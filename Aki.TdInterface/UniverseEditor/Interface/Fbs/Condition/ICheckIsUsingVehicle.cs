using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AA8 RID: 19112
	public struct ICheckIsUsingVehicle : IFlatbufferObject
	{
		// Token: 0x17008A80 RID: 35456
		// (get) Token: 0x0601DFD2 RID: 122834 RVA: 0x00435BA4 File Offset: 0x00433DA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DFD3 RID: 122835 RVA: 0x00435BB1 File Offset: 0x00433DB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DFD4 RID: 122836 RVA: 0x00435BB8 File Offset: 0x00433DB8
		public static ICheckIsUsingVehicle GetRootAsICheckIsUsingVehicle(ByteBuffer _bb)
		{
			return ICheckIsUsingVehicle.GetRootAsICheckIsUsingVehicle(_bb, default(ICheckIsUsingVehicle));
		}

		// Token: 0x0601DFD5 RID: 122837 RVA: 0x00435BD4 File Offset: 0x00433DD4
		public static ICheckIsUsingVehicle GetRootAsICheckIsUsingVehicle(ByteBuffer _bb, ICheckIsUsingVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DFD6 RID: 122838 RVA: 0x00435BF1 File Offset: 0x00433DF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DFD7 RID: 122839 RVA: 0x00435C00 File Offset: 0x00433E00
		public ICheckIsUsingVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A81 RID: 35457
		// (get) Token: 0x0601DFD8 RID: 122840 RVA: 0x00435C10 File Offset: 0x00433E10
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

		// Token: 0x17008A82 RID: 35458
		// (get) Token: 0x0601DFD9 RID: 122841 RVA: 0x00435C4C File Offset: 0x00433E4C
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

		// Token: 0x17008A83 RID: 35459
		// (get) Token: 0x0601DFDA RID: 122842 RVA: 0x00435C88 File Offset: 0x00433E88
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

		// Token: 0x17008A84 RID: 35460
		// (get) Token: 0x0601DFDB RID: 122843 RVA: 0x00435CC4 File Offset: 0x00433EC4
		public bool CheckIsBeingUsed
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008A85 RID: 35461
		// (get) Token: 0x0601DFDC RID: 122844 RVA: 0x00435D04 File Offset: 0x00433F04
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

		// Token: 0x0601DFDD RID: 122845 RVA: 0x00435D41 File Offset: 0x00433F41
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

		// Token: 0x0601DFDE RID: 122846 RVA: 0x00435D75 File Offset: 0x00433F75
		public static void StartICheckIsUsingVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601DFDF RID: 122847 RVA: 0x00435D7E File Offset: 0x00433F7E
		public static void AddType(FlatBufferBuilder builder, EVehicleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DFE0 RID: 122848 RVA: 0x00435D89 File Offset: 0x00433F89
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicle)
		{
			builder.AddInt(1, targetVehicle, 0);
		}

		// Token: 0x0601DFE1 RID: 122849 RVA: 0x00435D94 File Offset: 0x00433F94
		public static void AddSeat(FlatBufferBuilder builder, EVehicleSeat seat)
		{
			builder.AddUshort(2, (ushort)seat, 0);
		}

		// Token: 0x0601DFE2 RID: 122850 RVA: 0x00435D9F File Offset: 0x00433F9F
		public static void AddCheckIsBeingUsed(FlatBufferBuilder builder, bool checkIsBeingUsed)
		{
			builder.AddBool(3, checkIsBeingUsed, false);
		}

		// Token: 0x0601DFE3 RID: 122851 RVA: 0x00435DAA File Offset: 0x00433FAA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601DFE4 RID: 122852 RVA: 0x00435DB5 File Offset: 0x00433FB5
		public static Offset<ICheckIsUsingVehicle> EndICheckIsUsingVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsUsingVehicle>(builder.EndTable());
		}

		// Token: 0x0601DFE5 RID: 122853 RVA: 0x00435DC4 File Offset: 0x00433FC4
		public ICheckIsUsingVehicleT UnPack()
		{
			ICheckIsUsingVehicleT checkIsUsingVehicleT = new ICheckIsUsingVehicleT();
			this.UnPackTo(checkIsUsingVehicleT);
			return checkIsUsingVehicleT;
		}

		// Token: 0x0601DFE6 RID: 122854 RVA: 0x00435DDF File Offset: 0x00433FDF
		public void UnPackTo(ICheckIsUsingVehicleT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = this.TargetVehicle;
			_o.Seat = this.Seat;
			_o.CheckIsBeingUsed = this.CheckIsBeingUsed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601DFE7 RID: 122855 RVA: 0x00435E20 File Offset: 0x00434020
		public static Offset<ICheckIsUsingVehicle> Pack(FlatBufferBuilder builder, ICheckIsUsingVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsUsingVehicle>);
			}
			return ICheckIsUsingVehicle.CreateICheckIsUsingVehicle(builder, _o.Type, _o.TargetVehicle, _o.Seat, _o.CheckIsBeingUsed, _o.NullMask);
		}

		// Token: 0x0400D31F RID: 54047
		private Table __p;
	}
}
