using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020001FD RID: 509
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true)]
public class CameraFixedController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x06002004 RID: 8196 RVA: 0x000A7584 File Offset: 0x000A5784
	public CameraFixedController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x06002005 RID: 8197 RVA: 0x000A758D File Offset: 0x000A578D
	public override string Name()
	{
		return "FixedController";
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x000A7594 File Offset: 0x000A5794
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

	// Token: 0x06002007 RID: 8199 RVA: 0x000A7684 File Offset: 0x000A5884
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

	// Token: 0x06002008 RID: 8200 RVA: 0x000A7721 File Offset: 0x000A5921
	private void RemoveFadeIn()
	{
		if (this.TickIdFadeIn != null && TimerSystem.Instance.Has(this.TickIdFadeIn))
		{
			TimerSystem.Instance.Remove(this.TickIdFadeIn);
			this.OnFadeIn(0f);
		}
	}

	// Token: 0x06002009 RID: 8201 RVA: 0x000A775C File Offset: 0x000A595C
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

	// Token: 0x0600200A RID: 8202 RVA: 0x000A77F9 File Offset: 0x000A59F9
	private void RemoveFadeOut()
	{
		if (this.TickIdFadeOut != null && TimerSystem.Instance.Has(this.TickIdFadeOut))
		{
			TimerSystem.Instance.Remove(this.TickIdFadeOut);
		}
	}

	// Token: 0x0600200B RID: 8203 RVA: 0x000A7826 File Offset: 0x000A5A26
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

	// Token: 0x0600200C RID: 8204 RVA: 0x000A7858 File Offset: 0x000A5A58
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

	// Token: 0x0600200D RID: 8205 RVA: 0x000A78CC File Offset: 0x000A5ACC
	private void FixedCameraSetViewTarget()
	{
		CameraController.Instance.SetViewTarget(this.NowInCamera, "FixedCameraSetViewTarget", this.FadeInTime, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), base.CameraModel.CameraName, null, null);
		base.CameraModel.FightCamera.LogicComponent.CameraInputController.Lock(this);
		base.CameraModel.FightCamera.LogicComponent.SetIsDitherEffectEnable(false);
		this.IsLockedCamera = true;
		this.IsChangingCamera = true;
		this.AddFadeIn();
	}

	// Token: 0x0600200E RID: 8206 RVA: 0x000A7958 File Offset: 0x000A5B58
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

	// Token: 0x0600200F RID: 8207 RVA: 0x000A7A58 File Offset: 0x000A5C58
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

	// Token: 0x06002010 RID: 8208 RVA: 0x000A7AD8 File Offset: 0x000A5CD8
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

	// Token: 0x06002011 RID: 8209 RVA: 0x000A7B58 File Offset: 0x000A5D58
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

	// Token: 0x06002012 RID: 8210 RVA: 0x000A7BCB File Offset: 0x000A5DCB
	protected void OnFixedCameraRestored()
	{
		if (this.IsLockedCamera)
		{
			this.FixedCameraResetViewTarget();
		}
		base.CameraModel.FightCamera.LogicComponent.SetIsDitherEffectEnable(true);
	}

	// Token: 0x06002013 RID: 8211 RVA: 0x000A7BF4 File Offset: 0x000A5DF4
	private bool CheckIfTheSameCamera(Vector vectorLoc)
	{
		ACameraActor nowInCamera = this.NowInCamera;
		FVectorDouble? fvectorDouble = (nowInCamera != null) ? new FVectorDouble?(nowInCamera.D_K2_GetActorLocation()) : null;
		return MathUtils.Instance.IsNearlyEqual(fvectorDouble.Value.X, vectorLoc.ToUeVector(false).X, new double?(0.0001)) && MathUtils.Instance.IsNearlyEqual(fvectorDouble.Value.Y, vectorLoc.ToUeVector(false).Y, new double?(0.0001)) && MathUtils.Instance.IsNearlyEqual(fvectorDouble.Value.Z, vectorLoc.ToUeVector(false).Z, new double?(0.0001));
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x000A7CBA File Offset: 0x000A5EBA
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x000A7CC4 File Offset: 0x000A5EC4
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

	// Token: 0x06002016 RID: 8214 RVA: 0x000A7E38 File Offset: 0x000A6038
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

	// Token: 0x06002017 RID: 8215 RVA: 0x000A808E File Offset: 0x000A628E
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraFixedController.<MemberIter>d__27 <MemberIter>d__ = new CameraFixedController.<MemberIter>d__27(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x040013EC RID: 5100
	private float FadeInTime;

	// Token: 0x040013ED RID: 5101
	private float FadeOutTime;

	// Token: 0x040013EE RID: 5102
	[Nullable(2)]
	private TimerHandle TickIdFadeIn;

	// Token: 0x040013EF RID: 5103
	[Nullable(2)]
	private TimerHandle TickIdFadeOut;

	// Token: 0x040013F0 RID: 5104
	public bool IsLockedCamera;

	// Token: 0x040013F1 RID: 5105
	public bool IsChangingCamera;

	// Token: 0x040013F2 RID: 5106
	[Nullable(2)]
	private ACameraActor NowInCamera;

	// Token: 0x040013F3 RID: 5107
	[Nullable(2)]
	private ACameraActor LastInCamera;
}
