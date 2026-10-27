using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using UnrealEngine;

// Token: 0x0200020E RID: 526
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true)]
public class CameraHookController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x060020A5 RID: 8357 RVA: 0x000B10E3 File Offset: 0x000AF2E3
	public CameraHookController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x060020A6 RID: 8358 RVA: 0x000B110D File Offset: 0x000AF30D
	public override string Name()
	{
		return "HookController";
	}

	// Token: 0x060020A7 RID: 8359 RVA: 0x000B1114 File Offset: 0x000AF314
	public void ApplyCameraHook(GrapplingHookPointComponent point, [Nullable(2)] GrapplingHookPointComponent currentTarget = null)
	{
		this.LookAtPoint = point;
		this.GazeParams = ((currentTarget != null) ? new GazeParams(currentTarget, true) : new GazeParams(point, false));
		this.Enable = true;
		this.OnEnter();
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x000B1143 File Offset: 0x000AF343
	public void ExitCameraHook(bool fadeOut = true)
	{
		this.Enable = false;
		if (this.BlendState != CameraHookController.EBlendState.Default)
		{
			this.OnExit(fadeOut);
		}
	}

	// Token: 0x060020A9 RID: 8361 RVA: 0x000B115C File Offset: 0x000AF35C
	private void OnEnter()
	{
		this.BlendState = CameraHookController.EBlendState.BlendIn;
		this.ElapsedTime = 0f;
		this.FadeOutElapsedTime = 0f;
		this.StartFadeInCameraLookAt.DeepCopy(this.Camera.CameraForward);
		if (this.GazeParams.LockCamera)
		{
			base.CameraModel.FightCamera.LogicComponent.CameraInputController.Lock(this);
			base.CameraModel.FightCamera.LogicComponent.CameraFocusController.Lock(this);
		}
	}

	// Token: 0x060020AA RID: 8362 RVA: 0x000B11DF File Offset: 0x000AF3DF
	protected override bool UpdateCustomEnableCondition()
	{
		return this.Enable;
	}

	// Token: 0x060020AB RID: 8363 RVA: 0x000B11E8 File Offset: 0x000AF3E8
	protected override void UpdateInternal(float delta)
	{
		if (!this.LookAtPoint.Valid)
		{
			this.ExitCameraHook(true);
			return;
		}
		this.ElapsedTime += delta;
		if (this.Camera.IsModifiedArmRotationPitch || this.Camera.IsModifiedArmRotationYaw || this.Camera.IsModifiedArmLength)
		{
			this.OnExit(true);
		}
		this.CalcLookAt();
		switch (this.BlendState)
		{
		case CameraHookController.EBlendState.BlendIn:
		{
			float num = (this.GazeParams.FadeInTime > 0f) ? (this.ElapsedTime / this.GazeParams.FadeInTime) : 1f;
			num = MathUtils.Instance.Clamp(num, 0f, 1f);
			this.UpdateFadeIn(num);
			if (this.ElapsedTime > this.GazeParams.FadeInTime)
			{
				this.BlendState = CameraHookController.EBlendState.Staying;
				return;
			}
			break;
		}
		case CameraHookController.EBlendState.Staying:
			this.UpdateStaying();
			if (this.GazeParams.StayTime >= 0f && this.ElapsedTime > this.GazeParams.FadeInTime + this.GazeParams.StayTime)
			{
				if (this.GazeParams.FadeOutTime == null)
				{
					this.BlendState = CameraHookController.EBlendState.Default;
					this.OnExit(true);
					return;
				}
				this.BlendState = CameraHookController.EBlendState.BlendOut;
				this.StartFadeOutCameraLookAt.DeepCopy(this.Camera.CameraForward);
				return;
			}
			break;
		case CameraHookController.EBlendState.BlendOut:
		{
			this.FadeOutElapsedTime += delta;
			float num2 = (this.GazeParams.FadeOutTime.Value > 0f) ? (this.FadeOutElapsedTime / this.GazeParams.FadeOutTime.Value) : 1f;
			num2 = MathUtils.Instance.Clamp(num2, 0f, 1f);
			this.UpdateFadeOut(num2);
			float fadeOutElapsedTime = this.FadeOutElapsedTime;
			float? fadeOutTime = this.GazeParams.FadeOutTime;
			if (fadeOutElapsedTime > fadeOutTime.GetValueOrDefault() & fadeOutTime != null)
			{
				this.BlendState = CameraHookController.EBlendState.Default;
				this.OnExit(true);
			}
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x060020AC RID: 8364 RVA: 0x000B13E0 File Offset: 0x000AF5E0
	protected override void UpdateDeactivateInternal(float delta)
	{
		if (this.BlendState == CameraHookController.EBlendState.BlendOut)
		{
			this.FadeOutElapsedTime += delta;
			float num = (this.GazeParams.FadeOutTime.Value > 0f) ? (this.FadeOutElapsedTime / this.GazeParams.FadeOutTime.Value) : 1f;
			num = MathUtils.Instance.Clamp(num, 0f, 1f);
			this.UpdateFadeOut(num);
			float fadeOutElapsedTime = this.FadeOutElapsedTime;
			float? fadeOutTime = this.GazeParams.FadeOutTime;
			if (fadeOutElapsedTime > fadeOutTime.GetValueOrDefault() & fadeOutTime != null)
			{
				this.BlendState = CameraHookController.EBlendState.Default;
				this.OnExit(true);
			}
		}
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x000B1490 File Offset: 0x000AF690
	private void UpdateFadeIn(float alpha)
	{
		Vector vector = Vector.Create();
		Vector.LerpSin(this.StartFadeInCameraLookAt, this.LookAt, alpha, vector);
		FRotator frotator = vector.ToUeVector(false).Rotation();
		this.Camera.DesiredCamera.ArmRotation.DeepCopy(frotator);
		this.Camera.IsModifiedArmRotationPitch = true;
		this.Camera.IsModifiedArmRotationYaw = true;
	}

	// Token: 0x060020AE RID: 8366 RVA: 0x000B14F8 File Offset: 0x000AF6F8
	private void UpdateStaying()
	{
		FRotator frotator = this.LookAt.ToUeVector(false).Rotation();
		this.Camera.DesiredCamera.ArmRotation.DeepCopy(frotator);
		this.Camera.IsModifiedArmRotationPitch = true;
		this.Camera.IsModifiedArmRotationYaw = true;
	}

	// Token: 0x060020AF RID: 8367 RVA: 0x000B154C File Offset: 0x000AF74C
	private void UpdateFadeOut(float alpha)
	{
		Vector vector = Vector.Create();
		Vector.LerpSin(this.StartFadeOutCameraLookAt, this.StartFadeInCameraLookAt, alpha, vector);
		FRotator frotator = vector.ToUeVector(false).Rotation();
		this.Camera.DesiredCamera.ArmRotation.DeepCopy(frotator);
		this.Camera.IsModifiedArmRotationPitch = true;
		this.Camera.IsModifiedArmRotationYaw = true;
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x000B15B4 File Offset: 0x000AF7B4
	private void CalcLookAt()
	{
		Vector hookLocation = this.LookAtPoint.HookLocation;
		Vector playerLocation = this.Camera.PlayerLocation;
		hookLocation.Subtraction(playerLocation, this.LookAt);
		this.LookAt.Normalize(9.99999993922529E-09);
		if (Math.Abs(this.LookAt.X) < 1E-08 && Math.Abs(this.LookAt.Y) < 1E-08)
		{
			this.LookAt = Vector.ZeroVectorProxy;
		}
	}

	// Token: 0x060020B1 RID: 8369 RVA: 0x000B163C File Offset: 0x000AF83C
	private void OnExit(bool fadeOut = true)
	{
		this.Enable = false;
		CameraHookController.EBlendState blendState = this.BlendState;
		bool flag = blendState - CameraHookController.EBlendState.BlendIn <= 1;
		if (flag)
		{
			GrapplingHookPointComponent lookAtPoint = this.LookAtPoint;
			if (lookAtPoint != null && lookAtPoint.Valid)
			{
				GazeParams gazeParams = this.GazeParams;
				if (gazeParams != null && gazeParams.FadeOutTime != null)
				{
					this.BlendState = CameraHookController.EBlendState.BlendOut;
					this.FadeOutElapsedTime = (fadeOut ? 0f : this.GazeParams.FadeOutTime.Value);
					this.StartFadeOutCameraLookAt.DeepCopy(this.Camera.CameraForward);
					return;
				}
			}
		}
		base.CameraModel.FightCamera.LogicComponent.CameraInputController.Unlock(this);
		base.CameraModel.FightCamera.LogicComponent.CameraFocusController.Unlock(this);
	}

	// Token: 0x060020B2 RID: 8370 RVA: 0x000B1707 File Offset: 0x000AF907
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x060020B3 RID: 8371 RVA: 0x000B1710 File Offset: 0x000AF910
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			int length = key.Length;
			if (length <= 11)
			{
				if (length != 6)
				{
					if (length != 10)
					{
						if (length == 11)
						{
							char c = key[0];
							if (c != 'E')
							{
								if (c == 'L')
								{
									if (key == "LookAtPoint")
									{
										value = this.LookAtPoint;
										return true;
									}
								}
							}
							else if (key == "ElapsedTime")
							{
								value = this.ElapsedTime;
								return true;
							}
						}
					}
					else
					{
						char c = key[0];
						if (c != 'B')
						{
							if (c == 'G')
							{
								if (key == "GazeParams")
								{
									value = this.GazeParams;
									return true;
								}
							}
						}
						else if (key == "BlendState")
						{
							value = this.BlendState;
							return true;
						}
					}
				}
				else
				{
					char c = key[0];
					if (c != 'E')
					{
						if (c == 'L')
						{
							if (key == "LookAt")
							{
								value = this.LookAt;
								return true;
							}
						}
					}
					else if (key == "Enable")
					{
						value = this.Enable;
						return true;
					}
				}
			}
			else if (length != 18)
			{
				if (length != 23)
				{
					if (length == 24)
					{
						if (key == "StartFadeOutCameraLookAt")
						{
							value = this.StartFadeOutCameraLookAt;
							return true;
						}
					}
				}
				else if (key == "StartFadeInCameraLookAt")
				{
					value = this.StartFadeInCameraLookAt;
					return true;
				}
			}
			else if (key == "FadeOutElapsedTime")
			{
				value = this.FadeOutElapsedTime;
				return true;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x000B18C4 File Offset: 0x000AFAC4
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			int length = key.Length;
			if (length <= 10)
			{
				if (length != 6)
				{
					if (length == 10)
					{
						char c = key[0];
						if (c != 'B')
						{
							if (c == 'G')
							{
								if (key == "GazeParams")
								{
									this.GazeParams = (GazeParams)value;
									return;
								}
							}
						}
						else if (key == "BlendState")
						{
							this.BlendState = (CameraHookController.EBlendState)value;
							return;
						}
					}
				}
				else
				{
					char c = key[0];
					if (c != 'E')
					{
						if (c == 'L')
						{
							if (key == "LookAt")
							{
								this.LookAt = (Vector)value;
								return;
							}
						}
					}
					else if (key == "Enable")
					{
						this.Enable = (bool)value;
						return;
					}
				}
			}
			else if (length != 11)
			{
				if (length == 18)
				{
					if (key == "FadeOutElapsedTime")
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
						this.FadeOutElapsedTime = num2;
						return;
					}
				}
			}
			else
			{
				char c = key[0];
				if (c != 'E')
				{
					if (c == 'L')
					{
						if (key == "LookAtPoint")
						{
							this.LookAtPoint = (GrapplingHookPointComponent)value;
							return;
						}
					}
				}
				else if (key == "ElapsedTime")
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
					this.ElapsedTime = num2;
					return;
				}
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x060020B5 RID: 8373 RVA: 0x000B1B01 File Offset: 0x000AFD01
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraHookController.<MemberIter>d__26 <MemberIter>d__ = new CameraHookController.<MemberIter>d__26(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x040014AA RID: 5290
	[Nullable(2)]
	private GrapplingHookPointComponent LookAtPoint;

	// Token: 0x040014AB RID: 5291
	[Nullable(2)]
	private GazeParams GazeParams;

	// Token: 0x040014AC RID: 5292
	private CameraHookController.EBlendState BlendState;

	// Token: 0x040014AD RID: 5293
	private float ElapsedTime;

	// Token: 0x040014AE RID: 5294
	private float FadeOutElapsedTime;

	// Token: 0x040014AF RID: 5295
	private readonly Vector StartFadeInCameraLookAt = Vector.Create();

	// Token: 0x040014B0 RID: 5296
	private readonly Vector StartFadeOutCameraLookAt = Vector.Create();

	// Token: 0x040014B1 RID: 5297
	private Vector LookAt = Vector.Create();

	// Token: 0x040014B2 RID: 5298
	private bool Enable;

	// Token: 0x02007430 RID: 29744
	[NullableContext(0)]
	internal enum EBlendState
	{
		// Token: 0x040267E5 RID: 157669
		Default,
		// Token: 0x040267E6 RID: 157670
		BlendIn,
		// Token: 0x040267E7 RID: 157671
		Staying,
		// Token: 0x040267E8 RID: 157672
		BlendOut
	}
}
