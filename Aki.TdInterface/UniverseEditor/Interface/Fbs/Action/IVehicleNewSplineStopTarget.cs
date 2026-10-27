using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007526 RID: 29990
	public struct IVehicleNewSplineStopTarget : IFlatbufferObject
	{
		// Token: 0x1700E395 RID: 58261
		// (get) Token: 0x060368EC RID: 223468 RVA: 0x00769A28 File Offset: 0x00767C28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060368ED RID: 223469 RVA: 0x00769A35 File Offset: 0x00767C35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060368EE RID: 223470 RVA: 0x00769A3C File Offset: 0x00767C3C
		public static IVehicleNewSplineStopTarget GetRootAsIVehicleNewSplineStopTarget(ByteBuffer _bb)
		{
			return IVehicleNewSplineStopTarget.GetRootAsIVehicleNewSplineStopTarget(_bb, default(IVehicleNewSplineStopTarget));
		}

		// Token: 0x060368EF RID: 223471 RVA: 0x00769A58 File Offset: 0x00767C58
		public static IVehicleNewSplineStopTarget GetRootAsIVehicleNewSplineStopTarget(ByteBuffer _bb, IVehicleNewSplineStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060368F0 RID: 223472 RVA: 0x00769A75 File Offset: 0x00767C75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060368F1 RID: 223473 RVA: 0x00769A84 File Offset: 0x00767C84
		public IVehicleNewSplineStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E396 RID: 58262
		// (get) Token: 0x060368F2 RID: 223474 RVA: 0x00769A94 File Offset: 0x00767C94
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E397 RID: 58263
		// (get) Token: 0x060368F3 RID: 223475 RVA: 0x00769AD0 File Offset: 0x00767CD0
		public TTargetVehicle TargetVehicleType
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

		// Token: 0x060368F4 RID: 223476 RVA: 0x00769B0C File Offset: 0x00767D0C
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060368F5 RID: 223477 RVA: 0x00769B50 File Offset: 0x00767D50
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x060368F6 RID: 223478 RVA: 0x00769B6C File Offset: 0x00767D6C
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x060368F7 RID: 223479 RVA: 0x00769B88 File Offset: 0x00767D88
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x060368F8 RID: 223480 RVA: 0x00769BA4 File Offset: 0x00767DA4
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x060368F9 RID: 223481 RVA: 0x00769BC0 File Offset: 0x00767DC0
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x060368FA RID: 223482 RVA: 0x00769BDC File Offset: 0x00767DDC
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x060368FB RID: 223483 RVA: 0x00769BF8 File Offset: 0x00767DF8
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x060368FC RID: 223484 RVA: 0x00769C13 File Offset: 0x00767E13
		public static Offset<IVehicleNewSplineStopTarget> CreateIVehicleNewSplineStopTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, TTargetVehicle TargetVehicle_type = TTargetVehicle.NONE, int TargetVehicleOffset = 0)
		{
			builder.StartTable(3);
			IVehicleNewSplineStopTarget.AddTargetVehicle(builder, TargetVehicleOffset);
			IVehicleNewSplineStopTarget.AddTargetVehicleType(builder, TargetVehicle_type);
			IVehicleNewSplineStopTarget.AddType(builder, Type);
			return IVehicleNewSplineStopTarget.EndIVehicleNewSplineStopTarget(builder);
		}

		// Token: 0x060368FD RID: 223485 RVA: 0x00769C37 File Offset: 0x00767E37
		public static void StartIVehicleNewSplineStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060368FE RID: 223486 RVA: 0x00769C40 File Offset: 0x00767E40
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060368FF RID: 223487 RVA: 0x00769C4B File Offset: 0x00767E4B
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(1, (byte)targetVehicleType, 0);
		}

		// Token: 0x06036900 RID: 223488 RVA: 0x00769C56 File Offset: 0x00767E56
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(2, targetVehicleOffset, 0);
		}

		// Token: 0x06036901 RID: 223489 RVA: 0x00769C61 File Offset: 0x00767E61
		public static Offset<IVehicleNewSplineStopTarget> EndIVehicleNewSplineStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleNewSplineStopTarget>(builder.EndTable());
		}

		// Token: 0x06036902 RID: 223490 RVA: 0x00769C70 File Offset: 0x00767E70
		public IVehicleNewSplineStopTargetT UnPack()
		{
			IVehicleNewSplineStopTargetT vehicleNewSplineStopTargetT = new IVehicleNewSplineStopTargetT();
			this.UnPackTo(vehicleNewSplineStopTargetT);
			return vehicleNewSplineStopTargetT;
		}

		// Token: 0x06036903 RID: 223491 RVA: 0x00769C8C File Offset: 0x00767E8C
		public void UnPackTo(IVehicleNewSplineStopTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = new TTargetVehicleUnion();
			_o.TargetVehicle.Type = this.TargetVehicleType;
			switch (this.TargetVehicleType)
			{
			case TTargetVehicle.IAppointedVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IAppointedVehicle>() != null) ? this.TargetVehicle<IAppointedVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.ICurrentVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ICurrentVehicle>() != null) ? this.TargetVehicle<ICurrentVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.IFishingBoatVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IFishingBoatVehicle>() != null) ? this.TargetVehicle<IFishingBoatVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.ISelfVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ISelfVehicle>() != null) ? this.TargetVehicle<ISelfVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.ITriggeredVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ITriggeredVehicle>() != null) ? this.TargetVehicle<ITriggeredVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.IVehiclePlayerMotor:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IVehiclePlayerMotor>() != null) ? this.TargetVehicle<IVehiclePlayerMotor>().Value.UnPack() : null);
				return;
			case TTargetVehicle.IVehicleTeam:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IVehicleTeam>() != null) ? this.TargetVehicle<IVehicleTeam>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06036904 RID: 223492 RVA: 0x00769E70 File Offset: 0x00768070
		public static Offset<IVehicleNewSplineStopTarget> Pack(FlatBufferBuilder builder, IVehicleNewSplineStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleNewSplineStopTarget>);
			}
			TTargetVehicle targetVehicle_type = (_o.TargetVehicle == null) ? TTargetVehicle.NONE : _o.TargetVehicle.Type;
			int targetVehicleOffset = (_o.TargetVehicle == null) ? 0 : TTargetVehicleUnion.Pack(builder, _o.TargetVehicle);
			return IVehicleNewSplineStopTarget.CreateIVehicleNewSplineStopTarget(builder, _o.Type, targetVehicle_type, targetVehicleOffset);
		}

		// Token: 0x04012418 RID: 74776
		private Table __p;
	}
}
