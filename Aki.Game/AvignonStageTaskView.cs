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

// Token: 0x020005C5 RID: 1477
[NullableContext(1)]
[Nullable(0)]
public class AvignonStageTaskView : UiViewBase
{
	// Token: 0x060045D4 RID: 17876 RVA: 0x0017E63C File Offset: 0x0017C83C
	public AvignonStageTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060045D5 RID: 17877 RVA: 0x0017E650 File Offset: 0x0017C850
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

	// Token: 0x060045D6 RID: 17878 RVA: 0x0017E848 File Offset: 0x0017CA48
	protected override UniTask OnBeforeStartAsync()
	{
		AvignonStageTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AvignonStageTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060045D7 RID: 17879 RVA: 0x0017E88B File Offset: 0x0017CA8B
	private PageDot<int> InitPageDot()
	{
		return new PageDot<int>();
	}

	// Token: 0x060045D8 RID: 17880 RVA: 0x0017E892 File Offset: 0x0017CA92
	private AvignonTaskItem CreateTaskItem()
	{
		return new AvignonTaskItem();
	}

	// Token: 0x060045D9 RID: 17881 RVA: 0x0017E899 File Offset: 0x0017CA99
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x060045DA RID: 17882 RVA: 0x0017E8D3 File Offset: 0x0017CAD3
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x060045DB RID: 17883 RVA: 0x0017E910 File Offset: 0x0017CB10
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

	// Token: 0x060045DC RID: 17884 RVA: 0x0017EAAC File Offset: 0x0017CCAC
	private void OnRefreshTaskLayout(int activityId)
	{
		if (AvignonModel.Instance.GetAvignonActivityId() == activityId)
		{
			AvignonStageInfo avignonStageInfo = AvignonModel.Instance.GetAvignonStageInfo(this.StageIdList[this.CurrentSelectedIndex]);
			this.RefreshTaskList(avignonStageInfo.GetTaskList(), false);
		}
	}

	// Token: 0x060045DD RID: 17885 RVA: 0x0017EAEF File Offset: 0x0017CCEF
	private void RefreshTaskList(List<AvignonTaskData> data, bool playGridAnim = false)
	{
		this.RefreshStageTaskProgress();
		this.TaskLayout.RefreshByData(data, null, playGridAnim);
	}

	// Token: 0x060045DE RID: 17886 RVA: 0x0017EB08 File Offset: 0x0017CD08
	private void RefreshStageTaskProgress()
	{
		AvignonStageInfo avignonStageInfo = AvignonModel.Instance.GetAvignonStageInfo(this.StageId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BlackCoastTheme_TaskCompleteProgress", new <>z__ReadOnlySingleElementList<object>(avignonStageInfo.GetTaskProgress()));
	}

	// Token: 0x060045DF RID: 17887 RVA: 0x0017EB4C File Offset: 0x0017CD4C
	private void OnClickPre()
	{
		this.NextSelectedIndex = this.CurrentSelectedIndex - 1;
		base.PlaySequence("SwitchLeft", null, false);
	}

	// Token: 0x060045E0 RID: 17888 RVA: 0x0017EB6C File Offset: 0x0017CD6C
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

	// Token: 0x060045E1 RID: 17889 RVA: 0x0017EBCD File Offset: 0x0017CDCD
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060045E2 RID: 17890 RVA: 0x0017EBD6 File Offset: 0x0017CDD6
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "PageChange")
		{
			this.RefreshView();
		}
	}

	// Token: 0x04003584 RID: 13700
	private int StageId;

	// Token: 0x04003585 RID: 13701
	private AvignonStage? AvignonStageConf;

	// Token: 0x04003586 RID: 13702
	private int CurrentSelectedIndex;

	// Token: 0x04003587 RID: 13703
	private List<int> StageIdList = new List<int>();

	// Token: 0x04003588 RID: 13704
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003589 RID: 13705
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PageDot<int>, int> PageDotLayout;

	// Token: 0x0400358A RID: 13706
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AvignonTaskItem, AvignonTaskData> TaskLayout;

	// Token: 0x0400358B RID: 13707
	private int NextSelectedIndex;

	// Token: 0x02006868 RID: 26728
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040226AA RID: 140970
		public const int ItemCaption = 0;

		// Token: 0x040226AB RID: 140971
		public const int TxtFinishPercent = 1;

		// Token: 0x040226AC RID: 140972
		public const int LayoutTaskContent = 2;

		// Token: 0x040226AD RID: 140973
		public const int ItemTask = 3;

		// Token: 0x040226AE RID: 140974
		public const int LayoutPageDotContent = 4;

		// Token: 0x040226AF RID: 140975
		public const int ItemPageDot = 5;

		// Token: 0x040226B0 RID: 140976
		public const int BtnArrrowRight = 6;

		// Token: 0x040226B1 RID: 140977
		public const int BtnArrrowLeft = 7;

		// Token: 0x040226B2 RID: 140978
		public const int TextureIcon = 8;

		// Token: 0x040226B3 RID: 140979
		public const int SpriteRoma = 9;

		// Token: 0x040226B4 RID: 140980
		public const int TxtStageName = 10;
	}
}
