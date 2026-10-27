using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062F2 RID: 25330
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballSettleResultBonusStrategy : PinballSettleResultStrategyBase
	{
		// Token: 0x170092AD RID: 37549
		// (get) Token: 0x0603FBCB RID: 261067 RVA: 0x00F6C088 File Offset: 0x00F6A288
		public override bool HasCustomRefreshTitle
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0603FBCC RID: 261068 RVA: 0x00F6C08B File Offset: 0x00F6A28B
		public override bool GetIsNeedProgressRewardView()
		{
			return true;
		}

		// Token: 0x0603FBCD RID: 261069 RVA: 0x00F6C08E File Offset: 0x00F6A28E
		public override void RefreshTitle()
		{
			base.Context.ShowSuccessTips("Pinball_BattleSettlement_Fail");
		}

		// Token: 0x0603FBCE RID: 261070 RVA: 0x00F6C0A0 File Offset: 0x00F6A2A0
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

		// Token: 0x0603FBCF RID: 261071 RVA: 0x00F6C1AB File Offset: 0x00F6A3AB
		public override void RefreshButtons()
		{
			base.Context.BindRestartButton();
			base.Context.BindBackButton();
		}

		// Token: 0x0603FBD0 RID: 261072 RVA: 0x00F6C1C3 File Offset: 0x00F6A3C3
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

		// Token: 0x0603FBD1 RID: 261073 RVA: 0x00F6C1E8 File Offset: 0x00F6A3E8
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
