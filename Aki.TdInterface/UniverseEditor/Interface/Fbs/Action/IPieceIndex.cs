using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCF RID: 27855
	public struct IPieceIndex : IFlatbufferObject
	{
		// Token: 0x1700CF62 RID: 53090
		// (get) Token: 0x06031181 RID: 201089 RVA: 0x006A97E4 File Offset: 0x006A79E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031182 RID: 201090 RVA: 0x006A97F1 File Offset: 0x006A79F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031183 RID: 201091 RVA: 0x006A97F8 File Offset: 0x006A79F8
		public static IPieceIndex GetRootAsIPieceIndex(ByteBuffer _bb)
		{
			return IPieceIndex.GetRootAsIPieceIndex(_bb, default(IPieceIndex));
		}

		// Token: 0x06031184 RID: 201092 RVA: 0x006A9814 File Offset: 0x006A7A14
		public static IPieceIndex GetRootAsIPieceIndex(ByteBuffer _bb, IPieceIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031185 RID: 201093 RVA: 0x006A9831 File Offset: 0x006A7A31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031186 RID: 201094 RVA: 0x006A9840 File Offset: 0x006A7A40
		public IPieceIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF63 RID: 53091
		// (get) Token: 0x06031187 RID: 201095 RVA: 0x006A9850 File Offset: 0x006A7A50
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

		// Token: 0x1700CF64 RID: 53092
		// (get) Token: 0x06031188 RID: 201096 RVA: 0x006A988C File Offset: 0x006A7A8C
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

		// Token: 0x06031189 RID: 201097 RVA: 0x006A98C8 File Offset: 0x006A7AC8
		public static Offset<IPieceIndex> CreateIPieceIndex(FlatBufferBuilder builder, int RowIndex = 0, int ColumnIndex = 0)
		{
			builder.StartTable(2);
			IPieceIndex.AddColumnIndex(builder, ColumnIndex);
			IPieceIndex.AddRowIndex(builder, RowIndex);
			return IPieceIndex.EndIPieceIndex(builder);
		}

		// Token: 0x0603118A RID: 201098 RVA: 0x006A98E5 File Offset: 0x006A7AE5
		public static void StartIPieceIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603118B RID: 201099 RVA: 0x006A98EE File Offset: 0x006A7AEE
		public static void AddRowIndex(FlatBufferBuilder builder, int rowIndex)
		{
			builder.AddInt(0, rowIndex, 0);
		}

		// Token: 0x0603118C RID: 201100 RVA: 0x006A98F9 File Offset: 0x006A7AF9
		public static void AddColumnIndex(FlatBufferBuilder builder, int columnIndex)
		{
			builder.AddInt(1, columnIndex, 0);
		}

		// Token: 0x0603118D RID: 201101 RVA: 0x006A9904 File Offset: 0x006A7B04
		public static Offset<IPieceIndex> EndIPieceIndex(FlatBufferBuilder builder)
		{
			return new Offset<IPieceIndex>(builder.EndTable());
		}

		// Token: 0x0603118E RID: 201102 RVA: 0x006A9914 File Offset: 0x006A7B14
		public IPieceIndexT UnPack()
		{
			IPieceIndexT pieceIndexT = new IPieceIndexT();
			this.UnPackTo(pieceIndexT);
			return pieceIndexT;
		}

		// Token: 0x0603118F RID: 201103 RVA: 0x006A992F File Offset: 0x006A7B2F
		public void UnPackTo(IPieceIndexT _o)
		{
			_o.RowIndex = this.RowIndex;
			_o.ColumnIndex = this.ColumnIndex;
		}

		// Token: 0x06031190 RID: 201104 RVA: 0x006A994C File Offset: 0x006A7B4C
		public static Offset<IPieceIndex> Pack(FlatBufferBuilder builder, IPieceIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPieceIndex>);
			}
			return IPieceIndex.CreateIPieceIndex(builder, _o.RowIndex, _o.ColumnIndex);
		}

		// Token: 0x04011636 RID: 71222
		private Table __p;
	}
}
