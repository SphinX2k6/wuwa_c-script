using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7E RID: 3454
	public struct ItemHandBook : IFlatbufferObject
	{
		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06008655 RID: 34389 RVA: 0x00265D41 File Offset: 0x00263F41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008656 RID: 34390 RVA: 0x00265D4E File Offset: 0x00263F4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008657 RID: 34391 RVA: 0x00265D58 File Offset: 0x00263F58
		public static ItemHandBook GetRootAsItemHandBook(ByteBuffer _bb)
		{
			return ItemHandBook.GetRootAsItemHandBook(_bb, default(ItemHandBook));
		}

		// Token: 0x06008658 RID: 34392 RVA: 0x00265D74 File Offset: 0x00263F74
		public static ItemHandBook GetRootAsItemHandBook(ByteBuffer _bb, ItemHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008659 RID: 34393 RVA: 0x00265D91 File Offset: 0x00263F91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600865A RID: 34394 RVA: 0x00265DA0 File Offset: 0x00263FA0
		public ItemHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x0600865B RID: 34395 RVA: 0x00265DB0 File Offset: 0x00263FB0
		public int Id
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

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x0600865C RID: 34396 RVA: 0x00265DEC File Offset: 0x00263FEC
		public int Type
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

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x0600865D RID: 34397 RVA: 0x00265E28 File Offset: 0x00264028
		public string Title
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x00265E5F File Offset: 0x0026405F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600865F RID: 34399 RVA: 0x00265E6E File Offset: 0x0026406E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E07 RID: 19975
		private Table __p;
	}
}
