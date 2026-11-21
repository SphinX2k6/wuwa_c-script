using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000F1 RID: 241
[NullableContext(1)]
[Nullable(0)]
public class GameplayTagUtils : IStaticVariableResetter
{
	// Token: 0x06000794 RID: 1940 RVA: 0x000285E9 File Offset: 0x000267E9
	static GameplayTagUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameplayTagUtils.CreateStaticDefaultValue), new Action(GameplayTagUtils.ResetStaticDefaultValue));
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00028624 File Offset: 0x00026824
	public static int GetTagIdByName(string tagName)
	{
		int result;
		if (!GameplayTagDefine.EGameplayTagId.TryGetValue(tagName, out result))
		{
			result = UGASBPLibrary.FnvHash(tagName);
		}
		return result;
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00028648 File Offset: 0x00026848
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

	// Token: 0x06000797 RID: 1943 RVA: 0x000286B3 File Offset: 0x000268B3
	public static FGameplayTag? GetGameplayTagByName(string tagName)
	{
		return GameplayTagUtils.GetGameplayTagById(GameplayTagUtils.GetTagIdByName(tagName));
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x000286C0 File Offset: 0x000268C0
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

	// Token: 0x06000799 RID: 1945 RVA: 0x0002874E File Offset: 0x0002694E
	public static int GetParentTag(int tag)
	{
		return GameplayTagDefine.ParentTagIdMap.GetValueOrDefault(tag, 0);
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x0002875C File Offset: 0x0002695C
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

	// Token: 0x0600079B RID: 1947 RVA: 0x00028790 File Offset: 0x00026990
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

	// Token: 0x0600079C RID: 1948 RVA: 0x000287E8 File Offset: 0x000269E8
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

	// Token: 0x0600079D RID: 1949 RVA: 0x00028838 File Offset: 0x00026A38
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

	// Token: 0x0600079E RID: 1950 RVA: 0x00028890 File Offset: 0x00026A90
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

	// Token: 0x0600079F RID: 1951 RVA: 0x000288E8 File Offset: 0x00026AE8
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

	// Token: 0x060007A0 RID: 1952 RVA: 0x0002893A File Offset: 0x00026B3A
	public static bool IsValidTag(FGameplayTag? gameplayTag)
	{
		return gameplayTag != null && gameplayTag.Value.TagName != FName.NAME_None;
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x0002895D File Offset: 0x00026B5D
	public static void CreateStaticDefaultValue()
	{
		GameplayTagUtils.ErrorIdSet = new HashSet<int>();
		GameplayTagUtils.GameplayTagMap = new Dictionary<int, FGameplayTag?>();
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00028973 File Offset: 0x00026B73
	public static void ResetStaticDefaultValue()
	{
		GameplayTagUtils.ErrorIdSet = null;
		GameplayTagUtils.GameplayTagMap = null;
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00028984 File Offset: 0x00026B84
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

	// Token: 0x060007A4 RID: 1956 RVA: 0x000289C4 File Offset: 0x00026BC4
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

	// Token: 0x040005D7 RID: 1495
	private static HashSet<int> ErrorIdSet;

	// Token: 0x040005D8 RID: 1496
	[StaticVariableRuleIgnore]
	private static readonly Stat Stat = Stat.Create("GameplayTagUtils.FnvHash", "", "");

	// Token: 0x040005D9 RID: 1497
	private static Dictionary<int, FGameplayTag?> GameplayTagMap;
}
