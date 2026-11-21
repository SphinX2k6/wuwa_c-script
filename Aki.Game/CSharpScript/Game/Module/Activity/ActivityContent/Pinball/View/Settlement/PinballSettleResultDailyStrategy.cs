using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x02005271 RID: 21105
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballSettleResultDailyStrategy : PinballSettleResultStrategyBase
	{
		// Token: 0x06034894 RID: 215188 RVA: 0x00EB31B8 File Offset: 0x00EB13B8
		public override bool GetIsNeedRewardView()
		{
			return base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x06034895 RID: 215189 RVA: 0x00EB31CA File Offset: 0x00EB13CA
		public override bool GetIsNeedDialogView()
		{
			return !base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x06034896 RID: 215190 RVA: 0x00EB31DF File Offset: 0x00EB13DF
		public override bool GetIsNeedFailTipsView()
		{
			return !base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x06034897 RID: 215191 RVA: 0x00EB31F4 File Offset: 0x00EB13F4
		public override void RefreshRewards()
		{
			if (!base.Context.GetOpenParam().IsWin)
			{
				return;
			}
			int curDailyRewardDropId = PinballModel.Instance.ActivityData.GetCurDailyRewardDropId();
			List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(curDailyRewardDropId);
			base.Context.ShowRewards(dropPackagePreviewItemList);
		}

		// Token: 0x06034898 RID: 215192 RVA: 0x00EB323C File Offset: 0x00EB143C
		public override void RefreshButtons()
		{
			base.Context.BindRestartButton();
			base.Context.BindBackButton();
		}

		// Token: 0x06034899 RID: 215193 RVA: 0x00EB3254 File Offset: 0x00EB1454
		public override void OnClickBtnRestart(Action callback)
		{
			if (base.Context.GetNeedAdjustFormation())
			{
				base.OpenFormationView();
			}
			else
			{
				base.RestartImmediate();
			}
			callback();
		}

		// Token: 0x0603489A RID: 215194 RVA: 0x00EB3277 File Offset: 0x00EB1477
		public override void OnClickBtnBack(Action callback)
		{
			if (base.Context.GetOpenParam().IsWin)
			{
				base.OpenMainRootView();
			}
			else
			{
				PinballController.Instance.OpenDailyLevelView(true).Forget<bool>();
			}
			callback();
		}
	}
}
