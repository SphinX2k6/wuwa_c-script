using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D1F RID: 32031
	public struct IVehiclePlayerMotor : IFlatbufferObject
	{
		// Token: 0x1700EFC4 RID: 61380
		// (get) Token: 0x06039D21 RID: 236833 RVA: 0x007CD20C File Offset: 0x007CB40C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039D22 RID: 236834 RVA: 0x007CD219 File Offset: 0x007CB419
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039D23 RID: 236835 RVA: 0x007CD220 File Offset: 0x007CB420
		public static IVehiclePlayerMotor GetRootAsIVehiclePlayerMotor(ByteBuffer _bb)
		{
			return IVehiclePlayerMotor.GetRootAsIVehiclePlayerMotor(_bb, default(IVehiclePlayerMotor));
		}

		// Token: 0x06039D24 RID: 236836 RVA: 0x007CD23C File Offset: 0x007CB43C
		public static IVehiclePlayerMotor GetRootAsIVehiclePlayerMotor(ByteBuffer _bb, IVehiclePlayerMotor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039D25 RID: 236837 RVA: 0x007CD259 File Offset: 0x007CB459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039D26 RID: 236838 RVA: 0x007CD268 File Offset: 0x007CB468
		public IVehiclePlayerMotor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFC5 RID: 61381
		// (get) Token: 0x06039D27 RID: 236839 RVA: 0x007CD278 File Offset: 0x007CB478
		public ETargetVehicle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetVehicle.Current;
				}
				return (ETargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EFC6 RID: 61382
		// (get) Token: 0x06039D28 RID: 236840 RVA: 0x007CD2B4 File Offset: 0x007CB4B4
		public int SummonPositionEntityId
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

		// Token: 0x1700EFC7 RID: 61383
		// (get) Token: 0x06039D29 RID: 236841 RVA: 0x007CD2F0 File Offset: 0x007CB4F0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039D2A RID: 236842 RVA: 0x007CD32C File Offset: 0x007CB52C
		public static Offset<IVehiclePlayerMotor> CreateIVehiclePlayerMotor(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current, int SummonPositionEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVehiclePlayerMotor.AddSummonPositionEntityId(builder, SummonPositionEntityId);
			IVehiclePlayerMotor.AddNullMask(builder, NullMask);
			IVehiclePlayerMotor.AddType(builder, Type);
			return IVehiclePlayerMotor.EndIVehiclePlayerMotor(builder);
		}

		// Token: 0x06039D2B RID: 236843 RVA: 0x007CD350 File Offset: 0x007CB550
		public static void StartIVehiclePlayerMotor(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039D2C RID: 236844 RVA: 0x007CD359 File Offset: 0x007CB559
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039D2D RID: 236845 RVA: 0x007CD364 File Offset: 0x007CB564
		public static void AddSummonPositionEntityId(FlatBufferBuilder builder, int summonPositionEntityId)
		{
			builder.AddInt(1, summonPositionEntityId, 0);
		}

		// Token: 0x06039D2E RID: 236846 RVA: 0x007CD36F File Offset: 0x007CB56F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06039D2F RID: 236847 RVA: 0x007CD37A File Offset: 0x007CB57A
		public static Offset<IVehiclePlayerMotor> EndIVehiclePlayerMotor(FlatBufferBuilder builder)
		{
			return new Offset<IVehiclePlayerMotor>(builder.EndTable());
		}

		// Token: 0x06039D30 RID: 236848 RVA: 0x007CD388 File Offset: 0x007CB588
		public IVehiclePlayerMotorT UnPack()
		{
			IVehiclePlayerMotorT vehiclePlayerMotorT = new IVehiclePlayerMotorT();
			this.UnPackTo(vehiclePlayerMotorT);
			return vehiclePlayerMotorT;
		}

		// Token: 0x06039D31 RID: 236849 RVA: 0x007CD3A3 File Offset: 0x007CB5A3
		public void UnPackTo(IVehiclePlayerMotorT _o)
		{
			_o.Type = this.Type;
			_o.SummonPositionEntityId = this.SummonPositionEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039D32 RID: 236850 RVA: 0x007CD3CC File Offset: 0x007CB5CC
		public static Offset<IVehiclePlayerMotor> Pack(FlatBufferBuilder builder, IVehiclePlayerMotorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehiclePlayerMotor>);
			}
			return IVehiclePlayerMotor.CreateIVehiclePlayerMotor(builder, _o.Type, _o.SummonPositionEntityId, _o.NullMask);
		}

		// Token: 0x0401344C RID: 78924
		private Table __p;
	}
}
