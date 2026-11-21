using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC2 RID: 27330
	public struct IColorPiece : IFlatbufferObject
	{
		// Token: 0x1700C8B4 RID: 51380
		// (get) Token: 0x0602EE92 RID: 192146 RVA: 0x00663F90 File Offset: 0x00662190
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE93 RID: 192147 RVA: 0x00663F9D File Offset: 0x0066219D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x0602EE94 RID: 192148 RVA: 0x00663FAC File Offset: 0x006621AC
		public IColorPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8B5 RID: 51381
		// (get) Token: 0x0602EE95 RID: 192149 RVA: 0x00663FBC File Offset: 0x006621BC
		public EPieceColorType Color
		{
			get
			{
				return (EPieceColorType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x0602EE96 RID: 192150 RVA: 0x00663FD9 File Offset: 0x006621D9
		public static Offset<IColorPiece> CreateIColorPiece(FlatBufferBuilder builder, EPieceColorType Color)
		{
			builder.Prep(1, 1);
			builder.PutByte((byte)Color);
			return new Offset<IColorPiece>(builder.Offset);
		}

		// Token: 0x0602EE97 RID: 192151 RVA: 0x00663FF8 File Offset: 0x006621F8
		public IColorPieceT UnPack()
		{
			IColorPieceT colorPieceT = new IColorPieceT();
			this.UnPackTo(colorPieceT);
			return colorPieceT;
		}

		// Token: 0x0602EE98 RID: 192152 RVA: 0x00664013 File Offset: 0x00662213
		public void UnPackTo(IColorPieceT _o)
		{
			_o.Color = this.Color;
		}

		// Token: 0x0602EE99 RID: 192153 RVA: 0x00664024 File Offset: 0x00662224
		public static Offset<IColorPiece> Pack(FlatBufferBuilder builder, IColorPieceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IColorPiece>);
			}
			return IColorPiece.CreateIColorPiece(builder, _o.Color);
		}

		// Token: 0x04011863 RID: 71779
		private Struct __p;
	}
}
