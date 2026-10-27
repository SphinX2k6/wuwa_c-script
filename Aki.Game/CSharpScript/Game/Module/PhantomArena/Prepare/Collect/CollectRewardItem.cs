using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051B4 RID: 20916
	public class CollectRewardItem : GridProxyAbstract<int>
	{
		// Token: 0x060358DD RID: 219357 RVA: 0x00CAF628 File Offset: 0x00CAD828
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickReward))
			};
		}

		// Token: 0x060358DE RID: 219358 RVA: 0x00CAF740 File Offset: 0x00CAD940
		public override void Refresh(int rewardId, bool isSelected, int gridIndex)
		{
			this.RewardId = rewardId;
			ECollectRewardState ecollectRewardState = ECollectRewardState.Pending;
			int num = 0;
			if (this.RewardType == ECollectRewardType.Badge)
			{
				ecollectRewardState = PhantomArenaModel.Instance.GetBadgeRewardStateById(this.RewardId);
				num = PhantomArenaModel.Instance.GetBadgeRewardNeedCountById(this.RewardId);
			}
			else if (this.RewardType == ECollectRewardType.Card)
			{
				ecollectRewardState = PhantomArenaModel.Instance.GetCardRewardStateById(this.RewardId);
				num = PhantomArenaModel.Instance.GetCardRewardNeedCountById(this.RewardId);
			}
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			UUISprite sprite2 = base.GetSprite(2);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(ecollectRewardState == ECollectRewardState.Finish);
			}
			UUISprite sprite3 = base.GetSprite(3);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(ecollectRewardState == ECollectRewardState.Taken);
			}
			UUISprite sprite4 = base.GetSprite(4);
			if (sprite4 != null)
			{
				sprite4.SetUIActive(ecollectRewardState == ECollectRewardState.Finish);
			}
			UUISprite sprite5 = base.GetSprite(5);
			if (sprite5 != null)
			{
				sprite5.SetUIActive(ecollectRewardState == ECollectRewardState.Pending);
			}
			UUISprite sprite6 = base.GetSprite(6);
			if (sprite6 != null)
			{
				sprite6.SetUIActive(ecollectRewardState == ECollectRewardState.Taken);
			}
			UUISprite sprite7 = base.GetSprite(7);
			if (sprite7 != null)
			{
				sprite7.SetUIActive(true);
			}
			UUISprite sprite8 = base.GetSprite(8);
			if (sprite8 != null)
			{
				sprite8.SetUIActive(ecollectRewardState != ECollectRewardState.Pending);
			}
			base.GetText(9).SetText(num.ToString(), true);
		}

		// Token: 0x060358DF RID: 219359 RVA: 0x00CAF874 File Offset: 0x00CADA74
		private void OnClickReward()
		{
			if (this.CallbackClickReward != null)
			{
				TWeakObjectPtr<UUIItem> rootUIComp = base.GetButton(0).RootUIComp;
				this.CallbackClickReward(this.RewardId, rootUIComp);
			}
		}

		// Token: 0x0401C6E4 RID: 116452
		private int RewardId = -1;

		// Token: 0x0401C6E5 RID: 116453
		public ECollectRewardType RewardType;

		// Token: 0x0401C6E6 RID: 116454
		[Nullable(1)]
		public Action<int, UUIItem> CallbackClickReward;

		// Token: 0x0200B33B RID: 45883
		private static class EComponents
		{
			// Token: 0x0403651E RID: 222494
			public const int BtnReward = 0;

			// Token: 0x0403651F RID: 222495
			public const int SpriteBg = 1;

			// Token: 0x04036520 RID: 222496
			public const int SpriteBgFinish = 2;

			// Token: 0x04036521 RID: 222497
			public const int SpriteBoxTaken = 3;

			// Token: 0x04036522 RID: 222498
			public const int SpriteBoxFinish = 4;

			// Token: 0x04036523 RID: 222499
			public const int SpriteBoxPending = 5;

			// Token: 0x04036524 RID: 222500
			public const int SpriteIconTaken = 6;

			// Token: 0x04036525 RID: 222501
			public const int SpriteCubePending = 7;

			// Token: 0x04036526 RID: 222502
			public const int SpriteCubeTaken = 8;

			// Token: 0x04036527 RID: 222503
			public const int TextCount = 9;
		}
	}
}
