using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200739B RID: 29595
	public class ITeleportToVehicleInfo_UnionUnion
	{
		// Token: 0x1700E09D RID: 57501
		// (get) Token: 0x06035B61 RID: 220001 RVA: 0x0074FD39 File Offset: 0x0074DF39
		// (set) Token: 0x06035B62 RID: 220002 RVA: 0x0074FD41 File Offset: 0x0074DF41
		public ITeleportToVehicleInfo_Union Type { get; set; }

		// Token: 0x1700E09E RID: 57502
		// (get) Token: 0x06035B63 RID: 220003 RVA: 0x0074FD4A File Offset: 0x0074DF4A
		// (set) Token: 0x06035B64 RID: 220004 RVA: 0x0074FD52 File Offset: 0x0074DF52
		public object Value { get; set; }

		// Token: 0x06035B65 RID: 220005 RVA: 0x0074FD5B File Offset: 0x0074DF5B
		public ITeleportToVehicleInfo_UnionUnion()
		{
			this.Type = ITeleportToVehicleInfo_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035B66 RID: 220006 RVA: 0x0074FD71 File Offset: 0x0074DF71
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035B67 RID: 220007 RVA: 0x0074FD83 File Offset: 0x0074DF83
		public ITeleportToVehicleInfoT AsITeleportToVehicleInfo()
		{
			return this.As<ITeleportToVehicleInfoT>();
		}

		// Token: 0x06035B68 RID: 220008 RVA: 0x0074FD8B File Offset: 0x0074DF8B
		public static ITeleportToVehicleInfo_UnionUnion FromITeleportToVehicleInfo(ITeleportToVehicleInfoT _iteleporttovehicleinfo)
		{
			return new ITeleportToVehicleInfo_UnionUnion
			{
				Type = ITeleportToVehicleInfo_Union.ITeleportToVehicleInfo,
				Value = _iteleporttovehicleinfo
			};
		}

		// Token: 0x06035B69 RID: 220009 RVA: 0x0074FDA0 File Offset: 0x0074DFA0
		public ITeleportToAndEnterFishingBoatT AsITeleportToAndEnterFishingBoat()
		{
			return this.As<ITeleportToAndEnterFishingBoatT>();
		}

		// Token: 0x06035B6A RID: 220010 RVA: 0x0074FDA8 File Offset: 0x0074DFA8
		public static ITeleportToVehicleInfo_UnionUnion FromITeleportToAndEnterFishingBoat(ITeleportToAndEnterFishingBoatT _iteleporttoandenterfishingboat)
		{
			return new ITeleportToVehicleInfo_UnionUnion
			{
				Type = ITeleportToVehicleInfo_Union.ITeleportToAndEnterFishingBoat,
				Value = _iteleporttoandenterfishingboat
			};
		}

		// Token: 0x06035B6B RID: 220011 RVA: 0x0074FDC0 File Offset: 0x0074DFC0
		public static int Pack(FlatBufferBuilder builder, ITeleportToVehicleInfo_UnionUnion _o)
		{
			ITeleportToVehicleInfo_Union type = _o.Type;
			if (type == ITeleportToVehicleInfo_Union.ITeleportToVehicleInfo)
			{
				return ITeleportToVehicleInfo.Pack(builder, _o.AsITeleportToVehicleInfo()).Value;
			}
			if (type != ITeleportToVehicleInfo_Union.ITeleportToAndEnterFishingBoat)
			{
				return 0;
			}
			return ITeleportToAndEnterFishingBoat.Pack(builder, _o.AsITeleportToAndEnterFishingBoat()).Value;
		}
	}
}
