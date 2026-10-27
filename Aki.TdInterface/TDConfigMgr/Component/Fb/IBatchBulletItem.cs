using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D40 RID: 3392
	[NullableContext(1)]
	[Nullable(0)]
	public class IBatchBulletItem
	{
		// Token: 0x06004D5E RID: 19806 RVA: 0x000C0792 File Offset: 0x000BE992
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

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06004D5F RID: 19807 RVA: 0x000C07B1 File Offset: 0x000BE9B1
		public virtual int Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06004D60 RID: 19808 RVA: 0x000C07C0 File Offset: 0x000BE9C0
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

		// Token: 0x04002C5B RID: 11355
		private IBatchBulletItem Instance;

		// Token: 0x04002C5C RID: 11356
		private List<IBatchBulletCaster> _CasterListCache;

		// Token: 0x04002C5D RID: 11357
		private bool _CasterListInited;
	}
}
