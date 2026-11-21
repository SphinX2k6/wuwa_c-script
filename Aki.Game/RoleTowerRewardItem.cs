using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001CFA RID: 7418
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerRewardItem : GridProxyAbstract<RoleTowerRewardItemData>
{
	// Token: 0x060125D7 RID: 75223 RVA: 0x0056C304 File Offset: 0x0056A504
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x060125D8 RID: 75224 RVA: 0x0056C3B8 File Offset: 0x0056A5B8
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<ActivitySmallItemGrid, IItemGridData>(base.GetHorizontalLayout(2), () => new ActivitySmallItemGrid(), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		this.ReceiveButton = new ButtonItem(base.GetButton(4).RootUIComp.Get());
		this.ReceiveButton.SetFunction(delegate(int _)
		{
			this.OnClickReceive();
		});
	}

	// Token: 0x060125D9 RID: 75225 RVA: 0x0056C440 File Offset: 0x0056A640
	public override void Refresh(RoleTowerRewardItemData data, bool isSelected, int gridIndex)
	{
		this.RewardId = data.RewardId;
		RoleTowerReward? rewardCfg = RoleTowerModel.Instance.GetRewardCfg(data.RewardId);
		if (rewardCfg == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), rewardCfg.Value.Desc, rewardCfg.Value.DescParam());
		RoleTowerRewardData rewardState = RoleTowerModel.Instance.GetRewardState(data.RewardId);
		ERoleTowerRewardState eroleTowerRewardState = (rewardState != null) ? rewardState.State : ERoleTowerRewardState.UnFinish;
		int value = (rewardState != null) ? rewardState.Progress : 0;
		int value2 = (rewardState != null) ? rewardState.Target : 0;
		string newText;
		if (rewardCfg.Value.ProgressType == 1)
		{
			newText = ((eroleTowerRewardState == ERoleTowerRewardState.UnFinish) ? "0/1" : "1/1");
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
			newText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(newText, true);
		}
		bool flag = eroleTowerRewardState == ERoleTowerRewardState.CanReceive;
		base.SetButtonUiActive(4, flag);
		ButtonItem receiveButton = this.ReceiveButton;
		if (receiveButton != null)
		{
			receiveButton.SetRedDotVisible(flag);
		}
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(eroleTowerRewardState == ERoleTowerRewardState.UnFinish);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(eroleTowerRewardState == ERoleTowerRewardState.Received);
		}
		List<IItemGridData> list = new List<IItemGridData>();
		foreach (TItem item3 in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardCfg.Value.DropId))
		{
			list.Add(new ItemGridData
			{
				Item = item3,
				HasClaimed = (eroleTowerRewardState == ERoleTowerRewardState.Received)
			});
		}
		GenericLayout<ActivitySmallItemGrid, IItemGridData> rewardLayout = this.RewardLayout;
		if (rewardLayout == null)
		{
			return;
		}
		rewardLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060125DA RID: 75226 RVA: 0x0056C624 File Offset: 0x0056A824
	private void OnClickReceive()
	{
		RoleTowerReward? roleTowerReward;
		int tabId = (RoleTowerModel.Instance.GetRewardCfg(this.RewardId) != null) ? roleTowerReward.GetValueOrDefault().TabId : 0;
		int[] array = RoleTowerModel.Instance.GetCanReceiveRewardTaskIds(tabId);
		if (array.Length == 0)
		{
			array = new int[]
			{
				this.RewardId
			};
		}
		RoleTowerController.Instance.RewardTaskReceiveRequest(array).Forget();
	}

	// Token: 0x060125DB RID: 75227 RVA: 0x0056C68E File Offset: 0x0056A88E
	public override object GetKey(RoleTowerRewardItemData data, int displayIndex)
	{
		return data.RewardId;
	}

	// Token: 0x0400A013 RID: 40979
	private int RewardId;

	// Token: 0x0400A014 RID: 40980
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivitySmallItemGrid, IItemGridData> RewardLayout;

	// Token: 0x0400A015 RID: 40981
	[Nullable(2)]
	private ButtonItem ReceiveButton;

	// Token: 0x0200801B RID: 32795
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029729 RID: 169769
		public const int TxtDesc = 0;

		// Token: 0x0402972A RID: 169770
		public const int TxtProgress = 1;

		// Token: 0x0402972B RID: 169771
		public const int RewardLayout = 2;

		// Token: 0x0402972C RID: 169772
		public const int RewardItem = 3;

		// Token: 0x0402972D RID: 169773
		public const int BtnReceive = 4;

		// Token: 0x0402972E RID: 169774
		public const int PnlDoing = 5;

		// Token: 0x0402972F RID: 169775
		public const int PnlReceived = 6;
	}
}
