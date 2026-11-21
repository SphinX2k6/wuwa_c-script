using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F1F RID: 3871
public class DangoAbyssTimeLimitRewardView : UiViewBase
{
	// Token: 0x06009ADA RID: 39642 RVA: 0x002DED15 File Offset: 0x002DCF15
	[NullableContext(1)]
	public DangoAbyssTimeLimitRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009ADB RID: 39643 RVA: 0x002DED28 File Offset: 0x002DCF28
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickRewardBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009ADC RID: 39644 RVA: 0x002DEE96 File Offset: 0x002DD096
	public override bool GetBgmSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x06009ADD RID: 39645 RVA: 0x002DEEA8 File Offset: 0x002DD0A8
	private void OnClickRewardBtn()
	{
		int? abyssLimitRewardRewardId = DangoAbyssConfig.Instance.GetAbyssLimitRewardRewardId();
		ItemController.Instance.OpenItemTipsByItemId(abyssLimitRewardRewardId.Value, true, null, false);
	}

	// Token: 0x06009ADE RID: 39646 RVA: 0x002DEED4 File Offset: 0x002DD0D4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRewardStateUpdate, new Action(this.RefreshRewardLayout));
	}

	// Token: 0x06009ADF RID: 39647 RVA: 0x002DEEF2 File Offset: 0x002DD0F2
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRewardStateUpdate, new Action(this.RefreshRewardLayout));
	}

	// Token: 0x06009AE0 RID: 39648 RVA: 0x002DEF10 File Offset: 0x002DD110
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009AE1 RID: 39649 RVA: 0x002DEF1C File Offset: 0x002DD11C
	protected override void OnStart()
	{
		this.CurrentData = (this.OpenParam as DangoAbyssTimeLimitViewData);
		int[] rewardTypeTabList = this.CurrentData.Data.GetRewardTypeTabList(1);
		if (rewardTypeTabList.Length != 0)
		{
			this.CurrentTabId = rewardTypeTabList[0];
		}
		this.LoopScrollView = new LoopScrollView<DangoAbyssRewardItem, IActivityRewardData>(base.GetLoopScrollViewComponent(4), base.GetItem(5).GetOwner() as AUIBaseActor, new Func<DangoAbyssRewardItem>(this.CreateLoopItem), false);
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.RefreshTimeText();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06009AE2 RID: 39650 RVA: 0x002DEFB4 File Offset: 0x002DD1B4
	private void RefreshTimeText()
	{
		if (this.CurrentData.Data.CheckInLimitTime())
		{
			string remainTimeText = this.CurrentData.Data.GetRemainTimeText();
			base.GetText(1).SetText(remainTimeText, true);
			base.GetText(1).SetUIActive(true);
			return;
		}
		base.GetText(1).SetUIActive(false);
	}

	// Token: 0x06009AE3 RID: 39651 RVA: 0x002DF010 File Offset: 0x002DD210
	private void RefreshRewardLayout()
	{
		IActivityRewardData[] taskActivityRewardDataList = this.CurrentData.Data.GetTaskActivityRewardDataList(1, this.CurrentTabId);
		this.LoopScrollView.RefreshByData(taskActivityRewardDataList, false, null, true);
	}

	// Token: 0x06009AE4 RID: 39652 RVA: 0x002DF044 File Offset: 0x002DD244
	private void RefreshRewardTexture()
	{
		string abyssLimitRewardTexture = DangoAbyssConfig.Instance.GetAbyssLimitRewardTexture();
		base.SetTextureByPath(abyssLimitRewardTexture, base.GetTexture(2), null, null);
	}

	// Token: 0x06009AE5 RID: 39653 RVA: 0x002DF074 File Offset: 0x002DD274
	[NullableContext(1)]
	private DangoAbyssRewardItem CreateLoopItem()
	{
		return new DangoAbyssRewardItem();
	}

	// Token: 0x06009AE6 RID: 39654 RVA: 0x002DF07B File Offset: 0x002DD27B
	protected override void OnBeforeShow()
	{
		this.RefreshTimeText();
		this.RefreshRewardLayout();
		this.RefreshRewardTexture();
	}

	// Token: 0x06009AE7 RID: 39655 RVA: 0x002DF08F File Offset: 0x002DD28F
	protected override void OnBeforeDestroy()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x04005C66 RID: 23654
	private int CurrentTabId = 1;

	// Token: 0x04005C67 RID: 23655
	[Nullable(2)]
	private DangoAbyssTimeLimitViewData CurrentData;

	// Token: 0x04005C68 RID: 23656
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<DangoAbyssRewardItem, IActivityRewardData> LoopScrollView;

	// Token: 0x04005C69 RID: 23657
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0200713D RID: 28989
	private class EComponent
	{
		// Token: 0x04024E41 RID: 151105
		public const int BtnClose = 0;

		// Token: 0x04024E42 RID: 151106
		public const int RemainTimeText = 1;

		// Token: 0x04024E43 RID: 151107
		public const int RewardTexture = 2;

		// Token: 0x04024E44 RID: 151108
		public const int RewardDesc = 3;

		// Token: 0x04024E45 RID: 151109
		public const int LoopScroller = 4;

		// Token: 0x04024E46 RID: 151110
		public const int ScrollerItem = 5;

		// Token: 0x04024E47 RID: 151111
		public const int RewardBtn = 6;
	}
}
