using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019E2 RID: 6626
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IEnableCameraOperationConverter))]
	public class IEnableCameraOperation : ICameraOperationType
	{
		// Token: 0x06008DE7 RID: 36327 RVA: 0x0014C2F8 File Offset: 0x0014A4F8
		private IEnableCameraOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableCameraOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableCameraOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableCameraOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x0014C330 File Offset: 0x0014A530
		public static IEnableCameraOperation Create([Nullable(2)] IEnableCameraOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableCameraOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DE9 RID: 36329 RVA: 0x0014C343 File Offset: 0x0014A543
		public static IEnableCameraOperation CreateFromSetValue([Nullable(2)] IEnableCameraOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableCameraOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DEA RID: 36330 RVA: 0x0014C356 File Offset: 0x0014A556
		public new IEnableCameraOperation_SetValue ToSetValue()
		{
			return new IEnableCameraOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x06008DEB RID: 36331 RVA: 0x0014C369 File Offset: 0x0014A569
		// (set) Token: 0x06008DEC RID: 36332 RVA: 0x0014C394 File Offset: 0x0014A594
		public override ECameraOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005812 RID: 22546
		[Nullable(2)]
		protected new IEnableCameraOperation FbInstance;

		// Token: 0x04005813 RID: 22547
		[Nullable(2)]
		protected new IEnableCameraOperation_SetValue PocoInterface;
	}
}
