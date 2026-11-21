using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A7 RID: 10663
	public class SetBattleState : ActionParams
	{
		// Token: 0x0600EC43 RID: 60483 RVA: 0x0022C7A2 File Offset: 0x0022A9A2
		public static SetBattleState Create(ISetBattleState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetBattleState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045A3 RID: 17827
		// (get) Token: 0x0600EC44 RID: 60484 RVA: 0x0022C7C1 File Offset: 0x0022A9C1
		public virtual ISendBattleStateType StateOption
		{
			get
			{
				if (this._StateOptionInited)
				{
					return this._StateOptionCache;
				}
				this._StateOptionInited = true;
				this._StateOptionCache = ActionReadHelper.ReadSetBattleState_StateOption(this.Instance);
				return this._StateOptionCache;
			}
		}

		// Token: 0x04008213 RID: 33299
		private ISetBattleState Instance;

		// Token: 0x04008214 RID: 33300
		private ISendBattleStateType _StateOptionCache;

		// Token: 0x04008215 RID: 33301
		private bool _StateOptionInited;
	}
}
