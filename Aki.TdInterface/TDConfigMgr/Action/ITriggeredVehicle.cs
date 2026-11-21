using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002245 RID: 8773
	public class ITriggeredVehicle : ITargetVehicle
	{
		// Token: 0x0600BF32 RID: 48946 RVA: 0x001B94B0 File Offset: 0x001B76B0
		private ITriggeredVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggeredVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggeredVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggeredVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF33 RID: 48947 RVA: 0x001B94E8 File Offset: 0x001B76E8
		public static ITriggeredVehicle Create([Nullable(2)] ITriggeredVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggeredVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x001B94FB File Offset: 0x001B76FB
		public static ITriggeredVehicle CreateFromSetValue([Nullable(2)] ITriggeredVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggeredVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF35 RID: 48949 RVA: 0x001B950E File Offset: 0x001B770E
		public new ITriggeredVehicle_SetValue ToSetValue()
		{
			return new ITriggeredVehicle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x0600BF36 RID: 48950 RVA: 0x001B9521 File Offset: 0x001B7721
		// (set) Token: 0x0600BF37 RID: 48951 RVA: 0x001B954C File Offset: 0x001B774C
		public override ETargetVehicle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetVehicle.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007296 RID: 29334
		[Nullable(2)]
		protected new ITriggeredVehicle FbInstance;

		// Token: 0x04007297 RID: 29335
		[Nullable(2)]
		protected new ITriggeredVehicle_SetValue PocoInterface;
	}
}
