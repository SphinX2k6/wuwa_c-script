using System;

// Token: 0x02002AC6 RID: 10950
public static class EQteItemExtensions
{
	// Token: 0x0601BCBB RID: 113851 RVA: 0x0088E144 File Offset: 0x0088C344
	public static string ToEnumString(this EQteItem value)
	{
		string result;
		switch (value)
		{
		case EQteItem.SingleClickItem:
			result = "UiItem_QteBtnSingleTap";
			break;
		case EQteItem.ContinuousClickItem:
			result = "UiItem_QteBtnTapRapidly";
			break;
		case EQteItem.DragItem:
			result = "UiItem_QteDrag";
			break;
		case EQteItem.LongPressItem:
			result = "UiItem_QteBtnLongPress";
			break;
		case EQteItem.SelectOptionItem:
			result = "UiView_PlotInteraction";
			break;
		case EQteItem.CustomOptionItem:
			result = "UiItem_QteObjectPos";
			break;
		case EQteItem.PullUpItem:
			result = "UiItem_PullUp";
			break;
		case EQteItem.PullDownItem:
			result = "UiItem_PullDown";
			break;
		case EQteItem.PullLeftItem:
			result = "UiItem_PullLeft";
			break;
		case EQteItem.FocusSingleButtonItem:
			result = "UiItem_FocusSingleButton";
			break;
		case EQteItem.RingTapItem:
			result = "UiItem_QteBtnRingTab";
			break;
		case EQteItem.RingMatchTapItem:
			result = "UiItem_QteBtnRingMatch";
			break;
		case EQteItem.CompassRotateItem:
			result = "UiItem_CompassRotate";
			break;
		case EQteItem.FullScreenLongPressItem:
			result = "UiItem_FullScreenLongPress";
			break;
		case EQteItem.SingleTap37Item:
			result = "UiItem_QteBtnSingleTap37";
			break;
		case EQteItem.RightScreenDragItem:
			result = "UiItem_RightScreenDragItem";
			break;
		case EQteItem.SuisuiSlideItem:
			result = "UiItem_PlotQteSuisui";
			break;
		case EQteItem.SuisuiRight:
			result = "UiItem_PlotQteSuisuiRight";
			break;
		case EQteItem.SuisuiDown:
			result = "UiItem_PlotQteSuisuiDown";
			break;
		case EQteItem.PlotQteDragItem:
			result = "UiItem_PlotQteDragItem";
			break;
		default:
			result = value.ToString();
			break;
		}
		return result;
	}

