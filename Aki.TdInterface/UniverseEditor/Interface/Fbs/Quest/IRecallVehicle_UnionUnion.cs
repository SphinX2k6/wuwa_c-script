using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044DF RID: 17631
	public class IRecallVehicle_UnionUnion
	{
		// Token: 0x17007AB9 RID: 31417
		// (get) Token: 0x060197E0 RID: 104416 RVA: 0x003A2AFD File Offset: 0x003A0CFD
		// (set) Token: 0x060197E1 RID: 104417 RVA: 0x003A2B05 File Offset: 0x003A0D05
		public IRecallVehicle_Union Type { get; set; }

		// Token: 0x17007ABA RID: 31418
		// (get) Token: 0x060197E2 RID: 104418 RVA: 0x003A2B0E File Offset: 0x003A0D0E
		// (set) Token: 0x060197E3 RID: 104419 RVA: 0x003A2B16 File Offset: 0x003A0D16
		public object Value { get; set; }

		// Token: 0x060197E4 RID: 104420 RVA: 0x003A2B1F File Offset: 0x003A0D1F
		public IRecallVehicle_UnionUnion()
		{
			this.Type = IRecallVehicle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060197E5 RID: 104421 RVA: 0x003A2B35 File Offset: 0x003A0D35
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060197E6 RID: 104422 RVA: 0x003A2B47 File Offset: 0x003A0D47
		public IRecallVehicleT AsIRecallVehicle()
		{
			return this.As<IRecallVehicleT>();
		}

		// Token: 0x060197E7 RID: 104423 RVA: 0x003A2B4F File Offset: 0x003A0D4F
		public static IRecallVehicle_UnionUnion FromIRecallVehicle(IRecallVehicleT _irecallvehicle)
		{
			return new IRecallVehicle_UnionUnion
			{
				Type = IRecallVehicle_Union.IRecallVehicle,
				Value = _irecallvehicle
			};
		}

		// Token: 0x060197E8 RID: 104424 RVA: 0x003A2B64 File Offset: 0x003A0D64
		public IRecallFishingBoatT AsIRecallFishingBoat()
		{
			return this.As<IRecallFishingBoatT>();
		}

		// Token: 0x060197E9 RID: 104425 RVA: 0x003A2B6C File Offset: 0x003A0D6C
		public static IRecallVehicle_UnionUnion FromIRecallFishingBoat(IRecallFishingBoatT _irecallfishingboat)
		{
			return new IRecallVehicle_UnionUnion
			{
				Type = IRecallVehicle_Union.IRecallFishingBoat,
				Value = _irecallfishingboat
			};
		}

		// Token: 0x060197EA RID: 104426 RVA: 0x003A2B84 File Offset: 0x003A0D84
		public static int Pack(FlatBufferBuilder builder, IRecallVehicle_UnionUnion _o)
		{
			IRecallVehicle_Union type = _o.Type;
			if (type == IRecallVehicle_Union.IRecallVehicle)
			{
				return IRecallVehicle.Pack(builder, _o.AsIRecallVehicle()).Value;
			}
			if (type != IRecallVehicle_Union.IRecallFishingBoat)
			{
				return 0;
			}
			return IRecallFishingBoat.Pack(builder, _o.AsIRecallFishingBoat()).Value;
		}
	}
}
