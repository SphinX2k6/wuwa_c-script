using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6D RID: 2925
	public struct ChatFilterType : IFlatbufferObject
	{
		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x001F27CD File Offset: 0x001F09CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x001F27DA File Offset: 0x001F09DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x001F27E4 File Offset: 0x001F09E4
		public static ChatFilterType GetRootAsChatFilterType(ByteBuffer _bb)
		{
			return ChatFilterType.GetRootAsChatFilterType(_bb, default(ChatFilterType));
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x001F2800 File Offset: 0x001F0A00
		public static ChatFilterType GetRootAsChatFilterType(ByteBuffer _bb, ChatFilterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x001F281D File Offset: 0x001F0A1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x001F282C File Offset: 0x001F0A2C
		public ChatFilterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x001F283C File Offset: 0x001F0A3C
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

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060053E5 RID: 21477 RVA: 0x001F2878 File Offset: 0x001F0A78
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

		// Token: 0x060053E6 RID: 21478 RVA: 0x001F28AF File Offset: 0x001F0AAF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x001F28BE File Offset: 0x001F0ABE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B6F RID: 19311
		private Table __p;
	}
}
