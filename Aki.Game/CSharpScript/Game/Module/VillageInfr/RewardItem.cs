using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x020037FA RID: 14330
	internal class RewardItem : GridProxyAbstract<int>
	{
		// Token: 0x06025430 RID: 152624 RVA: 0x00A82728 File Offset: 0x00A80928
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06025431 RID: 152625 RVA: 0x00A82784 File Offset: 0x00A80984
		protected override void OnStart()
		{
			this.RewardItemGrid.Initialize(base.GetItem(2).GetOwner());
			this.RewardItemGrid.BindOnCanExecuteChange((object _, bool isOn, EToggleState toggleState) => false);
			this.RewardItemGrid.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				InfrV2ScoreReward? scoreRewardById = VillageInfrConfig.Instance.GetScoreRewardById(this.Id);
				bool flag = VillageInfrModel.Instance.GetRewardScore() >= scoreRewardById.Value.Score;
				if (!VillageInfrModel.Instance.IsScoreRewardReceived(this.Id) && flag)
				{
					VillageInfrController.Instance.RequestInfrV2ScoreReward().Forget<bool>();
					return;
				}
				TItem? titem = callbackParameter.Data as TItem?;
				ItemController.Instance.OpenItemTipsByItemId(titem.Value.ItemData.ItemId, true, null, false);
			});
		}

		// Token: 0x06025432 RID: 152626 RVA: 0x00A827EC File Offset: 0x00A809EC
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.Id = data;
			InfrV2ScoreReward? scoreRewardById = VillageInfrConfig.Instance.GetScoreRewardById(this.Id);
			TItem titem = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(scoreRewardById.Value.DropId)[0];
			bool flag = VillageInfrModel.Instance.GetRewardScore() >= scoreRewardById.Value.Score;
			bool flag2 = VillageInfrModel.Instance.IsScoreRewardReceived(this.Id);
			this.RewardItemGrid.Apply<PropSmallItemGrid>(new PropSmallItemGrid
			{
				Data = titem,
				ItemConfigId = new int?(titem.ItemData.ItemId),
				IsReceivedVisible = new bool?(flag2),
				IsRedDotVisible = new bool?(flag && !flag2),
				IsReceivableVisible = new bool?(flag && !flag2),
				BottomText = titem.Count.ToString()
			});
			base.GetText(1).SetText(scoreRewardById.Value.Score.ToString(), true);
		}

		// Token: 0x040149F8 RID: 84472
		private int Id;

		// Token: 0x040149F9 RID: 84473
		[Nullable(1)]
		private readonly SmallItemGrid RewardItemGrid = new SmallItemGrid();
	}
}
