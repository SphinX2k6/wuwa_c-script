using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007514 RID: 29972
	public struct IVehicleEntity : IFlatbufferObject
	{
		// Token: 0x1700E36F RID: 58223
		// (get) Token: 0x06036826 RID: 223270 RVA: 0x00767993 File Offset: 0x00765B93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036827 RID: 223271 RVA: 0x007679A0 File Offset: 0x00765BA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036828 RID: 223272 RVA: 0x007679A8 File Offset: 0x00765BA8
		public static IVehicleEntity GetRootAsIVehicleEntity(ByteBuffer _bb)
		{
			return IVehicleEntity.GetRootAsIVehicleEntity(_bb, default(IVehicleEntity));
		}

		// Token: 0x06036829 RID: 223273 RVA: 0x007679C4 File Offset: 0x00765BC4
		public static IVehicleEntity GetRootAsIVehicleEntity(ByteBuffer _bb, IVehicleEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603682A RID: 223274 RVA: 0x007679E1 File Offset: 0x00765BE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603682B RID: 223275 RVA: 0x007679F0 File Offset: 0x00765BF0
		public IVehicleEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E370 RID: 58224
		// (get) Token: 0x0603682C RID: 223276 RVA: 0x00767A00 File Offset: 0x00765C00
		public ETargetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetEntityType.Target;
				}
				return (ETargetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E371 RID: 58225
		// (get) Token: 0x0603682D RID: 223277 RVA: 0x00767A3C File Offset: 0x00765C3C
		public TTargetVehicle VehicleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetVehicle.NONE;
				}
				return (TTargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603682E RID: 223278 RVA: 0x00767A78 File Offset: 0x00765C78
		public TTable? Vehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603682F RID: 223279 RVA: 0x00767ABC File Offset: 0x00765CBC
		public IAppointedVehicle VehicleAsIAppointedVehicle()
		{
			return this.Vehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x06036830 RID: 223280 RVA: 0x00767AD8 File Offset: 0x00765CD8
		public ICurrentVehicle VehicleAsICurrentVehicle()
		{
			return this.Vehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x06036831 RID: 223281 RVA: 0x00767AF4 File Offset: 0x00765CF4
		public IFishingBoatVehicle VehicleAsIFishingBoatVehicle()
		{
			return this.Vehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x06036832 RID: 223282 RVA: 0x00767B10 File Offset: 0x00765D10
		public ISelfVehicle VehicleAsISelfVehicle()
		{
			return this.Vehicle<ISelfVehicle>().Value;
		}

		// Token: 0x06036833 RID: 223283 RVA: 0x00767B2C File Offset: 0x00765D2C
		public ITriggeredVehicle VehicleAsITriggeredVehicle()
		{
			return this.Vehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x06036834 RID: 223284 RVA: 0x00767B48 File Offset: 0x00765D48
		public IVehiclePlayerMotor VehicleAsIVehiclePlayerMotor()
		{
			return this.Vehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x06036835 RID: 223285 RVA: 0x00767B64 File Offset: 0x00765D64
		public IVehicleTeam VehicleAsIVehicleTeam()
		{
			return this.Vehicle<IVehicleTeam>().Value;
		}

		// Token: 0x06036836 RID: 223286 RVA: 0x00767B7F File Offset: 0x00765D7F
		public static Offset<IVehicleEntity> CreateIVehicleEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target, TTargetVehicle Vehicle_type = TTargetVehicle.NONE, int VehicleOffset = 0)
		{
			builder.StartTable(3);
			IVehicleEntity.AddVehicle(builder, VehicleOffset);
			IVehicleEntity.AddVehicleType(builder, Vehicle_type);
			IVehicleEntity.AddType(builder, Type);
			return IVehicleEntity.EndIVehicleEntity(builder);
		}

		// Token: 0x06036837 RID: 223287 RVA: 0x00767BA3 File Offset: 0x00765DA3
		public static void StartIVehicleEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036838 RID: 223288 RVA: 0x00767BAC File Offset: 0x00765DAC
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036839 RID: 223289 RVA: 0x00767BB7 File Offset: 0x00765DB7
		public static void AddVehicleType(FlatBufferBuilder builder, TTargetVehicle vehicleType)
		{
			builder.AddByte(1, (byte)vehicleType, 0);
		}

		// Token: 0x0603683A RID: 223290 RVA: 0x00767BC2 File Offset: 0x00765DC2
		public static void AddVehicle(FlatBufferBuilder builder, int vehicleOffset)
		{
			builder.AddOffset(2, vehicleOffset, 0);
		}

		// Token: 0x0603683B RID: 223291 RVA: 0x00767BCD File Offset: 0x00765DCD
		public static Offset<IVehicleEntity> EndIVehicleEntity(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEntity>(builder.EndTable());
		}

		// Token: 0x0603683C RID: 223292 RVA: 0x00767BDC File Offset: 0x00765DDC
		public IVehicleEntityT UnPack()
		{
			IVehicleEntityT vehicleEntityT = new IVehicleEntityT();
			this.UnPackTo(vehicleEntityT);
			return vehicleEntityT;
		}

		// Token: 0x0603683D RID: 223293 RVA: 0x00767BF8 File Offset: 0x00765DF8
		public void UnPackTo(IVehicleEntityT _o)
		{
			_o.Type = this.Type;
			_o.Vehicle = new TTargetVehicleUnion();
			_o.Vehicle.Type = this.VehicleType;
			switch (this.VehicleType)
			{
			case TTargetVehicle.IAppointedVehicle:
				_o.Vehicle.Value = ((this.Vehicle<IAppointedVehicle>() != null) ? this.Vehicle<IAppointedVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.ICurrentVehicle:
				_o.Vehicle.Value = ((this.Vehicle<ICurrentVehicle>() != null) ? this.Vehicle<ICurrentVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.IFishingBoatVehicle:
				_o.Vehicle.Value = ((this.Vehicle<IFishingBoatVehicle>() != null) ? this.Vehicle<IFishingBoatVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.ISelfVehicle:
				_o.Vehicle.Value = ((this.Vehicle<ISelfVehicle>() != null) ? this.Vehicle<ISelfVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.ITriggeredVehicle:
				_o.Vehicle.Value = ((this.Vehicle<ITriggeredVehicle>() != null) ? this.Vehicle<ITriggeredVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.IVehiclePlayerMotor:
				_o.Vehicle.Value = ((this.Vehicle<IVehiclePlayerMotor>() != null) ? this.Vehicle<IVehiclePlayerMotor>().Value.UnPack() : null);
				return;
			case TTargetVehicle.IVehicleTeam:
				_o.Vehicle.Value = ((this.Vehicle<IVehicleTeam>() != null) ? this.Vehicle<IVehicleTeam>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603683E RID: 223294 RVA: 0x00767DDC File Offset: 0x00765FDC
		public static Offset<IVehicleEntity> Pack(FlatBufferBuilder builder, IVehicleEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleEntity>);
			}
			TTargetVehicle vehicle_type = (_o.Vehicle == null) ? TTargetVehicle.NONE : _o.Vehicle.Type;
			int vehicleOffset = (_o.Vehicle == null) ? 0 : TTargetVehicleUnion.Pack(builder, _o.Vehicle);
			return IVehicleEntity.CreateIVehicleEntity(builder, _o.Type, vehicle_type, vehicleOffset);
		}

		// Token: 0x04012402 RID: 74754
		private Table __p;
	}
}
