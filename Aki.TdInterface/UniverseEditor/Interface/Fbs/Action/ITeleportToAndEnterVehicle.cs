using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007388 RID: 29576
	public struct ITeleportToAndEnterVehicle : IFlatbufferObject
	{
		// Token: 0x1700E08C RID: 57484
		// (get) Token: 0x06035AFB RID: 219899 RVA: 0x0074F3DD File Offset: 0x0074D5DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035AFC RID: 219900 RVA: 0x0074F3EA File Offset: 0x0074D5EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035AFD RID: 219901 RVA: 0x0074F3F4 File Offset: 0x0074D5F4
		public static ITeleportToAndEnterVehicle GetRootAsITeleportToAndEnterVehicle(ByteBuffer _bb)
		{
			return ITeleportToAndEnterVehicle.GetRootAsITeleportToAndEnterVehicle(_bb, default(ITeleportToAndEnterVehicle));
		}

		// Token: 0x06035AFE RID: 219902 RVA: 0x0074F410 File Offset: 0x0074D610
		public static ITeleportToAndEnterVehicle GetRootAsITeleportToAndEnterVehicle(ByteBuffer _bb, ITeleportToAndEnterVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035AFF RID: 219903 RVA: 0x0074F42D File Offset: 0x0074D62D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B00 RID: 219904 RVA: 0x0074F43C File Offset: 0x0074D63C
		public ITeleportToAndEnterVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E08D RID: 57485
		// (get) Token: 0x06035B01 RID: 219905 RVA: 0x0074F44C File Offset: 0x0074D64C
		public ITeleportToAndEnterFishingBoat? ToVehicle
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITeleportToAndEnterFishingBoat?(default(ITeleportToAndEnterFishingBoat).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035B02 RID: 219906 RVA: 0x0074F4A9 File Offset: 0x0074D6A9
		public static Offset<ITeleportToAndEnterVehicle> CreateITeleportToAndEnterVehicle(FlatBufferBuilder builder, Offset<ITeleportToAndEnterFishingBoat> ToVehicleOffset = default(Offset<ITeleportToAndEnterFishingBoat>))
		{
			builder.StartTable(1);
			ITeleportToAndEnterVehicle.AddToVehicle(builder, ToVehicleOffset);
			return ITeleportToAndEnterVehicle.EndITeleportToAndEnterVehicle(builder);
		}

		// Token: 0x06035B03 RID: 219907 RVA: 0x0074F4BF File Offset: 0x0074D6BF
		public static void StartITeleportToAndEnterVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035B04 RID: 219908 RVA: 0x0074F4C8 File Offset: 0x0074D6C8
		public static void AddToVehicle(FlatBufferBuilder builder, Offset<ITeleportToAndEnterFishingBoat> toVehicleOffset)
		{
			builder.AddOffset(0, toVehicleOffset.Value, 0);
		}

		// Token: 0x06035B05 RID: 219909 RVA: 0x0074F4D8 File Offset: 0x0074D6D8
		public static Offset<ITeleportToAndEnterVehicle> EndITeleportToAndEnterVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToAndEnterVehicle>(builder.EndTable());
		}

		// Token: 0x06035B06 RID: 219910 RVA: 0x0074F4E8 File Offset: 0x0074D6E8
		public ITeleportToAndEnterVehicleT UnPack()
		{
			ITeleportToAndEnterVehicleT teleportToAndEnterVehicleT = new ITeleportToAndEnterVehicleT();
			this.UnPackTo(teleportToAndEnterVehicleT);
			return teleportToAndEnterVehicleT;
		}

		// Token: 0x06035B07 RID: 219911 RVA: 0x0074F504 File Offset: 0x0074D704
		public void UnPackTo(ITeleportToAndEnterVehicleT _o)
		{
			_o.ToVehicle = ((this.ToVehicle != null) ? this.ToVehicle.Value.UnPack() : null);
		}

		// Token: 0x06035B08 RID: 219912 RVA: 0x0074F540 File Offset: 0x0074D740
		public static Offset<ITeleportToAndEnterVehicle> Pack(FlatBufferBuilder builder, ITeleportToAndEnterVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToAndEnterVehicle>);
			}
			Offset<ITeleportToAndEnterFishingBoat> toVehicleOffset = (_o.ToVehicle == null) ? default(Offset<ITeleportToAndEnterFishingBoat>) : ITeleportToAndEnterFishingBoat.Pack(builder, _o.ToVehicle);
			return ITeleportToAndEnterVehicle.CreateITeleportToAndEnterVehicle(builder, toVehicleOffset);
		}

		// Token: 0x040121A4 RID: 74148
		private Table __p;
	}
}
