using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x02005273 RID: 21107
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballSettleResultStrategyBase : IPinballSettleResultStrategy
	{
		// Token: 0x17006610 RID: 26128
		// (get) Token: 0x060348A6 RID: 215206 RVA: 0x00EB3583 File Offset: 0x00EB1783
		// (set) Token: 0x060348A7 RID: 215207 RVA: 0x00EB358B File Offset: 0x00EB178B
		public IPinballSettleResultViewContext Context { get; set; }

		// Token: 0x060348A8 RID: 215208 RVA: 0x00EB3594 File Offset: 0x00EB1794
		public virtual bool GetIsNeedRewardView()
		{
			return false;
		}

		// Token: 0x060348A9 RID: 215209 RVA: 0x00EB3597 File Offset: 0x00EB1797
		public virtual bool GetIsNeedProgressRewardView()
		{
			return false;
		}

		// Token: 0x060348AA RID: 215210 RVA: 0x00EB359A File Offset: 0x00EB179A
		public virtual bool GetIsNeedFailTipsView()
		{
			return false;
		}

		// Token: 0x060348AB RID: 215211 RVA: 0x00EB359D File Offset: 0x00EB179D
		public virtual bool GetIsNeedUnlockTipsView()
		{
			return false;
		}

		// Token: 0x060348AC RID: 215212 RVA: 0x00EB35A0 File Offset: 0x00EB17A0
		public virtual bool GetIsNeedDialogView()
		{
			return false;
		}

		// Token: 0x17006611 RID: 26129
		// (get) Token: 0x060348AD RID: 215213 RVA: 0x00EB35A3 File Offset: 0x00EB17A3
		public virtual bool HasCustomRefreshTitle
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17006612 RID: 26130
		// (get) Token: 0x060348AE RID: 215214 RVA: 0x00EB35A6 File Offset: 0x00EB17A6
		public virtual bool HasCustomRefreshFailTips
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17006613 RID: 26131
		// (get) Token: 0x060348AF RID: 215215 RVA: 0x00EB35A9 File Offset: 0x00EB17A9
		public virtual bool HasCustomRefreshDialog
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060348B0 RID: 215216 RVA: 0x00EB35AC File Offset: 0x00EB17AC
		public virtual void RefreshTitle()
		{
		}

		// Token: 0x060348B1 RID: 215217 RVA: 0x00EB35AE File Offset: 0x00EB17AE
		public virtual void RefreshStarLayout()
		{
		}

		// Token: 0x060348B2 RID: 215218 RVA: 0x00EB35B0 File Offset: 0x00EB17B0
		public virtual void RefreshRewards()
		{
		}

		// Token: 0x060348B3 RID: 215219 RVA: 0x00EB35B2 File Offset: 0x00EB17B2
		public virtual void RefreshButtons()
		{
		}

		// Token: 0x060348B4 RID: 215220 RVA: 0x00EB35B4 File Offset: 0x00EB17B4
		public virtual void RefreshProgressRewards()
		{
		}

		// Token: 0x060348B5 RID: 215221 RVA: 0x00EB35B6 File Offset: 0x00EB17B6
		public virtual void RefreshUnlockTips()
		{
		}

		// Token: 0x060348B6 RID: 215222 RVA: 0x00EB35B8 File Offset: 0x00EB17B8
		public virtual void RefreshFailTips()
		{
		}

		// Token: 0x060348B7 RID: 215223 RVA: 0x00EB35BA File Offset: 0x00EB17BA
		public virtual void RefreshDialog()
		{
		}

		// Token: 0x060348B8 RID: 215224 RVA: 0x00EB35BC File Offset: 0x00EB17BC
		public virtual void OnClickBtnRestart(Action callback)
		{
		}

		// Token: 0x060348B9 RID: 215225 RVA: 0x00EB35BE File Offset: 0x00EB17BE
		public virtual void OnClickBtnNext(Action callback)
		{
		}

		// Token: 0x060348BA RID: 215226 RVA: 0x00EB35C0 File Offset: 0x00EB17C0
		public virtual void OnClickBtnBack(Action callback)
		{
		}

		// Token: 0x060348BB RID: 215227 RVA: 0x00EB35C4 File Offset: 0x00EB17C4
		protected void RestartImmediate()
		{
			List<int> list = new List<int>();
			int levelId = this.Context.GetOpenParam().LevelId;
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
			if (pinballLevelConfigById.Value.TrailRoleLength == 0)
			{
				foreach (int item in this.Context.GetOpenParam().Roles.Keys)
				{
					list.Add(item);
				}
			}
			PinballBattleSubController.RequestEnterInst(levelId, list);
		}

		// Token: 0x060348BC RID: 215228 RVA: 0x00EB36A0 File Offset: 0x00EB18A0
		protected void OpenFormationView()
		{
			int levelId = this.Context.GetOpenParam().LevelId;
			PinballFormationViewData param = new PinballFormationViewData
			{
				LevelId = levelId,
				IfReturnToPinballMainView = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.PinballFormationView, param, null);
		}

		// Token: 0x060348BD RID: 215229 RVA: 0x00EB36E8 File Offset: 0x00EB18E8
		protected void OpenMainRootView()
		{
			PinballMainRootViewOpenParam openParam = new PinballMainRootViewOpenParam
			{
				ChildView = "PinballMainView",
				IsFromInstanceDungeon = new bool?(true)
			};
			PinballController.Instance.OpenMainRootView(openParam).Forget<bool>();
		}
	}
}
