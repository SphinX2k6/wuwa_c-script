using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200243A RID: 9274
[NullableContext(1)]
[Nullable(0)]
public class TagContainer : IClear
{
	// Token: 0x0601735D RID: 95069 RVA: 0x006D088C File Offset: 0x006CEA8C
	public IEnumerable<int> GetAllExactTags()
	{
		return this.ExactTags.Keys;
	}

	// Token: 0x0601735E RID: 95070 RVA: 0x006D0899 File Offset: 0x006CEA99
	public IEnumerable<ETagChannel> GetAllChannels()
	{
		return this.RawTags.Keys;
	}

	// Token: 0x0601735F RID: 95071 RVA: 0x006D08A8 File Offset: 0x006CEAA8
	[NullableContext(2)]
	public void BindTsTagContainer(UBaseAbilitySystemComponent tsAbilityComponent)
	{
		this.UeContainer = tsAbilityComponent;
		if (tsAbilityComponent != null)
		{
			foreach (int num in this.ExactTags.Keys)
			{
				FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(num);
				if (gameplayTagById != null)
				{
					FGameplayTag value = gameplayTagById.Value;
					tsAbilityComponent.UpdateTagMap(value, this.ExactTags.GetValueOrDefault(num, 0));
				}
			}
		}
	}

	// Token: 0x06017360 RID: 95072 RVA: 0x006D0930 File Offset: 0x006CEB30
	public bool Clear()
	{
		this.ExactTags.Clear();
		this.RawTags.Clear();
		this.ParentTags.Clear();
		this.AnyTagListeners.Clear();
		this.AnyExactTagListeners.Clear();
		this.UeContainer = null;
		return true;
	}

	// Token: 0x06017361 RID: 95073 RVA: 0x006D097C File Offset: 0x006CEB7C
	public bool ClearObject()
	{
		return this.Clear();
	}

