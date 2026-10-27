using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;

// Token: 0x02002925 RID: 10533
public class RouletteFunctionOpenController : IStaticVariableResetter
{
	// Token: 0x06015BDB RID: 89051 RVA: 0x0057BF28 File Offset: 0x0057A128
	static RouletteFunctionOpenController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteFunctionOpenController.CreateStaticDefaultValue), new Action(RouletteFunctionOpenController.ResetStaticDefaultValue));
	}

	// Token: 0x06015BDC RID: 89052 RVA: 0x0057BF48 File Offset: 0x0057A148
	public static void OpenRelateView(ERouletteFuncId rouletteFuncId)
	{
		Action action;
		if (RouletteFunctionOpenController.RouletteFunctionOpenMap.TryGetValue(rouletteFuncId, out action))
		{
			action();
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Functional;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[FunctionRoulette] 查找不到对应FuncId打开界面的实现方式,请在RouletteFunctionOpenController中注册";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("功能ID", rouletteFuncId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06015BDD RID: 89053 RVA: 0x0057BF97 File Offset: 0x0057A197
	private static void OpenWeeklyRogueInfoView()
	{
		if (WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
		{
			UiManager.Instance.OpenView(EUiViewName.WeeklyRogueInfo, null, null);
		}
	}

	// Token: 0x06015BDE RID: 89054 RVA: 0x0057BFB6 File Offset: 0x0057A1B6
	private static void OpenRogueResSummaryView()
	{
		if (MapRogueController.Instance.CheckInMapRogueInstance())
		{
			UiManager.Instance.OpenView(EUiViewName.RogueBattleSummary, null, null);
		}
	}

	// Token: 0x06015BDF RID: 89055 RVA: 0x0057BFD5 File Offset: 0x0057A1D5
	private static void OpenSurvivorsInfoView()
	{
		if (SurvivorsRogueController.Instance.CheckInSurvivorsRogueInstance())
		{
			UiManager.Instance.OpenView(EUiViewName.SurvivorsTabMainView, null, null);
		}
	}

	// Token: 0x06015BE0 RID: 89056 RVA: 0x0057BFF4 File Offset: 0x0057A1F4
	private static void OpenHonamiStoryQuestView()
	{
		if (HonamiStoryUtil.CheckInHonamiStoryAreaDungeon())
		{
			UiManager.Instance.OpenView(EUiViewName.HonamiStoryQuestView, null, null);
		}
	}

	// Token: 0x06015BE1 RID: 89057 RVA: 0x0057C00E File Offset: 0x0057A20E
	private static void OpenSpringManorAtmosphereView()
	{
		if (!SpringManorModel.Instance.CheckInInstance())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.SpringManorAtmosphereLevelView, null, null);
	}

	// Token: 0x06015BE2 RID: 89058 RVA: 0x0057C02E File Offset: 0x0057A22E
	private static void OpenSpringManorQuestView()
	{
		if (!SpringManorModel.Instance.CheckInInstance())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.SpringManorQuestView, null, null);
	}

	// Token: 0x06015BE3 RID: 89059 RVA: 0x0057C04E File Offset: 0x0057A24E
	private static void OpenSpringManorRoleSwitchView()
	{
		if (!SpringManorModel.Instance.CheckInInstance())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.SpringManorRoleSwitchView, null, null);
	}

	// Token: 0x06015BE4 RID: 89060 RVA: 0x0057C06E File Offset: 0x0057A26E
	private static void OpenRoguelikeInfoView()
	{
		if (!RoguelikeModel.Instance.CheckInRoguelike())
		{
			return;
		}
		RoguelikeController.Instance.OpenRogueInfoView(null, true, true, ERogueInfoViewPage.Overview);
	}

	// Token: 0x06015BE5 RID: 89061 RVA: 0x0057C08C File Offset: 0x0057A28C
	public static void CreateStaticDefaultValue()
	{
		Dictionary<ERouletteFuncId, Action> dictionary = new Dictionary<ERouletteFuncId, Action>();
		ERouletteFuncId key = ERouletteFuncId.WeeklyRogueInfo;
		Action value;
		if ((value = RouletteFunctionOpenController.<>O.<0>__OpenWeeklyRogueInfoView) == null)
		{
			value = (RouletteFunctionOpenController.<>O.<0>__OpenWeeklyRogueInfoView = new Action(RouletteFunctionOpenController.OpenWeeklyRogueInfoView));
		}
		dictionary.Add(key, value);
		ERouletteFuncId key2 = ERouletteFuncId.RogueResBattleSummaryInfo;
		Action value2;
		if ((value2 = RouletteFunctionOpenController.<>O.<1>__OpenRogueResSummaryView) == null)
		{
			value2 = (RouletteFunctionOpenController.<>O.<1>__OpenRogueResSummaryView = new Action(RouletteFunctionOpenController.OpenRogueResSummaryView));
		}
		dictionary.Add(key2, value2);
		ERouletteFuncId key3 = ERouletteFuncId.SurvivorsInfo;
		Action value3;
		if ((value3 = RouletteFunctionOpenController.<>O.<2>__OpenSurvivorsInfoView) == null)
		{
			value3 = (RouletteFunctionOpenController.<>O.<2>__OpenSurvivorsInfoView = new Action(RouletteFunctionOpenController.OpenSurvivorsInfoView));
		}
		dictionary.Add(key3, value3);
		ERouletteFuncId key4 = ERouletteFuncId.HonamiStoryQuest;
		Action value4;
		if ((value4 = RouletteFunctionOpenController.<>O.<3>__OpenHonamiStoryQuestView) == null)
		{
			value4 = (RouletteFunctionOpenController.<>O.<3>__OpenHonamiStoryQuestView = new Action(RouletteFunctionOpenController.OpenHonamiStoryQuestView));
		}
		dictionary.Add(key4, value4);
		ERouletteFuncId key5 = ERouletteFuncId.SpringManorAtmosphere;
		Action value5;
		if ((value5 = RouletteFunctionOpenController.<>O.<4>__OpenSpringManorAtmosphereView) == null)
		{
			value5 = (RouletteFunctionOpenController.<>O.<4>__OpenSpringManorAtmosphereView = new Action(RouletteFunctionOpenController.OpenSpringManorAtmosphereView));
		}
		dictionary.Add(key5, value5);
		ERouletteFuncId key6 = ERouletteFuncId.SpringManorQuest;
		Action value6;
		if ((value6 = RouletteFunctionOpenController.<>O.<5>__OpenSpringManorQuestView) == null)
		{
			value6 = (RouletteFunctionOpenController.<>O.<5>__OpenSpringManorQuestView = new Action(RouletteFunctionOpenController.OpenSpringManorQuestView));
		}
		dictionary.Add(key6, value6);
		ERouletteFuncId key7 = ERouletteFuncId.SpringManorRoleSwitch;
		Action value7;
		if ((value7 = RouletteFunctionOpenController.<>O.<6>__OpenSpringManorRoleSwitchView) == null)
		{
			value7 = (RouletteFunctionOpenController.<>O.<6>__OpenSpringManorRoleSwitchView = new Action(RouletteFunctionOpenController.OpenSpringManorRoleSwitchView));
		}
		dictionary.Add(key7, value7);
		ERouletteFuncId key8 = ERouletteFuncId.RoguelikeInfo;
		Action value8;
		if ((value8 = RouletteFunctionOpenController.<>O.<7>__OpenRoguelikeInfoView) == null)
		{
			value8 = (RouletteFunctionOpenController.<>O.<7>__OpenRoguelikeInfoView = new Action(RouletteFunctionOpenController.OpenRoguelikeInfoView));
		}
		dictionary.Add(key8, value8);
		RouletteFunctionOpenController.RouletteFunctionOpenMap = dictionary;
	}

	// Token: 0x06015BE6 RID: 89062 RVA: 0x0057C1D3 File Offset: 0x0057A3D3
	public static void ResetStaticDefaultValue()
	{
		RouletteFunctionOpenController.RouletteFunctionOpenMap = null;
	}

	// Token: 0x0400A1E1 RID: 41441
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<ERouletteFuncId, Action> RouletteFunctionOpenMap;

	// Token: 0x02008F0D RID: 36621
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402E612 RID: 189970
		public static Action <0>__OpenWeeklyRogueInfoView;

		// Token: 0x0402E613 RID: 189971
		public static Action <1>__OpenRogueResSummaryView;

		// Token: 0x0402E614 RID: 189972
		public static Action <2>__OpenSurvivorsInfoView;

		// Token: 0x0402E615 RID: 189973
		public static Action <3>__OpenHonamiStoryQuestView;

		// Token: 0x0402E616 RID: 189974
		public static Action <4>__OpenSpringManorAtmosphereView;

		// Token: 0x0402E617 RID: 189975
		public static Action <5>__OpenSpringManorQuestView;

		// Token: 0x0402E618 RID: 189976
		public static Action <6>__OpenSpringManorRoleSwitchView;

		// Token: 0x0402E619 RID: 189977
		public static Action <7>__OpenRoguelikeInfoView;
	}
}
