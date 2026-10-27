using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062F3 RID: 25331
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballSettleResultDailyStrategy : PinballSettleResultStrategyBase
	{
		// Token: 0x0603FBD3 RID: 261075 RVA: 0x00F6C25C File Offset: 0x00F6A45C
		public override bool GetIsNeedRewardView()
		{
			return base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x0603FBD4 RID: 261076 RVA: 0x00F6C26E File Offset: 0x00F6A46E
		public override bool GetIsNeedDialogView()
		{
			return !base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x0603FBD5 RID: 261077 RVA: 0x00F6C283 File Offset: 0x00F6A483
		public override bool GetIsNeedFailTipsView()
		{
			return !base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x0603FBD6 RID: 261078 RVA: 0x00F6C298 File Offset: 0x00F6A498
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

		// Token: 0x0603FBD7 RID: 261079 RVA: 0x00F6C2E0 File Offset: 0x00F6A4E0
		public override void RefreshButtons()
		{
			base.Context.BindRestartButton();
			base.Context.BindBackButton();
		}

		// Token: 0x0603FBD8 RID: 261080 RVA: 0x00F6C2F8 File Offset: 0x00F6A4F8
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

		// Token: 0x0603FBD9 RID: 261081 RVA: 0x00F6C31B File Offset: 0x00F6A51B
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
