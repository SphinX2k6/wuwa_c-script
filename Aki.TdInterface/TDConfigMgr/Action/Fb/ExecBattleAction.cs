using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026EF RID: 9967
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecBattleAction : ActionParams
	{
		// Token: 0x0600DE98 RID: 56984 RVA: 0x002105A4 File Offset: 0x0020E7A4
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

		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x0600DE99 RID: 56985 RVA: 0x002105C3 File Offset: 0x0020E7C3
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

		// Token: 0x04007B8F RID: 31631
		private IExecBattleAction Instance;

		// Token: 0x04007B90 RID: 31632
		private IExecBattleActionType _BattleOptionCache;

		// Token: 0x04007B91 RID: 31633
		private bool _BattleOptionInited;
	}
}
