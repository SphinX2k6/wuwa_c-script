using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Character.NPC.Animal;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonPet;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200237E RID: 9086
[NullableContext(2)]
[Nullable(0)]
public class AnimalPerformComponent : BasePerformComponent
{
	// Token: 0x060166BD RID: 91837 RVA: 0x0068E0C0 File Offset: 0x0068C2C0
	public void HandlePendingDestroy()
	{
		if (!this.PendingDestroy && !this.PlayDeathAnimOnDestroy)
		{
			CreatureController.Instance.DelayRemoveEntityFinished(base.Entity);
			return;
		}
		base.Entity.GetComponent<BaseTagComponent>().AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.特殊表现.销毁消失"]));
		if (this.PlayDeathAnimOnDestroy)
		{
			AnimalDeathSyncComponent component = base.Entity.GetComponent<AnimalDeathSyncComponent>();
			if (component == null)
			{
				return;
			}
			component.PlayDieAnimation();
		}
	}

	// Token: 0x060166BE RID: 91838 RVA: 0x0068E130 File Offset: 0x0068C330
	protected override bool OnInitData(IEntityArgs args = null)
	{
		object param = args.GetP1<CreateEntityData>().GetParam<AnimalPerformComponent>();
		AnimalComponent animalComponent = (param != null) ? (param as AnimalComponent) : null;
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		this.CanLookAtPlayer = (animalComponent != null && animalComponent.IsStare);
		this.MaterialMap = new Dictionary<int, string>();
		if (animalComponent != null)
		{
			ICollectAnimalConfig specialAnimalConfig = animalComponent.SpecialAnimalConfig;
			ESpecialAnimalType? especialAnimalType = (specialAnimalConfig != null) ? new ESpecialAnimalType?(specialAnimalConfig.Type) : null;
			ESpecialAnimalType especialAnimalType2 = ESpecialAnimalType.CollectAnimal;
			if (especialAnimalType.GetValueOrDefault() == especialAnimalType2 & especialAnimalType != null)
			{
				this.PartToBoneMap = new Dictionary<int, string>();
				this.PartEnableMap = new Dictionary<int, bool>();
				foreach (ICollectAnimalPartsConfig collectAnimalPartsConfig in animalComponent.SpecialAnimalConfig.PartsMap)
				{
					this.PartToBoneMap[(int)collectAnimalPartsConfig.Slot] = collectAnimalPartsConfig.Skeleton;
					this.PartEnableMap[(int)collectAnimalPartsConfig.Slot] = (component.PbAnimalInitialPartIds != null && Array.IndexOf<int>(component.PbAnimalInitialPartIds, (int)collectAnimalPartsConfig.Slot) >= 0);
				}
			}
		}
		this.PlayDeathAnimOnDestroy = ((animalComponent != null) ? animalComponent.PlayDeathAnimOnDestroy : null).GetValueOrDefault();
		return true;
	}

