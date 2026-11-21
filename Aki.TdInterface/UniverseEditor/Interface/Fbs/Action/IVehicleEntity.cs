using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D0A RID: 32010
	public struct IVehicleEntity : IFlatbufferObject
	{
		// Token: 0x1700EF99 RID: 61337
		// (get) Token: 0x06039C3C RID: 236604 RVA: 0x007CAC3B File Offset: 0x007C8E3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039C3D RID: 236605 RVA: 0x007CAC48 File Offset: 0x007C8E48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039C3E RID: 236606 RVA: 0x007CAC50 File Offset: 0x007C8E50
		public static IVehicleEntity GetRootAsIVehicleEntity(ByteBuffer _bb)
		{
			return IVehicleEntity.GetRootAsIVehicleEntity(_bb, default(IVehicleEntity));
		}

		// Token: 0x06039C3F RID: 236607 RVA: 0x007CAC6C File Offset: 0x007C8E6C
		public static IVehicleEntity GetRootAsIVehicleEntity(ByteBuffer _bb, IVehicleEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039C40 RID: 236608 RVA: 0x007CAC89 File Offset: 0x007C8E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039C41 RID: 236609 RVA: 0x007CAC98 File Offset: 0x007C8E98
		public IVehicleEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF9A RID: 61338
		// (get) Token: 0x06039C42 RID: 236610 RVA: 0x007CACA8 File Offset: 0x007C8EA8
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

		// Token: 0x1700EF9B RID: 61339
		// (get) Token: 0x06039C43 RID: 236611 RVA: 0x007CACE4 File Offset: 0x007C8EE4
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

		// Token: 0x06039C44 RID: 236612 RVA: 0x007CAD20 File Offset: 0x007C8F20
		public TTable? Vehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039C45 RID: 236613 RVA: 0x007CAD64 File Offset: 0x007C8F64
		public IAppointedVehicle VehicleAsIAppointedVehicle()
		{
			return this.Vehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x06039C46 RID: 236614 RVA: 0x007CAD80 File Offset: 0x007C8F80
		public ICurrentVehicle VehicleAsICurrentVehicle()
		{
			return this.Vehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x06039C47 RID: 236615 RVA: 0x007CAD9C File Offset: 0x007C8F9C
		public IFishingBoatVehicle VehicleAsIFishingBoatVehicle()
		{
			return this.Vehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x06039C48 RID: 236616 RVA: 0x007CADB8 File Offset: 0x007C8FB8
		public ISelfVehicle VehicleAsISelfVehicle()
		{
			return this.Vehicle<ISelfVehicle>().Value;
		}

		// Token: 0x06039C49 RID: 236617 RVA: 0x007CADD4 File Offset: 0x007C8FD4
		public ITriggeredVehicle VehicleAsITriggeredVehicle()
		{
			return this.Vehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x06039C4A RID: 236618 RVA: 0x007CADF0 File Offset: 0x007C8FF0
		public IVehiclePlayerMotor VehicleAsIVehiclePlayerMotor()
		{
			return this.Vehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x06039C4B RID: 236619 RVA: 0x007CAE0C File Offset: 0x007C900C
		public IVehicleTeam VehicleAsIVehicleTeam()
		{
			return this.Vehicle<IVehicleTeam>().Value;
		}

		// Token: 0x06039C4C RID: 236620 RVA: 0x007CAE27 File Offset: 0x007C9027
		public static Offset<IVehicleEntity> CreateIVehicleEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target, TTargetVehicle Vehicle_type = TTargetVehicle.NONE, int VehicleOffset = 0)
		{
			builder.StartTable(3);
			IVehicleEntity.AddVehicle(builder, VehicleOffset);
			IVehicleEntity.AddVehicleType(builder, Vehicle_type);
			IVehicleEntity.AddType(builder, Type);
			return IVehicleEntity.EndIVehicleEntity(builder);
		}

		// Token: 0x06039C4D RID: 236621 RVA: 0x007CAE4B File Offset: 0x007C904B
		public static void StartIVehicleEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039C4E RID: 236622 RVA: 0x007CAE54 File Offset: 0x007C9054
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039C4F RID: 236623 RVA: 0x007CAE5F File Offset: 0x007C905F
		public static void AddVehicleType(FlatBufferBuilder builder, TTargetVehicle vehicleType)
		{
			builder.AddByte(1, (byte)vehicleType, 0);
		}

		// Token: 0x06039C50 RID: 236624 RVA: 0x007CAE6A File Offset: 0x007C906A
		public static void AddVehicle(FlatBufferBuilder builder, int vehicleOffset)
		{
			builder.AddOffset(2, vehicleOffset, 0);
		}

		// Token: 0x06039C51 RID: 236625 RVA: 0x007CAE75 File Offset: 0x007C9075
		public static Offset<IVehicleEntity> EndIVehicleEntity(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEntity>(builder.EndTable());
		}

		// Token: 0x06039C52 RID: 236626 RVA: 0x007CAE84 File Offset: 0x007C9084
		public IVehicleEntityT UnPack()
		{
			IVehicleEntityT vehicleEntityT = new IVehicleEntityT();
			this.UnPackTo(vehicleEntityT);
			return vehicleEntityT;
		}

		// Token: 0x06039C53 RID: 236627 RVA: 0x007CAEA0 File Offset: 0x007C90A0
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

		// Token: 0x06039C54 RID: 236628 RVA: 0x007CB084 File Offset: 0x007C9284
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

		// Token: 0x04013433 RID: 78899
		private Table __p;
	}
}
