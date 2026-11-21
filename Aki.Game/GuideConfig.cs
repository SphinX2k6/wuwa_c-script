using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

// Token: 0x0200127B RID: 4731
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GuideConfig : ConfigBase
{
	// Token: 0x0600BAFB RID: 47867 RVA: 0x00371F27 File Offset: 0x00370127
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600BAFC RID: 47868 RVA: 0x00371F2A File Offset: 0x0037012A
	[NullableContext(2)]
	public IReadOnlyList<GuideTutorial> GetAllTutorial()
	{
		return ConfigGuideTutorialAll.GetConfigList(true);
	}

	// Token: 0x0600BAFD RID: 47869 RVA: 0x00371F34 File Offset: 0x00370134
	public GuideStep? GetStep(int stepId)
	{
		return new GuideStep?(ConfigGuideStepById.GetConfig(stepId, true).Value);
	}

	// Token: 0x0600BAFE RID: 47870 RVA: 0x00371F58 File Offset: 0x00370158
	public GuideTutorialPage? GetGuideTutorialPage(int pageId)
	{
		return new GuideTutorialPage?(ConfigGuideTutorialPageById.GetConfig(pageId, true).Value);
	}

	// Token: 0x0600BAFF RID: 47871 RVA: 0x00371F7C File Offset: 0x0037017C
	public int[] GetGuideTutorialPageIds(int stepId)
	{
		GuideTutorial value = this.GetGuideTutorial(stepId).Value;
		int pageReplaceConditionGroupId = value.PageReplaceConditionGroupId;
		if (pageReplaceConditionGroupId <= 0)
		{
			return value.PageId();
		}
		if (!LevelGeneralController.Instance.CheckCondition(pageReplaceConditionGroupId.ToString(), null, true, Array.Empty<object>()))
		{
			return value.PageId();
		}
		return value.ReplacePageId();
	}

	// Token: 0x0600BB00 RID: 47872 RVA: 0x00371FD8 File Offset: 0x003701D8
	public GuideTutorial? GetGuideTutorial(int stepId)
	{
		return new GuideTutorial?(ConfigGuideTutorialById.GetConfig(stepId, true).Value);
	}

	// Token: 0x0600BB01 RID: 47873 RVA: 0x00371FFC File Offset: 0x003701FC
	public GuideFocusNew? GetGuideFocus(int stepId)
	{
		return new GuideFocusNew?(ConfigGuideFocusNewByGuideId.GetConfig(stepId, true).Value);
	}

	// Token: 0x0600BB02 RID: 47874 RVA: 0x00372020 File Offset: 0x00370220
	public GuideTips? GetGuideTips(int stepId)
	{
		return new GuideTips?(ConfigGuideTipsByGuideId.GetConfig(stepId, true).Value);
	}

	// Token: 0x0600BB03 RID: 47875 RVA: 0x00372041 File Offset: 0x00370241
	public string GetGuideText(string textId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(textId, null) ?? "";
	}

	// Token: 0x0600BB04 RID: 47876 RVA: 0x00372054 File Offset: 0x00370254
	public GuideDungeonSetDefine? GetGuideDungeonSet(string setId)
	{
		return new GuideDungeonSetDefine?(ConfigGuideDungeonSetDefineByStrId.GetConfig(setId, true).Value);
	}

	// Token: 0x0600BB05 RID: 47877 RVA: 0x00372075 File Offset: 0x00370275
	[NullableContext(2)]
	public IReadOnlyList<int> GetGuideTopMiddleOffset()
	{
		return ConfigCommonParamById.GetIntArrayConfig("guide_top_middle_offset");
	}

	// Token: 0x0600BB06 RID: 47878 RVA: 0x00372081 File Offset: 0x00370281
	[NullableContext(2)]
	public IReadOnlyList<GuideGroup> GetAllGroup()
	{
		return ConfigGuideGroupAll.GetConfigList(true);
	}

	// Token: 0x0600BB07 RID: 47879 RVA: 0x00372089 File Offset: 0x00370289
	public GuideGroup? GetGroup(int groupId)
	{
		return ConfigGuideGroupById.GetConfig(groupId, true);
	}

	// Token: 0x0600BB08 RID: 47880 RVA: 0x00372094 File Offset: 0x00370294
	public int[] GetOrderedStepIdsOfGroup(int groupId, EInputControllerMainType controllerType)
	{
		List<int> list = new List<int>();
		GuideGroup? group = this.GetGroup(groupId);
		int index;
		if (group != null && this.inputControllerType2IndexInConfig.TryGetValue(controllerType, out index))
		{
			foreach (int num in group.Value.Step())
			{
				if (this.GetStep(num).Value.Controller[index] == 'T')
				{
					list.Add(num);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600BB09 RID: 47881 RVA: 0x00372124 File Offset: 0x00370324
	public HashSet<int> GetLimitRepeatStepSetOfGroup(int groupId)
	{
		HashSet<int> hashSet = new HashSet<int>();
		GuideGroup? group = this.GetGroup(groupId);
		if (group != null)
		{
			foreach (int item in group.Value.LimitRepeat())
			{
				hashSet.Add(item);
			}
		}
		return hashSet;
	}

	// Token: 0x0600BB0A RID: 47882 RVA: 0x00372178 File Offset: 0x00370378
	[NullableContext(2)]
	public HashSet<int> GetBreakExcludeStepIdSetOfGroup(int groupId)
	{
		GuideGroup? group = this.GetGroup(groupId);
		if (group == null || group.Value.PriorityBreakExcludeLength == 0)
		{
			return null;
		}
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 0; i < group.Value.PriorityBreakExcludeLength; i++)
		{
			hashSet.Add(group.Value.PriorityBreakExclude(i));
		}
		return hashSet;
	}

	// Token: 0x0600BB0B RID: 47883 RVA: 0x003721E4 File Offset: 0x003703E4
	public FVectorDouble GetGuideFocusCenterTextPos()
	{
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("GuideFocusTextOffsetY").GetValueOrDefault();
		return new FVectorDouble(0.0, 0.0, (double)valueOrDefault);
	}

	// Token: 0x17001299 RID: 4761
	// (get) Token: 0x0600BB0C RID: 47884 RVA: 0x0037221D File Offset: 0x0037041D
	public static GuideConfig Instance
	{
		get
		{
			return GuideConfig._Instance;
		}
	}

	// Token: 0x0600BB0D RID: 47885 RVA: 0x00372224 File Offset: 0x00370424
	public static GuideConfig GetOrCreateInstance()
	{
		if (GuideConfig._Instance == null)
		{
			GuideConfig.CreateInstance();
		}
		return GuideConfig._Instance;
	}

	// Token: 0x0600BB0E RID: 47886 RVA: 0x00372238 File Offset: 0x00370438
	public static bool CreateInstance()
	{
		if (GuideConfig._Instance != null)
		{
			return true;
		}
		GuideConfig._Instance = new GuideConfig();
		return true;
	}

	// Token: 0x0600BB0F RID: 47887 RVA: 0x0037224E File Offset: 0x0037044E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BB10 RID: 47888 RVA: 0x00372250 File Offset: 0x00370450
	public static void ResetStaticDefaultValue()
	{
		GuideConfig._Instance = null;
	}

	// Token: 0x0600BB11 RID: 47889 RVA: 0x00372258 File Offset: 0x00370458
	static GuideConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideConfig.CreateStaticDefaultValue), new Action(GuideConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006BC3 RID: 27587
	public bool GmMuteTutorial;

	// Token: 0x04006BC4 RID: 27588
	public readonly Dictionary<EInputControllerMainType, int> inputControllerType2IndexInConfig = new Dictionary<EInputControllerMainType, int>
	{
		{
			EInputControllerMainType.Keyboard,
			0
		},
		{
			EInputControllerMainType.Gamepad,
			1
		},
		{
			EInputControllerMainType.Touch,
			2
		}
	};

	// Token: 0x04006BC5 RID: 27589
	public readonly string TabTag = "tab";

	// Token: 0x04006BC6 RID: 27590
	public readonly string SlotTag = "slot";

	// Token: 0x04006BC7 RID: 27591
	[Nullable(2)]
	private static GuideConfig _Instance;
}
