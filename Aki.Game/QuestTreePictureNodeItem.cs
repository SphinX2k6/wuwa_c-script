using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BA0 RID: 7072
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestTreePictureNodeItem : QuestTreeNodeItemBase<QuestTreeNodeData>
{
	// Token: 0x17001A8B RID: 6795
	// (get) Token: 0x060119B8 RID: 72120 RVA: 0x005308C6 File Offset: 0x0052EAC6
	public override EQuestTreeNodeType Type
	{
		get
		{
			return EQuestTreeNodeType.Picture;
		}
	}

	// Token: 0x060119B9 RID: 72121 RVA: 0x005308CC File Offset: 0x0052EACC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 37;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(33, typeof(UUISizeControlByOther));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUISizeControlByOther));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(34, typeof(UUISizeControlByOther));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060119BA RID: 72122 RVA: 0x00530E14 File Offset: 0x0052F014
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(18);
		UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(16);
		if (verticalLayout == null || verticalLayout2 == null)
		{
			return;
		}
		this.LayoutChildrenGroup = new GenericLayout<QuestTreeNodeItemBase<List<QuestTreeNodeData>>, List<QuestTreeNodeData>>(verticalLayout, () => base.Loader.CreateLogicalNodeItem<List<QuestTreeNodeData>>(EQuestTreeNodeType.Container), null, true, true);
		this.LayoutChildrenGroupUp = new GenericLayout<QuestTreeNodeItemBase<List<QuestTreeNodeData>>, List<QuestTreeNodeData>>(verticalLayout2, () => base.Loader.CreateLogicalNodeItem<List<QuestTreeNodeData>>(EQuestTreeNodeType.Container), null, true, true);
		this.OriginalTopHeight = base.GetUiSizeControlByOther(32).GetAdditionalHeight();
		this.OriginalBottomHeight = base.GetUiSizeControlByOther(33).GetAdditionalHeight();
		base.GetItem(9).SetUIActive(false);
		this.OriginalAdditionalHeight = base.GetUiSizeControlByOther(34).GetAdditionalHeight();
		Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "QuestTreePictureNodeItem", ETickingGroup.TG_PrePhysics, true, 0, true);
		this.TickId = ((ticker != null) ? ticker.Id : -1);
		QuestTreeModel.Instance.ViewModelChapter.AddOnSelectedDataChange(new Action<QuestTreeNodeData>(this.OnSelectedDataChange));
		QuestTreeModel.Instance.ViewModelChapter.AddOnLocatingNode(new Action<QuestTreeNodeData, bool>(this.OnLocateToNode));
		QuestTreeModel.Instance.ViewModelChapter.AddOnUpdateNode(new Action(this.OnUpdateNode));
		EventSystem.Instance.Add(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x060119BB RID: 72123 RVA: 0x00530F68 File Offset: 0x0052F168
	protected override void OnBeforeDestroy()
	{
		if (this.TickId != -1)
		{
			TickSystem.Instance.Remove(this.TickId);
			this.TickId = -1;
		}
		EventSystem.Instance.Remove(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnUpdateNode(new Action(this.OnUpdateNode));
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnLocatingNode(new Action<QuestTreeNodeData, bool>(this.OnLocateToNode));
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnSelectedDataChange(new Action<QuestTreeNodeData>(this.OnSelectedDataChange));
		QuestTreeModel.Instance.ViewModelChapter.RemoveHeightBalanceValue(this.Data.Id);
	}

	// Token: 0x060119BC RID: 72124 RVA: 0x00531020 File Offset: 0x0052F220
	public override UniTask CreateSelf(UUIItem parent)
	{
		QuestTreePictureNodeItem.<CreateSelf>d__16 <CreateSelf>d__;
		<CreateSelf>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSelf>d__.<>4__this = this;
		<CreateSelf>d__.parent = parent;
		<CreateSelf>d__.<>1__state = -1;
		<CreateSelf>d__.<>t__builder.Start<QuestTreePictureNodeItem.<CreateSelf>d__16>(ref <CreateSelf>d__);
		return <CreateSelf>d__.<>t__builder.Task;
	}

	// Token: 0x060119BD RID: 72125 RVA: 0x0053106B File Offset: 0x0052F26B
	public override void UpdateData(QuestTreeNodeData data)
	{
		this.UpdateDataAsync(data);
	}

	// Token: 0x060119BE RID: 72126 RVA: 0x00531078 File Offset: 0x0052F278
	public UniTask UpdateDataAsync(QuestTreeNodeData data)
	{
		QuestTreePictureNodeItem.<UpdateDataAsync>d__18 <UpdateDataAsync>d__;
		<UpdateDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateDataAsync>d__.<>4__this = this;
		<UpdateDataAsync>d__.data = data;
		<UpdateDataAsync>d__.<>1__state = -1;
		<UpdateDataAsync>d__.<>t__builder.Start<QuestTreePictureNodeItem.<UpdateDataAsync>d__18>(ref <UpdateDataAsync>d__);
		return <UpdateDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060119BF RID: 72127 RVA: 0x005310C3 File Offset: 0x0052F2C3
	public override void Refresh(QuestTreeNodeData data, bool isSelected, int gridIndex)
	{
		this.UpdateData(data);
	}

	// Token: 0x060119C0 RID: 72128 RVA: 0x005310CC File Offset: 0x0052F2CC
	public override UniTask RefreshAsync(QuestTreeNodeData data, bool isSelected, int gridIndex)
	{
		QuestTreePictureNodeItem.<RefreshAsync>d__20 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<QuestTreePictureNodeItem.<RefreshAsync>d__20>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060119C1 RID: 72129 RVA: 0x00531118 File Offset: 0x0052F318
	public override float GetAdditionalHeight()
	{
		QuestTreeNodeData nextQuestNode = this.Data.NextQuestNode;
		if (nextQuestNode != null && nextQuestNode.Config.NodeType == 3 && this.Child != null)
		{
			return (this.Child as QuestTreeNodeItemBase<QuestTreeNodeData>).GetAdditionalHeight() + base.GetExtendToggle(0).GetRootComponent().GetHeight();
		}
		return 0f;
	}

	// Token: 0x060119C2 RID: 72130 RVA: 0x0053117C File Offset: 0x0052F37C
	protected override void LocateSelf(bool tween = true)
	{
		UUIItem rootComponent = base.GetExtendToggle(0).GetRootComponent();
		QuestTreeNodeLocatingHelper locatingHelper = QuestTreeModel.Instance.ViewModelChapter.LocatingHelper;
		if (locatingHelper != null)
		{
			locatingHelper.LocateToNode(rootComponent, tween, false);
		}
		this.SeqPlayer.PlayLevelSequenceByName("Jumpy", false, null, false);
	}

	// Token: 0x060119C3 RID: 72131 RVA: 0x005311CE File Offset: 0x0052F3CE
	[NullableContext(2)]
	public override UUIItem GetGuideFocusUiItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.GetRootComponent();
	}

	// Token: 0x060119C4 RID: 72132 RVA: 0x005311E4 File Offset: 0x0052F3E4
	private void RefreshInfo(QuestTreeNodeData data)
	{
		base.SetTextureByPath(data.ImageSmall, base.GetTexture(1), null, null);
		EQuestTreeNodeState displayState = data.DisplayState;
		base.GetItem(2).SetUIActive(!data.IsTracking && displayState == EQuestTreeNodeState.Locked);
		base.GetItem(3).SetUIActive(false);
		base.GetItem(4).SetUIActive(!data.IsTracking && displayState == EQuestTreeNodeState.Available);
		base.GetItem(5).SetUIActive(data.IsTracking);
		base.GetItem(6).SetUIActive(displayState == EQuestTreeNodeState.InProgress);
		this.SetSpriteByPath(data.TypeIconPath, base.GetSprite(7), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), data.Name, Array.Empty<object>());
		float height = base.GetExtendToggle(0).GetRootComponent().GetHeight();
		QuestTreeModel.Instance.ViewModelChapter.RecordToggleHeight(height);
	}

	// Token: 0x060119C5 RID: 72133 RVA: 0x005312D8 File Offset: 0x0052F4D8
	private void RefreshRecallInfo(QuestTreeNodeData data)
	{
		if (data.RecallId == 0 || data.State != EQuestTreeNodeState.Finished)
		{
			base.GetItem(36).SetUIActive(false);
			return;
		}
		bool uiactive = RecallQuestModel.Instance.IsRecallCanContinue(data.RecallId);
		base.GetItem(36).SetUIActive(uiactive);
	}

	// Token: 0x060119C6 RID: 72134 RVA: 0x00531324 File Offset: 0x0052F524
	private UniTask RefreshChildNode(QuestTreeNodeData data)
	{
		QuestTreePictureNodeItem.<RefreshChildNode>d__26 <RefreshChildNode>d__;
		<RefreshChildNode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshChildNode>d__.<>4__this = this;
		<RefreshChildNode>d__.data = data;
		<RefreshChildNode>d__.<>1__state = -1;
		<RefreshChildNode>d__.<>t__builder.Start<QuestTreePictureNodeItem.<RefreshChildNode>d__26>(ref <RefreshChildNode>d__);
		return <RefreshChildNode>d__.<>t__builder.Task;
	}

	// Token: 0x060119C7 RID: 72135 RVA: 0x00531370 File Offset: 0x0052F570
	private UniTask AttachNextNodeParallel(QuestTreeNodeData nextNode)
	{
		QuestTreePictureNodeItem.<AttachNextNodeParallel>d__27 <AttachNextNodeParallel>d__;
		<AttachNextNodeParallel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AttachNextNodeParallel>d__.<>4__this = this;
		<AttachNextNodeParallel>d__.nextNode = nextNode;
		<AttachNextNodeParallel>d__.<>1__state = -1;
		<AttachNextNodeParallel>d__.<>t__builder.Start<QuestTreePictureNodeItem.<AttachNextNodeParallel>d__27>(ref <AttachNextNodeParallel>d__);
		return <AttachNextNodeParallel>d__.<>t__builder.Task;
	}

	// Token: 0x060119C8 RID: 72136 RVA: 0x005313BC File Offset: 0x0052F5BC
	private UniTask AttachNextNodeDown(QuestTreeNodeData nextNode)
	{
		QuestTreePictureNodeItem.<AttachNextNodeDown>d__28 <AttachNextNodeDown>d__;
		<AttachNextNodeDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AttachNextNodeDown>d__.<>4__this = this;
		<AttachNextNodeDown>d__.nextNode = nextNode;
		<AttachNextNodeDown>d__.<>1__state = -1;
		<AttachNextNodeDown>d__.<>t__builder.Start<QuestTreePictureNodeItem.<AttachNextNodeDown>d__28>(ref <AttachNextNodeDown>d__);
		return <AttachNextNodeDown>d__.<>t__builder.Task;
	}

	// Token: 0x060119C9 RID: 72137 RVA: 0x00531408 File Offset: 0x0052F608
	private void FixSize()
	{
		if (this.Data.Config.QuestType != 1)
		{
			return;
		}
		UUISizeControlByOther uiSizeControlByOther = base.GetUiSizeControlByOther(33);
		UUISizeControlByOther uiSizeControlByOther2 = base.GetUiSizeControlByOther(32);
		float num = uiSizeControlByOther2.GetRootComponent().GetHeight() - uiSizeControlByOther2.GetAdditionalHeight();
		float num2 = uiSizeControlByOther.GetRootComponent().GetHeight() - uiSizeControlByOther.GetAdditionalHeight();
		float num3 = num2 - num;
		QuestTreeModel.Instance.ViewModelChapter.RecordHeightBalanceValue(this.Data.Id, num, num2);
		if (Math.Abs(num3) <= 1f)
		{
			return;
		}
		if (num3 > 0f)
		{
			uiSizeControlByOther2.SetAdditionalHeight(this.OriginalTopHeight + num + num3);
			return;
		}
		uiSizeControlByOther.SetAdditionalHeight(this.OriginalBottomHeight + num2 - num3);
	}

	// Token: 0x060119CA RID: 72138 RVA: 0x005314C4 File Offset: 0x0052F6C4
	private void HideAllChildArea()
	{
		base.GetItem(10).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		base.GetItem(12).SetUIActive(false);
		base.GetItem(13).SetUIActive(false);
		base.GetVerticalLayout(16).GetRootComponent().SetUIActive(false);
		base.GetItem(17).SetUIActive(false);
		base.GetVerticalLayout(18).GetRootComponent().SetUIActive(false);
		base.GetItem(19).SetUIActive(false);
		base.GetItem(14).SetUIActive(false);
		base.GetItem(15).SetUIActive(false);
		base.GetItem(31).SetUIActive(false);
		base.GetItem(30).SetUIActive(false);
		base.GetItem(20).SetUIActive(false);
		base.GetItem(21).SetUIActive(false);
		base.GetItem(22).SetUIActive(false);
		base.GetItem(23).SetUIActive(false);
		base.GetItem(24).SetUIActive(false);
		base.GetItem(25).SetUIActive(false);
		base.GetItem(26).SetUIActive(false);
		base.GetItem(27).SetUIActive(false);
		base.GetItem(28).SetUIActive(false);
		base.GetItem(29).SetUIActive(false);
	}

	// Token: 0x060119CB RID: 72139 RVA: 0x00531610 File Offset: 0x0052F810
	private void OnTick(float deltaTime)
	{
		this.FixSize();
		UUISizeControlByOther uiSizeControlByOther = base.GetUiSizeControlByOther(34);
		QuestTreeNodeItemBase<List<QuestTreeNodeData>> layoutItemByIndex = this.LayoutChildrenGroup.GetLayoutItemByIndex(this.LayoutChildrenGroup.GetDatas().Count - 1);
		if (layoutItemByIndex == null)
		{
			return;
		}
		uiSizeControlByOther.SetAdditionalHeight(this.OriginalAdditionalHeight - layoutItemByIndex.GetAdditionalHeight());
	}

	// Token: 0x060119CC RID: 72140 RVA: 0x00531664 File Offset: 0x0052F864
	private void OnClick(EToggleState _)
	{
		QuestTreeModel.Instance.ViewModelChapter.SelectData(this.Data);
		QuestTreeController.Instance.ReportClickNode(this.Data);
		if (this.Data.IsDummy)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("QuestTree_ToBeContinued", Array.Empty<object>());
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		QuestTreeController.Instance.OpenNodeDetailView(this.Data);
	}

	// Token: 0x060119CD RID: 72141 RVA: 0x005316D9 File Offset: 0x0052F8D9
	[NullableContext(2)]
	private void OnSelectedDataChange(QuestTreeNodeData data)
	{
		if (data != this.Data)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.LocateSelf(true);
	}

	// Token: 0x060119CE RID: 72142 RVA: 0x0053170E File Offset: 0x0052F90E
	private void OnDataUpdate(QuestTreeNodeData data)
	{
		if (data != this.Data)
		{
			return;
		}
		this.RefreshInfo(data);
	}

	// Token: 0x060119CF RID: 72143 RVA: 0x00531721 File Offset: 0x0052F921
	[NullableContext(2)]
	private void OnLocateToNode(QuestTreeNodeData data, bool tween)
	{
		if (data != this.Data)
		{
			return;
		}
		this.LocateSelf(tween);
		UiNavigationNewController.Instance.SetNavigationFocusForView(this.RootItem, true, false, false);
	}

	// Token: 0x060119D0 RID: 72144 RVA: 0x00531748 File Offset: 0x0052F948
	private void OnUpdateNode()
	{
		if (this.Data != null)
		{
			this.RefreshInfo(this.Data);
		}
	}

	// Token: 0x04009A12 RID: 39442
	private const float EPS = 1f;

	// Token: 0x04009A13 RID: 39443
	private QuestTreeNodeData Data;

	// Token: 0x04009A14 RID: 39444
	private GenericLayout<QuestTreeNodeItemBase<List<QuestTreeNodeData>>, List<QuestTreeNodeData>> LayoutChildrenGroup;

	// Token: 0x04009A15 RID: 39445
	private GenericLayout<QuestTreeNodeItemBase<List<QuestTreeNodeData>>, List<QuestTreeNodeData>> LayoutChildrenGroupUp;

	// Token: 0x04009A16 RID: 39446
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04009A17 RID: 39447
	[Nullable(2)]
	private IQuestTreeNodeItem Child;

	// Token: 0x04009A18 RID: 39448
	public float OriginalTopHeight;

	// Token: 0x04009A19 RID: 39449
	public float OriginalBottomHeight;

	// Token: 0x04009A1A RID: 39450
	private float OriginalAdditionalHeight;

	// Token: 0x04009A1B RID: 39451
	private int TickId = -1;

	// Token: 0x02007E89 RID: 32393
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028F0F RID: 167695
		public const int ToggleQuest = 0;

		// Token: 0x04028F10 RID: 167696
		public const int TextureQuest = 1;

		// Token: 0x04028F11 RID: 167697
		public const int ItemLock = 2;

		// Token: 0x04028F12 RID: 167698
		public const int ItemFinish = 3;

		// Token: 0x04028F13 RID: 167699
		public const int ItemAvailable = 4;

		// Token: 0x04028F14 RID: 167700
		public const int ItemTrack = 5;

		// Token: 0x04028F15 RID: 167701
		public const int ItemInProgress = 6;

		// Token: 0x04028F16 RID: 167702
		public const int SpriteType = 7;

		// Token: 0x04028F17 RID: 167703
		public const int TextName = 8;

		// Token: 0x04028F18 RID: 167704
		public const int ItemNew = 9;

		// Token: 0x04028F19 RID: 167705
		public const int ItemLeftLineDown = 10;

		// Token: 0x04028F1A RID: 167706
		public const int ItemLeftLineUp = 11;

		// Token: 0x04028F1B RID: 167707
		public const int ItemMainLine = 12;

		// Token: 0x04028F1C RID: 167708
		public const int ItemChildNodeAreaUp = 13;

		// Token: 0x04028F1D RID: 167709
		public const int SprintTopLineTypeA = 14;

		// Token: 0x04028F1E RID: 167710
		public const int SprintTopLineTypeB = 15;

		// Token: 0x04028F1F RID: 167711
		public const int ItemChildNodeParentUp = 16;

		// Token: 0x04028F20 RID: 167712
		public const int ItemChildNodeAreaDown = 17;

		// Token: 0x04028F21 RID: 167713
		public const int LayoutChildNodeParentDown = 18;

		// Token: 0x04028F22 RID: 167714
		public const int ItemChildNodeGroupTemplate = 19;

		// Token: 0x04028F23 RID: 167715
		public const int ItemNextNodeAreaDownForSeries = 20;

		// Token: 0x04028F24 RID: 167716
		public const int ItemNextNodeParentDownForSeries = 21;

		// Token: 0x04028F25 RID: 167717
		public const int ItemNextNodeAreaDownForPicture = 22;

		// Token: 0x04028F26 RID: 167718
		public const int ItemNextNodeParentDownForPicture = 23;

		// Token: 0x04028F27 RID: 167719
		public const int ItemNextNodeAreaDownForText = 24;

		// Token: 0x04028F28 RID: 167720
		public const int ItemNextNodeParentDownForText = 25;

		// Token: 0x04028F29 RID: 167721
		public const int ItemNextNodeAreaParallelForPicture = 26;

		// Token: 0x04028F2A RID: 167722
		public const int ItemNextNodeParentParallelForPicture = 27;

		// Token: 0x04028F2B RID: 167723
		public const int ItemNextNodeAreaParallelForOther = 28;

		// Token: 0x04028F2C RID: 167724
		public const int ItemNextNodeParentParallelForOther = 29;

		// Token: 0x04028F2D RID: 167725
		public const int ItemRightLineShort = 30;

		// Token: 0x04028F2E RID: 167726
		public const int ItemRightLineUp = 31;

		// Token: 0x04028F2F RID: 167727
		public const int ItemSizeControlTop = 32;

		// Token: 0x04028F30 RID: 167728
		public const int ItemSizeControlBottom = 33;

		// Token: 0x04028F31 RID: 167729
		public const int SizeLine = 34;

		// Token: 0x04028F32 RID: 167730
		public const int RecallingItem = 35;

		// Token: 0x04028F33 RID: 167731
		public const int InRecallProgressItem = 36;
	}
}
