using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020027E5 RID: 10213
[NullableContext(1)]
[Nullable(0)]
public class BaseTagComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06019AFA RID: 105210 RVA: 0x007E90F8 File Offset: 0x007E72F8
	static BaseTagComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseTagComponent.CreateStaticDefaultValue), new Action(BaseTagComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06019AFB RID: 105211 RVA: 0x007E916D File Offset: 0x007E736D
	protected override bool OnInit()
	{
		this.TagContainer.AddAnyTagListener(new TAnyTagChangeCallback(this.OnAnyTagChanged));
		return true;
	}

	// Token: 0x06019AFC RID: 105212 RVA: 0x007E9188 File Offset: 0x007E7388
	protected override bool OnStart()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		UBaseAbilitySystemComponent ubaseAbilitySystemComponent2;
		if (component != null && component.IsVehicle())
		{
			VehicleActorComponent component2 = base.Entity.GetComponent<VehicleActorComponent>();
			UBaseAbilitySystemComponent ubaseAbilitySystemComponent;
			if (component2 == null)
			{
				ubaseAbilitySystemComponent = null;
			}
			else
			{
				TsBaseVehicle actor = component2.Actor;
				ubaseAbilitySystemComponent = ((actor != null) ? actor.AbilitySystemComponent : null);
			}
			ubaseAbilitySystemComponent2 = ubaseAbilitySystemComponent;
		}
		else
		{
			CharacterActorComponent component3 = base.Entity.GetComponent<CharacterActorComponent>();
			UBaseAbilitySystemComponent ubaseAbilitySystemComponent3;
			if (component3 == null)
			{
				ubaseAbilitySystemComponent3 = null;
			}
			else
			{
				TsBaseCharacter actor2 = component3.Actor;
				ubaseAbilitySystemComponent3 = ((actor2 != null) ? actor2.AbilitySystemComponent : null);
			}
			ubaseAbilitySystemComponent2 = ubaseAbilitySystemComponent3;
		}
		if (ubaseAbilitySystemComponent2 != null && ubaseAbilitySystemComponent2.IsValid())
		{
			this.TagContainer.BindTsTagContainer(ubaseAbilitySystemComponent2);
		}
		return true;
	}

	// Token: 0x06019AFD RID: 105213 RVA: 0x007E9212 File Offset: 0x007E7412
	protected override bool OnEnd()
	{
		this.TagContainer.Clear();
		return true;
	}

	// Token: 0x06019AFE RID: 105214 RVA: 0x007E9224 File Offset: 0x007E7424
	protected unsafe void Emit(int tagId, [Nullable(new byte[]
	{
		2,
		1
	})] IEnumerable<BaseTagComponent.TTagSwitchedCallback> callbacks, int argsTagId, bool argstagExist)
	{
		if (tagId == 0 || callbacks == null)
		{
			return;
		}
		string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId);
		foreach (BaseTagComponent.TTagSwitchedCallback ttagSwitchedCallback in callbacks)
		{
			try
			{
				ttagSwitchedCallback(argsTagId, argstagExist);
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.ZQR;
				string message = "tag事件回调执行异常";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tag", nameByTagId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
	}

	// Token: 0x06019AFF RID: 105215 RVA: 0x007E92E8 File Offset: 0x007E74E8
	protected unsafe void Emit(int tagId, [Nullable(new byte[]
	{
		2,
		1
	})] IEnumerable<BaseTagComponent.TTagChangedCallback> callbacks, int argsCount, int argsTagId, int argsExactTagId, int argsOldCount)
	{
		if (tagId == 0 || callbacks == null)
		{
			return;
		}
		string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId);
		foreach (BaseTagComponent.TTagChangedCallback ttagChangedCallback in callbacks)
		{
			try
			{
				ttagChangedCallback(argsCount, argsTagId, argsExactTagId, argsOldCount);
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.ZQR;
				string message = "tag事件回调执行异常";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tag", nameByTagId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
	}

	// Token: 0x06019B00 RID: 105216 RVA: 0x007E93B0 File Offset: 0x007E75B0
	public virtual void AddTag(int? tagId)
	{
		if (tagId == null)
		{
			return;
		}
		this.TagContainer.AddExactTag(ETagChannel.Common, tagId.Value);
	}

	// Token: 0x06019B01 RID: 105217 RVA: 0x007E93CF File Offset: 0x007E75CF
	public virtual bool RemoveTag(int? tagId)
	{
		if (tagId == null)
		{
			return false;
		}
		this.TagContainer.RemoveTag(ETagChannel.Common, tagId.Value);
		this.TagContainer.RemoveTag(ETagChannel.Anim, tagId.Value);
		return true;
	}

	// Token: 0x06019B02 RID: 105218 RVA: 0x007E9403 File Offset: 0x007E7603
	public virtual bool HasTag(int tagId)
	{
		return this.TagContainer.ContainsTag(tagId);
	}

	// Token: 0x06019B03 RID: 105219 RVA: 0x007E9411 File Offset: 0x007E7611
	public bool HasExactTag(int tagId)
	{
		return this.TagContainer.ContainsExactTag(tagId);
	}

	// Token: 0x06019B04 RID: 105220 RVA: 0x007E9420 File Offset: 0x007E7620
	public bool HasAnyTag(IEnumerable<int> tagIds)
	{
		foreach (int tagId in tagIds)
		{
			if (this.HasTag(tagId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06019B05 RID: 105221 RVA: 0x007E9474 File Offset: 0x007E7674
	[NullableContext(0)]
	public unsafe bool HasAnyTag(in ReadOnlySpan<int> tagIds)
	{
		ReadOnlySpan<int> readOnlySpan = tagIds;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			int tagId = *readOnlySpan[i];
			if (this.HasTag(tagId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06019B06 RID: 105222 RVA: 0x007E94B0 File Offset: 0x007E76B0
	public bool HasAnyTag(IEnumerable<int?> tagIds)
	{
		foreach (int? num in tagIds)
		{
			if (this.HasTag(num.GetValueOrDefault()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06019B07 RID: 105223 RVA: 0x007E9508 File Offset: 0x007E7708
	public bool HasAnyTagContainer(FGameplayTagContainer tagContainer)
	{
		TArray<FGameplayTag> gameplayTags = tagContainer.GameplayTags;
		for (int i = gameplayTags.Num() - 1; i >= 0; i--)
		{
			if (this.HasTag(gameplayTags.Get(i).TagId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06019B08 RID: 105224 RVA: 0x007E9548 File Offset: 0x007E7748
	public bool HasAllTag(IEnumerable<int> tagIds)
	{
		foreach (int tagId in tagIds)
		{
			if (!this.HasTag(tagId))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06019B09 RID: 105225 RVA: 0x007E959C File Offset: 0x007E779C
	public int GetTagCount(int tagId)
	{
		if (tagId == 0)
		{
			return 0;
		}
		return this.TagContainer.GetTagCount(tagId);
	}

	// Token: 0x06019B0A RID: 105226 RVA: 0x007E95B0 File Offset: 0x007E77B0
	[NullableContext(2)]
	public ITagTask ListenForTagAddOrRemove(int? tagId, [Nullable(1)] BaseTagComponent.TTagSwitchedCallback callback, Stat callbackStat = null)
	{
		if (tagId == null || callback == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "回调函数添加失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tag", GameplayTagUtils.GetNameByTagId(tagId.Value));
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		TagSwitchedTask tagSwitchedTask = new TagSwitchedTask();
		tagSwitchedTask.StartTask(tagId.Value, callback, this, callbackStat);
		return tagSwitchedTask;
	}

	// Token: 0x06019B0B RID: 105227 RVA: 0x007E9614 File Offset: 0x007E7814
	public bool HasTagAddOrRemoveListener(int tagId, BaseTagComponent.TTagSwitchedCallback callback)
	{
		HashSet<BaseTagComponent.TTagSwitchedCallback> hashSet;
		return this.TagSwitchedCallbacks.TryGetValue(tagId, out hashSet) && hashSet.Contains(callback);
	}

	// Token: 0x06019B0C RID: 105228 RVA: 0x007E963C File Offset: 0x007E783C
	public unsafe void AddTagAddOrRemoveListener(int tagId, BaseTagComponent.TTagSwitchedCallback callback, [Nullable(2)] Stat callbackStat = null)
	{
		if (tagId == 0 || callback == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "回调函数添加失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tag", GameplayTagUtils.GetNameByTagId(tagId));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("callbackName", (callback != null) ? callback.Method.Name : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		HashSet<BaseTagComponent.TTagSwitchedCallback> hashSet;
		if (!this.TagSwitchedCallbacks.TryGetValue(tagId, out hashSet))
		{
			hashSet = new HashSet<BaseTagComponent.TTagSwitchedCallback>();
			this.TagSwitchedCallbacks[tagId] = hashSet;
		}
		if (hashSet.Contains(callback))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.ZQR;
			string message2 = "重复添加回调函数";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("tag", GameplayTagUtils.GetNameByTagId(tagId));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("callbackName", callback.Method.Name);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		hashSet.Add(callback);
	}

	// Token: 0x06019B0D RID: 105229 RVA: 0x007E9750 File Offset: 0x007E7950
	public void RemoveTagAddOrRemoveListener(int tagId, BaseTagComponent.TTagSwitchedCallback callback)
	{
		HashSet<BaseTagComponent.TTagSwitchedCallback> hashSet;
		if (this.TagSwitchedCallbacks.TryGetValue(tagId, out hashSet))
		{
			hashSet.Remove(callback);
		}
	}

	// Token: 0x06019B0E RID: 105230 RVA: 0x007E9778 File Offset: 0x007E7978
	[NullableContext(2)]
	public ITagTask ListenForTagAnyCountChanged(int tagId, BaseTagComponent.TTagChangedCallback callback)
	{
		if (tagId == 0 || callback == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "回调函数添加失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tag", GameplayTagUtils.GetNameByTagId(tagId));
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		TagChangedTask tagChangedTask = new TagChangedTask();
		tagChangedTask.StartTask(tagId, callback, this, null);
		return tagChangedTask;
	}

	// Token: 0x06019B0F RID: 105231 RVA: 0x007E97C8 File Offset: 0x007E79C8
	public unsafe void AddTagChangedListener(int tagId, BaseTagComponent.TTagChangedCallback callback, [Nullable(2)] Stat callbackStat = null)
	{
		if (tagId == 0 || callback == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "回调函数添加失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tag", GameplayTagUtils.GetNameByTagId(tagId));
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		HashSet<BaseTagComponent.TTagChangedCallback> hashSet;
		if (!this.TagChangedCallbacks.TryGetValue(tagId, out hashSet))
		{
			hashSet = new HashSet<BaseTagComponent.TTagChangedCallback>();
			this.TagChangedCallbacks[tagId] = hashSet;
		}
		if (hashSet.Contains(callback))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.ZQR;
			string message2 = "重复添加回调函数";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tag", GameplayTagUtils.GetNameByTagId(tagId));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("callbackName", callback.Method.Name);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (!this.AddTagChangedListenerInEditor(hashSet, tagId, callback, callbackStat).GetValueOrDefault())
		{
			hashSet.Add(callback);
		}
	}

	// Token: 0x06019B10 RID: 105232 RVA: 0x007E98B4 File Offset: 0x007E7AB4
	private bool? AddTagChangedListenerInEditor(HashSet<BaseTagComponent.TTagChangedCallback> callbackSet, int tagId, BaseTagComponent.TTagChangedCallback callback, [Nullable(2)] Stat callbackStat = null)
	{
		return null;
	}

	// Token: 0x06019B11 RID: 105233 RVA: 0x007E98CC File Offset: 0x007E7ACC
	public void RemoveTagChangedListener(int tagId, BaseTagComponent.TTagChangedCallback callback)
	{
		HashSet<BaseTagComponent.TTagChangedCallback> hashSet;
		if (this.TagChangedCallbacks.TryGetValue(tagId, out hashSet))
		{
			this.RemoveTagChangedListenerInEditor(hashSet, tagId, callback);
			hashSet.Remove(callback);
		}
	}

	// Token: 0x06019B12 RID: 105234 RVA: 0x007E98FC File Offset: 0x007E7AFC
	private bool? RemoveTagChangedListenerInEditor(HashSet<BaseTagComponent.TTagChangedCallback> callbackSet, int tagId, BaseTagComponent.TTagChangedCallback callback)
	{
		return null;
	}

	// Token: 0x06019B13 RID: 105235 RVA: 0x007E9912 File Offset: 0x007E7B12
	public string GetTagDebugStrings()
	{
		TagContainer tagContainer = this.TagContainer;
		return ((tagContainer != null) ? tagContainer.GetDebugString() : null) ?? "";
	}

	// Token: 0x06019B14 RID: 105236 RVA: 0x007E9930 File Offset: 0x007E7B30
	protected virtual void OnAnyTagChanged(int tagId, int newCount, int oldCount, int exactTagId)
	{
		if (tagId == 0 || oldCount == newCount)
		{
			return;
		}
		bool flag = newCount > 0;
		if (oldCount > 0 != flag)
		{
			this.EmitSwitchedCallbacks(tagId, flag);
		}
		this.EmitChangedCallbacks(newCount, tagId, exactTagId, oldCount);
		AbilityEvent.Instance.Emit<int, int, int, int>(SceneTeam.Scene, EAbilityEventName.OnGameplayTagChanged, (long)tagId, base.Entity.Id, tagId, oldCount, newCount);
		BaseBuffComponent component = base.Entity.GetComponent<BaseBuffComponent>();
		if (component == null)
		{
			return;
		}
		component.OnTagChanged(tagId);
	}

	// Token: 0x06019B15 RID: 105237 RVA: 0x007E99A0 File Offset: 0x007E7BA0
	private void EmitSwitchedCallbacks(int tagId, bool tagExist)
	{
		HashSet<BaseTagComponent.TTagSwitchedCallback> hashSet;
		if (this.TagSwitchedCallbacks.TryGetValue(tagId, out hashSet))
		{
			BaseTagComponent.TTagSwitchedCallback[] array = new BaseTagComponent.TTagSwitchedCallback[hashSet.Count];
			hashSet.CopyTo(array);
			BaseTagComponent.TTagSwitchedCallback[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i](tagId, tagExist);
			}
		}
	}

	// Token: 0x06019B16 RID: 105238 RVA: 0x007E99EC File Offset: 0x007E7BEC
	private void EmitChangedCallbacks(int newCount, int tagId, int exactTagId, int oldCount)
	{
		HashSet<BaseTagComponent.TTagChangedCallback> hashSet;
		if (this.TagChangedCallbacks.TryGetValue(tagId, out hashSet))
		{
			BaseTagComponent.TTagChangedCallback[] array = new BaseTagComponent.TTagChangedCallback[hashSet.Count];
			hashSet.CopyTo(array);
			BaseTagComponent.TTagChangedCallback[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i](newCount, tagId, exactTagId, oldCount);
			}
		}
	}

	// Token: 0x06019B17 RID: 105239 RVA: 0x007E9A39 File Offset: 0x007E7C39
	public static void CreateStaticDefaultValue()
	{
		BaseTagComponent.TagChangedStats = new Dictionary<int, Stat>();
	}

	// Token: 0x06019B18 RID: 105240 RVA: 0x007E9A45 File Offset: 0x007E7C45
	public static void ResetStaticDefaultValue()
	{
		BaseTagComponent.TagChangedStats = null;
	}

	// Token: 0x06019B19 RID: 105241 RVA: 0x007E9A50 File Offset: 0x007E7C50
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseTagComponent baseTagComponent = (BaseTagComponent)componentTemplate;
		if (baseTagComponent.TagSwitchedCallbacks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagSwitchedCallbacks), "TagSwitchedCallbacks"))
		{
			return false;
		}
		if (baseTagComponent.TagChangedCallbacks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagChangedCallbacks), "TagChangedCallbacks"))
		{
			return false;
		}
		if (baseTagComponent.TagContainer == null)
		{
			this.TagContainer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagContainer), "TagContainer"))
		{
			return false;
		}
		return baseTagComponent.WrappedTagChangedListenerMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.WrappedTagChangedListenerMap), "WrappedTagChangedListenerMap");
	}

	// Token: 0x1700292A RID: 10538
	// (get) Token: 0x06019B1A RID: 105242 RVA: 0x007E9B01 File Offset: 0x007E7D01
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700292B RID: 10539
	// (get) Token: 0x06019B1B RID: 105243 RVA: 0x007E9B04 File Offset: 0x007E7D04
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700292C RID: 10540
	// (get) Token: 0x06019B1C RID: 105244 RVA: 0x007E9B07 File Offset: 0x007E7D07
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E164 RID: 57700
	protected readonly Dictionary<int, HashSet<BaseTagComponent.TTagSwitchedCallback>> TagSwitchedCallbacks = new Dictionary<int, HashSet<BaseTagComponent.TTagSwitchedCallback>>();

	// Token: 0x0400E165 RID: 57701
	protected readonly Dictionary<int, HashSet<BaseTagComponent.TTagChangedCallback>> TagChangedCallbacks = new Dictionary<int, HashSet<BaseTagComponent.TTagChangedCallback>>();

	// Token: 0x0400E166 RID: 57702
	public TagContainer TagContainer = new TagContainer();

	// Token: 0x0400E167 RID: 57703
	private static Dictionary<int, Stat> TagChangedStats;

	// Token: 0x0400E168 RID: 57704
	private readonly Dictionary<int, Dictionary<BaseTagComponent.TTagChangedCallback, BaseTagComponent.TTagChangedCallback>> WrappedTagChangedListenerMap = new Dictionary<int, Dictionary<BaseTagComponent.TTagChangedCallback, BaseTagComponent.TTagChangedCallback>>();

	// Token: 0x0400E169 RID: 57705
	[StaticVariableRuleIgnore]
	private static readonly Stat OnAnyTagChangedStat = Stat.Create("BaseTagComponent.OnAnyTagChanged", "", "");

	// Token: 0x0400E16A RID: 57706
	[StaticVariableRuleIgnore]
	private static readonly Stat OnAnyTagChangedCallbacksStat = Stat.Create("BaseTagComponent.OnAnyTagChanged.Callbacks", "", "");

	// Token: 0x0400E16B RID: 57707
	[StaticVariableRuleIgnore]
	private static readonly Stat OnAnyTagChangedOnGlobalGameplayTagChanged = Stat.Create("BaseTagComponent.OnAnyTagChanged.OnGlobalGameplayTagChanged", "", "");

	// Token: 0x02008961 RID: 35169
	// (Invoke) Token: 0x06042970 RID: 272752
	[NullableContext(0)]
	public delegate void TTagSwitchedCallback(int tagId, bool tagExist);

	// Token: 0x02008962 RID: 35170
	// (Invoke) Token: 0x06042974 RID: 272756
	[NullableContext(0)]
	public delegate void TTagChangedCallback(int count, int tagId, int exactTagId, int oldCount);
}
