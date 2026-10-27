using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002FBB RID: 12219
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueEffect : GameplayCueMagnitude
{
	// Token: 0x06019E71 RID: 106097 RVA: 0x006C56F4 File Offset: 0x006C38F4
	protected unsafe override void OnInit()
	{
		base.OnInit();
		if (this.IsInstant && this.CueConfig.Magni != 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "瞬间型Buff特效不能应用特效幅度，因为瞬间型Buff特效依赖特效自身管理生命周期";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BuffId", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		Aki.Config.Vector value = this.CueConfig.Location.Value;
		Aki.Config.Vector value2 = this.CueConfig.Rotation.Value;
		Aki.Config.Vector value3 = this.CueConfig.Scale.Value;
		FVector fvector = new FVector(value.X, value.Y, value.Z);
		FRotator frotator = new FRotator(value2.X, value2.Y, value2.Z);
		FVector fvector2 = new FVector(value3.X, value3.Y, value3.Z);
		this.RelativeTransform = Transform.Create(frotator.Quaternion(), fvector, fvector2);
		this.ApplyRelativeTransformOverride(base.InitCueParam.RelativePositionOverride, base.InitCueParam.RelativeRotationOverride, base.InitCueParam.ScaleOverride);
		if (this.CueConfig.ParametersLength == 0 || this.CueConfig.Parameters(0) != "0")
		{
			this.IsSeekNeedProcess = true;
			return;
		}
		this.IsSeekNeedProcess = false;
	}

	// Token: 0x06019E72 RID: 106098 RVA: 0x006C589A File Offset: 0x006C3A9A
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
	}

	// Token: 0x06019E73 RID: 106099 RVA: 0x006C58A4 File Offset: 0x006C3AA4
	protected override void OnCreate()
	{
		this.SetTargetMeshAndSocket();
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(this.RelativeTransform.ToUeTransform());
		this.EffectViewHandle = instance.SpawnEffect(world, ftransformDouble, base.GetPath(), "[GameplayCueEffect.OnCreate]", this.CreateEffectContext(), EEffectType.Fight, delegate(int handle)
		{
			Action beginCallback = this.BeginCallback;
			if (beginCallback != null)
			{
				beginCallback();
			}
			if (this.UseMagnitude())
			{
				EffectSystem.Instance.FreezeHandle(handle, true, false);
			}
		}, null, null, false, false);
		if (!this.IsValidEffect())
		{
			return;
		}
		this.EffectTimeScaleType = this.GetEffectTimeScaleType();
		this.CueComp.AddCueEffectToSet(this.EffectViewHandle, this.EffectTimeScaleType, (ECueHideRule)this.CueConfig.HideRule);
		this.AttachEffect(false);
		this.AddFinishCallback();
		base.OnCreate();
	}

	// Token: 0x06019E74 RID: 106100 RVA: 0x006C594C File Offset: 0x006C3B4C
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			EffectSystem.Instance.SetTimeScale(this.EffectViewHandle, 1f, false);
			switch (this.CueConfig.EndRule)
			{
			case 0:
				EffectSystem.Instance.StopEffectById(this.EffectViewHandle, "[GameplayCueEffect.OnDestroy]", true, null);
				break;
			case 1:
				this.ListenForeverTimeScale();
				EffectSystem.Instance.StopEffectById(this.EffectViewHandle, "[GameplayCueEffect.OnDestroy]", this.IsForceRecycle, null);
				break;
			case 2:
				EffectSystem.Instance.FreezeHandle(this.EffectViewHandle, false, false);
				this.ListenForeverTimeScale();
				EffectSystem.Instance.StopEffectById(this.EffectViewHandle, "[GameplayCueEffect.OnDestroy]", this.IsForceRecycle, null);
				break;
			}
		}
		if (this.CueConfig.Comp == 2)
		{
			CharacterWeapon targetCharacterWeapon = this.TargetCharacterWeapon;
			if (targetCharacterWeapon != null)
			{
				targetCharacterWeapon.RemoveBuffEffect(this.EffectViewHandle);
			}
			this.RemoveWeaponRefreshListener();
		}
		if (this.IsListenScaleChanged)
		{
			this.RemoveMorphTypeChangedListener();
		}
	}

	// Token: 0x06019E75 RID: 106101 RVA: 0x006C5A72 File Offset: 0x006C3C72
	protected override void OnSetMagnitude(float normalizedValue)
	{
		if (this.IsSeekNeedProcess)
		{
			EffectSystem.Instance.HandleSeekToTimeWithProcess(this.EffectViewHandle, normalizedValue, true, -1f);
			return;
		}
		EffectSystem.Instance.HandleSeekToTime(this.EffectViewHandle, normalizedValue, true, false);
	}

	// Token: 0x06019E76 RID: 106102 RVA: 0x006C5AA8 File Offset: 0x006C3CA8
	public override void OnChangeRole(EntityHandle newEntityHandle)
	{
		base.OnChangeRole(newEntityHandle);
		this.RefreshEffectStatus(true);
	}

	// Token: 0x06019E77 RID: 106103 RVA: 0x006C5AB8 File Offset: 0x006C3CB8
	public void SyncMagnitude(GameplayCueEffect cueRef)
	{
		float passTime = EffectSystem.Instance.GetPassTime(cueRef.EffectViewHandle);
		EffectSystem.Instance.HandleSeekToTime(this.EffectViewHandle, passTime, true, false);
	}

	// Token: 0x06019E78 RID: 106104 RVA: 0x006C5AEA File Offset: 0x006C3CEA
	protected virtual void RefreshEffectStatus(bool onChangeRole)
	{
		this.SetTargetMeshAndSocket();
		this.AttachEffect(onChangeRole);
		EffectSystem.Instance.AttachSkeletalMesh(this.EffectViewHandle, this.CreateEffectContext());
	}

	// Token: 0x06019E79 RID: 106105 RVA: 0x006C5B10 File Offset: 0x006C3D10
	protected virtual void AttachEffect(bool onChangeRole = false)
	{
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.EffectViewHandle);
		if (this.CueConfig.Comp == 1 || this.CueConfig.Comp == 2)
		{
			this.ScaleEffect(effectActor);
			effectActor.K2_AttachToComponent(this.TargetMesh, new FName?(this.TargetSocket), (EAttachmentRule)this.CueConfig.LocRule, (EAttachmentRule)this.CueConfig.RotaRule, (EAttachmentRule)this.CueConfig.SclRule, false);
			if (this.CueConfig.Comp == 2)
			{
				CharacterWeapon targetCharacterWeapon = this.TargetCharacterWeapon;
				if (targetCharacterWeapon == null)
				{
					return;
				}
				targetCharacterWeapon.AddBuffEffect(this.EffectViewHandle);
				return;
			}
		}
		else if (!onChangeRole)
		{
			Transform socketTransform = this.SocketTransform;
			FTransformDouble ftransformDouble = this.TargetMesh.D_GetSocketTransform(this.TargetSocket, ERelativeTransformSpace.RTS_World);
			socketTransform.FromUeTransform(ftransformDouble);
			this.RelativeTransform.ComposeTransforms(this.SocketTransform, this.TargetTransform);
			OneOf<KuroEffectActorHandle, AActor> self = effectActor;
			ftransformDouble = this.TargetTransform.ToUeTransform();
			self.D_K2_SetActorTransform(ftransformDouble, false, ref WorldGlobal.SweepHitResult, true);
		}
	}

	// Token: 0x06019E7A RID: 106106 RVA: 0x006C5C08 File Offset: 0x006C3E08
	protected unsafe virtual void SetTargetMeshAndSocket()
	{
		if (this.CueConfig.Comp == 2)
		{
			this.TargetCharacterWeapon = this.GetCharacterWeapon();
			CharacterWeapon targetCharacterWeapon = this.TargetCharacterWeapon;
			bool? flag;
			if (targetCharacterWeapon == null)
			{
				flag = null;
			}
			else
			{
				UMeshComponent mesh = targetCharacterWeapon.Mesh;
				flag = ((mesh != null) ? new bool?(mesh.IsValid()) : null);
			}
			bool? flag2 = flag;
			bool valueOrDefault = flag2.GetValueOrDefault();
			CharacterWeapon targetCharacterWeapon2 = this.TargetCharacterWeapon;
			USkeletalMeshComponent uskeletalMeshComponent = ((targetCharacterWeapon2 != null) ? targetCharacterWeapon2.Mesh : null) as USkeletalMeshComponent;
			if (uskeletalMeshComponent != null && valueOrDefault)
			{
				this.TargetMesh = uskeletalMeshComponent;
			}
			else
			{
				this.TargetMesh = null;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "GameplayCueEffect.SetTargetMeshAndSocket, 找不到武器Mesh或者武器Mesh不是SkeletalMeshComponent";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CharacterWeapon", this.TargetCharacterWeapon != null);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item = "Weapon";
				object item2;
				if (!valueOrDefault)
				{
					item2 = "";
				}
				else
				{
					CharacterWeapon targetCharacterWeapon3 = this.TargetCharacterWeapon;
					if (targetCharacterWeapon3 == null)
					{
						item2 = null;
					}
					else
					{
						UMeshComponent mesh2 = targetCharacterWeapon3.Mesh;
						item2 = ((mesh2 != null) ? mesh2.GetName() : null);
					}
				}
				ptr = new ValueTuple<string, object>(item, item2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("IsValid", valueOrDefault);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
		}
		else
		{
			this.TargetMesh = this.GetAttachedComponent();
		}
		this.TargetSocket = FNameUtil.GetDynamicFName(this.CueConfig.Socket).Value;
		USkeletalMeshComponent targetMesh = this.TargetMesh;
		if (targetMesh == null || !targetMesh.DoesSocketExist(this.TargetSocket))
		{
			this.TargetSocket = CharacterNameDefines.Instance.ROOT;
			if (this.CueConfig.Comp == 2)
			{
				this.AddWeaponRefreshListener();
			}
		}
		string socketNameOverride = base.InitCueParam.SocketNameOverride;
		if (socketNameOverride != null)
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName(socketNameOverride);
			if (dynamicFName != null)
			{
				USkeletalMeshComponent targetMesh2 = this.TargetMesh;
				if (targetMesh2 != null && targetMesh2.DoesSocketExist(dynamicFName.Value))
				{
					this.TargetSocket = dynamicFName.Value;
					return;
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderEffect;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[FxEmote] 覆盖挂点不存在于目标Mesh，保持原挂点";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SocketOverride", socketNameOverride);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
	}

	// Token: 0x06019E7B RID: 106107 RVA: 0x006C5E90 File Offset: 0x006C4090
	public override void OnGameplayCueEffectOverride(IGameplayCueEffectOverride @override)
	{
		if (@override.SocketName != null)
		{
			this.SetSocketAndReattach(@override.SocketName);
		}
		if (@override.RelativePosition == null && @override.RelativeRotation == null && @override.Scale == null)
		{
			return;
		}
		this.ApplyRelativeTransformOverride(@override.RelativePosition, @override.RelativeRotation, @override.Scale);
		this.AttachEffect(false);
	}

	// Token: 0x06019E7C RID: 106108 RVA: 0x006C5F04 File Offset: 0x006C4104
	private void ApplyRelativeTransformOverride(FVector? position, FVector? rotation, FVector? scale)
	{
		if (this.RelativeTransform == null)
		{
			return;
		}
		if (position != null)
		{
			this.RelativeTransform.SetLocation(global::Vector.Create((double)position.Value.X, (double)position.Value.Y, (double)position.Value.Z));
		}
		if (rotation != null)
		{
			FRotator frotator = new FRotator(rotation.Value.X, rotation.Value.Y, rotation.Value.Z);
			this.RelativeTransform.SetRotation(frotator.Quaternion());
		}
		if (scale != null)
		{
			this.RelativeTransform.SetScale3D(global::Vector.Create((double)scale.Value.X, (double)scale.Value.Y, (double)scale.Value.Z));
		}
	}

	// Token: 0x06019E7D RID: 106109 RVA: 0x006C5FE8 File Offset: 0x006C41E8
	public void SetSocketAndReattach(string socketName)
	{
		if (this.TargetMesh == null)
		{
			return;
		}
		FName? dynamicFName = FNameUtil.GetDynamicFName(socketName);
		if (dynamicFName != null && this.TargetMesh.DoesSocketExist(dynamicFName.Value))
		{
			this.TargetSocket = dynamicFName.Value;
		}
		else
		{
			this.TargetSocket = CharacterNameDefines.Instance.ROOT;
		}
		this.AttachEffect(false);
	}

	// Token: 0x06019E7E RID: 106110 RVA: 0x006C6048 File Offset: 0x006C4248
	protected virtual SkeletalMeshEffectContext CreateEffectContext()
	{
		return new SkeletalMeshEffectContext(null, null, false)
		{
			SkeletalMeshComp = this.TargetMesh,
			EntityId = new int?(this.EntityHandle.Id)
		};
	}

	// Token: 0x06019E7F RID: 106111 RVA: 0x006C6088 File Offset: 0x006C4288
	private void ListenForeverTimeScale()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		PawnTimeScaleComponent pawnTimeScaleComponent = (entity != null) ? entity.GetComponent<PawnTimeScaleComponent>() : null;
		if (!pawnTimeScaleComponent)
		{
			return;
		}
		if (this.EffectTimeScaleType == ETimeScaleType.FollowEntity)
		{
			EffectUtil.ListenForeverTimeScale(this.EffectViewHandle, pawnTimeScaleComponent);
		}
	}

	// Token: 0x06019E80 RID: 106112 RVA: 0x006C60CC File Offset: 0x006C42CC
	[NullableContext(2)]
	private USkeletalMeshComponent GetAttachedComponent()
	{
		if (!this.ActorInternal.IsValid())
		{
			return null;
		}
		if (this.CueConfig.CompName == "Mesh")
		{
			return this.ActorInternal.Mesh;
		}
		foreach (UActorComponent uactorComponent in this.ActorInternal.K2_GetComponentsByClass(UMeshComponent.StaticClass()))
		{
			USkeletalMeshComponent uskeletalMeshComponent = uactorComponent as USkeletalMeshComponent;
			if (uskeletalMeshComponent != null && uactorComponent.GetName() == this.CueConfig.CompName)
			{
				return uskeletalMeshComponent;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.HXY;
		string message = "Cue信息错误！或者无法找到合适的组件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06019E81 RID: 106113 RVA: 0x006C61B4 File Offset: 0x006C43B4
	[NullableContext(2)]
	private CharacterWeaponComponent GetWeaponComponent()
	{
		if (!this.ActorInternal.IsValid() || this.CueConfig.Comp != 2)
		{
			return null;
		}
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterWeaponComponent characterWeaponComponent = (entity != null) ? entity.GetComponent<CharacterWeaponComponent>() : null;
		if (characterWeaponComponent == null || !characterWeaponComponent.Valid)
		{
			return null;
		}
		return characterWeaponComponent;
	}

	// Token: 0x06019E82 RID: 106114 RVA: 0x006C6204 File Offset: 0x006C4404
	[NullableContext(2)]
	private CharacterWeapon GetCharacterWeapon()
	{
		if (!this.ActorInternal.IsValid() || this.CueConfig.Comp != 2)
		{
			return null;
		}
		CharacterWeaponComponent weaponComponent = this.GetWeaponComponent();
		if (weaponComponent == null)
		{
			return null;
		}
		CharacterWeaponMesh weaponMesh = weaponComponent.GetWeaponMesh();
		if (weaponMesh == null)
		{
			return null;
		}
		int num;
		if (!int.TryParse(this.CueConfig.CompName.Replace("WeaponCase", ""), out num))
		{
			return null;
		}
		if (num < 0 || num >= weaponMesh.CharacterWeapons.Length)
		{
			return null;
		}
		return weaponMesh.CharacterWeapons[num];
	}

	// Token: 0x06019E83 RID: 106115 RVA: 0x006C6284 File Offset: 0x006C4484
	private void ScaleEffect([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<KuroEffectActorHandle, AActor> effectActor)
	{
		float num = this.CueConfig.TargetScaleUp(0);
		float num2 = this.CueConfig.TargetScaleUp(1);
		if (num >= num2)
		{
			return;
		}
		if (!this.IsInitScaleEffect)
		{
			this.IsInitScaleEffect = true;
			this.OriginScale = effectActor.D_GetActorScale3D();
			WorldEntity entity = this.EntityHandle.Entity;
			bool flag;
			if (entity == null)
			{
				flag = false;
			}
			else
			{
				CharacterMorphComponent component = entity.GetComponent<CharacterMorphComponent>();
				flag = ((component != null) ? new bool?(component.IsEnableMorph()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				this.IsListenScaleChanged = true;
				this.AddMorphTypeChangedListener();
			}
		}
		FVector fvector = new FVector();
		FVector fvector2 = new FVector();
		float num3 = 0f;
		UKismetSystemLibrary.GetComponentBounds(this.TargetMesh, ref fvector, ref fvector2, ref num3);
		float num4 = fvector2.X / 50f * fvector2.Y / 50f * fvector2.Z / 50f;
		num4 = MathUtils.Instance.Clamp(num4, 5f, 60f);
		float num5 = (num4 - 5f) / 55f * (num2 - num) + num;
		FVectorDouble fvectorDouble = this.OriginScale * (double)num5;
		effectActor.D_SetActorScale3D(fvectorDouble);
	}

	// Token: 0x06019E84 RID: 106116 RVA: 0x006C63A8 File Offset: 0x006C45A8
	private bool IsValidEffect()
	{
		return EffectSystem.Instance.IsValid(this.EffectViewHandle) && EffectSystem.Instance.GetEffectActor(this.EffectViewHandle).IsValid();
	}

	// Token: 0x06019E85 RID: 106117 RVA: 0x006C63D8 File Offset: 0x006C45D8
	private void AddFinishCallback()
	{
		if (this.EndCallback != null && !this.IsInstant)
		{
			EffectSystem.Instance.AddFinishCallback(this.EffectViewHandle, delegate(int _)
			{
				Action endCallback = this.EndCallback;
				if (endCallback == null)
				{
					return;
				}
				endCallback();
			});
		}
	}

	// Token: 0x06019E86 RID: 106118 RVA: 0x006C6408 File Offset: 0x006C4608
	private ETimeScaleType GetEffectTimeScaleType()
	{
		if (this.BuffHandleId <= 0)
		{
			return ETimeScaleType.FollowEntity;
		}
		WorldEntity entity = this.EntityHandle.Entity;
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		IActiveBuff activeBuff = (baseBuffComponent != null) ? baseBuffComponent.GetBuffByHandle(this.BuffHandleId) : null;
		if (activeBuff == null)
		{
			return ETimeScaleType.FollowEntity;
		}
		Entity instigator = activeBuff.GetInstigator();
		bool? flag;
		if (instigator == null)
		{
			flag = null;
		}
		else
		{
			CreatureDataComponent component = instigator.GetComponent<CreatureDataComponent>();
			flag = ((component != null) ? new bool?(component.IsRole()) : null);
		}
		bool? flag2 = flag;
		if (!flag2.GetValueOrDefault())
		{
			return ETimeScaleType.FollowEntity;
		}
		return ETimeScaleType.ImmuneForeverTimeScale;
	}

	// Token: 0x06019E87 RID: 106119 RVA: 0x006C6490 File Offset: 0x006C4690
	private void AddWeaponRefreshListener()
	{
		if (this.IsInstant)
		{
			return;
		}
		WorldEntity entity = this.EntityHandle.Entity;
		if (entity == null || !entity.Valid)
		{
			return;
		}
		if (!EventSystem.Instance.HasWithTarget(entity, EEventName.CharacterWeaponLoaded, new Action<string>(this.OnCharacterWeaponLoaded)))
		{
			EventSystem.Instance.AddWithTarget<string>(entity, EEventName.CharacterWeaponLoaded, new Action<string>(this.OnCharacterWeaponLoaded));
		}
	}

	// Token: 0x06019E88 RID: 106120 RVA: 0x006C6500 File Offset: 0x006C4700
	private void RemoveWeaponRefreshListener()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		if (entity == null)
		{
			return;
		}
		if (EventSystem.Instance.HasWithTarget(entity, EEventName.CharacterWeaponLoaded, new Action<string>(this.OnCharacterWeaponLoaded)))
		{
			EventSystem.Instance.RemoveWithTarget<string>(entity, EEventName.CharacterWeaponLoaded, new Action<string>(this.OnCharacterWeaponLoaded));
		}
	}

	// Token: 0x06019E89 RID: 106121 RVA: 0x006C6558 File Offset: 0x006C4758
	private unsafe void OnCharacterWeaponLoaded(string weaponCaseName)
	{
		USkeletalMeshComponent targetMesh = this.TargetMesh;
		if (targetMesh == null || !targetMesh.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "GameplayCueEffect.OnCharacterWeaponLoaded, TargetMesh已无效";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CompName", this.CueConfig.CompName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("WeaponCaseName", weaponCaseName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TargetMesh", this.TargetMesh);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4);
			string item = "IsValid";
			USkeletalMeshComponent targetMesh2 = this.TargetMesh;
			ptr = new ValueTuple<string, object>(item, (targetMesh2 != null) ? new bool?(targetMesh2.IsValid()) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return;
		}
		if (this.TargetMesh.GetName() != weaponCaseName)
		{
			return;
		}
		this.SetTargetMeshAndSocket();
		this.AttachEffect(false);
		this.RemoveWeaponRefreshListener();
	}

	// Token: 0x06019E8A RID: 106122 RVA: 0x006C6684 File Offset: 0x006C4884
	private void AddMorphTypeChangedListener()
	{
		if (this.IsInstant)
		{
			return;
		}
		WorldEntity entity = this.EntityHandle.Entity;
		if (entity == null || !entity.Valid)
		{
			return;
		}
		if (!EventSystem.Instance.HasWithTarget(entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged)))
		{
			EventSystem.Instance.AddWithTarget<Entity, EMorphType, EMorphType>(entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		}
	}

	// Token: 0x06019E8B RID: 106123 RVA: 0x006C66F4 File Offset: 0x006C48F4
	private void RemoveMorphTypeChangedListener()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		if (entity == null)
		{
			return;
		}
		if (EventSystem.Instance.HasWithTarget(entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged)))
		{
			EventSystem.Instance.RemoveWithTarget<Entity, EMorphType, EMorphType>(entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		}
	}

	// Token: 0x06019E8C RID: 106124 RVA: 0x006C674C File Offset: 0x006C494C
	private void OnCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType)
	{
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.EffectViewHandle);
		if (effectActor.HasValue)
		{
			this.ScaleEffect(effectActor);
		}
	}

	// Token: 0x0400C3F1 RID: 50161
	private const float RATE = 50f;

	// Token: 0x0400C3F2 RID: 50162
	private const float VOLUME_MIN = 5f;

	// Token: 0x0400C3F3 RID: 50163
	private const float VOLUME_MAX = 60f;

	// Token: 0x0400C3F4 RID: 50164
	public int EffectViewHandle;

	// Token: 0x0400C3F5 RID: 50165
	[Nullable(2)]
	protected USkeletalMeshComponent TargetMesh;

	// Token: 0x0400C3F6 RID: 50166
	protected FName TargetSocket;

	// Token: 0x0400C3F7 RID: 50167
	[Nullable(2)]
	private CharacterWeapon TargetCharacterWeapon;

	// Token: 0x0400C3F8 RID: 50168
	[Nullable(2)]
	protected Transform RelativeTransform;

	// Token: 0x0400C3F9 RID: 50169
	protected bool IsSeekNeedProcess;

	// Token: 0x0400C3FA RID: 50170
	protected readonly Transform SocketTransform = Transform.Create();

	// Token: 0x0400C3FB RID: 50171
	protected readonly Transform TargetTransform = Transform.Create();

	// Token: 0x0400C3FC RID: 50172
	protected ETimeScaleType EffectTimeScaleType;

	// Token: 0x0400C3FD RID: 50173
	protected bool IsInitScaleEffect;

	// Token: 0x0400C3FE RID: 50174
	protected FVectorDouble OriginScale;

	// Token: 0x0400C3FF RID: 50175
	protected bool IsListenScaleChanged;

	// Token: 0x0400C400 RID: 50176
	public bool IsForceRecycle;
}
