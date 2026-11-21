using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3A RID: 3642
	public class IBatchBulletItem
	{
		// Token: 0x0600527A RID: 21114 RVA: 0x000CBED6 File Offset: 0x000CA0D6
		public static IBatchBulletItem Create(IBatchBulletItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBatchBulletItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x0600527B RID: 21115 RVA: 0x000CBEF5 File Offset: 0x000CA0F5
		public virtual int Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x0600527C RID: 21116 RVA: 0x000CBF04 File Offset: 0x000CA104
		public virtual List<IBatchBulletCaster> CasterList
		{
			get
			{
				if (this._CasterListInited)
				{
					return this._CasterListCache;
				}
				this._CasterListInited = true;
				int casterListLength = this.Instance.CasterListLength;
				this._CasterListCache = new List<IBatchBulletCaster>(casterListLength);
				for (int i = 0; i < casterListLength; i++)
				{
					this._CasterListCache.Add(IBatchBulletCaster.Create(this.Instance.CasterList(i)));
				}
				return this._CasterListCache;
			}
		}

		// Token: 0x04002F1B RID: 12059
		private IBatchBulletItem Instance;

		// Token: 0x04002F1C RID: 12060
		private List<IBatchBulletCaster> _CasterListCache;

		// Token: 0x04002F1D RID: 12061
		private bool _CasterListInited;
	}
}
