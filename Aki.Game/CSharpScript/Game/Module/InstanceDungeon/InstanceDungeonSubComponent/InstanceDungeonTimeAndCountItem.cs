using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058AD RID: 22701
	public class InstanceDungeonTimeAndCountItem : UiPanelBase
	{
		// Token: 0x06039BD7 RID: 236503 RVA: 0x00DB8FC0 File Offset: 0x00DB71C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039BD8 RID: 236504 RVA: 0x00DB906C File Offset: 0x00DB726C
		public void RefreshItem(int instanceId)
		{
			int rewardId = InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.RewardId;
			ExchangeReward? exchangeReward;
			int? id = (ExchangeRewardConfig.Instance.GetExchangeRewardConfig(new int?(rewardId)) != null) ? new int?(exchangeReward.GetValueOrDefault().SharedId) : null;
			if (id != null && id.Value != 0)
			{
				ExchangeShared? exchangeShareConfig = ExchangeRewardConfig.Instance.GetExchangeShareConfig(id);
				base.GetItem(0).SetUIActive(true);
				base.GetText(2).SetUIActive(true);
				int exchangeRewardShareCount = ExchangeRewardModel.Instance.GetExchangeRewardShareCount(id.Value);
				int maxCount = exchangeShareConfig.Value.MaxCount;
				int num = maxCount - exchangeRewardShareCount;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "InstanceCanRewardTimes", new <>z__ReadOnlySingleElementList<object>(((num >= 0) ? num : 0).ToString() + "/" + maxCount.ToString()));
				if (num == maxCount)
				{
					base.GetItem(1).SetUIActive(false);
					return;
				}
			}
			else
			{
				int enterControlId = InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.EnterControlId;
				InstanceDungeonData instanceData = InstanceDungeonEntranceModel.Instance.GetInstanceData(enterControlId);
				if (instanceData != null)
				{
					int limitChallengedTimes = instanceData.LimitChallengedTimes;
					base.GetItem(0).SetUIActive(true);
					base.GetText(2).SetUIActive(true);
					int num2 = (instanceData.LeftChallengedTimes >= 0) ? instanceData.LeftChallengedTimes : 0;
					LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "InstanceCanRewardTimes", new <>z__ReadOnlySingleElementList<object>(num2.ToString() + "/" + instanceData.LimitChallengedTimes.ToString()));
					if (num2 == instanceData.LimitChallengedTimes)
					{
						base.GetItem(1).SetUIActive(false);
						return;
					}
				}
				else
				{
					base.GetItem(0).SetUIActive(false);
					base.GetText(2).SetUIActive(false);
				}
			}
			long num3 = InstanceDungeonEntranceModel.Instance.GetInstanceResetTime(instanceId).GetValueOrDefault();
			if (num3 <= 0L)
			{
				num3 = InstanceDungeonEntranceModel.Instance.EntranceEndTime;
			}
			double num4 = (double)num3 - TimeUtil.Instance.GetServerTime();
			if (num3 > 0L && num4 > 0.0)
			{
				base.GetItem(1).SetUIActive(true);
				CommonDefine.IRemainTime remainTime = TimeUtil.Instance.CalculateRemainingTime(num4, CommonDefine.ETimeType.Minute);
				LguiUtil.Instance.SetLocalText(base.GetText(3), remainTime.TextId, new <>z__ReadOnlySingleElementList<object>((remainTime.TimeValue > 0) ? remainTime.TimeValue : 1));
				return;
			}
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x0200BB14 RID: 47892
		private enum EChildType
		{
			// Token: 0x0403883D RID: 231485
			UIItemFrequency,
			// Token: 0x0403883E RID: 231486
			UIItemTime,
			// Token: 0x0403883F RID: 231487
			TextFrequency,
			// Token: 0x04038840 RID: 231488
			TextTime
		}
	}
}
