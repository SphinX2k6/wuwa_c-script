using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026E3 RID: 9955
	[NullableContext(1)]
	[Nullable(0)]
	public class SetBattleState : ActionParams
	{
		// Token: 0x0600DE67 RID: 56935 RVA: 0x0020FF62 File Offset: 0x0020E162
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

		// Token: 0x17004263 RID: 16995
		// (get) Token: 0x0600DE68 RID: 56936 RVA: 0x0020FF81 File Offset: 0x0020E181
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

		// Token: 0x04007B73 RID: 31603
		private ISetBattleState Instance;

		// Token: 0x04007B74 RID: 31604
		private ISendBattleStateType _StateOptionCache;

		// Token: 0x04007B75 RID: 31605
		private bool _StateOptionInited;
	}
}
