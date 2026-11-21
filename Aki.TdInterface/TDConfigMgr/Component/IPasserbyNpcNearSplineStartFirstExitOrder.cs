using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000647 RID: 1607
	public class IPasserbyNpcNearSplineStartFirstExitOrder : IPasserbyNpcExitOrderBase
	{
		// Token: 0x060021C0 RID: 8640 RVA: 0x0005DAB4 File Offset: 0x0005BCB4
		private IPasserbyNpcNearSplineStartFirstExitOrder_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcNearSplineStartFirstExitOrder 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcNearSplineStartFirstExitOrder_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcNearSplineStartFirstExitOrder_SetValue());
			}
			return result;
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0005DAEC File Offset: 0x0005BCEC
		public static IPasserbyNpcNearSplineStartFirstExitOrder Create([Nullable(2)] IPasserbyNpcNearSplineStartFirstExitOrder instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcNearSplineStartFirstExitOrder
			{
				FbInstance = instance
			};
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0005DAFF File Offset: 0x0005BCFF
		public static IPasserbyNpcNearSplineStartFirstExitOrder CreateFromSetValue([Nullable(2)] IPasserbyNpcNearSplineStartFirstExitOrder_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcNearSplineStartFirstExitOrder
			{
				PocoInterface = value
			};
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0005DB12 File Offset: 0x0005BD12
		public new IPasserbyNpcNearSplineStartFirstExitOrder_SetValue ToSetValue()
		{
			return new IPasserbyNpcNearSplineStartFirstExitOrder_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x0005DB25 File Offset: 0x0005BD25
		// (set) Token: 0x060021C5 RID: 8645 RVA: 0x0005DB50 File Offset: 0x0005BD50
		public override EPasserbyNpcExitOrderType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcExitOrderType.NearSplineStartFirst;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040017CD RID: 6093
		[Nullable(2)]
		protected new IPasserbyNpcNearSplineStartFirstExitOrder FbInstance;

		// Token: 0x040017CE RID: 6094
		[Nullable(2)]
		protected new IPasserbyNpcNearSplineStartFirstExitOrder_SetValue PocoInterface;
	}
}
