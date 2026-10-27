using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6F RID: 2927
	public struct ChatPartnerFilter : IFlatbufferObject
	{
		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06005407 RID: 21511 RVA: 0x001F2CF1 File Offset: 0x001F0EF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x001F2CFE File Offset: 0x001F0EFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x001F2D08 File Offset: 0x001F0F08
		public static ChatPartnerFilter GetRootAsChatPartnerFilter(ByteBuffer _bb)
		{
			return ChatPartnerFilter.GetRootAsChatPartnerFilter(_bb, default(ChatPartnerFilter));
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x001F2D24 File Offset: 0x001F0F24
		public static ChatPartnerFilter GetRootAsChatPartnerFilter(ByteBuffer _bb, ChatPartnerFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x001F2D41 File Offset: 0x001F0F41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x001F2D50 File Offset: 0x001F0F50
		public ChatPartnerFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600540D RID: 21517 RVA: 0x001F2D60 File Offset: 0x001F0F60
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

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600540E RID: 21518 RVA: 0x001F2D9C File Offset: 0x001F0F9C
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

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600540F RID: 21519 RVA: 0x001F2DD8 File Offset: 0x001F0FD8
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

		// Token: 0x06005410 RID: 21520 RVA: 0x001F2E0F File Offset: 0x001F100F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x001F2E1E File Offset: 0x001F101E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06005412 RID: 21522 RVA: 0x001F2E38 File Offset: 0x001F1038
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

		// Token: 0x06005413 RID: 21523 RVA: 0x001F2E70 File Offset: 0x001F1070
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x001F2E80 File Offset: 0x001F1080
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06005415 RID: 21525 RVA: 0x001F2E98 File Offset: 0x001F1098
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

		// Token: 0x04004B71 RID: 19313
		private Table __p;
	}
}
