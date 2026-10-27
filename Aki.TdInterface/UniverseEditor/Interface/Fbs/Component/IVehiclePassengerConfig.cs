using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B26 RID: 23334
	public struct IVehiclePassengerConfig : IFlatbufferObject
	{
		// Token: 0x1700B025 RID: 45093
		// (get) Token: 0x06027E16 RID: 163350 RVA: 0x0057C140 File Offset: 0x0057A340
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027E17 RID: 163351 RVA: 0x0057C14D File Offset: 0x0057A34D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027E18 RID: 163352 RVA: 0x0057C154 File Offset: 0x0057A354
		public static IVehiclePassengerConfig GetRootAsIVehiclePassengerConfig(ByteBuffer _bb)
		{
			return IVehiclePassengerConfig.GetRootAsIVehiclePassengerConfig(_bb, default(IVehiclePassengerConfig));
		}

		// Token: 0x06027E19 RID: 163353 RVA: 0x0057C170 File Offset: 0x0057A370
		public static IVehiclePassengerConfig GetRootAsIVehiclePassengerConfig(ByteBuffer _bb, IVehiclePassengerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027E1A RID: 163354 RVA: 0x0057C18D File Offset: 0x0057A38D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027E1B RID: 163355 RVA: 0x0057C19C File Offset: 0x0057A39C
		public IVehiclePassengerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B026 RID: 45094
		// (get) Token: 0x06027E1C RID: 163356 RVA: 0x0057C1AC File Offset: 0x0057A3AC
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

		// Token: 0x1700B027 RID: 45095
		// (get) Token: 0x06027E1D RID: 163357 RVA: 0x0057C1E8 File Offset: 0x0057A3E8
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

		// Token: 0x06027E1E RID: 163358 RVA: 0x0057C224 File Offset: 0x0057A424
		public static Offset<IVehiclePassengerConfig> CreateIVehiclePassengerConfig(FlatBufferBuilder builder, int PassengerNpc = 0, int Seat = 0)
		{
			builder.StartTable(2);
			IVehiclePassengerConfig.AddSeat(builder, Seat);
			IVehiclePassengerConfig.AddPassengerNpc(builder, PassengerNpc);
			return IVehiclePassengerConfig.EndIVehiclePassengerConfig(builder);
		}

		// Token: 0x06027E1F RID: 163359 RVA: 0x0057C241 File Offset: 0x0057A441
		public static void StartIVehiclePassengerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027E20 RID: 163360 RVA: 0x0057C24A File Offset: 0x0057A44A
		public static void AddPassengerNpc(FlatBufferBuilder builder, int passengerNpc)
		{
			builder.AddInt(0, passengerNpc, 0);
		}

		// Token: 0x06027E21 RID: 163361 RVA: 0x0057C255 File Offset: 0x0057A455
		public static void AddSeat(FlatBufferBuilder builder, int seat)
		{
			builder.AddInt(1, seat, 0);
		}

		// Token: 0x06027E22 RID: 163362 RVA: 0x0057C260 File Offset: 0x0057A460
		public static Offset<IVehiclePassengerConfig> EndIVehiclePassengerConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehiclePassengerConfig>(builder.EndTable());
		}

		// Token: 0x06027E23 RID: 163363 RVA: 0x0057C270 File Offset: 0x0057A470
		public IVehiclePassengerConfigT UnPack()
		{
			IVehiclePassengerConfigT vehiclePassengerConfigT = new IVehiclePassengerConfigT();
			this.UnPackTo(vehiclePassengerConfigT);
			return vehiclePassengerConfigT;
		}

		// Token: 0x06027E24 RID: 163364 RVA: 0x0057C28B File Offset: 0x0057A48B
		public void UnPackTo(IVehiclePassengerConfigT _o)
		{
			_o.PassengerNpc = this.PassengerNpc;
			_o.Seat = this.Seat;
		}

		// Token: 0x06027E25 RID: 163365 RVA: 0x0057C2A8 File Offset: 0x0057A4A8
		public static Offset<IVehiclePassengerConfig> Pack(FlatBufferBuilder builder, IVehiclePassengerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehiclePassengerConfig>);
			}
			return IVehiclePassengerConfig.CreateIVehiclePassengerConfig(builder, _o.PassengerNpc, _o.Seat);
		}

		// Token: 0x0400F249 RID: 62025
		private Table __p;
	}
}
