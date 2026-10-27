using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.RhythmGame;
using AkiClient.Game.Aki.Data.Level.PlaneYinyou.BP;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x0200108A RID: 4234
[NullableContext(1)]
[Nullable(0)]
public class RhythmGameShipController : ControllerBase
{
	// Token: 0x06006E19 RID: 28185 RVA: 0x00166418 File Offset: 0x00164618
	public void Initialize(BP_Plane_C shipActor)
	{
		this.ShipActor = shipActor;
		USkeletalMeshComponent skeletalMesh = shipActor.SkeletalMesh;
		this.ShipAnimInstance = (((skeletalMesh != null) ? skeletalMesh.GetAnimInstance() : null) as ABP_Plane_C);
		this.SwitchFireLevel();
		this.SpawnLockIcon();
		EventSystem.Instance.Add(EEventName.OnRhythmGameSpeedLevelConfigIndexChanged, new Action<int>(this.OnSpeedLevelChanged));
	}

	// Token: 0x06006E1A RID: 28186 RVA: 0x00166474 File Offset: 0x00164674
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

	// Token: 0x06006E1B RID: 28187 RVA: 0x00166648 File Offset: 0x00164848
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

	// Token: 0x06006E1C RID: 28188 RVA: 0x00166698 File Offset: 0x00164898
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

	// Token: 0x06006E1D RID: 28189 RVA: 0x001666F8 File Offset: 0x001648F8
	private void StopEffect(int handle, string logContext)
	{
		if (handle != -1)
		{
			EffectSystem.Instance.StopEffectById(handle, logContext, false, null);
		}
	}

	// Token: 0x06006E1E RID: 28190 RVA: 0x00166720 File Offset: 0x00164920
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

	// Token: 0x06006E1F RID: 28191 RVA: 0x001667F8 File Offset: 0x001649F8
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

	// Token: 0x06006E20 RID: 28192 RVA: 0x001668A0 File Offset: 0x00164AA0
	private void StopHighSpeedEffect()
	{
		foreach (int handle in this.HighSpeedEffectHandles)
		{
			EffectSystem.Instance.StopEffectById(handle, "[RhythmGameShipController] Stop High Speed Effect", false, null);
		}
		this.HighSpeedEffectHandles.Clear();
	}

	// Token: 0x06006E21 RID: 28193 RVA: 0x00166914 File Offset: 0x00164B14
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

	// Token: 0x06006E22 RID: 28194 RVA: 0x001669BC File Offset: 0x00164BBC
	private void StopFeverEffect()
	{
		foreach (int handle in this.FeverEffectHandles)
		{
			EffectSystem.Instance.StopEffectById(handle, "[RhythmGameShipController] Stop Fever Effect", false, null);
		}
		this.FeverEffectHandles.Clear();
	}

	// Token: 0x06006E23 RID: 28195 RVA: 0x00166A30 File Offset: 0x00164C30
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

	// Token: 0x06006E24 RID: 28196 RVA: 0x00166B68 File Offset: 0x00164D68
	private void StopFireworksEffect()
	{
		if (this.FireworksEffectHandle != -1)
		{
			EffectSystem.Instance.StopEffectById(this.FireworksEffectHandle, "[RhythmGameShipController] Stop Fireworks Effect", false, null);
			this.FireworksEffectHandle = -1;
		}
	}

	// Token: 0x06006E25 RID: 28197 RVA: 0x00166BA8 File Offset: 0x00164DA8
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

	// Token: 0x06006E26 RID: 28198 RVA: 0x00166CD0 File Offset: 0x00164ED0
	private void StopSparksLineEffect()
	{
		if (this.SparksLineEffectHandle != -1)
		{
			EffectSystem.Instance.StopEffectById(this.SparksLineEffectHandle, "[RhythmGameShipController] Stop Sparks Line Effect", false, null);
			this.SparksLineEffectHandle = -1;
		}
	}

	// Token: 0x06006E27 RID: 28199 RVA: 0x00166D10 File Offset: 0x00164F10
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

