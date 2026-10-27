using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

// Token: 0x02001DB9 RID: 7609
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GuideConfig : ConfigBase
{
	// Token: 0x0600E6DD RID: 59101 RVA: 0x003662C7 File Offset: 0x003644C7
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600E6DE RID: 59102 RVA: 0x003662CA File Offset: 0x003644CA
	[NullableContext(2)]
	public IReadOnlyList<GuideTutorial> GetAllTutorial()
	{
		return ConfigGuideTutorialAll.GetConfigList(true);
	}

	// Token: 0x0600E6DF RID: 59103 RVA: 0x003662D4 File Offset: 0x003644D4
	public GuideStep? GetStep(int stepId)
	{
		return new GuideStep?(ConfigGuideStepById.GetConfig(stepId, true).Value);
	}

	// Token: 0x0600E6E0 RID: 59104 RVA: 0x003662F8 File Offset: 0x003644F8
	public GuideTutorialPage? GetGuideTutorialPage(int pageId)
	{
		return new GuideTutorialPage?(ConfigGuideTutorialPageById.GetConfig(pageId, true).Value);
	}

	// Token: 0x0600E6E1 RID: 59105 RVA: 0x0036631C File Offset: 0x0036451C
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

	// Token: 0x0600E6E2 RID: 59106 RVA: 0x00366378 File Offset: 0x00364578
	public GuideTutorial? GetGuideTutorial(int stepId)
	{
		return new GuideTutorial?(ConfigGuideTutorialById.GetConfig(stepId, true).Value);
	}

	// Token: 0x0600E6E3 RID: 59107 RVA: 0x0036639C File Offset: 0x0036459C
	public GuideFocusNew? GetGuideFocus(int stepId)
	{
		return new GuideFocusNew?(ConfigGuideFocusNewByGuideId.GetConfig(stepId, true).Value);
	}

	// Token: 0x0600E6E4 RID: 59108 RVA: 0x003663C0 File Offset: 0x003645C0
	public GuideTips? GetGuideTips(int stepId)
	{
		return new GuideTips?(ConfigGuideTipsByGuideId.GetConfig(stepId, true).Value);
	}

	// Token: 0x0600E6E5 RID: 59109 RVA: 0x003663E1 File Offset: 0x003645E1
	public string GetGuideText(string textId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(textId, null) ?? "";
	}

	// Token: 0x0600E6E6 RID: 59110 RVA: 0x003663F4 File Offset: 0x003645F4
	public GuideDungeonSetDefine? GetGuideDungeonSet(string setId)
	{
		return new GuideDungeonSetDefine?(ConfigGuideDungeonSetDefineByStrId.GetConfig(setId, true).Value);
	}

	// Token: 0x0600E6E7 RID: 59111 RVA: 0x00366415 File Offset: 0x00364615
	[NullableContext(2)]
	public IReadOnlyList<int> GetGuideTopMiddleOffset()
	{
		return ConfigCommonParamById.GetIntArrayConfig("guide_top_middle_offset");
	}

	// Token: 0x0600E6E8 RID: 59112 RVA: 0x00366421 File Offset: 0x00364621
	[NullableContext(2)]
	public IReadOnlyList<GuideGroup> GetAllGroup()
	{
		return ConfigGuideGroupAll.GetConfigList(true);
	}

	// Token: 0x0600E6E9 RID: 59113 RVA: 0x00366429 File Offset: 0x00364629
	public GuideGroup? GetGroup(int groupId)
	{
		return ConfigGuideGroupById.GetConfig(groupId, true);
	}

	// Token: 0x0600E6EA RID: 59114 RVA: 0x00366434 File Offset: 0x00364634
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

	// Token: 0x0600E6EB RID: 59115 RVA: 0x003664C4 File Offset: 0x003646C4
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

	// Token: 0x0600E6EC RID: 59116 RVA: 0x00366518 File Offset: 0x00364718
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

	// Token: 0x0600E6ED RID: 59117 RVA: 0x00366584 File Offset: 0x00364784
	public FVectorDouble GetGuideFocusCenterTextPos()
	{
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("GuideFocusTextOffsetY").GetValueOrDefault();
		return new FVectorDouble(0.0, 0.0, (double)valueOrDefault);
	}

	// Token: 0x1700126F RID: 4719
	// (get) Token: 0x0600E6EE RID: 59118 RVA: 0x003665BD File Offset: 0x003647BD
	public static GuideConfig Instance
	{
		get
		{
			return GuideConfig._Instance;
		}
	}

	// Token: 0x0600E6EF RID: 59119 RVA: 0x003665C4 File Offset: 0x003647C4
	public static GuideConfig GetOrCreateInstance()
	{
		if (GuideConfig._Instance == null)
		{
			GuideConfig.CreateInstance();
		}
		return GuideConfig._Instance;
	}

	// Token: 0x0600E6F0 RID: 59120 RVA: 0x003665D8 File Offset: 0x003647D8
	public static bool CreateInstance()
	{
		if (GuideConfig._Instance != null)
		{
			return true;
		}
		GuideConfig._Instance = new GuideConfig();
		return true;
	}

	// Token: 0x0600E6F1 RID: 59121 RVA: 0x003665EE File Offset: 0x003647EE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E6F2 RID: 59122 RVA: 0x003665F0 File Offset: 0x003647F0
	public static void ResetStaticDefaultValue()
	{
		GuideConfig._Instance = null;
	}

	// Token: 0x0600E6F3 RID: 59123 RVA: 0x003665F8 File Offset: 0x003647F8
	static GuideConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideConfig.CreateStaticDefaultValue), new Action(GuideConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006AE2 RID: 27362
	public bool GmMuteTutorial;

	// Token: 0x04006AE3 RID: 27363
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

	// Token: 0x04006AE4 RID: 27364
	public readonly string TabTag = "tab";

	// Token: 0x04006AE5 RID: 27365
	public readonly string SlotTag = "slot";

	// Token: 0x04006AE6 RID: 27366
	[Nullable(2)]
	private static GuideConfig _Instance;
}
