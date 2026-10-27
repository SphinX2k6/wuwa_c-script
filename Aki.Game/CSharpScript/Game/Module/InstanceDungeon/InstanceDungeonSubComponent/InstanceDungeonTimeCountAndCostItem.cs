using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058AE RID: 22702
	public class InstanceDungeonTimeCountAndCostItem : UiPanelBase
	{
		// Token: 0x06039BDA RID: 236506 RVA: 0x00DB9320 File Offset: 0x00DB7520
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039BDB RID: 236507 RVA: 0x00DB93AC File Offset: 0x00DB75AC
		public void RefreshItem(TItem item, int instanceId)
		{
			int rewardId = InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.RewardId;
			ExchangeReward? exchangeReward;
			int? id = (ExchangeRewardConfig.Instance.GetExchangeRewardConfig(new int?(rewardId)) != null) ? new int?(exchangeReward.GetValueOrDefault().SharedId) : null;
			if (id != null && id.Value != 0)
			{
				ExchangeShared? exchangeShareConfig = ExchangeRewardConfig.Instance.GetExchangeShareConfig(id);
				int exchangeRewardShareCount = ExchangeRewardModel.Instance.GetExchangeRewardShareCount(id.Value);
				int maxCount = exchangeShareConfig.Value.MaxCount;
				int num = maxCount - exchangeRewardShareCount;
				int num2 = (num >= 0) ? num : 0;
				if (num2 == 0)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "InstanceCanRewardTimesDepleted", new <>z__ReadOnlyArray<object>(new object[]
					{
						num2,
						maxCount
					}));
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "InstanceCanRewardTimes", new <>z__ReadOnlySingleElementList<object>(num2.ToString() + "/" + maxCount.ToString()));
				}
			}
			bool flag = item.ItemData.ItemId == 5 && !PowerModel.Instance.IsPowerEnough(new int?(item.Count));
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText("x" + item.Count.ToString(), true);
			}
			if (text != null)
			{
				UUIItem uuiitem = text;
				bool bUseChangeColor = flag;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			base.SetItemIcon(base.GetTexture(0), item.ItemData.ItemId, null, null);
		}

		// Token: 0x0200BB15 RID: 47893
		private enum EChildType
		{
			// Token: 0x04038842 RID: 231490
			ItemIconTex,
			// Token: 0x04038843 RID: 231491
			TimeCountTxt,
			// Token: 0x04038844 RID: 231492
			ItemCountNumTxt
		}
	}
}
