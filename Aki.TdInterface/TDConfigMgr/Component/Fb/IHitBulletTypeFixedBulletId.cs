using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C63 RID: 3171
	public class IHitBulletTypeFixedBulletId : IHitBulletType
	{
		// Token: 0x06004878 RID: 18552 RVA: 0x000B7446 File Offset: 0x000B5646
		public static IHitBulletTypeFixedBulletId Create(IHitBulletTypeFixedBulletId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypeFixedBulletId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06004879 RID: 18553 RVA: 0x000B7465 File Offset: 0x000B5665
		public override EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x0600487A RID: 18554 RVA: 0x000B7474 File Offset: 0x000B5674
		public virtual List<long> BulletId
		{
			get
			{
				if (this._BulletIdInited)
				{
					return this._BulletIdCache;
				}
				this._BulletIdInited = true;
				int bulletIdLength = this.Instance.BulletIdLength;
				this._BulletIdCache = new List<long>(bulletIdLength);
				for (int i = 0; i < bulletIdLength; i++)
				{
					this._BulletIdCache.Add(this.Instance.BulletId(i));
				}
				return this._BulletIdCache;
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x000B74D8 File Offset: 0x000B56D8
		public virtual bool? PlayerAttack
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.PlayerAttack);
			}
		}

		// Token: 0x040028BA RID: 10426
		private IHitBulletTypeFixedBulletId Instance;

		// Token: 0x040028BB RID: 10427
		private List<long> _BulletIdCache;

		// Token: 0x040028BC RID: 10428
		private bool _BulletIdInited;
	}
}
