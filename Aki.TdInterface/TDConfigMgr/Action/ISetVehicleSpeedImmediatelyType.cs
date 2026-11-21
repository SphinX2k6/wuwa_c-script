using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002083 RID: 8323
	public class ISetVehicleSpeedImmediatelyType
	{
		// Token: 0x0600B0B5 RID: 45237 RVA: 0x0018D9C8 File Offset: 0x0018BBC8
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

		// Token: 0x0600B0B6 RID: 45238 RVA: 0x0018DA00 File Offset: 0x0018BC00
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

		// Token: 0x0600B0B7 RID: 45239 RVA: 0x0018DA13 File Offset: 0x0018BC13
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

		// Token: 0x0600B0B8 RID: 45240 RVA: 0x0018DA26 File Offset: 0x0018BC26
		public ISetVehicleSpeedImmediatelyType_SetValue ToSetValue()
		{
			return new ISetVehicleSpeedImmediatelyType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x0600B0B9 RID: 45241 RVA: 0x0018DA39 File Offset: 0x0018BC39
		// (set) Token: 0x0600B0BA RID: 45242 RVA: 0x0018DA64 File Offset: 0x0018BC64
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

		// Token: 0x04006917 RID: 26903
		[Nullable(2)]
		protected ISetVehicleSpeedImmediatelyType FbInstance;

		// Token: 0x04006918 RID: 26904
		[Nullable(2)]
		protected ISetVehicleSpeedImmediatelyType_SetValue PocoInterface;
	}
}
