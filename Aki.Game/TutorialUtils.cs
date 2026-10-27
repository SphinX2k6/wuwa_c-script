using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002C2B RID: 11307
[NullableContext(1)]
[Nullable(0)]
public class TutorialUtils : IStaticVariableResetter
{
	// Token: 0x060178DF RID: 96479 RVA: 0x005FD0F2 File Offset: 0x005FB2F2
	static TutorialUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TutorialUtils.CreateStaticDefaultValue), new Action(TutorialUtils.ResetStaticDefaultValue));
	}

	// Token: 0x060178E0 RID: 96480 RVA: 0x005FD114 File Offset: 0x005FB314
	public static string AddSearchHighlight(string text)
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("TutorialSearchColor");
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
		defaultInterpolatedStringHandler.AppendLiteral("<color=");
		defaultInterpolatedStringHandler.AppendFormatted(stringConfig.ToLower());
		defaultInterpolatedStringHandler.AppendLiteral(">");
		defaultInterpolatedStringHandler.AppendFormatted(text);
		defaultInterpolatedStringHandler.AppendLiteral("</color>");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x17001FBA RID: 8122
	// (get) Token: 0x060178E1 RID: 96481 RVA: 0x005FD176 File Offset: 0x005FB376
	public static int? MaxLatestTutorial
	{
		get
		{
			return ConfigCommonParamById.GetIntConfig("MaxLatestTutorial");
		}
	}

	// Token: 0x060178E2 RID: 96482 RVA: 0x005FD184 File Offset: 0x005FB384
	public static void CreateStaticDefaultValue()
	{
		TutorialUtils.TutorialTypeTxtMap = new Dictionary<ETutorialType, string>
		{
			{
				ETutorialType.All,
				"GuideTutorialType_0"
			},
			{
				ETutorialType.QteReaction,
				"GuideTutorialType_1"
			},
			{
				ETutorialType.Enemy,
				"GuideTutorialType_2"
			},
			{
				ETutorialType.System,
				"GuideTutorialType_3"
			},
			{
				ETutorialType.Adventure,
				"GuideTutorialType_4"
			},
			{
				ETutorialType.BuffOnEnemy,
				"GuideTutorialType_5"
			}
		};
		TutorialUtils.TutorialTypeIconMap = new Dictionary<ETutorialType, string>
		{
			{
				ETutorialType.All,
				"SP_TutorialIconAll"
			},
			{
				ETutorialType.QteReaction,
				"SP_TutorialIconQteReaction"
			},
			{
				ETutorialType.Enemy,
				"SP_TutorialIconEnemy"
			},
			{
				ETutorialType.System,
				"SP_TutorialIconSystem"
			},
			{
				ETutorialType.Adventure,
				"SP_TutorialIconAdventure"
			},
			{
				ETutorialType.BuffOnEnemy,
				"SP_TutorialIconBuff"
			}
		};
		TutorialUtils.FixedDropDropShowPlanId = 1;
	}

	// Token: 0x060178E3 RID: 96483 RVA: 0x005FD23B File Offset: 0x005FB43B
	public static void ResetStaticDefaultValue()
	{
		TutorialUtils.TutorialTypeTxtMap = null;
		TutorialUtils.TutorialTypeIconMap = null;
		TutorialUtils.FixedDropDropShowPlanId = 0;
	}

	// Token: 0x060178E4 RID: 96484 RVA: 0x005FD250 File Offset: 0x005FB450
	[NullableContext(2)]
	public static string GetTutorialTypeIconPath(ETutorialType type)
	{
		if (TutorialUtils.TutorialTypeIconMap.ContainsKey(type))
		{
			string resourceId = TutorialUtils.TutorialTypeIconMap[type];
			return UiResourceConfig.Instance.GetResourcePath(resourceId);
		}
		return null;
	}

	// Token: 0x060178E5 RID: 96485 RVA: 0x005FD283 File Offset: 0x005FB483
	[NullableContext(2)]
	public static string GetTutorialTypeTxt(ETutorialType type)
	{
		if (TutorialUtils.TutorialTypeTxtMap.ContainsKey(type))
		{
			return TutorialUtils.TutorialTypeTxtMap[type];
		}
		return null;
	}

	// Token: 0x0400AFB8 RID: 44984
	public static int FixedDropDropShowPlanId;

	// Token: 0x0400AFB9 RID: 44985
	private static Dictionary<ETutorialType, string> TutorialTypeIconMap;

	// Token: 0x0400AFBA RID: 44986
	private static Dictionary<ETutorialType, string> TutorialTypeTxtMap;
}
