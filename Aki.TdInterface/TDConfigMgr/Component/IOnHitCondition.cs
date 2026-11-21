using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000615 RID: 1557
	public class IOnHitCondition : IBulletCreateCondition
	{
		// Token: 0x060020AE RID: 8366 RVA: 0x0005B9C8 File Offset: 0x00059BC8
		private IOnHitCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnHitCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnHitCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnHitCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0005BA00 File Offset: 0x00059C00
		public static IOnHitCondition Create([Nullable(2)] IOnHitCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnHitCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0005BA13 File Offset: 0x00059C13
		public static IOnHitCondition CreateFromSetValue([Nullable(2)] IOnHitCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnHitCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0005BA26 File Offset: 0x00059C26
		public new IOnHitCondition_SetValue ToSetValue()
		{
			return new IOnHitCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId
			};
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0005BA45 File Offset: 0x00059C45
		// (set) Token: 0x060020B3 RID: 8371 RVA: 0x0005BA70 File Offset: 0x00059C70
		public override EBulletCreateCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBulletCreateCondition.OnHit;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0005BA7E File Offset: 0x00059C7E
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x0005BAAA File Offset: 0x00059CAA
		public override long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x04001741 RID: 5953
		[Nullable(2)]
		protected new IOnHitCondition FbInstance;

		// Token: 0x04001742 RID: 5954
		[Nullable(2)]
		protected new IOnHitCondition_SetValue PocoInterface;
	}
}
