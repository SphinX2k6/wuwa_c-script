using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000278 RID: 632
	public class ICircuitConnectOutputPortLayout : ICircuitConnectLayoutBase
	{
		// Token: 0x06000B2E RID: 2862 RVA: 0x0002D964 File Offset: 0x0002BB64
		private ICircuitConnectOutputPortLayout_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnectOutputPortLayout 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnectOutputPortLayout_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnectOutputPortLayout_SetValue());
			}
			return result;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0002D99C File Offset: 0x0002BB9C
		public static ICircuitConnectOutputPortLayout Create([Nullable(2)] ICircuitConnectOutputPortLayout instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectOutputPortLayout
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0002D9AF File Offset: 0x0002BBAF
		public static ICircuitConnectOutputPortLayout CreateFromSetValue([Nullable(2)] ICircuitConnectOutputPortLayout_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnectOutputPortLayout
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0002D9C2 File Offset: 0x0002BBC2
		public new ICircuitConnectOutputPortLayout_SetValue ToSetValue()
		{
			return new ICircuitConnectOutputPortLayout_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0002D9D5 File Offset: 0x0002BBD5
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x0002DA00 File Offset: 0x0002BC00
		public override ECircuitConnectElementType Type
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

		// Token: 0x04000B1D RID: 2845
		[Nullable(2)]
		protected new ICircuitConnectOutputPortLayout FbInstance;

		// Token: 0x04000B1E RID: 2846
		[Nullable(2)]
		protected new ICircuitConnectOutputPortLayout_SetValue PocoInterface;
	}
}
