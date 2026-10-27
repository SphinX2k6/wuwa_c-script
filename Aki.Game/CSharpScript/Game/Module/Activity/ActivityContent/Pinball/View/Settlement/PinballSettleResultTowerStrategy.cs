using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062F6 RID: 25334
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballSettleResultTowerStrategy : PinballSettleResultStrategyBase
	{
		// Token: 0x0603FBFE RID: 261118 RVA: 0x00F6C7CE File Offset: 0x00F6A9CE
		public override bool GetIsNeedRewardView()
		{
			return base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x0603FBFF RID: 261119 RVA: 0x00F6C7E0 File Offset: 0x00F6A9E0
		public override bool GetIsNeedDialogView()
		{
			return !base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x0603FC00 RID: 261120 RVA: 0x00F6C7F5 File Offset: 0x00F6A9F5
		public override bool GetIsNeedFailTipsView()
		{
			return !base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x0603FC01 RID: 261121 RVA: 0x00F6C80A File Offset: 0x00F6AA0A
		public override void RefreshStarLayout()
		{
			if (!base.Context.GetOpenParam().IsWin)
			{
				return;
			}
			base.Context.ShowStarLayout(base.Context.GetOpenParam().StarInfo);
		}

		// Token: 0x0603FC02 RID: 261122 RVA: 0x00F6C83C File Offset: 0x00F6AA3C
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

		// Token: 0x0603FC03 RID: 261123 RVA: 0x00F6C908 File Offset: 0x00F6AB08
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

		// Token: 0x0603FC04 RID: 261124 RVA: 0x00F6C97F File Offset: 0x00F6AB7F
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

		// Token: 0x0603FC05 RID: 261125 RVA: 0x00F6C9A4 File Offset: 0x00F6ABA4
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

		// Token: 0x0603FC06 RID: 261126 RVA: 0x00F6CA2C File Offset: 0x00F6AC2C
		public override void OnClickBtnBack(Action callback)
		{
			PinballController.Instance.OpenTowerLevelView(base.Context.GetOpenParam().LevelId, true).Forget<bool>();
			callback();
		}
	}
}