	// Token: 0x060166BF RID: 91839 RVA: 0x0068E290 File Offset: 0x0068C490
	protected unsafe override bool OnStart()
	{
		base.OnStart();
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		if (this.ActorComp == null)
		{
			Log.Instance.Error(ELogModule.Animal, ELogAuthor.CJH, "[AnimalPerformComponent] 初始化失败 Actor Component Undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		if (this.AnimComp == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Animal;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "[AnimalPerformComponent] 初始化失败 Animation Component Undefined";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.ActorComp.CreatureData.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PlayerId", this.ActorComp.CreatureData.GetPlayerId());
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		this.AnimComp.EnableSightDirect = this.CanLookAtPlayer;
		ABP_BaseAnimal_C abp_BaseAnimal_C = this.AnimComp.MainAnimInstance as ABP_BaseAnimal_C;
		if (abp_BaseAnimal_C != null)
		{
			foreach (KeyValuePair<FGameplayTag, TSoftObjectPtr<PD_CharacterControllerData_C>> keyValuePair in abp_BaseAnimal_C.材质配置)
			{
				FGameplayTag fgameplayTag;
				TSoftObjectPtr<PD_CharacterControllerData_C> tsoftObjectPtr;
				keyValuePair.Deconstruct(out fgameplayTag, out tsoftObjectPtr);
				FGameplayTag tag = fgameplayTag;
				TSoftObjectPtr<PD_CharacterControllerData_C> tsoftObjectPtr2 = tsoftObjectPtr;
				if (!tag.TagName.ToString().Contains("动物."))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Animal;
					ELogAuthor author2 = ELogAuthor.CJH;
					string message2 = "[AnimalPerformComponent] 材质GameplayTag不符合规范";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", this.ActorComp.CreatureData.GetCreatureDataId());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("PlayerId", this.ActorComp.CreatureData.GetPlayerId());
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
				else
				{
					this.MaterialMap[tag.TagId()] = tsoftObjectPtr2.ToAssetPathName();
				}
			}
		}
		this.PerceptionComp = base.Entity.GetComponent<PawnPerceptionComponent>();
		if (this.PerceptionComp == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Animal;
			ELogAuthor author3 = ELogAuthor.CJH;
			string message3 = "[AnimalPerformComponent] 初始化失败 Perception Component Undefined";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("CreatureDataId", this.ActorComp.CreatureData.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("PlayerId", this.ActorComp.CreatureData.GetPlayerId());
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return false;
		}
		this.PerceptionComp.SetSightRange(300f);
		this.GameplayTagComp = base.Entity.GetComponent<BaseTagComponent>();
		if (this.GameplayTagComp == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Animal;
			ELogAuthor author4 = ELogAuthor.CJH;
			string message4 = "[AnimalPerformComponent] 初始化失败 GameplayTag Component Undefined";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("CreatureDataId", this.ActorComp.CreatureData.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("PlayerId", this.ActorComp.CreatureData.GetPlayerId());
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
			return false;
		}
		foreach (KeyValuePair<int, string> keyValuePair2 in this.MaterialMap)
		{
			this.GameplayTagComp.AddTagAddOrRemoveListener(keyValuePair2.Key, new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayTagChange), null);
		}
		this.GameplayTagComp.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["动物.Common.特殊表现.销毁消失"], new BaseTagComponent.TTagSwitchedCallback(this.OnDestroyDisappearTagAdd), null);
		this.GameplayTagComp.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"], new BaseTagComponent.TTagSwitchedCallback(this.OnDyingTagAdd), null);
		this.AddEvents();
		return true;
	}

	// Token: 0x060166C0 RID: 91840 RVA: 0x0068E778 File Offset: 0x0068C978
	protected override void OnActivate()
	{
		if (base.Entity.GetComponent<CreatureDataComponent>().GetEntityType() == EEntityType.Monster)
		{
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			this.ActorComp.SetAutonomous(true, null);
			this.AddBlurCollision();
		}
		this.UpdateAllPartsHideState();
	}

	// Token: 0x060166C1 RID: 91841 RVA: 0x0068E7C6 File Offset: 0x0068C9C6
	protected override void OnTick(float delta)
	{
		if (!this.CanLookAtPlayer)
		{
			return;
		}
		if (this.PerceptionComp.IsInSightRange && this.IsInSightDirection())
		{
			this.SightTarget(Global.BaseCharacter.CharacterActorComponent);
			return;
		}
		this.SightTarget(null);
	}

	// Token: 0x060166C2 RID: 91842 RVA: 0x0068E800 File Offset: 0x0068CA00
	private bool IsInSightDirection()
	{
		CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
		this.TempDirect.FromUeVector(characterActorComponent.ActorLocationProxy);
		this.TempDirect.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		this.TempDirect.Z = 0.0;
		this.TempDirect.Normalize(9.99999993922529E-09);
		return MathUtils.Instance.GetAngleByVectorDot(this.TempDirect, this.ActorComp.ActorForwardProxy) <= 80.0;
	}

	// Token: 0x060166C3 RID: 91843 RVA: 0x0068E89C File Offset: 0x0068CA9C
	private void SightTarget(BaseActorComponent target)
	{
		if (!this.CanLookAtPlayer)
		{
			return;
		}
		this.AnimComp.SetSightTargetItem(target);
	}

	// Token: 0x060166C4 RID: 91844 RVA: 0x0068E8B4 File Offset: 0x0068CAB4
	protected override bool OnEnd()
	{
		this.RemoveBlurCollision();
		this.RemoveEvents();
		foreach (KeyValuePair<int, string> keyValuePair in this.MaterialMap)
		{
			this.GameplayTagComp.RemoveTagAddOrRemoveListener(keyValuePair.Key, new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayTagChange));
		}
		this.GameplayTagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"], new BaseTagComponent.TTagSwitchedCallback(this.OnDyingTagAdd));
		return true;
	}

