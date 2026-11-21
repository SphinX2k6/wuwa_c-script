using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029CB RID: 10699
	public class ExecClientBattleAction : ActionParams
	{
		// Token: 0x0600ECDA RID: 60634 RVA: 0x0022D721 File Offset: 0x0022B921
		public static ExecClientBattleAction Create(IExecClientBattleAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecClientBattleAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045F2 RID: 17906
		// (get) Token: 0x0600ECDB RID: 60635 RVA: 0x0022D740 File Offset: 0x0022B940
		public virtual IExecClientBattleActionType ClientBattleOption
		{
			get
			{
				if (this._ClientBattleOptionInited)
				{
					return this._ClientBattleOptionCache;
				}
				this._ClientBattleOptionInited = true;
				this._ClientBattleOptionCache = ActionReadHelper.ReadExecClientBattleAction_ClientBattleOption(this.Instance);
				return this._ClientBattleOptionCache;
			}
		}

		// Token: 0x0400825D RID: 33373
		private IExecClientBattleAction Instance;

		// Token: 0x0400825E RID: 33374
		private IExecClientBattleActionType _ClientBattleOptionCache;

		// Token: 0x0400825F RID: 33375
		private bool _ClientBattleOptionInited;
	}
}
