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

// Token: 0x02001111 RID: 4369
[NullableContext(1)]
[Nullable(0)]
public class AvignonStageTaskView : UiViewBase
{
	// Token: 0x0600723E RID: 29246 RVA: 0x00175C80 File Offset: 0x00173E80
	public AvignonStageTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600723F RID: 29247 RVA: 0x00175C94 File Offset: 0x00173E94
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickPre));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickNext));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007240 RID: 29248 RVA: 0x00175E8C File Offset: 0x0017408C
	protected override UniTask OnBeforeStartAsync()
	{
		AvignonStageTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AvignonStageTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007241 RID: 29249 RVA: 0x00175ECF File Offset: 0x001740CF
	private PageDot<int> InitPageDot()
	{
		return new PageDot<int>();
	}

	// Token: 0x06007242 RID: 29250 RVA: 0x00175ED6 File Offset: 0x001740D6
	private AvignonTaskItem CreateTaskItem()
	{
		return new AvignonTaskItem();
	}

	// Token: 0x06007243 RID: 29251 RVA: 0x00175EDD File Offset: 0x001740DD
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06007244 RID: 29252 RVA: 0x00175F17 File Offset: 0x00174117
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06007245 RID: 29253 RVA: 0x00175F54 File Offset: 0x00174154
	private void RefreshView()
	{
		this.PageDotLayout.GetLayoutItemByIndex(this.CurrentSelectedIndex).UpdateShow(false);
		this.CurrentSelectedIndex = this.NextSelectedIndex;
		this.PageDotLayout.GetLayoutItemByIndex(this.CurrentSelectedIndex).UpdateShow(true);
		base.GetButton(7).RootUIComp.Get().SetUIActive(this.CurrentSelectedIndex > 0);
		base.GetButton(6).RootUIComp.Get().SetUIActive(this.CurrentSelectedIndex < this.StageIdList.Count - 1);
		this.StageId = this.StageIdList[this.CurrentSelectedIndex];
		this.AvignonStageConf = AvignonConfig.Instance.GetStageConfigById(this.StageId);
		AvignonStageInfo avignonStageInfo = AvignonModel.Instance.GetAvignonStageInfo(this.StageId);
		this.RefreshTaskList(avignonStageInfo.GetTaskList(), true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), this.AvignonStageConf.Value.Title, Array.Empty<object>());
		string path = this.AvignonStageConf.Value.Icon;
		if (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female)
		{
			path = this.AvignonStageConf.Value.FemaleIcon;
		}
		base.SetTextureByPath(path, base.GetTexture(8), null, null);
		this.SetSpriteByPath(this.AvignonStageConf.Value.RomaIcon, base.GetSprite(9), false, null, null);
		AvignonModel.Instance.SaveNewStageFlag(this.StageId);
	}

	// Token: 0x06007246 RID: 29254 RVA: 0x001760F0 File Offset: 0x001742F0
	private void OnRefreshTaskLayout(int activityId)
	{
		if (AvignonModel.Instance.GetAvignonActivityId() == activityId)
		{
			AvignonStageInfo avignonStageInfo = AvignonModel.Instance.GetAvignonStageInfo(this.StageIdList[this.CurrentSelectedIndex]);
			this.RefreshTaskList(avignonStageInfo.GetTaskList(), false);
		}
	}

	// Token: 0x06007247 RID: 29255 RVA: 0x00176133 File Offset: 0x00174333
	private void RefreshTaskList(List<AvignonTaskData> data, bool playGridAnim = false)
	{
		this.RefreshStageTaskProgress();
		this.TaskLayout.RefreshByData(data, null, playGridAnim);
	}

	// Token: 0x06007248 RID: 29256 RVA: 0x0017614C File Offset: 0x0017434C
	private void RefreshStageTaskProgress()
	{
		AvignonStageInfo avignonStageInfo = AvignonModel.Instance.GetAvignonStageInfo(this.StageId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BlackCoastTheme_TaskCompleteProgress", new <>z__ReadOnlySingleElementList<object>(avignonStageInfo.GetTaskProgress()));
	}

	// Token: 0x06007249 RID: 29257 RVA: 0x00176190 File Offset: 0x00174390
	private void OnClickPre()
	{
		this.NextSelectedIndex = this.CurrentSelectedIndex - 1;
		base.PlaySequence("SwitchLeft", null, false);
	}

	// Token: 0x0600724A RID: 29258 RVA: 0x001761B0 File Offset: 0x001743B0
	private void OnClickNext()
	{
		int num = this.CurrentSelectedIndex + 1;
		int stageId = this.StageIdList[num];
		AvignonStageInfo avignonStageInfo = AvignonModel.Instance.GetAvignonStageInfo(stageId);
		if (avignonStageInfo.IsUnlock)
		{
			this.NextSelectedIndex = num;
			base.PlaySequence("SwitchRight", null, false);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId(avignonStageInfo.GetLockConditionText(), Array.Empty<object>());
	}

	// Token: 0x0600724B RID: 29259 RVA: 0x00176211 File Offset: 0x00174411
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600724C RID: 29260 RVA: 0x0017621A File Offset: 0x0017441A
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "PageChange")
		{
			this.RefreshView();
		}
	}

	// Token: 0x040034EB RID: 13547
	private int StageId;

	// Token: 0x040034EC RID: 13548
	private AvignonStage? AvignonStageConf;

	// Token: 0x040034ED RID: 13549
	private int CurrentSelectedIndex;

	// Token: 0x040034EE RID: 13550
	private List<int> StageIdList = new List<int>();

	// Token: 0x040034EF RID: 13551
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040034F0 RID: 13552
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PageDot<int>, int> PageDotLayout;

	// Token: 0x040034F1 RID: 13553
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AvignonTaskItem, AvignonTaskData> TaskLayout;

	// Token: 0x040034F2 RID: 13554
	private int NextSelectedIndex;

	// Token: 0x020076D4 RID: 30420
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027361 RID: 160609
		public const int ItemCaption = 0;

		// Token: 0x04027362 RID: 160610
		public const int TxtFinishPercent = 1;

		// Token: 0x04027363 RID: 160611
		public const int LayoutTaskContent = 2;

		// Token: 0x04027364 RID: 160612
		public const int ItemTask = 3;

		// Token: 0x04027365 RID: 160613
		public const int LayoutPageDotContent = 4;

		// Token: 0x04027366 RID: 160614
		public const int ItemPageDot = 5;

		// Token: 0x04027367 RID: 160615
		public const int BtnArrrowRight = 6;

		// Token: 0x04027368 RID: 160616
		public const int BtnArrrowLeft = 7;

		// Token: 0x04027369 RID: 160617
		public const int TextureIcon = 8;

		// Token: 0x0402736A RID: 160618
		public const int SpriteRoma = 9;

		// Token: 0x0402736B RID: 160619
		public const int TxtStageName = 10;
	}
}
