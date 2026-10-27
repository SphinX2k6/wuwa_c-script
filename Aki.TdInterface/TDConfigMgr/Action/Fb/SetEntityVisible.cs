using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002643 RID: 9795
	[NullableContext(1)]
	[Nullable(0)]
	public class SetEntityVisible : ActionParams
	{
		// Token: 0x0600DBC1 RID: 56257 RVA: 0x0020B490 File Offset: 0x00209690
		public static SetEntityVisible Create(ISetEntityVisible? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetEntityVisible
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x0600DBC2 RID: 56258 RVA: 0x0020B4B0 File Offset: 0x002096B0
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x0600DBC3 RID: 56259 RVA: 0x0020B514 File Offset: 0x00209714
		public virtual bool Visible
		{
			get
			{
				return this.Instance.Visible;
			}
		}

		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x0600DBC4 RID: 56260 RVA: 0x0020B524 File Offset: 0x00209724
		public virtual bool? PerformDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.PerformDestroy);
			}
		}

		// Token: 0x04007A1D RID: 31261
		private ISetEntityVisible Instance;

		// Token: 0x04007A1E RID: 31262
		private List<int> _EntityIdsCache;

		// Token: 0x04007A1F RID: 31263
		private bool _EntityIdsInited;
	}
}
