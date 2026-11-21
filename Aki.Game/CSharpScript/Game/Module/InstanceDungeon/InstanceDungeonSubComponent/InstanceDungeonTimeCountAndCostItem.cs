using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004886 RID: 18566
	public class InstanceDungeonTimeCountAndCostItem : UiPanelBase
	{
		// Token: 0x0602EAFD RID: 191229 RVA: 0x00D08238 File Offset: 0x00D06438
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

		// Token: 0x0602EAFE RID: 191230 RVA: 0x00D082C4 File Offset: 0x00D064C4
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

		// Token: 0x0200A52E RID: 42286
		private enum EChildType
		{
			// Token: 0x04033243 RID: 209475
			ItemIconTex,
			// Token: 0x04033244 RID: 209476
			TimeCountTxt,
			// Token: 0x04033245 RID: 209477
			ItemCountNumTxt
		}
	}
}
