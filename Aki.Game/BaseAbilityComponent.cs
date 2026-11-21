using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020023AF RID: 9135
[NullableContext(1)]
[Nullable(0)]
public class BaseAbilityComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06016D9A RID: 93594 RVA: 0x006A8BA4 File Offset: 0x006A6DA4
	static BaseAbilityComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseAbilityComponent.CreateStaticDefaultValue), new Action(BaseAbilityComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06016D9B RID: 93595 RVA: 0x006A8BC4 File Offset: 0x006A6DC4
	protected override bool OnStart()
	{
		this.ActorComponent = base.Entity.GetComponent<BaseActorComponent>();
		this.TsAbilityComponentInternal = this.GetAbilitySystemComponent();
		if (!this.TsAbilityComponentInternal.IsValid())
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.ZQR, "技能组件TsAbilityComponentInternal Add失败，AbilityComponent Start失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.TsAbilityComponentInternal.SetComponentTickEnabled(false);
		this.RefreshMeshAnim();
		this.InitClass();
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.GameplayEventTask = this.CreateGameplayEventTask(new Action<FGameplayTag, FGameplayEventData>(this.GameplayEventCallback));
		EventSystem.Instance.AddWithTarget<Entity, EMorphType, EMorphType>(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		return true;
	}

	// Token: 0x06016D9C RID: 93596 RVA: 0x006A8C7D File Offset: 0x006A6E7D
	protected override bool OnEnd()
	{
		if (this.GameplayEventTask != null)
		{
			this.GameplayEventTask.EndTask();
		}
		EventSystem.Instance.RemoveWithTarget<Entity, EMorphType, EMorphType>(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		return true;
	}

	// Token: 0x06016D9D RID: 93597 RVA: 0x006A8CB5 File Offset: 0x006A6EB5
	protected override bool OnClear()
	{
		if (this.TsAbilityComponentInternal != null)
		{
			this.TsAbilityComponentInternal.K2_DestroyComponent(this.TsAbilityComponentInternal);
			this.TsAbilityComponentInternal = null;
		}
		return true;
	}

	// Token: 0x06016D9E RID: 93598 RVA: 0x006A8CD8 File Offset: 0x006A6ED8
	protected override void OnTick(float delta)
	{
		this.TsAbilityComponentInternal.KuroTickComponentOutside(delta * 0.001f * this.ActorComponent.Owner.CustomTimeDilation);
	}

	// Token: 0x06016D9F RID: 93599 RVA: 0x006A8CFD File Offset: 0x006A6EFD
	private void OnCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType)
	{
		this.RefreshMeshAnim();
	}

	// Token: 0x06016DA0 RID: 93600 RVA: 0x006A8D08 File Offset: 0x006A6F08
	protected void RefreshMeshAnim()
	{
		ACharacter acharacter = this.ActorComponent.Owner as ACharacter;
		if (acharacter != null)
		{
			FName abp_BASE = CharacterNameDefines.Instance.ABP_BASE;
			if (acharacter.Mesh.GetLinkedAnimGraphInstanceByTag(abp_BASE) != null)
			{
				this.TsAbilityComponentInternal.BP_InitAbilityActorInfo(abp_BASE);
				return;
			}
			this.TsAbilityComponentInternal.BP_InitAbilityActorInfo(FNameUtil.NONE);
		}
	}

	// Token: 0x06016DA1 RID: 93601 RVA: 0x006A8D5F File Offset: 0x006A6F5F
	[NullableContext(2)]
	protected virtual UBaseAbilitySystemComponent GetAbilitySystemComponent()
	{
		return null;
	}

	// Token: 0x06016DA2 RID: 93602 RVA: 0x006A8D62 File Offset: 0x006A6F62
	public void AddPerformanceTag(string tagName)
	{
		this.LastPerformanceTag = tagName;
		this.TagComponent.AddTag(new int?(GameplayTagUtils.GetTagIdByName(tagName)));
	}

	// Token: 0x06016DA3 RID: 93603 RVA: 0x006A8D81 File Offset: 0x006A6F81
	public void ClearLastPerformanceTag()
	{
		if (!string.IsNullOrEmpty(this.LastPerformanceTag))
		{
			this.TagComponent.RemoveTag(new int?(GameplayTagUtils.GetTagIdByName(this.LastPerformanceTag)));
		}
	}

	// Token: 0x06016DA4 RID: 93604 RVA: 0x006A8DAC File Offset: 0x006A6FAC
	[NullableContext(2)]
	public void SendGameplayEventToActor(FGameplayTag eventTag, FGameplayEventData payload = null)
	{
		UAbilitySystemBlueprintLibrary.SendGameplayEventToActor(this.ActorComponent.Owner, eventTag, payload ?? BaseAbilityComponent._cachedGameplayEventData);
	}

	// Token: 0x06016DA5 RID: 93605 RVA: 0x006A8DC9 File Offset: 0x006A6FC9
	public bool TryActivateAbilityByClass(UClassStackOnlyPtr inAbilityToActivate, bool bAllowRemoteActivation = true)
	{
		return this.TsAbilityComponentInternal.TryActivateAbilityByClass(inAbilityToActivate, bAllowRemoteActivation);
	}

	// Token: 0x06016DA6 RID: 93606 RVA: 0x006A8DDD File Offset: 0x006A6FDD
	[NullableContext(2)]
	public UGameplayAbility GetCurrentWaitAndPlayedMontageCorrespondingGa()
	{
		return this.TsAbilityComponentInternal.LocalAnimMontageInfo.AnimatingAbility;
	}

	// Token: 0x06016DA7 RID: 93607 RVA: 0x006A8DF0 File Offset: 0x006A6FF0
	public FGameplayAbilitySpecHandle GetAbility(UClassStackOnlyPtr ability)
	{
		UBaseAbilitySystemComponent tsAbilityComponentInternal = this.TsAbilityComponentInternal;
		TSubclassOf<UGameplayAbility> tsubclassOf = ability;
		return tsAbilityComponentInternal.GetAbility(tsubclassOf);
	}

	// Token: 0x06016DA8 RID: 93608 RVA: 0x006A8E11 File Offset: 0x006A7011
	public void ClearAbility(FGameplayAbilitySpecHandle handle)
	{
		this.TsAbilityComponentInternal.RemoveAbility(handle);
	}

	// Token: 0x06016DA9 RID: 93609 RVA: 0x006A8E20 File Offset: 0x006A7020
	public int GetAbilityScopeLockCount()
	{
		return this.TsAbilityComponentInternal.GetAbilityScopeLockCount();
	}

	// Token: 0x06016DAA RID: 93610 RVA: 0x006A8E2D File Offset: 0x006A702D
	public void InitClass()
	{
		if (BaseAbilityComponent._isClassInitiated)
		{
			return;
		}
		BaseAbilityComponent._cachedGameplayEventData = new FGameplayEventData();
		BaseAbilityComponent._isClassInitiated = true;
	}

	// Token: 0x06016DAB RID: 93611 RVA: 0x006A8E47 File Offset: 0x006A7047
	public UAsyncTaskWaitGameplayEvent CreateGameplayEventTask(Action<FGameplayTag, FGameplayEventData> callback)
	{
		UAsyncTaskWaitGameplayEvent uasyncTaskWaitGameplayEvent = UAsyncTaskWaitGameplayEvent.ListenForGameplayEvent(this.TsAbilityComponentInternal);
		uasyncTaskWaitGameplayEvent.EventReceived.Add(callback);
		return uasyncTaskWaitGameplayEvent;
	}

	// Token: 0x06016DAC RID: 93612 RVA: 0x006A8E60 File Offset: 0x006A7060
	private unsafe void GameplayEventCallback(FGameplayTag eventTag, FGameplayEventData payload)
	{
		int num = eventTag.TagId();
		if (num == 0)
		{
			return;
		}
		HashSet<TGameplayEventCallback> collection;
		if (!this.GameplayEventCallbacks.TryGetValue(num, out collection))
		{
			return;
		}
		string nameByTagId = GameplayTagUtils.GetNameByTagId(num);
		foreach (TGameplayEventCallback tgameplayEventCallback in new List<TGameplayEventCallback>(collection))
		{
			try
			{
				tgameplayEventCallback(num, payload);
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.HXY;
				string message = "gameplayEvent事件回调执行异常";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("gameplayEvent", nameByTagId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
	}

	// Token: 0x06016DAD RID: 93613 RVA: 0x006A8F48 File Offset: 0x006A7148
	public unsafe void AddGameplayEventListener(int tagId, TGameplayEventCallback callback)
	{
		if (callback == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "回调函数添加失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("gameplayEvent", GameplayTagUtils.GetNameByTagId(tagId));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("callbackName", (callback != null) ? callback.Method.Name : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		HashSet<TGameplayEventCallback> hashSet;
		if (!this.GameplayEventCallbacks.TryGetValue(tagId, out hashSet))
		{
			hashSet = new HashSet<TGameplayEventCallback>();
			this.GameplayEventCallbacks[tagId] = hashSet;
		}
		if (hashSet.Contains(callback))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.HXY;
			string message2 = "重复添加回调函数";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("gameplayEvent", GameplayTagUtils.GetNameByTagId(tagId));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("callbackName", callback.Method.Name);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		hashSet.Add(callback);
	}

	// Token: 0x06016DAE RID: 93614 RVA: 0x006A9058 File Offset: 0x006A7258
	[return: Nullable(2)]
	public unsafe IGameplayEventTask AddGameplayEventListenerOnce(int? tagId, TGameplayEventCallback callback)
	{
		if (tagId == null || callback == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "回调函数添加失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("gameplayEvent", GameplayTagUtils.GetNameByTagId(tagId.GetValueOrDefault()));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("callbackName", (callback != null) ? callback.Method.Name : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		GameplayEventOnceTask gameplayEventOnceTask = new GameplayEventOnceTask();
		gameplayEventOnceTask.StartTask(tagId.Value, callback, this);
		return gameplayEventOnceTask;
	}

	// Token: 0x06016DAF RID: 93615 RVA: 0x006A90F8 File Offset: 0x006A72F8
	public void RemoveGameplayEventListener(int tagId, TGameplayEventCallback callback)
	{
		HashSet<TGameplayEventCallback> hashSet;
		if (!this.GameplayEventCallbacks.TryGetValue(tagId, out hashSet))
		{
			return;
		}
		hashSet.Remove(callback);
	}

	// Token: 0x06016DB0 RID: 93616 RVA: 0x006A911E File Offset: 0x006A731E
	public static void CreateStaticDefaultValue()
	{
		BaseAbilityComponent._cachedGameplayEventData = null;
		BaseAbilityComponent._isClassInitiated = false;
	}

	// Token: 0x06016DB1 RID: 93617 RVA: 0x006A912C File Offset: 0x006A732C
	public static void ResetStaticDefaultValue()
	{
		BaseAbilityComponent._cachedGameplayEventData = null;
		BaseAbilityComponent._isClassInitiated = false;
	}

	// Token: 0x06016DB2 RID: 93618 RVA: 0x006A913C File Offset: 0x006A733C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseAbilityComponent baseAbilityComponent = (BaseAbilityComponent)componentTemplate;
		if (baseAbilityComponent.ActorComponent == null)
		{
			this.ActorComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
		{
			return false;
		}
		if (baseAbilityComponent.TsAbilityComponentInternal == null)
		{
			this.TsAbilityComponentInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TsAbilityComponentInternal), "TsAbilityComponentInternal"))
		{
			return false;
		}
		if (baseAbilityComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		this.LastPerformanceTag = baseAbilityComponent.LastPerformanceTag;
		if (baseAbilityComponent.GameplayEventTask == null)
		{
			this.GameplayEventTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GameplayEventTask), "GameplayEventTask"))
		{
			return false;
		}
		return baseAbilityComponent.GameplayEventCallbacks == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.GameplayEventCallbacks), "GameplayEventCallbacks");
	}

	// Token: 0x17002313 RID: 8979
	// (get) Token: 0x06016DB3 RID: 93619 RVA: 0x006A9236 File Offset: 0x006A7436
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002314 RID: 8980
	// (get) Token: 0x06016DB4 RID: 93620 RVA: 0x006A9239 File Offset: 0x006A7439
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002315 RID: 8981
	// (get) Token: 0x06016DB5 RID: 93621 RVA: 0x006A923C File Offset: 0x006A743C
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002316 RID: 8982
	// (get) Token: 0x06016DB6 RID: 93622 RVA: 0x006A923F File Offset: 0x006A743F
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400BFB7 RID: 49079
	public const int DEFAULT_SOURCE_SKILL_LEVEL = 1;

	// Token: 0x0400BFB8 RID: 49080
	public const int DEFAULT_SOURCE_SKILL_LEVEL_NOT_FOUND = -1;

	// Token: 0x0400BFB9 RID: 49081
	[Nullable(2)]
	private BaseActorComponent ActorComponent;

	// Token: 0x0400BFBA RID: 49082
	[Nullable(2)]
	private UBaseAbilitySystemComponent TsAbilityComponentInternal;

	// Token: 0x0400BFBB RID: 49083
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400BFBC RID: 49084
	[Nullable(2)]
	private static FGameplayEventData _cachedGameplayEventData;

	// Token: 0x0400BFBD RID: 49085
	private string LastPerformanceTag = "";

	// Token: 0x0400BFBE RID: 49086
	private static bool _isClassInitiated;

	// Token: 0x0400BFBF RID: 49087
	[Nullable(2)]
	private UAsyncTaskWaitGameplayEvent GameplayEventTask;

	// Token: 0x0400BFC0 RID: 49088
	protected readonly Dictionary<int, HashSet<TGameplayEventCallback>> GameplayEventCallbacks = new Dictionary<int, HashSet<TGameplayEventCallback>>();
}
