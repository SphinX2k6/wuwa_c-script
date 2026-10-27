using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E4E RID: 7758
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetVehicleSpeedImmediatelyType
	{
		// Token: 0x0600A5FD RID: 42493 RVA: 0x00177CC8 File Offset: 0x00175EC8
		private ISetVehicleSpeedImmediatelyType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetVehicleSpeedImmediatelyType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetVehicleSpeedImmediatelyType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetVehicleSpeedImmediatelyType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A5FE RID: 42494 RVA: 0x00177D00 File Offset: 0x00175F00
		public static ISetVehicleSpeedImmediatelyType Create([Nullable(2)] ISetVehicleSpeedImmediatelyType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetVehicleSpeedImmediatelyType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A5FF RID: 42495 RVA: 0x00177D13 File Offset: 0x00175F13
		public static ISetVehicleSpeedImmediatelyType CreateFromSetValue([Nullable(2)] ISetVehicleSpeedImmediatelyType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetVehicleSpeedImmediatelyType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A600 RID: 42496 RVA: 0x00177D26 File Offset: 0x00175F26
		public ISetVehicleSpeedImmediatelyType_SetValue ToSetValue()
		{
			return new ISetVehicleSpeedImmediatelyType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600A601 RID: 42497 RVA: 0x00177D39 File Offset: 0x00175F39
		// (set) Token: 0x0600A602 RID: 42498 RVA: 0x00177D64 File Offset: 0x00175F64
		public virtual ESetVehicleSpeedImmediatelyType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetVehicleSpeedImmediatelyType.TotalSpeed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006333 RID: 25395
		[Nullable(2)]
		protected ISetVehicleSpeedImmediatelyType FbInstance;

		// Token: 0x04006334 RID: 25396
		[Nullable(2)]
		protected ISetVehicleSpeedImmediatelyType_SetValue PocoInterface;
	}
}
