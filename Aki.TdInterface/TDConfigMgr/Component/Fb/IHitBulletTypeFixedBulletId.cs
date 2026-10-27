using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B95 RID: 2965
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitBulletTypeFixedBulletId : IHitBulletType
	{
		// Token: 0x0600441F RID: 17439 RVA: 0x000AD382 File Offset: 0x000AB582
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

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06004420 RID: 17440 RVA: 0x000AD3A1 File Offset: 0x000AB5A1
		public override EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06004421 RID: 17441 RVA: 0x000AD3B0 File Offset: 0x000AB5B0
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

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06004422 RID: 17442 RVA: 0x000AD414 File Offset: 0x000AB614
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

		// Token: 0x04002672 RID: 9842
		private IHitBulletTypeFixedBulletId Instance;

		// Token: 0x04002673 RID: 9843
		private List<long> _BulletIdCache;

		// Token: 0x04002674 RID: 9844
		private bool _BulletIdInited;
	}
}