	// Token: 0x060166C5 RID: 91845 RVA: 0x0068E954 File Offset: 0x0068CB54
	[NullableContext(1)]
	private void AddMaterialControllerData(string materialPath)
	{
		if (this.MaterialHandle > -1)
		{
			this.RemoveMaterialControllerData();
		}
		ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(materialPath, delegate([Nullable(2)] PD_CharacterControllerData_C data, string _)
		{
			if (data == null || !data.IsValid())
			{
				return;
			}
			if (this.ActorComp != null)
			{
				TsBaseCharacter actor = this.ActorComp.Actor;
				if (actor != null && actor.IsValid())
				{
					this.MaterialHandle = this.ActorComp.Actor.CharRenderingComponent.AddMaterialControllerData(data);
				}
			}
		}, 100, "js_undefined");
	}

	// Token: 0x060166C6 RID: 91846 RVA: 0x0068E984 File Offset: 0x0068CB84
	private void RemoveMaterialControllerData()
	{
		if (this.MaterialHandle > -1)
		{
			this.ActorComp.Actor.CharRenderingComponent.RemoveMaterialControllerData(this.MaterialHandle);
		}
		this.MaterialHandle = -1;
	}

	// Token: 0x060166C7 RID: 91847 RVA: 0x0068E9B1 File Offset: 0x0068CBB1
	private void OnDyingTagAdd(int tagId, bool gameplayTagExist)
	{
		if (!gameplayTagExist)
		{
			return;
		}
		EventSystem.Instance.Emit<Entity>(EEventName.OnAnimalDying, base.Entity);
	}

