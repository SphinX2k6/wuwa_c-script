using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007502 RID: 29954
	public struct IVehicleEnter : IFlatbufferObject
	{
		// Token: 0x1700E344 RID: 58180
		// (get) Token: 0x06036775 RID: 223093 RVA: 0x00766190 File Offset: 0x00764390
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036776 RID: 223094 RVA: 0x0076619D File Offset: 0x0076439D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036777 RID: 223095 RVA: 0x007661A4 File Offset: 0x007643A4
		public static IVehicleEnter GetRootAsIVehicleEnter(ByteBuffer _bb)
		{
			return IVehicleEnter.GetRootAsIVehicleEnter(_bb, default(IVehicleEnter));
		}

		// Token: 0x06036778 RID: 223096 RVA: 0x007661C0 File Offset: 0x007643C0
		public static IVehicleEnter GetRootAsIVehicleEnter(ByteBuffer _bb, IVehicleEnter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036779 RID: 223097 RVA: 0x007661DD File Offset: 0x007643DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603677A RID: 223098 RVA: 0x007661EC File Offset: 0x007643EC
		public IVehicleEnter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E345 RID: 58181
		// (get) Token: 0x0603677B RID: 223099 RVA: 0x007661FC File Offset: 0x007643FC
		public TVehicleEnteringTarget EnteringTargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TVehicleEnteringTarget.NONE;
				}
				return (TVehicleEnteringTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603677C RID: 223100 RVA: 0x00766238 File Offset: 0x00764438
		public TTable? EnteringTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603677D RID: 223101 RVA: 0x0076627C File Offset: 0x0076447C
		public IVehicleEnteringNpcTarget EnteringTargetAsIVehicleEnteringNpcTarget()
		{
			return this.EnteringTarget<IVehicleEnteringNpcTarget>().Value;
		}

		// Token: 0x0603677E RID: 223102 RVA: 0x00766298 File Offset: 0x00764498
		public IVehicleEnteringPlayerTarget EnteringTargetAsIVehicleEnteringPlayerTarget()
		{
			return this.EnteringTarget<IVehicleEnteringPlayerTarget>().Value;
		}

		// Token: 0x1700E346 RID: 58182
		// (get) Token: 0x0603677F RID: 223103 RVA: 0x007662B4 File Offset: 0x007644B4
		public TTargetVehicle VehicleTargetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTargetVehicle.NONE;
				}
				return (TTargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036780 RID: 223104 RVA: 0x007662F0 File Offset: 0x007644F0
		public TTable? VehicleTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036781 RID: 223105 RVA: 0x00766338 File Offset: 0x00764538
		public IAppointedVehicle VehicleTargetAsIAppointedVehicle()
		{
			return this.VehicleTarget<IAppointedVehicle>().Value;
		}

		// Token: 0x06036782 RID: 223106 RVA: 0x00766354 File Offset: 0x00764554
		public ICurrentVehicle VehicleTargetAsICurrentVehicle()
		{
			return this.VehicleTarget<ICurrentVehicle>().Value;
		}

		// Token: 0x06036783 RID: 223107 RVA: 0x00766370 File Offset: 0x00764570
		public IFishingBoatVehicle VehicleTargetAsIFishingBoatVehicle()
		{
			return this.VehicleTarget<IFishingBoatVehicle>().Value;
		}

		// Token: 0x06036784 RID: 223108 RVA: 0x0076638C File Offset: 0x0076458C
		public ISelfVehicle VehicleTargetAsISelfVehicle()
		{
			return this.VehicleTarget<ISelfVehicle>().Value;
		}

		// Token: 0x06036785 RID: 223109 RVA: 0x007663A8 File Offset: 0x007645A8
		public ITriggeredVehicle VehicleTargetAsITriggeredVehicle()
		{
			return this.VehicleTarget<ITriggeredVehicle>().Value;
		}

		// Token: 0x06036786 RID: 223110 RVA: 0x007663C4 File Offset: 0x007645C4
		public IVehiclePlayerMotor VehicleTargetAsIVehiclePlayerMotor()
		{
			return this.VehicleTarget<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x06036787 RID: 223111 RVA: 0x007663E0 File Offset: 0x007645E0
		public IVehicleTeam VehicleTargetAsIVehicleTeam()
		{
			return this.VehicleTarget<IVehicleTeam>().Value;
		}

		// Token: 0x1700E347 RID: 58183
		// (get) Token: 0x06036788 RID: 223112 RVA: 0x007663FC File Offset: 0x007645FC
		public EVehicleSeat Seat
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EVehicleSeat.Seat0;
				}
				return (EVehicleSeat)this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E348 RID: 58184
		// (get) Token: 0x06036789 RID: 223113 RVA: 0x0076643C File Offset: 0x0076463C
		public bool ForceExitLastVehicle
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E349 RID: 58185
		// (get) Token: 0x0603678A RID: 223114 RVA: 0x0076647C File Offset: 0x0076467C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603678B RID: 223115 RVA: 0x007664BC File Offset: 0x007646BC
		public static Offset<IVehicleEnter> CreateIVehicleEnter(FlatBufferBuilder builder, TVehicleEnteringTarget EnteringTarget_type = TVehicleEnteringTarget.NONE, int EnteringTargetOffset = 0, TTargetVehicle VehicleTarget_type = TTargetVehicle.NONE, int VehicleTargetOffset = 0, EVehicleSeat Seat = EVehicleSeat.Seat0, bool ForceExitLastVehicle = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IVehicleEnter.AddVehicleTarget(builder, VehicleTargetOffset);
			IVehicleEnter.AddEnteringTarget(builder, EnteringTargetOffset);
			IVehicleEnter.AddSeat(builder, Seat);
			IVehicleEnter.AddNullMask(builder, NullMask);
			IVehicleEnter.AddForceExitLastVehicle(builder, ForceExitLastVehicle);
			IVehicleEnter.AddVehicleTargetType(builder, VehicleTarget_type);
			IVehicleEnter.AddEnteringTargetType(builder, EnteringTarget_type);
			return IVehicleEnter.EndIVehicleEnter(builder);
		}

		// Token: 0x0603678C RID: 223116 RVA: 0x0076650B File Offset: 0x0076470B
		public static void StartIVehicleEnter(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603678D RID: 223117 RVA: 0x00766514 File Offset: 0x00764714
		public static void AddEnteringTargetType(FlatBufferBuilder builder, TVehicleEnteringTarget enteringTargetType)
		{
			builder.AddByte(0, (byte)enteringTargetType, 0);
		}

		// Token: 0x0603678E RID: 223118 RVA: 0x0076651F File Offset: 0x0076471F
		public static void AddEnteringTarget(FlatBufferBuilder builder, int enteringTargetOffset)
		{
			builder.AddOffset(1, enteringTargetOffset, 0);
		}

		// Token: 0x0603678F RID: 223119 RVA: 0x0076652A File Offset: 0x0076472A
		public static void AddVehicleTargetType(FlatBufferBuilder builder, TTargetVehicle vehicleTargetType)
		{
			builder.AddByte(2, (byte)vehicleTargetType, 0);
		}

		// Token: 0x06036790 RID: 223120 RVA: 0x00766535 File Offset: 0x00764735
		public static void AddVehicleTarget(FlatBufferBuilder builder, int vehicleTargetOffset)
		{
			builder.AddOffset(3, vehicleTargetOffset, 0);
		}

		// Token: 0x06036791 RID: 223121 RVA: 0x00766540 File Offset: 0x00764740
		public static void AddSeat(FlatBufferBuilder builder, EVehicleSeat seat)
		{
			builder.AddUshort(4, (ushort)seat, 0);
		}

		// Token: 0x06036792 RID: 223122 RVA: 0x0076654B File Offset: 0x0076474B
		public static void AddForceExitLastVehicle(FlatBufferBuilder builder, bool forceExitLastVehicle)
		{
			builder.AddBool(5, forceExitLastVehicle, false);
		}

		// Token: 0x06036793 RID: 223123 RVA: 0x00766556 File Offset: 0x00764756
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06036794 RID: 223124 RVA: 0x00766561 File Offset: 0x00764761
		public static Offset<IVehicleEnter> EndIVehicleEnter(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEnter>(builder.EndTable());
		}

		// Token: 0x06036795 RID: 223125 RVA: 0x00766570 File Offset: 0x00764770
		public IVehicleEnterT UnPack()
		{
			IVehicleEnterT vehicleEnterT = new IVehicleEnterT();
			this.UnPackTo(vehicleEnterT);
			return vehicleEnterT;
		}

		// Token: 0x06036796 RID: 223126 RVA: 0x0076658C File Offset: 0x0076478C
		public void UnPackTo(IVehicleEnterT _o)
		{
			_o.EnteringTarget = new TVehicleEnteringTargetUnion();
			_o.EnteringTarget.Type = this.EnteringTargetType;
			TVehicleEnteringTarget enteringTargetType = this.EnteringTargetType;
			if (enteringTargetType != TVehicleEnteringTarget.IVehicleEnteringNpcTarget)
			{
				if (enteringTargetType == TVehicleEnteringTarget.IVehicleEnteringPlayerTarget)
				{
					_o.EnteringTarget.Value = ((this.EnteringTarget<IVehicleEnteringPlayerTarget>() != null) ? this.EnteringTarget<IVehicleEnteringPlayerTarget>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.EnteringTarget.Value = ((this.EnteringTarget<IVehicleEnteringNpcTarget>() != null) ? this.EnteringTarget<IVehicleEnteringNpcTarget>().Value.UnPack() : null);
			}
			_o.VehicleTarget = new TTargetVehicleUnion();
			_o.VehicleTarget.Type = this.VehicleTargetType;
			switch (this.VehicleTargetType)
			{
			case TTargetVehicle.IAppointedVehicle:
				_o.VehicleTarget.Value = ((this.VehicleTarget<IAppointedVehicle>() != null) ? this.VehicleTarget<IAppointedVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ICurrentVehicle:
				_o.VehicleTarget.Value = ((this.VehicleTarget<ICurrentVehicle>() != null) ? this.VehicleTarget<ICurrentVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IFishingBoatVehicle:
				_o.VehicleTarget.Value = ((this.VehicleTarget<IFishingBoatVehicle>() != null) ? this.VehicleTarget<IFishingBoatVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ISelfVehicle:
				_o.VehicleTarget.Value = ((this.VehicleTarget<ISelfVehicle>() != null) ? this.VehicleTarget<ISelfVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ITriggeredVehicle:
				_o.VehicleTarget.Value = ((this.VehicleTarget<ITriggeredVehicle>() != null) ? this.VehicleTarget<ITriggeredVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IVehiclePlayerMotor:
				_o.VehicleTarget.Value = ((this.VehicleTarget<IVehiclePlayerMotor>() != null) ? this.VehicleTarget<IVehiclePlayerMotor>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IVehicleTeam:
				_o.VehicleTarget.Value = ((this.VehicleTarget<IVehicleTeam>() != null) ? this.VehicleTarget<IVehicleTeam>().Value.UnPack() : null);
				break;
			}
			_o.Seat = this.Seat;
			_o.ForceExitLastVehicle = this.ForceExitLastVehicle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036797 RID: 223127 RVA: 0x0076683C File Offset: 0x00764A3C
		public static Offset<IVehicleEnter> Pack(FlatBufferBuilder builder, IVehicleEnterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleEnter>);
			}
			TVehicleEnteringTarget enteringTarget_type = (_o.EnteringTarget == null) ? TVehicleEnteringTarget.NONE : _o.EnteringTarget.Type;
			int enteringTargetOffset = (_o.EnteringTarget == null) ? 0 : TVehicleEnteringTargetUnion.Pack(builder, _o.EnteringTarget);
			TTargetVehicle vehicleTarget_type = (_o.VehicleTarget == null) ? TTargetVehicle.NONE : _o.VehicleTarget.Type;
			int vehicleTargetOffset = (_o.VehicleTarget == null) ? 0 : TTargetVehicleUnion.Pack(builder, _o.VehicleTarget);
			return IVehicleEnter.CreateIVehicleEnter(builder, enteringTarget_type, enteringTargetOffset, vehicleTarget_type, vehicleTargetOffset, _o.Seat, _o.ForceExitLastVehicle, _o.NullMask);
		}

		// Token: 0x040123E4 RID: 74724
		private Table __p;
	}
}
