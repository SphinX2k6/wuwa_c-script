using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007523 RID: 29987
	public struct IVehicleNewSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700E38C RID: 58252
		// (get) Token: 0x060368C5 RID: 223429 RVA: 0x007693BC File Offset: 0x007675BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060368C6 RID: 223430 RVA: 0x007693C9 File Offset: 0x007675C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060368C7 RID: 223431 RVA: 0x007693D0 File Offset: 0x007675D0
		public static IVehicleNewSplineMoveTarget GetRootAsIVehicleNewSplineMoveTarget(ByteBuffer _bb)
		{
			return IVehicleNewSplineMoveTarget.GetRootAsIVehicleNewSplineMoveTarget(_bb, default(IVehicleNewSplineMoveTarget));
		}

		// Token: 0x060368C8 RID: 223432 RVA: 0x007693EC File Offset: 0x007675EC
		public static IVehicleNewSplineMoveTarget GetRootAsIVehicleNewSplineMoveTarget(ByteBuffer _bb, IVehicleNewSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060368C9 RID: 223433 RVA: 0x00769409 File Offset: 0x00767609
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060368CA RID: 223434 RVA: 0x00769418 File Offset: 0x00767618
		public IVehicleNewSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E38D RID: 58253
		// (get) Token: 0x060368CB RID: 223435 RVA: 0x00769428 File Offset: 0x00767628
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

		// Token: 0x1700E38E RID: 58254
		// (get) Token: 0x060368CC RID: 223436 RVA: 0x00769464 File Offset: 0x00767664
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

		// Token: 0x060368CD RID: 223437 RVA: 0x007694A0 File Offset: 0x007676A0
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060368CE RID: 223438 RVA: 0x007694E4 File Offset: 0x007676E4
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x060368CF RID: 223439 RVA: 0x00769500 File Offset: 0x00767700
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x060368D0 RID: 223440 RVA: 0x0076951C File Offset: 0x0076771C
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x060368D1 RID: 223441 RVA: 0x00769538 File Offset: 0x00767738
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x060368D2 RID: 223442 RVA: 0x00769554 File Offset: 0x00767754
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x060368D3 RID: 223443 RVA: 0x00769570 File Offset: 0x00767770
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x060368D4 RID: 223444 RVA: 0x0076958C File Offset: 0x0076778C
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x1700E38F RID: 58255
		// (get) Token: 0x060368D5 RID: 223445 RVA: 0x007695A8 File Offset: 0x007677A8
		public bool IsLookDir
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E390 RID: 58256
		// (get) Token: 0x060368D6 RID: 223446 RVA: 0x007695E8 File Offset: 0x007677E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060368D7 RID: 223447 RVA: 0x00769625 File Offset: 0x00767825
		public static Offset<IVehicleNewSplineMoveTarget> CreateIVehicleNewSplineMoveTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, TTargetVehicle TargetVehicle_type = TTargetVehicle.NONE, int TargetVehicleOffset = 0, bool IsLookDir = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IVehicleNewSplineMoveTarget.AddTargetVehicle(builder, TargetVehicleOffset);
			IVehicleNewSplineMoveTarget.AddNullMask(builder, NullMask);
			IVehicleNewSplineMoveTarget.AddIsLookDir(builder, IsLookDir);
			IVehicleNewSplineMoveTarget.AddTargetVehicleType(builder, TargetVehicle_type);
			IVehicleNewSplineMoveTarget.AddType(builder, Type);
			return IVehicleNewSplineMoveTarget.EndIVehicleNewSplineMoveTarget(builder);
		}

		// Token: 0x060368D8 RID: 223448 RVA: 0x00769659 File Offset: 0x00767859
		public static void StartIVehicleNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060368D9 RID: 223449 RVA: 0x00769662 File Offset: 0x00767862
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060368DA RID: 223450 RVA: 0x0076966D File Offset: 0x0076786D
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(1, (byte)targetVehicleType, 0);
		}

		// Token: 0x060368DB RID: 223451 RVA: 0x00769678 File Offset: 0x00767878
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(2, targetVehicleOffset, 0);
		}

		// Token: 0x060368DC RID: 223452 RVA: 0x00769683 File Offset: 0x00767883
		public static void AddIsLookDir(FlatBufferBuilder builder, bool isLookDir)
		{
			builder.AddBool(3, isLookDir, false);
		}

		// Token: 0x060368DD RID: 223453 RVA: 0x0076968E File Offset: 0x0076788E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060368DE RID: 223454 RVA: 0x00769699 File Offset: 0x00767899
		public static Offset<IVehicleNewSplineMoveTarget> EndIVehicleNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleNewSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x060368DF RID: 223455 RVA: 0x007696A8 File Offset: 0x007678A8
		public IVehicleNewSplineMoveTargetT UnPack()
		{
			IVehicleNewSplineMoveTargetT vehicleNewSplineMoveTargetT = new IVehicleNewSplineMoveTargetT();
			this.UnPackTo(vehicleNewSplineMoveTargetT);
			return vehicleNewSplineMoveTargetT;
		}

		// Token: 0x060368E0 RID: 223456 RVA: 0x007696C4 File Offset: 0x007678C4
		public void UnPackTo(IVehicleNewSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = new TTargetVehicleUnion();
			_o.TargetVehicle.Type = this.TargetVehicleType;
			switch (this.TargetVehicleType)
			{
			case TTargetVehicle.IAppointedVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IAppointedVehicle>() != null) ? this.TargetVehicle<IAppointedVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ICurrentVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ICurrentVehicle>() != null) ? this.TargetVehicle<ICurrentVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IFishingBoatVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IFishingBoatVehicle>() != null) ? this.TargetVehicle<IFishingBoatVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ISelfVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ISelfVehicle>() != null) ? this.TargetVehicle<ISelfVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ITriggeredVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ITriggeredVehicle>() != null) ? this.TargetVehicle<ITriggeredVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IVehiclePlayerMotor:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IVehiclePlayerMotor>() != null) ? this.TargetVehicle<IVehiclePlayerMotor>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IVehicleTeam:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IVehicleTeam>() != null) ? this.TargetVehicle<IVehicleTeam>().Value.UnPack() : null);
				break;
			}
			_o.IsLookDir = this.IsLookDir;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060368E1 RID: 223457 RVA: 0x007698D8 File Offset: 0x00767AD8
		public static Offset<IVehicleNewSplineMoveTarget> Pack(FlatBufferBuilder builder, IVehicleNewSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleNewSplineMoveTarget>);
			}
			TTargetVehicle targetVehicle_type = (_o.TargetVehicle == null) ? TTargetVehicle.NONE : _o.TargetVehicle.Type;
			int targetVehicleOffset = (_o.TargetVehicle == null) ? 0 : TTargetVehicleUnion.Pack(builder, _o.TargetVehicle);
			return IVehicleNewSplineMoveTarget.CreateIVehicleNewSplineMoveTarget(builder, _o.Type, targetVehicle_type, targetVehicleOffset, _o.IsLookDir, _o.NullMask);
		}

		// Token: 0x04012413 RID: 74771
		private Table __p;
	}
}