	// Token: 0x060166C8 RID: 91848 RVA: 0x0068E9D0 File Offset: 0x0068CBD0
	private void OnDestroyDisappearTagAdd(int tagId, bool gameplayTagExist)
	{
		if (!gameplayTagExist)
		{
			return;
		}
		if (this.PendingDestroy)
		{
			this.GameplayTagComp.AddTag(new int?(AnimalPerformComponent.GAMEPLAY_TAG_INVISIBILITY));
			this.ActorComp.Actor.CapsuleComponent.SetCollisionProfileName(CharacterNameDefines.Instance.VANISH_PAWN, true);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				Entity entity = base.Entity;
				if (entity == null || !entity.Valid)
				{
					return;
				}
				CreatureController.Instance.DelayRemoveEntityFinished(base.Entity);
			}, 2000f, null, null, true, 1f);
			return;
		}
		CreatureController.Instance.DelayRemoveEntityFinished(base.Entity);
	}

	// Token: 0x060166C9 RID: 91849 RVA: 0x0068EA54 File Offset: 0x0068CC54
	private void OnGameplayTagChange(int tagId, bool gameplayTagExist)
	{
		string materialPath;
		if (!this.MaterialMap.TryGetValue(tagId, out materialPath))
		{
			return;
		}
		if (gameplayTagExist)
		{
			this.AddMaterialControllerData(materialPath);
			if (tagId == AnimalPerformComponent.GAMEPLAY_TAG_DISAPPEAR)
			{
				this.GameplayTagComp.AddTag(new int?(AnimalPerformComponent.GAMEPLAY_TAG_INVISIBILITY));
				this.ActorComp.Actor.CapsuleComponent.SetCollisionProfileName(CharacterNameDefines.Instance.VANISH_PAWN, true);
				return;
			}
		}
		else
		{
			this.RemoveMaterialControllerData();
			if (tagId == AnimalPerformComponent.GAMEPLAY_TAG_DISAPPEAR)
			{
				this.GameplayTagComp.RemoveTag(new int?(AnimalPerformComponent.GAMEPLAY_TAG_INVISIBILITY));
				this.ActorComp.Actor.CapsuleComponent.SetCollisionProfileName(CharacterNameDefines.Instance.PAWN, true);
			}
		}
	}

	// Token: 0x060166CA RID: 91850 RVA: 0x0068EB00 File Offset: 0x0068CD00
	private void OnChangeModeFinish()
	{
		if (base.Entity.GetComponent<CreatureDataComponent>().GetEntityType() == EEntityType.Monster)
		{
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			this.ActorComp.SetAutonomous(true, null);
			this.AddBlurCollision();
			return;
		}
		this.RemoveBlurCollision();
	}

	// Token: 0x060166CB RID: 91851 RVA: 0x0068EB50 File Offset: 0x0068CD50
	[NullableContext(1)]
	private void OnFriendHit(BulletInfo bulletInfo)
	{
		if (bulletInfo.CollisionInfo.DamageId == 0L)
		{
			return;
		}
		bool flag = false;
		CreatureDataComponent component = bulletInfo.Attacker.GetComponent<CreatureDataComponent>();
		if ((component != null && component.IsRole()) || (component != null && component.IsVision()))
		{
			flag = true;
		}
		else if (component != null)
		{
			EntityHandle entity = CreatureModel.Instance.GetEntity(component.GetSummonerId());
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			bool flag2;
			if (worldEntity == null)
			{
				flag2 = false;
			}
			else
			{
				CreatureDataComponent component2 = worldEntity.GetComponent<CreatureDataComponent>();
				flag2 = ((component2 != null) ? new bool?(component2.IsRole()) : null).GetValueOrDefault();
			}
			if (flag2)
			{
				flag = true;
			}
		}
		if (flag)
		{
			this.GameplayTagComp.AddTag(new int?(AnimalPerformComponent.GAMEPLAY_TAG_ON_HIT));
		}
	}

	// Token: 0x060166CC RID: 91852 RVA: 0x0068EBFC File Offset: 0x0068CDFC
	[NullableContext(1)]
	private void OnAnimalDying(Entity entity)
	{
		if (entity == null || !entity.Valid)
		{
			return;
		}
		if (entity.Id == base.Entity.Id)
		{
			return;
		}
		global::Vector actorLocationProxy = entity.GetComponent<CharacterActorComponent>().ActorLocationProxy;
		this.ActorComp.ActorLocationProxy.Subtraction(actorLocationProxy, this.TempDirect);
		if (this.TempDirect.Size() > 500.0)
		{
			return;
		}
		this.GameplayTagComp.AddTag(new int?(AnimalPerformComponent.GAMEPLAY_TAG_ALERT));
	}

	// Token: 0x060166CD RID: 91853 RVA: 0x0068EC80 File Offset: 0x0068CE80
	private void AddBlurCollision()
	{
		if (this.HaveBlurEvent)
		{
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.Valid)
		{
			TsBaseCharacter actor = this.ActorComp.Actor;
			if (actor != null && actor.IsValid())
			{
				if (!UKuroStaticLibrary.IsObjectClassByName(this.ActorComp.Actor, CharacterNameDefines.Instance.BP_COMMONPET))
				{
					return;
				}
				UBoxComponent blurCollision = (this.ActorComp.Actor as BP_CommonPet_C).BlurCollision;
				blurCollision.OnComponentBeginOverlap.Add(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>(this.OnBlurBegin));
				blurCollision.OnComponentEndOverlap.Add(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>(this.OnBlurEnd));
				this.HaveBlurEvent = true;
				return;
			}
		}
	}

	// Token: 0x060166CE RID: 91854 RVA: 0x0068ED30 File Offset: 0x0068CF30
	private void RemoveBlurCollision()
	{
		if (!this.HaveBlurEvent)
		{
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.Valid)
		{
			TsBaseCharacter actor = this.ActorComp.Actor;
			if (actor != null && actor.IsValid())
			{
				if (!UKuroStaticLibrary.IsObjectClassByName(this.ActorComp.Actor, CharacterNameDefines.Instance.BP_COMMONPET))
				{
					return;
				}
				UBoxComponent blurCollision = (this.ActorComp.Actor as BP_CommonPet_C).BlurCollision;
				blurCollision.OnComponentBeginOverlap.Remove(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>(this.OnBlurBegin));
				blurCollision.OnComponentEndOverlap.Remove(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>(this.OnBlurEnd));
				this.HaveBlurEvent = false;
				return;
			}
		}
	}

	// Token: 0x060166CF RID: 91855 RVA: 0x0068EDE0 File Offset: 0x0068CFE0
	private void OnBlurBegin(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex, bool bFromSweep, [Nullable(1)] FHitResult sweepResult)
	{
		if (this.IsAnotherClientPlayer(otherActor) && !this.GameplayTagComp.HasTag(AnimalPerformComponent.GAMEPLAY_TAG_BLUR))
		{
			this.GameplayTagComp.AddTag(new int?(AnimalPerformComponent.GAMEPLAY_TAG_BLUR));
		}
	}

	// Token: 0x060166D0 RID: 91856 RVA: 0x0068EE12 File Offset: 0x0068D012
	private void OnBlurEnd(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex)
	{
		if (this.IsAnotherClientPlayer(otherActor) && this.GameplayTagComp.HasTag(AnimalPerformComponent.GAMEPLAY_TAG_BLUR))
		{
			this.GameplayTagComp.RemoveTag(new int?(AnimalPerformComponent.GAMEPLAY_TAG_BLUR));
		}
	}

	// Token: 0x060166D1 RID: 91857 RVA: 0x0068EE48 File Offset: 0x0068D048
	public unsafe void SetUiOpenPerformance(EUiViewName uiViewName, int boardId)
	{
		AnimalStateMachineComponent component = base.Entity.GetComponent<AnimalStateMachineComponent>();
		if (component.CurrentState() == EAnimalEcologicalState.系统UI)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Animal;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "开启系统UI失败，系统UI已开启";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ConfigID", this.ActorComp.CreatureData.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("已开启系统UI", uiViewName);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		(component.GetState(EAnimalPerformState.SystemUi) as AnimalPerformSystemUiState).SystemUiViewName = new EUiViewName?(uiViewName);
		component.SwitchState(EAnimalPerformState.SystemUi);
	}

	// Token: 0x060166D2 RID: 91858 RVA: 0x0068EEF8 File Offset: 0x0068D0F8
	[NullableContext(1)]
	public void InitFeedingAnimalConfig(int[] itemIds, string[] gameplayTags)
	{
		(base.Entity.GetComponent<AnimalStateMachineComponent>().GetState(EAnimalPerformState.SystemUi) as AnimalPerformSystemUiState).InitFeedingAnimalConfig(itemIds, gameplayTags);
	}

	// Token: 0x060166D3 RID: 91859 RVA: 0x0068EF18 File Offset: 0x0068D118
	private bool IsAnotherClientPlayer(AActor otherActor)
	{
		EntityHandle entityByActor = ActorUtils.GetEntityByActor(otherActor, false);
		if (entityByActor == null || !entityByActor.Valid)
		{
			return false;
		}
		if (!entityByActor.Entity.GetComponent<CreatureDataComponent>().IsRole())
		{
			return false;
		}
		CharacterActorComponent component = entityByActor.Entity.GetComponent<CharacterActorComponent>();
		return component != null && component.Valid && !component.IsAutonomousProxy;
	}

	// Token: 0x060166D4 RID: 91860 RVA: 0x0068EF7C File Offset: 0x0068D17C
	private void AddEvents()
	{
		if (!this.EventsInited)
		{
			EventSystem.Instance.AddWithTarget<BulletInfo>(base.Entity, EEventName.BulletHitSpecialCharacter, new Action<BulletInfo>(this.OnFriendHit));
			EventSystem.Instance.Add(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
			EventSystem.Instance.Add<Entity>(EEventName.OnAnimalDying, new Action<Entity>(this.OnAnimalDying));
			this.EventsInited = true;
		}
	}

	// Token: 0x060166D5 RID: 91861 RVA: 0x0068EFF4 File Offset: 0x0068D1F4
	private void RemoveEvents()
	{
		if (this.EventsInited)
		{
			EventSystem.Instance.RemoveWithTarget<BulletInfo>(base.Entity, EEventName.BulletHitSpecialCharacter, new Action<BulletInfo>(this.OnFriendHit));
			EventSystem.Instance.Remove(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
			EventSystem.Instance.Remove<Entity>(EEventName.OnAnimalDying, new Action<Entity>(this.OnAnimalDying));
			this.EventsInited = false;
		}
	}

	// Token: 0x060166D6 RID: 91862 RVA: 0x0068F06C File Offset: 0x0068D26C
	public bool GetIsPartShow(int partId)
	{
		Dictionary<int, bool> partEnableMap = this.PartEnableMap;
		bool flag;
		return partEnableMap != null && partEnableMap.TryGetValue(partId, out flag) && flag;
	}

	// Token: 0x060166D7 RID: 91863 RVA: 0x0068F094 File Offset: 0x0068D294
	private void UpdateAllPartsHideState()
	{
		if (this.PartEnableMap == null || this.PartToBoneMap == null)
		{
			return;
		}
		foreach (KeyValuePair<int, bool> keyValuePair in this.PartEnableMap)
		{
			int key = keyValuePair.Key;
			bool value = keyValuePair.Value;
			string key2;
			if (this.PartToBoneMap.TryGetValue(key, out key2))
			{
				FName? dynamicFName = FNameUtil.GetDynamicFName(key2);
				if (dynamicFName != null)
				{
					this.SetHideBone(dynamicFName.Value, !value);
				}
			}
		}
	}

	// Token: 0x060166D8 RID: 91864 RVA: 0x0068F134 File Offset: 0x0068D334
	public void ShowPart(int partId)
	{
		Dictionary<int, string> partToBoneMap = this.PartToBoneMap;
		string key;
		if (partToBoneMap != null && partToBoneMap.TryGetValue(partId, out key))
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName(key);
			if (dynamicFName != null)
			{
				this.SetHideBone(dynamicFName.Value, false);
				if (this.PartEnableMap != null)
				{
					this.PartEnableMap[partId] = true;
				}
			}
		}
	}

	// Token: 0x060166D9 RID: 91865 RVA: 0x0068F18C File Offset: 0x0068D38C
	public void HidePart(int partId)
	{
		Dictionary<int, string> partToBoneMap = this.PartToBoneMap;
		string key;
		if (partToBoneMap != null && partToBoneMap.TryGetValue(partId, out key))
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName(key);
			if (dynamicFName != null)
			{
				this.SetHideBone(dynamicFName.Value, true);
				if (this.PartEnableMap != null)
				{
					this.PartEnableMap[partId] = false;
				}
			}
		}
	}

	// Token: 0x060166DA RID: 91866 RVA: 0x0068F1E4 File Offset: 0x0068D3E4
	private void SetHideBone(FName boneName, bool hide)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		bool flag;
		if (actorComp == null)
		{
			flag = true;
		}
		else
		{
			TsBaseCharacter actor = actorComp.Actor;
			bool? flag2;
			if (actor == null)
			{
				flag2 = null;
			}
			else
			{
				USkeletalMeshComponent mesh = actor.Mesh;
				flag2 = ((mesh != null) ? new bool?(mesh.IsValid()) : null);
			}
			bool? flag3 = flag2;
			flag = !flag3.GetValueOrDefault();
		}
		if (flag || boneName == null)
		{
			return;
		}
		if (this.ActorComp.Actor.Mesh.IsBoneHiddenByName(boneName) == hide)
		{
			return;
		}
		if (hide)
		{
			this.ActorComp.Actor.Mesh.HideBoneByName(boneName, EPhysBodyOp.PBO_None);
			return;
		}
		this.ActorComp.Actor.Mesh.UnHideBoneByName(boneName);
	}

	// Token: 0x060166DB RID: 91867 RVA: 0x0068F298 File Offset: 0x0068D498
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		AnimalPerformComponent animalPerformComponent = (AnimalPerformComponent)componentTemplate;
		if (animalPerformComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (animalPerformComponent.PerceptionComp == null)
		{
			this.PerceptionComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PerceptionComp), "PerceptionComp"))
		{
			return false;
		}
		if (animalPerformComponent.GameplayTagComp == null)
		{
			this.GameplayTagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GameplayTagComp), "GameplayTagComp"))
		{
			return false;
		}
		this.CanLookAtPlayer = animalPerformComponent.CanLookAtPlayer;
		if (animalPerformComponent.TempDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempDirect), "TempDirect"))
		{
			return false;
		}
		this.MaterialHandle = animalPerformComponent.MaterialHandle;
		this.EventsInited = animalPerformComponent.EventsInited;
		if (animalPerformComponent.MaterialMap == null)
		{
			this.MaterialMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MaterialMap), "MaterialMap"))
		{
			return false;
		}
		if (animalPerformComponent.PartToBoneMap == null)
		{
			this.PartToBoneMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PartToBoneMap), "PartToBoneMap"))
		{
			return false;
		}
		if (animalPerformComponent.PartEnableMap == null)
		{
			this.PartEnableMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PartEnableMap), "PartEnableMap"))
		{
			return false;
		}
		this.HaveBlurEvent = animalPerformComponent.HaveBlurEvent;
		this.PendingDestroy = animalPerformComponent.PendingDestroy;
		this.PlayDeathAnimOnDestroy = animalPerformComponent.PlayDeathAnimOnDestroy;
		return true;
	}

	// Token: 0x170022E9 RID: 8937
	// (get) Token: 0x060166DC RID: 91868 RVA: 0x0068F424 File Offset: 0x0068D624
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170022EA RID: 8938
	// (get) Token: 0x060166DD RID: 91869 RVA: 0x0068F427 File Offset: 0x0068D627
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170022EB RID: 8939
	// (get) Token: 0x060166DE RID: 91870 RVA: 0x0068F42A File Offset: 0x0068D62A
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170022EC RID: 8940
	// (get) Token: 0x060166DF RID: 91871 RVA: 0x0068F42D File Offset: 0x0068D62D
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170022ED RID: 8941
	// (get) Token: 0x060166E0 RID: 91872 RVA: 0x0068F430 File Offset: 0x0068D630
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400BE1A RID: 48666
	private const int DEFAULT_SIGHT_RANGE = 300;

	// Token: 0x0400BE1B RID: 48667
	private const int SIGHT_OPEN_DEGREE = 80;

	// Token: 0x0400BE1C RID: 48668
	private static readonly int GAMEPLAY_TAG_DISAPPEAR = GameplayTagDefine.EGameplayTagId["动物.Common.特殊表现.消失"];

	// Token: 0x0400BE1D RID: 48669
	private static readonly int GAMEPLAY_TAG_BLUR = GameplayTagDefine.EGameplayTagId["动物.Common.特殊表现.虚化"];

	// Token: 0x0400BE1E RID: 48670
	private const int DESTROY_DISAPPEAR_TIME = 2000;

	// Token: 0x0400BE1F RID: 48671
	private static readonly int GAMEPLAY_TAG_INVISIBILITY = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.不被子弹命中"];

	// Token: 0x0400BE20 RID: 48672
	private static readonly int GAMEPLAY_TAG_ON_HIT = GameplayTagDefine.EGameplayTagId["动物.Common.通知标识.受到攻击"];

	// Token: 0x0400BE21 RID: 48673
	private const int ALERT_RANGE = 500;

	// Token: 0x0400BE22 RID: 48674
	private static readonly int GAMEPLAY_TAG_ALERT = GameplayTagDefine.EGameplayTagId["动物.Common.通知标识.警觉"];

	// Token: 0x0400BE23 RID: 48675
	private CharacterActorComponent ActorComp;

	// Token: 0x0400BE24 RID: 48676
	private PawnPerceptionComponent PerceptionComp;

	// Token: 0x0400BE25 RID: 48677
	private BaseTagComponent GameplayTagComp;

	// Token: 0x0400BE26 RID: 48678
	private bool CanLookAtPlayer;

	// Token: 0x0400BE27 RID: 48679
	[Nullable(1)]
	private readonly global::Vector TempDirect = global::Vector.Create();

	// Token: 0x0400BE28 RID: 48680
	private int MaterialHandle = -1;

	// Token: 0x0400BE29 RID: 48681
	private bool EventsInited;

	// Token: 0x0400BE2A RID: 48682
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> MaterialMap;

	// Token: 0x0400BE2B RID: 48683
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> PartToBoneMap;

	// Token: 0x0400BE2C RID: 48684
	private Dictionary<int, bool> PartEnableMap;

	// Token: 0x0400BE2D RID: 48685
	private bool HaveBlurEvent;

	// Token: 0x0400BE2E RID: 48686
	public bool PendingDestroy = true;

	// Token: 0x0400BE2F RID: 48687
	public bool PlayDeathAnimOnDestroy;
}
