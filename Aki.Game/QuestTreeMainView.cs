using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.UiComponent.UiHomeButton;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026BF RID: 9919
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeMainView : UiTickViewBase
{
	// Token: 0x06014561 RID: 83297 RVA: 0x005259DD File Offset: 0x00523BDD
	public QuestTreeMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06014562 RID: 83298 RVA: 0x005259E8 File Offset: 0x00523BE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickBtnPickUp));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickBtnTracking));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014563 RID: 83299 RVA: 0x00525B78 File Offset: 0x00523D78
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeMainView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeMainView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014564 RID: 83300 RVA: 0x00525BBC File Offset: 0x00523DBC
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
		scrollViewWithScrollbar.OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChange));
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(0);
		if (scrollViewWithScrollbar2 != null)
		{
			scrollViewWithScrollbar2.SetCanScroll(false);
		}
		QuestTreeModel.Instance.ViewModelMain.InitLocatingHelper(scrollViewWithScrollbar);
		base.GetButton(6).GetRootComponent().SetUIActive(false);
		this.RefreshTrackBtn();
		QuestTreeEnterLogEvent logData = new QuestTreeEnterLogEvent();
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x06014565 RID: 83301 RVA: 0x00525C34 File Offset: 0x00523E34
	protected override void OnBeforeShow()
	{
		this.TickDefaultLocate = true;
		this.ScrollChapter.RefreshByData(QuestTreeModel.Instance.ViewModelMain.GetViewDataList(), null, false);
		this.RefreshTrackBtn();
	}

	// Token: 0x06014566 RID: 83302 RVA: 0x00525C5F File Offset: 0x00523E5F
	protected override void OnAfterShow()
	{
		this.LocateToDefaultNode(true);
		this.TickDefaultLocate = false;
	}

	// Token: 0x06014567 RID: 83303 RVA: 0x00525C6F File Offset: 0x00523E6F
	protected override void OnBeforeDestroy()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.OnScrollValueChange.Unbind();
		}
		QuestTreeModel.Instance.ViewModelMain.SetShouldLocateToDefaultNode(true);
		QuestTreeModel.Instance.ViewModelMain.OnViewClose();
	}

	// Token: 0x06014568 RID: 83304 RVA: 0x00525CA7 File Offset: 0x00523EA7
	protected override void OnTick(float delta)
	{
		if (!this.TickDefaultLocate)
		{
			return;
		}
		this.LocateToDefaultNode(false);
	}

	// Token: 0x06014569 RID: 83305 RVA: 0x00525CB9 File Offset: 0x00523EB9
	private void RefreshTrackBtn()
	{
		base.GetButton(7).GetRootComponent().SetUIActive(QuestTreeModel.Instance.GetCurTrackingChapterData() != null);
	}

	// Token: 0x0601456A RID: 83306 RVA: 0x00525CDC File Offset: 0x00523EDC
	private void LocateToDefaultNode(bool tween = true)
	{
		QuestTreeChapterData defaultLocatingNode = QuestTreeModel.Instance.ViewModelMain.GetDefaultLocatingNode();
		if (defaultLocatingNode != null && QuestTreeModel.Instance.ViewModelMain.ShouldLocateToDefaultNode)
		{
			QuestTreeModel.Instance.ViewModelMain.LocateNode(defaultLocatingNode, tween);
		}
	}

	// Token: 0x0601456B RID: 83307 RVA: 0x00525D20 File Offset: 0x00523F20
	private void OnScrollValueChange(FVector2D value)
	{
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(4);
		float? num;
		if (horizontalLayout == null)
		{
			num = null;
		}
		else
		{
			UUIItem rootComponent = horizontalLayout.GetRootComponent();
			num = ((rootComponent != null) ? new float?(rootComponent.GetAnchorOffsetX()) : null);
		}
		float? num2 = num;
		float valueOrDefault = num2.GetValueOrDefault();
		float num3 = valueOrDefault - this.LastScrollOffsetX;
		this.LastScrollOffsetX = valueOrDefault;
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
		TWeakObjectPtr<UUIItem>? tweakObjectPtr = (scrollViewWithScrollbar != null) ? new TWeakObjectPtr<UUIItem>?(scrollViewWithScrollbar.ContentUIItem) : null;
		float? num4;
		if (tweakObjectPtr == null)
		{
			num4 = null;
		}
		else
		{
			UUIItem uuiitem = tweakObjectPtr.GetValueOrDefault().Get();
			num4 = ((uuiitem != null) ? new float?(uuiitem.GetAnchorOffsetX()) : null);
		}
		num2 = num4;
		float valueOrDefault2 = num2.GetValueOrDefault();
		if (tweakObjectPtr != null)
		{
			UUIItem uuiitem2 = tweakObjectPtr.GetValueOrDefault().Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetAnchorOffsetX(valueOrDefault2 + num3 * 0.2f);
		}
	}

	// Token: 0x0601456C RID: 83308 RVA: 0x00525E14 File Offset: 0x00524014
	private void OnClickBtnPickUp()
	{
		List<QuestTreeNodeData> allAcceptableNodeList = QuestTreeModel.Instance.GetAllAcceptableNodeList();
		if (allAcceptableNodeList.Count == 0)
		{
			return;
		}
		QuestTreeController.Instance.OpenAvailableListView(allAcceptableNodeList);
	}

	// Token: 0x0601456D RID: 83309 RVA: 0x00525E40 File Offset: 0x00524040
	private void OnClickBtnTracking()
	{
		QuestTreeChapterData curTrackingChapterData = QuestTreeModel.Instance.GetCurTrackingChapterData();
		if (curTrackingChapterData != null)
		{
			QuestTreeModel.Instance.ViewModelMain.LocateNode(curTrackingChapterData, true);
		}
	}

	// Token: 0x0601456E RID: 83310 RVA: 0x00525E6C File Offset: 0x0052406C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 2 || configParams[0] != "Chapter")
		{
			return null;
		}
		if (this.ScrollChapter == null)
		{
			return null;
		}
		int num = int.Parse(configParams[1]);
		QuestTreeChapterData chapterDataById = QuestTreeModel.Instance.GetChapterDataById(num);
		if (chapterDataById == null)
		{
			return null;
		}
		QuestTreeModel.Instance.ViewModelMain.SetShouldLocateToDefaultNode(false);
		QuestTreeModel.Instance.ViewModelMain.LocateNode(chapterDataById, false);
		foreach (QuestTreeChapterGroupItem questTreeChapterGroupItem in this.ScrollChapter.GetScrollItemList())
		{
			UUIItem chapterToggleUiItem = questTreeChapterGroupItem.GetChapterToggleUiItem(num);
			if (chapterToggleUiItem != null)
			{
				return new UUIItem[]
				{
					chapterToggleUiItem,
					chapterToggleUiItem
				};
			}
		}
		return null;
	}

	// Token: 0x040098E6 RID: 39142
	private GenericScrollViewNew<QuestTreeChapterGroupItem, List<QuestTreeChapterData>> ScrollChapter;

	// Token: 0x040098E7 RID: 39143
	private PopupCaptionItem Caption;

	// Token: 0x040098E8 RID: 39144
	private HomeBtnItem HomeBtn;

	// Token: 0x040098E9 RID: 39145
	private float LastScrollOffsetX;

	// Token: 0x040098EA RID: 39146
	private const float BG_MOVEMENT_RATE = 0.2f;

	// Token: 0x040098EB RID: 39147
	private bool TickDefaultLocate;

	// Token: 0x02008D21 RID: 36129
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DCFA RID: 187642
		public const int ScrollBackground = 0;

		// Token: 0x0402DCFB RID: 187643
		public const int TextureBackground = 1;

		// Token: 0x0402DCFC RID: 187644
		public const int ItemCaption = 2;

		// Token: 0x0402DCFD RID: 187645
		public const int ScrollChapter = 3;

		// Token: 0x0402DCFE RID: 187646
		public const int LayoutContent = 4;

		// Token: 0x0402DCFF RID: 187647
		public const int ItemChapterGroup = 5;

		// Token: 0x0402DD00 RID: 187648
		public const int BtnPickUp = 6;

		// Token: 0x0402DD01 RID: 187649
		public const int BtnTracking = 7;
	}
}
