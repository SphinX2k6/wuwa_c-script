using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006424 RID: 25636
	public struct IClosePathLineMove : IFlatbufferObject
	{
		// Token: 0x1700BEE5 RID: 48869
		// (get) Token: 0x0602C5C7 RID: 181703 RVA: 0x00616518 File Offset: 0x00614718
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C5C8 RID: 181704 RVA: 0x00616525 File Offset: 0x00614725
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C5C9 RID: 181705 RVA: 0x0061652C File Offset: 0x0061472C
		public static IClosePathLineMove GetRootAsIClosePathLineMove(ByteBuffer _bb)
		{
			return IClosePathLineMove.GetRootAsIClosePathLineMove(_bb, default(IClosePathLineMove));
		}

		// Token: 0x0602C5CA RID: 181706 RVA: 0x00616548 File Offset: 0x00614748
		public static IClosePathLineMove GetRootAsIClosePathLineMove(ByteBuffer _bb, IClosePathLineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C5CB RID: 181707 RVA: 0x00616565 File Offset: 0x00614765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C5CC RID: 181708 RVA: 0x00616574 File Offset: 0x00614774
		public IClosePathLineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEE6 RID: 48870
		// (get) Token: 0x0602C5CD RID: 181709 RVA: 0x00616584 File Offset: 0x00614784
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

		// Token: 0x1700BEE7 RID: 48871
		// (get) Token: 0x0602C5CE RID: 181710 RVA: 0x006165C0 File Offset: 0x006147C0
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

		// Token: 0x1700BEE8 RID: 48872
		// (get) Token: 0x0602C5CF RID: 181711 RVA: 0x00616600 File Offset: 0x00614800
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

		// Token: 0x0602C5D0 RID: 181712 RVA: 0x0061663C File Offset: 0x0061483C
		public static Offset<IClosePathLineMove> CreateIClosePathLineMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IClosePathLineMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			IClosePathLineMove.AddNullMask(builder, NullMask);
			IClosePathLineMove.AddType(builder, Type);
			return IClosePathLineMove.EndIClosePathLineMove(builder);
		}

		// Token: 0x0602C5D1 RID: 181713 RVA: 0x00616660 File Offset: 0x00614860
		public static void StartIClosePathLineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C5D2 RID: 181714 RVA: 0x00616669 File Offset: 0x00614869
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C5D3 RID: 181715 RVA: 0x00616674 File Offset: 0x00614874
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602C5D4 RID: 181716 RVA: 0x00616687 File Offset: 0x00614887
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C5D5 RID: 181717 RVA: 0x00616692 File Offset: 0x00614892
		public static Offset<IClosePathLineMove> EndIClosePathLineMove(FlatBufferBuilder builder)
		{
			return new Offset<IClosePathLineMove>(builder.EndTable());
		}

		// Token: 0x0602C5D6 RID: 181718 RVA: 0x006166A0 File Offset: 0x006148A0
		public IClosePathLineMoveT UnPack()
		{
			IClosePathLineMoveT closePathLineMoveT = new IClosePathLineMoveT();
			this.UnPackTo(closePathLineMoveT);
			return closePathLineMoveT;
		}

		// Token: 0x0602C5D7 RID: 181719 RVA: 0x006166BB File Offset: 0x006148BB
		public void UnPackTo(IClosePathLineMoveT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C5D8 RID: 181720 RVA: 0x006166E4 File Offset: 0x006148E4
		public static Offset<IClosePathLineMove> Pack(FlatBufferBuilder builder, IClosePathLineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClosePathLineMove>);
			}
			return IClosePathLineMove.CreateIClosePathLineMove(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x04010A15 RID: 68117
		private Table __p;
	}
}
