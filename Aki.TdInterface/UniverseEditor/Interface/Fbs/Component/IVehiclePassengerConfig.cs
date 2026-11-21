using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200613C RID: 24892
	public struct IVehiclePassengerConfig : IFlatbufferObject
	{
		// Token: 0x1700B96D RID: 47469
		// (get) Token: 0x0602A3DA RID: 173018 RVA: 0x005C3B94 File Offset: 0x005C1D94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A3DB RID: 173019 RVA: 0x005C3BA1 File Offset: 0x005C1DA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A3DC RID: 173020 RVA: 0x005C3BA8 File Offset: 0x005C1DA8
		public static IVehiclePassengerConfig GetRootAsIVehiclePassengerConfig(ByteBuffer _bb)
		{
			return IVehiclePassengerConfig.GetRootAsIVehiclePassengerConfig(_bb, default(IVehiclePassengerConfig));
		}

		// Token: 0x0602A3DD RID: 173021 RVA: 0x005C3BC4 File Offset: 0x005C1DC4
		public static IVehiclePassengerConfig GetRootAsIVehiclePassengerConfig(ByteBuffer _bb, IVehiclePassengerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A3DE RID: 173022 RVA: 0x005C3BE1 File Offset: 0x005C1DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A3DF RID: 173023 RVA: 0x005C3BF0 File Offset: 0x005C1DF0
		public IVehiclePassengerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B96E RID: 47470
		// (get) Token: 0x0602A3E0 RID: 173024 RVA: 0x005C3C00 File Offset: 0x005C1E00
		public int PassengerNpc
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B96F RID: 47471
		// (get) Token: 0x0602A3E1 RID: 173025 RVA: 0x005C3C3C File Offset: 0x005C1E3C
		public int Seat
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A3E2 RID: 173026 RVA: 0x005C3C78 File Offset: 0x005C1E78
		public static Offset<IVehiclePassengerConfig> CreateIVehiclePassengerConfig(FlatBufferBuilder builder, int PassengerNpc = 0, int Seat = 0)
		{
			builder.StartTable(2);
			IVehiclePassengerConfig.AddSeat(builder, Seat);
			IVehiclePassengerConfig.AddPassengerNpc(builder, PassengerNpc);
			return IVehiclePassengerConfig.EndIVehiclePassengerConfig(builder);
		}

		// Token: 0x0602A3E3 RID: 173027 RVA: 0x005C3C95 File Offset: 0x005C1E95
		public static void StartIVehiclePassengerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A3E4 RID: 173028 RVA: 0x005C3C9E File Offset: 0x005C1E9E
		public static void AddPassengerNpc(FlatBufferBuilder builder, int passengerNpc)
		{
			builder.AddInt(0, passengerNpc, 0);
		}

		// Token: 0x0602A3E5 RID: 173029 RVA: 0x005C3CA9 File Offset: 0x005C1EA9
		public static void AddSeat(FlatBufferBuilder builder, int seat)
		{
			builder.AddInt(1, seat, 0);
		}

		// Token: 0x0602A3E6 RID: 173030 RVA: 0x005C3CB4 File Offset: 0x005C1EB4
		public static Offset<IVehiclePassengerConfig> EndIVehiclePassengerConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehiclePassengerConfig>(builder.EndTable());
		}

		// Token: 0x0602A3E7 RID: 173031 RVA: 0x005C3CC4 File Offset: 0x005C1EC4
		public IVehiclePassengerConfigT UnPack()
		{
			IVehiclePassengerConfigT vehiclePassengerConfigT = new IVehiclePassengerConfigT();
			this.UnPackTo(vehiclePassengerConfigT);
			return vehiclePassengerConfigT;
		}

		// Token: 0x0602A3E8 RID: 173032 RVA: 0x005C3CDF File Offset: 0x005C1EDF
		public void UnPackTo(IVehiclePassengerConfigT _o)
		{
			_o.PassengerNpc = this.PassengerNpc;
			_o.Seat = this.Seat;
		}

		// Token: 0x0602A3E9 RID: 173033 RVA: 0x005C3CFC File Offset: 0x005C1EFC
		public static Offset<IVehiclePassengerConfig> Pack(FlatBufferBuilder builder, IVehiclePassengerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehiclePassengerConfig>);
			}
			return IVehiclePassengerConfig.CreateIVehiclePassengerConfig(builder, _o.PassengerNpc, _o.Seat);
		}

		// Token: 0x0400FF4F RID: 65359
		private Table __p;
	}
}
