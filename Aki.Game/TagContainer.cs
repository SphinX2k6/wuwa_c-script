using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002EE7 RID: 12007
[NullableContext(1)]
[Nullable(0)]
public class TagContainer : IClear
{
	// Token: 0x06019A5A RID: 105050 RVA: 0x006AA71C File Offset: 0x006A891C
	public IEnumerable<int> GetAllExactTags()
	{
		return this.ExactTags.Keys;
	}

	// Token: 0x06019A5B RID: 105051 RVA: 0x006AA729 File Offset: 0x006A8929
	public IEnumerable<ETagChannel> GetAllChannels()
	{
		return this.RawTags.Keys;
	}

	// Token: 0x06019A5C RID: 105052 RVA: 0x006AA738 File Offset: 0x006A8938
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

	// Token: 0x06019A5D RID: 105053 RVA: 0x006AA7C0 File Offset: 0x006A89C0
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

	// Token: 0x06019A5E RID: 105054 RVA: 0x006AA80C File Offset: 0x006A8A0C
	public bool ClearObject()
	{
		return this.Clear();
	}

	// Token: 0x06019A5F RID: 105055 RVA: 0x006AA814 File Offset: 0x006A8A14
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

	// Token: 0x06019A60 RID: 105056 RVA: 0x006AA934 File Offset: 0x006A8B34
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
				foreach (TAnyTagChangeCallback tanyTagChangeCallback in this.AnyExactTagListeners.ToArray<TAnyTagChangeCallback>())
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
			foreach (TAnyTagChangeCallback tanyTagChangeCallback2 in this.AnyTagListeners.ToArray<TAnyTagChangeCallback>())
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

	// Token: 0x06019A61 RID: 105057 RVA: 0x006AAA84 File Offset: 0x006A8C84
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

