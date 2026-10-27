using System;
using CSharpScript.Core.Common;

// Token: 0x02002625 RID: 9765
[EnumExtensions]
public enum EQteItem
{
	// Token: 0x04009679 RID: 38521
	[EnumStringMember("UiItem_QteBtnSingleTap")]
	SingleClickItem,
	// Token: 0x0400967A RID: 38522
	[EnumStringMember("UiItem_QteBtnTapRapidly")]
	ContinuousClickItem,
	// Token: 0x0400967B RID: 38523
	[EnumStringMember("UiItem_QteDrag")]
	DragItem,
	// Token: 0x0400967C RID: 38524
	[EnumStringMember("UiItem_QteBtnLongPress")]
	LongPressItem,
	// Token: 0x0400967D RID: 38525
	[EnumStringMember("UiView_PlotInteraction")]
	SelectOptionItem,
	// Token: 0x0400967E RID: 38526
	[EnumStringMember("UiItem_QteObjectPos")]
	CustomOptionItem,
	// Token: 0x0400967F RID: 38527
	[EnumStringMember("UiItem_PullUp")]
	PullUpItem,
	// Token: 0x04009680 RID: 38528
	[EnumStringMember("UiItem_PullDown")]
	PullDownItem,
	// Token: 0x04009681 RID: 38529
	[EnumStringMember("UiItem_FocusSingleButton")]
	FocusSingleButtonItem,
	// Token: 0x04009682 RID: 38530
	[EnumStringMember("UiItem_QteBtnRingTab")]
	RingTapItem,
	// Token: 0x04009683 RID: 38531
	[EnumStringMember("UiItem_QteBtnRingMatch")]
	RingMatchTapItem,
	// Token: 0x04009684 RID: 38532
	[EnumStringMember("UiItem_CompassRotate")]
	CompassRotateItem,
	// Token: 0x04009685 RID: 38533
	[EnumStringMember("UiItem_FullScreenLongPress")]
	FullScreenLongPressItem,
	// Token: 0x04009686 RID: 38534
	[EnumStringMember("UiItem_QteBtnSingleTap37")]
	SingleTap37Item,
	// Token: 0x04009687 RID: 38535
	[EnumStringMember("UiItem_RightScreenDragItem")]
	RightScreenDragItem,
	// Token: 0x04009688 RID: 38536
	[EnumStringMember("UiItem_PlotQteSuisui")]
	SuisuiSlideItem,
	// Token: 0x04009689 RID: 38537
	[EnumStringMember("UiItem_PlotQteSuisuiRight")]
	SuisuiRight,
	// Token: 0x0400968A RID: 38538
	[EnumStringMember("UiItem_PlotQteSuisuiDown")]
	SuisuiDown,
	// Token: 0x0400968B RID: 38539
	[EnumStringMember("UiItem_PlotQteDragItem")]
	PlotQteDragItem
}
