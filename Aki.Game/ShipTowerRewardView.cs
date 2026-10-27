using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029CA RID: 10698
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerRewardView : UiViewBase
{
	// Token: 0x060162B6 RID: 90806 RVA: 0x0059B61D File Offset: 0x0059981D
	public ShipTowerRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060162B7 RID: 90807 RVA: 0x0059B630 File Offset: 0x00599830
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x060162B8 RID: 90808 RVA: 0x0059B6CC File Offset: 0x005998CC
	private void InitDataParam()
	{
		this.AreaList = ShipTowerModel.Instance.GetAreaList();
	}

	// Token: 0x060162B9 RID: 90809 RVA: 0x0059B6E0 File Offset: 0x005998E0
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRewardView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRewardView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060162BA RID: 90810 RVA: 0x0059B724 File Offset: 0x00599924
	private UniTask CheckIsNeedShowSeasonReview()
	{
		ShipTowerRewardView.<CheckIsNeedShowSeasonReview>d__12 <CheckIsNeedShowSeasonReview>d__;
		<CheckIsNeedShowSeasonReview>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckIsNeedShowSeasonReview>d__.<>1__state = -1;
		<CheckIsNeedShowSeasonReview>d__.<>t__builder.Start<ShipTowerRewardView.<CheckIsNeedShowSeasonReview>d__12>(ref <CheckIsNeedShowSeasonReview>d__);
		return <CheckIsNeedShowSeasonReview>d__.<>t__builder.Task;
	}

	// Token: 0x060162BB RID: 90811 RVA: 0x0059B75F File Offset: 0x0059995F
	private void EventOnActivitySequenceEmitEvent(string name)
	{
		if (name == "Start")
		{
			LoopScrollView<ShipTowerAreaItem, ShipTowerAreaItemData> areaLoopView = this.AreaLoopView;
			if (areaLoopView == null)
			{
				return;
			}
			areaLoopView.SelectGridProxy(this.GetSelectAreaIndex(), false);
		}
	}

	// Token: 0x060162BC RID: 90812 RVA: 0x0059B785 File Offset: 0x00599985
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.ShipTowerRewardReceive, new Action<int>(this.EventRewardReceive));
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.EventOnActivitySequenceEmitEvent));
	}

	// Token: 0x060162BD RID: 90813 RVA: 0x0059B7BF File Offset: 0x005999BF
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ShipTowerRewardReceive, new Action<int>(this.EventRewardReceive));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.EventOnActivitySequenceEmitEvent));
	}

	// Token: 0x060162BE RID: 90814 RVA: 0x0059B7FC File Offset: 0x005999FC
	protected override void OnBeforeShow()
	{
		this.UpdateRemainTime();
		int num = 500;
		this.RefreshTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimerRefresh), (float)num, 1f, null, null, true);
	}

	// Token: 0x060162BF RID: 90815 RVA: 0x0059B83B File Offset: 0x00599A3B
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x060162C0 RID: 90816 RVA: 0x0059B83D File Offset: 0x00599A3D
	private ShipTowerAreaItem CreateAreaItem()
	{
		return new ShipTowerAreaItem
		{
			ClickCallBack = new Action<ShipTowerAreaItemData>(this.OnAreaItemClick)
		};
	}

	// Token: 0x060162C1 RID: 90817 RVA: 0x0059B856 File Offset: 0x00599A56
	private ShipTowerRewardItem CreateRewardItem()
	{
		return new ShipTowerRewardItem
		{
			ClickCallBack = new Action<ShipTowerRewardItemData>(this.OnRewardItemClick)
		};
	}

	// Token: 0x060162C2 RID: 90818 RVA: 0x0059B86F File Offset: 0x00599A6F
	private void OnAreaItemClick(ShipTowerAreaItemData data)
	{
		this.SelectData = data;
		LoopScrollView<ShipTowerRewardItem, ShipTowerRewardItemData> rewardLoopView = this.RewardLoopView;
		if (rewardLoopView != null)
		{
			rewardLoopView.RefreshByData(data.RewardList, false, null, this.IsPlayAnim);
		}
		this.IsPlayAnim = true;
	}

	// Token: 0x060162C3 RID: 90819 RVA: 0x0059B8A0 File Offset: 0x00599AA0
	private void OnRewardItemClick(ShipTowerRewardItemData data)
	{
		List<ShipTowerRewardItemData> list = null;
		ShipTowerAreaItemData selectData = this.SelectData;
		if (((selectData != null) ? selectData.RewardList : null) != null)
		{
			list = new List<ShipTowerRewardItemData>();
			foreach (ShipTowerRewardItemData shipTowerRewardItemData in this.SelectData.RewardList)
			{
				if (shipTowerRewardItemData.IsReceive)
				{
					list.Add(shipTowerRewardItemData);
				}
			}
		}
		List<int> list2 = new List<int>();
		if (list != null)
		{
			foreach (ShipTowerRewardItemData shipTowerRewardItemData2 in list)
			{
				list2.Add(shipTowerRewardItemData2.Id);
			}
		}
		ShipTowerModel.Instance.ReceiveAward(data.Id, list2.ToArray()).Forget();
	}

	// Token: 0x060162C4 RID: 90820 RVA: 0x0059B984 File Offset: 0x00599B84
	private void OnTimerRefresh(float delta)
	{
		this.UpdateRemainTime();
		if (ShipTowerModel.Instance.TimeIsOver())
		{
			this.ClearTimer();
		}
	}

	// Token: 0x060162C5 RID: 90821 RVA: 0x0059B99E File Offset: 0x00599B9E
	private void ClearTimer()
	{
		if (this.RefreshTimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x060162C6 RID: 90822 RVA: 0x0059B9C0 File Offset: 0x00599BC0
	private int GetSelectAreaIndex()
	{
		ShipTowerRewardViewParams shipTowerRewardViewParams = this.OpenParam as ShipTowerRewardViewParams;
		if (shipTowerRewardViewParams == null || shipTowerRewardViewParams.RewardId == null)
		{
			return this.GetCanReceiveAwardIndex();
		}
		int value = shipTowerRewardViewParams.RewardId.Value;
		int index = -1;
		for (int i = 0; i < this.AreaList.Count; i++)
		{
			ShipTowerAreaItemData shipTowerAreaItemData = this.AreaList[i];
			if (shipTowerAreaItemData.RewardList != null)
			{
				bool flag = false;
				using (List<ShipTowerRewardItemData>.Enumerator enumerator = shipTowerAreaItemData.RewardList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Id == value)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					index = i;
					break;
				}
			}
		}
		return this.GetRangeIndex(index);
	}

	// Token: 0x060162C7 RID: 90823 RVA: 0x0059BA90 File Offset: 0x00599C90
	private int GetCanReceiveAwardIndex()
	{
		int index = -1;
		for (int i = 0; i < this.AreaList.Count; i++)
		{
			ShipTowerAreaItemData shipTowerAreaItemData = this.AreaList[i];
			if (shipTowerAreaItemData.RewardList != null)
			{
				bool flag = false;
				using (List<ShipTowerRewardItemData>.Enumerator enumerator = shipTowerAreaItemData.RewardList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsReceive)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					index = i;
					break;
				}
			}
		}
		return this.GetRangeIndex(index);
	}

	// Token: 0x060162C8 RID: 90824 RVA: 0x0059BB24 File Offset: 0x00599D24
	private int GetRangeIndex(int index)
	{
		if (index == -1)
		{
			return 0;
		}
		return index;
	}

	// Token: 0x060162C9 RID: 90825 RVA: 0x0059BB30 File Offset: 0x00599D30
	private void UpdateRemainTime()
	{
		string rewardCountDownDesc = ShipTowerModel.Instance.GetRewardCountDownDesc();
		UUIText text = base.GetText(5);
		if (text == null)
		{
			return;
		}
		text.SetText(rewardCountDownDesc, true);
	}

	// Token: 0x060162CA RID: 90826 RVA: 0x0059BB5B File Offset: 0x00599D5B
	private void EventRewardReceive(int id)
	{
		if (this.SelectData == null)
		{
			return;
		}
		LoopScrollView<ShipTowerAreaItem, ShipTowerAreaItemData> areaLoopView = this.AreaLoopView;
		if (areaLoopView == null)
		{
			return;
		}
		areaLoopView.RefreshByData(this.AreaList, true, delegate
		{
			this.IsPlayAnim = false;
			LoopScrollView<ShipTowerAreaItem, ShipTowerAreaItemData> areaLoopView2 = this.AreaLoopView;
			if (areaLoopView2 != null)
			{
				areaLoopView2.DeselectCurrentGridProxy(false);
			}
			LoopScrollView<ShipTowerAreaItem, ShipTowerAreaItemData> areaLoopView3 = this.AreaLoopView;
			if (areaLoopView3 == null)
			{
				return;
			}
			areaLoopView3.SelectGridProxy(this.GetCanReceiveAwardIndex(), false);
		}, false);
	}

	// Token: 0x0400A51B RID: 42267
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x0400A51C RID: 42268
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShipTowerAreaItem, ShipTowerAreaItemData> AreaLoopView;

	// Token: 0x0400A51D RID: 42269
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShipTowerRewardItem, ShipTowerRewardItemData> RewardLoopView;

	// Token: 0x0400A51E RID: 42270
	private List<ShipTowerAreaItemData> AreaList;

	// Token: 0x0400A51F RID: 42271
	[Nullable(2)]
	private ShipTowerAreaItemData SelectData;

	// Token: 0x0400A520 RID: 42272
	private bool IsPlayAnim = true;

	// Token: 0x0400A521 RID: 42273
	[Nullable(2)]
	private TimerHandle RefreshTimerHandle;

	// Token: 0x02008FEC RID: 36844
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E9B1 RID: 190897
		public const int ItemCaption = 0;

		// Token: 0x0402E9B2 RID: 190898
		public const int LoopViewArea = 1;

		// Token: 0x0402E9B3 RID: 190899
		public const int LoopViewReward = 2;

		// Token: 0x0402E9B4 RID: 190900
		public const int ItemArea = 3;

		// Token: 0x0402E9B5 RID: 190901
		public const int ItemReward = 4;

		// Token: 0x0402E9B6 RID: 190902
		public const int CountDownText = 5;
	}
}