	// Token: 0x06006E28 RID: 28200 RVA: 0x00166D84 File Offset: 0x00164F84
	public void StopLockIconEffect()
	{
		foreach (int handle in this.LockIconEffectHandles)
		{
			EffectSystem.Instance.StopEffectById(handle, "[RhythmGameShipController] Stop Lock Icon Effect", false, null);
		}
		this.LockIconEffectHandles.Clear();
	}

	// Token: 0x06006E29 RID: 28201 RVA: 0x00166DF8 File Offset: 0x00164FF8
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

	// Token: 0x06006E2A RID: 28202 RVA: 0x00166E74 File Offset: 0x00165074
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

	// Token: 0x06006E2B RID: 28203 RVA: 0x00166FA4 File Offset: 0x001651A4
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

	// Token: 0x06006E2C RID: 28204 RVA: 0x00167040 File Offset: 0x00165240
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

	// Token: 0x06006E2D RID: 28205 RVA: 0x001670BC File Offset: 0x001652BC
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

	// Token: 0x06006E2E RID: 28206 RVA: 0x0016714C File Offset: 0x0016534C
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

	// Token: 0x06006E2F RID: 28207 RVA: 0x001671BC File Offset: 0x001653BC
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

	// Token: 0x17000923 RID: 2339
	// (get) Token: 0x06006E30 RID: 28208 RVA: 0x001672DA File Offset: 0x001654DA
	public static RhythmGameShipController Instance
	{
		get
		{
			return RhythmGameShipController._Instance;
		}
	}

	// Token: 0x06006E31 RID: 28209 RVA: 0x001672E1 File Offset: 0x001654E1
	public static RhythmGameShipController GetOrCreateInstance()
	{
		if (RhythmGameShipController._Instance == null)
		{
			RhythmGameShipController.CreateInstance();
		}
		return RhythmGameShipController._Instance;
	}

	// Token: 0x06006E32 RID: 28210 RVA: 0x001672F5 File Offset: 0x001654F5
	public static bool CreateInstance()
	{
		if (RhythmGameShipController._Instance != null)
		{
			return true;
		}
		RhythmGameShipController._Instance = new RhythmGameShipController();
		return true;
	}

	// Token: 0x06006E33 RID: 28211 RVA: 0x0016730B File Offset: 0x0016550B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006E34 RID: 28212 RVA: 0x0016730D File Offset: 0x0016550D
	public static void ResetStaticDefaultValue()
	{
		RhythmGameShipController._Instance = null;
	}

	// Token: 0x06006E35 RID: 28213 RVA: 0x00167315 File Offset: 0x00165515
	static RhythmGameShipController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RhythmGameShipController.CreateStaticDefaultValue), new Action(RhythmGameShipController.ResetStaticDefaultValue));
	}

	// Token: 0x040032FA RID: 13050
	[Nullable(2)]
	private BP_Plane_C ShipActor;

	// Token: 0x040032FB RID: 13051
	[Nullable(2)]
	private ABP_Plane_C ShipAnimInstance;

	// Token: 0x040032FC RID: 13052
	private int FireEffectHandle = -1;

	// Token: 0x040032FD RID: 13053
	private bool LineHitIsL3 = true;

	// Token: 0x040032FE RID: 13054
	private readonly List<int> LockIconEffectHandles = new List<int>();

	// Token: 0x040032FF RID: 13055
	private int HitLockEffectHandle = -1;

	// Token: 0x04003300 RID: 13056
	[Nullable(2)]
	private TimerHandle DestroyHitLockEffectHandle;

	// Token: 0x04003301 RID: 13057
	private readonly List<int> HighSpeedEffectHandles = new List<int>();

	// Token: 0x04003302 RID: 13058
	private readonly List<int> FeverEffectHandles = new List<int>();

	// Token: 0x04003303 RID: 13059
	private int FireworksEffectHandle = -1;

	// Token: 0x04003304 RID: 13060
	private int SparksLineEffectHandle = -1;

	// Token: 0x04003305 RID: 13061
	[Nullable(2)]
	private static RhythmGameShipController _Instance;
}
