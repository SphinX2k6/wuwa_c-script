using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026B0 RID: 9904
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeChapterView : UiTickViewBase
{
	// Token: 0x06014497 RID: 83095 RVA: 0x0052031C File Offset: 0x0051E51C
	public QuestTreeChapterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014498 RID: 83096 RVA: 0x0052036C File Offset: 0x0051E56C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 18;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISliderComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnLocate));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014499 RID: 83097 RVA: 0x00520630 File Offset: 0x0051E830
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeChapterView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeChapterView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601449A RID: 83098 RVA: 0x00520674 File Offset: 0x0051E874
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
		scrollViewWithScrollbar.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerBeginDrag));
		base.GetSlider(4).OnValueChangeCb.Bind(new Action<float>(this.OnValueChange));
		QuestTreeModel.Instance.ViewModelChapter.InitLocatingHelper(scrollViewWithScrollbar);
		QuestTreeModel.Instance.ViewModelChapter.OnViewOpen(this);
		this.CollectBtn.SetActive(this.Data.GetAcceptableNodeList().Count > 0);
		base.GetButton(14).GetRootComponent().SetUIActive(this.Data.GetCurTrackingNode() != null);
		base.GetDraggable(15).OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScroll));
		this.Elasticity = scrollViewWithScrollbar.Elasticity;
		InputDistributeController.Instance.BindTouches(new int[]
		{
			0,
			1
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x0601449B RID: 83099 RVA: 0x00520765 File Offset: 0x0051E965
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x0601449C RID: 83100 RVA: 0x00520783 File Offset: 0x0051E983
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x0601449D RID: 83101 RVA: 0x005207A1 File Offset: 0x0051E9A1
	protected override void OnBeforeShow()
	{
		QuestTreeModel.Instance.ViewModelChapter.SetShouldLocateToDefaultNode(true);
	}

	// Token: 0x0601449E RID: 83102 RVA: 0x005207B4 File Offset: 0x0051E9B4
	protected override void OnAfterShow()
	{
		QuestTreeModel.Instance.ViewModelChapter.NotifyUpdateNode();
		this.OnDataUpdate(null);
		int chapterId = (this.OpenParam as QuestTreeChapterViewParam).ChapterId;
		QuestTreeModel instance = QuestTreeModel.Instance;
		QuestTreeChapterData questTreeChapterData = (instance != null) ? instance.GetChapterDataById(chapterId) : null;
		if (questTreeChapterData == null)
		{
			return;
		}
		int? nodeId = (this.OpenParam as QuestTreeChapterViewParam).NodeId;
		QuestTreeNodeData questTreeNodeData = (nodeId != null) ? questTreeChapterData.NodeMap.GetValueOrDefault(nodeId.Value) : questTreeChapterData.GetDefaultLocatingNode();
		if (QuestTreeModel.Instance.ViewModelChapter.LastSelectedDataCache != null)
		{
			questTreeNodeData = QuestTreeModel.Instance.ViewModelChapter.LastSelectedDataCache;
		}
		if (questTreeNodeData != null && QuestTreeModel.Instance.ViewModelChapter.ShouldLocateToDefaultNode)
		{
			QuestTreeModel.Instance.ViewModelChapter.LocateToNode(questTreeNodeData, true);
		}
		BlackScreenController.Instance.RemoveBlackScreen("Close", "QuestTreeChapterView", "Default");
	}

	// Token: 0x0601449F RID: 83103 RVA: 0x00520893 File Offset: 0x0051EA93
	protected override void OnBeforeHide()
	{
		QuestTreeController.Instance.CloseNodeDetailView();
	}

	// Token: 0x060144A0 RID: 83104 RVA: 0x005208A0 File Offset: 0x0051EAA0
	protected override void OnBeforeDestroy()
	{
		this.Factory = null;
		base.GetSlider(4).OnValueChangeCb.Unbind();
		QuestTreeModel.Instance.ViewModelChapter.OnViewClose();
		base.GetScrollViewWithScrollbar(5).OnPointerBeginDragCallBack.Unbind();
		base.GetDraggable(15).OnPointerScrollCallBack.Unbind();
		InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
		{
			0,
			1
		}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		this.HasPointerScrolled = false;
		this.GuideFocusNodeData = null;
	}

	// Token: 0x060144A1 RID: 83105 RVA: 0x0052092A File Offset: 0x0051EB2A
	protected override void OnTick(float delta)
	{
		this.TickRebuildLayout(delta);
		this.TickLayoutMargin(delta);
		this.TickPointerScrolling(delta);
		this.TickLocateToGuideFocusNodeData();
	}

	// Token: 0x060144A2 RID: 83106 RVA: 0x00520948 File Offset: 0x0051EB48
	private void TickRebuildLayout(float delta)
	{
		this.DeltaTime += delta;
		if (this.DeltaTime >= 100f)
		{
			this.DeltaTime = 0f;
			if (this.ScaleDirty)
			{
				UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(6);
				horizontalLayout.GetRootComponent().SetUIActive(false);
				horizontalLayout.GetRootComponent().SetUIActive(true);
				this.ScaleDirty = false;
			}
		}
	}

	// Token: 0x060144A3 RID: 83107 RVA: 0x005209A8 File Offset: 0x0051EBA8
	private void TickLayoutMargin(float delta)
	{
		FMargin layoutMargin = this.LayoutMargin;
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(6);
		float maxTopHeight = QuestTreeModel.Instance.ViewModelChapter.MaxTopHeight;
		float num = QuestTreeModel.Instance.ViewModelChapter.MaxBottomHeight - maxTopHeight;
		if (num > 0f)
		{
			this.LayoutMargin.Top = -num + QuestTreeModel.Instance.ViewModelChapter.MaxToggleHeight * (maxTopHeight <= 0f) + 50f;
			this.LayoutMargin.Bottom = 50f;
		}
		else
		{
			this.LayoutMargin.Top = 50f;
			this.LayoutMargin.Bottom = -num;
		}
		horizontalLayout.SetPadding(this.LayoutMargin);
	}

	// Token: 0x060144A4 RID: 83108 RVA: 0x00520A57 File Offset: 0x0051EC57
	private void TickPointerScrolling(float delta)
	{
		if (this.IsPointerScrolling)
		{
			this.IsPointerScrolling = false;
			return;
		}
		if (this.HasPointerScrolled)
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			scrollViewWithScrollbar.SetHorizontal(true);
			scrollViewWithScrollbar.SetVertical(true);
		}
	}

	// Token: 0x060144A5 RID: 83109 RVA: 0x00520A85 File Offset: 0x0051EC85
	private void TickLocateToGuideFocusNodeData()
	{
		if (this.GuideFocusNodeData != null && GuideModel.Instance.HasFocusGuideGroupOnView(this.ViewInfo.Name))
		{
			QuestTreeModel.Instance.ViewModelChapter.LocateToNode(this.GuideFocusNodeData, false);
			return;
		}
		this.GuideFocusNodeData = null;
	}

	// Token: 0x060144A6 RID: 83110 RVA: 0x00520AC4 File Offset: 0x0051ECC4
	public UniTask RefreshByData(QuestTreeChapterData data)
	{
		QuestTreeChapterView.<RefreshByData>d__34 <RefreshByData>d__;
		<RefreshByData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshByData>d__.<>4__this = this;
		<RefreshByData>d__.data = data;
		<RefreshByData>d__.<>1__state = -1;
		<RefreshByData>d__.<>t__builder.Start<QuestTreeChapterView.<RefreshByData>d__34>(ref <RefreshByData>d__);
		return <RefreshByData>d__.<>t__builder.Task;
	}

	// Token: 0x060144A7 RID: 83111 RVA: 0x00520B0F File Offset: 0x0051ED0F
	public UUIScrollViewWithScrollbarComponent GetScrollView()
	{
		return base.GetScrollViewWithScrollbar(5);
	}

	// Token: 0x060144A8 RID: 83112 RVA: 0x00520B18 File Offset: 0x0051ED18
	public UUIItem GetOverrideBlurItem()
	{
		return base.GetItem(17);
	}

	// Token: 0x060144A9 RID: 83113 RVA: 0x00520B24 File Offset: 0x0051ED24
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 2 || configParams[0] != "Node")
		{
			return null;
		}
		int nodeId = int.Parse(configParams[1]);
		if (this.Data == null || this.ScrollQuests == null)
		{
			return null;
		}
		QuestTreeNodeData nodeDataFromNodeId = QuestTreeModel.Instance.GetNodeDataFromNodeId(nodeId);
		if (nodeDataFromNodeId == null || nodeDataFromNodeId.ChapterId != this.Data.Id)
		{
			return null;
		}
		this.GuideFocusNodeData = nodeDataFromNodeId;
		QuestTreeModel.Instance.ViewModelChapter.SetShouldLocateToDefaultNode(false);
		QuestTreeModel.Instance.ViewModelChapter.LocateToNode(nodeDataFromNodeId, false);
		int num = this.Data.GetMainNodeList().FindIndex((QuestTreeNodeData n) => n.Id == nodeId);
		if (num < 0)
		{
			return null;
		}
		QuestTreeNodeItemBase<QuestTreeNodeData> scrollItemByIndex = this.ScrollQuests.GetScrollItemByIndex(num);
		if (scrollItemByIndex == null)
		{
			return null;
		}
		UUIItem guideFocusUiItem = scrollItemByIndex.GetGuideFocusUiItem();
		if (guideFocusUiItem == null)
		{
			return null;
		}
		if (Info.Instance.IsInGamepad())
		{
			UiNavigationNewController.Instance.SetNavigationFocusForView(guideFocusUiItem, false, false, false);
		}
		return new UUIItem[]
		{
			guideFocusUiItem,
			guideFocusUiItem
		};
	}

	// Token: 0x060144AA RID: 83114 RVA: 0x00520C30 File Offset: 0x0051EE30
	private void OnValueChange(float value)
	{
		UUISliderComponent slider = base.GetSlider(4);
		this.LongPressIncrease.SetInteractive(value < slider.GetMaxValue());
		this.LongPressReduce.SetInteractive(value > slider.GetMinValue());
		this.ScaleVector.X = value;
		this.ScaleVector.Y = value;
		this.ScaleVector.Z = value;
		base.GetHorizontalLayout(6).GetRootComponent().SetUIRelativeScale3D(this.ScaleVector);
		this.ScaleDirty = true;
	}

	// Token: 0x060144AB RID: 83115 RVA: 0x00520CB0 File Offset: 0x0051EEB0
	private void OnPressIncrease(bool _)
	{
		UUISliderComponent slider = base.GetSlider(4);
		slider.SetValue(Math.Min(slider.GetValue() + 0.01f, slider.GetMaxValue()), true);
	}

	// Token: 0x060144AC RID: 83116 RVA: 0x00520CE4 File Offset: 0x0051EEE4
	private void OnPressReduce(bool _)
	{
		UUISliderComponent slider = base.GetSlider(4);
		slider.SetValue(Math.Max(slider.GetValue() - 0.01f, slider.GetMinValue()), true);
	}

	// Token: 0x060144AD RID: 83117 RVA: 0x00520D18 File Offset: 0x0051EF18
	private void OnLocate()
	{
		QuestTreeNodeData curTrackingNode = this.Data.GetCurTrackingNode();
		if (curTrackingNode == null)
		{
			return;
		}
		QuestTreeModel.Instance.ViewModelChapter.LocateToNode(curTrackingNode, true);
	}

	// Token: 0x060144AE RID: 83118 RVA: 0x00520D46 File Offset: 0x0051EF46
	[NullableContext(2)]
	private bool OnPointerBeginDrag(ULGUIPointerEventData _)
	{
		base.GetScrollViewWithScrollbar(5).Elasticity = this.Elasticity;
		return true;
	}

	// Token: 0x060144AF RID: 83119 RVA: 0x00520D5C File Offset: 0x0051EF5C
	[NullableContext(2)]
	private void OnPointerScroll(ULGUIPointerEventData eventData)
	{
		if (eventData == null)
		{
			return;
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
		scrollViewWithScrollbar.SetHorizontal(false);
		scrollViewWithScrollbar.SetVertical(false);
		this.IsPointerScrolling = true;
		this.HasPointerScrolled = true;
		base.GetScrollViewWithScrollbar(5).Elasticity = 0f;
		float num = eventData.scrollAxisValue * QuestTreeConfig.Instance.GetScrollingScaleDelta();
		UUISliderComponent slider = base.GetSlider(4);
		float value = slider.GetValue();
		float num2 = MathUtils.Instance.Clamp(value + num, slider.GetMinValue(), slider.GetMaxValue());
		this.SetScaleImp((double)num2, eventData.pointerPosition);
	}

	// Token: 0x060144B0 RID: 83120 RVA: 0x00520DE9 File Offset: 0x0051EFE9
	private void OnDataUpdate(QuestTreeNodeData data)
	{
		this.CollectBtn.SetActive(this.Data.GetAcceptableNodeList().Count > 0);
		base.GetButton(14).GetRootComponent().SetUIActive(this.Data.GetCurTrackingNode() != null);
	}

	// Token: 0x17001A51 RID: 6737
	// (get) Token: 0x060144B1 RID: 83121 RVA: 0x00520E29 File Offset: 0x0051F029
	private bool IsInMultiTouch
	{
		get
		{
			return this.TouchMap.Count > 1;
		}
	}

	// Token: 0x060144B2 RID: 83122 RVA: 0x00520E39 File Offset: 0x0051F039
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchBegin)
		{
			this.OnTouchBegin(touchData);
			return;
		}
		if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchEnd)
		{
			this.OnTouchEnd(touchData);
			return;
		}
		if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
		{
			this.OnTouchMove(touchData);
		}
	}

	// Token: 0x060144B3 RID: 83123 RVA: 0x00520E6C File Offset: 0x0051F06C
	private void OnTouchBegin(InputDistributeDefine.ITouchData touchData)
	{
		int touchId = touchData.TouchId;
		if (LguiEventSystemManager.Instance.IsPressComponentIsValid(touchId))
		{
			this.TouchMap[touchId] = touchData;
		}
		this.TouchCenter.Reset();
		foreach (InputDistributeDefine.ITouchData touchData2 in this.TouchMap.Values)
		{
			this.TempTouchVector2D.Set(touchData2.TouchPosition.X, touchData2.TouchPosition.Y, 0.0);
			this.TouchCenter.AdditionEqual(this.TempTouchVector2D);
		}
		if (this.TouchMap.Count > 0)
		{
			this.TouchCenter.DivisionEqual((double)this.TouchMap.Count);
		}
	}

	// Token: 0x060144B4 RID: 83124 RVA: 0x00520F4C File Offset: 0x0051F14C
	private void OnTouchEnd(InputDistributeDefine.ITouchData touchData)
	{
		int touchId = touchData.TouchId;
		this.TouchMap.Remove(touchId);
		this.TouchCenter.Reset();
		foreach (InputDistributeDefine.ITouchData touchData2 in this.TouchMap.Values)
		{
			this.TempTouchVector2D.Set(touchData2.TouchPosition.X, touchData2.TouchPosition.Y, 0.0);
			this.TouchCenter.AdditionEqual(this.TempTouchVector2D);
		}
		if (this.TouchMap.Count > 0)
		{
			this.TouchCenter.DivisionEqual((double)this.TouchMap.Count);
		}
	}

	// Token: 0x060144B5 RID: 83125 RVA: 0x00521020 File Offset: 0x0051F220
	private void OnTouchMove(InputDistributeDefine.ITouchData touchData)
	{
		if (!this.IsInMultiTouch)
		{
			return;
		}
		this.IsPointerScrolling = true;
		ValueTuple<EFingerExpandCloseType, float> fingerExpandCloseType = TouchFingerManager.Instance.GetFingerExpandCloseType(EFingerIndex.One, EFingerIndex.Two);
		EFingerExpandCloseType item = fingerExpandCloseType.Item1;
		float item2 = fingerExpandCloseType.Item2;
		if (item == EFingerExpandCloseType.None)
		{
			return;
		}
		float value = base.GetSlider(4).GetValue();
		this.SetScaleImp((double)(value + item2), this.TouchCenter.ToUeVectorOld());
	}

	// Token: 0x060144B6 RID: 83126 RVA: 0x0052107C File Offset: 0x0051F27C
	private void SetScaleImp(double newScale, FVector center)
	{
		Vector2D vector2D = Vector2D.Create((double)center.X, (double)center.Y);
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		FVector2D fvector2D = vector2D.ToUeVector2D(false);
		FVector2D fvector2D2 = canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
		UUIItem rootComponent = base.GetHorizontalLayout(6).GetRootComponent();
		FVector lguispaceAbsolutePosition = rootComponent.GetLGUISpaceAbsolutePosition();
		float num = fvector2D2.X - lguispaceAbsolutePosition.X;
		double num2 = (double)(fvector2D2.Y - lguispaceAbsolutePosition.Y);
		UUISliderComponent slider = base.GetSlider(4);
		float value = slider.GetValue();
		double num3 = newScale / (double)value;
		double num4 = (double)num * (1.0 - num3);
		double num5 = num2 * (1.0 - num3);
		double num6 = (double)rootComponent.GetAnchorOffset().X + num4;
		double num7 = (double)rootComponent.GetAnchorOffset().Y + num5;
		rootComponent.SetAnchorOffsetX((float)num6);
		rootComponent.SetAnchorOffsetY((float)num7);
		slider.SetValue((float)newScale, true);
	}

	// Token: 0x04009894 RID: 39060
	private const float SCALE_STEP = 0.01f;

	// Token: 0x04009895 RID: 39061
	private const float EXTRA_BALANCE_UP_REDUCE = 50f;

	// Token: 0x04009896 RID: 39062
	private QuestTreeChapterData Data;

	// Token: 0x04009897 RID: 39063
	private GenericScrollViewNew<QuestTreeNodeItemBase<QuestTreeNodeData>, QuestTreeNodeData> ScrollQuests;

	// Token: 0x04009898 RID: 39064
	private PopupCaptionItem Caption;

	// Token: 0x04009899 RID: 39065
	private QuestTreeNodeItemFactory Factory;

	// Token: 0x0400989A RID: 39066
	private FMargin LayoutMargin;

	// Token: 0x0400989B RID: 39067
	private FVector ScaleVector = new FVector(1f, 1f, 1f);

	// Token: 0x0400989C RID: 39068
	private bool ScaleDirty;

	// Token: 0x0400989D RID: 39069
	private float DeltaTime;

	// Token: 0x0400989E RID: 39070
	private LongPressButtonItem LongPressIncrease;

	// Token: 0x0400989F RID: 39071
	private LongPressButtonItem LongPressReduce;

	// Token: 0x040098A0 RID: 39072
	private QuestTreeChapterStartNodeItem StartNode;

	// Token: 0x040098A1 RID: 39073
	private QuestTreeCollectBtnItem CollectBtn;

	// Token: 0x040098A2 RID: 39074
	private float Elasticity;

	// Token: 0x040098A3 RID: 39075
	private bool IsPointerScrolling;

	// Token: 0x040098A4 RID: 39076
	private bool HasPointerScrolled;

	// Token: 0x040098A5 RID: 39077
	[Nullable(2)]
	private QuestTreeNodeData GuideFocusNodeData;

	// Token: 0x040098A6 RID: 39078
	private Vector TempTouchVector2D = Vector.Create();

	// Token: 0x040098A7 RID: 39079
	private Vector TouchCenter = Vector.Create();

	// Token: 0x040098A8 RID: 39080
	private Dictionary<int, InputDistributeDefine.ITouchData> TouchMap = new Dictionary<int, InputDistributeDefine.ITouchData>();

	// Token: 0x02008CF3 RID: 36083
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DBAD RID: 187309
		public const int ItemCaption = 0;

		// Token: 0x0402DBAE RID: 187310
		public const int ItemScaleBar = 1;

		// Token: 0x0402DBAF RID: 187311
		public const int BtnIncrease = 2;

		// Token: 0x0402DBB0 RID: 187312
		public const int BtnReduce = 3;

		// Token: 0x0402DBB1 RID: 187313
		public const int SliderScale = 4;

		// Token: 0x0402DBB2 RID: 187314
		public const int ScrollQuests = 5;

		// Token: 0x0402DBB3 RID: 187315
		public const int LayoutContent = 6;

		// Token: 0x0402DBB4 RID: 187316
		public const int ItemNode = 7;

		// Token: 0x0402DBB5 RID: 187317
		public const int TextureRegionIcon = 8;

		// Token: 0x0402DBB6 RID: 187318
		public const int TextChapterTitle = 9;

		// Token: 0x0402DBB7 RID: 187319
		public const int TextChapterName = 10;

		// Token: 0x0402DBB8 RID: 187320
		public const int TextureBg = 11;

		// Token: 0x0402DBB9 RID: 187321
		public const int ItemStartNode = 12;

		// Token: 0x0402DBBA RID: 187322
		public const int BtnPick = 13;

		// Token: 0x0402DBBB RID: 187323
		public const int BtnLocate = 14;

		// Token: 0x0402DBBC RID: 187324
		public const int Draggable = 15;

		// Token: 0x0402DBBD RID: 187325
		public const int ScrollBar = 16;

		// Token: 0x0402DBBE RID: 187326
		public const int ItemBlurOverride = 17;
	}
}
