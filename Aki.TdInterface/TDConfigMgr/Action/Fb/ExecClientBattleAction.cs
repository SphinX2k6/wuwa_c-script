using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002704 RID: 9988
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecClientBattleAction : ActionParams
	{
		// Token: 0x0600DEEE RID: 57070 RVA: 0x00210D78 File Offset: 0x0020EF78
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

		// Token: 0x170042A8 RID: 17064
		// (get) Token: 0x0600DEEF RID: 57071 RVA: 0x00210D97 File Offset: 0x0020EF97
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

		// Token: 0x04007BB8 RID: 31672
		private IExecClientBattleAction Instance;

		// Token: 0x04007BB9 RID: 31673
		private IExecClientBattleActionType _ClientBattleOptionCache;

		// Token: 0x04007BBA RID: 31674
		private bool _ClientBattleOptionInited;
	}
}
