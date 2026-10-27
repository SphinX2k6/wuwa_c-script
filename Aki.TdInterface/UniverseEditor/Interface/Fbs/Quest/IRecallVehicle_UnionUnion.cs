using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200409E RID: 16542
	public class IRecallVehicle_UnionUnion
	{
		// Token: 0x170074B7 RID: 29879
		// (get) Token: 0x06018147 RID: 98631 RVA: 0x00378CC5 File Offset: 0x00376EC5
		// (set) Token: 0x06018148 RID: 98632 RVA: 0x00378CCD File Offset: 0x00376ECD
		public IRecallVehicle_Union Type { get; set; }

		// Token: 0x170074B8 RID: 29880
		// (get) Token: 0x06018149 RID: 98633 RVA: 0x00378CD6 File Offset: 0x00376ED6
		// (set) Token: 0x0601814A RID: 98634 RVA: 0x00378CDE File Offset: 0x00376EDE
		public object Value { get; set; }

		// Token: 0x0601814B RID: 98635 RVA: 0x00378CE7 File Offset: 0x00376EE7
		public IRecallVehicle_UnionUnion()
		{
			this.Type = IRecallVehicle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601814C RID: 98636 RVA: 0x00378CFD File Offset: 0x00376EFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601814D RID: 98637 RVA: 0x00378D0F File Offset: 0x00376F0F
		public IRecallVehicleT AsIRecallVehicle()
		{
			return this.As<IRecallVehicleT>();
		}

		// Token: 0x0601814E RID: 98638 RVA: 0x00378D17 File Offset: 0x00376F17
		public static IRecallVehicle_UnionUnion FromIRecallVehicle(IRecallVehicleT _irecallvehicle)
		{
			return new IRecallVehicle_UnionUnion
			{
				Type = IRecallVehicle_Union.IRecallVehicle,
				Value = _irecallvehicle
			};
		}

		// Token: 0x0601814F RID: 98639 RVA: 0x00378D2C File Offset: 0x00376F2C
		public IRecallFishingBoatT AsIRecallFishingBoat()
		{
			return this.As<IRecallFishingBoatT>();
		}

		// Token: 0x06018150 RID: 98640 RVA: 0x00378D34 File Offset: 0x00376F34
		public static IRecallVehicle_UnionUnion FromIRecallFishingBoat(IRecallFishingBoatT _irecallfishingboat)
		{
			return new IRecallVehicle_UnionUnion
			{
				Type = IRecallVehicle_Union.IRecallFishingBoat,
				Value = _irecallfishingboat
			};
		}

		// Token: 0x06018151 RID: 98641 RVA: 0x00378D4C File Offset: 0x00376F4C
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
