using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C73 RID: 3187
	public class ICheckGearHit
	{
		// Token: 0x060048C6 RID: 18630 RVA: 0x000B7DBC File Offset: 0x000B5FBC
		public static ICheckGearHit Create(ICheckGearHit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckGearHit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x060048C7 RID: 18631 RVA: 0x000B7DDB File Offset: 0x000B5FDB
		public virtual int HitIndex
		{
			get
			{
				return this.Instance.HitIndex;
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x060048C8 RID: 18632 RVA: 0x000B7DE8 File Offset: 0x000B5FE8
		public virtual List<int> AffectIndex
		{
			get
			{
				if (this._AffectIndexInited)
				{
					return this._AffectIndexCache;
				}
				this._AffectIndexInited = true;
				int affectIndexLength = this.Instance.AffectIndexLength;
				this._AffectIndexCache = new List<int>(affectIndexLength);
				for (int i = 0; i < affectIndexLength; i++)
				{
					this._AffectIndexCache.Add(this.Instance.AffectIndex(i));
				}
				return this._AffectIndexCache;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x060048C9 RID: 18633 RVA: 0x000B7E4C File Offset: 0x000B604C
		public virtual EGearHitAffectType AffectType
		{
			get
			{
				return (EGearHitAffectType)this.Instance.AffectType;
			}
		}

		// Token: 0x040028EA RID: 10474
		private ICheckGearHit Instance;

		// Token: 0x040028EB RID: 10475
		private List<int> _AffectIndexCache;

		// Token: 0x040028EC RID: 10476
		private bool _AffectIndexInited;
	}
}
