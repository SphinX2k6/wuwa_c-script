using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AD RID: 10157
	[NullableContext(1)]
	[Nullable(0)]
	public class ForceOccupations : ActionParams
	{
		// Token: 0x0600E1F9 RID: 57849 RVA: 0x002160B0 File Offset: 0x002142B0
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

		// Token: 0x17004461 RID: 17505
		// (get) Token: 0x0600E1FA RID: 57850 RVA: 0x002160CF File Offset: 0x002142CF
		public virtual EOccupationActionType OccupationType
		{
			get
			{
				return (EOccupationActionType)this.Instance.OccupationType;
			}
		}

		// Token: 0x17004462 RID: 17506
		// (get) Token: 0x0600E1FB RID: 57851 RVA: 0x002160DC File Offset: 0x002142DC
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

		// Token: 0x04007D4F RID: 32079
		private IForceOccupations Instance;

		// Token: 0x04007D50 RID: 32080
		private List<string> _OccupationsCache;

		// Token: 0x04007D51 RID: 32081
		private bool _OccupationsInited;
	}
}
