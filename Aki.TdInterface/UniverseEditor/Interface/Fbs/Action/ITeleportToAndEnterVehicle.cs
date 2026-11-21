using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B6F RID: 31599
	public struct ITeleportToAndEnterVehicle : IFlatbufferObject
	{
		// Token: 0x1700EC9C RID: 60572
		// (get) Token: 0x06038E96 RID: 233110 RVA: 0x007B191D File Offset: 0x007AFB1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038E97 RID: 233111 RVA: 0x007B192A File Offset: 0x007AFB2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038E98 RID: 233112 RVA: 0x007B1934 File Offset: 0x007AFB34
		public static ITeleportToAndEnterVehicle GetRootAsITeleportToAndEnterVehicle(ByteBuffer _bb)
		{
			return ITeleportToAndEnterVehicle.GetRootAsITeleportToAndEnterVehicle(_bb, default(ITeleportToAndEnterVehicle));
		}

		// Token: 0x06038E99 RID: 233113 RVA: 0x007B1950 File Offset: 0x007AFB50
		public static ITeleportToAndEnterVehicle GetRootAsITeleportToAndEnterVehicle(ByteBuffer _bb, ITeleportToAndEnterVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038E9A RID: 233114 RVA: 0x007B196D File Offset: 0x007AFB6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038E9B RID: 233115 RVA: 0x007B197C File Offset: 0x007AFB7C
		public ITeleportToAndEnterVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC9D RID: 60573
		// (get) Token: 0x06038E9C RID: 233116 RVA: 0x007B198C File Offset: 0x007AFB8C
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

		// Token: 0x06038E9D RID: 233117 RVA: 0x007B19E9 File Offset: 0x007AFBE9
		public static Offset<ITeleportToAndEnterVehicle> CreateITeleportToAndEnterVehicle(FlatBufferBuilder builder, Offset<ITeleportToAndEnterFishingBoat> ToVehicleOffset = default(Offset<ITeleportToAndEnterFishingBoat>))
		{
			builder.StartTable(1);
			ITeleportToAndEnterVehicle.AddToVehicle(builder, ToVehicleOffset);
			return ITeleportToAndEnterVehicle.EndITeleportToAndEnterVehicle(builder);
		}

		// Token: 0x06038E9E RID: 233118 RVA: 0x007B19FF File Offset: 0x007AFBFF
		public static void StartITeleportToAndEnterVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038E9F RID: 233119 RVA: 0x007B1A08 File Offset: 0x007AFC08
		public static void AddToVehicle(FlatBufferBuilder builder, Offset<ITeleportToAndEnterFishingBoat> toVehicleOffset)
		{
			builder.AddOffset(0, toVehicleOffset.Value, 0);
		}

		// Token: 0x06038EA0 RID: 233120 RVA: 0x007B1A18 File Offset: 0x007AFC18
		public static Offset<ITeleportToAndEnterVehicle> EndITeleportToAndEnterVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToAndEnterVehicle>(builder.EndTable());
		}

		// Token: 0x06038EA1 RID: 233121 RVA: 0x007B1A28 File Offset: 0x007AFC28
		public ITeleportToAndEnterVehicleT UnPack()
		{
			ITeleportToAndEnterVehicleT teleportToAndEnterVehicleT = new ITeleportToAndEnterVehicleT();
			this.UnPackTo(teleportToAndEnterVehicleT);
			return teleportToAndEnterVehicleT;
		}

		// Token: 0x06038EA2 RID: 233122 RVA: 0x007B1A44 File Offset: 0x007AFC44
		public void UnPackTo(ITeleportToAndEnterVehicleT _o)
		{
			_o.ToVehicle = ((this.ToVehicle != null) ? this.ToVehicle.Value.UnPack() : null);
		}

		// Token: 0x06038EA3 RID: 233123 RVA: 0x007B1A80 File Offset: 0x007AFC80
		public static Offset<ITeleportToAndEnterVehicle> Pack(FlatBufferBuilder builder, ITeleportToAndEnterVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToAndEnterVehicle>);
			}
			Offset<ITeleportToAndEnterFishingBoat> toVehicleOffset = (_o.ToVehicle == null) ? default(Offset<ITeleportToAndEnterFishingBoat>) : ITeleportToAndEnterFishingBoat.Pack(builder, _o.ToVehicle);
			return ITeleportToAndEnterVehicle.CreateITeleportToAndEnterVehicle(builder, toVehicleOffset);
		}

		// Token: 0x040131BD RID: 78269
		private Table __p;
	}
}
