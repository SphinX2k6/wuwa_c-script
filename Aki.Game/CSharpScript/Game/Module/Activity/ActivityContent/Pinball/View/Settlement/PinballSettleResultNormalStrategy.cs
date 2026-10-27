using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062F4 RID: 25332
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballSettleResultNormalStrategy : PinballSettleResultStrategyBase
	{
		// Token: 0x0603FBDB RID: 261083 RVA: 0x00F6C355 File Offset: 0x00F6A555
		public override bool GetIsNeedRewardView()
		{
			return base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x0603FBDC RID: 261084 RVA: 0x00F6C367 File Offset: 0x00F6A567
		public override bool GetIsNeedDialogView()
		{
			return !base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x0603FBDD RID: 261085 RVA: 0x00F6C37C File Offset: 0x00F6A57C
		public override bool GetIsNeedFailTipsView()
		{
			return !base.Context.GetOpenParam().IsWin;
		}

		// Token: 0x0603FBDE RID: 261086 RVA: 0x00F6C391 File Offset: 0x00F6A591
		public override void RefreshStarLayout()
		{
			if (!base.Context.GetOpenParam().IsWin)
			{
				return;
			}
			base.Context.ShowStarLayout(base.Context.GetOpenParam().StarInfo);
		}

		// Token: 0x0603FBDF RID: 261087 RVA: 0x00F6C3C4 File Offset: 0x00F6A5C4
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

		// Token: 0x0603FBE0 RID: 261088 RVA: 0x00F6C490 File Offset: 0x00F6A690
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

		// Token: 0x0603FBE1 RID: 261089 RVA: 0x00F6C507 File Offset: 0x00F6A707
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

		// Token: 0x0603FBE2 RID: 261090 RVA: 0x00F6C52C File Offset: 0x00F6A72C
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
			if (pinballLevelConfigById.Value.NextLevelId == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PinballBattle;
				ELogAuthor author2 = ELogAuthor.CB;
				string message2 = "星弹奇游关卡配置不存在下一关";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("LevelId", levelId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			PinballController.Instance.OpenLevelView(pinballLevelConfigById.Value.NextLevelId, true).Forget<bool>();
			callback();
		}

		// Token: 0x0603FBE3 RID: 261091 RVA: 0x00F6C5F7 File Offset: 0x00F6A7F7
		public override void OnClickBtnBack(Action callback)
		{
			PinballController.Instance.OpenLevelView(base.Context.GetOpenParam().LevelId, true).Forget<bool>();
			callback();
		}
	}
}
