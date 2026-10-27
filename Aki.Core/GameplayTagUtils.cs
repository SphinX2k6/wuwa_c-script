using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000F1 RID: 241
[NullableContext(1)]
[Nullable(0)]
public class GameplayTagUtils : IStaticVariableResetter
{
	// Token: 0x0600075A RID: 1882 RVA: 0x000282B5 File Offset: 0x000264B5
	static GameplayTagUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameplayTagUtils.CreateStaticDefaultValue), new Action(GameplayTagUtils.ResetStaticDefaultValue));
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x000282F0 File Offset: 0x000264F0
	public static int GetTagIdByName(string tagName)
	{
		int result;
		if (!GameplayTagDefine.EGameplayTagId.TryGetValue(tagName, out result))
		{
			result = UGASBPLibrary.FnvHash(tagName);
		}
		return result;
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00028314 File Offset: 0x00026514
	[NullableContext(2)]
	public static string GetNameByTagId(int tagId)
	{
		FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(tagId);
		if (gameplayTagById == null)
		{
			return null;
		}
		string text = gameplayTagById.Value.OriginalTagName().ToString();
		if (!string.IsNullOrEmpty(text) && text != "None")
		{
			return text;
		}
		return gameplayTagById.Value.TagName.ToString();
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x0002837F File Offset: 0x0002657F
	public static FGameplayTag? GetGameplayTagByName(string tagName)
	{
		return GameplayTagUtils.GetGameplayTagById(GameplayTagUtils.GetTagIdByName(tagName));
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x0002838C File Offset: 0x0002658C
	public static FGameplayTag? GetGameplayTagById(int tagId)
	{
		FGameplayTag? fgameplayTag;
		if (!GameplayTagUtils.GameplayTagMap.TryGetValue(tagId, out fgameplayTag))
		{
			fgameplayTag = new FGameplayTag?(UGASBPLibrary.GetGameplayTagFromTagHash(tagId));
			GameplayTagUtils.GameplayTagMap[tagId] = fgameplayTag;
		}
		if (fgameplayTag == null)
		{
			if (!GameplayTagUtils.ErrorIdSet.Contains(tagId))
			{
				GameplayTagUtils.ErrorIdSet.Add(tagId);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Game;
				ELogAuthor author = ELogAuthor.WLJ;
				string message = "TagId对应的GameplayTag不存在，请检查GameplayTag设置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TagId", tagId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return null;
		}
		return fgameplayTag;
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x0002841A File Offset: 0x0002661A
	public static int GetParentTag(int tag)
	{
		return GameplayTagDefine.ParentTagIdMap.GetValueOrDefault(tag, 0);
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00028428 File Offset: 0x00026628
	public static bool IsChildTag(int tagA, int tagB)
	{
		if (tagA == tagB)
		{
			return true;
		}
		IReadOnlyDictionary<int, int> parentTagIdMap = GameplayTagDefine.ParentTagIdMap;
		int key = tagA;
		int num;
		while (parentTagIdMap.TryGetValue(key, out num))
		{
			if (num == tagB)
			{
				return true;
			}
			key = num;
		}
		return false;
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x0002845C File Offset: 0x0002665C
	[NullableContext(2)]
	public static bool Contains(IEnumerable<int> tagContainer, int tag)
	{
		if (tagContainer == null)
		{
			return false;
		}
		foreach (int tagB in tagContainer)
		{
			if (GameplayTagUtils.IsChildTag(tag, tagB))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x000284B4 File Offset: 0x000266B4
	[NullableContext(2)]
	public static bool ContainsExact(IEnumerable<int> tagContainer, int tag)
	{
		if (tagContainer == null)
		{
			return false;
		}
		using (IEnumerator<int> enumerator = tagContainer.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == tag)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00028504 File Offset: 0x00026704
	[NullableContext(2)]
	public static bool HasAll(IEnumerable<int> tagContainerA, IEnumerable<int> tagContainerB)
	{
		if (tagContainerB == null)
		{
			return true;
		}
		foreach (int tag in tagContainerB)
		{
			if (!GameplayTagUtils.Contains(tagContainerA, tag))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x0002855C File Offset: 0x0002675C
	[NullableContext(2)]
	public static bool HasAny(IEnumerable<int> tagContainerA, IEnumerable<int> tagContainerB)
	{
		if (tagContainerB == null)
		{
			return false;
		}
		foreach (int tag in tagContainerB)
		{
			if (GameplayTagUtils.Contains(tagContainerA, tag))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x000285B4 File Offset: 0x000267B4
	public static List<int> ConvertFromUeContainer([Nullable(2)] FGameplayTagContainer ueContainer)
	{
		if (ueContainer == null)
		{
			return new List<int>();
		}
		List<int> list = new List<int>();
		int num = ueContainer.GameplayTags.Num();
		for (int i = 0; i < num; i++)
		{
			list.Add(ueContainer.GameplayTags.Get(i).TagId());
		}
		return list;
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00028606 File Offset: 0x00026806
	public static bool IsValidTag(FGameplayTag? gameplayTag)
	{
		return gameplayTag != null && gameplayTag.Value.TagName != FName.NAME_None;
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00028629 File Offset: 0x00026829
	public static void CreateStaticDefaultValue()
	{
		GameplayTagUtils.ErrorIdSet = new HashSet<int>();
		GameplayTagUtils.GameplayTagMap = new Dictionary<int, FGameplayTag?>();
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x0002863F File Offset: 0x0002683F
	public static void ResetStaticDefaultValue()
	{
		GameplayTagUtils.ErrorIdSet = null;
		GameplayTagUtils.GameplayTagMap = null;
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00028650 File Offset: 0x00026850
	public static IList<int> GameplayTagsToTagIds(TArray<FGameplayTag> tags)
	{
		List<int> list = new List<int>();
		if (tags.Num() > 0)
		{
			for (int i = 0; i < tags.Num(); i++)
			{
				list.Add(tags.Get(i).TagId());
			}
		}
		return list;
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00028690 File Offset: 0x00026890
	public static IList<string> GameplayTagsToTagNames(TArray<FGameplayTag> tags)
	{
		List<string> list = new List<string>();
		if (tags.Num() > 0)
		{
			for (int i = 0; i < tags.Num(); i++)
			{
				list.Add(tags.Get(i).TagName.ToString());
			}
		}
		return list;
	}

	// Token: 0x040005CC RID: 1484
	private static HashSet<int> ErrorIdSet;

	// Token: 0x040005CD RID: 1485
	[StaticVariableRuleIgnore]
	private static readonly Stat Stat = Stat.Create("GameplayTagUtils.FnvHash", "", "");

	// Token: 0x040005CE RID: 1486
	private static Dictionary<int, FGameplayTag?> GameplayTagMap;
}
