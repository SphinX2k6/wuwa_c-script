using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F77 RID: 20343
	public struct ICheckIsUsingVehicle : IFlatbufferObject
	{
		// Token: 0x1700916D RID: 37229
		// (get) Token: 0x0601FABB RID: 129723 RVA: 0x004673C4 File Offset: 0x004655C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FABC RID: 129724 RVA: 0x004673D1 File Offset: 0x004655D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FABD RID: 129725 RVA: 0x004673D8 File Offset: 0x004655D8
		public static ICheckIsUsingVehicle GetRootAsICheckIsUsingVehicle(ByteBuffer _bb)
		{
			return ICheckIsUsingVehicle.GetRootAsICheckIsUsingVehicle(_bb, default(ICheckIsUsingVehicle));
		}

		// Token: 0x0601FABE RID: 129726 RVA: 0x004673F4 File Offset: 0x004655F4
		public static ICheckIsUsingVehicle GetRootAsICheckIsUsingVehicle(ByteBuffer _bb, ICheckIsUsingVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FABF RID: 129727 RVA: 0x00467411 File Offset: 0x00465611
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FAC0 RID: 129728 RVA: 0x00467420 File Offset: 0x00465620
		public ICheckIsUsingVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700916E RID: 37230
		// (get) Token: 0x0601FAC1 RID: 129729 RVA: 0x00467430 File Offset: 0x00465630
		public EVehicleConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleConditionType.UsingVehicle;
				}
				return (EVehicleConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700916F RID: 37231
		// (get) Token: 0x0601FAC2 RID: 129730 RVA: 0x0046746C File Offset: 0x0046566C
		public int TargetVehicle
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

		// Token: 0x17009170 RID: 37232
		// (get) Token: 0x0601FAC3 RID: 129731 RVA: 0x004674A8 File Offset: 0x004656A8
		public EVehicleSeat Seat
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EVehicleSeat.Seat0;
				}
				return (EVehicleSeat)this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009171 RID: 37233
		// (get) Token: 0x0601FAC4 RID: 129732 RVA: 0x004674E4 File Offset: 0x004656E4
		public bool CheckIsBeingUsed
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009172 RID: 37234
		// (get) Token: 0x0601FAC5 RID: 129733 RVA: 0x00467524 File Offset: 0x00465724
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

		// Token: 0x0601FAC6 RID: 129734 RVA: 0x00467561 File Offset: 0x00465761
		public static Offset<ICheckIsUsingVehicle> CreateICheckIsUsingVehicle(FlatBufferBuilder builder, EVehicleConditionType Type = EVehicleConditionType.UsingVehicle, int TargetVehicle = 0, EVehicleSeat Seat = EVehicleSeat.Seat0, bool CheckIsBeingUsed = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICheckIsUsingVehicle.AddTargetVehicle(builder, TargetVehicle);
			ICheckIsUsingVehicle.AddSeat(builder, Seat);
			ICheckIsUsingVehicle.AddNullMask(builder, NullMask);
			ICheckIsUsingVehicle.AddCheckIsBeingUsed(builder, CheckIsBeingUsed);
			ICheckIsUsingVehicle.AddType(builder, Type);
			return ICheckIsUsingVehicle.EndICheckIsUsingVehicle(builder);
		}

		// Token: 0x0601FAC7 RID: 129735 RVA: 0x00467595 File Offset: 0x00465795
		public static void StartICheckIsUsingVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601FAC8 RID: 129736 RVA: 0x0046759E File Offset: 0x0046579E
		public static void AddType(FlatBufferBuilder builder, EVehicleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FAC9 RID: 129737 RVA: 0x004675A9 File Offset: 0x004657A9
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicle)
		{
			builder.AddInt(1, targetVehicle, 0);
		}

		// Token: 0x0601FACA RID: 129738 RVA: 0x004675B4 File Offset: 0x004657B4
		public static void AddSeat(FlatBufferBuilder builder, EVehicleSeat seat)
		{
			builder.AddUshort(2, (ushort)seat, 0);
		}

		// Token: 0x0601FACB RID: 129739 RVA: 0x004675BF File Offset: 0x004657BF
		public static void AddCheckIsBeingUsed(FlatBufferBuilder builder, bool checkIsBeingUsed)
		{
			builder.AddBool(3, checkIsBeingUsed, false);
		}

		// Token: 0x0601FACC RID: 129740 RVA: 0x004675CA File Offset: 0x004657CA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601FACD RID: 129741 RVA: 0x004675D5 File Offset: 0x004657D5
		public static Offset<ICheckIsUsingVehicle> EndICheckIsUsingVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsUsingVehicle>(builder.EndTable());
		}

		// Token: 0x0601FACE RID: 129742 RVA: 0x004675E4 File Offset: 0x004657E4
		public ICheckIsUsingVehicleT UnPack()
		{
			ICheckIsUsingVehicleT checkIsUsingVehicleT = new ICheckIsUsingVehicleT();
			this.UnPackTo(checkIsUsingVehicleT);
			return checkIsUsingVehicleT;
		}

		// Token: 0x0601FACF RID: 129743 RVA: 0x004675FF File Offset: 0x004657FF
		public void UnPackTo(ICheckIsUsingVehicleT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = this.TargetVehicle;
			_o.Seat = this.Seat;
			_o.CheckIsBeingUsed = this.CheckIsBeingUsed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601FAD0 RID: 129744 RVA: 0x00467640 File Offset: 0x00465840
		public static Offset<ICheckIsUsingVehicle> Pack(FlatBufferBuilder builder, ICheckIsUsingVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsUsingVehicle>);
			}
			return ICheckIsUsingVehicle.CreateICheckIsUsingVehicle(builder, _o.Type, _o.TargetVehicle, _o.Seat, _o.CheckIsBeingUsed, _o.NullMask);
		}

		// Token: 0x0400DE04 RID: 56836
		private Table __p;
	}
}
