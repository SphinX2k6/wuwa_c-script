using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FFE RID: 8190
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggeredVehicle : ITargetVehicle
	{
		// Token: 0x0600B41C RID: 46108 RVA: 0x001A2F44 File Offset: 0x001A1144
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

		// Token: 0x0600B41D RID: 46109 RVA: 0x001A2F7C File Offset: 0x001A117C
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

		// Token: 0x0600B41E RID: 46110 RVA: 0x001A2F8F File Offset: 0x001A118F
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

		// Token: 0x0600B41F RID: 46111 RVA: 0x001A2FA2 File Offset: 0x001A11A2
		public new ITriggeredVehicle_SetValue ToSetValue()
		{
			return new ITriggeredVehicle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x0600B420 RID: 46112 RVA: 0x001A2FB5 File Offset: 0x001A11B5
		// (set) Token: 0x0600B421 RID: 46113 RVA: 0x001A2FE0 File Offset: 0x001A11E0
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

		// Token: 0x04006C94 RID: 27796
		[Nullable(2)]
		protected new ITriggeredVehicle FbInstance;

		// Token: 0x04006C95 RID: 27797
		[Nullable(2)]
		protected new ITriggeredVehicle_SetValue PocoInterface;
	}
}
