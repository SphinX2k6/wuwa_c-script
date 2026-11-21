using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CF8 RID: 31992
	public struct IVehicleEnter : IFlatbufferObject
	{
		// Token: 0x1700EF6E RID: 61294
		// (get) Token: 0x06039B8A RID: 236426 RVA: 0x007C93E0 File Offset: 0x007C75E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039B8B RID: 236427 RVA: 0x007C93ED File Offset: 0x007C75ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039B8C RID: 236428 RVA: 0x007C93F4 File Offset: 0x007C75F4
		public static IVehicleEnter GetRootAsIVehicleEnter(ByteBuffer _bb)
		{
			return IVehicleEnter.GetRootAsIVehicleEnter(_bb, default(IVehicleEnter));
		}

		// Token: 0x06039B8D RID: 236429 RVA: 0x007C9410 File Offset: 0x007C7610
		public static IVehicleEnter GetRootAsIVehicleEnter(ByteBuffer _bb, IVehicleEnter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039B8E RID: 236430 RVA: 0x007C942D File Offset: 0x007C762D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039B8F RID: 236431 RVA: 0x007C943C File Offset: 0x007C763C
		public IVehicleEnter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF6F RID: 61295
		// (get) Token: 0x06039B90 RID: 236432 RVA: 0x007C944C File Offset: 0x007C764C
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

		// Token: 0x06039B91 RID: 236433 RVA: 0x007C9488 File Offset: 0x007C7688
		public TTable? EnteringTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039B92 RID: 236434 RVA: 0x007C94CC File Offset: 0x007C76CC
		public IVehicleEnteringNpcTarget EnteringTargetAsIVehicleEnteringNpcTarget()
		{
			return this.EnteringTarget<IVehicleEnteringNpcTarget>().Value;
		}

		// Token: 0x06039B93 RID: 236435 RVA: 0x007C94E8 File Offset: 0x007C76E8
		public IVehicleEnteringPlayerTarget EnteringTargetAsIVehicleEnteringPlayerTarget()
		{
			return this.EnteringTarget<IVehicleEnteringPlayerTarget>().Value;
		}

		// Token: 0x1700EF70 RID: 61296
		// (get) Token: 0x06039B94 RID: 236436 RVA: 0x007C9504 File Offset: 0x007C7704
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

		// Token: 0x06039B95 RID: 236437 RVA: 0x007C9540 File Offset: 0x007C7740
		public TTable? VehicleTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039B96 RID: 236438 RVA: 0x007C9588 File Offset: 0x007C7788
		public IAppointedVehicle VehicleTargetAsIAppointedVehicle()
		{
			return this.VehicleTarget<IAppointedVehicle>().Value;
		}

		// Token: 0x06039B97 RID: 236439 RVA: 0x007C95A4 File Offset: 0x007C77A4
		public ICurrentVehicle VehicleTargetAsICurrentVehicle()
		{
			return this.VehicleTarget<ICurrentVehicle>().Value;
		}

		// Token: 0x06039B98 RID: 236440 RVA: 0x007C95C0 File Offset: 0x007C77C0
		public IFishingBoatVehicle VehicleTargetAsIFishingBoatVehicle()
		{
			return this.VehicleTarget<IFishingBoatVehicle>().Value;
		}

		// Token: 0x06039B99 RID: 236441 RVA: 0x007C95DC File Offset: 0x007C77DC
		public ISelfVehicle VehicleTargetAsISelfVehicle()
		{
			return this.VehicleTarget<ISelfVehicle>().Value;
		}

		// Token: 0x06039B9A RID: 236442 RVA: 0x007C95F8 File Offset: 0x007C77F8
		public ITriggeredVehicle VehicleTargetAsITriggeredVehicle()
		{
			return this.VehicleTarget<ITriggeredVehicle>().Value;
		}

		// Token: 0x06039B9B RID: 236443 RVA: 0x007C9614 File Offset: 0x007C7814
		public IVehiclePlayerMotor VehicleTargetAsIVehiclePlayerMotor()
		{
			return this.VehicleTarget<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x06039B9C RID: 236444 RVA: 0x007C9630 File Offset: 0x007C7830
		public IVehicleTeam VehicleTargetAsIVehicleTeam()
		{
			return this.VehicleTarget<IVehicleTeam>().Value;
		}

		// Token: 0x1700EF71 RID: 61297
		// (get) Token: 0x06039B9D RID: 236445 RVA: 0x007C964C File Offset: 0x007C784C
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

		// Token: 0x1700EF72 RID: 61298
		// (get) Token: 0x06039B9E RID: 236446 RVA: 0x007C968C File Offset: 0x007C788C
		public bool ForceExitLastVehicle
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EF73 RID: 61299
		// (get) Token: 0x06039B9F RID: 236447 RVA: 0x007C96CC File Offset: 0x007C78CC
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

		// Token: 0x06039BA0 RID: 236448 RVA: 0x007C970C File Offset: 0x007C790C
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

		// Token: 0x06039BA1 RID: 236449 RVA: 0x007C975B File Offset: 0x007C795B
		public static void StartIVehicleEnter(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06039BA2 RID: 236450 RVA: 0x007C9764 File Offset: 0x007C7964
		public static void AddEnteringTargetType(FlatBufferBuilder builder, TVehicleEnteringTarget enteringTargetType)
		{
			builder.AddByte(0, (byte)enteringTargetType, 0);
		}

		// Token: 0x06039BA3 RID: 236451 RVA: 0x007C976F File Offset: 0x007C796F
		public static void AddEnteringTarget(FlatBufferBuilder builder, int enteringTargetOffset)
		{
			builder.AddOffset(1, enteringTargetOffset, 0);
		}

		// Token: 0x06039BA4 RID: 236452 RVA: 0x007C977A File Offset: 0x007C797A
		public static void AddVehicleTargetType(FlatBufferBuilder builder, TTargetVehicle vehicleTargetType)
		{
			builder.AddByte(2, (byte)vehicleTargetType, 0);
		}

		// Token: 0x06039BA5 RID: 236453 RVA: 0x007C9785 File Offset: 0x007C7985
		public static void AddVehicleTarget(FlatBufferBuilder builder, int vehicleTargetOffset)
		{
			builder.AddOffset(3, vehicleTargetOffset, 0);
		}

		// Token: 0x06039BA6 RID: 236454 RVA: 0x007C9790 File Offset: 0x007C7990
		public static void AddSeat(FlatBufferBuilder builder, EVehicleSeat seat)
		{
			builder.AddUshort(4, (ushort)seat, 0);
		}

		// Token: 0x06039BA7 RID: 236455 RVA: 0x007C979B File Offset: 0x007C799B
		public static void AddForceExitLastVehicle(FlatBufferBuilder builder, bool forceExitLastVehicle)
		{
			builder.AddBool(5, forceExitLastVehicle, false);
		}

		// Token: 0x06039BA8 RID: 236456 RVA: 0x007C97A6 File Offset: 0x007C79A6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06039BA9 RID: 236457 RVA: 0x007C97B1 File Offset: 0x007C79B1
		public static Offset<IVehicleEnter> EndIVehicleEnter(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEnter>(builder.EndTable());
		}

		// Token: 0x06039BAA RID: 236458 RVA: 0x007C97C0 File Offset: 0x007C79C0
		public IVehicleEnterT UnPack()
		{
			IVehicleEnterT vehicleEnterT = new IVehicleEnterT();
			this.UnPackTo(vehicleEnterT);
			return vehicleEnterT;
		}

		// Token: 0x06039BAB RID: 236459 RVA: 0x007C97DC File Offset: 0x007C79DC
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

		// Token: 0x06039BAC RID: 236460 RVA: 0x007C9A8C File Offset: 0x007C7C8C
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

		// Token: 0x04013415 RID: 78869
		private Table __p;
	}
}
