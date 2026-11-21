using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B5 RID: 10677
	public class ExecBattleAction : ActionParams
	{
		// Token: 0x0600EC7F RID: 60543 RVA: 0x0022CEDA File Offset: 0x0022B0DA
		public static ExecBattleAction Create(IExecBattleAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecBattleAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045C3 RID: 17859
		// (get) Token: 0x0600EC80 RID: 60544 RVA: 0x0022CEF9 File Offset: 0x0022B0F9
		public virtual IExecBattleActionType BattleOption
		{
			get
			{
				if (this._BattleOptionInited)
				{
					return this._BattleOptionCache;
				}
				this._BattleOptionInited = true;
				this._BattleOptionCache = ActionReadHelper.ReadExecBattleAction_BattleOption(this.Instance);
				return this._BattleOptionCache;
			}
		}

		// Token: 0x04008233 RID: 33331
		private IExecBattleAction Instance;

		// Token: 0x04008234 RID: 33332
		private IExecBattleActionType _BattleOptionCache;

		// Token: 0x04008235 RID: 33333
		private bool _BattleOptionInited;
	}
}
