using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002E5D RID: 11869
[NullableContext(1)]
[Nullable(0)]
public class BaseAbilityComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x060194E0 RID: 103648 RVA: 0x00682814 File Offset: 0x00680A14
	static BaseAbilityComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseAbilityComponent.CreateStaticDefaultValue), new Action(BaseAbilityComponent.ResetStaticDefaultValue));
	}

	// Token: 0x060194E1 RID: 103649 RVA: 0x00682834 File Offset: 0x00680A34
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

	// Token: 0x060194E2 RID: 103650 RVA: 0x006828ED File Offset: 0x00680AED
	protected override bool OnEnd()
	{
		if (this.GameplayEventTask != null)
		{
			this.GameplayEventTask.EndTask();
		}
		EventSystem.Instance.RemoveWithTarget<Entity, EMorphType, EMorphType>(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		return true;
	}

	// Token: 0x060194E3 RID: 103651 RVA: 0x00682925 File Offset: 0x00680B25
	protected override bool OnClear()
	{
		if (this.TsAbilityComponentInternal != null)
		{
			this.TsAbilityComponentInternal.K2_DestroyComponent(this.TsAbilityComponentInternal);
			this.TsAbilityComponentInternal = null;
		}
		return true;
	}

	// Token: 0x060194E4 RID: 103652 RVA: 0x00682948 File Offset: 0x00680B48
	protected override void OnTick(float delta)
	{
		this.TsAbilityComponentInternal.KuroTickComponentOutside(delta * 0.001f * this.ActorComponent.Owner.CustomTimeDilation);
	}

	// Token: 0x060194E5 RID: 103653 RVA: 0x0068296D File Offset: 0x00680B6D
	private void OnCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType)
	{
		this.RefreshMeshAnim();
	}

	// Token: 0x060194E6 RID: 103654 RVA: 0x00682978 File Offset: 0x00680B78
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

	// Token: 0x060194E7 RID: 103655 RVA: 0x006829CF File Offset: 0x00680BCF
	[NullableContext(2)]
	protected virtual UBaseAbilitySystemComponent GetAbilitySystemComponent()
	{
		return null;
	}

	// Token: 0x060194E8 RID: 103656 RVA: 0x006829D2 File Offset: 0x00680BD2
	public void AddPerformanceTag(string tagName)
	{
		this.LastPerformanceTag = tagName;
		this.TagComponent.AddTag(new int?(GameplayTagUtils.GetTagIdByName(tagName)));
	}

	// Token: 0x060194E9 RID: 103657 RVA: 0x006829F1 File Offset: 0x00680BF1
	public void ClearLastPerformanceTag()
	{
		if (!string.IsNullOrEmpty(this.LastPerformanceTag))
		{
			this.TagComponent.RemoveTag(new int?(GameplayTagUtils.GetTagIdByName(this.LastPerformanceTag)));
		}
	}

	// Token: 0x060194EA RID: 103658 RVA: 0x00682A1C File Offset: 0x00680C1C
	[NullableContext(2)]
	public void SendGameplayEventToActor(FGameplayTag eventTag, FGameplayEventData payload = null)
	{
		UAbilitySystemBlueprintLibrary.SendGameplayEventToActor(this.ActorComponent.Owner, eventTag, payload ?? BaseAbilityComponent._cachedGameplayEventData);
	}

	// Token: 0x060194EB RID: 103659 RVA: 0x00682A39 File Offset: 0x00680C39
	public bool TryActivateAbilityByClass(UClassStackOnlyPtr inAbilityToActivate, bool bAllowRemoteActivation = true)
	{
		return this.TsAbilityComponentInternal.TryActivateAbilityByClass(inAbilityToActivate, bAllowRemoteActivation);
	}

	// Token: 0x060194EC RID: 103660 RVA: 0x00682A4D File Offset: 0x00680C4D
	[NullableContext(2)]
	public UGameplayAbility GetCurrentWaitAndPlayedMontageCorrespondingGa()
	{
		return this.TsAbilityComponentInternal.LocalAnimMontageInfo.AnimatingAbility;
	}

	// Token: 0x060194ED RID: 103661 RVA: 0x00682A60 File Offset: 0x00680C60
	public FGameplayAbilitySpecHandle GetAbility(UClassStackOnlyPtr ability)
	{
		UBaseAbilitySystemComponent tsAbilityComponentInternal = this.TsAbilityComponentInternal;
		TSubclassOf<UGameplayAbility> tsubclassOf = ability;
		return tsAbilityComponentInternal.GetAbility(tsubclassOf);
	}

	// Token: 0x060194EE RID: 103662 RVA: 0x00682A81 File Offset: 0x00680C81
	public void ClearAbility(FGameplayAbilitySpecHandle handle)
	{
		this.TsAbilityComponentInternal.RemoveAbility(handle);
	}

	// Token: 0x060194EF RID: 103663 RVA: 0x00682A90 File Offset: 0x00680C90
	public int GetAbilityScopeLockCount()
	{
		return this.TsAbilityComponentInternal.GetAbilityScopeLockCount();
	}

	// Token: 0x060194F0 RID: 103664 RVA: 0x00682A9D File Offset: 0x00680C9D
	public void InitClass()
	{
		if (BaseAbilityComponent._isClassInitiated)
		{
			return;
		}
		BaseAbilityComponent._cachedGameplayEventData = new FGameplayEventData();
		BaseAbilityComponent._isClassInitiated = true;
	}

	// Token: 0x060194F1 RID: 103665 RVA: 0x00682AB7 File Offset: 0x00680CB7
	public UAsyncTaskWaitGameplayEvent CreateGameplayEventTask(Action<FGameplayTag, FGameplayEventData> callback)
	{
		UAsyncTaskWaitGameplayEvent uasyncTaskWaitGameplayEvent = UAsyncTaskWaitGameplayEvent.ListenForGameplayEvent(this.TsAbilityComponentInternal);
		uasyncTaskWaitGameplayEvent.EventReceived.Add(callback);
		return uasyncTaskWaitGameplayEvent;
	}

	// Token: 0x060194F2 RID: 103666 RVA: 0x00682AD0 File Offset: 0x00680CD0
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

	// Token: 0x060194F3 RID: 103667 RVA: 0x00682BB8 File Offset: 0x00680DB8
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

	// Token: 0x060194F4 RID: 103668 RVA: 0x00682CC8 File Offset: 0x00680EC8
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

	// Token: 0x060194F5 RID: 103669 RVA: 0x00682D68 File Offset: 0x00680F68
	public void RemoveGameplayEventListener(int tagId, TGameplayEventCallback callback)
	{
		HashSet<TGameplayEventCallback> hashSet;
		if (!this.GameplayEventCallbacks.TryGetValue(tagId, out hashSet))
		{
			return;
		}
		hashSet.Remove(callback);
	}

	// Token: 0x060194F6 RID: 103670 RVA: 0x00682D8E File Offset: 0x00680F8E
	public static void CreateStaticDefaultValue()
	{
		BaseAbilityComponent._cachedGameplayEventData = null;
		BaseAbilityComponent._isClassInitiated = false;
	}

	// Token: 0x060194F7 RID: 103671 RVA: 0x00682D9C File Offset: 0x00680F9C
	public static void ResetStaticDefaultValue()
	{
		BaseAbilityComponent._cachedGameplayEventData = null;
		BaseAbilityComponent._isClassInitiated = false;
	}

	// Token: 0x060194F8 RID: 103672 RVA: 0x00682DAC File Offset: 0x00680FAC
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseAbilityComponent baseAbilityComponent = (BaseAbilityComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComponent"))
		{
			if (baseAbilityComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TsAbilityComponentInternal"))
		{
			if (baseAbilityComponent.TsAbilityComponentInternal == null)
			{
				this.TsAbilityComponentInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UBaseAbilitySystemComponent>(this.TsAbilityComponentInternal), "TsAbilityComponentInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (baseAbilityComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LastPerformanceTag"))
		{
			this.LastPerformanceTag = baseAbilityComponent.LastPerformanceTag;
		}
		if (base.CanResetComponentProperty("GameplayEventTask"))
		{
			if (baseAbilityComponent.GameplayEventTask == null)
			{
				this.GameplayEventTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UAsyncTaskWaitGameplayEvent>(this.GameplayEventTask), "GameplayEventTask"))
			{
				return false;
			}
		}
		return !base.CanResetComponentProperty("GameplayEventCallbacks") || baseAbilityComponent.GameplayEventCallbacks == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, HashSet<TGameplayEventCallback>>>(this.GameplayEventCallbacks), "GameplayEventCallbacks");
	}

	// Token: 0x0400BC23 RID: 48163
	public const int DEFAULT_SOURCE_SKILL_LEVEL = 1;

	// Token: 0x0400BC24 RID: 48164
	public const int DEFAULT_SOURCE_SKILL_LEVEL_NOT_FOUND = -1;

	// Token: 0x0400BC25 RID: 48165
	[Nullable(2)]
	private BaseActorComponent ActorComponent;

	// Token: 0x0400BC26 RID: 48166
	[Nullable(2)]
	private UBaseAbilitySystemComponent TsAbilityComponentInternal;

	// Token: 0x0400BC27 RID: 48167
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400BC28 RID: 48168
	[Nullable(2)]
	private static FGameplayEventData _cachedGameplayEventData;

	// Token: 0x0400BC29 RID: 48169
	private string LastPerformanceTag = "";

	// Token: 0x0400BC2A RID: 48170
	private static bool _isClassInitiated;

	// Token: 0x0400BC2B RID: 48171
	[Nullable(2)]
	private UAsyncTaskWaitGameplayEvent GameplayEventTask;

	// Token: 0x0400BC2C RID: 48172
	protected readonly Dictionary<int, HashSet<TGameplayEventCallback>> GameplayEventCallbacks = new Dictionary<int, HashSet<TGameplayEventCallback>>();
}
