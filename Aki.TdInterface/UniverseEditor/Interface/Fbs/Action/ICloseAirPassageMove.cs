using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8F RID: 27279
	public struct ICloseAirPassageMove : IFlatbufferObject
	{
		// Token: 0x1700C856 RID: 51286
		// (get) Token: 0x0602ECF7 RID: 191735 RVA: 0x00661339 File Offset: 0x0065F539
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ECF8 RID: 191736 RVA: 0x00661346 File Offset: 0x0065F546
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ECF9 RID: 191737 RVA: 0x00661350 File Offset: 0x0065F550
		public static ICloseAirPassageMove GetRootAsICloseAirPassageMove(ByteBuffer _bb)
		{
			return ICloseAirPassageMove.GetRootAsICloseAirPassageMove(_bb, default(ICloseAirPassageMove));
		}

		// Token: 0x0602ECFA RID: 191738 RVA: 0x0066136C File Offset: 0x0065F56C
		public static ICloseAirPassageMove GetRootAsICloseAirPassageMove(ByteBuffer _bb, ICloseAirPassageMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ECFB RID: 191739 RVA: 0x00661389 File Offset: 0x0065F589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ECFC RID: 191740 RVA: 0x00661398 File Offset: 0x0065F598
		public ICloseAirPassageMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C857 RID: 51287
		// (get) Token: 0x0602ECFD RID: 191741 RVA: 0x006613A8 File Offset: 0x0065F5A8
		public ESplineMovePattern Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMovePattern.PathLine;
				}
				return (ESplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C858 RID: 51288
		// (get) Token: 0x0602ECFE RID: 191742 RVA: 0x006613E4 File Offset: 0x0065F5E4
		public float GravitySwitchAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C859 RID: 51289
		// (get) Token: 0x0602ECFF RID: 191743 RVA: 0x00661424 File Offset: 0x0065F624
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

		// Token: 0x0602ED00 RID: 191744 RVA: 0x00661460 File Offset: 0x0065F660
		public static Offset<ICloseAirPassageMove> CreateICloseAirPassageMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseAirPassageMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ICloseAirPassageMove.AddNullMask(builder, NullMask);
			ICloseAirPassageMove.AddType(builder, Type);
			return ICloseAirPassageMove.EndICloseAirPassageMove(builder);
		}

		// Token: 0x0602ED01 RID: 191745 RVA: 0x00661484 File Offset: 0x0065F684
		public static void StartICloseAirPassageMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602ED02 RID: 191746 RVA: 0x0066148D File Offset: 0x0065F68D
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ED03 RID: 191747 RVA: 0x00661498 File Offset: 0x0065F698
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602ED04 RID: 191748 RVA: 0x006614AB File Offset: 0x0065F6AB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602ED05 RID: 191749 RVA: 0x006614B6 File Offset: 0x0065F6B6
		public static Offset<ICloseAirPassageMove> EndICloseAirPassageMove(FlatBufferBuilder builder)
		{
			return new Offset<ICloseAirPassageMove>(builder.EndTable());
		}

		// Token: 0x0602ED06 RID: 191750 RVA: 0x006614C4 File Offset: 0x0065F6C4
		public ICloseAirPassageMoveT UnPack()
		{
			ICloseAirPassageMoveT closeAirPassageMoveT = new ICloseAirPassageMoveT();
			this.UnPackTo(closeAirPassageMoveT);
			return closeAirPassageMoveT;
		}

		// Token: 0x0602ED07 RID: 191751 RVA: 0x006614DF File Offset: 0x0065F6DF
		public void UnPackTo(ICloseAirPassageMoveT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602ED08 RID: 191752 RVA: 0x00661508 File Offset: 0x0065F708
		public static Offset<ICloseAirPassageMove> Pack(FlatBufferBuilder builder, ICloseAirPassageMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseAirPassageMove>);
			}
			return ICloseAirPassageMove.CreateICloseAirPassageMove(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x04011823 RID: 71715
		private Table __p;
	}
}
