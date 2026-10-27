using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AC RID: 10156
	[NullableContext(1)]
	[Nullable(0)]
	public class ManualOccupations : ActionParams
	{
		// Token: 0x0600E1F5 RID: 57845 RVA: 0x00216015 File Offset: 0x00214215
		public static ManualOccupations Create(IManualOccupations? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ManualOccupations
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700445F RID: 17503
		// (get) Token: 0x0600E1F6 RID: 57846 RVA: 0x00216034 File Offset: 0x00214234
		public virtual EOccupationActionType OccupationType
		{
			get
			{
				return (EOccupationActionType)this.Instance.OccupationType;
			}
		}

		// Token: 0x17004460 RID: 17504
		// (get) Token: 0x0600E1F7 RID: 57847 RVA: 0x00216044 File Offset: 0x00214244
		public virtual List<string> Occupations
		{
			get
			{
				if (this._OccupationsInited)
				{
					return this._OccupationsCache;
				}
				this._OccupationsInited = true;
				int occupationsLength = this.Instance.OccupationsLength;
				this._OccupationsCache = new List<string>(occupationsLength);
				for (int i = 0; i < occupationsLength; i++)
				{
					this._OccupationsCache.Add(this.Instance.Occupations(i));
				}
				return this._OccupationsCache;
			}
		}

		// Token: 0x04007D4C RID: 32076
		private IManualOccupations Instance;

		// Token: 0x04007D4D RID: 32077
		private List<string> _OccupationsCache;

		// Token: 0x04007D4E RID: 32078
		private bool _OccupationsInited;
	}
}
