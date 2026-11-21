using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A50 RID: 10832
	public class IActorInitialMontage
	{
		// Token: 0x0600EF35 RID: 61237 RVA: 0x00230FE5 File Offset: 0x0022F1E5
		public static IActorInitialMontage Create(IActorInitialMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorInitialMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004743 RID: 18243
		// (get) Token: 0x0600EF36 RID: 61238 RVA: 0x00231004 File Offset: 0x0022F204
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				this._MontageIdCache = IMontageId.Create(this.Instance.MontageId);
				return this._MontageIdCache;
			}
		}

		// Token: 0x04008366 RID: 33638
		private IActorInitialMontage Instance;

		// Token: 0x04008367 RID: 33639
		[Nullable(2)]
		private IMontageId _MontageIdCache;

		// Token: 0x04008368 RID: 33640
		private bool _MontageIdInited;
	}
}
