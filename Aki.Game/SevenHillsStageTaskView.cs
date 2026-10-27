using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012B0 RID: 4784
[NullableContext(1)]
[Nullable(0)]
public class SevenHillsStageTaskView : UiViewBase
{
	// Token: 0x17000B30 RID: 2864
	// (get) Token: 0x0600836F RID: 33647 RVA: 0x001BFEB7 File Offset: 0x001BE0B7
	protected virtual bool IsRefreshNow
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06008370 RID: 33648 RVA: 0x001BFEBA File Offset: 0x001BE0BA
	public SevenHillsStageTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008371 RID: 33649 RVA: 0x001BFEC4 File Offset: 0x001BE0C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickPre));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickNext));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008372 RID: 33650 RVA: 0x001C00BC File Offset: 0x001BE2BC
	protected override UniTask OnBeforeStartAsync()
	{
		SevenHillsStageTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SevenHillsStageTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008373 RID: 33651 RVA: 0x001C0100 File Offset: 0x001BE300
	protected virtual void RefreshTitleIcon()
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("SevenHillsIconPath");
		if (!string.IsNullOrEmpty(stringConfig))
		{
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetTitleIcon(stringConfig);
		}
	}

	// Token: 0x06008374 RID: 33652 RVA: 0x001C0134 File Offset: 0x001BE334
	protected override void OnBeforeShow()
	{
		ActivityController.Instance.CheckIsActivityClose(null, new int?(this.ActivityBaseData.Id));
		this.RefreshView();
	}

	// Token: 0x06008375 RID: 33653 RVA: 0x001C016A File Offset: 0x001BE36A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTasks));
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06008376 RID: 33654 RVA: 0x001C01A4 File Offset: 0x001BE3A4
	protected void RefreshView()
	{
		this.PageDotLayout.GetLayoutItemByIndex(this.CurrentIndex).UpdateShow(false);
		this.CurrentIndex = this.NextSelectedIndex;
		this.PageDotLayout.GetLayoutItemByIndex(this.CurrentIndex).UpdateShow(true);
		int num = this.ActivityBaseData.StageIds[this.CurrentIndex];
		LongShanStage value = ConfigLongShanStageById.GetConfig(num, true).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.TitleDetail, Array.Empty<object>());
		this.SetSpriteByPath(value.RomeNumSprite, base.GetSprite(2), false, null, null);
		base.SetTextureByPath(value.Picture, base.GetTexture(1), null, null);
		base.GetButton(8).RootUIComp.Get().SetUIActive(this.CurrentIndex > 0);
		base.GetButton(7).RootUIComp.Get().SetUIActive(this.CurrentIndex < this.ActivityBaseData.StageIds.Length - 1);
		this.RefreshTasks();
		this.ActivityBaseData.SaveNewStageFlag(num);
	}

	// Token: 0x06008377 RID: 33655 RVA: 0x001C02D0 File Offset: 0x001BE4D0
	private void RefreshTasks()
	{
		ActivityLongShanData activityBaseData = this.ActivityBaseData;
		int id = activityBaseData.StageIds[this.CurrentIndex];
		int progress = activityBaseData.GetProgress(id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "LongShanStage_ProgressPercentage", new <>z__ReadOnlySingleElementList<object>(progress));
		List<LongShanTaskInfo> list = activityBaseData.GetStageInfoByIdIncludeLock(id).Tasks.ToList<LongShanTaskInfo>();
		list.Sort(new Comparison<LongShanTaskInfo>(this.ActivityBaseData.TaskSort));
		this.TaskLayout.RefreshByData(list, null, true);
	}

	// Token: 0x06008378 RID: 33656 RVA: 0x001C0350 File Offset: 0x001BE550
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTasks));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06008379 RID: 33657 RVA: 0x001C038C File Offset: 0x001BE58C
	private void OnRefreshTasks(int activityId)
	{
		ActivityLongShanData activityBaseData = this.ActivityBaseData;
		int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
		if (activityId == num.GetValueOrDefault() & num != null)
		{
			this.RefreshTasks();
		}
	}

	// Token: 0x0600837A RID: 33658 RVA: 0x001C03D3 File Offset: 0x001BE5D3
	private void OnClickPre()
	{
		this.NextSelectedIndex = this.CurrentIndex - 1;
		base.PlaySequence("SwitchLeft", null, false);
		if (this.IsRefreshNow)
		{
			this.RefreshView();
		}
	}

	// Token: 0x0600837B RID: 33659 RVA: 0x001C0400 File Offset: 0x001BE600
	private void OnClickNext()
	{
		int stageId = this.ActivityBaseData.StageIds[this.CurrentIndex + 1];
		if (this.ActivityBaseData.IsStageUnlock(stageId))
		{
			this.NextSelectedIndex = this.CurrentIndex + 1;
			base.PlaySequence("SwitchRight", null, false);
			if (this.IsRefreshNow)
			{
				this.RefreshView();
				return;
			}
		}
		else
		{
			ActivityLongShanController.Instance.ShowUnlockTip(stageId);
		}
	}

	// Token: 0x0600837C RID: 33660 RVA: 0x001C0465 File Offset: 0x001BE665
	private LongShanTaskItem CreateTaskItem()
	{
		return new LongShanTaskItem();
	}

	// Token: 0x0600837D RID: 33661 RVA: 0x001C046C File Offset: 0x001BE66C
	private PageDot<int> InitPageDot()
	{
		return new PageDot<int>();
	}

	// Token: 0x0600837E RID: 33662 RVA: 0x001C0473 File Offset: 0x001BE673
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Enter" && !this.IsRefreshNow)
		{
			this.RefreshView();
		}
	}

	// Token: 0x04003B33 RID: 15155
	[Nullable(2)]
	protected ActivityLongShanData ActivityBaseData;

	// Token: 0x04003B34 RID: 15156
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<LongShanTaskItem, LongShanTaskInfo> TaskLayout;

	// Token: 0x04003B35 RID: 15157
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<PageDot<int>, int> PageDotLayout;

	// Token: 0x04003B36 RID: 15158
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003B37 RID: 15159
	protected int CurrentIndex;

	// Token: 0x04003B38 RID: 15160
	protected int NextSelectedIndex;

	// Token: 0x020078D2 RID: 30930
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027CE4 RID: 163044
		public const int ItemCaption = 0;

		// Token: 0x04027CE5 RID: 163045
		public const int TextureImage = 1;

		// Token: 0x04027CE6 RID: 163046
		public const int SpriteRomeNum = 2;

		// Token: 0x04027CE7 RID: 163047
		public const int TextName = 3;

		// Token: 0x04027CE8 RID: 163048
		public const int TextProgress = 4;

		// Token: 0x04027CE9 RID: 163049
		public const int LayoutTask = 5;

		// Token: 0x04027CEA RID: 163050
		public const int ItemTask = 6;

		// Token: 0x04027CEB RID: 163051
		public const int BtnArrrowRight = 7;

		// Token: 0x04027CEC RID: 163052
		public const int BtnArrrowLeft = 8;

		// Token: 0x04027CED RID: 163053
		public const int LayoutPageDot = 9;

		// Token: 0x04027CEE RID: 163054
		public const int ItemPageDot = 10;
	}
}
