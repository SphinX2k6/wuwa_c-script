using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200645A RID: 25690
	public struct IColorPiece : IFlatbufferObject
	{
		// Token: 0x1700BF32 RID: 48946
		// (get) Token: 0x0602C74D RID: 182093 RVA: 0x00618EC4 File Offset: 0x006170C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C74E RID: 182094 RVA: 0x00618ED1 File Offset: 0x006170D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x0602C74F RID: 182095 RVA: 0x00618EE0 File Offset: 0x006170E0
		public IColorPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF33 RID: 48947
		// (get) Token: 0x0602C750 RID: 182096 RVA: 0x00618EF0 File Offset: 0x006170F0
		public EPieceColorType Color
		{
			get
			{
				return (EPieceColorType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x0602C751 RID: 182097 RVA: 0x00618F0D File Offset: 0x0061710D
		public static Offset<IColorPiece> CreateIColorPiece(FlatBufferBuilder builder, EPieceColorType Color)
		{
			builder.Prep(1, 1);
			builder.PutByte((byte)Color);
			return new Offset<IColorPiece>(builder.Offset);
		}

		// Token: 0x0602C752 RID: 182098 RVA: 0x00618F2C File Offset: 0x0061712C
		public IColorPieceT UnPack()
		{
			IColorPieceT colorPieceT = new IColorPieceT();
			this.UnPackTo(colorPieceT);
			return colorPieceT;
		}

		// Token: 0x0602C753 RID: 182099 RVA: 0x00618F47 File Offset: 0x00617147
		public void UnPackTo(IColorPieceT _o)
		{
			_o.Color = this.Color;
		}

		// Token: 0x0602C754 RID: 182100 RVA: 0x00618F58 File Offset: 0x00617158
		public static Offset<IColorPiece> Pack(FlatBufferBuilder builder, IColorPieceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IColorPiece>);
			}
			return IColorPiece.CreateIColorPiece(builder, _o.Color);
		}

		// Token: 0x04010A58 RID: 68184
		private Struct __p;
	}
}
