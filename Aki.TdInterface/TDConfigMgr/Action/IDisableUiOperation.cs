using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019BA RID: 6586
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableUiOperationConverter))]
	public class IDisableUiOperation : IUiOperationType
	{
		// Token: 0x06008D1D RID: 36125 RVA: 0x0014ADD4 File Offset: 0x00148FD4
		private IDisableUiOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableUiOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableUiOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableUiOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008D1E RID: 36126 RVA: 0x0014AE0C File Offset: 0x0014900C
		public static IDisableUiOperation Create([Nullable(2)] IDisableUiOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableUiOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D1F RID: 36127 RVA: 0x0014AE1F File Offset: 0x0014901F
		public static IDisableUiOperation CreateFromSetValue([Nullable(2)] IDisableUiOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableUiOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x0014AE32 File Offset: 0x00149032
		public new IDisableUiOperation_SetValue ToSetValue()
		{
			return new IDisableUiOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x06008D21 RID: 36129 RVA: 0x0014AE45 File Offset: 0x00149045
		// (set) Token: 0x06008D22 RID: 36130 RVA: 0x0014AE70 File Offset: 0x00149070
		public override EUiOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUiOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040057BB RID: 22459
		[Nullable(2)]
		protected new IDisableUiOperation FbInstance;

		// Token: 0x040057BC RID: 22460
		[Nullable(2)]
		protected new IDisableUiOperation_SetValue PocoInterface;
	}
}
