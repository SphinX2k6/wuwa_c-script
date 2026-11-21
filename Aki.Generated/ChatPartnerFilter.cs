using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4F RID: 3151
	public struct ChatPartnerFilter : IFlatbufferObject
	{
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060059C9 RID: 22985 RVA: 0x00212A0D File Offset: 0x00210C0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060059CA RID: 22986 RVA: 0x00212A1A File Offset: 0x00210C1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x00212A24 File Offset: 0x00210C24
		public static ChatPartnerFilter GetRootAsChatPartnerFilter(ByteBuffer _bb)
		{
			return ChatPartnerFilter.GetRootAsChatPartnerFilter(_bb, default(ChatPartnerFilter));
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x00212A40 File Offset: 0x00210C40
		public static ChatPartnerFilter GetRootAsChatPartnerFilter(ByteBuffer _bb, ChatPartnerFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x00212A5D File Offset: 0x00210C5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x00212A6C File Offset: 0x00210C6C
		public ChatPartnerFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060059CF RID: 22991 RVA: 0x00212A7C File Offset: 0x00210C7C
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

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060059D0 RID: 22992 RVA: 0x00212AB8 File Offset: 0x00210CB8
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

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060059D1 RID: 22993 RVA: 0x00212AF4 File Offset: 0x00210CF4
		public string Name
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

		// Token: 0x060059D2 RID: 22994 RVA: 0x00212B2B File Offset: 0x00210D2B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x00212B3A File Offset: 0x00210D3A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060059D4 RID: 22996 RVA: 0x00212B54 File Offset: 0x00210D54
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x00212B8C File Offset: 0x00210D8C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x00212B9C File Offset: 0x00210D9C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060059D7 RID: 22999 RVA: 0x00212BB4 File Offset: 0x00210DB4
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005151 RID: 20817
		private Table __p;
	}
}
