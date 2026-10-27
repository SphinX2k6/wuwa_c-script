using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046AB RID: 18091
	public class InputDefine
	{
		// Token: 0x0602EA6F RID: 191087 RVA: 0x00ACC048 File Offset: 0x00ACA248
		// Note: this type is marked as 'beforefieldinit'.
		static InputDefine()
		{
			Dictionary<string, EUiViewName> dictionary = new Dictionary<string, EUiViewName>();
			dictionary["邮件"] = EUiViewName.MailBoxView;
			dictionary["地图"] = EUiViewName.WorldMapView;
			dictionary["任务"] = EUiViewName.QuestView;
			dictionary["编队"] = EUiViewName.Formation2DView;
			dictionary["背包"] = EUiViewName.InventoryView;
			dictionary["聊天"] = EUiViewName.ChatView;
			dictionary["功能菜单"] = EUiViewName.FunctionView;
			dictionary["角色选择界面"] = EUiViewName.RoleRootView;
			dictionary["幻象列表界面"] = EUiViewName.PhantomExploreSetView;
			dictionary["幻象探索选择界面"] = EUiViewName.PhantomExploreView;
			dictionary["塔防轮盘"] = EUiViewName.PhantomExploreView;
			dictionary["GM指令"] = EUiViewName.GmView;
			dictionary["教程"] = EUiViewName.TutorialView;
			dictionary["联机"] = EUiViewName.OnlineWorldHallView;
			dictionary["小活动"] = EUiViewName.CommonActivityView;
			dictionary["调谐"] = EUiViewName.GachaMainView;
			dictionary["变星"] = EUiViewName.BattlePassMainView;
			dictionary["拾音辑录"] = EUiViewName.AdventureGuideView;
			InputDefine.openViewActionsMap = dictionary;
		}

		// Token: 0x04019691 RID: 104081
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<string, EUiViewName> openViewActionsMap;
	}
}
