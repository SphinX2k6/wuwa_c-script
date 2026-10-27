using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003276 RID: 12918
[NullableContext(1)]
[Nullable(0)]
public class BaseTagComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601BF17 RID: 114455 RVA: 0x007C1CC0 File Offset: 0x007BFEC0
	static BaseTagComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseTagComponent.CreateStaticDefaultValue), new Action(BaseTagComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601BF18 RID: 114456 RVA: 0x007C1D35 File Offset: 0x007BFF35
	protected override bool OnInit()
	{
		this.TagContainer.AddAnyTagListener(new TAnyTagChangeCallback(this.OnAnyTagChanged));
		return true;
	}

	// Token: 0x0601BF19 RID: 114457 RVA: 0x007C1D50 File Offset: 0x007BFF50
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

	// Token: 0x0601BF1A RID: 114458 RVA: 0x007C1DDA File Offset: 0x007BFFDA
	protected override bool OnEnd()
	{
		this.TagContainer.Clear();
		return true;
	}

	// Token: 0x0601BF1B RID: 114459 RVA: 0x007C1DEC File Offset: 0x007BFFEC
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

	// Token: 0x0601BF1C RID: 114460 RVA: 0x007C1EB0 File Offset: 0x007C00B0
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

	// Token: 0x0601BF1D RID: 114461 RVA: 0x007C1F78 File Offset: 0x007C0178
	public virtual void AddTag(int? tagId)
	{
		if (tagId == null)
		{
			return;
		}
		this.TagContainer.AddExactTag(ETagChannel.Common, tagId.Value);
	}

	// Token: 0x0601BF1E RID: 114462 RVA: 0x007C1F97 File Offset: 0x007C0197
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

	// Token: 0x0601BF1F RID: 114463 RVA: 0x007C1FCB File Offset: 0x007C01CB
	public virtual bool HasTag(int tagId)
	{
		return this.TagContainer.ContainsTag(tagId);
	}

	// Token: 0x0601BF20 RID: 114464 RVA: 0x007C1FD9 File Offset: 0x007C01D9
	public bool HasExactTag(int tagId)
	{
		return this.TagContainer.ContainsExactTag(tagId);
	}

	// Token: 0x0601BF21 RID: 114465 RVA: 0x007C1FE8 File Offset: 0x007C01E8
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

	// Token: 0x0601BF22 RID: 114466 RVA: 0x007C203C File Offset: 0x007C023C
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

	// Token: 0x0601BF23 RID: 114467 RVA: 0x007C2078 File Offset: 0x007C0278
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

	// Token: 0x0601BF24 RID: 114468 RVA: 0x007C20D0 File Offset: 0x007C02D0
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

	// Token: 0x0601BF25 RID: 114469 RVA: 0x007C2110 File Offset: 0x007C0310
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

	// Token: 0x0601BF26 RID: 114470 RVA: 0x007C2164 File Offset: 0x007C0364
	public int GetTagCount(int tagId)
	{
		if (tagId == 0)
		{
			return 0;
		}
		return this.TagContainer.GetTagCount(tagId);
	}

	// Token: 0x0601BF27 RID: 114471 RVA: 0x007C2178 File Offset: 0x007C0378
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

	// Token: 0x0601BF28 RID: 114472 RVA: 0x007C21DC File Offset: 0x007C03DC
	public bool HasTagAddOrRemoveListener(int tagId, BaseTagComponent.TTagSwitchedCallback callback)
	{
		HashSet<BaseTagComponent.TTagSwitchedCallback> hashSet;
		return this.TagSwitchedCallbacks.TryGetValue(tagId, out hashSet) && hashSet.Contains(callback);
	}

	// Token: 0x0601BF29 RID: 114473 RVA: 0x007C2204 File Offset: 0x007C0404
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

	// Token: 0x0601BF2A RID: 114474 RVA: 0x007C2318 File Offset: 0x007C0518
	public void RemoveTagAddOrRemoveListener(int tagId, BaseTagComponent.TTagSwitchedCallback callback)
	{
		HashSet<BaseTagComponent.TTagSwitchedCallback> hashSet;
		if (this.TagSwitchedCallbacks.TryGetValue(tagId, out hashSet))
		{
			hashSet.Remove(callback);
		}
	}

	// Token: 0x0601BF2B RID: 114475 RVA: 0x007C2340 File Offset: 0x007C0540
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

	// Token: 0x0601BF2C RID: 114476 RVA: 0x007C2390 File Offset: 0x007C0590
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

	// Token: 0x0601BF2D RID: 114477 RVA: 0x007C247C File Offset: 0x007C067C
	private bool? AddTagChangedListenerInEditor(HashSet<BaseTagComponent.TTagChangedCallback> callbackSet, int tagId, BaseTagComponent.TTagChangedCallback callback, [Nullable(2)] Stat callbackStat = null)
	{
		return null;
	}

	// Token: 0x0601BF2E RID: 114478 RVA: 0x007C2494 File Offset: 0x007C0694
	public void RemoveTagChangedListener(int tagId, BaseTagComponent.TTagChangedCallback callback)
	{
		HashSet<BaseTagComponent.TTagChangedCallback> hashSet;
		if (this.TagChangedCallbacks.TryGetValue(tagId, out hashSet))
		{
			this.RemoveTagChangedListenerInEditor(hashSet, tagId, callback);
			hashSet.Remove(callback);
		}
	}

	// Token: 0x0601BF2F RID: 114479 RVA: 0x007C24C4 File Offset: 0x007C06C4
	private bool? RemoveTagChangedListenerInEditor(HashSet<BaseTagComponent.TTagChangedCallback> callbackSet, int tagId, BaseTagComponent.TTagChangedCallback callback)
	{
		return null;
	}

	// Token: 0x0601BF30 RID: 114480 RVA: 0x007C24DA File Offset: 0x007C06DA
	public string GetTagDebugStrings()
	{
		TagContainer tagContainer = this.TagContainer;
		return ((tagContainer != null) ? tagContainer.GetDebugString() : null) ?? "";
	}

	// Token: 0x0601BF31 RID: 114481 RVA: 0x007C24F8 File Offset: 0x007C06F8
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

	// Token: 0x0601BF32 RID: 114482 RVA: 0x007C2568 File Offset: 0x007C0768
	private void EmitSwitchedCallbacks(int tagId, bool tagExist)
	{
		HashSet<BaseTagComponent.TTagSwitchedCallback> source;
		if (this.TagSwitchedCallbacks.TryGetValue(tagId, out source))
		{
			BaseTagComponent.TTagSwitchedCallback[] array = source.ToArray<BaseTagComponent.TTagSwitchedCallback>();
			for (int i = 0; i < array.Length; i++)
			{
				array[i](tagId, tagExist);
			}
		}
	}

	// Token: 0x0601BF33 RID: 114483 RVA: 0x007C25A4 File Offset: 0x007C07A4
	private void EmitChangedCallbacks(int newCount, int tagId, int exactTagId, int oldCount)
	{
		HashSet<BaseTagComponent.TTagChangedCallback> source;
		if (this.TagChangedCallbacks.TryGetValue(tagId, out source))
		{
			BaseTagComponent.TTagChangedCallback[] array = source.ToArray<BaseTagComponent.TTagChangedCallback>();
			for (int i = 0; i < array.Length; i++)
			{
				array[i](newCount, tagId, exactTagId, oldCount);
			}
		}
	}

	// Token: 0x0601BF34 RID: 114484 RVA: 0x007C25E3 File Offset: 0x007C07E3
	public static void CreateStaticDefaultValue()
	{
		BaseTagComponent.TagChangedStats = new Dictionary<int, Stat>();
	}

	// Token: 0x0601BF35 RID: 114485 RVA: 0x007C25EF File Offset: 0x007C07EF
	public static void ResetStaticDefaultValue()
	{
		BaseTagComponent.TagChangedStats = null;
	}

	// Token: 0x0601BF36 RID: 114486 RVA: 0x007C25F8 File Offset: 0x007C07F8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseTagComponent baseTagComponent = (BaseTagComponent)componentTemplate;
		if (base.CanResetComponentProperty("TagSwitchedCallbacks") && baseTagComponent.TagSwitchedCallbacks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, HashSet<BaseTagComponent.TTagSwitchedCallback>>>(this.TagSwitchedCallbacks), "TagSwitchedCallbacks"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TagChangedCallbacks") && baseTagComponent.TagChangedCallbacks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, HashSet<BaseTagComponent.TTagChangedCallback>>>(this.TagChangedCallbacks), "TagChangedCallbacks"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TagContainer"))
		{
			if (baseTagComponent.TagContainer == null)
			{
				this.TagContainer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TagContainer>(this.TagContainer), "TagContainer"))
			{
				return false;
			}
		}
		return !base.CanResetComponentProperty("WrappedTagChangedListenerMap") || baseTagComponent.WrappedTagChangedListenerMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, Dictionary<BaseTagComponent.TTagChangedCallback, BaseTagComponent.TTagChangedCallback>>>(this.WrappedTagChangedListenerMap), "WrappedTagChangedListenerMap");
	}

	// Token: 0x0400DCC5 RID: 56517
	protected readonly Dictionary<int, HashSet<BaseTagComponent.TTagSwitchedCallback>> TagSwitchedCallbacks = new Dictionary<int, HashSet<BaseTagComponent.TTagSwitchedCallback>>();

	// Token: 0x0400DCC6 RID: 56518
	protected readonly Dictionary<int, HashSet<BaseTagComponent.TTagChangedCallback>> TagChangedCallbacks = new Dictionary<int, HashSet<BaseTagComponent.TTagChangedCallback>>();

	// Token: 0x0400DCC7 RID: 56519
	public TagContainer TagContainer = new TagContainer();

	// Token: 0x0400DCC8 RID: 56520
	private static Dictionary<int, Stat> TagChangedStats;

	// Token: 0x0400DCC9 RID: 56521
	private readonly Dictionary<int, Dictionary<BaseTagComponent.TTagChangedCallback, BaseTagComponent.TTagChangedCallback>> WrappedTagChangedListenerMap = new Dictionary<int, Dictionary<BaseTagComponent.TTagChangedCallback, BaseTagComponent.TTagChangedCallback>>();

	// Token: 0x0400DCCA RID: 56522
	[StaticVariableRuleIgnore]
	private static readonly Stat OnAnyTagChangedStat = Stat.Create("BaseTagComponent.OnAnyTagChanged", "", "");

	// Token: 0x0400DCCB RID: 56523
	[StaticVariableRuleIgnore]
	private static readonly Stat OnAnyTagChangedCallbacksStat = Stat.Create("BaseTagComponent.OnAnyTagChanged.Callbacks", "", "");

	// Token: 0x0400DCCC RID: 56524
	[StaticVariableRuleIgnore]
	private static readonly Stat OnAnyTagChangedOnGlobalGameplayTagChanged = Stat.Create("BaseTagComponent.OnAnyTagChanged.OnGlobalGameplayTagChanged", "", "");

	// Token: 0x0200973B RID: 38715
	// (Invoke) Token: 0x0604C4E2 RID: 312546
	[NullableContext(0)]
	public delegate void TTagSwitchedCallback(int tagId, bool tagExist);

	// Token: 0x0200973C RID: 38716
	// (Invoke) Token: 0x0604C4E6 RID: 312550
	[NullableContext(0)]
	public delegate void TTagChangedCallback(int count, int tagId, int exactTagId, int oldCount);
}
