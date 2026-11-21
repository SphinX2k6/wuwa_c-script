using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x02005270 RID: 21104
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballSettleResultBonusStrategy : PinballSettleResultStrategyBase
	{
		// Token: 0x1700660F RID: 26127
		// (get) Token: 0x0603488C RID: 215180 RVA: 0x00EB2FE4 File Offset: 0x00EB11E4
		public override bool HasCustomRefreshTitle
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0603488D RID: 215181 RVA: 0x00EB2FE7 File Offset: 0x00EB11E7
		public override bool GetIsNeedProgressRewardView()
		{
			return true;
		}

		// Token: 0x0603488E RID: 215182 RVA: 0x00EB2FEA File Offset: 0x00EB11EA
		public override void RefreshTitle()
		{
			base.Context.ShowSuccessTips("Pinball_BattleSettlement_Fail");
		}

		// Token: 0x0603488F RID: 215183 RVA: 0x00EB2FFC File Offset: 0x00EB11FC
		public override void RefreshProgressRewards()
		{
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
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < pinballLevelConfigById.Value.ScoreLevelRewardLength; i++)
			{
				DicIntInt? dicIntInt = pinballLevelConfigById.Value.ScoreLevelReward(i);
				if (dicIntInt != null)
				{
					list.Add(dicIntInt.Value.Key);
					list2.Add(dicIntInt.Value.Value);
				}
			}
			base.Context.ShowProgressRewardList(base.Context.GetOpenParam().Score, list.ToArray(), list2.ToArray());
		}

		// Token: 0x06034890 RID: 215184 RVA: 0x00EB3107 File Offset: 0x00EB1307
		public override void RefreshButtons()
		{
			base.Context.BindRestartButton();
			base.Context.BindBackButton();
		}

		// Token: 0x06034891 RID: 215185 RVA: 0x00EB311F File Offset: 0x00EB131F
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

		// Token: 0x06034892 RID: 215186 RVA: 0x00EB3144 File Offset: 0x00EB1344
		public override void OnClickBtnBack(Action callback)
		{
			if (base.Context.GetOpenParam().Score >= PinballModel.Instance.ActivityData.GetLevelMaxScore(base.Context.GetOpenParam().LevelId))
			{
				base.OpenMainRootView();
			}
			else
			{
				PinballController.Instance.OpenLevelView(base.Context.GetOpenParam().LevelId, true).Forget<bool>();
			}
			callback();
		}
	}
}
