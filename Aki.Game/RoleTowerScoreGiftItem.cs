using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CF8 RID: 7416
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerScoreGiftItem : GridProxyAbstract<RoleTowerScoreGiftData>
{
	// Token: 0x060125C9 RID: 75209 RVA: 0x0056BD4C File Offset: 0x00569F4C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x060125CA RID: 75210 RVA: 0x0056BDBC File Offset: 0x00569FBC
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerScoreGiftItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerScoreGiftItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060125CB RID: 75211 RVA: 0x0056BE00 File Offset: 0x0056A000
	public override void Refresh(RoleTowerScoreGiftData data, bool isSelected, int gridIndex)
	{
		this.ScoreRewardId = data.ScoreRewardId;
		RoleTowerScoreReward? scoreRewardCfg = RoleTowerModel.Instance.GetScoreRewardCfg(data.ScoreRewardId);
		if (scoreRewardCfg == null)
		{
			return;
		}
		RoleTowerScoreRewardData scoreRewardState = RoleTowerModel.Instance.GetScoreRewardState(data.ScoreRewardId);
		ERoleTowerRewardState eroleTowerRewardState = (scoreRewardState != null) ? scoreRewardState.State : ERoleTowerRewardState.UnFinish;
		bool flag = eroleTowerRewardState == ERoleTowerRewardState.CanReceive;
		bool flag2 = eroleTowerRewardState == ERoleTowerRewardState.Received;
		bool flag3 = !flag && !flag2;
		bool flag4 = !flag3;
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(scoreRewardCfg.Value.NeedScore.ToString(), true);
		}
		if (text != null)
		{
			UUIItem uuiitem = text;
			bool bUseChangeColor = flag4;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			UUIItem uuiitem2 = sprite;
			bool bUseChangeColor2 = flag4;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		}
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(scoreRewardCfg.Value.DropId);
		this.RewardItem = ((dropPackagePreviewItemList.Count > 0) ? new TItem?(dropPackagePreviewItemList[0]) : null);
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(this.RewardItem != null);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		if (this.RewardItem == null || this.RewardItemGrid == null)
		{
			return;
		}
		this.RewardItemGrid.Apply<PropSmallItemGrid>(new PropSmallItemGrid
		{
			Data = scoreRewardCfg.Value,
			ItemConfigId = new int?(this.RewardItem.Value.ItemData.ItemId),
			BottomText = this.RewardItem.Value.Count.ToString(),
			IsReceivableVisible = new bool?(flag),
			IsReceivedVisible = new bool?(flag2),
			IsRedDotVisible = new bool?(false)
		});
		this.RewardItemGrid.SetLockBlackVisible(flag3);
	}

	// Token: 0x060125CC RID: 75212 RVA: 0x0056BFF8 File Offset: 0x0056A1F8
	private void OnClickItem(MediumItemGridExtendCallback _)
	{
		RoleTowerScoreRewardData scoreRewardState = RoleTowerModel.Instance.GetScoreRewardState(this.ScoreRewardId);
		if (((scoreRewardState != null) ? scoreRewardState.State : ERoleTowerRewardState.UnFinish) == ERoleTowerRewardState.CanReceive)
		{
			int[] array = RoleTowerModel.Instance.GetCanReceiveScoreRewardIds();
			if (array.Length == 0)
			{
				array = new int[]
				{
					this.ScoreRewardId
				};
			}
			RoleTowerController.Instance.ScoreRewardReceiveRequest(array).Forget();
			return;
		}
		if (this.RewardItem != null)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null, false);
		}
	}

	// Token: 0x060125CD RID: 75213 RVA: 0x0056C083 File Offset: 0x0056A283
	public override object GetKey(RoleTowerScoreGiftData data, int displayIndex)
	{
		return data.ScoreRewardId;
	}

	// Token: 0x0400A00D RID: 40973
	private int ScoreRewardId;

	// Token: 0x0400A00E RID: 40974
	[Nullable(2)]
	private SmallItemGrid RewardItemGrid;

	// Token: 0x0400A00F RID: 40975
	private TItem? RewardItem;

	// Token: 0x02008017 RID: 32791
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402971B RID: 169755
		public const int SprNumBg = 0;

		// Token: 0x0402971C RID: 169756
		public const int TxtNeedScore = 1;

		// Token: 0x0402971D RID: 169757
		public const int RewardItem = 2;

		// Token: 0x0402971E RID: 169758
		public const int PnlRedDot = 3;
	}
}
