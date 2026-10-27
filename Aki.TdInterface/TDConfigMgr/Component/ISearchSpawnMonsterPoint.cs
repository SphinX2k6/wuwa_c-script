using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006BA RID: 1722
	[NullableContext(1)]
	[Nullable(0)]
	public class ISearchSpawnMonsterPoint : IRangeConstraint
	{
		// Token: 0x06002500 RID: 9472 RVA: 0x00063EA4 File Offset: 0x000620A4
		private ISearchSpawnMonsterPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISearchSpawnMonsterPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISearchSpawnMonsterPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISearchSpawnMonsterPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x00063EDC File Offset: 0x000620DC
		public static ISearchSpawnMonsterPoint Create([Nullable(2)] ISearchSpawnMonsterPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISearchSpawnMonsterPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00063EEF File Offset: 0x000620EF
		public static ISearchSpawnMonsterPoint CreateFromSetValue([Nullable(2)] ISearchSpawnMonsterPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISearchSpawnMonsterPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00063F02 File Offset: 0x00062102
		public new ISearchSpawnMonsterPoint_SetValue ToSetValue()
		{
			return new ISearchSpawnMonsterPoint_SetValue
			{
				Type = this.Type,
				Radius = this.Radius,
				TagId = this.TagId
			};
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x00063F2D File Offset: 0x0006212D
		// (set) Token: 0x06002505 RID: 9477 RVA: 0x00063F58 File Offset: 0x00062158
		public override ERangeConstraint Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERangeConstraint.SearchSpawnMonsterPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x00063F66 File Offset: 0x00062166
		// (set) Token: 0x06002507 RID: 9479 RVA: 0x00063F91 File Offset: 0x00062191
		public virtual int Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x00063FA0 File Offset: 0x000621A0
		// (set) Token: 0x06002509 RID: 9481 RVA: 0x00063FDA File Offset: 0x000621DA
		public virtual int? TagId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TagId;
				}
				ISearchSpawnMonsterPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TagId;
			}
			set
			{
				this.GetOrCreatePoco().TagId = value;
			}
		}

		// Token: 0x04001954 RID: 6484
		[Nullable(2)]
		protected new ISearchSpawnMonsterPoint FbInstance;

		// Token: 0x04001955 RID: 6485
		[Nullable(2)]
		protected new ISearchSpawnMonsterPoint_SetValue PocoInterface;
	}
}
