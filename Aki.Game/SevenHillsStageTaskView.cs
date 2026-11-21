using System;
using System.Collections.Generic;
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

// Token: 0x02000764 RID: 1892
[NullableContext(1)]
[Nullable(0)]
public class SevenHillsStageTaskView : UiViewBase
{
	// Token: 0x17000B50 RID: 2896
	// (get) Token: 0x06005706 RID: 22278 RVA: 0x001C8C47 File Offset: 0x001C6E47
	protected virtual bool IsRefreshNow
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06005707 RID: 22279 RVA: 0x001C8C4A File Offset: 0x001C6E4A
	public SevenHillsStageTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005708 RID: 22280 RVA: 0x001C8C54 File Offset: 0x001C6E54
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

	// Token: 0x06005709 RID: 22281 RVA: 0x001C8E4C File Offset: 0x001C704C
	protected override UniTask OnBeforeStartAsync()
	{
		SevenHillsStageTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SevenHillsStageTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600570A RID: 22282 RVA: 0x001C8E90 File Offset: 0x001C7090
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

	// Token: 0x0600570B RID: 22283 RVA: 0x001C8EC4 File Offset: 0x001C70C4
	protected override void OnBeforeShow()
	{
		ActivityController.Instance.CheckIsActivityClose(null, new int?(this.ActivityBaseData.Id));
		this.RefreshView();
	}

	// Token: 0x0600570C RID: 22284 RVA: 0x001C8EFA File Offset: 0x001C70FA
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTasks));
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600570D RID: 22285 RVA: 0x001C8F34 File Offset: 0x001C7134
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

	// Token: 0x0600570E RID: 22286 RVA: 0x001C9060 File Offset: 0x001C7260
	private void RefreshTasks()
	{
		ActivityLongShanData activityBaseData = this.ActivityBaseData;
		int id = activityBaseData.StageIds[this.CurrentIndex];
		int progress = activityBaseData.GetProgress(id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "LongShanStage_ProgressPercentage", new <>z__ReadOnlySingleElementList<object>(progress));
		List<LongShanTaskInfo> list = new List<LongShanTaskInfo>(activityBaseData.GetStageInfoByIdIncludeLock(id).Tasks);
		list.Sort(new Comparison<LongShanTaskInfo>(this.ActivityBaseData.TaskSort));
		this.TaskLayout.RefreshByData(list, null, true);
	}

	// Token: 0x0600570F RID: 22287 RVA: 0x001C90E0 File Offset: 0x001C72E0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTasks));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06005710 RID: 22288 RVA: 0x001C911C File Offset: 0x001C731C
	private void OnRefreshTasks(int activityId)
	{
		ActivityLongShanData activityBaseData = this.ActivityBaseData;
		int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
		if (activityId == num.GetValueOrDefault() & num != null)
		{
			this.RefreshTasks();
		}
	}

	// Token: 0x06005711 RID: 22289 RVA: 0x001C9163 File Offset: 0x001C7363
	private void OnClickPre()
	{
		this.NextSelectedIndex = this.CurrentIndex - 1;
		base.PlaySequence("SwitchLeft", null, false);
		if (this.IsRefreshNow)
		{
			this.RefreshView();
		}
	}

	// Token: 0x06005712 RID: 22290 RVA: 0x001C9190 File Offset: 0x001C7390
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

	// Token: 0x06005713 RID: 22291 RVA: 0x001C91F5 File Offset: 0x001C73F5
	private LongShanTaskItem CreateTaskItem()
	{
		return new LongShanTaskItem();
	}

	// Token: 0x06005714 RID: 22292 RVA: 0x001C91FC File Offset: 0x001C73FC
	private PageDot<int> InitPageDot()
	{
		return new PageDot<int>();
	}

	// Token: 0x06005715 RID: 22293 RVA: 0x001C9203 File Offset: 0x001C7403
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Enter" && !this.IsRefreshNow)
		{
			this.RefreshView();
		}
	}

	// Token: 0x04003BCB RID: 15307
	[Nullable(2)]
	protected ActivityLongShanData ActivityBaseData;

	// Token: 0x04003BCC RID: 15308
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<LongShanTaskItem, LongShanTaskInfo> TaskLayout;

	// Token: 0x04003BCD RID: 15309
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<PageDot<int>, int> PageDotLayout;

	// Token: 0x04003BCE RID: 15310
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003BCF RID: 15311
	protected int CurrentIndex;

	// Token: 0x04003BD0 RID: 15312
	protected int NextSelectedIndex;

	// Token: 0x02006A5C RID: 27228
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023012 RID: 143378
		public const int ItemCaption = 0;

		// Token: 0x04023013 RID: 143379
		public const int TextureImage = 1;

		// Token: 0x04023014 RID: 143380
		public const int SpriteRomeNum = 2;

		// Token: 0x04023015 RID: 143381
		public const int TextName = 3;

		// Token: 0x04023016 RID: 143382
		public const int TextProgress = 4;

		// Token: 0x04023017 RID: 143383
		public const int LayoutTask = 5;

		// Token: 0x04023018 RID: 143384
		public const int ItemTask = 6;

		// Token: 0x04023019 RID: 143385
		public const int BtnArrrowRight = 7;

		// Token: 0x0402301A RID: 143386
		public const int BtnArrrowLeft = 8;

		// Token: 0x0402301B RID: 143387
		public const int LayoutPageDot = 9;

		// Token: 0x0402301C RID: 143388
		public const int ItemPageDot = 10;
	}
}
