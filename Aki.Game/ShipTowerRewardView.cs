using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F45 RID: 8005
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerRewardView : UiViewBase
{
	// Token: 0x06013CBC RID: 81084 RVA: 0x005C65D5 File Offset: 0x005C47D5
	public ShipTowerRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013CBD RID: 81085 RVA: 0x005C65E8 File Offset: 0x005C47E8
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

	// Token: 0x06013CBE RID: 81086 RVA: 0x005C6684 File Offset: 0x005C4884
	private void InitDataParam()
	{
		this.AreaList = ShipTowerModel.Instance.GetAreaList();
	}

	// Token: 0x06013CBF RID: 81087 RVA: 0x005C6698 File Offset: 0x005C4898
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRewardView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRewardView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013CC0 RID: 81088 RVA: 0x005C66DC File Offset: 0x005C48DC
	private UniTask CheckIsNeedShowSeasonReview()
	{
		ShipTowerRewardView.<CheckIsNeedShowSeasonReview>d__12 <CheckIsNeedShowSeasonReview>d__;
		<CheckIsNeedShowSeasonReview>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckIsNeedShowSeasonReview>d__.<>1__state = -1;
		<CheckIsNeedShowSeasonReview>d__.<>t__builder.Start<ShipTowerRewardView.<CheckIsNeedShowSeasonReview>d__12>(ref <CheckIsNeedShowSeasonReview>d__);
		return <CheckIsNeedShowSeasonReview>d__.<>t__builder.Task;
	}

	// Token: 0x06013CC1 RID: 81089 RVA: 0x005C6717 File Offset: 0x005C4917
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

	// Token: 0x06013CC2 RID: 81090 RVA: 0x005C673D File Offset: 0x005C493D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.ShipTowerRewardReceive, new Action<int>(this.EventRewardReceive));
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.EventOnActivitySequenceEmitEvent));
	}

	// Token: 0x06013CC3 RID: 81091 RVA: 0x005C6777 File Offset: 0x005C4977
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ShipTowerRewardReceive, new Action<int>(this.EventRewardReceive));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.EventOnActivitySequenceEmitEvent));
	}

	// Token: 0x06013CC4 RID: 81092 RVA: 0x005C67B4 File Offset: 0x005C49B4
	protected override void OnBeforeShow()
	{
		this.UpdateRemainTime();
		int num = 500;
		this.RefreshTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimerRefresh), (float)num, 1f, null, null, true);
	}

	// Token: 0x06013CC5 RID: 81093 RVA: 0x005C67F3 File Offset: 0x005C49F3
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06013CC6 RID: 81094 RVA: 0x005C67F5 File Offset: 0x005C49F5
	private ShipTowerAreaItem CreateAreaItem()
	{
		return new ShipTowerAreaItem
		{
			ClickCallBack = new Action<ShipTowerAreaItemData>(this.OnAreaItemClick)
		};
	}

	// Token: 0x06013CC7 RID: 81095 RVA: 0x005C680E File Offset: 0x005C4A0E
	private ShipTowerRewardItem CreateRewardItem()
	{
		return new ShipTowerRewardItem
		{
			ClickCallBack = new Action<ShipTowerRewardItemData>(this.OnRewardItemClick)
		};
	}

	// Token: 0x06013CC8 RID: 81096 RVA: 0x005C6827 File Offset: 0x005C4A27
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

	// Token: 0x06013CC9 RID: 81097 RVA: 0x005C6858 File Offset: 0x005C4A58
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

	// Token: 0x06013CCA RID: 81098 RVA: 0x005C693C File Offset: 0x005C4B3C
	private void OnTimerRefresh(float delta)
	{
		this.UpdateRemainTime();
		if (ShipTowerModel.Instance.TimeIsOver())
		{
			this.ClearTimer();
		}
	}

	// Token: 0x06013CCB RID: 81099 RVA: 0x005C6956 File Offset: 0x005C4B56
	private void ClearTimer()
	{
		if (this.RefreshTimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x06013CCC RID: 81100 RVA: 0x005C6978 File Offset: 0x005C4B78
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

	// Token: 0x06013CCD RID: 81101 RVA: 0x005C6A48 File Offset: 0x005C4C48
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

	// Token: 0x06013CCE RID: 81102 RVA: 0x005C6ADC File Offset: 0x005C4CDC
	private int GetRangeIndex(int index)
	{
		if (index == -1)
		{
			return 0;
		}
		return index;
	}

	// Token: 0x06013CCF RID: 81103 RVA: 0x005C6AE8 File Offset: 0x005C4CE8
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

	// Token: 0x06013CD0 RID: 81104 RVA: 0x005C6B13 File Offset: 0x005C4D13
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

	// Token: 0x0400A905 RID: 43269
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x0400A906 RID: 43270
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShipTowerAreaItem, ShipTowerAreaItemData> AreaLoopView;

	// Token: 0x0400A907 RID: 43271
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShipTowerRewardItem, ShipTowerRewardItemData> RewardLoopView;

	// Token: 0x0400A908 RID: 43272
	private List<ShipTowerAreaItemData> AreaList;

	// Token: 0x0400A909 RID: 43273
	[Nullable(2)]
	private ShipTowerAreaItemData SelectData;

	// Token: 0x0400A90A RID: 43274
	private bool IsPlayAnim = true;

	// Token: 0x0400A90B RID: 43275
	[Nullable(2)]
	private TimerHandle RefreshTimerHandle;

	// Token: 0x02008233 RID: 33331
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A0A9 RID: 172201
		public const int ItemCaption = 0;

		// Token: 0x0402A0AA RID: 172202
		public const int LoopViewArea = 1;

		// Token: 0x0402A0AB RID: 172203
		public const int LoopViewReward = 2;

		// Token: 0x0402A0AC RID: 172204
		public const int ItemArea = 3;

		// Token: 0x0402A0AD RID: 172205
		public const int ItemReward = 4;

		// Token: 0x0402A0AE RID: 172206
		public const int CountDownText = 5;
	}
}
