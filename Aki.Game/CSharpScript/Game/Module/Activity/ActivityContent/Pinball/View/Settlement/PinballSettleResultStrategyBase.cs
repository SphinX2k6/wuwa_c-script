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
	// Token: 0x020062F5 RID: 25333
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballSettleResultStrategyBase : IPinballSettleResultStrategy
	{
		// Token: 0x170092AE RID: 37550
		// (get) Token: 0x0603FBE5 RID: 261093 RVA: 0x00F6C627 File Offset: 0x00F6A827
		// (set) Token: 0x0603FBE6 RID: 261094 RVA: 0x00F6C62F File Offset: 0x00F6A82F
		public IPinballSettleResultViewContext Context { get; set; }

		// Token: 0x0603FBE7 RID: 261095 RVA: 0x00F6C638 File Offset: 0x00F6A838
		public virtual bool GetIsNeedRewardView()
		{
			return false;
		}

		// Token: 0x0603FBE8 RID: 261096 RVA: 0x00F6C63B File Offset: 0x00F6A83B
		public virtual bool GetIsNeedProgressRewardView()
		{
			return false;
		}

		// Token: 0x0603FBE9 RID: 261097 RVA: 0x00F6C63E File Offset: 0x00F6A83E
		public virtual bool GetIsNeedFailTipsView()
		{
			return false;
		}

		// Token: 0x0603FBEA RID: 261098 RVA: 0x00F6C641 File Offset: 0x00F6A841
		public virtual bool GetIsNeedUnlockTipsView()
		{
			return false;
		}

		// Token: 0x0603FBEB RID: 261099 RVA: 0x00F6C644 File Offset: 0x00F6A844
		public virtual bool GetIsNeedDialogView()
		{
			return false;
		}

		// Token: 0x170092AF RID: 37551
		// (get) Token: 0x0603FBEC RID: 261100 RVA: 0x00F6C647 File Offset: 0x00F6A847
		public virtual bool HasCustomRefreshTitle
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170092B0 RID: 37552
		// (get) Token: 0x0603FBED RID: 261101 RVA: 0x00F6C64A File Offset: 0x00F6A84A
		public virtual bool HasCustomRefreshFailTips
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170092B1 RID: 37553
		// (get) Token: 0x0603FBEE RID: 261102 RVA: 0x00F6C64D File Offset: 0x00F6A84D
		public virtual bool HasCustomRefreshDialog
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0603FBEF RID: 261103 RVA: 0x00F6C650 File Offset: 0x00F6A850
		public virtual void RefreshTitle()
		{
		}

		// Token: 0x0603FBF0 RID: 261104 RVA: 0x00F6C652 File Offset: 0x00F6A852
		public virtual void RefreshStarLayout()
		{
		}

		// Token: 0x0603FBF1 RID: 261105 RVA: 0x00F6C654 File Offset: 0x00F6A854
		public virtual void RefreshRewards()
		{
		}

		// Token: 0x0603FBF2 RID: 261106 RVA: 0x00F6C656 File Offset: 0x00F6A856
		public virtual void RefreshButtons()
		{
		}

		// Token: 0x0603FBF3 RID: 261107 RVA: 0x00F6C658 File Offset: 0x00F6A858
		public virtual void RefreshProgressRewards()
		{
		}

		// Token: 0x0603FBF4 RID: 261108 RVA: 0x00F6C65A File Offset: 0x00F6A85A
		public virtual void RefreshUnlockTips()
		{
		}

		// Token: 0x0603FBF5 RID: 261109 RVA: 0x00F6C65C File Offset: 0x00F6A85C
		public virtual void RefreshFailTips()
		{
		}

		// Token: 0x0603FBF6 RID: 261110 RVA: 0x00F6C65E File Offset: 0x00F6A85E
		public virtual void RefreshDialog()
		{
		}

		// Token: 0x0603FBF7 RID: 261111 RVA: 0x00F6C660 File Offset: 0x00F6A860
		public virtual void OnClickBtnRestart(Action callback)
		{
		}

		// Token: 0x0603FBF8 RID: 261112 RVA: 0x00F6C662 File Offset: 0x00F6A862
		public virtual void OnClickBtnNext(Action callback)
		{
		}

		// Token: 0x0603FBF9 RID: 261113 RVA: 0x00F6C664 File Offset: 0x00F6A864
		public virtual void OnClickBtnBack(Action callback)
		{
		}

		// Token: 0x0603FBFA RID: 261114 RVA: 0x00F6C668 File Offset: 0x00F6A868
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

		// Token: 0x0603FBFB RID: 261115 RVA: 0x00F6C744 File Offset: 0x00F6A944
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

		// Token: 0x0603FBFC RID: 261116 RVA: 0x00F6C78C File Offset: 0x00F6A98C
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
