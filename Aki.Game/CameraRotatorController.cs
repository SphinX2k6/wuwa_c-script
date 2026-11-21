using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;

// Token: 0x02000222 RID: 546
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true, true, null)]
public class CameraRotatorController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x060021E0 RID: 8672 RVA: 0x000C4BC0 File Offset: 0x000C2DC0
	public CameraRotatorController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x060021E1 RID: 8673 RVA: 0x000C4C12 File Offset: 0x000C2E12
	public override string Name()
	{
		return "RotatorController";
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x000C4C1C File Offset: 0x000C2E1C
	public void PlayCameraRotator(Vector lookAt1, Vector lookAt2, Rotator addRotator, float time, bool canBreakByInput = true, float stayTime = 0f)
	{
		this.BeginCameraRotator(lookAt1, lookAt2, addRotator, time, stayTime, 0f, 1f, canBreakByInput, null);
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x000C4C44 File Offset: 0x000C2E44
	public void PlayCameraRotatorWithCurve(Vector lookAt1, Vector lookAt2, Rotator addRotator, float time, float minAlpha, float maxAlpha, CurveBase curve, bool canBreakByInput = true, float stayTime = 0f, [Nullable(2)] Action callback = null)
	{
		this.RotatorAlphaCurve = curve;
		this.BeginCameraRotator(lookAt1, lookAt2, addRotator, time, stayTime, minAlpha, maxAlpha, canBreakByInput, callback);
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x000C4C6E File Offset: 0x000C2E6E
	public void PlayCameraEulerRotator(Rotator desRotator, float time, bool canBreakByInput = true, float stayTime = 0f)
	{
		this.BeginCameraEulerRotator(desRotator, time, stayTime, 0f, 1f, canBreakByInput);
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x000C4C85 File Offset: 0x000C2E85
	public void PlayCameraEulerRotatorWithCurve(Rotator desRotator, float time, float minAlpha, float maxAlpha, CurveBase curve, bool canBreakByInput = true, float stayTime = 0f)
	{
		this.RotatorAlphaCurve = curve;
		this.BeginCameraEulerRotator(desRotator, time, stayTime, minAlpha, maxAlpha, canBreakByInput);
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x000C4CA0 File Offset: 0x000C2EA0
	private void UpdateArmRotationModifier(float deltaTime)
	{
		if (!this.IsActive)
		{
			return;
		}
		ValueTuple<float, float> cameraInput = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterInputComponent>().GetCameraInput();
		float item = cameraInput.Item1;
		float item2 = cameraInput.Item2;
		if (this.CanBreakByInput && (Math.Abs(item) > 0f || Math.Abs(item2) > 0f))
		{
			this.FinishCameraRotator();
			return;
		}
		float num = this.CurrentTime / this.Time;
		if (this.RotatorAlphaCurve != null)
		{
			this.Alpha = this.RotatorAlphaCurve.GetCurrentValue(num);
		}
		else
		{
			this.Alpha = num;
		}
		this.Alpha = MathUtils.Instance.Clamp(this.Alpha, this.MinAlpha, this.MaxAlpha);
		if (this.IsSustainingMode)
		{
			this.SustainingLookAt.Subtraction(this.Camera.PlayerLocation, this.SustainingTemp);
			this.SustainingTemp.Rotation(this.DesRotator);
			if (!this.Camera.IsInNormalGravityMode())
			{
				CameraUtility.GetRotatorInGravity(this.DesRotator, this.DesRotator);
			}
		}
		Rotator.Lerp(this.StartRotator, this.DesRotator, this.Alpha, this.CurrentRotator);
		if (this.Camera.IsInNormalGravityMode())
		{
			this.Camera.DesiredCamera.ArmRotation = Rotator.Create(this.CurrentRotator);
		}
		else
		{
			CameraUtility.SetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.CurrentRotator);
		}
		if (this.CurrentTime >= this.Time + this.StayTime)
		{
			this.FinishCameraRotator();
		}
		this.CurrentTime += deltaTime;
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x000C4E3C File Offset: 0x000C303C
	private void BeginCameraRotator(Vector lookAt1, Vector lookAt2, Rotator addRotator, float time, float stayTime, float minAlpha, float maxAlpha, bool canBreakByInput, [Nullable(2)] Action finishCallback = null)
	{
		this.IsActive = true;
		if (this.Camera.IsInNormalGravityMode())
		{
			this.StartRotator.FromUeRotator(this.Camera.CurrentCamera.ArmRotation);
		}
		else
		{
			CameraUtility.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.StartRotator);
		}
		Vector vector = Vector.Create();
		lookAt2.Subtraction(lookAt1, vector);
		vector.Rotation(this.DesRotator);
		if (!this.Camera.IsInNormalGravityMode())
		{
			CameraUtility.GetRotatorInGravity(this.DesRotator, this.DesRotator);
		}
		this.Time = time;
		this.StayTime = stayTime;
		this.CurrentTime = 0f;
		this.Alpha = 0f;
		this.MinAlpha = minAlpha;
		this.MaxAlpha = maxAlpha;
		this.CanBreakByInput = canBreakByInput;
		this.FinishCallback = finishCallback;
		MathUtils.Instance.ComposeRotator(this.DesRotator, addRotator, this.DesRotator);
		this.UpdateCameraInputState();
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x000C4F34 File Offset: 0x000C3134
	public void BeginCameraSustainingRotator(Vector lookAtPosition, float time, float stayTime, int minAlpha, int maxAlpha, bool canBreakByInput, [Nullable(2)] Action callback = null)
	{
		this.IsActive = true;
		this.IsSustainingMode = true;
		if (this.Camera.IsInNormalGravityMode())
		{
			this.StartRotator.FromUeRotator(this.Camera.CurrentCamera.ArmRotation);
		}
		else
		{
			CameraUtility.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.StartRotator);
		}
		this.SustainingLookAt.DeepCopy(lookAtPosition);
		this.Time = time;
		this.StayTime = stayTime;
		this.CurrentTime = 0f;
		this.Alpha = 0f;
		this.MinAlpha = (float)minAlpha;
		this.MaxAlpha = (float)maxAlpha;
		this.CanBreakByInput = canBreakByInput;
		this.FinishCallback = callback;
		this.UpdateCameraInputState();
	}

	// Token: 0x060021E9 RID: 8681 RVA: 0x000C4FF0 File Offset: 0x000C31F0
	private void BeginCameraEulerRotator(Rotator desRotator, float time, float stayTime, float minAlpha, float maxAlpha, bool canBreakByInput)
	{
		this.IsActive = true;
		if (this.Camera.IsInNormalGravityMode())
		{
			this.StartRotator.FromUeRotator(this.Camera.CurrentCamera.ArmRotation);
			this.DesRotator.Set(desRotator.Pitch, desRotator.Yaw, desRotator.Roll);
		}
		else
		{
			CameraUtility.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.StartRotator);
			CameraUtility.GetRotatorInGravity(desRotator, this.DesRotator);
		}
		this.Time = time;
		this.StayTime = stayTime;
		this.CurrentTime = 0f;
		this.Alpha = 0f;
		this.MinAlpha = minAlpha;
		this.MaxAlpha = maxAlpha;
		this.CanBreakByInput = canBreakByInput;
		this.UpdateCameraInputState();
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x000C50B8 File Offset: 0x000C32B8
	private void FinishCameraRotator()
	{
		this.IsActive = false;
		this.IsSustainingMode = false;
		this.RotatorAlphaCurve = null;
		this.Camera.CameraInputController.Unlock(this);
		this.Camera.CameraRotationZone.Unlock(this);
		Action finishCallback = this.FinishCallback;
		if (finishCallback != null)
		{
			finishCallback();
		}
		this.FinishCallback = null;
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x000C5114 File Offset: 0x000C3314
	private void UpdateCameraInputState()
	{
		if (this.CanBreakByInput)
		{
			this.Camera.CameraInputController.Unlock(this);
		}
		else
		{
			this.Camera.CameraInputController.Lock(this);
		}
		this.Camera.CameraRotationZone.Lock(this);
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000C5153 File Offset: 0x000C3353
	protected override void UpdateInternal(float deltaTime)
	{
		this.UpdateArmRotationModifier(deltaTime);
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x000C515C File Offset: 0x000C335C
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x000C5168 File Offset: 0x000C3368
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 4:
				if (key == "Time")
				{
					value = this.Time;
					return true;
				}
				break;
			case 5:
				if (key == "Alpha")
				{
					value = this.Alpha;
					return true;
				}
				break;
			case 8:
			{
				char c = key[1];
				if (c <= 'i')
				{
					if (c != 'a')
					{
						if (c == 'i')
						{
							if (key == "MinAlpha")
							{
								value = this.MinAlpha;
								return true;
							}
						}
					}
					else if (key == "MaxAlpha")
					{
						value = this.MaxAlpha;
						return true;
					}
				}
				else if (c != 's')
				{
					if (c == 't')
					{
						if (key == "StayTime")
						{
							value = this.StayTime;
							return true;
						}
					}
				}
				else if (key == "IsActive")
				{
					value = this.IsActive;
					return true;
				}
				break;
			}
			case 10:
				if (key == "DesRotator")
				{
					value = this.DesRotator;
					return true;
				}
				break;
			case 11:
				if (key == "CurrentTime")
				{
					value = this.CurrentTime;
					return true;
				}
				break;
			case 12:
				if (key == "StartRotator")
				{
					value = this.StartRotator;
					return true;
				}
				break;
			case 14:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c != 'F')
					{
						if (c == 'S')
						{
							if (key == "SustainingTemp")
							{
								value = this.SustainingTemp;
								return true;
							}
						}
					}
					else if (key == "FinishCallback")
					{
						value = this.FinishCallback;
						return true;
					}
				}
				else if (key == "CurrentRotator")
				{
					value = this.CurrentRotator;
					return true;
				}
				break;
			}
			case 15:
				if (key == "CanBreakByInput")
				{
					value = this.CanBreakByInput;
					return true;
				}
				break;
			case 16:
			{
				char c = key[0];
				if (c != 'I')
				{
					if (c == 'S')
					{
						if (key == "SustainingLookAt")
						{
							value = this.SustainingLookAt;
							return true;
						}
					}
				}
				else if (key == "IsSustainingMode")
				{
					value = this.IsSustainingMode;
					return true;
				}
				break;
			}
			case 17:
				if (key == "RotatorAlphaCurve")
				{
					value = this.RotatorAlphaCurve;
					return true;
				}
				break;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x000C5468 File Offset: 0x000C3668
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 4:
				if (key == "Time")
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
					this.Time = num2;
					return;
				}
				break;
			case 5:
				if (key == "Alpha")
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
					this.Alpha = num2;
					return;
				}
				break;
			case 8:
			{
				char c = key[1];
				if (c <= 'i')
				{
					if (c != 'a')
					{
						if (c == 'i')
						{
							if (key == "MinAlpha")
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
								this.MinAlpha = num2;
								return;
							}
						}
					}
					else if (key == "MaxAlpha")
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
						this.MaxAlpha = num2;
						return;
					}
				}
				else if (c != 's')
				{
					if (c == 't')
					{
						if (key == "StayTime")
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
							this.StayTime = num2;
							return;
						}
					}
				}
				else if (key == "IsActive")
				{
					this.IsActive = (bool)value;
					return;
				}
				break;
			}
			case 11:
				if (key == "CurrentTime")
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
					this.CurrentTime = num2;
					return;
				}
				break;
			case 14:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c == 'S')
					{
						if (key == "SustainingTemp")
						{
							this.SustainingTemp = (Vector)value;
							return;
						}
					}
				}
				else if (key == "FinishCallback")
				{
					this.FinishCallback = (Action)value;
					return;
				}
				break;
			}
			case 15:
				if (key == "CanBreakByInput")
				{
					this.CanBreakByInput = (bool)value;
					return;
				}
				break;
			case 16:
			{
				char c = key[0];
				if (c != 'I')
				{
					if (c == 'S')
					{
						if (key == "SustainingLookAt")
						{
							this.SustainingLookAt = (Vector)value;
							return;
						}
					}
				}
				else if (key == "IsSustainingMode")
				{
					this.IsSustainingMode = (bool)value;
					return;
				}
				break;
			}
			case 17:
				if (key == "RotatorAlphaCurve")
				{
					this.RotatorAlphaCurve = (CurveBase)value;
					return;
				}
				break;
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x000C595D File Offset: 0x000C3B5D
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraRotatorController.<MemberIter>d__32 <MemberIter>d__ = new CameraRotatorController.<MemberIter>d__32(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x0400160E RID: 5646
	public readonly Rotator StartRotator = Rotator.Create();

	// Token: 0x0400160F RID: 5647
	public readonly Rotator DesRotator = Rotator.Create();

	// Token: 0x04001610 RID: 5648
	public readonly Rotator CurrentRotator = Rotator.Create();

	// Token: 0x04001611 RID: 5649
	private bool IsActive;

	// Token: 0x04001612 RID: 5650
	private float Time;

	// Token: 0x04001613 RID: 5651
	private float StayTime;

	// Token: 0x04001614 RID: 5652
	private float CurrentTime;

	// Token: 0x04001615 RID: 5653
	public float Alpha;

	// Token: 0x04001616 RID: 5654
	private float MinAlpha;

	// Token: 0x04001617 RID: 5655
	private float MaxAlpha;

	// Token: 0x04001618 RID: 5656
	[Nullable(2)]
	private CurveBase RotatorAlphaCurve;

	// Token: 0x04001619 RID: 5657
	private bool CanBreakByInput = true;

	// Token: 0x0400161A RID: 5658
	private Vector SustainingLookAt = Vector.Create();

	// Token: 0x0400161B RID: 5659
	private Vector SustainingTemp = Vector.Create();

	// Token: 0x0400161C RID: 5660
	private bool IsSustainingMode;

	// Token: 0x0400161D RID: 5661
	[Nullable(2)]
	private Action FinishCallback;
}
