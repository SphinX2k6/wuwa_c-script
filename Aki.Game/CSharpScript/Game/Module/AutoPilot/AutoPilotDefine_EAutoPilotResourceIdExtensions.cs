using System;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E5E RID: 20062
	public static class AutoPilotDefine_EAutoPilotResourceIdExtensions
	{
		// Token: 0x060327F6 RID: 206838 RVA: 0x00E2A7D8 File Offset: 0x00E289D8
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

		// Token: 0x060327F7 RID: 206839 RVA: 0x00E2A844 File Offset: 0x00E28A44
		public static AutoPilotDefine.EAutoPilotResourceId FromString(string name)
		{
			AutoPilotDefine.EAutoPilotResourceId result;
			if (!AutoPilotDefine_EAutoPilotResourceIdExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 AutoPilotDefine.EAutoPilotResourceId 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060327F8 RID: 206840 RVA: 0x00E2A870 File Offset: 0x00E28A70
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

		// Token: 0x060327F9 RID: 206841 RVA: 0x00E2A8FC File Offset: 0x00E28AFC
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

		// Token: 0x060327FA RID: 206842 RVA: 0x00E2A934 File Offset: 0x00E28B34
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

		// Token: 0x060327FB RID: 206843 RVA: 0x00E2A947 File Offset: 0x00E28B47
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
