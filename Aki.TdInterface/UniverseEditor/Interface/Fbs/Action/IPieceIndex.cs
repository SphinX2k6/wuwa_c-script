using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007445 RID: 29765
	public struct IPieceIndex : IFlatbufferObject
	{
		// Token: 0x1700DA9F RID: 55967
		// (get) Token: 0x06034158 RID: 213336 RVA: 0x00704A18 File Offset: 0x00702C18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034159 RID: 213337 RVA: 0x00704A25 File Offset: 0x00702C25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603415A RID: 213338 RVA: 0x00704A2C File Offset: 0x00702C2C
		public static IPieceIndex GetRootAsIPieceIndex(ByteBuffer _bb)
		{
			return IPieceIndex.GetRootAsIPieceIndex(_bb, default(IPieceIndex));
		}

		// Token: 0x0603415B RID: 213339 RVA: 0x00704A48 File Offset: 0x00702C48
		public static IPieceIndex GetRootAsIPieceIndex(ByteBuffer _bb, IPieceIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603415C RID: 213340 RVA: 0x00704A65 File Offset: 0x00702C65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603415D RID: 213341 RVA: 0x00704A74 File Offset: 0x00702C74
		public IPieceIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DAA0 RID: 55968
		// (get) Token: 0x0603415E RID: 213342 RVA: 0x00704A84 File Offset: 0x00702C84
		public int RowIndex
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DAA1 RID: 55969
		// (get) Token: 0x0603415F RID: 213343 RVA: 0x00704AC0 File Offset: 0x00702CC0
		public int ColumnIndex
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

		// Token: 0x06034160 RID: 213344 RVA: 0x00704AFC File Offset: 0x00702CFC
		public static Offset<IPieceIndex> CreateIPieceIndex(FlatBufferBuilder builder, int RowIndex = 0, int ColumnIndex = 0)
		{
			builder.StartTable(2);
			IPieceIndex.AddColumnIndex(builder, ColumnIndex);
			IPieceIndex.AddRowIndex(builder, RowIndex);
			return IPieceIndex.EndIPieceIndex(builder);
		}

		// Token: 0x06034161 RID: 213345 RVA: 0x00704B19 File Offset: 0x00702D19
		public static void StartIPieceIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034162 RID: 213346 RVA: 0x00704B22 File Offset: 0x00702D22
		public static void AddRowIndex(FlatBufferBuilder builder, int rowIndex)
		{
			builder.AddInt(0, rowIndex, 0);
		}

		// Token: 0x06034163 RID: 213347 RVA: 0x00704B2D File Offset: 0x00702D2D
		public static void AddColumnIndex(FlatBufferBuilder builder, int columnIndex)
		{
			builder.AddInt(1, columnIndex, 0);
		}

		// Token: 0x06034164 RID: 213348 RVA: 0x00704B38 File Offset: 0x00702D38
		public static Offset<IPieceIndex> EndIPieceIndex(FlatBufferBuilder builder)
		{
			return new Offset<IPieceIndex>(builder.EndTable());
		}

		// Token: 0x06034165 RID: 213349 RVA: 0x00704B48 File Offset: 0x00702D48
		public IPieceIndexT UnPack()
		{
			IPieceIndexT pieceIndexT = new IPieceIndexT();
			this.UnPackTo(pieceIndexT);
			return pieceIndexT;
		}

		// Token: 0x06034166 RID: 213350 RVA: 0x00704B63 File Offset: 0x00702D63
		public void UnPackTo(IPieceIndexT _o)
		{
			_o.RowIndex = this.RowIndex;
			_o.ColumnIndex = this.ColumnIndex;
		}

		// Token: 0x06034167 RID: 213351 RVA: 0x00704B80 File Offset: 0x00702D80
		public static Offset<IPieceIndex> Pack(FlatBufferBuilder builder, IPieceIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPieceIndex>);
			}
			return IPieceIndex.CreateIPieceIndex(builder, _o.RowIndex, _o.ColumnIndex);
		}

		// Token: 0x040125A6 RID: 75174
		private Table __p;
	}
}