	// Token: 0x06017362 RID: 95074 RVA: 0x006D0984 File Offset: 0x006CEB84
	[return: TupleElementNames(new string[]
	{
		"tagId",
		"newCount",
		"oldCount",
		"isExact",
		"exactTagId"
	})]
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	private ValueTuple<int, int, int, bool, int>[] ModifyTagInner(int tagId, int deltaCount)
	{
		if (deltaCount == 0)
		{
			return new ValueTuple<int, int, int, bool, int>[0];
		}
		int valueOrDefault = this.ExactTags.GetValueOrDefault(tagId, 0);
		int num = Math.Max(0, valueOrDefault + deltaCount);
		deltaCount = num - valueOrDefault;
		if (valueOrDefault == num)
		{
			return new ValueTuple<int, int, int, bool, int>[0];
		}
		if (num <= 0)
		{
			this.ExactTags.Remove(tagId);
		}
		else
		{
			this.ExactTags[tagId] = num;
		}
		int parentTag = GameplayTagUtils.GetParentTag(tagId);
		List<ValueTuple<int, int, int, bool, int>> list = new List<ValueTuple<int, int, int, bool, int>>
		{
			new ValueTuple<int, int, int, bool, int>(tagId, num, valueOrDefault, true, tagId)
		};
		while (parentTag != 0)
		{
			int valueOrDefault2 = this.ParentTags.GetValueOrDefault(parentTag, 0);
			int valueOrDefault3 = this.ExactTags.GetValueOrDefault(parentTag, 0);
			int num2 = Math.Max(0, valueOrDefault2 + deltaCount);
			if (num2 <= 0)
			{
				this.ParentTags.Remove(parentTag);
			}
			else
			{
				this.ParentTags[parentTag] = num2;
			}
			list.Add(new ValueTuple<int, int, int, bool, int>(parentTag, num2 + valueOrDefault3, valueOrDefault2 + valueOrDefault3, false, tagId));
			parentTag = GameplayTagUtils.GetParentTag(parentTag);
		}
		FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(tagId);
		if (gameplayTagById != null)
		{
			UBaseAbilitySystemComponent ueContainer = this.UeContainer;
			if (ueContainer != null)
			{
				FGameplayTag value = gameplayTagById.Value;
				ueContainer.UpdateTagMap(value, deltaCount);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06017363 RID: 95075 RVA: 0x006D0AA4 File Offset: 0x006CECA4
	private void InvokeEvents([TupleElementNames(new string[]
	{
		"tagId",
		"newCount",
		"oldCount",
		"isExact",
		"exactTagId"
	})] [Nullable(new byte[]
	{
		2,
		0
	})] ValueTuple<int, int, int, bool, int>[] callbackList)
	{
		if (callbackList == null || callbackList.Length == 0)
		{
			return;
		}
		foreach (ValueTuple<int, int, int, bool, int> valueTuple in callbackList)
		{
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			int item3 = valueTuple.Item3;
			bool item4 = valueTuple.Item4;
			int item5 = valueTuple.Item5;
			if (item4)
			{
				TAnyTagChangeCallback[] array = new TAnyTagChangeCallback[this.AnyExactTagListeners.Count];
				this.AnyExactTagListeners.CopyTo(array);
				foreach (TAnyTagChangeCallback tanyTagChangeCallback in array)
				{
					try
					{
						tanyTagChangeCallback(item, item2, item3, item5);
					}
					catch (Exception ex)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Character;
						ELogAuthor author = ELogAuthor.ZQR;
						string message = "执行Tag监听回调时出错";
						Exception error = ex;
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("error", ex.Message);
						instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
				}
			}
			TAnyTagChangeCallback[] array3 = new TAnyTagChangeCallback[this.AnyTagListeners.Count];
			this.AnyTagListeners.CopyTo(array3);
			foreach (TAnyTagChangeCallback tanyTagChangeCallback2 in array3)
			{
				try
				{
					tanyTagChangeCallback2(item, item2, item3, item5);
				}
				catch (Exception ex2)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Character;
					ELogAuthor author2 = ELogAuthor.ZQR;
					string message2 = "执行Tag监听回调时出错";
					Exception error2 = ex2;
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("error", ex2.Message);
					instance2.ErrorWithStack(module2, author2, message2, error2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				}
			}
		}
	}

	// Token: 0x06017364 RID: 95076 RVA: 0x006D0C24 File Offset: 0x006CEE24
	public void AddExactTag(ETagChannel tagChannel, int tagId)
	{
		Dictionary<int, int> dictionary;
		if (!this.RawTags.TryGetValue(tagChannel, out dictionary))
		{
			dictionary = new Dictionary<int, int>();
			this.RawTags[tagChannel] = dictionary;
		}
		dictionary[tagId] = dictionary.GetValueOrDefault(tagId, 0) + 1;
		ValueTuple<int, int, int, bool, int>[] callbackList = this.ModifyTagInner(tagId, 1);
		this.InvokeEvents(callbackList);
	}

	// Token: 0x06017365 RID: 95077 RVA: 0x006D0C78 File Offset: 0x006CEE78
	public void RemoveTag(ETagChannel tagChannel, int tagId)
	{
		Dictionary<int, int> dictionary;
		if (!this.RawTags.TryGetValue(tagChannel, out dictionary))
		{
			return;
		}
		int valueOrDefault = dictionary.GetValueOrDefault(tagId, 0);
		dictionary.Remove(tagId);
		ValueTuple<int, int, int, bool, int>[] array = this.ModifyTagInner(tagId, -valueOrDefault) ?? new ValueTuple<int, int, int, bool, int>[0];
		if (this.ParentTags.GetValueOrDefault(tagId, 0) > 0)
		{
			List<int> list = new List<int>();
			foreach (int num in dictionary.Keys)
			{
				if (GameplayTagUtils.IsChildTag(num, tagId))
				{
					list.Add(num);
				}
			}
			foreach (int num2 in list)
			{
				int valueOrDefault2 = dictionary.GetValueOrDefault(num2, 0);
				dictionary.Remove(num2);
				ValueTuple<int, int, int, bool, int>[] array2 = this.ModifyTagInner(num2, -valueOrDefault2);
				if (array2 != null)
				{
					ValueTuple<int, int, int, bool, int>[] array3 = new ValueTuple<int, int, int, bool, int>[array.Length + array2.Length];
					array.CopyTo(array3, 0);
					array2.CopyTo(array3, array.Length);
					array = array3;
				}
			}
		}
		if (dictionary.Count == 0)
		{
			this.RawTags.Remove(tagChannel);
		}
		this.InvokeEvents(array);
	}

	// Token: 0x06017366 RID: 95078 RVA: 0x006D0DC8 File Offset: 0x006CEFC8
	public void RemoveExactTag(ETagChannel tagChannel, int tagId)
	{
		Dictionary<int, int> dictionary;
		if (!this.RawTags.TryGetValue(tagChannel, out dictionary))
		{
			return;
		}
		int valueOrDefault = dictionary.GetValueOrDefault(tagId, 0);
		ValueTuple<int, int, int, bool, int>[] callbackList = null;
		if (valueOrDefault > 0)
		{
			callbackList = this.ModifyTagInner(tagId, -valueOrDefault);
			dictionary.Remove(tagId);
		}
		if (dictionary.Count == 0)
		{
			this.RawTags.Remove(tagChannel);
		}
		this.InvokeEvents(callbackList);
	}

	// Token: 0x06017367 RID: 95079 RVA: 0x006D0E24 File Offset: 0x006CF024
	public void UpdateExactTag(ETagChannel tagChannel, int tagId, int deltaCount)
	{
		Dictionary<int, int> dictionary;
		if (!this.RawTags.TryGetValue(tagChannel, out dictionary))
		{
			if (deltaCount <= 0)
			{
				return;
			}
			dictionary = new Dictionary<int, int>();
			this.RawTags[tagChannel] = dictionary;
		}
		int valueOrDefault = dictionary.GetValueOrDefault(tagId, 0);
		int num = Math.Max(0, valueOrDefault + deltaCount);
		if (num > 0)
		{
			dictionary[tagId] = num;
		}
		else
		{
			dictionary.Remove(tagId);
		}
		ValueTuple<int, int, int, bool, int>[] callbackList = this.ModifyTagInner(tagId, num - valueOrDefault);
		if (dictionary.Count == 0)
		{
			this.RawTags.Remove(tagChannel);
		}
		this.InvokeEvents(callbackList);
	}

	// Token: 0x06017368 RID: 95080 RVA: 0x006D0EAB File Offset: 0x006CF0AB
	public bool ContainsTag(int tagId)
	{
		return this.ExactTags.ContainsKey(tagId) || this.ParentTags.ContainsKey(tagId);
	}

	// Token: 0x06017369 RID: 95081 RVA: 0x006D0EC9 File Offset: 0x006CF0C9
	public bool ContainsExactTag(int tagId)
	{
		return this.ExactTags.ContainsKey(tagId);
	}

	// Token: 0x0601736A RID: 95082 RVA: 0x006D0ED8 File Offset: 0x006CF0D8
	public int GetRawTagCount(ETagChannel channel, int tagId)
	{
		Dictionary<int, int> dictionary;
		if (this.RawTags.TryGetValue(channel, out dictionary))
		{
			return dictionary.GetValueOrDefault(tagId, 0);
		}
		return 0;
	}

	// Token: 0x0601736B RID: 95083 RVA: 0x006D0EFF File Offset: 0x006CF0FF
	public int GetTagCount(int tagId)
	{
		return this.ExactTags.GetValueOrDefault(tagId, 0) + this.ParentTags.GetValueOrDefault(tagId, 0);
	}

	// Token: 0x0601736C RID: 95084 RVA: 0x006D0F1C File Offset: 0x006CF11C
	public int GetExactTagCount(int tagId)
	{
		return this.ExactTags.GetValueOrDefault(tagId, 0);
	}

	// Token: 0x0601736D RID: 95085 RVA: 0x006D0F2B File Offset: 0x006CF12B
	public void AddAnyTagListener(TAnyTagChangeCallback listener)
	{
		this.AnyTagListeners.Add(listener);
	}

	// Token: 0x0601736E RID: 95086 RVA: 0x006D0F3A File Offset: 0x006CF13A
	public void RemoveAnyTagListener(TAnyTagChangeCallback listener)
	{
		this.AnyTagListeners.Remove(listener);
	}

	// Token: 0x0601736F RID: 95087 RVA: 0x006D0F49 File Offset: 0x006CF149
	public void AddAnyExactTagListener(TAnyTagChangeCallback listener)
	{
		this.AnyExactTagListeners.Add(listener);
	}

	// Token: 0x06017370 RID: 95088 RVA: 0x006D0F58 File Offset: 0x006CF158
	public void RemoveExactAnyTagListener(TAnyTagChangeCallback listener)
	{
		this.AnyExactTagListeners.Remove(listener);
	}

	// Token: 0x06017371 RID: 95089 RVA: 0x006D0F68 File Offset: 0x006CF168
	public string GetDebugString()
	{
		string text = "汇总tag:\n";
		text += this.GetExactTagsDebugString();
		text += "\n\n父tag:\n";
		List<ValueTuple<string, int>> list = new List<ValueTuple<string, int>>();
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in this.ParentTags)
		{
			List<ValueTuple<string, int>> list2 = list;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendFormatted(GameplayTagUtils.GetNameByTagId(keyValuePair.Key));
			defaultInterpolatedStringHandler.AppendLiteral(" * ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Value);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			list2.Add(new ValueTuple<string, int>(defaultInterpolatedStringHandler.ToStringAndClear(), num));
			num++;
		}
		list.Sort(delegate([TupleElementNames(new string[]
		{
			"text",
			"order"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<string, int> left, [TupleElementNames(new string[]
		{
			"text",
			"order"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<string, int> right)
		{
			int num2 = Comparer<string>.Default.Compare(left.Item1, right.Item1);
			if (num2 == 0)
			{
				return left.Item2.CompareTo(right.Item2);
			}
			return num2;
		});
		text += string.Join("", list.ConvertAll<string>(([TupleElementNames(new string[]
		{
			"text",
			"order"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<string, int> item) => item.Item1));
		return text;
	}

	// Token: 0x06017372 RID: 95090 RVA: 0x006D1094 File Offset: 0x006CF294
	public string GetExactTagsDebugString()
	{
		List<ValueTuple<string, int>> list = new List<ValueTuple<string, int>>();
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in this.ExactTags)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendFormatted(GameplayTagUtils.GetNameByTagId(keyValuePair.Key));
			defaultInterpolatedStringHandler.AppendLiteral(" x ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Value);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			foreach (ETagChannel key in this.RawTags.Keys)
			{
				Dictionary<int, int> dictionary;
				if (this.RawTags.TryGetValue(key, out dictionary))
				{
					int valueOrDefault = dictionary.GetValueOrDefault(keyValuePair.Key, 0);
					if (valueOrDefault != 0)
					{
						string str = text;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
						defaultInterpolatedStringHandler.AppendFormatted(TagContainer.channelDebugName[key]);
						defaultInterpolatedStringHandler.AppendLiteral(" x ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
						text = str + defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
			}
			list.Add(new ValueTuple<string, int>(text + ")\n", num));
			num++;
		}
		list.Sort(delegate([TupleElementNames(new string[]
		{
			"text",
			"order"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<string, int> left, [TupleElementNames(new string[]
		{
			"text",
			"order"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<string, int> right)
		{
			int num2 = Comparer<string>.Default.Compare(left.Item1, right.Item1);
			if (num2 == 0)
			{
				return left.Item2.CompareTo(right.Item2);
			}
			return num2;
		});
		return string.Join("", list.ConvertAll<string>(([TupleElementNames(new string[]
		{
			"text",
			"order"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<string, int> item) => item.Item1));
	}

	// Token: 0x06017373 RID: 95091 RVA: 0x006D126C File Offset: 0x006CF46C
	public bool HasAnyTag(TagContainer otherContainer)
	{
		foreach (int tagId in otherContainer.GetAllExactTags())
		{
			if (this.ContainsTag(tagId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06017374 RID: 95092 RVA: 0x006D12C4 File Offset: 0x006CF4C4
	public bool HasAllTag(TagContainer otherContainer)
	{
		foreach (int tagId in otherContainer.GetAllExactTags())
		{
			if (!this.ContainsTag(tagId))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06017375 RID: 95093 RVA: 0x006D131C File Offset: 0x006CF51C
	public bool NotHasAnyTag(TagContainer otherContainer)
	{
		foreach (int tagId in otherContainer.GetAllExactTags())
		{
			if (!this.ContainsTag(tagId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06017376 RID: 95094 RVA: 0x006D1374 File Offset: 0x006CF574
	public bool NotHasAllTag(TagContainer otherContainer)
	{
		foreach (int tagId in otherContainer.GetAllExactTags())
		{
			if (this.ContainsTag(tagId))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06017378 RID: 95096 RVA: 0x006D140C File Offset: 0x006CF60C
	// Note: this type is marked as 'beforefieldinit'.
	static TagContainer()
	{
		Dictionary<ETagChannel, string> dictionary = new Dictionary<ETagChannel, string>();
		dictionary[ETagChannel.Common] = "Tag";
		dictionary[ETagChannel.BattleBuff] = "Buff";
		dictionary[ETagChannel.LevelServer] = "关卡服务器";
		dictionary[ETagChannel.Anim] = "动画";
		dictionary[ETagChannel.Player] = "玩家编队";
		dictionary[ETagChannel.Frozen] = "Frozen";
		dictionary[ETagChannel.PassiveSkill] = "被动技能";
		TagContainer.channelDebugName = dictionary;
		TagContainer.ModifyTagInnerStat = Stat.Create("TagContainer.ModifyTagInner", "STATGROUP_KuroBattle", "");
		TagContainer.ModifyTagInnerModifyCountStat = Stat.Create("TagContainer.ModifyTagInner.ModifyCount", "STATGROUP_KuroBattle", "");
		TagContainer.ModifyTagInnerUpdateUeStat = Stat.Create("TagContainer.ModifyTagInner.UpdateUe", "STATGROUP_KuroBattle", "");
		TagContainer.InvokeEventsStat = Stat.Create("TagContainer.InvokeEvents", "STATGROUP_KuroBattle", "");
		TagContainer.UpdateExactTagStat = Stat.Create("TagContainer.UpdateExactTag", "STATGROUP_KuroBattle", "");
	}

	// Token: 0x0400C3C3 RID: 50115
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<ETagChannel, string> channelDebugName;

	// Token: 0x0400C3C4 RID: 50116
	private readonly Dictionary<ETagChannel, Dictionary<int, int>> RawTags = new Dictionary<ETagChannel, Dictionary<int, int>>();

	// Token: 0x0400C3C5 RID: 50117
	private readonly Dictionary<int, int> ExactTags = new Dictionary<int, int>();

	// Token: 0x0400C3C6 RID: 50118
	private readonly Dictionary<int, int> ParentTags = new Dictionary<int, int>();

	// Token: 0x0400C3C7 RID: 50119
	private readonly HashSet<TAnyTagChangeCallback> AnyTagListeners = new HashSet<TAnyTagChangeCallback>();

	// Token: 0x0400C3C8 RID: 50120
	private readonly HashSet<TAnyTagChangeCallback> AnyExactTagListeners = new HashSet<TAnyTagChangeCallback>();

	// Token: 0x0400C3C9 RID: 50121
	[Nullable(2)]
	private UBaseAbilitySystemComponent UeContainer;

	// Token: 0x0400C3CA RID: 50122
	[StaticVariableRuleIgnore]
	private static readonly Stat ModifyTagInnerStat;

	// Token: 0x0400C3CB RID: 50123
	[StaticVariableRuleIgnore]
	private static readonly Stat ModifyTagInnerModifyCountStat;

	// Token: 0x0400C3CC RID: 50124
	[StaticVariableRuleIgnore]
	private static readonly Stat ModifyTagInnerUpdateUeStat;

	// Token: 0x0400C3CD RID: 50125
	[StaticVariableRuleIgnore]
	private static readonly Stat InvokeEventsStat;

	// Token: 0x0400C3CE RID: 50126
	[StaticVariableRuleIgnore]
	private static readonly Stat UpdateExactTagStat;
}
