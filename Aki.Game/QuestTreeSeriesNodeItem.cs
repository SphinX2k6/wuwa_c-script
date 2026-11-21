using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BA1 RID: 7073
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestTreeSeriesNodeItem : QuestTreeNodeItemBase<QuestTreeNodeData>
{
	// Token: 0x17001A8C RID: 6796
	// (get) Token: 0x060119D4 RID: 72148 RVA: 0x00531789 File Offset: 0x0052F989
	public override EQuestTreeNodeType Type
	{
		get
		{
			return EQuestTreeNodeType.Series;
		}
	}

	// Token: 0x060119D5 RID: 72149 RVA: 0x0053178C File Offset: 0x0052F98C
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

	// Token: 0x060119D6 RID: 72150 RVA: 0x005319E8 File Offset: 0x0052FBE8
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

	// Token: 0x060119D7 RID: 72151 RVA: 0x00531AB4 File Offset: 0x0052FCB4
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

	// Token: 0x060119D8 RID: 72152 RVA: 0x00531B3E File Offset: 0x0052FD3E
	public override UniTask CreateSelf(UUIItem parent)
	{
		return base.CreateThenShowByResourceIdAsync("UiItem_TaskTreeBranchTab", parent, false);
	}

	// Token: 0x060119D9 RID: 72153 RVA: 0x00531B50 File Offset: 0x0052FD50
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

	// Token: 0x060119DA RID: 72154 RVA: 0x00531BD2 File Offset: 0x0052FDD2
	public override float GetAdditionalHeight()
	{
		return base.GetRootItem().GetHeight();
	}

	// Token: 0x060119DB RID: 72155 RVA: 0x00531BDF File Offset: 0x0052FDDF
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

	// Token: 0x060119DC RID: 72156 RVA: 0x00531BF4 File Offset: 0x0052FDF4
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

	// Token: 0x060119DD RID: 72157 RVA: 0x00531D15 File Offset: 0x0052FF15
	private void RefreshChildren(List<QuestTreeNodeData> data)
	{
		this.LayoutChildren.RefreshByData(data, null, true);
	}

	// Token: 0x060119DE RID: 72158 RVA: 0x00531D25 File Offset: 0x0052FF25
	private void OnToggleClick(EToggleState _)
	{
		this.HidingLayout = !this.HidingLayout;
		this.ShowHideChildren(this.HidingLayout).Forget();
	}

	// Token: 0x060119DF RID: 72159 RVA: 0x00531D48 File Offset: 0x0052FF48
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

	// Token: 0x060119E0 RID: 72160 RVA: 0x00531DB4 File Offset: 0x0052FFB4
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

	// Token: 0x060119E1 RID: 72161 RVA: 0x00531DFF File Offset: 0x0052FFFF
	private void SetSizeItemActive(bool active)
	{
		if (this.Data.IsLastNodeOfMainQuestChildren())
		{
			base.GetUiSizeControlByOther(14).GetRootComponent().SetUIActive(false);
			return;
		}
		base.GetUiSizeControlByOther(14).GetRootComponent().SetUIActive(active);
	}

	// Token: 0x060119E2 RID: 72162 RVA: 0x00531E35 File Offset: 0x00530035
	private void OnNodeUpdate(QuestTreeNodeData node)
	{
		if (node != this.Data && ((node != null) ? node.BelongedNode : null) != this.Data)
		{
			return;
		}
		this.RefreshInfo(this.Data);
	}

	// Token: 0x060119E3 RID: 72163 RVA: 0x00531E61 File Offset: 0x00530061
	private void OnUpdateNode()
	{
		if (this.Data != null)
		{
			this.RefreshInfo(this.Data);
		}
	}

	// Token: 0x060119E4 RID: 72164 RVA: 0x00531E78 File Offset: 0x00530078
	private void StartExpandHeightInterpolation()
	{
		UUISizeControlByOther uiSizeControlByOther = base.GetUiSizeControlByOther(14);
		float num = -(base.GetVerticalLayout(12).GetRootComponent().GetHeight() + this.OriginalAdditionalHeight);
		float originalAdditionalHeight = this.OriginalAdditionalHeight;
		uiSizeControlByOther.SetAdditionalHeight(num);
		ULTweenBPLibrary.FloatTo(GlobalData.World, this.InterpDelegate, num, originalAdditionalHeight, 0.3f, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x060119E5 RID: 72165 RVA: 0x00531ED4 File Offset: 0x005300D4
	private void StartShrinkHeightInterpolation()
	{
		float originalAdditionalHeight = this.OriginalAdditionalHeight;
		float endValue = -base.GetVerticalLayout(12).GetRootComponent().GetHeight();
		ULTweenBPLibrary.FloatTo(GlobalData.World, this.InterpDelegate, originalAdditionalHeight, endValue, 0.3f, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x060119E6 RID: 72166 RVA: 0x00531F1A File Offset: 0x0053011A
	private void OnInterpUpdate(float value)
	{
		base.GetUiSizeControlByOther(14).SetAdditionalHeight(value);
	}

	// Token: 0x04009A1C RID: 39452
	private QuestTreeNodeData Data;

	// Token: 0x04009A1D RID: 39453
	private GenericLayout<QuestTreeNodeItemBase<QuestTreeNodeData>, QuestTreeNodeData> LayoutChildren;

	// Token: 0x04009A1E RID: 39454
	private bool HidingLayout;

	// Token: 0x04009A1F RID: 39455
	private LevelSequencePlayer UiSequencePlayer;

	// Token: 0x04009A20 RID: 39456
	[Nullable(2)]
	private FLTweenFloatSetterDynamic InterpDelegate;

	// Token: 0x04009A21 RID: 39457
	private float OriginalAdditionalHeight;

	// Token: 0x02007E90 RID: 32400
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028F55 RID: 167765
		public const int Toggle = 0;

		// Token: 0x04028F56 RID: 167766
		public const int ItemFinish = 1;

		// Token: 0x04028F57 RID: 167767
		public const int ItemAvailable = 2;

		// Token: 0x04028F58 RID: 167768
		public const int ItemTracking = 3;

		// Token: 0x04028F59 RID: 167769
		public const int ItemLock = 4;

		// Token: 0x04028F5A RID: 167770
		public const int ItemInProgress = 5;

		// Token: 0x04028F5B RID: 167771
		public const int SpriteTypeIcon = 6;

		// Token: 0x04028F5C RID: 167772
		public const int TextName = 7;

		// Token: 0x04028F5D RID: 167773
		public const int TextProgress = 8;

		// Token: 0x04028F5E RID: 167774
		public const int ItemLeftLineParallel = 9;

		// Token: 0x04028F5F RID: 167775
		public const int ItemLeftLineUp = 10;

		// Token: 0x04028F60 RID: 167776
		public const int ItemChildren = 11;

		// Token: 0x04028F61 RID: 167777
		public const int LayoutChildren = 12;

		// Token: 0x04028F62 RID: 167778
		public const int ItemChild = 13;

		// Token: 0x04028F63 RID: 167779
		public const int ItemSize = 14;
	}
}
