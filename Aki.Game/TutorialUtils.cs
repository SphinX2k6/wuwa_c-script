using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020021A6 RID: 8614
[NullableContext(1)]
[Nullable(0)]
public class TutorialUtils : IStaticVariableResetter
{
	// Token: 0x06015311 RID: 86801 RVA: 0x00629B16 File Offset: 0x00627D16
	static TutorialUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TutorialUtils.CreateStaticDefaultValue), new Action(TutorialUtils.ResetStaticDefaultValue));
	}

	// Token: 0x06015312 RID: 86802 RVA: 0x00629B38 File Offset: 0x00627D38
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

	// Token: 0x17002012 RID: 8210
	// (get) Token: 0x06015313 RID: 86803 RVA: 0x00629B9A File Offset: 0x00627D9A
	public static int? MaxLatestTutorial
	{
		get
		{
			return ConfigCommonParamById.GetIntConfig("MaxLatestTutorial");
		}
	}

	// Token: 0x06015314 RID: 86804 RVA: 0x00629BA8 File Offset: 0x00627DA8
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

	// Token: 0x06015315 RID: 86805 RVA: 0x00629C5F File Offset: 0x00627E5F
	public static void ResetStaticDefaultValue()
	{
		TutorialUtils.TutorialTypeTxtMap = null;
		TutorialUtils.TutorialTypeIconMap = null;
		TutorialUtils.FixedDropDropShowPlanId = 0;
	}

	// Token: 0x06015316 RID: 86806 RVA: 0x00629C74 File Offset: 0x00627E74
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

	// Token: 0x06015317 RID: 86807 RVA: 0x00629CA7 File Offset: 0x00627EA7
	[NullableContext(2)]
	public static string GetTutorialTypeTxt(ETutorialType type)
	{
		if (TutorialUtils.TutorialTypeTxtMap.ContainsKey(type))
		{
			return TutorialUtils.TutorialTypeTxtMap[type];
		}
		return null;
	}

	// Token: 0x0400B3BD RID: 46013
	public static int FixedDropDropShowPlanId;

	// Token: 0x0400B3BE RID: 46014
	private static Dictionary<ETutorialType, string> TutorialTypeIconMap;

	// Token: 0x0400B3BF RID: 46015
	private static Dictionary<ETutorialType, string> TutorialTypeTxtMap;
}
