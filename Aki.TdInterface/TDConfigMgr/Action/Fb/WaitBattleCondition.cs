using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D0 RID: 10704
	public class WaitBattleCondition : ActionParams
	{
		// Token: 0x0600ECEC RID: 60652 RVA: 0x0022D895 File Offset: 0x0022BA95
		public static WaitBattleCondition Create(IWaitBattleCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WaitBattleCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045FA RID: 17914
		// (get) Token: 0x0600ECED RID: 60653 RVA: 0x0022D8B4 File Offset: 0x0022BAB4
		public virtual IDetectBattleTag StateOption
		{
			get
			{
				if (this._StateOptionInited)
				{
					return this._StateOptionCache;
				}
				this._StateOptionInited = true;
				this._StateOptionCache = IDetectBattleTag.Create(this.Instance.StateOption);
				return this._StateOptionCache;
			}
		}

		// Token: 0x04008266 RID: 33382
		private IWaitBattleCondition Instance;

		// Token: 0x04008267 RID: 33383
		[Nullable(2)]
		private IDetectBattleTag _StateOptionCache;

		// Token: 0x04008268 RID: 33384
		private bool _StateOptionInited;
	}
}
