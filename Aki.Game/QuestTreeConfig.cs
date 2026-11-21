using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001B75 RID: 7029
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class QuestTreeConfig : ConfigBase
{
	// Token: 0x06011882 RID: 71810 RVA: 0x0052C1A8 File Offset: 0x0052A3A8
	protected override bool OnClear()
	{
		this.CustomGotoConfigMap = null;
		return true;
	}

	// Token: 0x06011883 RID: 71811 RVA: 0x0052C1B4 File Offset: 0x0052A3B4
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

	// Token: 0x06011884 RID: 71812 RVA: 0x0052C274 File Offset: 0x0052A474
	public IReadOnlyList<QuestTreeChapter> GetAllChapters()
	{
		return ConfigQuestTreeChapterAll.GetConfigList(true) ?? new List<QuestTreeChapter>();
	}

	// Token: 0x06011885 RID: 71813 RVA: 0x0052C285 File Offset: 0x0052A485
	public QuestTreeChapter? GetChapterById(int chapterId)
	{
		return ConfigQuestTreeChapterById.GetConfig(chapterId, true);
	}

	// Token: 0x06011886 RID: 71814 RVA: 0x0052C28E File Offset: 0x0052A48E
	public IReadOnlyList<QuestTreeNode> GetNodeListByChapterId(int chapterId)
	{
		return ConfigQuestTreeNodeByChapterId.GetConfigList(chapterId, true) ?? new List<QuestTreeNode>();
	}

	// Token: 0x06011887 RID: 71815 RVA: 0x0052C2A0 File Offset: 0x0052A4A0
	public QuestTreeNode? GetNodeById(int nodeId)
	{
		return ConfigQuestTreeNodeById.GetConfig(nodeId, true);
	}

	// Token: 0x06011888 RID: 71816 RVA: 0x0052C2A9 File Offset: 0x0052A4A9
	public QuestTreeNodeUnlock? GetNodeUnlockConditionById(int unlockId)
	{
		return ConfigQuestTreeNodeUnlockById.GetConfig(unlockId, true);
	}

	// Token: 0x06011889 RID: 71817 RVA: 0x0052C2B2 File Offset: 0x0052A4B2
	public NodeUnlockDefault? GetNodeUnlockConditionDefaultConfigByType(string type)
	{
		return ConfigNodeUnlockDefaultById.GetConfig(type, true);
	}

	// Token: 0x0601188A RID: 71818 RVA: 0x0052C2BC File Offset: 0x0052A4BC
	public int GetMoonChasingQuestId()
	{
		return ConfigCommonParamById.GetIntConfig("MoonChasingQuestId").GetValueOrDefault();
	}

	// Token: 0x0601188B RID: 71819 RVA: 0x0052C2DC File Offset: 0x0052A4DC
	public float GetScrollingScaleDelta()
	{
		return ConfigCommonParamById.GetFloatConfig("QuestTreeScrollingScaleDelta").GetValueOrDefault(0.01f);
	}

	// Token: 0x0601188C RID: 71820 RVA: 0x0052C300 File Offset: 0x0052A500
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

	// Token: 0x0601188D RID: 71821 RVA: 0x0052C356 File Offset: 0x0052A556
	public IReadOnlyList<QuestTreeCustomJumpConfig> GetAllCustomGotoConfig()
	{
		return ConfigQuestTreeCustomJumpConfigAll.GetConfigList(true) ?? new List<QuestTreeCustomJumpConfig>();
	}

	// Token: 0x17001A4E RID: 6734
	// (get) Token: 0x0601188E RID: 71822 RVA: 0x0052C367 File Offset: 0x0052A567
	public static QuestTreeConfig Instance
	{
		get
		{
			return QuestTreeConfig._Instance;
		}
	}

	// Token: 0x0601188F RID: 71823 RVA: 0x0052C36E File Offset: 0x0052A56E
	public static QuestTreeConfig GetOrCreateInstance()
	{
		if (QuestTreeConfig._Instance == null)
		{
			QuestTreeConfig.CreateInstance();
		}
		return QuestTreeConfig._Instance;
	}

	// Token: 0x06011890 RID: 71824 RVA: 0x0052C382 File Offset: 0x0052A582
	public static bool CreateInstance()
	{
		if (QuestTreeConfig._Instance != null)
		{
			return true;
		}
		QuestTreeConfig._Instance = new QuestTreeConfig();
		return true;
	}

	// Token: 0x06011891 RID: 71825 RVA: 0x0052C398 File Offset: 0x0052A598
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011892 RID: 71826 RVA: 0x0052C39A File Offset: 0x0052A59A
	public static void ResetStaticDefaultValue()
	{
		QuestTreeConfig._Instance = null;
	}

	// Token: 0x06011893 RID: 71827 RVA: 0x0052C3A2 File Offset: 0x0052A5A2
	static QuestTreeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestTreeConfig.CreateStaticDefaultValue), new Action(QuestTreeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400997D RID: 39293
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<int, Dictionary<string, Dictionary<int, QuestTreeCustomJumpConfig>>> CustomGotoConfigMap;

	// Token: 0x0400997E RID: 39294
	[Nullable(2)]
	private static QuestTreeConfig _Instance;
}
