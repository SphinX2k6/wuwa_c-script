using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000280 RID: 640
	public class ICircuitConnectTwoRings : ICircuitConnectModeBase
	{
		// Token: 0x06000B52 RID: 2898 RVA: 0x0002DCDC File Offset: 0x0002BEDC
		private ICircuitConnectTwoRings_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnectTwoRings 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnectTwoRings_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnectTwoRings_SetValue());
			}
			return result;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002DD14 File Offset: 0x0002BF14
		public static ICircuitConnectTwoRings Create([Nullable(2)] ICircuitConnectTwoRings instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectTwoRings
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0002DD27 File Offset: 0x0002BF27
		public static ICircuitConnectTwoRings CreateFromSetValue([Nullable(2)] ICircuitConnectTwoRings_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnectTwoRings
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0002DD3A File Offset: 0x0002BF3A
		public new ICircuitConnectTwoRings_SetValue ToSetValue()
		{
			return new ICircuitConnectTwoRings_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0002DD4D File Offset: 0x0002BF4D
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x0002DD78 File Offset: 0x0002BF78
		public override ECircuitConnectMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECircuitConnectMode.TwoRings;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000B2B RID: 2859
		[Nullable(2)]
		protected new ICircuitConnectTwoRings FbInstance;

		// Token: 0x04000B2C RID: 2860
		[Nullable(2)]
		protected new ICircuitConnectTwoRings_SetValue PocoInterface;
	}
}
