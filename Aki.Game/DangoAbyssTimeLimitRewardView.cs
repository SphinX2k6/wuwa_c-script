using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A60 RID: 6752
public class DangoAbyssTimeLimitRewardView : UiViewBase
{
	// Token: 0x0600C6CA RID: 50890 RVA: 0x002D3C19 File Offset: 0x002D1E19
	[NullableContext(1)]
	public DangoAbyssTimeLimitRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C6CB RID: 50891 RVA: 0x002D3C2C File Offset: 0x002D1E2C
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

	// Token: 0x0600C6CC RID: 50892 RVA: 0x002D3D9A File Offset: 0x002D1F9A
	public override bool GetLoopAudioEventSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x0600C6CD RID: 50893 RVA: 0x002D3DAC File Offset: 0x002D1FAC
	private void OnClickRewardBtn()
	{
		int? abyssLimitRewardRewardId = DangoAbyssConfig.Instance.GetAbyssLimitRewardRewardId();
		ItemController.Instance.OpenItemTipsByItemId(abyssLimitRewardRewardId.Value, true, null);
	}

	// Token: 0x0600C6CE RID: 50894 RVA: 0x002D3DD7 File Offset: 0x002D1FD7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRewardStateUpdate, new Action(this.RefreshRewardLayout));
	}

	// Token: 0x0600C6CF RID: 50895 RVA: 0x002D3DF5 File Offset: 0x002D1FF5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRewardStateUpdate, new Action(this.RefreshRewardLayout));
	}

	// Token: 0x0600C6D0 RID: 50896 RVA: 0x002D3E13 File Offset: 0x002D2013
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C6D1 RID: 50897 RVA: 0x002D3E1C File Offset: 0x002D201C
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

	// Token: 0x0600C6D2 RID: 50898 RVA: 0x002D3EB4 File Offset: 0x002D20B4
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

	// Token: 0x0600C6D3 RID: 50899 RVA: 0x002D3F10 File Offset: 0x002D2110
	private void RefreshRewardLayout()
	{
		IActivityRewardData[] taskActivityRewardDataList = this.CurrentData.Data.GetTaskActivityRewardDataList(1, this.CurrentTabId);
		this.LoopScrollView.RefreshByData(taskActivityRewardDataList.ToList<IActivityRewardData>(), false, null, true);
	}

	// Token: 0x0600C6D4 RID: 50900 RVA: 0x002D3F4C File Offset: 0x002D214C
	private void RefreshRewardTexture()
	{
		string abyssLimitRewardTexture = DangoAbyssConfig.Instance.GetAbyssLimitRewardTexture();
		base.SetTextureByPath(abyssLimitRewardTexture, base.GetTexture(2), null, null);
	}

	// Token: 0x0600C6D5 RID: 50901 RVA: 0x002D3F7C File Offset: 0x002D217C
	[NullableContext(1)]
	private DangoAbyssRewardItem CreateLoopItem()
	{
		return new DangoAbyssRewardItem();
	}

	// Token: 0x0600C6D6 RID: 50902 RVA: 0x002D3F83 File Offset: 0x002D2183
	protected override void OnBeforeShow()
	{
		this.RefreshTimeText();
		this.RefreshRewardLayout();
		this.RefreshRewardTexture();
	}

	// Token: 0x0600C6D7 RID: 50903 RVA: 0x002D3F97 File Offset: 0x002D2197
	protected override void OnBeforeDestroy()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x04005B97 RID: 23447
	private int CurrentTabId = 1;

	// Token: 0x04005B98 RID: 23448
	[Nullable(2)]
	private DangoAbyssTimeLimitViewData CurrentData;

	// Token: 0x04005B99 RID: 23449
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<DangoAbyssRewardItem, IActivityRewardData> LoopScrollView;

	// Token: 0x04005B9A RID: 23450
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x02007FAE RID: 32686
	private class EComponent
	{
		// Token: 0x04029B04 RID: 170756
		public const int BtnClose = 0;

		// Token: 0x04029B05 RID: 170757
		public const int RemainTimeText = 1;

		// Token: 0x04029B06 RID: 170758
		public const int RewardTexture = 2;

		// Token: 0x04029B07 RID: 170759
		public const int RewardDesc = 3;

		// Token: 0x04029B08 RID: 170760
		public const int LoopScroller = 4;

		// Token: 0x04029B09 RID: 170761
		public const int ScrollerItem = 5;

		// Token: 0x04029B0A RID: 170762
		public const int RewardBtn = 6;
	}
}
