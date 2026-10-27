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

// Token: 0x020026B5 RID: 9909
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestTreePictureNodeItem : QuestTreeNodeItemBase<QuestTreeNodeData>
{
	// Token: 0x17001A53 RID: 6739
	// (get) Token: 0x060144D6 RID: 83158 RVA: 0x00521B8E File Offset: 0x0051FD8E
	public override EQuestTreeNodeType Type
	{
		get
		{
			return EQuestTreeNodeType.Picture;
		}
	}

	// Token: 0x060144D7 RID: 83159 RVA: 0x00521B94 File Offset: 0x0051FD94
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

	// Token: 0x060144D8 RID: 83160 RVA: 0x005220DC File Offset: 0x005202DC
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

	// Token: 0x060144D9 RID: 83161 RVA: 0x00522230 File Offset: 0x00520430
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

	// Token: 0x060144DA RID: 83162 RVA: 0x005222E8 File Offset: 0x005204E8
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

	// Token: 0x060144DB RID: 83163 RVA: 0x00522333 File Offset: 0x00520533
	public override void UpdateData(QuestTreeNodeData data)
	{
		this.UpdateDataAsync(data);
	}

	// Token: 0x060144DC RID: 83164 RVA: 0x00522340 File Offset: 0x00520540
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

	// Token: 0x060144DD RID: 83165 RVA: 0x0052238B File Offset: 0x0052058B
	public override void Refresh(QuestTreeNodeData data, bool isSelected, int gridIndex)
	{
		this.UpdateData(data);
	}

	// Token: 0x060144DE RID: 83166 RVA: 0x00522394 File Offset: 0x00520594
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

	// Token: 0x060144DF RID: 83167 RVA: 0x005223E0 File Offset: 0x005205E0
	public override float GetAdditionalHeight()
	{
		QuestTreeNodeData nextQuestNode = this.Data.NextQuestNode;
		if (nextQuestNode != null && nextQuestNode.Config.NodeType == 3 && this.Child != null)
		{
			return (this.Child as QuestTreeNodeItemBase<QuestTreeNodeData>).GetAdditionalHeight() + base.GetExtendToggle(0).GetRootComponent().GetHeight();
		}
		return 0f;
	}

	// Token: 0x060144E0 RID: 83168 RVA: 0x00522444 File Offset: 0x00520644
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

	// Token: 0x060144E1 RID: 83169 RVA: 0x00522496 File Offset: 0x00520696
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

	// Token: 0x060144E2 RID: 83170 RVA: 0x005224AC File Offset: 0x005206AC
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

	// Token: 0x060144E3 RID: 83171 RVA: 0x005225A0 File Offset: 0x005207A0
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

	// Token: 0x060144E4 RID: 83172 RVA: 0x005225EC File Offset: 0x005207EC
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

	// Token: 0x060144E5 RID: 83173 RVA: 0x00522638 File Offset: 0x00520838
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

	// Token: 0x060144E6 RID: 83174 RVA: 0x00522684 File Offset: 0x00520884
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

	// Token: 0x060144E7 RID: 83175 RVA: 0x005226D0 File Offset: 0x005208D0
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

	// Token: 0x060144E8 RID: 83176 RVA: 0x0052278C File Offset: 0x0052098C
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

	// Token: 0x060144E9 RID: 83177 RVA: 0x005228D8 File Offset: 0x00520AD8
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

	// Token: 0x060144EA RID: 83178 RVA: 0x0052292C File Offset: 0x00520B2C
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

	// Token: 0x060144EB RID: 83179 RVA: 0x005229A1 File Offset: 0x00520BA1
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

	// Token: 0x060144EC RID: 83180 RVA: 0x005229D6 File Offset: 0x00520BD6
	private void OnDataUpdate(QuestTreeNodeData data)
	{
		if (data != this.Data)
		{
			return;
		}
		this.RefreshInfo(data);
	}

	// Token: 0x060144ED RID: 83181 RVA: 0x005229E9 File Offset: 0x00520BE9
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

	// Token: 0x060144EE RID: 83182 RVA: 0x00522A10 File Offset: 0x00520C10
	private void OnUpdateNode()
	{
		if (this.Data != null)
		{
			this.RefreshInfo(this.Data);
		}
	}

	// Token: 0x040098BA RID: 39098
	private const float EPS = 1f;

	// Token: 0x040098BB RID: 39099
	private QuestTreeNodeData Data;

	// Token: 0x040098BC RID: 39100
	private GenericLayout<QuestTreeNodeItemBase<List<QuestTreeNodeData>>, List<QuestTreeNodeData>> LayoutChildrenGroup;

	// Token: 0x040098BD RID: 39101
	private GenericLayout<QuestTreeNodeItemBase<List<QuestTreeNodeData>>, List<QuestTreeNodeData>> LayoutChildrenGroupUp;

	// Token: 0x040098BE RID: 39102
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x040098BF RID: 39103
	[Nullable(2)]
	private IQuestTreeNodeItem Child;

	// Token: 0x040098C0 RID: 39104
	public float OriginalTopHeight;

	// Token: 0x040098C1 RID: 39105
	public float OriginalBottomHeight;

	// Token: 0x040098C2 RID: 39106
	private float OriginalAdditionalHeight;

	// Token: 0x040098C3 RID: 39107
	private int TickId = -1;

	// Token: 0x02008D00 RID: 36096
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DBF8 RID: 187384
		public const int ToggleQuest = 0;

		// Token: 0x0402DBF9 RID: 187385
		public const int TextureQuest = 1;

		// Token: 0x0402DBFA RID: 187386
		public const int ItemLock = 2;

		// Token: 0x0402DBFB RID: 187387
		public const int ItemFinish = 3;

		// Token: 0x0402DBFC RID: 187388
		public const int ItemAvailable = 4;

		// Token: 0x0402DBFD RID: 187389
		public const int ItemTrack = 5;

		// Token: 0x0402DBFE RID: 187390
		public const int ItemInProgress = 6;

		// Token: 0x0402DBFF RID: 187391
		public const int SpriteType = 7;

		// Token: 0x0402DC00 RID: 187392
		public const int TextName = 8;

		// Token: 0x0402DC01 RID: 187393
		public const int ItemNew = 9;

		// Token: 0x0402DC02 RID: 187394
		public const int ItemLeftLineDown = 10;

		// Token: 0x0402DC03 RID: 187395
		public const int ItemLeftLineUp = 11;

		// Token: 0x0402DC04 RID: 187396
		public const int ItemMainLine = 12;

		// Token: 0x0402DC05 RID: 187397
		public const int ItemChildNodeAreaUp = 13;

		// Token: 0x0402DC06 RID: 187398
		public const int SprintTopLineTypeA = 14;

		// Token: 0x0402DC07 RID: 187399
		public const int SprintTopLineTypeB = 15;

		// Token: 0x0402DC08 RID: 187400
		public const int ItemChildNodeParentUp = 16;

		// Token: 0x0402DC09 RID: 187401
		public const int ItemChildNodeAreaDown = 17;

		// Token: 0x0402DC0A RID: 187402
		public const int LayoutChildNodeParentDown = 18;

		// Token: 0x0402DC0B RID: 187403
		public const int ItemChildNodeGroupTemplate = 19;

		// Token: 0x0402DC0C RID: 187404
		public const int ItemNextNodeAreaDownForSeries = 20;

		// Token: 0x0402DC0D RID: 187405
		public const int ItemNextNodeParentDownForSeries = 21;

		// Token: 0x0402DC0E RID: 187406
		public const int ItemNextNodeAreaDownForPicture = 22;

		// Token: 0x0402DC0F RID: 187407
		public const int ItemNextNodeParentDownForPicture = 23;

		// Token: 0x0402DC10 RID: 187408
		public const int ItemNextNodeAreaDownForText = 24;

		// Token: 0x0402DC11 RID: 187409
		public const int ItemNextNodeParentDownForText = 25;

		// Token: 0x0402DC12 RID: 187410
		public const int ItemNextNodeAreaParallelForPicture = 26;

		// Token: 0x0402DC13 RID: 187411
		public const int ItemNextNodeParentParallelForPicture = 27;

		// Token: 0x0402DC14 RID: 187412
		public const int ItemNextNodeAreaParallelForOther = 28;

		// Token: 0x0402DC15 RID: 187413
		public const int ItemNextNodeParentParallelForOther = 29;

		// Token: 0x0402DC16 RID: 187414
		public const int ItemRightLineShort = 30;

		// Token: 0x0402DC17 RID: 187415
		public const int ItemRightLineUp = 31;

		// Token: 0x0402DC18 RID: 187416
		public const int ItemSizeControlTop = 32;

		// Token: 0x0402DC19 RID: 187417
		public const int ItemSizeControlBottom = 33;

		// Token: 0x0402DC1A RID: 187418
		public const int SizeLine = 34;

		// Token: 0x0402DC1B RID: 187419
		public const int RecallingItem = 35;

		// Token: 0x0402DC1C RID: 187420
		public const int InRecallProgressItem = 36;
	}
}
