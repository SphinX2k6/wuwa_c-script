using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x0200250F RID: 9487
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueEffect : GameplayCueMagnitude
{
	// Token: 0x06017783 RID: 96131 RVA: 0x006EBFB8 File Offset: 0x006EA1B8
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

	// Token: 0x06017784 RID: 96132 RVA: 0x006EC15E File Offset: 0x006EA35E
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
	}

	// Token: 0x06017785 RID: 96133 RVA: 0x006EC168 File Offset: 0x006EA368
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

	// Token: 0x06017786 RID: 96134 RVA: 0x006EC210 File Offset: 0x006EA410
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

	// Token: 0x06017787 RID: 96135 RVA: 0x006EC336 File Offset: 0x006EA536
	protected override void OnSetMagnitude(float normalizedValue)
	{
		if (this.IsSeekNeedProcess)
		{
			EffectSystem.Instance.HandleSeekToTimeWithProcess(this.EffectViewHandle, normalizedValue, true, -1f);
			return;
		}
		EffectSystem.Instance.HandleSeekToTime(this.EffectViewHandle, normalizedValue, true, false);
	}

	// Token: 0x06017788 RID: 96136 RVA: 0x006EC36C File Offset: 0x006EA56C
	public override void OnChangeRole(EntityHandle newEntityHandle)
	{
		base.OnChangeRole(newEntityHandle);
		this.RefreshEffectStatus(true);
	}

	// Token: 0x06017789 RID: 96137 RVA: 0x006EC37C File Offset: 0x006EA57C
	public void SyncMagnitude(GameplayCueEffect cueRef)
	{
		float passTime = EffectSystem.Instance.GetPassTime(cueRef.EffectViewHandle);
		EffectSystem.Instance.HandleSeekToTime(this.EffectViewHandle, passTime, true, false);
	}

	// Token: 0x0601778A RID: 96138 RVA: 0x006EC3AE File Offset: 0x006EA5AE
	protected virtual void RefreshEffectStatus(bool onChangeRole)
	{
		this.SetTargetMeshAndSocket();
		this.AttachEffect(onChangeRole);
		EffectSystem.Instance.AttachSkeletalMesh(this.EffectViewHandle, this.CreateEffectContext());
	}

	// Token: 0x0601778B RID: 96139 RVA: 0x006EC3D4 File Offset: 0x006EA5D4
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

	// Token: 0x0601778C RID: 96140 RVA: 0x006EC4CC File Offset: 0x006EA6CC
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

	// Token: 0x0601778D RID: 96141 RVA: 0x006EC754 File Offset: 0x006EA954
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

	// Token: 0x0601778E RID: 96142 RVA: 0x006EC7C8 File Offset: 0x006EA9C8
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

	// Token: 0x0601778F RID: 96143 RVA: 0x006EC8AC File Offset: 0x006EAAAC
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

	// Token: 0x06017790 RID: 96144 RVA: 0x006EC90C File Offset: 0x006EAB0C
	protected virtual SkeletalMeshEffectContext CreateEffectContext()
	{
		return new SkeletalMeshEffectContext(null, null, false)
		{
			SkeletalMeshComp = this.TargetMesh,
			EntityId = new int?(this.EntityHandle.Id)
		};
	}

	// Token: 0x06017791 RID: 96145 RVA: 0x006EC94C File Offset: 0x006EAB4C
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

	// Token: 0x06017792 RID: 96146 RVA: 0x006EC990 File Offset: 0x006EAB90
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

	// Token: 0x06017793 RID: 96147 RVA: 0x006ECA80 File Offset: 0x006EAC80
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

	// Token: 0x06017794 RID: 96148 RVA: 0x006ECAD0 File Offset: 0x006EACD0
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

	// Token: 0x06017795 RID: 96149 RVA: 0x006ECB50 File Offset: 0x006EAD50
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

	// Token: 0x06017796 RID: 96150 RVA: 0x006ECC74 File Offset: 0x006EAE74
	private bool IsValidEffect()
	{
		return EffectSystem.Instance.IsValid(this.EffectViewHandle) && EffectSystem.Instance.GetEffectActor(this.EffectViewHandle).IsValid();
	}

	// Token: 0x06017797 RID: 96151 RVA: 0x006ECCA4 File Offset: 0x006EAEA4
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

	// Token: 0x06017798 RID: 96152 RVA: 0x006ECCD4 File Offset: 0x006EAED4
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

	// Token: 0x06017799 RID: 96153 RVA: 0x006ECD5C File Offset: 0x006EAF5C
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

	// Token: 0x0601779A RID: 96154 RVA: 0x006ECDCC File Offset: 0x006EAFCC
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

	// Token: 0x0601779B RID: 96155 RVA: 0x006ECE24 File Offset: 0x006EB024
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

	// Token: 0x0601779C RID: 96156 RVA: 0x006ECF50 File Offset: 0x006EB150
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

	// Token: 0x0601779D RID: 96157 RVA: 0x006ECFC0 File Offset: 0x006EB1C0
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

	// Token: 0x0601779E RID: 96158 RVA: 0x006ED018 File Offset: 0x006EB218
	private void OnCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType)
	{
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.EffectViewHandle);
		if (effectActor.HasValue)
		{
			this.ScaleEffect(effectActor);
		}
	}

	// Token: 0x0400C79A RID: 51098
	private const float RATE = 50f;

	// Token: 0x0400C79B RID: 51099
	private const float VOLUME_MIN = 5f;

	// Token: 0x0400C79C RID: 51100
	private const float VOLUME_MAX = 60f;

	// Token: 0x0400C79D RID: 51101
	public int EffectViewHandle;

	// Token: 0x0400C79E RID: 51102
	[Nullable(2)]
	protected USkeletalMeshComponent TargetMesh;

	// Token: 0x0400C79F RID: 51103
	protected FName TargetSocket;

	// Token: 0x0400C7A0 RID: 51104
	[Nullable(2)]
	private CharacterWeapon TargetCharacterWeapon;

	// Token: 0x0400C7A1 RID: 51105
	[Nullable(2)]
	protected Transform RelativeTransform;

	// Token: 0x0400C7A2 RID: 51106
	protected bool IsSeekNeedProcess;

	// Token: 0x0400C7A3 RID: 51107
	protected readonly Transform SocketTransform = Transform.Create();

	// Token: 0x0400C7A4 RID: 51108
	protected readonly Transform TargetTransform = Transform.Create();

	// Token: 0x0400C7A5 RID: 51109
	protected ETimeScaleType EffectTimeScaleType;

	// Token: 0x0400C7A6 RID: 51110
	protected bool IsInitScaleEffect;

	// Token: 0x0400C7A7 RID: 51111
	protected FVectorDouble OriginScale;

	// Token: 0x0400C7A8 RID: 51112
	protected bool IsListenScaleChanged;

	// Token: 0x0400C7A9 RID: 51113
	public bool IsForceRecycle;
}
