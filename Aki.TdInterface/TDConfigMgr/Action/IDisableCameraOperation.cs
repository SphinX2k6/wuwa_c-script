using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019A8 RID: 6568
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableCameraOperationConverter))]
	public class IDisableCameraOperation : ICameraOperationType
	{
		// Token: 0x06008C8B RID: 35979 RVA: 0x00149B20 File Offset: 0x00147D20
		private IDisableCameraOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableCameraOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableCameraOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableCameraOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x00149B58 File Offset: 0x00147D58
		public static IDisableCameraOperation Create([Nullable(2)] IDisableCameraOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableCameraOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C8D RID: 35981 RVA: 0x00149B6B File Offset: 0x00147D6B
		public static IDisableCameraOperation CreateFromSetValue([Nullable(2)] IDisableCameraOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableCameraOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C8E RID: 35982 RVA: 0x00149B7E File Offset: 0x00147D7E
		public new IDisableCameraOperation_SetValue ToSetValue()
		{
			return new IDisableCameraOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x06008C8F RID: 35983 RVA: 0x00149B91 File Offset: 0x00147D91
		// (set) Token: 0x06008C90 RID: 35984 RVA: 0x00149BBC File Offset: 0x00147DBC
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

		// Token: 0x04005777 RID: 22391
		[Nullable(2)]
		protected new IDisableCameraOperation FbInstance;

		// Token: 0x04005778 RID: 22392
		[Nullable(2)]
		protected new IDisableCameraOperation_SetValue PocoInterface;
	}
}
