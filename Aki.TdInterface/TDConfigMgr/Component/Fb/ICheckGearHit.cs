using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA5 RID: 2981
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckGearHit
	{
		// Token: 0x0600446D RID: 17517 RVA: 0x000ADCF8 File Offset: 0x000ABEF8
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

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x0600446E RID: 17518 RVA: 0x000ADD17 File Offset: 0x000ABF17
		public virtual int HitIndex
		{
			get
			{
				return this.Instance.HitIndex;
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x000ADD24 File Offset: 0x000ABF24
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

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06004470 RID: 17520 RVA: 0x000ADD88 File Offset: 0x000ABF88
		public virtual EGearHitAffectType AffectType
		{
			get
			{
				return (EGearHitAffectType)this.Instance.AffectType;
			}
		}

		// Token: 0x040026A2 RID: 9890
		private ICheckGearHit Instance;

		// Token: 0x040026A3 RID: 9891
		private List<int> _AffectIndexCache;

		// Token: 0x040026A4 RID: 9892
		private bool _AffectIndexInited;
	}
}
