using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4D RID: 3149
	public struct ChatFilterType : IFlatbufferObject
	{
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060059A0 RID: 22944 RVA: 0x00212505 File Offset: 0x00210705
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x00212512 File Offset: 0x00210712
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x0021251C File Offset: 0x0021071C
		public static ChatFilterType GetRootAsChatFilterType(ByteBuffer _bb)
		{
			return ChatFilterType.GetRootAsChatFilterType(_bb, default(ChatFilterType));
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x00212538 File Offset: 0x00210738
		public static ChatFilterType GetRootAsChatFilterType(ByteBuffer _bb, ChatFilterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x00212555 File Offset: 0x00210755
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060059A5 RID: 22949 RVA: 0x00212564 File Offset: 0x00210764
		public ChatFilterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060059A6 RID: 22950 RVA: 0x00212574 File Offset: 0x00210774
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

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060059A7 RID: 22951 RVA: 0x002125B0 File Offset: 0x002107B0
		public string Title
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x002125E7 File Offset: 0x002107E7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060059A9 RID: 22953 RVA: 0x002125F6 File Offset: 0x002107F6
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400514F RID: 20815
		private Table __p;
	}
}
