using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B82 RID: 31618
	public class ITeleportToVehicleInfo_UnionUnion
	{
		// Token: 0x1700ECAD RID: 60589
		// (get) Token: 0x06038EFC RID: 233212 RVA: 0x007B2279 File Offset: 0x007B0479
		// (set) Token: 0x06038EFD RID: 233213 RVA: 0x007B2281 File Offset: 0x007B0481
		public ITeleportToVehicleInfo_Union Type { get; set; }

		// Token: 0x1700ECAE RID: 60590
		// (get) Token: 0x06038EFE RID: 233214 RVA: 0x007B228A File Offset: 0x007B048A
		// (set) Token: 0x06038EFF RID: 233215 RVA: 0x007B2292 File Offset: 0x007B0492
		public object Value { get; set; }

		// Token: 0x06038F00 RID: 233216 RVA: 0x007B229B File Offset: 0x007B049B
		public ITeleportToVehicleInfo_UnionUnion()
		{
			this.Type = ITeleportToVehicleInfo_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038F01 RID: 233217 RVA: 0x007B22B1 File Offset: 0x007B04B1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038F02 RID: 233218 RVA: 0x007B22C3 File Offset: 0x007B04C3
		public ITeleportToVehicleInfoT AsITeleportToVehicleInfo()
		{
			return this.As<ITeleportToVehicleInfoT>();
		}

		// Token: 0x06038F03 RID: 233219 RVA: 0x007B22CB File Offset: 0x007B04CB
		public static ITeleportToVehicleInfo_UnionUnion FromITeleportToVehicleInfo(ITeleportToVehicleInfoT _iteleporttovehicleinfo)
		{
			return new ITeleportToVehicleInfo_UnionUnion
			{
				Type = ITeleportToVehicleInfo_Union.ITeleportToVehicleInfo,
				Value = _iteleporttovehicleinfo
			};
		}

		// Token: 0x06038F04 RID: 233220 RVA: 0x007B22E0 File Offset: 0x007B04E0
		public ITeleportToAndEnterFishingBoatT AsITeleportToAndEnterFishingBoat()
		{
			return this.As<ITeleportToAndEnterFishingBoatT>();
		}

		// Token: 0x06038F05 RID: 233221 RVA: 0x007B22E8 File Offset: 0x007B04E8
		public static ITeleportToVehicleInfo_UnionUnion FromITeleportToAndEnterFishingBoat(ITeleportToAndEnterFishingBoatT _iteleporttoandenterfishingboat)
		{
			return new ITeleportToVehicleInfo_UnionUnion
			{
				Type = ITeleportToVehicleInfo_Union.ITeleportToAndEnterFishingBoat,
				Value = _iteleporttoandenterfishingboat
			};
		}

		// Token: 0x06038F06 RID: 233222 RVA: 0x007B2300 File Offset: 0x007B0500
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
