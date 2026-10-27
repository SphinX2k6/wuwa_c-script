using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200268A RID: 9866
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class QuestTreeConfig : ConfigBase
{
	// Token: 0x060143A0 RID: 82848 RVA: 0x0051D470 File Offset: 0x0051B670
	protected override bool OnClear()
	{
		this.CustomGotoConfigMap = null;
		return true;
	}

	// Token: 0x060143A1 RID: 82849 RVA: 0x0051D47C File Offset: 0x0051B67C
	private Dictionary<int, Dictionary<string, Dictionary<int, QuestTreeCustomJumpConfig>>> GetCustomGotoConfigMap()
	{
		if (this.CustomGotoConfigMap == null)
		{
			Dictionary<int, Dictionary<string, Dictionary<int, QuestTreeCustomJumpConfig>>> dictionary = new Dictionary<int, Dictionary<string, Dictionary<int, QuestTreeCustomJumpConfig>>>();
			foreach (QuestTreeCustomJumpConfig value in this.GetAllCustomGotoConfig())
			{
				Dictionary<string, Dictionary<int, QuestTreeCustomJumpConfig>> dictionary2;
				if (!dictionary.TryGetValue(value.QuestId, out dictionary2))
				{
					dictionary2 = new Dictionary<string, Dictionary<int, QuestTreeCustomJumpConfig>>();
					dictionary[value.QuestId] = dictionary2;
				}
				Dictionary<int, QuestTreeCustomJumpConfig> dictionary3;
				if (!dictionary2.TryGetValue(value.PreConditionType, out dictionary3))
				{
					dictionary3 = new Dictionary<int, QuestTreeCustomJumpConfig>();
					dictionary2[value.PreConditionType] = dictionary3;
				}
				dictionary3[value.ConditionIndex] = value;
			}
			this.CustomGotoConfigMap = dictionary;
		}
		return this.CustomGotoConfigMap;
	}

	// Token: 0x060143A2 RID: 82850 RVA: 0x0051D53C File Offset: 0x0051B73C
	public IReadOnlyList<QuestTreeChapter> GetAllChapters()
	{
		return ConfigQuestTreeChapterAll.GetConfigList(true) ?? new List<QuestTreeChapter>();
	}

	// Token: 0x060143A3 RID: 82851 RVA: 0x0051D54D File Offset: 0x0051B74D
	public QuestTreeChapter? GetChapterById(int chapterId)
	{
		return ConfigQuestTreeChapterById.GetConfig(chapterId, true);
	}

	// Token: 0x060143A4 RID: 82852 RVA: 0x0051D556 File Offset: 0x0051B756
	public IReadOnlyList<QuestTreeNode> GetNodeListByChapterId(int chapterId)
	{
		return ConfigQuestTreeNodeByChapterId.GetConfigList(chapterId, true) ?? new List<QuestTreeNode>();
	}

	// Token: 0x060143A5 RID: 82853 RVA: 0x0051D568 File Offset: 0x0051B768
	public QuestTreeNode? GetNodeById(int nodeId)
	{
		return ConfigQuestTreeNodeById.GetConfig(nodeId, true);
	}

	// Token: 0x060143A6 RID: 82854 RVA: 0x0051D571 File Offset: 0x0051B771
	public QuestTreeNodeUnlock? GetNodeUnlockConditionById(int unlockId)
	{
		return ConfigQuestTreeNodeUnlockById.GetConfig(unlockId, true);
	}

	// Token: 0x060143A7 RID: 82855 RVA: 0x0051D57A File Offset: 0x0051B77A
	public NodeUnlockDefault? GetNodeUnlockConditionDefaultConfigByType(string type)
	{
		return ConfigNodeUnlockDefaultById.GetConfig(type, true);
	}

	// Token: 0x060143A8 RID: 82856 RVA: 0x0051D584 File Offset: 0x0051B784
	public int GetMoonChasingQuestId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonChasingQuestId").GetValueOrDefault();
	}

	// Token: 0x060143A9 RID: 82857 RVA: 0x0051D5A4 File Offset: 0x0051B7A4
	public float GetScrollingScaleDelta()
	{
		return ConfigCommonParamById.GetFloatConfig("QuestTreeScrollingScaleDelta").GetValueOrDefault(0.01f);
	}

	// Token: 0x060143AA RID: 82858 RVA: 0x0051D5C8 File Offset: 0x0051B7C8
	public QuestTreeCustomJumpConfig? GetCustomGotoConfigByQuestIdAndType(int questId, string type, int conditionIndex)
	{
		Dictionary<string, Dictionary<int, QuestTreeCustomJumpConfig>> dictionary;
		Dictionary<int, QuestTreeCustomJumpConfig> dictionary2;
		if (this.GetCustomGotoConfigMap().TryGetValue(questId, out dictionary) && dictionary.TryGetValue(type, out dictionary2))
		{
			QuestTreeCustomJumpConfig value;
			if (dictionary2.TryGetValue(conditionIndex, out value))
			{
				return new QuestTreeCustomJumpConfig?(value);
			}
			QuestTreeCustomJumpConfig value2;
			if (dictionary2.TryGetValue(1, out value2))
			{
				return new QuestTreeCustomJumpConfig?(value2);
			}
		}
		return null;
	}

	// Token: 0x060143AB RID: 82859 RVA: 0x0051D61E File Offset: 0x0051B81E
	public IReadOnlyList<QuestTreeCustomJumpConfig> GetAllCustomGotoConfig()
	{
		return ConfigQuestTreeCustomJumpConfigAll.GetConfigList(true) ?? new List<QuestTreeCustomJumpConfig>();
	}

	// Token: 0x17001A16 RID: 6678
	// (get) Token: 0x060143AC RID: 82860 RVA: 0x0051D62F File Offset: 0x0051B82F
	public static QuestTreeConfig Instance
	{
		get
		{
			return QuestTreeConfig._Instance;
		}
	}

	// Token: 0x060143AD RID: 82861 RVA: 0x0051D636 File Offset: 0x0051B836
	public static QuestTreeConfig GetOrCreateInstance()
	{
		if (QuestTreeConfig._Instance == null)
		{
			QuestTreeConfig.CreateInstance();
		}
		return QuestTreeConfig._Instance;
	}

	// Token: 0x060143AE RID: 82862 RVA: 0x0051D64A File Offset: 0x0051B84A
	public static bool CreateInstance()
	{
		if (QuestTreeConfig._Instance != null)
		{
			return true;
		}
		QuestTreeConfig._Instance = new QuestTreeConfig();
		return true;
	}

	// Token: 0x060143AF RID: 82863 RVA: 0x0051D660 File Offset: 0x0051B860
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060143B0 RID: 82864 RVA: 0x0051D662 File Offset: 0x0051B862
	public static void ResetStaticDefaultValue()
	{
		QuestTreeConfig._Instance = null;
	}

	// Token: 0x060143B1 RID: 82865 RVA: 0x0051D66A File Offset: 0x0051B86A
	static QuestTreeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestTreeConfig.CreateStaticDefaultValue), new Action(QuestTreeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009825 RID: 38949
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<int, Dictionary<string, Dictionary<int, QuestTreeCustomJumpConfig>>> CustomGotoConfigMap;

	// Token: 0x04009826 RID: 38950
	[Nullable(2)]
	private static QuestTreeConfig _Instance;
}
