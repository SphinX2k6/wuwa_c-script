using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000229 RID: 553
	[NullableContext(1)]
	[Nullable(0)]
	public class ICdRefreshRule : IRefreshRule
	{
		// Token: 0x060009A2 RID: 2466 RVA: 0x000299C8 File Offset: 0x00027BC8
		private ICdRefreshRule_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICdRefreshRule 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICdRefreshRule_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICdRefreshRule_SetValue());
			}
			return result;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00029A00 File Offset: 0x00027C00
		public static ICdRefreshRule Create([Nullable(2)] ICdRefreshRule instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICdRefreshRule
			{
				FbInstance = instance
			};
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00029A13 File Offset: 0x00027C13
		public static ICdRefreshRule CreateFromSetValue([Nullable(2)] ICdRefreshRule_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICdRefreshRule
			{
				PocoInterface = value
			};
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00029A26 File Offset: 0x00027C26
		public new ICdRefreshRule_SetValue ToSetValue()
		{
			return new ICdRefreshRule_SetValue
			{
				Type = this.Type,
				Cd = this.Cd
			};
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00029A45 File Offset: 0x00027C45
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00029A70 File Offset: 0x00027C70
		public override ERefreshRule Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERefreshRule.CD;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00029A7E File Offset: 0x00027C7E
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00029AA9 File Offset: 0x00027CA9
		public virtual int Cd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Cd;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Cd;
			}
			set
			{
				this.GetOrCreatePoco().Cd = value;
			}
		}

		// Token: 0x040009ED RID: 2541
		[Nullable(2)]
		protected new ICdRefreshRule FbInstance;

		// Token: 0x040009EE RID: 2542
		[Nullable(2)]
		protected new ICdRefreshRule_SetValue PocoInterface;
	}
}
