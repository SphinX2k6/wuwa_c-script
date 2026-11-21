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

// Token: 0x02001BAA RID: 7082
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeMainView : UiTickViewBase
{
	// Token: 0x06011A43 RID: 72259 RVA: 0x00534715 File Offset: 0x00532915
	public QuestTreeMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06011A44 RID: 72260 RVA: 0x00534720 File Offset: 0x00532920
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

	// Token: 0x06011A45 RID: 72261 RVA: 0x005348B0 File Offset: 0x00532AB0
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeMainView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeMainView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011A46 RID: 72262 RVA: 0x005348F4 File Offset: 0x00532AF4
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

	// Token: 0x06011A47 RID: 72263 RVA: 0x0053496C File Offset: 0x00532B6C
	protected override void OnBeforeShow()
	{
		this.TickDefaultLocate = true;
		this.ScrollChapter.RefreshByData(QuestTreeModel.Instance.ViewModelMain.GetViewDataList(), null, false);
		this.RefreshTrackBtn();
	}

	// Token: 0x06011A48 RID: 72264 RVA: 0x00534997 File Offset: 0x00532B97
	protected override void OnAfterShow()
	{
		this.LocateToDefaultNode(true);
		this.TickDefaultLocate = false;
	}

	// Token: 0x06011A49 RID: 72265 RVA: 0x005349A7 File Offset: 0x00532BA7
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

	// Token: 0x06011A4A RID: 72266 RVA: 0x005349DF File Offset: 0x00532BDF
	protected override void OnTick(float delta)
	{
		if (!this.TickDefaultLocate)
		{
			return;
		}
		this.LocateToDefaultNode(false);
	}

	// Token: 0x06011A4B RID: 72267 RVA: 0x005349F1 File Offset: 0x00532BF1
	private void RefreshTrackBtn()
	{
		base.GetButton(7).GetRootComponent().SetUIActive(QuestTreeModel.Instance.GetCurTrackingChapterData() != null);
	}

	// Token: 0x06011A4C RID: 72268 RVA: 0x00534A14 File Offset: 0x00532C14
	private void LocateToDefaultNode(bool tween = true)
	{
		QuestTreeChapterData defaultLocatingNode = QuestTreeModel.Instance.ViewModelMain.GetDefaultLocatingNode();
		if (defaultLocatingNode != null && QuestTreeModel.Instance.ViewModelMain.ShouldLocateToDefaultNode)
		{
			QuestTreeModel.Instance.ViewModelMain.LocateNode(defaultLocatingNode, tween);
		}
	}

	// Token: 0x06011A4D RID: 72269 RVA: 0x00534A58 File Offset: 0x00532C58
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

	// Token: 0x06011A4E RID: 72270 RVA: 0x00534B4C File Offset: 0x00532D4C
	private void OnClickBtnPickUp()
	{
		List<QuestTreeNodeData> allAcceptableNodeList = QuestTreeModel.Instance.GetAllAcceptableNodeList();
		if (allAcceptableNodeList.Count == 0)
		{
			return;
		}
		QuestTreeController.Instance.OpenAvailableListView(allAcceptableNodeList);
	}

	// Token: 0x06011A4F RID: 72271 RVA: 0x00534B78 File Offset: 0x00532D78
	private void OnClickBtnTracking()
	{
		QuestTreeChapterData curTrackingChapterData = QuestTreeModel.Instance.GetCurTrackingChapterData();
		if (curTrackingChapterData != null)
		{
			QuestTreeModel.Instance.ViewModelMain.LocateNode(curTrackingChapterData, true);
		}
	}

	// Token: 0x06011A50 RID: 72272 RVA: 0x00534BA4 File Offset: 0x00532DA4
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

	// Token: 0x04009A3E RID: 39486
	private GenericScrollViewNew<QuestTreeChapterGroupItem, List<QuestTreeChapterData>> ScrollChapter;

	// Token: 0x04009A3F RID: 39487
	private PopupCaptionItem Caption;

	// Token: 0x04009A40 RID: 39488
	private HomeBtnItem HomeBtn;

	// Token: 0x04009A41 RID: 39489
	private float LastScrollOffsetX;

	// Token: 0x04009A42 RID: 39490
	private const float BG_MOVEMENT_RATE = 0.2f;

	// Token: 0x04009A43 RID: 39491
	private bool TickDefaultLocate;

	// Token: 0x02007EAA RID: 32426
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04029011 RID: 167953
		public const int ScrollBackground = 0;

		// Token: 0x04029012 RID: 167954
		public const int TextureBackground = 1;

		// Token: 0x04029013 RID: 167955
		public const int ItemCaption = 2;

		// Token: 0x04029014 RID: 167956
		public const int ScrollChapter = 3;

		// Token: 0x04029015 RID: 167957
		public const int LayoutContent = 4;

		// Token: 0x04029016 RID: 167958
		public const int ItemChapterGroup = 5;

		// Token: 0x04029017 RID: 167959
		public const int BtnPickUp = 6;

		// Token: 0x04029018 RID: 167960
		public const int BtnTracking = 7;
	}
}
