using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200040C RID: 1036
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitBulletGroup
	{
		// Token: 0x060014EB RID: 5355 RVA: 0x00042394 File Offset: 0x00040594
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

		// Token: 0x060014EC RID: 5356 RVA: 0x000423CC File Offset: 0x000405CC
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

		// Token: 0x060014ED RID: 5357 RVA: 0x000423DF File Offset: 0x000405DF
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

		// Token: 0x060014EE RID: 5358 RVA: 0x000423F2 File Offset: 0x000405F2
		public IHitBulletGroup_SetValue ToSetValue()
		{
			return new IHitBulletGroup_SetValue
			{
				MatchAny = this.MatchAny,
				HitBullets = this.HitBullets
			};
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00042411 File Offset: 0x00040611
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x0004243C File Offset: 0x0004063C
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

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x0004244A File Offset: 0x0004064A
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x00042471 File Offset: 0x00040671
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

		// Token: 0x04001052 RID: 4178
		[Nullable(2)]
		protected IHitBulletGroup FbInstance;

		// Token: 0x04001053 RID: 4179
		[Nullable(2)]
		protected IHitBulletGroup_SetValue PocoInterface;
	}
}
