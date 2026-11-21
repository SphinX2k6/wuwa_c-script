using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02000201 RID: 513
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true, true, null)]
public class CameraFixedController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x060020B2 RID: 8370 RVA: 0x000AE8D8 File Offset: 0x000ACAD8
	public CameraFixedController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x060020B3 RID: 8371 RVA: 0x000AE8E1 File Offset: 0x000ACAE1
	public override string Name()
	{
		return "FixedController";
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x000AE8E8 File Offset: 0x000ACAE8
	public void InitFixedCamera(Vector vectorLoc, Rotator vectorRot, float fov, float fadeInTime, float fadeOutTime)
	{
		if (this.NowInCamera == null || !this.CheckIfTheSameCamera(vectorLoc) || base.CameraModel.CurrentCameraActor != this.NowInCamera)
		{
			this.LastInCamera = this.NowInCamera;
			UObject world = GlobalData.World;
			TSubclassOf<AActor> actorClass = ACameraActor.StaticClass();
			FRotator frotator = vectorRot.ToUeRotator();
			FVectorDouble fvectorDouble = vectorLoc.ToUeVector(false);
			FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
			FVector fvector = fvectorDouble2;
			FTransformDouble ftransformDouble = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
			this.NowInCamera = (UKuroActorManager.D_SpawnActor(world, actorClass, ftransformDouble, ESpawnActorCollisionHandlingMethod.Undefined, null, null, false) as ACameraActor);
			if (this.NowInCamera != null)
			{
				this.FadeInTime = fadeInTime;
				this.FadeOutTime = fadeOutTime;
				this.NowInCamera.CameraComponent.FieldOfView = fov;
				this.NowInCamera.CameraComponent.bConstrainAspectRatio = false;
				this.AddEventSystem();
				this.FixedCameraSetViewTarget();
			}
		}
	}

	// Token: 0x060020B5 RID: 8373 RVA: 0x000AE9D8 File Offset: 0x000ACBD8
	private void AddFadeIn()
	{
		if (this.TickIdFadeIn != null && TimerSystem.Instance.Has(this.TickIdFadeIn))
		{
			TimerSystem.Instance.Remove(this.TickIdFadeIn);
			this.OnFadeIn(0f);
		}
		this.RemoveFadeOut();
		if ((double)this.FadeInTime > 0.2)
		{
			this.TickIdFadeIn = TimerSystem.Instance.Delay(new TTimerAction(this.OnFadeIn), this.FadeInTime * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
			return;
		}
		this.OnFadeIn(0f);
	}

	// Token: 0x060020B6 RID: 8374 RVA: 0x000AEA75 File Offset: 0x000ACC75
	private void RemoveFadeIn()
	{
		if (this.TickIdFadeIn != null && TimerSystem.Instance.Has(this.TickIdFadeIn))
		{
			TimerSystem.Instance.Remove(this.TickIdFadeIn);
			this.OnFadeIn(0f);
		}
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x000AEAB0 File Offset: 0x000ACCB0
	private void AddFadeOut()
	{
		if (this.TickIdFadeOut != null && TimerSystem.Instance.Has(this.TickIdFadeOut))
		{
			TimerSystem.Instance.Remove(this.TickIdFadeOut);
			this.OnFadeOut(0f);
		}
		this.RemoveFadeIn();
		if ((double)this.FadeOutTime > 0.2)
		{
			this.TickIdFadeOut = TimerSystem.Instance.Delay(new TTimerAction(this.OnFadeOut), this.FadeOutTime * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
			return;
		}
		this.OnFadeOut(0f);
	}

	// Token: 0x060020B8 RID: 8376 RVA: 0x000AEB4D File Offset: 0x000ACD4D
	private void RemoveFadeOut()
	{
		if (this.TickIdFadeOut != null && TimerSystem.Instance.Has(this.TickIdFadeOut))
		{
			TimerSystem.Instance.Remove(this.TickIdFadeOut);
		}
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x000AEB7A File Offset: 0x000ACD7A
	private void OnFadeIn(float delta)
	{
		if (this.LastInCamera != this.NowInCamera)
		{
			ACameraActor lastInCamera = this.LastInCamera;
			if (lastInCamera != null)
			{
				lastInCamera.K2_DestroyActor();
			}
			this.LastInCamera = null;
		}
		this.IsChangingCamera = false;
	}

	// Token: 0x060020BA RID: 8378 RVA: 0x000AEBAC File Offset: 0x000ACDAC
	private void OnFadeOut(float delta)
	{
		base.CameraModel.FightCamera.LogicComponent.CameraInputController.Unlock(this);
		ACameraActor nowInCamera = this.NowInCamera;
		if (nowInCamera != null)
		{
			nowInCamera.K2_DestroyActor();
		}
		this.NowInCamera = null;
		ACameraActor lastInCamera = this.LastInCamera;
		if (lastInCamera != null)
		{
			lastInCamera.K2_DestroyActor();
		}
		this.LastInCamera = null;
		this.RemoveEventSystem();
		this.RemoveFadeIn();
		this.RemoveFadeOut();
		this.IsChangingCamera = false;
	}

	// Token: 0x060020BB RID: 8379 RVA: 0x000AEC20 File Offset: 0x000ACE20
	private void FixedCameraSetViewTarget()
	{
		CameraController.Instance.SetViewTarget(this.NowInCamera, "FixedCameraSetViewTarget", this.FadeInTime, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), base.CameraModel.CameraName, null, null);
		base.CameraModel.FightCamera.LogicComponent.CameraInputController.Lock(this);
		base.CameraModel.FightCamera.LogicComponent.SetIsDitherEffectEnable(false);
		this.IsLockedCamera = true;
		this.IsChangingCamera = true;
		this.AddFadeIn();
	}

	// Token: 0x060020BC RID: 8380 RVA: 0x000AECAC File Offset: 0x000ACEAC
	public bool FixedCameraResetViewTarget()
	{
		if (this.LastInCamera != this.NowInCamera)
		{
			VirtualCamera desiredCamera = base.CameraModel.FightCamera.LogicComponent.DesiredCamera;
			Rotator armRotation = desiredCamera.ArmRotation;
			ACameraActor nowInCamera = this.NowInCamera;
			FRotator? frotator = (nowInCamera != null) ? new FRotator?(nowInCamera.K2_GetActorRotation()) : null;
			desiredCamera.ArmRotation = new Rotator(frotator.Value.Pitch, frotator.Value.Yaw, armRotation.Roll);
			CameraController instance = CameraController.Instance;
			FightCameraDisplayComponent component = base.CameraModel.FightCamera.GetComponent<FightCameraDisplayComponent>();
			instance.SetViewTarget((component != null) ? component.CameraActor : null, "FixedCameraResetViewTarget", this.FadeOutTime, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), base.CameraModel.CameraName, null, null);
			base.CameraModel.FightCamera.LogicComponent.CameraInputController.Lock(this);
			this.IsChangingCamera = true;
			this.AddFadeOut();
			return true;
		}
		return false;
	}

	// Token: 0x060020BD RID: 8381 RVA: 0x000AEDAC File Offset: 0x000ACFAC
	private void AddEventSystem()
	{
		if (!EventSystem.Instance.Has<float, string>(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged)))
		{
			EventSystem.Instance.Add<float, string>(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged));
		}
		if (!EventSystem.Instance.Has(EEventName.FixedCameraRestored, new Action(this.OnFixedCameraRestored)))
		{
			EventSystem.Instance.Add(EEventName.FixedCameraRestored, new Action(this.OnFixedCameraRestored));
		}
	}

	// Token: 0x060020BE RID: 8382 RVA: 0x000AEE2C File Offset: 0x000AD02C
	private void RemoveEventSystem()
	{
		if (EventSystem.Instance.Has<float, string>(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged)))
		{
			EventSystem.Instance.Remove<float, string>(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged));
		}
		if (EventSystem.Instance.Has(EEventName.FixedCameraRestored, new Action(this.OnFixedCameraRestored)))
		{
			EventSystem.Instance.Remove(EEventName.FixedCameraRestored, new Action(this.OnFixedCameraRestored));
		}
	}

	// Token: 0x060020BF RID: 8383 RVA: 0x000AEEAC File Offset: 0x000AD0AC
	protected void OnViewTargetChanged(float f, string cameraName)
	{
		CameraModelInstance cameraModel = base.CameraModel;
		if (cameraName != ((cameraModel != null) ? cameraModel.CameraName : null))
		{
			return;
		}
		if (this.NowInCamera != null && base.CameraModel.CurrentCameraActor != this.NowInCamera && this.IsLockedCamera)
		{
			base.CameraModel.FightCamera.LogicComponent.CameraInputController.Unlock(this);
			this.RemoveEventSystem();
			this.IsLockedCamera = false;
		}
	}

	// Token: 0x060020C0 RID: 8384 RVA: 0x000AEF1F File Offset: 0x000AD11F
	protected void OnFixedCameraRestored()
	{
		if (this.IsLockedCamera)
		{
			this.FixedCameraResetViewTarget();
		}
		base.CameraModel.FightCamera.LogicComponent.SetIsDitherEffectEnable(true);
	}

	// Token: 0x060020C1 RID: 8385 RVA: 0x000AEF48 File Offset: 0x000AD148
	private bool CheckIfTheSameCamera(Vector vectorLoc)
	{
		ACameraActor nowInCamera = this.NowInCamera;
		FVectorDouble? fvectorDouble = (nowInCamera != null) ? new FVectorDouble?(nowInCamera.D_K2_GetActorLocation()) : null;
		return MathUtils.Instance.IsNearlyEqual(fvectorDouble.Value.X, vectorLoc.ToUeVector(false).X, new double?(0.0001)) && MathUtils.Instance.IsNearlyEqual(fvectorDouble.Value.Y, vectorLoc.ToUeVector(false).Y, new double?(0.0001)) && MathUtils.Instance.IsNearlyEqual(fvectorDouble.Value.Z, vectorLoc.ToUeVector(false).Z, new double?(0.0001));
	}

	// Token: 0x060020C2 RID: 8386 RVA: 0x000AF00E File Offset: 0x000AD20E
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x060020C3 RID: 8387 RVA: 0x000AF018 File Offset: 0x000AD218
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 10:
				if (key == "FadeInTime")
				{
					value = this.FadeInTime;
					return true;
				}
				break;
			case 11:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c == 'N')
					{
						if (key == "NowInCamera")
						{
							value = this.NowInCamera;
							return true;
						}
					}
				}
				else if (key == "FadeOutTime")
				{
					value = this.FadeOutTime;
					return true;
				}
				break;
			}
			case 12:
			{
				char c = key[0];
				if (c != 'L')
				{
					if (c == 'T')
					{
						if (key == "TickIdFadeIn")
						{
							value = this.TickIdFadeIn;
							return true;
						}
					}
				}
				else if (key == "LastInCamera")
				{
					value = this.LastInCamera;
					return true;
				}
				break;
			}
			case 13:
				if (key == "TickIdFadeOut")
				{
					value = this.TickIdFadeOut;
					return true;
				}
				break;
			case 14:
				if (key == "IsLockedCamera")
				{
					value = this.IsLockedCamera;
					return true;
				}
				break;
			case 16:
				if (key == "IsChangingCamera")
				{
					value = this.IsChangingCamera;
					return true;
				}
				break;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x000AF18C File Offset: 0x000AD38C
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 10:
				if (key == "FadeInTime")
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
					this.FadeInTime = num2;
					return;
				}
				break;
			case 11:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c == 'N')
					{
						if (key == "NowInCamera")
						{
							this.NowInCamera = (ACameraActor)value;
							return;
						}
					}
				}
				else if (key == "FadeOutTime")
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
					this.FadeOutTime = num2;
					return;
				}
				break;
			}
			case 12:
			{
				char c = key[0];
				if (c != 'L')
				{
					if (c == 'T')
					{
						if (key == "TickIdFadeIn")
						{
							this.TickIdFadeIn = (TimerHandle)value;
							return;
						}
					}
				}
				else if (key == "LastInCamera")
				{
					this.LastInCamera = (ACameraActor)value;
					return;
				}
				break;
			}
			case 13:
				if (key == "TickIdFadeOut")
				{
					this.TickIdFadeOut = (TimerHandle)value;
					return;
				}
				break;
			case 14:
				if (key == "IsLockedCamera")
				{
					this.IsLockedCamera = (bool)value;
					return;
				}
				break;
			case 16:
				if (key == "IsChangingCamera")
				{
					this.IsChangingCamera = (bool)value;
					return;
				}
				break;
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x000AF3E2 File Offset: 0x000AD5E2
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraFixedController.<MemberIter>d__27 <MemberIter>d__ = new CameraFixedController.<MemberIter>d__27(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x0400142E RID: 5166
	private float FadeInTime;

	// Token: 0x0400142F RID: 5167
	private float FadeOutTime;

	// Token: 0x04001430 RID: 5168
	[Nullable(2)]
	private TimerHandle TickIdFadeIn;

	// Token: 0x04001431 RID: 5169
	[Nullable(2)]
	private TimerHandle TickIdFadeOut;

	// Token: 0x04001432 RID: 5170
	public bool IsLockedCamera;

	// Token: 0x04001433 RID: 5171
	public bool IsChangingCamera;

	// Token: 0x04001434 RID: 5172
	[Nullable(2)]
	private ACameraActor NowInCamera;

	// Token: 0x04001435 RID: 5173
	[Nullable(2)]
	private ACameraActor LastInCamera;
}
