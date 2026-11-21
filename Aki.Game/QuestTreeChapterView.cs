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

// Token: 0x02001B9B RID: 7067
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeChapterView : UiTickViewBase
{
	// Token: 0x06011979 RID: 72057 RVA: 0x0052F054 File Offset: 0x0052D254
	public QuestTreeChapterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601197A RID: 72058 RVA: 0x0052F0A4 File Offset: 0x0052D2A4
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

	// Token: 0x0601197B RID: 72059 RVA: 0x0052F368 File Offset: 0x0052D568
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeChapterView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeChapterView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601197C RID: 72060 RVA: 0x0052F3AC File Offset: 0x0052D5AC
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

	// Token: 0x0601197D RID: 72061 RVA: 0x0052F49D File Offset: 0x0052D69D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x0601197E RID: 72062 RVA: 0x0052F4BB File Offset: 0x0052D6BB
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x0601197F RID: 72063 RVA: 0x0052F4D9 File Offset: 0x0052D6D9
	protected override void OnBeforeShow()
	{
		QuestTreeModel.Instance.ViewModelChapter.SetShouldLocateToDefaultNode(true);
	}

	// Token: 0x06011980 RID: 72064 RVA: 0x0052F4EC File Offset: 0x0052D6EC
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

	// Token: 0x06011981 RID: 72065 RVA: 0x0052F5CB File Offset: 0x0052D7CB
	protected override void OnBeforeHide()
	{
		QuestTreeController.Instance.CloseNodeDetailView();
	}

	// Token: 0x06011982 RID: 72066 RVA: 0x0052F5D8 File Offset: 0x0052D7D8
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

	// Token: 0x06011983 RID: 72067 RVA: 0x0052F662 File Offset: 0x0052D862
	protected override void OnTick(float delta)
	{
		this.TickRebuildLayout(delta);
		this.TickLayoutMargin(delta);
		this.TickPointerScrolling(delta);
		this.TickLocateToGuideFocusNodeData();
	}

	// Token: 0x06011984 RID: 72068 RVA: 0x0052F680 File Offset: 0x0052D880
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

	// Token: 0x06011985 RID: 72069 RVA: 0x0052F6E0 File Offset: 0x0052D8E0
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

	// Token: 0x06011986 RID: 72070 RVA: 0x0052F78F File Offset: 0x0052D98F
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

	// Token: 0x06011987 RID: 72071 RVA: 0x0052F7BD File Offset: 0x0052D9BD
	private void TickLocateToGuideFocusNodeData()
	{
		if (this.GuideFocusNodeData != null && GuideModel.Instance.HasFocusGuideGroupOnView(this.ViewInfo.Name))
		{
			QuestTreeModel.Instance.ViewModelChapter.LocateToNode(this.GuideFocusNodeData, false);
			return;
		}
		this.GuideFocusNodeData = null;
	}

	// Token: 0x06011988 RID: 72072 RVA: 0x0052F7FC File Offset: 0x0052D9FC
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

	// Token: 0x06011989 RID: 72073 RVA: 0x0052F847 File Offset: 0x0052DA47
	public UUIScrollViewWithScrollbarComponent GetScrollView()
	{
		return base.GetScrollViewWithScrollbar(5);
	}

	// Token: 0x0601198A RID: 72074 RVA: 0x0052F850 File Offset: 0x0052DA50
	public UUIItem GetOverrideBlurItem()
	{
		return base.GetItem(17);
	}

	// Token: 0x0601198B RID: 72075 RVA: 0x0052F85C File Offset: 0x0052DA5C
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

	// Token: 0x0601198C RID: 72076 RVA: 0x0052F968 File Offset: 0x0052DB68
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

	// Token: 0x0601198D RID: 72077 RVA: 0x0052F9E8 File Offset: 0x0052DBE8
	private void OnPressIncrease(bool _)
	{
		UUISliderComponent slider = base.GetSlider(4);
		slider.SetValue(Math.Min(slider.GetValue() + 0.01f, slider.GetMaxValue()), true);
	}

	// Token: 0x0601198E RID: 72078 RVA: 0x0052FA1C File Offset: 0x0052DC1C
	private void OnPressReduce(bool _)
	{
		UUISliderComponent slider = base.GetSlider(4);
		slider.SetValue(Math.Max(slider.GetValue() - 0.01f, slider.GetMinValue()), true);
	}

	// Token: 0x0601198F RID: 72079 RVA: 0x0052FA50 File Offset: 0x0052DC50
	private void OnLocate()
	{
		QuestTreeNodeData curTrackingNode = this.Data.GetCurTrackingNode();
		if (curTrackingNode == null)
		{
			return;
		}
		QuestTreeModel.Instance.ViewModelChapter.LocateToNode(curTrackingNode, true);
	}

	// Token: 0x06011990 RID: 72080 RVA: 0x0052FA7E File Offset: 0x0052DC7E
	[NullableContext(2)]
	private bool OnPointerBeginDrag(ULGUIPointerEventData _)
	{
		base.GetScrollViewWithScrollbar(5).Elasticity = this.Elasticity;
		return true;
	}

	// Token: 0x06011991 RID: 72081 RVA: 0x0052FA94 File Offset: 0x0052DC94
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

	// Token: 0x06011992 RID: 72082 RVA: 0x0052FB21 File Offset: 0x0052DD21
	private void OnDataUpdate(QuestTreeNodeData data)
	{
		this.CollectBtn.SetActive(this.Data.GetAcceptableNodeList().Count > 0);
		base.GetButton(14).GetRootComponent().SetUIActive(this.Data.GetCurTrackingNode() != null);
	}

	// Token: 0x17001A89 RID: 6793
	// (get) Token: 0x06011993 RID: 72083 RVA: 0x0052FB61 File Offset: 0x0052DD61
	private bool IsInMultiTouch
	{
		get
		{
			return this.TouchMap.Count > 1;
		}
	}

	// Token: 0x06011994 RID: 72084 RVA: 0x0052FB71 File Offset: 0x0052DD71
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

	// Token: 0x06011995 RID: 72085 RVA: 0x0052FBA4 File Offset: 0x0052DDA4
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

	// Token: 0x06011996 RID: 72086 RVA: 0x0052FC84 File Offset: 0x0052DE84
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

	// Token: 0x06011997 RID: 72087 RVA: 0x0052FD58 File Offset: 0x0052DF58
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

	// Token: 0x06011998 RID: 72088 RVA: 0x0052FDB4 File Offset: 0x0052DFB4
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

	// Token: 0x040099EC RID: 39404
	private const float SCALE_STEP = 0.01f;

	// Token: 0x040099ED RID: 39405
	private const float EXTRA_BALANCE_UP_REDUCE = 50f;

	// Token: 0x040099EE RID: 39406
	private QuestTreeChapterData Data;

	// Token: 0x040099EF RID: 39407
	private GenericScrollViewNew<QuestTreeNodeItemBase<QuestTreeNodeData>, QuestTreeNodeData> ScrollQuests;

	// Token: 0x040099F0 RID: 39408
	private PopupCaptionItem Caption;

	// Token: 0x040099F1 RID: 39409
	private QuestTreeNodeItemFactory Factory;

	// Token: 0x040099F2 RID: 39410
	private FMargin LayoutMargin;

	// Token: 0x040099F3 RID: 39411
	private FVector ScaleVector = new FVector(1f, 1f, 1f);

	// Token: 0x040099F4 RID: 39412
	private bool ScaleDirty;

	// Token: 0x040099F5 RID: 39413
	private float DeltaTime;

	// Token: 0x040099F6 RID: 39414
	private LongPressButtonItem LongPressIncrease;

	// Token: 0x040099F7 RID: 39415
	private LongPressButtonItem LongPressReduce;

	// Token: 0x040099F8 RID: 39416
	private QuestTreeChapterStartNodeItem StartNode;

	// Token: 0x040099F9 RID: 39417
	private QuestTreeCollectBtnItem CollectBtn;

	// Token: 0x040099FA RID: 39418
	private float Elasticity;

	// Token: 0x040099FB RID: 39419
	private bool IsPointerScrolling;

	// Token: 0x040099FC RID: 39420
	private bool HasPointerScrolled;

	// Token: 0x040099FD RID: 39421
	[Nullable(2)]
	private QuestTreeNodeData GuideFocusNodeData;

	// Token: 0x040099FE RID: 39422
	private Vector TempTouchVector2D = Vector.Create();

	// Token: 0x040099FF RID: 39423
	private Vector TouchCenter = Vector.Create();

	// Token: 0x04009A00 RID: 39424
	private Dictionary<int, InputDistributeDefine.ITouchData> TouchMap = new Dictionary<int, InputDistributeDefine.ITouchData>();

	// Token: 0x02007E7C RID: 32380
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028EC4 RID: 167620
		public const int ItemCaption = 0;

		// Token: 0x04028EC5 RID: 167621
		public const int ItemScaleBar = 1;

		// Token: 0x04028EC6 RID: 167622
		public const int BtnIncrease = 2;

		// Token: 0x04028EC7 RID: 167623
		public const int BtnReduce = 3;

		// Token: 0x04028EC8 RID: 167624
		public const int SliderScale = 4;

		// Token: 0x04028EC9 RID: 167625
		public const int ScrollQuests = 5;

		// Token: 0x04028ECA RID: 167626
		public const int LayoutContent = 6;

		// Token: 0x04028ECB RID: 167627
		public const int ItemNode = 7;

		// Token: 0x04028ECC RID: 167628
		public const int TextureRegionIcon = 8;

		// Token: 0x04028ECD RID: 167629
		public const int TextChapterTitle = 9;

		// Token: 0x04028ECE RID: 167630
		public const int TextChapterName = 10;

		// Token: 0x04028ECF RID: 167631
		public const int TextureBg = 11;

		// Token: 0x04028ED0 RID: 167632
		public const int ItemStartNode = 12;

		// Token: 0x04028ED1 RID: 167633
		public const int BtnPick = 13;

		// Token: 0x04028ED2 RID: 167634
		public const int BtnLocate = 14;

		// Token: 0x04028ED3 RID: 167635
		public const int Draggable = 15;

		// Token: 0x04028ED4 RID: 167636
		public const int ScrollBar = 16;

		// Token: 0x04028ED5 RID: 167637
		public const int ItemBlurOverride = 17;
	}
}
