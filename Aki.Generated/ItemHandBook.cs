using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E63 RID: 3683
	public struct ItemHandBook : IFlatbufferObject
	{
		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06008C70 RID: 35952 RVA: 0x00283FD1 File Offset: 0x002821D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C71 RID: 35953 RVA: 0x00283FDE File Offset: 0x002821DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C72 RID: 35954 RVA: 0x00283FE8 File Offset: 0x002821E8
		public static ItemHandBook GetRootAsItemHandBook(ByteBuffer _bb)
		{
			return ItemHandBook.GetRootAsItemHandBook(_bb, default(ItemHandBook));
		}

		// Token: 0x06008C73 RID: 35955 RVA: 0x00284004 File Offset: 0x00282204
		public static ItemHandBook GetRootAsItemHandBook(ByteBuffer _bb, ItemHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C74 RID: 35956 RVA: 0x00284021 File Offset: 0x00282221
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C75 RID: 35957 RVA: 0x00284030 File Offset: 0x00282230
		public ItemHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06008C76 RID: 35958 RVA: 0x00284040 File Offset: 0x00282240
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

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06008C77 RID: 35959 RVA: 0x0028407C File Offset: 0x0028227C
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

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06008C78 RID: 35960 RVA: 0x002840B8 File Offset: 0x002822B8
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

		// Token: 0x06008C79 RID: 35961 RVA: 0x002840EF File Offset: 0x002822EF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x002840FE File Offset: 0x002822FE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040053EC RID: 21484
		private Table __p;
	}
}
