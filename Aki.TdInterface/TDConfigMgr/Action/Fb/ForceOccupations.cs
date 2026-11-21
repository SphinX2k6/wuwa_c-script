using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A80 RID: 10880
	public class ForceOccupations : ActionParams
	{
		// Token: 0x0600F01B RID: 61467 RVA: 0x00232E84 File Offset: 0x00231084
		public static ForceOccupations Create(IForceOccupations? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ForceOccupations
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047C9 RID: 18377
		// (get) Token: 0x0600F01C RID: 61468 RVA: 0x00232EA3 File Offset: 0x002310A3
		public virtual EOccupationActionType OccupationType
		{
			get
			{
				return (EOccupationActionType)this.Instance.OccupationType;
			}
		}

		// Token: 0x170047CA RID: 18378
		// (get) Token: 0x0600F01D RID: 61469 RVA: 0x00232EB0 File Offset: 0x002310B0
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

		// Token: 0x04008406 RID: 33798
		private IForceOccupations Instance;

		// Token: 0x04008407 RID: 33799
		private List<string> _OccupationsCache;

		// Token: 0x04008408 RID: 33800
		private bool _OccupationsInited;
	}
}
