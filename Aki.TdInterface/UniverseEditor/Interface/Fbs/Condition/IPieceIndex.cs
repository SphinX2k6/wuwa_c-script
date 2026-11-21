using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005178 RID: 20856
	public struct IPieceIndex : IFlatbufferObject
	{
		// Token: 0x17009564 RID: 38244
		// (get) Token: 0x06020CFF RID: 134399 RVA: 0x0048AD52 File Offset: 0x00488F52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020D00 RID: 134400 RVA: 0x0048AD5F File Offset: 0x00488F5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020D01 RID: 134401 RVA: 0x0048AD68 File Offset: 0x00488F68
		public static IPieceIndex GetRootAsIPieceIndex(ByteBuffer _bb)
		{
			return IPieceIndex.GetRootAsIPieceIndex(_bb, default(IPieceIndex));
		}

		// Token: 0x06020D02 RID: 134402 RVA: 0x0048AD84 File Offset: 0x00488F84
		public static IPieceIndex GetRootAsIPieceIndex(ByteBuffer _bb, IPieceIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020D03 RID: 134403 RVA: 0x0048ADA1 File Offset: 0x00488FA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020D04 RID: 134404 RVA: 0x0048ADB0 File Offset: 0x00488FB0
		public IPieceIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009565 RID: 38245
		// (get) Token: 0x06020D05 RID: 134405 RVA: 0x0048ADC0 File Offset: 0x00488FC0
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

		// Token: 0x17009566 RID: 38246
		// (get) Token: 0x06020D06 RID: 134406 RVA: 0x0048ADFC File Offset: 0x00488FFC
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

		// Token: 0x06020D07 RID: 134407 RVA: 0x0048AE38 File Offset: 0x00489038
		public static Offset<IPieceIndex> CreateIPieceIndex(FlatBufferBuilder builder, int RowIndex = 0, int ColumnIndex = 0)
		{
			builder.StartTable(2);
			IPieceIndex.AddColumnIndex(builder, ColumnIndex);
			IPieceIndex.AddRowIndex(builder, RowIndex);
			return IPieceIndex.EndIPieceIndex(builder);
		}

		// Token: 0x06020D08 RID: 134408 RVA: 0x0048AE55 File Offset: 0x00489055
		public static void StartIPieceIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020D09 RID: 134409 RVA: 0x0048AE5E File Offset: 0x0048905E
		public static void AddRowIndex(FlatBufferBuilder builder, int rowIndex)
		{
			builder.AddInt(0, rowIndex, 0);
		}

		// Token: 0x06020D0A RID: 134410 RVA: 0x0048AE69 File Offset: 0x00489069
		public static void AddColumnIndex(FlatBufferBuilder builder, int columnIndex)
		{
			builder.AddInt(1, columnIndex, 0);
		}

		// Token: 0x06020D0B RID: 134411 RVA: 0x0048AE74 File Offset: 0x00489074
		public static Offset<IPieceIndex> EndIPieceIndex(FlatBufferBuilder builder)
		{
			return new Offset<IPieceIndex>(builder.EndTable());
		}

		// Token: 0x06020D0C RID: 134412 RVA: 0x0048AE84 File Offset: 0x00489084
		public IPieceIndexT UnPack()
		{
			IPieceIndexT pieceIndexT = new IPieceIndexT();
			this.UnPackTo(pieceIndexT);
			return pieceIndexT;
		}

		// Token: 0x06020D0D RID: 134413 RVA: 0x0048AE9F File Offset: 0x0048909F
		public void UnPackTo(IPieceIndexT _o)
		{
			_o.RowIndex = this.RowIndex;
			_o.ColumnIndex = this.ColumnIndex;
		}

		// Token: 0x06020D0E RID: 134414 RVA: 0x0048AEBC File Offset: 0x004890BC
		public static Offset<IPieceIndex> Pack(FlatBufferBuilder builder, IPieceIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPieceIndex>);
			}
			return IPieceIndex.CreateIPieceIndex(builder, _o.RowIndex, _o.ColumnIndex);
		}

		// Token: 0x0400E15C RID: 57692
		private Table __p;
	}
}
