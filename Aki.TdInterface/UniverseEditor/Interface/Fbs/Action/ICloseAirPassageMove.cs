using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200640F RID: 25615
	public struct ICloseAirPassageMove : IFlatbufferObject
	{
		// Token: 0x1700BEBC RID: 48828
		// (get) Token: 0x0602C521 RID: 181537 RVA: 0x006154AD File Offset: 0x006136AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C522 RID: 181538 RVA: 0x006154BA File Offset: 0x006136BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C523 RID: 181539 RVA: 0x006154C4 File Offset: 0x006136C4
		public static ICloseAirPassageMove GetRootAsICloseAirPassageMove(ByteBuffer _bb)
		{
			return ICloseAirPassageMove.GetRootAsICloseAirPassageMove(_bb, default(ICloseAirPassageMove));
		}

		// Token: 0x0602C524 RID: 181540 RVA: 0x006154E0 File Offset: 0x006136E0
		public static ICloseAirPassageMove GetRootAsICloseAirPassageMove(ByteBuffer _bb, ICloseAirPassageMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C525 RID: 181541 RVA: 0x006154FD File Offset: 0x006136FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C526 RID: 181542 RVA: 0x0061550C File Offset: 0x0061370C
		public ICloseAirPassageMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEBD RID: 48829
		// (get) Token: 0x0602C527 RID: 181543 RVA: 0x0061551C File Offset: 0x0061371C
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

		// Token: 0x1700BEBE RID: 48830
		// (get) Token: 0x0602C528 RID: 181544 RVA: 0x00615558 File Offset: 0x00613758
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

		// Token: 0x1700BEBF RID: 48831
		// (get) Token: 0x0602C529 RID: 181545 RVA: 0x00615598 File Offset: 0x00613798
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

		// Token: 0x0602C52A RID: 181546 RVA: 0x006155D4 File Offset: 0x006137D4
		public static Offset<ICloseAirPassageMove> CreateICloseAirPassageMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseAirPassageMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ICloseAirPassageMove.AddNullMask(builder, NullMask);
			ICloseAirPassageMove.AddType(builder, Type);
			return ICloseAirPassageMove.EndICloseAirPassageMove(builder);
		}

		// Token: 0x0602C52B RID: 181547 RVA: 0x006155F8 File Offset: 0x006137F8
		public static void StartICloseAirPassageMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C52C RID: 181548 RVA: 0x00615601 File Offset: 0x00613801
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C52D RID: 181549 RVA: 0x0061560C File Offset: 0x0061380C
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602C52E RID: 181550 RVA: 0x0061561F File Offset: 0x0061381F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C52F RID: 181551 RVA: 0x0061562A File Offset: 0x0061382A
		public static Offset<ICloseAirPassageMove> EndICloseAirPassageMove(FlatBufferBuilder builder)
		{
			return new Offset<ICloseAirPassageMove>(builder.EndTable());
		}

		// Token: 0x0602C530 RID: 181552 RVA: 0x00615638 File Offset: 0x00613838
		public ICloseAirPassageMoveT UnPack()
		{
			ICloseAirPassageMoveT closeAirPassageMoveT = new ICloseAirPassageMoveT();
			this.UnPackTo(closeAirPassageMoveT);
			return closeAirPassageMoveT;
		}

		// Token: 0x0602C531 RID: 181553 RVA: 0x00615653 File Offset: 0x00613853
		public void UnPackTo(ICloseAirPassageMoveT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C532 RID: 181554 RVA: 0x0061567C File Offset: 0x0061387C
		public static Offset<ICloseAirPassageMove> Pack(FlatBufferBuilder builder, ICloseAirPassageMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseAirPassageMove>);
			}
			return ICloseAirPassageMove.CreateICloseAirPassageMove(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x040109FD RID: 68093
		private Table __p;
	}
}
