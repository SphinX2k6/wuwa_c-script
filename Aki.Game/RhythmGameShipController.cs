using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.RhythmGame;
using AkiClient.Game.Aki.Data.Level.PlaneYinyou.BP;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x0200053E RID: 1342
[NullableContext(1)]
[Nullable(0)]
public class RhythmGameShipController : ControllerBase
{
	// Token: 0x060041AE RID: 16814 RVA: 0x0016ED4C File Offset: 0x0016CF4C
	public void Initialize(BP_Plane_C shipActor)
	{
		this.ShipActor = shipActor;
		USkeletalMeshComponent skeletalMesh = shipActor.SkeletalMesh;
		this.ShipAnimInstance = (((skeletalMesh != null) ? skeletalMesh.GetAnimInstance() : null) as ABP_Plane_C);
		this.SwitchFireLevel();
		this.SpawnLockIcon();
		EventSystem.Instance.Add(EEventName.OnRhythmGameSpeedLevelConfigIndexChanged, new Action<int>(this.OnSpeedLevelChanged));
	}

	// Token: 0x060041AF RID: 16815 RVA: 0x0016EDA8 File Offset: 0x0016CFA8
	public void Release()
	{
		this.ShipActor = null;
		if (EventSystem.Instance.Has(EEventName.OnRhythmGameSpeedLevelConfigIndexChanged, new Action<int>(this.OnSpeedLevelChanged)))
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmGameSpeedLevelConfigIndexChanged, new Action<int>(this.OnSpeedLevelChanged));
		}
		if (this.FireEffectHandle != -1)
		{
			EffectSystem.Instance.StopEffectById(this.FireEffectHandle, "[RhythmGameShipController] Release Fire Effect", false, null);
			this.FireEffectHandle = -1;
		}
		if (this.FireworksEffectHandle != -1)
		{
			this.StopFireworksEffect();
		}
		if (this.HighSpeedEffectHandles.Count > 0)
		{
			foreach (int handle in this.HighSpeedEffectHandles)
			{
				EffectSystem.Instance.StopEffectById(handle, "[RhythmGameShipController] Stop High Speed Effect", false, null);
			}
			this.HighSpeedEffectHandles.Clear();
		}
		if (this.FeverEffectHandles.Count > 0)
		{
			foreach (int handle2 in this.FeverEffectHandles)
			{
				EffectSystem.Instance.StopEffectById(handle2, "[RhythmGameShipController] Stop Fever Effect", false, null);
			}
			this.FeverEffectHandles.Clear();
		}
		if (this.HitLockEffectHandle != -1)
		{
			EffectSystem.Instance.StopEffectById(this.HitLockEffectHandle, "[RhythmGameShipController] Release Hit Lock Effect", false, null);
			this.HitLockEffectHandle = -1;
		}
		if (this.SparksLineEffectHandle != -1)
		{
			this.StopSparksLineEffect();
		}
		if (this.DestroyHitLockEffectHandle != null)
		{
			TimerSystem.Instance.Remove(this.DestroyHitLockEffectHandle);
			this.DestroyHitLockEffectHandle = null;
		}
		this.StopLockIconEffect();
	}

	// Token: 0x060041B0 RID: 16816 RVA: 0x0016EF7C File Offset: 0x0016D17C
	private void OnSpeedLevelChanged(int value)
	{
		this.SwitchFireLevel();
		if (value >= 3)
		{
			this.SpawnHighSpeedEffect();
		}
		else
		{
			this.StopHighSpeedEffect();
		}
		if (value >= 4)
		{
			this.SpawnFeverEffect();
			this.SpawnFireworksEffect();
			this.SpawnSparksLineEffect();
			return;
		}
		this.StopFeverEffect();
		this.StopFireworksEffect();
		this.StopSparksLineEffect();
	}

	// Token: 0x060041B1 RID: 16817 RVA: 0x0016EFCC File Offset: 0x0016D1CC
	private int SpawnAttachedEffect(string effectPath, string logContext, USceneComponent attachComponent, FName? socketName = null, [Nullable(new byte[]
	{
		2,
		0,
		1,
		1
	})] Action<OneOf<KuroEffectActorHandle, AActor>> onSpawned = null)
	{
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
		int num = instance.SpawnEffect(world, ftransformDouble, effectPath, logContext, null, EEffectType.Scene, null, null, null, false, false);
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
		effectActor.K2_AttachToComponent(attachComponent, socketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
		if (onSpawned != null)
		{
			onSpawned(effectActor);
		}
		return num;
	}

	// Token: 0x060041B2 RID: 16818 RVA: 0x0016F02C File Offset: 0x0016D22C
	private void StopEffect(int handle, string logContext)
	{
		if (handle != -1)
		{
			EffectSystem.Instance.StopEffectById(handle, logContext, false, null);
		}
	}

	// Token: 0x060041B3 RID: 16819 RVA: 0x0016F054 File Offset: 0x0016D254
	private void SwitchFireLevel()
	{
		if (this.ShipActor == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] ShipActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RhythmGameSpeedLevelConfig currentSpeedLevelConfig = RhythmGameModel.Instance.GetCurrentSpeedLevelConfig();
		string text = (currentSpeedLevelConfig != null) ? currentSpeedLevelConfig.FireEffectDa.ToAssetPathName() : null;
		if (text == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] FireEffectPath is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.StopEffect(this.FireEffectHandle, "[RhythmGameShipController] Play New Fire Effect");
		this.FireEffectHandle = -1;
		this.FireEffectHandle = this.SpawnAttachedEffect(text, "[RhythmGameShipController] Play New Fire Effect", this.ShipActor.SkeletalMesh, new FName?(new FName("Bone_Prop001")), delegate([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<KuroEffectActorHandle, AActor> actor)
		{
			FTransformDouble ftransformDouble = new FTransformDouble();
			FQuat fquat = new FRotator(0f, 90f, 0f).Quaternion();
			ftransformDouble.SetRotation(fquat);
			FHitResult fhitResult = new FHitResult();
			actor.D_K2_SetActorRelativeTransform(ftransformDouble, false, ref fhitResult, false);
		});
	}

	// Token: 0x060041B4 RID: 16820 RVA: 0x0016F12C File Offset: 0x0016D32C
	private void SpawnHighSpeedEffect()
	{
		if (this.ShipActor == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] ShipActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.HighSpeedEffectHandles.Count > 0)
		{
			return;
		}
		foreach (string effectPath in RhythmGameModelDefine.RhythmGameHighSpeedEffect)
		{
			this.HighSpeedEffectHandles.Add(this.SpawnAttachedEffect(effectPath, "[RhythmGameShipController] Spawn High Speed Effect", this.ShipActor.SkeletalMesh, null, null));
		}
	}

	// Token: 0x060041B5 RID: 16821 RVA: 0x0016F1D4 File Offset: 0x0016D3D4
	private void StopHighSpeedEffect()
	{
		foreach (int handle in this.HighSpeedEffectHandles)
		{
			EffectSystem.Instance.StopEffectById(handle, "[RhythmGameShipController] Stop High Speed Effect", false, null);
		}
		this.HighSpeedEffectHandles.Clear();
	}

	// Token: 0x060041B6 RID: 16822 RVA: 0x0016F248 File Offset: 0x0016D448
	private void SpawnFeverEffect()
	{
		if (this.ShipActor == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] ShipActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.FeverEffectHandles.Count > 0)
		{
			return;
		}
		foreach (string effectPath in RhythmGameModelDefine.RhythmGameFeverEffect)
		{
			this.FeverEffectHandles.Add(this.SpawnAttachedEffect(effectPath, "[RhythmGameShipController] Spawn Fever Effect", this.ShipActor.SkeletalMesh, null, null));
		}
	}

	// Token: 0x060041B7 RID: 16823 RVA: 0x0016F2F0 File Offset: 0x0016D4F0
	private void StopFeverEffect()
	{
		foreach (int handle in this.FeverEffectHandles)
		{
			EffectSystem.Instance.StopEffectById(handle, "[RhythmGameShipController] Stop Fever Effect", false, null);
		}
		this.FeverEffectHandles.Clear();
	}

	// Token: 0x060041B8 RID: 16824 RVA: 0x0016F364 File Offset: 0x0016D564
	private void SpawnFireworksEffect()
	{
		if (this.ShipActor == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] ShipActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.FireworksEffectHandle != -1)
		{
			return;
		}
		TsGameSplineActor splineActor = RhythmGameController.Instance.GetSplineActor();
		if (splineActor == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] SplineActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		USplineComponent curSplineComponent = RhythmGameModel.Instance.CurSplineComponent;
		float currentSplineDistance = RhythmGameController.Instance.GetRhythmGameShipController().GetCurrentSplineDistance();
		FVectorDouble fvectorDouble = (curSplineComponent != null) ? curSplineComponent.D_GetLocationAtDistanceAlongSpline(currentSplineDistance, ESplineCoordinateSpace.World) : new FVectorDouble();
		FTransformDouble value = new FTransformDouble();
		value.SetLocation(fvectorDouble);
		FQuat fquat = ((curSplineComponent != null) ? curSplineComponent.GetRotationAtDistanceAlongSpline(currentSplineDistance, ESplineCoordinateSpace.World) : new FRotator()).Quaternion();
		value.SetRotation(fquat);
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(value);
		this.FireworksEffectHandle = instance.SpawnEffect(world, ftransformDouble, "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Sparks.DA_Fx_Group_Sparks", "[RhythmGameShipController] Spawn Fireworks Effect", null, EEffectType.Scene, null, null, null, false, false);
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.FireworksEffectHandle);
		AActor parent = splineActor;
		FName? fname = null;
		effectActor.K2_AttachToActor(parent, fname, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false);
		AudioSystem.Instance.PostEvent("play_ui_rhythmship_gamefirework");
	}

	// Token: 0x060041B9 RID: 16825 RVA: 0x0016F49C File Offset: 0x0016D69C
	private void StopFireworksEffect()
	{
		if (this.FireworksEffectHandle != -1)
		{
			EffectSystem.Instance.StopEffectById(this.FireworksEffectHandle, "[RhythmGameShipController] Stop Fireworks Effect", false, null);
			this.FireworksEffectHandle = -1;
		}
	}

	// Token: 0x060041BA RID: 16826 RVA: 0x0016F4DC File Offset: 0x0016D6DC
	private void SpawnSparksLineEffect()
	{
		if (this.ShipActor == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] ShipActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.SparksLineEffectHandle != -1)
		{
			return;
		}
		TsGameSplineActor splineActor = RhythmGameController.Instance.GetSplineActor();
		if (splineActor == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] SplineActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		USplineComponent curSplineComponent = RhythmGameModel.Instance.CurSplineComponent;
		float currentSplineDistance = RhythmGameController.Instance.GetRhythmGameShipController().GetCurrentSplineDistance();
		FVectorDouble fvectorDouble = (curSplineComponent != null) ? curSplineComponent.D_GetLocationAtDistanceAlongSpline(currentSplineDistance, ESplineCoordinateSpace.World) : new FVectorDouble();
		FTransformDouble value = new FTransformDouble();
		value.SetLocation(fvectorDouble);
		FQuat fquat = ((curSplineComponent != null) ? curSplineComponent.GetRotationAtDistanceAlongSpline(currentSplineDistance, ESplineCoordinateSpace.World) : new FRotator()).Quaternion();
		value.SetRotation(fquat);
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(value);
		this.SparksLineEffectHandle = instance.SpawnEffect(world, ftransformDouble, "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_SparkLine.DA_Fx_Group_SparkLine", "[RhythmGameShipController] Spawn Sparks Line Effect", null, EEffectType.Scene, null, null, null, false, false);
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.SparksLineEffectHandle);
		AActor parent = splineActor;
		FName? fname = null;
		effectActor.K2_AttachToActor(parent, fname, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false);
	}

	// Token: 0x060041BB RID: 16827 RVA: 0x0016F604 File Offset: 0x0016D804
	private void StopSparksLineEffect()
	{
		if (this.SparksLineEffectHandle != -1)
		{
			EffectSystem.Instance.StopEffectById(this.SparksLineEffectHandle, "[RhythmGameShipController] Stop Sparks Line Effect", false, null);
			this.SparksLineEffectHandle = -1;
		}
	}

	// Token: 0x060041BC RID: 16828 RVA: 0x0016F644 File Offset: 0x0016D844
	public void SpawnLockIcon()
	{
		if (this.ShipActor == null)
		{
			return;
		}
		if (this.LockIconEffectHandles.Count > 0)
		{
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			string effectPath = RhythmGameModelDefine.RhythmGameLockIconEffect[i];
			this.LockIconEffectHandles.Add(this.SpawnAttachedEffect(effectPath, "[RhythmGameShipController] Spawn Lock Icon", this.ShipActor.SkeletalMesh, null, delegate([Nullable(new byte[]
			{
				0,
				1,
				1
			})] OneOf<KuroEffectActorHandle, AActor> actor)
			{
				FTransformDouble ftransformDouble = this.ShipActor.SkeletalMesh.D_GetRelativeTransform().Inverse();
				FQuat fquat = new FRotator(0f, 0f, 0f).Quaternion();
				ftransformDouble.SetRotation(fquat);
				FHitResult fhitResult = new FHitResult();
				actor.D_K2_SetActorRelativeTransform(ftransformDouble, false, ref fhitResult, false);
			}));
		}
	}

	// Token: 0x060041BD RID: 16829 RVA: 0x0016F6B8 File Offset: 0x0016D8B8
	public void StopLockIconEffect()
	{
		foreach (int handle in this.LockIconEffectHandles)
		{
			EffectSystem.Instance.StopEffectById(handle, "[RhythmGameShipController] Stop Lock Icon Effect", false, null);
		}
		this.LockIconEffectHandles.Clear();
	}

	// Token: 0x060041BE RID: 16830 RVA: 0x0016F72C File Offset: 0x0016D92C
	public void TriggerTunnelTranslationAnim(bool isLeft)
	{
		if (this.ShipAnimInstance == null)
		{
			return;
		}
		if (isLeft)
		{
			this.ShipAnimInstance.InputSwingL = true;
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ShipAnimInstance.InputSwingL = false;
			}, 20f, null, null, true, 1f);
			return;
		}
		this.ShipAnimInstance.InputSwingR = true;
		TimerSystem.Instance.Delay(delegate(float _)
		{
			this.ShipAnimInstance.InputSwingR = false;
		}, 20f, null, null, true, 1f);
	}

	// Token: 0x060041BF RID: 16831 RVA: 0x0016F7A8 File Offset: 0x0016D9A8
	public void TriggerHitLockEffect()
	{
		if (this.ShipActor == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] ShipActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.LockIconEffectHandles.Count == 0)
		{
			Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] LockIconEffectHandles is empty, no need to trigger hit lock effect", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		string text = RhythmGameModelDefine.RhythmGameLockIconEffect[2];
		if (text == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] HitLockEffect is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.DestroyHitLockEffectHandle != null)
		{
			TimerSystem.Instance.Remove(this.DestroyHitLockEffectHandle);
			this.DestroyHitLockEffectHandle = null;
		}
		if (this.HitLockEffectHandle != -1)
		{
			this.StopEffect(this.HitLockEffectHandle, "[RhythmGameShipController] Trigger Hit Lock Effect");
			this.HitLockEffectHandle = -1;
		}
		this.HitLockEffectHandle = this.SpawnAttachedEffect(text, "[RhythmGameShipController] Trigger Hit Lock Effect", this.ShipActor.SkeletalMesh, null, delegate([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<KuroEffectActorHandle, AActor> actor)
		{
			FTransformDouble ftransformDouble = this.ShipActor.SkeletalMesh.D_GetRelativeTransform().Inverse();
			FQuat fquat = new FRotator(0f, 0f, 0f).Quaternion();
			ftransformDouble.SetRotation(fquat);
			FHitResult fhitResult = new FHitResult();
			actor.D_K2_SetActorRelativeTransform(ftransformDouble, false, ref fhitResult, false);
		});
		this.DestroyHitLockEffectHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			if (this.HitLockEffectHandle != -1)
			{
				EffectSystem.Instance.StopEffectById(this.HitLockEffectHandle, "[RhythmGameShipController] Destroy Hit Lock Effect", false, null);
				this.HitLockEffectHandle = -1;
			}
			this.DestroyHitLockEffectHandle = null;
		}, 500f, null, null, true, 1f);
	}

	// Token: 0x060041C0 RID: 16832 RVA: 0x0016F8D8 File Offset: 0x0016DAD8
	public void TriggerTranslationAnim(bool isLeft)
	{
		if (this.ShipAnimInstance == null)
		{
			return;
		}
		if (isLeft)
		{
			this.ShipAnimInstance.InputMoveL = true;
			this.ShipAnimInstance.Horzontal = -1f;
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ShipAnimInstance.InputMoveL = false;
			}, 20f, null, null, true, 1f);
			return;
		}
		this.ShipAnimInstance.InputMoveR = true;
		this.ShipAnimInstance.Horzontal = 1f;
		TimerSystem.Instance.Delay(delegate(float _)
		{
			this.ShipAnimInstance.InputMoveR = false;
		}, 20f, null, null, true, 1f);
	}

	// Token: 0x060041C1 RID: 16833 RVA: 0x0016F974 File Offset: 0x0016DB74
	public void TriggerRollAnim(bool isLeft)
	{
		if (this.ShipAnimInstance == null)
		{
			return;
		}
		if (isLeft)
		{
			this.ShipAnimInstance.InputRollL = true;
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ShipAnimInstance.InputRollL = false;
			}, 20f, null, null, true, 1f);
			return;
		}
		this.ShipAnimInstance.InputRollR = true;
		TimerSystem.Instance.Delay(delegate(float _)
		{
			this.ShipAnimInstance.InputRollR = false;
		}, 20f, null, null, true, 1f);
	}

	// Token: 0x060041C2 RID: 16834 RVA: 0x0016F9F0 File Offset: 0x0016DBF0
	public void TriggerLineHit()
	{
		if (this.ShipAnimInstance == null)
		{
			return;
		}
		if (this.LineHitIsL3)
		{
			this.ShipAnimInstance.InputRollL3 = true;
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ShipAnimInstance.InputRollL3 = false;
			}, 20f, null, null, true, 1f);
		}
		else
		{
			this.ShipAnimInstance.InputRollR3 = true;
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ShipAnimInstance.InputRollR3 = false;
			}, 20f, null, null, true, 1f);
		}
		this.LineHitIsL3 = !this.LineHitIsL3;
	}

	// Token: 0x060041C3 RID: 16835 RVA: 0x0016FA80 File Offset: 0x0016DC80
	public void TriggerJumpAnim()
	{
		if (this.ShipAnimInstance == null)
		{
			return;
		}
		this.ShipAnimInstance.InputJump = true;
		TimerSystem.Instance.Delay(delegate(float _)
		{
			this.ShipAnimInstance.InputJump = false;
		}, 20f, null, null, true, 1f);
		TimerSystem.Instance.Delay(delegate(float _)
		{
			this.ShipAnimInstance.Horzontal = 0f;
		}, (float)RhythmGameController.Instance.GetCurrentBeatDurationMs(), null, null, true, 1f);
	}

	// Token: 0x060041C4 RID: 16836 RVA: 0x0016FAF0 File Offset: 0x0016DCF0
	public void SpawnStartTrailEffect()
	{
		if (this.ShipActor == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] ShipActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.SparksLineEffectHandle != -1)
		{
			return;
		}
		TsGameSplineActor splineActor = RhythmGameController.Instance.GetSplineActor();
		if (splineActor == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "[RhythmGameShipController] SplineActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		USplineComponent curSplineComponent = RhythmGameModel.Instance.CurSplineComponent;
		float currentSplineDistance = RhythmGameController.Instance.GetRhythmGameShipController().GetCurrentSplineDistance();
		FVectorDouble fvectorDouble = (curSplineComponent != null) ? curSplineComponent.D_GetLocationAtDistanceAlongSpline(currentSplineDistance, ESplineCoordinateSpace.World) : new FVectorDouble();
		FTransformDouble value = new FTransformDouble();
		value.SetLocation(fvectorDouble);
		FQuat fquat = ((curSplineComponent != null) ? curSplineComponent.GetRotationAtDistanceAlongSpline(currentSplineDistance, ESplineCoordinateSpace.World) : new FRotator()).Quaternion();
		value.SetRotation(fquat);
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(value);
		int id = instance.SpawnEffect(world, ftransformDouble, "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_StartTrail.DA_Fx_Group_StartTrail", "[RhythmGameShipController] Spawn Start Trail Effect", null, EEffectType.Scene, null, null, null, false, false);
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(id);
		AActor parent = splineActor;
		FName? fname = null;
		effectActor.K2_AttachToActor(parent, fname, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false);
	}

	// Token: 0x17000943 RID: 2371
	// (get) Token: 0x060041C5 RID: 16837 RVA: 0x0016FC0E File Offset: 0x0016DE0E
	public static RhythmGameShipController Instance
	{
		get
		{
			return RhythmGameShipController._Instance;
		}
	}

	// Token: 0x060041C6 RID: 16838 RVA: 0x0016FC15 File Offset: 0x0016DE15
	public static RhythmGameShipController GetOrCreateInstance()
	{
		if (RhythmGameShipController._Instance == null)
		{
			RhythmGameShipController.CreateInstance();
		}
		return RhythmGameShipController._Instance;
	}

	// Token: 0x060041C7 RID: 16839 RVA: 0x0016FC29 File Offset: 0x0016DE29
	public static bool CreateInstance()
	{
		if (RhythmGameShipController._Instance != null)
		{
			return true;
		}
		RhythmGameShipController._Instance = new RhythmGameShipController();
		return true;
	}

	// Token: 0x060041C8 RID: 16840 RVA: 0x0016FC3F File Offset: 0x0016DE3F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060041C9 RID: 16841 RVA: 0x0016FC41 File Offset: 0x0016DE41
	public static void ResetStaticDefaultValue()
	{
		RhythmGameShipController._Instance = null;
	}

	// Token: 0x060041CA RID: 16842 RVA: 0x0016FC49 File Offset: 0x0016DE49
	static RhythmGameShipController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RhythmGameShipController.CreateStaticDefaultValue), new Action(RhythmGameShipController.ResetStaticDefaultValue));
	}

	// Token: 0x04003393 RID: 13203
	[Nullable(2)]
	private BP_Plane_C ShipActor;

	// Token: 0x04003394 RID: 13204
	[Nullable(2)]
	private ABP_Plane_C ShipAnimInstance;

	// Token: 0x04003395 RID: 13205
	private int FireEffectHandle = -1;

	// Token: 0x04003396 RID: 13206
	private bool LineHitIsL3 = true;

	// Token: 0x04003397 RID: 13207
	private readonly List<int> LockIconEffectHandles = new List<int>();

	// Token: 0x04003398 RID: 13208
	private int HitLockEffectHandle = -1;

	// Token: 0x04003399 RID: 13209
	[Nullable(2)]
	private TimerHandle DestroyHitLockEffectHandle;

	// Token: 0x0400339A RID: 13210
	private readonly List<int> HighSpeedEffectHandles = new List<int>();

	// Token: 0x0400339B RID: 13211
	private readonly List<int> FeverEffectHandles = new List<int>();

	// Token: 0x0400339C RID: 13212
	private int FireworksEffectHandle = -1;

	// Token: 0x0400339D RID: 13213
	private int SparksLineEffectHandle = -1;

	// Token: 0x0400339E RID: 13214
	[Nullable(2)]
	private static RhythmGameShipController _Instance;
}