	// Token: 0x0601BCBC RID: 113852 RVA: 0x0088E26C File Offset: 0x0088C46C
	public static EQteItem FromString(string name)
	{
		EQteItem result;
		if (!EQteItemExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 EQteItem 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601BCBD RID: 113853 RVA: 0x0088E298 File Offset: 0x0088C498
	public static bool TryFromString(string name, out EQteItem value)
	{
		if (string.IsNullOrEmpty(name))
		{
			value = EQteItem.SingleClickItem;
			return false;
		}
		if (name != null)
		{
			switch (name.Length)
			{
			case 13:
				if (name == "UiItem_PullUp")
				{
					value = EQteItem.PullUpItem;
					return true;
				}
				break;
			case 14:
				if (name == "UiItem_QteDrag")
				{
					value = EQteItem.DragItem;
					return true;
				}
				break;
			case 15:
			{
				char c = name[11];
				if (c != 'D')
				{
					if (c == 'L')
					{
						if (name == "UiItem_PullLeft")
						{
							value = EQteItem.PullLeftItem;
							return true;
						}
					}
				}
				else if (name == "UiItem_PullDown")
				{
					value = EQteItem.PullDownItem;
					return true;
				}
				break;
			}
			case 19:
				if (name == "UiItem_QteObjectPos")
				{
					value = EQteItem.CustomOptionItem;
					return true;
				}
				break;
			case 20:
			{
				char c = name[7];
				if (c != 'C')
				{
					if (c != 'P')
					{
						if (c == 'Q')
						{
							if (name == "UiItem_QteBtnRingTab")
							{
								value = EQteItem.RingTapItem;
								return true;
							}
						}
					}
					else if (name == "UiItem_PlotQteSuisui")
					{
						value = EQteItem.SuisuiSlideItem;
						return true;
					}
				}
				else if (name == "UiItem_CompassRotate")
				{
					value = EQteItem.CompassRotateItem;
					return true;
				}
				break;
			}
			case 22:
			{
				char c = name[13];
				if (c <= 'R')
				{
					if (c != 'L')
					{
						if (c == 'R')
						{
							if (name == "UiItem_QteBtnRingMatch")
							{
								value = EQteItem.RingMatchTapItem;
								return true;
							}
						}
					}
					else if (name == "UiItem_QteBtnLongPress")
					{
						value = EQteItem.LongPressItem;
						return true;
					}
				}
				else if (c != 'S')
				{
					if (c != 'e')
					{
						if (c == 't')
						{
							if (name == "UiView_PlotInteraction")
							{
								value = EQteItem.SelectOptionItem;
								return true;
							}
						}
					}
					else if (name == "UiItem_PlotQteDragItem")
					{
						value = EQteItem.PlotQteDragItem;
						return true;
					}
				}
				else if (name == "UiItem_QteBtnSingleTap")
				{
					value = EQteItem.SingleClickItem;
					return true;
				}
				break;
			}
			case 23:
				if (name == "UiItem_QteBtnTapRapidly")
				{
					value = EQteItem.ContinuousClickItem;
					return true;
				}
				break;
			case 24:
			{
				char c = name[7];
				if (c != 'F')
				{
					if (c != 'P')
					{
						if (c == 'Q')
						{
							if (name == "UiItem_QteBtnSingleTap37")
							{
								value = EQteItem.SingleTap37Item;
								return true;
							}
						}
					}
					else if (name == "UiItem_PlotQteSuisuiDown")
					{
						value = EQteItem.SuisuiDown;
						return true;
					}
				}
				else if (name == "UiItem_FocusSingleButton")
				{
					value = EQteItem.FocusSingleButtonItem;
					return true;
				}
				break;
			}
			case 25:
				if (name == "UiItem_PlotQteSuisuiRight")
				{
					value = EQteItem.SuisuiRight;
					return true;
				}
				break;
			case 26:
			{
				char c = name[7];
				if (c != 'F')
				{
					if (c == 'R')
					{
						if (name == "UiItem_RightScreenDragItem")
						{
							value = EQteItem.RightScreenDragItem;
							return true;
						}
					}
				}
				else if (name == "UiItem_FullScreenLongPress")
				{
					value = EQteItem.FullScreenLongPressItem;
					return true;
				}
				break;
			}
			}
		}
		value = EQteItem.SingleClickItem;
		return false;
	}

	// Token: 0x0601BCBE RID: 113854 RVA: 0x0088E5D4 File Offset: 0x0088C7D4
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"UiItem_QteBtnSingleTap",
			"UiItem_QteBtnTapRapidly",
			"UiItem_QteDrag",
			"UiItem_QteBtnLongPress",
			"UiView_PlotInteraction",
			"UiItem_QteObjectPos",
			"UiItem_PullUp",
			"UiItem_PullDown",
			"UiItem_PullLeft",
			"UiItem_FocusSingleButton",
			"UiItem_QteBtnRingTab",
			"UiItem_QteBtnRingMatch",
			"UiItem_CompassRotate",
			"UiItem_FullScreenLongPress",
			"UiItem_QteBtnSingleTap37",
			"UiItem_RightScreenDragItem",
			"UiItem_PlotQteSuisui",
			"UiItem_PlotQteSuisuiRight",
			"UiItem_PlotQteSuisuiDown",
			"UiItem_PlotQteDragItem"
		};
	}

	// Token: 0x0601BCBF RID: 113855 RVA: 0x0088E693 File Offset: 0x0088C893
	public static EQteItem[] GetValues()
	{
		return new EQteItem[]
		{
			EQteItem.SingleClickItem,
			EQteItem.ContinuousClickItem,
			EQteItem.DragItem,
			EQteItem.LongPressItem,
			EQteItem.SelectOptionItem,
			EQteItem.CustomOptionItem,
			EQteItem.PullUpItem,
			EQteItem.PullDownItem,
			EQteItem.PullLeftItem,
			EQteItem.FocusSingleButtonItem,
			EQteItem.RingTapItem,
			EQteItem.RingMatchTapItem,
			EQteItem.CompassRotateItem,
			EQteItem.FullScreenLongPressItem,
			EQteItem.SingleTap37Item,
			EQteItem.RightScreenDragItem,
			EQteItem.SuisuiSlideItem,
			EQteItem.SuisuiRight,
			EQteItem.SuisuiDown,
			EQteItem.PlotQteDragItem
		};
	}

	// Token: 0x0601BCC0 RID: 113856 RVA: 0x0088E6A8 File Offset: 0x0088C8A8
	public static string[] GetNames()
	{
		return new string[]
		{
			"SingleClickItem",
			"ContinuousClickItem",
			"DragItem",
			"LongPressItem",
			"SelectOptionItem",
			"CustomOptionItem",
			"PullUpItem",
			"PullDownItem",
			"PullLeftItem",
			"FocusSingleButtonItem",
			"RingTapItem",
			"RingMatchTapItem",
			"CompassRotateItem",
			"FullScreenLongPressItem",
			"SingleTap37Item",
			"RightScreenDragItem",
			"SuisuiSlideItem",
			"SuisuiRight",
			"SuisuiDown",
			"PlotQteDragItem"
		};
	}
}
