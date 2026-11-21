using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200027E RID: 638
	public class ICircuitConnectThreeRings : ICircuitConnectModeBase
	{
		// Token: 0x06000B4A RID: 2890 RVA: 0x0002DC20 File Offset: 0x0002BE20
		private ICircuitConnectThreeRings_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnectThreeRings 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnectThreeRings_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnectThreeRings_SetValue());
			}
			return result;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0002DC58 File Offset: 0x0002BE58
		public static ICircuitConnectThreeRings Create([Nullable(2)] ICircuitConnectThreeRings instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectThreeRings
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0002DC6B File Offset: 0x0002BE6B
		public static ICircuitConnectThreeRings CreateFromSetValue([Nullable(2)] ICircuitConnectThreeRings_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnectThreeRings
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0002DC7E File Offset: 0x0002BE7E
		public new ICircuitConnectThreeRings_SetValue ToSetValue()
		{
			return new ICircuitConnectThreeRings_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0002DC91 File Offset: 0x0002BE91
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x0002DCBC File Offset: 0x0002BEBC
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

		// Token: 0x04000B28 RID: 2856
		[Nullable(2)]
		protected new ICircuitConnectThreeRings FbInstance;

		// Token: 0x04000B29 RID: 2857
		[Nullable(2)]
		protected new ICircuitConnectThreeRings_SetValue PocoInterface;
	}
}
