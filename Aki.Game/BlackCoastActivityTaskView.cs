using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011B0 RID: 4528
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastActivityTaskView : UiViewBase
{
	// Token: 0x0600781B RID: 30747 RVA: 0x001922EF File Offset: 0x001904EF
	public BlackCoastActivityTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600781C RID: 30748 RVA: 0x0019230C File Offset: 0x0019050C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickPre));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickNext));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600781D RID: 30749 RVA: 0x00192524 File Offset: 0x00190724
	protected override UniTask OnBeforeStartAsync()
	{
		BlackCoastActivityTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BlackCoastActivityTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600781E RID: 30750 RVA: 0x00192568 File Offset: 0x00190768
	private UniTask LoadMaterial()
	{
		BlackCoastActivityTaskView.<LoadMaterial>d__12 <LoadMaterial>d__;
		<LoadMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadMaterial>d__.<>4__this = this;
		<LoadMaterial>d__.<>1__state = -1;
		<LoadMaterial>d__.<>t__builder.Start<BlackCoastActivityTaskView.<LoadMaterial>d__12>(ref <LoadMaterial>d__);
		return <LoadMaterial>d__.<>t__builder.Task;
	}

	// Token: 0x0600781F RID: 30751 RVA: 0x001925AC File Offset: 0x001907AC
	protected override void OnBeforeShow()
	{
		ActivityController.Instance.CheckIsActivityClose(null, new int?(this.ActivityBaseData.Id));
	}

	// Token: 0x06007820 RID: 30752 RVA: 0x001925DC File Offset: 0x001907DC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
	}

	// Token: 0x06007821 RID: 30753 RVA: 0x001925FA File Offset: 0x001907FA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
	}

	// Token: 0x06007822 RID: 30754 RVA: 0x00192618 File Offset: 0x00190818
	protected override void OnBeforeDestroy()
	{
		MediaPlayer mediaPlayer = this.MediaPlayer;
		if (mediaPlayer != null)
		{
			mediaPlayer.Clear();
		}
		this.MediaPlayer = null;
		this.CancelLoad();
	}

	// Token: 0x06007823 RID: 30755 RVA: 0x00192638 File Offset: 0x00190838
	private void CancelLoad()
	{
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
			this.HandleId = -1;
		}
	}

	// Token: 0x06007824 RID: 30756 RVA: 0x0019265A File Offset: 0x0019085A
	private PageDot<int> InitPageDot()
	{
		return new PageDot<int>();
	}

	// Token: 0x06007825 RID: 30757 RVA: 0x00192661 File Offset: 0x00190861
	private BlackCoastTaskItem CreateTaskItem()
	{
		return new BlackCoastTaskItem();
	}

	// Token: 0x06007826 RID: 30758 RVA: 0x00192668 File Offset: 0x00190868
	private void OnRefreshTaskLayout(int activityId)
	{
		if (this.ActivityBaseData != null && this.ActivityBaseData.Id == activityId)
		{
			BlackCoastStageInfo stageById = this.ActivityBaseData.GetStageById(this.StageIdList[this.CurrentSelectedIndex]);
			this.RefreshStageInfo();
			this.RefreshTaskList(stageById.GetTaskList(), false);
		}
	}

	// Token: 0x06007827 RID: 30759 RVA: 0x001926BB File Offset: 0x001908BB
	private void OnClickPre()
	{
		this.RefreshView(this.CurrentSelectedIndex - 1);
	}

	// Token: 0x06007828 RID: 30760 RVA: 0x001926CC File Offset: 0x001908CC
	private void OnClickNext()
	{
		int index = this.CurrentSelectedIndex + 1;
		BlackCoastStageInfo stageById = this.ActivityBaseData.GetStageById(this.StageIdList[index]);
		if (stageById.IsUnlock)
		{
			this.RefreshView(index);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId(stageById.GetLockConditionText(), Array.Empty<object>());
	}

	// Token: 0x06007829 RID: 30761 RVA: 0x00192720 File Offset: 0x00190920
	private UniTask InitView(int index)
	{
		BlackCoastActivityTaskView.<InitView>d__23 <InitView>d__;
		<InitView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitView>d__.<>4__this = this;
		<InitView>d__.index = index;
		<InitView>d__.<>1__state = -1;
		<InitView>d__.<>t__builder.Start<BlackCoastActivityTaskView.<InitView>d__23>(ref <InitView>d__);
		return <InitView>d__.<>t__builder.Task;
	}

	// Token: 0x0600782A RID: 30762 RVA: 0x0019276C File Offset: 0x0019096C
	private UniTask RefreshView(int index)
	{
		BlackCoastActivityTaskView.<RefreshView>d__24 <RefreshView>d__;
		<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshView>d__.<>4__this = this;
		<RefreshView>d__.index = index;
		<RefreshView>d__.<>1__state = -1;
		<RefreshView>d__.<>t__builder.Start<BlackCoastActivityTaskView.<RefreshView>d__24>(ref <RefreshView>d__);
		return <RefreshView>d__.<>t__builder.Task;
	}

	// Token: 0x0600782B RID: 30763 RVA: 0x001927B8 File Offset: 0x001909B8
	private void RefreshStageInfo()
	{
		BlackCoastStageInfo stageById = this.ActivityBaseData.GetStageById(this.StageIdList[this.CurrentSelectedIndex]);
		BlackCoastThemeStageRe? stageConfig = ActivityBlackCoastConfig.Instance.GetStageConfig(stageById.StageId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "BlackCoastTheme_TaskCompleteProgress", new <>z__ReadOnlySingleElementList<object>(stageById.GetTaskProgress()));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), stageConfig.Value.TitleDetail, Array.Empty<object>());
	}

	// Token: 0x0600782C RID: 30764 RVA: 0x0019283F File Offset: 0x00190A3F
	private void RefreshTaskList(List<BlackCoastTaskData> data, bool playGridAnim = false)
	{
		this.TaskScroll.RefreshByData(data, null, playGridAnim);
	}

	// Token: 0x0600782D RID: 30765 RVA: 0x00192850 File Offset: 0x00190A50
	private void RefreshBg()
	{
		BlackCoastStageInfo stageById = this.ActivityBaseData.GetStageById(this.StageIdList[this.CurrentSelectedIndex]);
		this.MediaPlayer.PlayVideo(stageById.StageId.ToString(), stageById.GetVideoSource(), true);
	}

	// Token: 0x0600782E RID: 30766 RVA: 0x0019289A File Offset: 0x00190A9A
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x04003746 RID: 14150
	protected ActivityBlackCoastData ActivityBaseData;

	// Token: 0x04003747 RID: 14151
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003748 RID: 14152
	private GenericLayout<PageDot<int>, int> PageDotLayout;

	// Token: 0x04003749 RID: 14153
	private GenericLayout<BlackCoastTaskItem, BlackCoastTaskData> TaskScroll;

	// Token: 0x0400374A RID: 14154
	private List<int> StageIdList = new List<int>();

	// Token: 0x0400374B RID: 14155
	private int CurrentSelectedIndex;

	// Token: 0x0400374C RID: 14156
	private MediaPlayer MediaPlayer;

	// Token: 0x0400374D RID: 14157
	private int HandleId = -1;

	// Token: 0x02007792 RID: 30610
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040276D1 RID: 161489
		public const int Caption = 0;

		// Token: 0x040276D2 RID: 161490
		public const int PanelBg = 1;

		// Token: 0x040276D3 RID: 161491
		public const int DotLayout = 2;

		// Token: 0x040276D4 RID: 161492
		public const int Dot = 3;

		// Token: 0x040276D5 RID: 161493
		public const int TaskLayout = 4;

		// Token: 0x040276D6 RID: 161494
		public const int TaskItem = 5;

		// Token: 0x040276D7 RID: 161495
		public const int ButtonPre = 6;

		// Token: 0x040276D8 RID: 161496
		public const int ButtonNext = 7;

		// Token: 0x040276D9 RID: 161497
		public const int TextProgress = 8;

		// Token: 0x040276DA RID: 161498
		public const int CG = 9;

		// Token: 0x040276DB RID: 161499
		public const int TextName = 10;

		// Token: 0x040276DC RID: 161500
		public const int TextureIcon = 11;
	}
}
