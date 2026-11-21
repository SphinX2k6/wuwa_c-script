using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x02005274 RID: 21108
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballSettleResultTowerStrategy : PinballSettleResultStrategyBase
	{
		// Token: 0x060348BF RID: 215231 RVA: 0x00EB372A File Offset: 0x00EB192A
		public override bool GetIsNeedRewardView()
		{
			return base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x060348C0 RID: 215232 RVA: 0x00EB373C File Offset: 0x00EB193C
		public override bool GetIsNeedDialogView()
		{
			return !base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x060348C1 RID: 215233 RVA: 0x00EB3751 File Offset: 0x00EB1951
		public override bool GetIsNeedFailTipsView()
		{
			return !base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x060348C2 RID: 215234 RVA: 0x00EB3766 File Offset: 0x00EB1966
		public override void RefreshStarLayout()
		{
			if (!base.Context.GetOpenParam().IsWin)
			{
				return;
			}
			base.Context.ShowStarLayout(base.Context.GetOpenParam().StarInfo);
		}

		// Token: 0x060348C3 RID: 215235 RVA: 0x00EB3798 File Offset: 0x00EB1998
		public override void RefreshRewards()
		{
			if (!base.Context.GetOpenParam().IsWin)
			{
				return;
			}
			if (!base.Context.GetOpenParam().IsFirstPass)
			{
				base.Context.ShowRewardsGot();
				return;
			}
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(base.Context.GetOpenParam().LevelId);
			if (pinballLevelConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "星弹奇游关卡配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelId", base.Context.GetOpenParam().LevelId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(pinballLevelConfigById.Value.FirstClearDropId);
			base.Context.ShowRewards(dropPackagePreviewItemList);
		}

		// Token: 0x060348C4 RID: 215236 RVA: 0x00EB3864 File Offset: 0x00EB1A64
		public override void RefreshButtons()
		{
			base.Context.BindRestartButton();
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(base.Context.GetOpenParam().LevelId);
			if (base.Context.GetOpenParam().IsWin && pinballLevelConfigById != null && pinballLevelConfigById.Value.NextLevelId > 0)
			{
				base.Context.BindNextButton();
				return;
			}
			base.Context.BindBackButton();
		}

		// Token: 0x060348C5 RID: 215237 RVA: 0x00EB38DB File Offset: 0x00EB1ADB
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

		// Token: 0x060348C6 RID: 215238 RVA: 0x00EB3900 File Offset: 0x00EB1B00
		public override void OnClickBtnNext(Action callback)
		{
			int levelId = base.Context.GetOpenParam().LevelId;
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(levelId);
			if (pinballLevelConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "星弹奇游关卡配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelId", levelId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			PinballController.Instance.OpenTowerLevelView(pinballLevelConfigById.Value.NextLevelId, true).Forget<bool>();
			callback();
		}

		// Token: 0x060348C7 RID: 215239 RVA: 0x00EB3988 File Offset: 0x00EB1B88
		public override void OnClickBtnBack(Action callback)
		{
			PinballController.Instance.OpenTowerLevelView(base.Context.GetOpenParam().LevelId, true).Forget<bool>();
			callback();
		}
	}
}
