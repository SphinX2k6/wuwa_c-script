using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C5 RID: 26565
	public struct IFishingBoatVehicle : IFlatbufferObject
	{
		// Token: 0x1700C532 RID: 50482
		// (get) Token: 0x0602E3DF RID: 189407 RVA: 0x00650B5A File Offset: 0x0064ED5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E3E0 RID: 189408 RVA: 0x00650B67 File Offset: 0x0064ED67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E3E1 RID: 189409 RVA: 0x00650B70 File Offset: 0x0064ED70
		public static IFishingBoatVehicle GetRootAsIFishingBoatVehicle(ByteBuffer _bb)
		{
			return IFishingBoatVehicle.GetRootAsIFishingBoatVehicle(_bb, default(IFishingBoatVehicle));
		}

		// Token: 0x0602E3E2 RID: 189410 RVA: 0x00650B8C File Offset: 0x0064ED8C
		public static IFishingBoatVehicle GetRootAsIFishingBoatVehicle(ByteBuffer _bb, IFishingBoatVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E3E3 RID: 189411 RVA: 0x00650BA9 File Offset: 0x0064EDA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E3E4 RID: 189412 RVA: 0x00650BB8 File Offset: 0x0064EDB8
		public IFishingBoatVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C533 RID: 50483
		// (get) Token: 0x0602E3E5 RID: 189413 RVA: 0x00650BC8 File Offset: 0x0064EDC8
		public ETargetVehicle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetVehicle.Current;
				}
				return (ETargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E3E6 RID: 189414 RVA: 0x00650C04 File Offset: 0x0064EE04
		public static Offset<IFishingBoatVehicle> CreateIFishingBoatVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current)
		{
			builder.StartTable(1);
			IFishingBoatVehicle.AddType(builder, Type);
			return IFishingBoatVehicle.EndIFishingBoatVehicle(builder);
		}

		// Token: 0x0602E3E7 RID: 189415 RVA: 0x00650C1A File Offset: 0x0064EE1A
		public static void StartIFishingBoatVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E3E8 RID: 189416 RVA: 0x00650C23 File Offset: 0x0064EE23
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E3E9 RID: 189417 RVA: 0x00650C2E File Offset: 0x0064EE2E
		public static Offset<IFishingBoatVehicle> EndIFishingBoatVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IFishingBoatVehicle>(builder.EndTable());
		}

		// Token: 0x0602E3EA RID: 189418 RVA: 0x00650C3C File Offset: 0x0064EE3C
		public IFishingBoatVehicleT UnPack()
		{
			IFishingBoatVehicleT fishingBoatVehicleT = new IFishingBoatVehicleT();
			this.UnPackTo(fishingBoatVehicleT);
			return fishingBoatVehicleT;
		}

		// Token: 0x0602E3EB RID: 189419 RVA: 0x00650C57 File Offset: 0x0064EE57
		public void UnPackTo(IFishingBoatVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E3EC RID: 189420 RVA: 0x00650C68 File Offset: 0x0064EE68
		public static Offset<IFishingBoatVehicle> Pack(FlatBufferBuilder builder, IFishingBoatVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishingBoatVehicle>);
			}
			return IFishingBoatVehicle.CreateIFishingBoatVehicle(builder, _o.Type);
		}

		// Token: 0x04010EDF RID: 69343
		private Table __p;
	}
}