	// Token: 0x06019A62 RID: 105058 RVA: 0x006AAAD8 File Offset: 0x006A8CD8
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
					array = array.Concat(array2).ToArray<ValueTuple<int, int, int, bool, int>>();
				}
			}
		}
		if (dictionary.Count == 0)
		{
			this.RawTags.Remove(tagChannel);
		}
		this.InvokeEvents(array);
	}

	// Token: 0x06019A63 RID: 105059 RVA: 0x006AAC10 File Offset: 0x006A8E10
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

	// Token: 0x06019A64 RID: 105060 RVA: 0x006AAC6C File Offset: 0x006A8E6C
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

	// Token: 0x06019A65 RID: 105061 RVA: 0x006AACF3 File Offset: 0x006A8EF3
	public bool ContainsTag(int tagId)
	{
		return this.ExactTags.ContainsKey(tagId) || this.ParentTags.ContainsKey(tagId);
	}

	// Token: 0x06019A66 RID: 105062 RVA: 0x006AAD11 File Offset: 0x006A8F11
	public bool ContainsExactTag(int tagId)
	{
		return this.ExactTags.ContainsKey(tagId);
	}

	// Token: 0x06019A67 RID: 105063 RVA: 0x006AAD20 File Offset: 0x006A8F20
	public int GetRawTagCount(ETagChannel channel, int tagId)
	{
		Dictionary<int, int> dictionary;
		if (this.RawTags.TryGetValue(channel, out dictionary))
		{
			return dictionary.GetValueOrDefault(tagId, 0);
		}
		return 0;
	}

	// Token: 0x06019A68 RID: 105064 RVA: 0x006AAD47 File Offset: 0x006A8F47
	public int GetTagCount(int tagId)
	{
		return this.ExactTags.GetValueOrDefault(tagId, 0) + this.ParentTags.GetValueOrDefault(tagId, 0);
	}

	// Token: 0x06019A69 RID: 105065 RVA: 0x006AAD64 File Offset: 0x006A8F64
	public int GetExactTagCount(int tagId)
	{
		return this.ExactTags.GetValueOrDefault(tagId, 0);
	}

	// Token: 0x06019A6A RID: 105066 RVA: 0x006AAD73 File Offset: 0x006A8F73
	public void AddAnyTagListener(TAnyTagChangeCallback listener)
	{
		this.AnyTagListeners.Add(listener);
	}

	// Token: 0x06019A6B RID: 105067 RVA: 0x006AAD82 File Offset: 0x006A8F82
	public void RemoveAnyTagListener(TAnyTagChangeCallback listener)
	{
		this.AnyTagListeners.Remove(listener);
	}

	// Token: 0x06019A6C RID: 105068 RVA: 0x006AAD91 File Offset: 0x006A8F91
	public void AddAnyExactTagListener(TAnyTagChangeCallback listener)
	{
		this.AnyExactTagListeners.Add(listener);
	}

	// Token: 0x06019A6D RID: 105069 RVA: 0x006AADA0 File Offset: 0x006A8FA0
	public void RemoveExactAnyTagListener(TAnyTagChangeCallback listener)
	{
		this.AnyExactTagListeners.Remove(listener);
	}

	// Token: 0x06019A6E RID: 105070 RVA: 0x006AADB0 File Offset: 0x006A8FB0
	public string GetDebugString()
	{
		return "汇总tag:\n" + this.GetExactTagsDebugString() + "\n\n父tag:\n" + string.Join("", from s in this.ParentTags.Select(delegate(KeyValuePair<int, int> kvp)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendFormatted(GameplayTagUtils.GetNameByTagId(kvp.Key));
			defaultInterpolatedStringHandler.AppendLiteral(" * ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(kvp.Value);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		})
		orderby s
		select s);
	}

	// Token: 0x06019A6F RID: 105071 RVA: 0x006AAE34 File Offset: 0x006A9034
	public string GetExactTagsDebugString()
	{
		return string.Join("", from s in this.ExactTags.Select(delegate(KeyValuePair<int, int> kvp)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendFormatted(GameplayTagUtils.GetNameByTagId(kvp.Key));
			defaultInterpolatedStringHandler.AppendLiteral(" x ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(kvp.Value);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			foreach (ETagChannel key in this.RawTags.Keys)
			{
				Dictionary<int, int> dictionary;
				if (this.RawTags.TryGetValue(key, out dictionary))
				{
					int valueOrDefault = dictionary.GetValueOrDefault(kvp.Key, 0);
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
			return text + ")\n";
		})
		orderby s
		select s);
	}

	// Token: 0x06019A70 RID: 105072 RVA: 0x006AAE88 File Offset: 0x006A9088
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

	// Token: 0x06019A71 RID: 105073 RVA: 0x006AAEE0 File Offset: 0x006A90E0
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

	// Token: 0x06019A72 RID: 105074 RVA: 0x006AAF38 File Offset: 0x006A9138
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

	// Token: 0x06019A73 RID: 105075 RVA: 0x006AAF90 File Offset: 0x006A9190
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

	// Token: 0x06019A75 RID: 105077 RVA: 0x006AB028 File Offset: 0x006A9228
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

	// Token: 0x0400C028 RID: 49192
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<ETagChannel, string> channelDebugName;

	// Token: 0x0400C029 RID: 49193
	private readonly Dictionary<ETagChannel, Dictionary<int, int>> RawTags = new Dictionary<ETagChannel, Dictionary<int, int>>();

	// Token: 0x0400C02A RID: 49194
	private readonly Dictionary<int, int> ExactTags = new Dictionary<int, int>();

	// Token: 0x0400C02B RID: 49195
	private readonly Dictionary<int, int> ParentTags = new Dictionary<int, int>();

	// Token: 0x0400C02C RID: 49196
	private readonly HashSet<TAnyTagChangeCallback> AnyTagListeners = new HashSet<TAnyTagChangeCallback>();

	// Token: 0x0400C02D RID: 49197
	private readonly HashSet<TAnyTagChangeCallback> AnyExactTagListeners = new HashSet<TAnyTagChangeCallback>();

	// Token: 0x0400C02E RID: 49198
	[Nullable(2)]
	private UBaseAbilitySystemComponent UeContainer;

	// Token: 0x0400C02F RID: 49199
	[StaticVariableRuleIgnore]
	private static readonly Stat ModifyTagInnerStat;

	// Token: 0x0400C030 RID: 49200
	[StaticVariableRuleIgnore]
	private static readonly Stat ModifyTagInnerModifyCountStat;

	// Token: 0x0400C031 RID: 49201
	[StaticVariableRuleIgnore]
	private static readonly Stat ModifyTagInnerUpdateUeStat;

	// Token: 0x0400C032 RID: 49202
	[StaticVariableRuleIgnore]
	private static readonly Stat InvokeEventsStat;

	// Token: 0x0400C033 RID: 49203
	[StaticVariableRuleIgnore]
	private static readonly Stat UpdateExactTagStat;
}
