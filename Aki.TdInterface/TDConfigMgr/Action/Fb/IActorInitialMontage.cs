using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277E RID: 10110
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorInitialMontage
	{
		// Token: 0x0600E117 RID: 57623 RVA: 0x00214251 File Offset: 0x00212451
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

		// Token: 0x170043DD RID: 17373
		// (get) Token: 0x0600E118 RID: 57624 RVA: 0x00214270 File Offset: 0x00212470
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

		// Token: 0x04007CB0 RID: 31920
		private IActorInitialMontage Instance;

		// Token: 0x04007CB1 RID: 31921
		[Nullable(2)]
		private IMontageId _MontageIdCache;

		// Token: 0x04007CB2 RID: 31922
		private bool _MontageIdInited;
	}
}
