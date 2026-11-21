using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BFE RID: 7166
	public class IFishingBoatVehicle : ITargetVehicle
	{
		// Token: 0x06009830 RID: 38960 RVA: 0x0016145C File Offset: 0x0015F65C
		private IFishingBoatVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFishingBoatVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFishingBoatVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFishingBoatVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x06009831 RID: 38961 RVA: 0x00161494 File Offset: 0x0015F694
		public static IFishingBoatVehicle Create([Nullable(2)] IFishingBoatVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFishingBoatVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009832 RID: 38962 RVA: 0x001614A7 File Offset: 0x0015F6A7
		public static IFishingBoatVehicle CreateFromSetValue([Nullable(2)] IFishingBoatVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFishingBoatVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009833 RID: 38963 RVA: 0x001614BA File Offset: 0x0015F6BA
		public new IFishingBoatVehicle_SetValue ToSetValue()
		{
			return new IFishingBoatVehicle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x06009834 RID: 38964 RVA: 0x001614CD File Offset: 0x0015F6CD
		// (set) Token: 0x06009835 RID: 38965 RVA: 0x001614F8 File Offset: 0x0015F6F8
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

		// Token: 0x04005DC3 RID: 24003
		[Nullable(2)]
		protected new IFishingBoatVehicle FbInstance;

		// Token: 0x04005DC4 RID: 24004
		[Nullable(2)]
		protected new IFishingBoatVehicle_SetValue PocoInterface;
	}
}
