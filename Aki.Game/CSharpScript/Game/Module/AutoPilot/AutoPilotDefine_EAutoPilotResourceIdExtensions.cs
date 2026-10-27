using System;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E79 RID: 24185
	public static class AutoPilotDefine_EAutoPilotResourceIdExtensions
	{
		// Token: 0x0603D866 RID: 252006 RVA: 0x00ED924C File Offset: 0x00ED744C
		public static string ToEnumString(this AutoPilotDefine.EAutoPilotResourceId value)
		{
			string result;
			switch (value)
			{
			case AutoPilotDefine.EAutoPilotResourceId.AutoPilotNavBtn:
				result = "UiItem_AutocruiseNavBtn";
				break;
			case AutoPilotDefine.EAutoPilotResourceId.AutoPilotGoBtnGroup:
				result = "PnlSetOutBtn";
				break;
			case AutoPilotDefine.EAutoPilotResourceId.AutoPilotLineComp:
				result = "UiItem_AutoPilot_Line";
				break;
			case AutoPilotDefine.EAutoPilotResourceId.AutoPilotTrackMark:
				result = "UiItem_AutocruiseMark";
				break;
			case AutoPilotDefine.EAutoPilotResourceId.AutoPilotView:
				result = "UiView_MotorcycleAutoCruise";
				break;
			case AutoPilotDefine.EAutoPilotResourceId.AutoPilotState:
				result = "UiItem_MotorAutoCruise";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0603D867 RID: 252007 RVA: 0x00ED92B8 File Offset: 0x00ED74B8
		public static AutoPilotDefine.EAutoPilotResourceId FromString(string name)
		{
			AutoPilotDefine.EAutoPilotResourceId result;
			if (!AutoPilotDefine_EAutoPilotResourceIdExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 AutoPilotDefine.EAutoPilotResourceId 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603D868 RID: 252008 RVA: 0x00ED92E4 File Offset: 0x00ED74E4
		public static bool TryFromString(string name, out AutoPilotDefine.EAutoPilotResourceId value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = AutoPilotDefine.EAutoPilotResourceId.AutoPilotNavBtn;
				return false;
			}
			if (name == "UiItem_AutocruiseNavBtn")
			{
				value = AutoPilotDefine.EAutoPilotResourceId.AutoPilotNavBtn;
				return true;
			}
			if (name == "PnlSetOutBtn")
			{
				value = AutoPilotDefine.EAutoPilotResourceId.AutoPilotGoBtnGroup;
				return true;
			}
			if (name == "UiItem_AutoPilot_Line")
			{
				value = AutoPilotDefine.EAutoPilotResourceId.AutoPilotLineComp;
				return true;
			}
			if (name == "UiItem_AutocruiseMark")
			{
				value = AutoPilotDefine.EAutoPilotResourceId.AutoPilotTrackMark;
				return true;
			}
			if (name == "UiView_MotorcycleAutoCruise")
			{
				value = AutoPilotDefine.EAutoPilotResourceId.AutoPilotView;
				return true;
			}
			if (!(name == "UiItem_MotorAutoCruise"))
			{
				value = AutoPilotDefine.EAutoPilotResourceId.AutoPilotNavBtn;
				return false;
			}
			value = AutoPilotDefine.EAutoPilotResourceId.AutoPilotState;
			return true;
		}

		// Token: 0x0603D869 RID: 252009 RVA: 0x00ED9370 File Offset: 0x00ED7570
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UiItem_AutocruiseNavBtn",
				"PnlSetOutBtn",
				"UiItem_AutoPilot_Line",
				"UiItem_AutocruiseMark",
				"UiView_MotorcycleAutoCruise",
				"UiItem_MotorAutoCruise"
			};
		}

		// Token: 0x0603D86A RID: 252010 RVA: 0x00ED93A8 File Offset: 0x00ED75A8
		public static AutoPilotDefine.EAutoPilotResourceId[] GetValues()
		{
			return new AutoPilotDefine.EAutoPilotResourceId[]
			{
				AutoPilotDefine.EAutoPilotResourceId.AutoPilotNavBtn,
				AutoPilotDefine.EAutoPilotResourceId.AutoPilotGoBtnGroup,
				AutoPilotDefine.EAutoPilotResourceId.AutoPilotLineComp,
				AutoPilotDefine.EAutoPilotResourceId.AutoPilotTrackMark,
				AutoPilotDefine.EAutoPilotResourceId.AutoPilotView,
				AutoPilotDefine.EAutoPilotResourceId.AutoPilotState
			};
		}

		// Token: 0x0603D86B RID: 252011 RVA: 0x00ED93BB File Offset: 0x00ED75BB
		public static string[] GetNames()
		{
			return new string[]
			{
				"AutoPilotNavBtn",
				"AutoPilotGoBtnGroup",
				"AutoPilotLineComp",
				"AutoPilotTrackMark",
				"AutoPilotView",
				"AutoPilotState"
			};
		}
	}
}
