using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000250 RID: 592
	public class ICdRefreshRule : IRefreshRule
	{
		// Token: 0x06000A16 RID: 2582 RVA: 0x0002B188 File Offset: 0x00029388
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

		// Token: 0x06000A17 RID: 2583 RVA: 0x0002B1C0 File Offset: 0x000293C0
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

		// Token: 0x06000A18 RID: 2584 RVA: 0x0002B1D3 File Offset: 0x000293D3
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

		// Token: 0x06000A19 RID: 2585 RVA: 0x0002B1E6 File Offset: 0x000293E6
		public new ICdRefreshRule_SetValue ToSetValue()
		{
			return new ICdRefreshRule_SetValue
			{
				Type = this.Type,
				Cd = this.Cd
			};
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0002B205 File Offset: 0x00029405
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x0002B230 File Offset: 0x00029430
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0002B23E File Offset: 0x0002943E
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x0002B269 File Offset: 0x00029469
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

		// Token: 0x04000A77 RID: 2679
		[Nullable(2)]
		protected new ICdRefreshRule FbInstance;

		// Token: 0x04000A78 RID: 2680
		[Nullable(2)]
		protected new ICdRefreshRule_SetValue PocoInterface;
	}
}
