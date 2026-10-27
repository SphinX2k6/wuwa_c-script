using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026B6 RID: 9910
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestTreeSeriesNodeItem : QuestTreeNodeItemBase<QuestTreeNodeData>
{
	// Token: 0x17001A54 RID: 6740
	// (get) Token: 0x060144F2 RID: 83186 RVA: 0x00522A51 File Offset: 0x00520C51
	public override EQuestTreeNodeType Type
	{
		get
		{
			return EQuestTreeNodeType.Series;
		}
	}

	// Token: 0x060144F3 RID: 83187 RVA: 0x00522A54 File Offset: 0x00520C54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISizeControlByOther));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060144F4 RID: 83188 RVA: 0x00522CB0 File Offset: 0x00520EB0
	protected override void OnStart()
	{
		this.LayoutChildren = new GenericLayout<QuestTreeNodeItemBase<QuestTreeNodeData>, QuestTreeNodeData>(base.GetVerticalLayout(12), () => base.Loader.CreateLogicalNodeItem<QuestTreeNodeData>(EQuestTreeNodeType.Text), null, false, true);
		this.UiSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.InterpDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnInterpUpdate));
		this.OriginalAdditionalHeight = base.GetUiSizeControlByOther(14).GetAdditionalHeight();
		base.GetExtendToggle(0).bLockStateOnSelect = false;
		QuestTreeModel.Instance.ViewModelChapter.AddOnLocatingNode(new Action<QuestTreeNodeData, bool>(this.OnLocateToNode));
		QuestTreeModel.Instance.ViewModelChapter.AddOnUpdateNode(new Action(this.OnUpdateNode));
		EventSystem.Instance.Add(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnNodeUpdate));
	}

	// Token: 0x060144F5 RID: 83189 RVA: 0x00522D7C File Offset: 0x00520F7C
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnNodeUpdate));
		this.UiSequencePlayer.Clear();
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnUpdateNode(new Action(this.OnUpdateNode));
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnLocatingNode(new Action<QuestTreeNodeData, bool>(this.OnLocateToNode));
		if (this.InterpDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnInterpUpdate));
			this.InterpDelegate = null;
		}
	}

	// Token: 0x060144F6 RID: 83190 RVA: 0x00522E06 File Offset: 0x00521006
	public override UniTask CreateSelf(UUIItem parent)
	{
		return base.CreateThenShowByResourceIdAsync("UiItem_TaskTreeBranchTab", parent, false);
	}

	// Token: 0x060144F7 RID: 83191 RVA: 0x00522E18 File Offset: 0x00521018
	public override void UpdateData(QuestTreeNodeData data)
	{
		this.Data = data;
		bool flag;
		if (data.PreQuestNodes.Count != 0)
		{
			QuestTreeNodeData questTreeNodeData = data.PreQuestNodes[0];
			flag = (questTreeNodeData != null && questTreeNodeData.Config.QuestType == 1);
		}
		else
		{
			flag = true;
		}
		bool flag2 = flag;
		this.RefreshInfo(data);
		this.RefreshChildren(data.GetIncludeNodes(true));
		base.GetItem(10).SetUIActive(flag2);
		base.GetItem(9).SetUIActive(!flag2);
		this.SetSizeItemActive(true);
	}

	// Token: 0x060144F8 RID: 83192 RVA: 0x00522E9A File Offset: 0x0052109A
	public override float GetAdditionalHeight()
	{
		return base.GetRootItem().GetHeight();
	}

	// Token: 0x060144F9 RID: 83193 RVA: 0x00522EA7 File Offset: 0x005210A7
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

	// Token: 0x060144FA RID: 83194 RVA: 0x00522EBC File Offset: 0x005210BC
	private void RefreshInfo(QuestTreeNodeData data)
	{
		EQuestTreeNodeState displayState = data.DisplayState;
		base.GetItem(4).SetUIActive(!data.IsTracking && displayState == EQuestTreeNodeState.Locked);
		base.GetItem(1).SetUIActive(!data.IsTracking && displayState == EQuestTreeNodeState.Finished);
		base.GetItem(2).SetUIActive(!data.IsTracking && displayState == EQuestTreeNodeState.Available);
		base.GetItem(3).SetUIActive(data.IsTracking);
		base.GetItem(5).SetUIActive(!data.IsTracking && displayState == EQuestTreeNodeState.InProgress);
		this.SetSpriteByPath(data.TypeIconPath, base.GetSprite(6), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), data.Config.Name, Array.Empty<object>());
		ValueTuple<int, int> includeNodesProgress = data.GetIncludeNodesProgress();
		int item = includeNodesProgress.Item1;
		int item2 = includeNodesProgress.Item2;
		UUIText text = base.GetText(8);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060144FB RID: 83195 RVA: 0x00522FDD File Offset: 0x005211DD
	private void RefreshChildren(List<QuestTreeNodeData> data)
	{
		this.LayoutChildren.RefreshByData(data, null, true);
	}

	// Token: 0x060144FC RID: 83196 RVA: 0x00522FED File Offset: 0x005211ED
	private void OnToggleClick(EToggleState _)
	{
		this.HidingLayout = !this.HidingLayout;
		this.ShowHideChildren(this.HidingLayout).Forget();
	}

	// Token: 0x060144FD RID: 83197 RVA: 0x00523010 File Offset: 0x00521210
	private void OnLocateToNode(QuestTreeNodeData data, bool tween)
	{
		if (data != this.Data && ((data != null) ? data.BelongedNode : null) != this.Data)
		{
			return;
		}
		this.LocateSelf(tween);
		UiNavigationNewController.Instance.SetNavigationFocusForView(this.RootItem, true, false, false);
		if (data.IsTracking)
		{
			this.UiSequencePlayer.PlayLevelSequenceByName("Jumpy", false, null, false);
		}
	}

	// Token: 0x060144FE RID: 83198 RVA: 0x0052307C File Offset: 0x0052127C
	private UniTask ShowHideChildren(bool hide)
	{
		QuestTreeSeriesNodeItem.<ShowHideChildren>d__20 <ShowHideChildren>d__;
		<ShowHideChildren>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowHideChildren>d__.<>4__this = this;
		<ShowHideChildren>d__.hide = hide;
		<ShowHideChildren>d__.<>1__state = -1;
		<ShowHideChildren>d__.<>t__builder.Start<QuestTreeSeriesNodeItem.<ShowHideChildren>d__20>(ref <ShowHideChildren>d__);
		return <ShowHideChildren>d__.<>t__builder.Task;
	}

	// Token: 0x060144FF RID: 83199 RVA: 0x005230C7 File Offset: 0x005212C7
	private void SetSizeItemActive(bool active)
	{
		if (this.Data.IsLastNodeOfMainQuestChildren())
		{
			base.GetUiSizeControlByOther(14).GetRootComponent().SetUIActive(false);
			return;
		}
		base.GetUiSizeControlByOther(14).GetRootComponent().SetUIActive(active);
	}

	// Token: 0x06014500 RID: 83200 RVA: 0x005230FD File Offset: 0x005212FD
	private void OnNodeUpdate(QuestTreeNodeData node)
	{
		if (node != this.Data && ((node != null) ? node.BelongedNode : null) != this.Data)
		{
			return;
		}
		this.RefreshInfo(this.Data);
	}

	// Token: 0x06014501 RID: 83201 RVA: 0x00523129 File Offset: 0x00521329
	private void OnUpdateNode()
	{
		if (this.Data != null)
		{
			this.RefreshInfo(this.Data);
		}
	}

	// Token: 0x06014502 RID: 83202 RVA: 0x00523140 File Offset: 0x00521340
	private void StartExpandHeightInterpolation()
	{
		UUISizeControlByOther uiSizeControlByOther = base.GetUiSizeControlByOther(14);
		float num = -(base.GetVerticalLayout(12).GetRootComponent().GetHeight() + this.OriginalAdditionalHeight);
		float originalAdditionalHeight = this.OriginalAdditionalHeight;
		uiSizeControlByOther.SetAdditionalHeight(num);
		ULTweenBPLibrary.FloatTo(GlobalData.World, this.InterpDelegate, num, originalAdditionalHeight, 0.3f, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x06014503 RID: 83203 RVA: 0x0052319C File Offset: 0x0052139C
	private void StartShrinkHeightInterpolation()
	{
		float originalAdditionalHeight = this.OriginalAdditionalHeight;
		float endValue = -base.GetVerticalLayout(12).GetRootComponent().GetHeight();
		ULTweenBPLibrary.FloatTo(GlobalData.World, this.InterpDelegate, originalAdditionalHeight, endValue, 0.3f, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x06014504 RID: 83204 RVA: 0x005231E2 File Offset: 0x005213E2
	private void OnInterpUpdate(float value)
	{
		base.GetUiSizeControlByOther(14).SetAdditionalHeight(value);
	}

	// Token: 0x040098C4 RID: 39108
	private QuestTreeNodeData Data;

	// Token: 0x040098C5 RID: 39109
	private GenericLayout<QuestTreeNodeItemBase<QuestTreeNodeData>, QuestTreeNodeData> LayoutChildren;

	// Token: 0x040098C6 RID: 39110
	private bool HidingLayout;

	// Token: 0x040098C7 RID: 39111
	private LevelSequencePlayer UiSequencePlayer;

	// Token: 0x040098C8 RID: 39112
	[Nullable(2)]
	private FLTweenFloatSetterDynamic InterpDelegate;

	// Token: 0x040098C9 RID: 39113
	private float OriginalAdditionalHeight;

	// Token: 0x02008D07 RID: 36103
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DC3E RID: 187454
		public const int Toggle = 0;

		// Token: 0x0402DC3F RID: 187455
		public const int ItemFinish = 1;

		// Token: 0x0402DC40 RID: 187456
		public const int ItemAvailable = 2;

		// Token: 0x0402DC41 RID: 187457
		public const int ItemTracking = 3;

		// Token: 0x0402DC42 RID: 187458
		public const int ItemLock = 4;

		// Token: 0x0402DC43 RID: 187459
		public const int ItemInProgress = 5;

		// Token: 0x0402DC44 RID: 187460
		public const int SpriteTypeIcon = 6;

		// Token: 0x0402DC45 RID: 187461
		public const int TextName = 7;

		// Token: 0x0402DC46 RID: 187462
		public const int TextProgress = 8;

		// Token: 0x0402DC47 RID: 187463
		public const int ItemLeftLineParallel = 9;

		// Token: 0x0402DC48 RID: 187464
		public const int ItemLeftLineUp = 10;

		// Token: 0x0402DC49 RID: 187465
		public const int ItemChildren = 11;

		// Token: 0x0402DC4A RID: 187466
		public const int LayoutChildren = 12;

		// Token: 0x0402DC4B RID: 187467
		public const int ItemChild = 13;

		// Token: 0x0402DC4C RID: 187468
		public const int ItemSize = 14;
	}
}
