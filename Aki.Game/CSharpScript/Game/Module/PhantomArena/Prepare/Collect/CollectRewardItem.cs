using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x02004184 RID: 16772
	public class CollectRewardItem : GridProxyAbstract<int>
	{
		// Token: 0x0602A7D8 RID: 174040 RVA: 0x00BFCC64 File Offset: 0x00BFAE64
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

		// Token: 0x0602A7D9 RID: 174041 RVA: 0x00BFCD7C File Offset: 0x00BFAF7C
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

		// Token: 0x0602A7DA RID: 174042 RVA: 0x00BFCEB0 File Offset: 0x00BFB0B0
		private void OnClickReward()
		{
			if (this.CallbackClickReward != null)
			{
				TWeakObjectPtr<UUIItem> rootUIComp = base.GetButton(0).RootUIComp;
				this.CallbackClickReward(this.RewardId, rootUIComp);
			}
		}

		// Token: 0x04017119 RID: 94489
		private int RewardId = -1;

		// Token: 0x0401711A RID: 94490
		public ECollectRewardType RewardType;

		// Token: 0x0401711B RID: 94491
		[Nullable(1)]
		public Action<int, UUIItem> CallbackClickReward;

		// Token: 0x02009D73 RID: 40307
		private static class EComponents
		{
			// Token: 0x04030F71 RID: 200561
			public const int BtnReward = 0;

			// Token: 0x04030F72 RID: 200562
			public const int SpriteBg = 1;

			// Token: 0x04030F73 RID: 200563
			public const int SpriteBgFinish = 2;

			// Token: 0x04030F74 RID: 200564
			public const int SpriteBoxTaken = 3;

			// Token: 0x04030F75 RID: 200565
			public const int SpriteBoxFinish = 4;

			// Token: 0x04030F76 RID: 200566
			public const int SpriteBoxPending = 5;

			// Token: 0x04030F77 RID: 200567
			public const int SpriteIconTaken = 6;

			// Token: 0x04030F78 RID: 200568
			public const int SpriteCubePending = 7;

			// Token: 0x04030F79 RID: 200569
			public const int SpriteCubeTaken = 8;

			// Token: 0x04030F7A RID: 200570
			public const int TextCount = 9;
		}
	}
}
