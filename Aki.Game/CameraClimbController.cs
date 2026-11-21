using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;

// Token: 0x020001F7 RID: 503
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true, true, null)]
public class CameraClimbController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x06002022 RID: 8226 RVA: 0x000A55BA File Offset: 0x000A37BA
	public override string Name()
	{
		return "ClimbController";
	}

	// Token: 0x06002023 RID: 8227 RVA: 0x000A55C4 File Offset: 0x000A37C4
	protected override void OnInit()
	{
		base.SetConfigMap(EFightCameraClimb.退出攀爬淡出时间, "FadeOutDuration");
		base.SetConfigMap(EFightCameraClimb.无操作等待时间, "PrepTime");
		base.SetConfigMap(EFightCameraClimb.持续移动进入修正时间, "MoveDelayTime");
		base.SetConfigMap(EFightCameraClimb.镜头角度插值速度, "DefaultInterpSpeed");
		base.SetConfigMap(EFightCameraClimb.角色移动基准速度, "ReferToMoveSpeed");
		base.SetConfigMap(EFightCameraClimb.进入攀爬增加臂长, "AdditionalArmLength");
		base.SetConfigMap(EFightCameraClimb.进入攀爬修正时间, "FadeInCenterTime");
		base.SetConfigMap(EFightCameraClimb.进入攀爬淡出系数, "CenterStateBlendInExp");
		base.SetConfigMap(EFightCameraClimb.攀爬基准臂长, "DefaultArmLength");
		base.SetConfigMap(EFightCameraClimb.臂长插值速度, "ArmLengthSpeed");
		base.SetConfigMap(EFightCameraClimb.镜头预期朝向与角色移动方向夹角, "DesiredAngle");
		base.SetConfigMap(EFightCameraClimb.镜头预期朝向仰视角压缩倍率, "PitchUpRate");
		base.SetConfigMap(EFightCameraClimb.镜头预期朝向俯视角压缩倍率, "PitchDownRate");
		base.SetConfigMap(EFightCameraClimb.镜头预期朝向和角色面朝方向夹角合法范围, "ApplicableAngleWithCharacter");
		base.SetConfigMap(EFightCameraClimb.登顶镜头插值速度, "ReachThePeakSpeed");
		base.SetConfigMap(EFightCameraClimb.登顶镜头预期Pitch, "ReachThePeakPitch");
		base.SetConfigMap(EFightCameraClimb.大跨度输入角度阈值, "LargeAngleTurnThreshold");
		base.SetConfigMap(EFightCameraClimb.大跨度输入角度延迟响应时间, "LargeAngleTurnDelay");
		base.SetConfigMap(EFightCameraClimb.输入粘滞时间, "StopInputDelay");
		base.SetConfigMap(EFightCameraClimb.停止输入延迟响应时间, "StartInputDelay");
	}

	// Token: 0x06002024 RID: 8228 RVA: 0x000A5734 File Offset: 0x000A3934
	public CameraClimbController(FightCameraLogicComponent camera) : base(camera)
	{
		this.StateMachine = new StateMachine<CameraClimbController, CameraClimbController.ECameraState>(this, null);
		this.StateMachine.AddState<CameraClimbController.DefaultState>(CameraClimbController.ECameraState.Default, null);
		this.StateMachine.AddState<CameraClimbController.CenterState>(CameraClimbController.ECameraState.Center, null);
		this.StateMachine.AddState<CameraClimbController.ReadyState>(CameraClimbController.ECameraState.Ready, null);
		this.StateMachine.AddState<CameraClimbController.AdjustState>(CameraClimbController.ECameraState.Adjust, null);
		this.StateMachine.AddState<CameraClimbController.FadeOutState>(CameraClimbController.ECameraState.FadeOut, null);
		this.StateMachine.AddState<CameraClimbController.ReachThePeakState>(CameraClimbController.ECameraState.ReachThePeak, null);
		this.StateMachine.Start(CameraClimbController.ECameraState.Default);
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x000A5808 File Offset: 0x000A3A08
	protected override void OnEnable()
	{
		EExitClimb exitClimbType = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterClimbComponent>().GetExitClimbType();
		if (this.CheckReachThePeak(exitClimbType))
		{
			this.StateMachine.Switch(CameraClimbController.ECameraState.Default);
		}
		else
		{
			this.StateMachine.Switch(CameraClimbController.ECameraState.Center);
		}
		this.Camera.CameraAdjustController.Lock(this);
		this.Camera.CameraAutoController.Lock(this);
		this.Camera.CameraSidestepController.Lock(this);
		this.LastValidInput.Reset();
		this.NextChangeInputTime = (float)(Time.Instance.Now + (double)(this.StartInputDelay * (float)TimeUtil.Instance.InverseMillisecond));
		this.NextStopTime = 0f;
		this.IsMoving = false;
		EventSystem.Instance.Add<int, EExitClimb>(EEventName.CharClimbStartExit, new Action<int, EExitClimb>(this.OnCharClimbStartExit));
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x000A58E4 File Offset: 0x000A3AE4
	protected override void OnDisable()
	{
		this.Camera.CameraAdjustController.Unlock(this);
		this.Camera.CameraAutoController.Unlock(this);
		this.Camera.CameraSidestepController.Unlock(this);
		if (EventSystem.Instance.Has<int, EExitClimb>(EEventName.CharClimbStartExit, new Action<int, EExitClimb>(this.OnCharClimbStartExit)))
		{
			EventSystem.Instance.Remove<int, EExitClimb>(EEventName.CharClimbStartExit, new Action<int, EExitClimb>(this.OnCharClimbStartExit));
		}
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x000A5957 File Offset: 0x000A3B57
	protected override bool UpdateCustomEnableCondition()
	{
		return this.Camera.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"], false);
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x000A5974 File Offset: 0x000A3B74
	protected override void UpdateInternal(float deltaSeconds)
	{
		this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterInputComponent>().GetMoveVector(this.TmpVector);
		if (this.CheckStateMayChange(this.TmpVector))
		{
			if (Time.Instance.Now > (double)this.NextChangeInputTime)
			{
				this.LastValidInput.DeepCopy(this.TmpVector);
				this.TmpVector.Set(0.0, this.LastValidInput.Y, this.LastValidInput.X);
				this.Camera.Character.CharacterActorComponent.ActorQuatProxy.RotateVector(this.TmpVector, this.MoveDirection);
				this.IsMoving = true;
				float speed = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterMoveComponent>().Speed;
				this.ElapseTimeScale = ((speed > this.ReferToMoveSpeed) ? (speed / this.ReferToMoveSpeed) : 1f);
				this.NextChangeInputTime = (float)(Time.Instance.Now + (double)(this.LargeAngleTurnDelay * (float)TimeUtil.Instance.InverseMillisecond));
			}
			else if (this.IsMoving && Time.Instance.Now > (double)this.NextStopTime)
			{
				this.IsMoving = false;
				this.NextChangeInputTime = (float)(Time.Instance.Now + (double)(this.StartInputDelay * (float)TimeUtil.Instance.InverseMillisecond));
			}
		}
		else if (this.IsMoving)
		{
			float speed2 = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterMoveComponent>().Speed;
			this.ElapseTimeScale = ((speed2 > this.ReferToMoveSpeed) ? (speed2 / this.ReferToMoveSpeed) : 1f);
		}
		this.StateMachine.Update(deltaSeconds);
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x000A5B2C File Offset: 0x000A3D2C
	private bool CheckStateMayChange(Vector inputDirect)
	{
		bool flag = inputDirect.X != 0.0 || inputDirect.Y != 0.0;
		if (this.IsMoving)
		{
			if (flag)
			{
				this.NextStopTime = (float)(Time.Instance.Now + (double)(this.StopInputDelay * (float)TimeUtil.Instance.InverseMillisecond));
				if (this.LastValidInput.X * inputDirect.X + this.LastValidInput.Y * inputDirect.Y > Math.Cos((double)(this.LargeAngleTurnThreshold * 0.017453292f)))
				{
					this.NextChangeInputTime = (float)(Time.Instance.Now + (double)(this.LargeAngleTurnDelay * (float)TimeUtil.Instance.InverseMillisecond));
					float speed = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterMoveComponent>().Speed;
					this.ElapseTimeScale = ((speed > this.ReferToMoveSpeed) ? (speed / this.ReferToMoveSpeed) : 1f);
					return false;
				}
			}
			else
			{
				this.NextChangeInputTime = (float)(Time.Instance.Now + (double)(this.LargeAngleTurnDelay * (float)TimeUtil.Instance.InverseMillisecond));
			}
		}
		else
		{
			this.NextStopTime = (float)(Time.Instance.Now + (double)(this.StopInputDelay * (float)TimeUtil.Instance.InverseMillisecond));
			if (!flag)
			{
				this.NextChangeInputTime = (float)(Time.Instance.Now + (double)(this.StartInputDelay * (float)TimeUtil.Instance.InverseMillisecond));
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x000A5CAC File Offset: 0x000A3EAC
	public void UpdateInterp(float deltaTime, float interpSpeed, Vector moveDirection)
	{
		CameraUtility.GetVectorInGravity(this.Camera.Character.CharacterActorComponent.ActorForwardProxy, this.ActorForwardInGravity);
		CameraUtility.GetVectorInGravity(moveDirection, this.MoveDirectionInGravity);
		this.TmpVector.DeepCopy(this.ActorForwardInGravity);
		this.TmpVector2.DeepCopy(this.MoveDirectionInGravity);
		if (Math.Abs(Math.Acos(this.TmpVector.DotProduct(this.TmpVector2)) * 57.295780181884766) > (double)this.DesiredAngle)
		{
			this.TmpVector.CrossProduct(this.TmpVector2, this.TmpVector2);
			this.TmpVector2.CrossProduct(this.TmpVector, this.TmpVector2);
			float num = this.DesiredAngle * 0.017453292f;
			this.TmpVector.MultiplyEqual(Math.Cos((double)num));
			this.TmpVector2.MultiplyEqual(Math.Sin((double)num));
			this.TmpVector.AdditionEqual(this.TmpVector2);
		}
		else
		{
			this.TmpVector.DeepCopy(this.MoveDirectionInGravity);
		}
		if (this.Camera.IsInNormalGravityMode())
		{
			this.Camera.CurrentCamera.ArmRotation.Vector(this.TmpVector2);
		}
		else
		{
			CameraUtility.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.TmpRotator);
			this.TmpRotator.Vector(this.TmpVector2);
		}
		double num2 = this.TmpVector2.X * this.ActorForwardInGravity.Y - this.TmpVector2.Y * this.ActorForwardInGravity.X;
		double num3 = this.TmpVector2.X * this.TmpVector.Y - this.TmpVector2.Y * this.TmpVector.X;
		double num4 = this.TmpVector.X * this.ActorForwardInGravity.Y - this.TmpVector.Y * this.ActorForwardInGravity.X;
		bool invertYaw = num2 * num3 < 0.0 && num2 * num4 < 0.0;
		MathUtils.Instance.LerpDirect2dByMaxAngle(this.TmpVector2, this.TmpVector, (double)((this.TmpVector.Z < 0.0) ? this.PitchDownRate : this.PitchUpRate), (double)(deltaTime * interpSpeed * this.ElapseTimeScale), invertYaw, this.TmpVector);
		if (this.Camera.IsInNormalGravityMode())
		{
			Rotator armRotation = this.Camera.DesiredCamera.ArmRotation;
			MathUtils.Instance.LookRotationForwardFirst(this.TmpVector, Vector.UpVectorProxy, armRotation);
		}
		else
		{
			this.TmpVector.Rotation(this.TmpRotator);
			CameraUtility.SetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.TmpRotator);
		}
		this.Camera.IsModifiedArmRotationPitch = true;
		this.Camera.IsModifiedArmRotationYaw = true;
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x000A5F94 File Offset: 0x000A4194
	public void OnCharClimbStartExit(int charId, EExitClimb exitClimbType)
	{
		if (this.Camera.CharacterEntityHandle.Id == charId && this.CheckReachThePeak(exitClimbType))
		{
			if (this.StateMachine.CurrentState.GetValueOrDefault() == CameraClimbController.ECameraState.Adjust)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.ReachThePeak);
				return;
			}
			if (this.StateMachine.CurrentState.GetValueOrDefault() == CameraClimbController.ECameraState.Center)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Default);
			}
		}
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x000A6004 File Offset: 0x000A4204
	private bool CheckReachThePeak(EExitClimb exitClimbType)
	{
		return exitClimbType == EExitClimb.到顶退出 || exitClimbType - EExitClimb.地面登上 <= 2;
	}

	// Token: 0x0600202D RID: 8237 RVA: 0x000A6022 File Offset: 0x000A4222
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x0600202E RID: 8238 RVA: 0x000A602C File Offset: 0x000A422C
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 8:
			{
				char c = key[0];
				if (c != 'I')
				{
					if (c == 'P')
					{
						if (key == "PrepTime")
						{
							value = this.PrepTime;
							return true;
						}
					}
				}
				else if (key == "IsMoving")
				{
					value = this.IsMoving;
					return true;
				}
				break;
			}
			case 9:
				if (key == "TmpVector")
				{
					value = this.TmpVector;
					return true;
				}
				break;
			case 10:
			{
				char c = key[3];
				if (c != 'R')
				{
					if (c == 'V')
					{
						if (key == "TmpVector2")
						{
							value = this.TmpVector2;
							return true;
						}
					}
				}
				else if (key == "TmpRotator")
				{
					value = this.TmpRotator;
					return true;
				}
				break;
			}
			case 11:
				if (key == "PitchUpRate")
				{
					value = this.PitchUpRate;
					return true;
				}
				break;
			case 12:
			{
				char c = key[0];
				if (c != 'D')
				{
					if (c != 'N')
					{
						if (c == 'S')
						{
							if (key == "StateMachine")
							{
								value = this.StateMachine;
								return true;
							}
						}
					}
					else if (key == "NextStopTime")
					{
						value = this.NextStopTime;
						return true;
					}
				}
				else if (key == "DesiredAngle")
				{
					value = this.DesiredAngle;
					return true;
				}
				break;
			}
			case 13:
			{
				char c = key[5];
				if (c != 'D')
				{
					if (c != 'e')
					{
						if (c == 'i')
						{
							if (key == "MoveDirection")
							{
								value = this.MoveDirection;
								return true;
							}
						}
					}
					else if (key == "MoveDelayTime")
					{
						value = this.MoveDelayTime;
						return true;
					}
				}
				else if (key == "PitchDownRate")
				{
					value = this.PitchDownRate;
					return true;
				}
				break;
			}
			case 14:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c != 'L')
					{
						if (c == 'S')
						{
							if (key == "StopInputDelay")
							{
								value = this.StopInputDelay;
								return true;
							}
						}
					}
					else if (key == "LastValidInput")
					{
						value = this.LastValidInput;
						return true;
					}
				}
				else if (key == "ArmLengthSpeed")
				{
					value = this.ArmLengthSpeed;
					return true;
				}
				break;
			}
			case 15:
			{
				char c = key[0];
				if (c != 'E')
				{
					if (c != 'F')
					{
						if (c == 'S')
						{
							if (key == "StartInputDelay")
							{
								value = this.StartInputDelay;
								return true;
							}
						}
					}
					else if (key == "FadeOutDuration")
					{
						value = this.FadeOutDuration;
						return true;
					}
				}
				else if (key == "ElapseTimeScale")
				{
					value = this.ElapseTimeScale;
					return true;
				}
				break;
			}
			case 16:
			{
				char c = key[0];
				if (c != 'D')
				{
					if (c != 'F')
					{
						if (c == 'R')
						{
							if (key == "ReferToMoveSpeed")
							{
								value = this.ReferToMoveSpeed;
								return true;
							}
						}
					}
					else if (key == "FadeInCenterTime")
					{
						value = this.FadeInCenterTime;
						return true;
					}
				}
				else if (key == "DefaultArmLength")
				{
					value = this.DefaultArmLength;
					return true;
				}
				break;
			}
			case 17:
			{
				char c = key[12];
				if (c != 'P')
				{
					if (c == 'S')
					{
						if (key == "ReachThePeakSpeed")
						{
							value = this.ReachThePeakSpeed;
							return true;
						}
					}
				}
				else if (key == "ReachThePeakPitch")
				{
					value = this.ReachThePeakPitch;
					return true;
				}
				break;
			}
			case 18:
				if (key == "DefaultInterpSpeed")
				{
					value = this.DefaultInterpSpeed;
					return true;
				}
				break;
			case 19:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c != 'L')
					{
						if (c == 'N')
						{
							if (key == "NextChangeInputTime")
							{
								value = this.NextChangeInputTime;
								return true;
							}
						}
					}
					else if (key == "LargeAngleTurnDelay")
					{
						value = this.LargeAngleTurnDelay;
						return true;
					}
				}
				else if (key == "AdditionalArmLength")
				{
					value = this.AdditionalArmLength;
					return true;
				}
				break;
			}
			case 21:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c == 'C')
					{
						if (key == "CenterStateBlendInExp")
						{
							value = this.CenterStateBlendInExp;
							return true;
						}
					}
				}
				else if (key == "ActorForwardInGravity")
				{
					value = this.ActorForwardInGravity;
					return true;
				}
				break;
			}
			case 22:
				if (key == "MoveDirectionInGravity")
				{
					value = this.MoveDirectionInGravity;
					return true;
				}
				break;
			case 23:
				if (key == "LargeAngleTurnThreshold")
				{
					value = this.LargeAngleTurnThreshold;
					return true;
				}
				break;
			case 28:
				if (key == "ApplicableAngleWithCharacter")
				{
					value = this.ApplicableAngleWithCharacter;
					return true;
				}
				break;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x000A665C File Offset: 0x000A485C
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 8:
			{
				char c = key[0];
				if (c != 'I')
				{
					if (c == 'P')
					{
						if (key == "PrepTime")
						{
							float num2;
							if (value is double)
							{
								double num = (double)value;
								num2 = (float)num;
							}
							else if (value is float)
							{
								float num3 = (float)value;
								num2 = num3;
							}
							else if (value is int)
							{
								int num4 = (int)value;
								num2 = (float)num4;
							}
							else if (value is long)
							{
								long num5 = (long)value;
								num2 = (float)num5;
							}
							else
							{
								num2 = (float)value;
							}
							this.PrepTime = num2;
							return;
						}
					}
				}
				else if (key == "IsMoving")
				{
					this.IsMoving = (bool)value;
					return;
				}
				break;
			}
			case 11:
				if (key == "PitchUpRate")
				{
					float num2;
					if (value is double)
					{
						double num6 = (double)value;
						num2 = (float)num6;
					}
					else if (value is float)
					{
						float num7 = (float)value;
						num2 = num7;
					}
					else if (value is int)
					{
						int num8 = (int)value;
						num2 = (float)num8;
					}
					else if (value is long)
					{
						long num9 = (long)value;
						num2 = (float)num9;
					}
					else
					{
						num2 = (float)value;
					}
					this.PitchUpRate = num2;
					return;
				}
				break;
			case 12:
			{
				char c = key[0];
				if (c != 'D')
				{
					if (c == 'N')
					{
						if (key == "NextStopTime")
						{
							float num2;
							if (value is double)
							{
								double num10 = (double)value;
								num2 = (float)num10;
							}
							else if (value is float)
							{
								float num11 = (float)value;
								num2 = num11;
							}
							else if (value is int)
							{
								int num12 = (int)value;
								num2 = (float)num12;
							}
							else if (value is long)
							{
								long num13 = (long)value;
								num2 = (float)num13;
							}
							else
							{
								num2 = (float)value;
							}
							this.NextStopTime = num2;
							return;
						}
					}
				}
				else if (key == "DesiredAngle")
				{
					float num2;
					if (value is double)
					{
						double num14 = (double)value;
						num2 = (float)num14;
					}
					else if (value is float)
					{
						float num15 = (float)value;
						num2 = num15;
					}
					else if (value is int)
					{
						int num16 = (int)value;
						num2 = (float)num16;
					}
					else if (value is long)
					{
						long num17 = (long)value;
						num2 = (float)num17;
					}
					else
					{
						num2 = (float)value;
					}
					this.DesiredAngle = num2;
					return;
				}
				break;
			}
			case 13:
			{
				char c = key[0];
				if (c != 'M')
				{
					if (c == 'P')
					{
						if (key == "PitchDownRate")
						{
							float num2;
							if (value is double)
							{
								double num18 = (double)value;
								num2 = (float)num18;
							}
							else if (value is float)
							{
								float num19 = (float)value;
								num2 = num19;
							}
							else if (value is int)
							{
								int num20 = (int)value;
								num2 = (float)num20;
							}
							else if (value is long)
							{
								long num21 = (long)value;
								num2 = (float)num21;
							}
							else
							{
								num2 = (float)value;
							}
							this.PitchDownRate = num2;
							return;
						}
					}
				}
				else if (key == "MoveDelayTime")
				{
					float num2;
					if (value is double)
					{
						double num22 = (double)value;
						num2 = (float)num22;
					}
					else if (value is float)
					{
						float num23 = (float)value;
						num2 = num23;
					}
					else if (value is int)
					{
						int num24 = (int)value;
						num2 = (float)num24;
					}
					else if (value is long)
					{
						long num25 = (long)value;
						num2 = (float)num25;
					}
					else
					{
						num2 = (float)value;
					}
					this.MoveDelayTime = num2;
					return;
				}
				break;
			}
			case 14:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c == 'S')
					{
						if (key == "StopInputDelay")
						{
							float num2;
							if (value is double)
							{
								double num26 = (double)value;
								num2 = (float)num26;
							}
							else if (value is float)
							{
								float num27 = (float)value;
								num2 = num27;
							}
							else if (value is int)
							{
								int num28 = (int)value;
								num2 = (float)num28;
							}
							else if (value is long)
							{
								long num29 = (long)value;
								num2 = (float)num29;
							}
							else
							{
								num2 = (float)value;
							}
							this.StopInputDelay = num2;
							return;
						}
					}
				}
				else if (key == "ArmLengthSpeed")
				{
					float num2;
					if (value is double)
					{
						double num30 = (double)value;
						num2 = (float)num30;
					}
					else if (value is float)
					{
						float num31 = (float)value;
						num2 = num31;
					}
					else if (value is int)
					{
						int num32 = (int)value;
						num2 = (float)num32;
					}
					else if (value is long)
					{
						long num33 = (long)value;
						num2 = (float)num33;
					}
					else
					{
						num2 = (float)value;
					}
					this.ArmLengthSpeed = num2;
					return;
				}
				break;
			}
			case 15:
			{
				char c = key[0];
				if (c != 'E')
				{
					if (c != 'F')
					{
						if (c == 'S')
						{
							if (key == "StartInputDelay")
							{
								float num2;
								if (value is double)
								{
									double num34 = (double)value;
									num2 = (float)num34;
								}
								else if (value is float)
								{
									float num35 = (float)value;
									num2 = num35;
								}
								else if (value is int)
								{
									int num36 = (int)value;
									num2 = (float)num36;
								}
								else if (value is long)
								{
									long num37 = (long)value;
									num2 = (float)num37;
								}
								else
								{
									num2 = (float)value;
								}
								this.StartInputDelay = num2;
								return;
							}
						}
					}
					else if (key == "FadeOutDuration")
					{
						float num2;
						if (value is double)
						{
							double num38 = (double)value;
							num2 = (float)num38;
						}
						else if (value is float)
						{
							float num39 = (float)value;
							num2 = num39;
						}
						else if (value is int)
						{
							int num40 = (int)value;
							num2 = (float)num40;
						}
						else if (value is long)
						{
							long num41 = (long)value;
							num2 = (float)num41;
						}
						else
						{
							num2 = (float)value;
						}
						this.FadeOutDuration = num2;
						return;
					}
				}
				else if (key == "ElapseTimeScale")
				{
					float num2;
					if (value is double)
					{
						double num42 = (double)value;
						num2 = (float)num42;
					}
					else if (value is float)
					{
						float num43 = (float)value;
						num2 = num43;
					}
					else if (value is int)
					{
						int num44 = (int)value;
						num2 = (float)num44;
					}
					else if (value is long)
					{
						long num45 = (long)value;
						num2 = (float)num45;
					}
					else
					{
						num2 = (float)value;
					}
					this.ElapseTimeScale = num2;
					return;
				}
				break;
			}
			case 16:
			{
				char c = key[0];
				if (c != 'D')
				{
					if (c != 'F')
					{
						if (c == 'R')
						{
							if (key == "ReferToMoveSpeed")
							{
								float num2;
								if (value is double)
								{
									double num46 = (double)value;
									num2 = (float)num46;
								}
								else if (value is float)
								{
									float num47 = (float)value;
									num2 = num47;
								}
								else if (value is int)
								{
									int num48 = (int)value;
									num2 = (float)num48;
								}
								else if (value is long)
								{
									long num49 = (long)value;
									num2 = (float)num49;
								}
								else
								{
									num2 = (float)value;
								}
								this.ReferToMoveSpeed = num2;
								return;
							}
						}
					}
					else if (key == "FadeInCenterTime")
					{
						float num2;
						if (value is double)
						{
							double num50 = (double)value;
							num2 = (float)num50;
						}
						else if (value is float)
						{
							float num51 = (float)value;
							num2 = num51;
						}
						else if (value is int)
						{
							int num52 = (int)value;
							num2 = (float)num52;
						}
						else if (value is long)
						{
							long num53 = (long)value;
							num2 = (float)num53;
						}
						else
						{
							num2 = (float)value;
						}
						this.FadeInCenterTime = num2;
						return;
					}
				}
				else if (key == "DefaultArmLength")
				{
					float num2;
					if (value is double)
					{
						double num54 = (double)value;
						num2 = (float)num54;
					}
					else if (value is float)
					{
						float num55 = (float)value;
						num2 = num55;
					}
					else if (value is int)
					{
						int num56 = (int)value;
						num2 = (float)num56;
					}
					else if (value is long)
					{
						long num57 = (long)value;
						num2 = (float)num57;
					}
					else
					{
						num2 = (float)value;
					}
					this.DefaultArmLength = num2;
					return;
				}
				break;
			}
			case 17:
			{
				char c = key[12];
				if (c != 'P')
				{
					if (c == 'S')
					{
						if (key == "ReachThePeakSpeed")
						{
							float num2;
							if (value is double)
							{
								double num58 = (double)value;
								num2 = (float)num58;
							}
							else if (value is float)
							{
								float num59 = (float)value;
								num2 = num59;
							}
							else if (value is int)
							{
								int num60 = (int)value;
								num2 = (float)num60;
							}
							else if (value is long)
							{
								long num61 = (long)value;
								num2 = (float)num61;
							}
							else
							{
								num2 = (float)value;
							}
							this.ReachThePeakSpeed = num2;
							return;
						}
					}
				}
				else if (key == "ReachThePeakPitch")
				{
					float num2;
					if (value is double)
					{
						double num62 = (double)value;
						num2 = (float)num62;
					}
					else if (value is float)
					{
						float num63 = (float)value;
						num2 = num63;
					}
					else if (value is int)
					{
						int num64 = (int)value;
						num2 = (float)num64;
					}
					else if (value is long)
					{
						long num65 = (long)value;
						num2 = (float)num65;
					}
					else
					{
						num2 = (float)value;
					}
					this.ReachThePeakPitch = num2;
					return;
				}
				break;
			}
			case 18:
				if (key == "DefaultInterpSpeed")
				{
					float num2;
					if (value is double)
					{
						double num66 = (double)value;
						num2 = (float)num66;
					}
					else if (value is float)
					{
						float num67 = (float)value;
						num2 = num67;
					}
					else if (value is int)
					{
						int num68 = (int)value;
						num2 = (float)num68;
					}
					else if (value is long)
					{
						long num69 = (long)value;
						num2 = (float)num69;
					}
					else
					{
						num2 = (float)value;
					}
					this.DefaultInterpSpeed = num2;
					return;
				}
				break;
			case 19:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c != 'L')
					{
						if (c == 'N')
						{
							if (key == "NextChangeInputTime")
							{
								float num2;
								if (value is double)
								{
									double num70 = (double)value;
									num2 = (float)num70;
								}
								else if (value is float)
								{
									float num71 = (float)value;
									num2 = num71;
								}
								else if (value is int)
								{
									int num72 = (int)value;
									num2 = (float)num72;
								}
								else if (value is long)
								{
									long num73 = (long)value;
									num2 = (float)num73;
								}
								else
								{
									num2 = (float)value;
								}
								this.NextChangeInputTime = num2;
								return;
							}
						}
					}
					else if (key == "LargeAngleTurnDelay")
					{
						float num2;
						if (value is double)
						{
							double num74 = (double)value;
							num2 = (float)num74;
						}
						else if (value is float)
						{
							float num75 = (float)value;
							num2 = num75;
						}
						else if (value is int)
						{
							int num76 = (int)value;
							num2 = (float)num76;
						}
						else if (value is long)
						{
							long num77 = (long)value;
							num2 = (float)num77;
						}
						else
						{
							num2 = (float)value;
						}
						this.LargeAngleTurnDelay = num2;
						return;
					}
				}
				else if (key == "AdditionalArmLength")
				{
					float num2;
					if (value is double)
					{
						double num78 = (double)value;
						num2 = (float)num78;
					}
					else if (value is float)
					{
						float num79 = (float)value;
						num2 = num79;
					}
					else if (value is int)
					{
						int num80 = (int)value;
						num2 = (float)num80;
					}
					else if (value is long)
					{
						long num81 = (long)value;
						num2 = (float)num81;
					}
					else
					{
						num2 = (float)value;
					}
					this.AdditionalArmLength = num2;
					return;
				}
				break;
			}
			case 21:
				if (key == "CenterStateBlendInExp")
				{
					float num2;
					if (value is double)
					{
						double num82 = (double)value;
						num2 = (float)num82;
					}
					else if (value is float)
					{
						float num83 = (float)value;
						num2 = num83;
					}
					else if (value is int)
					{
						int num84 = (int)value;
						num2 = (float)num84;
					}
					else if (value is long)
					{
						long num85 = (long)value;
						num2 = (float)num85;
					}
					else
					{
						num2 = (float)value;
					}
					this.CenterStateBlendInExp = num2;
					return;
				}
				break;
			case 23:
				if (key == "LargeAngleTurnThreshold")
				{
					float num2;
					if (value is double)
					{
						double num86 = (double)value;
						num2 = (float)num86;
					}
					else if (value is float)
					{
						float num87 = (float)value;
						num2 = num87;
					}
					else if (value is int)
					{
						int num88 = (int)value;
						num2 = (float)num88;
					}
					else if (value is long)
					{
						long num89 = (long)value;
						num2 = (float)num89;
					}
					else
					{
						num2 = (float)value;
					}
					this.LargeAngleTurnThreshold = num2;
					return;
				}
				break;
			case 28:
				if (key == "ApplicableAngleWithCharacter")
				{
					float num2;
					if (value is double)
					{
						double num90 = (double)value;
						num2 = (float)num90;
					}
					else if (value is float)
					{
						float num91 = (float)value;
						num2 = num91;
					}
					else if (value is int)
					{
						int num92 = (int)value;
						num2 = (float)num92;
					}
					else if (value is long)
					{
						long num93 = (long)value;
						num2 = (float)num93;
					}
					else
					{
						num2 = (float)value;
					}
					this.ApplicableAngleWithCharacter = num2;
					return;
				}
				break;
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x000A7464 File Offset: 0x000A5664
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraClimbController.<MemberIter>d__54 <MemberIter>d__ = new CameraClimbController.<MemberIter>d__54(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x04001370 RID: 4976
	public const bool IsDebug = false;

	// Token: 0x04001371 RID: 4977
	public float FadeOutDuration;

	// Token: 0x04001372 RID: 4978
	public float PrepTime;

	// Token: 0x04001373 RID: 4979
	public float MoveDelayTime;

	// Token: 0x04001374 RID: 4980
	public float DefaultInterpSpeed;

	// Token: 0x04001375 RID: 4981
	public float ReferToMoveSpeed;

	// Token: 0x04001376 RID: 4982
	public float AdditionalArmLength;

	// Token: 0x04001377 RID: 4983
	public float FadeInCenterTime;

	// Token: 0x04001378 RID: 4984
	public float CenterStateBlendInExp;

	// Token: 0x04001379 RID: 4985
	public float DefaultArmLength;

	// Token: 0x0400137A RID: 4986
	public float ArmLengthSpeed;

	// Token: 0x0400137B RID: 4987
	public float DesiredAngle;

	// Token: 0x0400137C RID: 4988
	public float PitchUpRate;

	// Token: 0x0400137D RID: 4989
	public float PitchDownRate;

	// Token: 0x0400137E RID: 4990
	public float ApplicableAngleWithCharacter;

	// Token: 0x0400137F RID: 4991
	public float StopInputDelay;

	// Token: 0x04001380 RID: 4992
	public float ReachThePeakSpeed;

	// Token: 0x04001381 RID: 4993
	public float ReachThePeakPitch;

	// Token: 0x04001382 RID: 4994
	public float LargeAngleTurnThreshold;

	// Token: 0x04001383 RID: 4995
	public float LargeAngleTurnDelay;

	// Token: 0x04001384 RID: 4996
	public float StartInputDelay;

	// Token: 0x04001385 RID: 4997
	public float ElapseTimeScale = 1f;

	// Token: 0x04001386 RID: 4998
	public bool IsMoving;

	// Token: 0x04001387 RID: 4999
	private readonly Vector LastValidInput = Vector.Create();

	// Token: 0x04001388 RID: 5000
	private float NextChangeInputTime;

	// Token: 0x04001389 RID: 5001
	private float NextStopTime;

	// Token: 0x0400138A RID: 5002
	public readonly Vector MoveDirection = Vector.Create();

	// Token: 0x0400138B RID: 5003
	private readonly StateMachine<CameraClimbController, CameraClimbController.ECameraState> StateMachine;

	// Token: 0x0400138C RID: 5004
	private readonly Vector ActorForwardInGravity = Vector.Create();

	// Token: 0x0400138D RID: 5005
	private readonly Vector MoveDirectionInGravity = Vector.Create();

	// Token: 0x0400138E RID: 5006
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400138F RID: 5007
	private readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04001390 RID: 5008
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x020065A9 RID: 26025
	[NullableContext(0)]
	public enum ECameraState
	{
		// Token: 0x04021AC1 RID: 137921
		Default,
		// Token: 0x04021AC2 RID: 137922
		Center,
		// Token: 0x04021AC3 RID: 137923
		Ready,
		// Token: 0x04021AC4 RID: 137924
		Adjust,
		// Token: 0x04021AC5 RID: 137925
		FadeOut,
		// Token: 0x04021AC6 RID: 137926
		ReachThePeak
	}

	// Token: 0x020065AA RID: 26026
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DefaultState : StateBase<CameraClimbController, CameraClimbController.ECameraState>
	{
		// Token: 0x0603EBEC RID: 257004 RVA: 0x01246B4B File Offset: 0x01244D4B
		public DefaultState(CameraClimbController owner, CameraClimbController.ECameraState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CameraClimbController, CameraClimbController.ECameraState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603EBED RID: 257005 RVA: 0x01246B56 File Offset: 0x01244D56
		protected override void OnEnter(CameraClimbController.ECameraState? stat)
		{
			this.ElapseTime = 0f;
		}

		// Token: 0x0603EBEE RID: 257006 RVA: 0x01246B63 File Offset: 0x01244D63
		protected override void OnUpdate(float delta)
		{
			this.ElapseTime += delta * this.Owner.ElapseTimeScale;
			if (this.ElapseTime > this.Owner.PrepTime)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Ready);
			}
		}

		// Token: 0x04021AC7 RID: 137927
		private float ElapseTime;
	}

	// Token: 0x020065AB RID: 26027
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CenterState : StateBase<CameraClimbController, CameraClimbController.ECameraState>
	{
		// Token: 0x0603EBEF RID: 257007 RVA: 0x01246B9F File Offset: 0x01244D9F
		public CenterState(CameraClimbController owner, CameraClimbController.ECameraState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CameraClimbController, CameraClimbController.ECameraState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603EBF0 RID: 257008 RVA: 0x01246BCB File Offset: 0x01244DCB
		public override bool CanReEnter()
		{
			return true;
		}

		// Token: 0x0603EBF1 RID: 257009 RVA: 0x01246BD0 File Offset: 0x01244DD0
		protected override void OnReEnter()
		{
			this.OnEnter(null);
		}

		// Token: 0x0603EBF2 RID: 257010 RVA: 0x01246BEC File Offset: 0x01244DEC
		protected override void OnEnter(CameraClimbController.ECameraState? state)
		{
			if (this.Owner.Camera.IsInNormalGravityMode())
			{
				this.StartRotator.DeepCopy(this.Owner.Camera.CurrentCamera.ArmRotation);
				this.DesiredRotator.DeepCopy(this.Owner.Camera.PlayerRotator);
			}
			else
			{
				CameraUtility.GetRotatorInGravity(this.Owner.Camera.CurrentCamera.ArmRotation, this.StartRotator);
				this.DesiredRotator.DeepCopy(this.Owner.Camera.PlayerRotatorInGravity);
			}
			this.ElapseTime = 0f;
		}

		// Token: 0x0603EBF3 RID: 257011 RVA: 0x01246C90 File Offset: 0x01244E90
		protected override void OnUpdate(float delta)
		{
			if (this.Owner.Camera.IsModifiedArmRotationPitch || this.Owner.Camera.IsModifiedArmRotationYaw)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Default);
				return;
			}
			float num = delta / this.Owner.FadeInCenterTime * this.Owner.AdditionalArmLength * this.Owner.ElapseTimeScale;
			this.Owner.Camera.DesiredCamera.ArmLength = this.Owner.Camera.CurrentCamera.ArmLength + num;
			this.Owner.Camera.IsModifiedArmLength = true;
			this.ElapseTime += delta;
			float alpha = this.ElapseTime / this.Owner.FadeInCenterTime;
			alpha = (float)MathUtils.Instance.BlendEaseIn(0.0, 1.0, alpha, (double)this.Owner.CenterStateBlendInExp);
			Rotator.Lerp(this.StartRotator, this.DesiredRotator, alpha, this.TmpRotator);
			if (this.Owner.Camera.IsInNormalGravityMode())
			{
				this.Owner.Camera.DesiredCamera.ArmRotation.DeepCopy(this.TmpRotator);
			}
			else
			{
				CameraUtility.SetRotatorInGravity(this.Owner.Camera.DesiredCamera.ArmRotation, this.TmpRotator);
			}
			this.Owner.Camera.IsModifiedArmRotationPitch = true;
			this.Owner.Camera.IsModifiedArmRotationYaw = true;
			if (this.ElapseTime > this.Owner.FadeInCenterTime)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Ready);
			}
		}

		// Token: 0x04021AC8 RID: 137928
		private readonly Rotator StartRotator = Rotator.Create();

		// Token: 0x04021AC9 RID: 137929
		private readonly Rotator DesiredRotator = Rotator.Create();

		// Token: 0x04021ACA RID: 137930
		private float ElapseTime;

		// Token: 0x04021ACB RID: 137931
		private readonly Rotator TmpRotator = Rotator.Create();
	}

	// Token: 0x020065AC RID: 26028
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ReadyState : StateBase<CameraClimbController, CameraClimbController.ECameraState>
	{
		// Token: 0x0603EBF4 RID: 257012 RVA: 0x01246E2D File Offset: 0x0124502D
		public ReadyState(CameraClimbController owner, CameraClimbController.ECameraState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CameraClimbController, CameraClimbController.ECameraState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603EBF5 RID: 257013 RVA: 0x01246E38 File Offset: 0x01245038
		protected override void OnEnter(CameraClimbController.ECameraState? lastState)
		{
			this.ElapseTime = 0f;
		}

		// Token: 0x0603EBF6 RID: 257014 RVA: 0x01246E48 File Offset: 0x01245048
		protected override void OnUpdate(float delta)
		{
			if (this.Owner.Camera.IsModifiedArmRotationPitch || this.Owner.Camera.IsModifiedArmRotationYaw)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Default);
				return;
			}
			if (!this.Owner.IsMoving)
			{
				this.ElapseTime = 0f;
				return;
			}
			this.ElapseTime += delta * this.Owner.ElapseTimeScale;
			if (this.ElapseTime > this.Owner.MoveDelayTime)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Adjust);
			}
		}

		// Token: 0x04021ACC RID: 137932
		private float ElapseTime;
	}

	// Token: 0x020065AD RID: 26029
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AdjustState : StateBase<CameraClimbController, CameraClimbController.ECameraState>
	{
		// Token: 0x0603EBF7 RID: 257015 RVA: 0x01246EDA File Offset: 0x012450DA
		public AdjustState(CameraClimbController owner, CameraClimbController.ECameraState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CameraClimbController, CameraClimbController.ECameraState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603EBF8 RID: 257016 RVA: 0x01246EFB File Offset: 0x012450FB
		protected override void OnEnter(CameraClimbController.ECameraState? lastState)
		{
			this.Applicable = false;
		}

		// Token: 0x0603EBF9 RID: 257017 RVA: 0x01246F04 File Offset: 0x01245104
		protected override void OnUpdate(float delta)
		{
			if (this.Owner.Camera.IsModifiedArmRotationPitch || this.Owner.Camera.IsModifiedArmRotationYaw)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Default);
				return;
			}
			if (!this.Owner.IsMoving)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.FadeOut);
				return;
			}
			this.Owner.Camera.PlayerRotator.Vector(this.PlayerFacing);
			this.Owner.UpdateInterp(delta, this.Owner.DefaultInterpSpeed, this.Owner.MoveDirection);
			this.Owner.Camera.DesiredCamera.ArmRotation.Vector(this.CameraFacing);
			if (!this.Owner.Camera.IsInNormalGravityMode())
			{
				CameraUtility.GetVectorInGravity(this.PlayerFacing, this.PlayerFacing);
				CameraUtility.GetVectorInGravity(this.CameraFacing, this.CameraFacing);
			}
			bool flag = Math.Abs(Math.Acos(Vector.DotProduct(this.PlayerFacing, this.CameraFacing)) * 57.295780181884766) <= (double)this.Owner.ApplicableAngleWithCharacter;
			if (!flag && this.Applicable)
			{
				Vector vector = Vector.Create();
				this.PlayerFacing.CrossProduct(this.CameraFacing, vector);
				Vector vector2 = Vector.Create();
				if (vector.Normalize(9.99999993922529E-09))
				{
					this.PlayerFacing.RotateAngleAxis((double)this.Owner.ApplicableAngleWithCharacter, vector, vector2);
				}
				else
				{
					vector2.DeepCopy(this.PlayerFacing);
				}
				vector2.Rotation(this.Owner.Camera.DesiredCamera.ArmRotation);
				this.Owner.Camera.IsModifiedArmRotationPitch = true;
				this.Owner.Camera.IsModifiedArmRotationYaw = true;
				this.Applicable = true;
			}
			else
			{
				this.Applicable = flag;
			}
			if (!MathUtils.Instance.IsNearlyEqual((double)this.Owner.Camera.CurrentCamera.ArmLength, (double)this.Owner.DefaultArmLength, null))
			{
				float num = this.Owner.DefaultArmLength - this.Owner.Camera.CurrentCamera.ArmLength;
				float num2 = this.Owner.ArmLengthSpeed * delta;
				if (Math.Abs(num2) > Math.Abs(num))
				{
					this.Owner.Camera.DesiredCamera.ArmLength = this.Owner.DefaultArmLength;
				}
				else
				{
					num2 = ((num > 0f) ? num2 : (-num2));
					this.Owner.Camera.DesiredCamera.ArmLength = this.Owner.Camera.CurrentCamera.ArmLength + num2;
				}
				this.Owner.Camera.IsModifiedArmLength = true;
			}
		}

		// Token: 0x04021ACD RID: 137933
		private bool Applicable;

		// Token: 0x04021ACE RID: 137934
		private readonly Vector PlayerFacing = Vector.Create();

		// Token: 0x04021ACF RID: 137935
		private readonly Vector CameraFacing = Vector.Create();
	}

	// Token: 0x020065AE RID: 26030
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FadeOutState : StateBase<CameraClimbController, CameraClimbController.ECameraState>
	{
		// Token: 0x0603EBFA RID: 257018 RVA: 0x012471CA File Offset: 0x012453CA
		public FadeOutState(CameraClimbController owner, CameraClimbController.ECameraState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CameraClimbController, CameraClimbController.ECameraState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603EBFB RID: 257019 RVA: 0x012471D5 File Offset: 0x012453D5
		protected override void OnEnter(CameraClimbController.ECameraState? state)
		{
			this.ElapseTime = 0f;
		}

		// Token: 0x0603EBFC RID: 257020 RVA: 0x012471E4 File Offset: 0x012453E4
		protected override void OnUpdate(float delta)
		{
			if (this.Owner.Camera.IsModifiedArmRotationPitch || this.Owner.Camera.IsModifiedArmRotationYaw)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Default);
				return;
			}
			if (this.Owner.IsMoving)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Adjust);
				return;
			}
			if (this.ElapseTime >= this.Owner.FadeOutDuration)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Ready);
				return;
			}
			this.ElapseTime += delta;
			float interpSpeed = MathUtils.Instance.RangeClamp(this.ElapseTime, 0f, this.Owner.FadeOutDuration, this.Owner.DefaultInterpSpeed, 0f);
			this.Owner.UpdateInterp(delta, interpSpeed, this.Owner.MoveDirection);
		}

		// Token: 0x04021AD0 RID: 137936
		private float ElapseTime;
	}

	// Token: 0x020065AF RID: 26031
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ReachThePeakState : StateBase<CameraClimbController, CameraClimbController.ECameraState>
	{
		// Token: 0x0603EBFD RID: 257021 RVA: 0x012472B6 File Offset: 0x012454B6
		public ReachThePeakState(CameraClimbController owner, CameraClimbController.ECameraState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CameraClimbController, CameraClimbController.ECameraState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603EBFE RID: 257022 RVA: 0x012472D8 File Offset: 0x012454D8
		protected override void OnEnter(CameraClimbController.ECameraState? state)
		{
			this.TargetRotator.DeepCopy(this.Owner.Camera.PlayerRotator);
			this.TargetRotator.Pitch = this.Owner.ReachThePeakPitch;
			this.TargetRotator.Vector(this.TargetLookAt);
		}

		// Token: 0x0603EBFF RID: 257023 RVA: 0x01247328 File Offset: 0x01245528
		protected override void OnUpdate(float delta)
		{
			if (this.Owner.Camera.IsModifiedArmRotationPitch || this.Owner.Camera.IsModifiedArmRotationYaw)
			{
				this.StateMachine.Switch(CameraClimbController.ECameraState.Default);
				return;
			}
			this.Owner.UpdateInterp(delta, this.Owner.ReachThePeakSpeed, this.TargetLookAt);
		}

		// Token: 0x04021AD1 RID: 137937
		private readonly Vector TargetLookAt = Vector.Create();

		// Token: 0x04021AD2 RID: 137938
		private readonly Rotator TargetRotator = Rotator.Create();
	}
}
