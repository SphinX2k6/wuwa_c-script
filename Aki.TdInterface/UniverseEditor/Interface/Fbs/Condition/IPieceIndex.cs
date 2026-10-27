using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C7F RID: 19583
	public struct IPieceIndex : IFlatbufferObject
	{
		// Token: 0x17008E36 RID: 36406
		// (get) Token: 0x0601F0DD RID: 127197 RVA: 0x00457202 File Offset: 0x00455402
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F0DE RID: 127198 RVA: 0x0045720F File Offset: 0x0045540F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F0DF RID: 127199 RVA: 0x00457218 File Offset: 0x00455418
		public static IPieceIndex GetRootAsIPieceIndex(ByteBuffer _bb)
		{
			return IPieceIndex.GetRootAsIPieceIndex(_bb, default(IPieceIndex));
		}

		// Token: 0x0601F0E0 RID: 127200 RVA: 0x00457234 File Offset: 0x00455434
		public static IPieceIndex GetRootAsIPieceIndex(ByteBuffer _bb, IPieceIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F0E1 RID: 127201 RVA: 0x00457251 File Offset: 0x00455451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F0E2 RID: 127202 RVA: 0x00457260 File Offset: 0x00455460
		public IPieceIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E37 RID: 36407
		// (get) Token: 0x0601F0E3 RID: 127203 RVA: 0x00457270 File Offset: 0x00455470
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

		// Token: 0x17008E38 RID: 36408
		// (get) Token: 0x0601F0E4 RID: 127204 RVA: 0x004572AC File Offset: 0x004554AC
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

		// Token: 0x0601F0E5 RID: 127205 RVA: 0x004572E8 File Offset: 0x004554E8
		public static Offset<IPieceIndex> CreateIPieceIndex(FlatBufferBuilder builder, int RowIndex = 0, int ColumnIndex = 0)
		{
			builder.StartTable(2);
			IPieceIndex.AddColumnIndex(builder, ColumnIndex);
			IPieceIndex.AddRowIndex(builder, RowIndex);
			return IPieceIndex.EndIPieceIndex(builder);
		}

		// Token: 0x0601F0E6 RID: 127206 RVA: 0x00457305 File Offset: 0x00455505
		public static void StartIPieceIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F0E7 RID: 127207 RVA: 0x0045730E File Offset: 0x0045550E
		public static void AddRowIndex(FlatBufferBuilder builder, int rowIndex)
		{
			builder.AddInt(0, rowIndex, 0);
		}

		// Token: 0x0601F0E8 RID: 127208 RVA: 0x00457319 File Offset: 0x00455519
		public static void AddColumnIndex(FlatBufferBuilder builder, int columnIndex)
		{
			builder.AddInt(1, columnIndex, 0);
		}

		// Token: 0x0601F0E9 RID: 127209 RVA: 0x00457324 File Offset: 0x00455524
		public static Offset<IPieceIndex> EndIPieceIndex(FlatBufferBuilder builder)
		{
			return new Offset<IPieceIndex>(builder.EndTable());
		}

		// Token: 0x0601F0EA RID: 127210 RVA: 0x00457334 File Offset: 0x00455534
		public IPieceIndexT UnPack()
		{
			IPieceIndexT pieceIndexT = new IPieceIndexT();
			this.UnPackTo(pieceIndexT);
			return pieceIndexT;
		}

		// Token: 0x0601F0EB RID: 127211 RVA: 0x0045734F File Offset: 0x0045554F
		public void UnPackTo(IPieceIndexT _o)
		{
			_o.RowIndex = this.RowIndex;
			_o.ColumnIndex = this.ColumnIndex;
		}

		// Token: 0x0601F0EC RID: 127212 RVA: 0x0045736C File Offset: 0x0045556C
		public static Offset<IPieceIndex> Pack(FlatBufferBuilder builder, IPieceIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPieceIndex>);
			}
			return IPieceIndex.CreateIPieceIndex(builder, _o.RowIndex, _o.ColumnIndex);
		}

		// Token: 0x0400D635 RID: 54837
		private Table __p;
	}
}
