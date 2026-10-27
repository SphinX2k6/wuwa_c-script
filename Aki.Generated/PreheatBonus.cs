using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F54 RID: 3924
	public struct PreheatBonus : IFlatbufferObject
	{
		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x0600B2B3 RID: 45747 RVA: 0x002C9FBC File Offset: 0x002C81BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x002C9FC9 File Offset: 0x002C81C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x002C9FD0 File Offset: 0x002C81D0
		public static PreheatBonus GetRootAsPreheatBonus(ByteBuffer _bb)
		{
			return PreheatBonus.GetRootAsPreheatBonus(_bb, default(PreheatBonus));
		}

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x002C9FEC File Offset: 0x002C81EC
		public static PreheatBonus GetRootAsPreheatBonus(ByteBuffer _bb, PreheatBonus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B2B7 RID: 45751 RVA: 0x002CA009 File Offset: 0x002C8209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x002CA018 File Offset: 0x002C8218
		public PreheatBonus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x0600B2B9 RID: 45753 RVA: 0x002CA028 File Offset: 0x002C8228
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

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x0600B2BA RID: 45754 RVA: 0x002CA064 File Offset: 0x002C8264
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

		// Token: 0x0600B2BB RID: 45755 RVA: 0x002CA09B File Offset: 0x002C829B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x002CA0AA File Offset: 0x002C82AA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x0600B2BD RID: 45757 RVA: 0x002CA0C4 File Offset: 0x002C82C4
		public string Content
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

		// Token: 0x0600B2BE RID: 45758 RVA: 0x002CA0FB File Offset: 0x002C82FB
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x002CA10A File Offset: 0x002C830A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x0600B2C0 RID: 45760 RVA: 0x002CA124 File Offset: 0x002C8324
		public int CrestIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x0600B2C1 RID: 45761 RVA: 0x002CA164 File Offset: 0x002C8364
		public string MainTex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2C2 RID: 45762 RVA: 0x002CA19C File Offset: 0x002C839C
		public Span<byte> GetMainTexBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x002CA1AC File Offset: 0x002C83AC
		public byte[] GetMainTexArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x0600B2C4 RID: 45764 RVA: 0x002CA1C4 File Offset: 0x002C83C4
		public string Photo
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x002CA1FC File Offset: 0x002C83FC
		public Span<byte> GetPhotoBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x002CA20C File Offset: 0x002C840C
		public byte[] GetPhotoArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x0600B2C7 RID: 45767 RVA: 0x002CA224 File Offset: 0x002C8424
		public string SharePhoto
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x002CA25C File Offset: 0x002C845C
		public Span<byte> GetSharePhotoBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x002CA26C File Offset: 0x002C846C
		public byte[] GetSharePhotoArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x0600B2CA RID: 45770 RVA: 0x002CA284 File Offset: 0x002C8484
		public string NpcIconPath
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x002CA2BC File Offset: 0x002C84BC
		public Span<byte> GetNpcIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x002CA2CC File Offset: 0x002C84CC
		public byte[] GetNpcIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x0600B2CD RID: 45773 RVA: 0x002CA2E4 File Offset: 0x002C84E4
		public string NpcContent
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2CE RID: 45774 RVA: 0x002CA31C File Offset: 0x002C851C
		public Span<byte> GetNpcContentBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B2CF RID: 45775 RVA: 0x002CA32C File Offset: 0x002C852C
		public byte[] GetNpcContentArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x0600B2D0 RID: 45776 RVA: 0x002CA344 File Offset: 0x002C8544
		public string BonusTxt
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2D1 RID: 45777 RVA: 0x002CA37C File Offset: 0x002C857C
		public Span<byte> GetBonusTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B2D2 RID: 45778 RVA: 0x002CA38C File Offset: 0x002C858C
		public byte[] GetBonusTxtArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005021 RID: 20513
		private Table __p;
	}
}
