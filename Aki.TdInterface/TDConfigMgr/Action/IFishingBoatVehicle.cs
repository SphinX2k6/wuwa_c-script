using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A69 RID: 6761
	[NullableContext(1)]
	[Nullable(0)]
	public class IFishingBoatVehicle : ITargetVehicle
	{
		// Token: 0x060090C6 RID: 37062 RVA: 0x00151530 File Offset: 0x0014F730
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

		// Token: 0x060090C7 RID: 37063 RVA: 0x00151568 File Offset: 0x0014F768
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

		// Token: 0x060090C8 RID: 37064 RVA: 0x0015157B File Offset: 0x0014F77B
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

		// Token: 0x060090C9 RID: 37065 RVA: 0x0015158E File Offset: 0x0014F78E
		public new IFishingBoatVehicle_SetValue ToSetValue()
		{
			return new IFishingBoatVehicle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x060090CA RID: 37066 RVA: 0x001515A1 File Offset: 0x0014F7A1
		// (set) Token: 0x060090CB RID: 37067 RVA: 0x001515CC File Offset: 0x0014F7CC
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

		// Token: 0x0400595E RID: 22878
		[Nullable(2)]
		protected new IFishingBoatVehicle FbInstance;

		// Token: 0x0400595F RID: 22879
		[Nullable(2)]
		protected new IFishingBoatVehicle_SetValue PocoInterface;
	}
}
