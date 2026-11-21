using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029ED RID: 10733
	public class INpcFollowConfig
	{
		// Token: 0x0600ED65 RID: 60773 RVA: 0x0022E639 File Offset: 0x0022C839
		public static INpcFollowConfig Create(INpcFollowConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcFollowConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004639 RID: 17977
		// (get) Token: 0x0600ED66 RID: 60774 RVA: 0x0022E658 File Offset: 0x0022C858
		public virtual IPerformerRangeBoundaryActionTrigger PerformerWhenEnter
		{
			get
			{
				if (this._PerformerWhenEnterInited)
				{
					return this._PerformerWhenEnterCache;
				}
				this._PerformerWhenEnterInited = true;
				this._PerformerWhenEnterCache = IPerformerRangeBoundaryActionTrigger.Create(this.Instance.PerformerWhenEnter);
				return this._PerformerWhenEnterCache;
			}
		}

		// Token: 0x1700463A RID: 17978
		// (get) Token: 0x0600ED67 RID: 60775 RVA: 0x0022E68C File Offset: 0x0022C88C
		public virtual IPerformerRangeBoundaryActionTrigger PerformerWhenExit
		{
			get
			{
				if (this._PerformerWhenExitInited)
				{
					return this._PerformerWhenExitCache;
				}
				this._PerformerWhenExitInited = true;
				this._PerformerWhenExitCache = IPerformerRangeBoundaryActionTrigger.Create(this.Instance.PerformerWhenExit);
				return this._PerformerWhenExitCache;
			}
		}

		// Token: 0x040082A7 RID: 33447
		private INpcFollowConfig Instance;

		// Token: 0x040082A8 RID: 33448
		[Nullable(2)]
		private IPerformerRangeBoundaryActionTrigger _PerformerWhenEnterCache;

		// Token: 0x040082A9 RID: 33449
		private bool _PerformerWhenEnterInited;

		// Token: 0x040082AA RID: 33450
		[Nullable(2)]
		private IPerformerRangeBoundaryActionTrigger _PerformerWhenExitCache;

		// Token: 0x040082AB RID: 33451
		private bool _PerformerWhenExitInited;
	}
}
