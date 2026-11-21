using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000465 RID: 1125
	public class IHitBulletGroup
	{
		// Token: 0x06001685 RID: 5765 RVA: 0x000460DC File Offset: 0x000442DC
		private IHitBulletGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitBulletGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitBulletGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitBulletGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00046114 File Offset: 0x00044314
		public static IHitBulletGroup Create([Nullable(2)] IHitBulletGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00046127 File Offset: 0x00044327
		public static IHitBulletGroup CreateFromSetValue([Nullable(2)] IHitBulletGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitBulletGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0004613A File Offset: 0x0004433A
		public IHitBulletGroup_SetValue ToSetValue()
		{
			return new IHitBulletGroup_SetValue
			{
				MatchAny = this.MatchAny,
				HitBullets = this.HitBullets
			};
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x00046159 File Offset: 0x00044359
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x00046184 File Offset: 0x00044384
		public virtual bool MatchAny
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MatchAny;
				}
				return this.PocoInterface != null && this.PocoInterface.MatchAny;
			}
			set
			{
				this.GetOrCreatePoco().MatchAny = value;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x00046192 File Offset: 0x00044392
		// (set) Token: 0x0600168C RID: 5772 RVA: 0x000461B9 File Offset: 0x000443B9
		public virtual List<IHitBulletType> HitBullets
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitBullets;
				}
				IHitBulletGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HitBullets;
			}
			set
			{
				this.GetOrCreatePoco().HitBullets = value;
			}
		}

		// Token: 0x04001174 RID: 4468
		[Nullable(2)]
		protected IHitBulletGroup FbInstance;

		// Token: 0x04001175 RID: 4469
		[Nullable(2)]
		protected IHitBulletGroup_SetValue PocoInterface;
	}
}
