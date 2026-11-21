using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A7F RID: 10879
	public class ManualOccupations : ActionParams
	{
		// Token: 0x0600F017 RID: 61463 RVA: 0x00232DEA File Offset: 0x00230FEA
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

		// Token: 0x170047C7 RID: 18375
		// (get) Token: 0x0600F018 RID: 61464 RVA: 0x00232E09 File Offset: 0x00231009
		public virtual EOccupationActionType OccupationType
		{
			get
			{
				return (EOccupationActionType)this.Instance.OccupationType;
			}
		}

		// Token: 0x170047C8 RID: 18376
		// (get) Token: 0x0600F019 RID: 61465 RVA: 0x00232E18 File Offset: 0x00231018
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

		// Token: 0x04008403 RID: 33795
		private IManualOccupations Instance;

		// Token: 0x04008404 RID: 33796
		private List<string> _OccupationsCache;

		// Token: 0x04008405 RID: 33797
		private bool _OccupationsInited;
	}
}
