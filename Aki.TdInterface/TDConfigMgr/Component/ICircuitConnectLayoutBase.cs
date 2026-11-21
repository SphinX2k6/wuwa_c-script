using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000270 RID: 624
	public class ICircuitConnectLayoutBase
	{
		// Token: 0x06000B04 RID: 2820 RVA: 0x0002D430 File Offset: 0x0002B630
		private ICircuitConnectLayoutBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnectLayoutBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnectLayoutBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnectLayoutBase_SetValue());
			}
			return result;
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0002D468 File Offset: 0x0002B668
		public static ICircuitConnectLayoutBase Create([Nullable(2)] ICircuitConnectLayoutBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectLayoutBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0002D47B File Offset: 0x0002B67B
		public static ICircuitConnectLayoutBase CreateFromSetValue([Nullable(2)] ICircuitConnectLayoutBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnectLayoutBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0002D48E File Offset: 0x0002B68E
		public ICircuitConnectLayoutBase_SetValue ToSetValue()
		{
			return new ICircuitConnectLayoutBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0002D4A1 File Offset: 0x0002B6A1
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x0002D4CC File Offset: 0x0002B6CC
		public virtual ECircuitConnectElementType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECircuitConnectElementType.Straight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000B08 RID: 2824
		[Nullable(2)]
		protected ICircuitConnectLayoutBase FbInstance;

		// Token: 0x04000B09 RID: 2825
		[Nullable(2)]
		protected ICircuitConnectLayoutBase_SetValue PocoInterface;
	}
}
