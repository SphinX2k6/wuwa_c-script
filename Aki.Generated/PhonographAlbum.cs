using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F02 RID: 3842
	public struct PhonographAlbum : IFlatbufferObject
	{
		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x0600AAF2 RID: 43762 RVA: 0x002B884D File Offset: 0x002B6A4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x002B885A File Offset: 0x002B6A5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AAF4 RID: 43764 RVA: 0x002B8864 File Offset: 0x002B6A64
		public static PhonographAlbum GetRootAsPhonographAlbum(ByteBuffer _bb)
		{
			return PhonographAlbum.GetRootAsPhonographAlbum(_bb, default(PhonographAlbum));
		}

		// Token: 0x0600AAF5 RID: 43765 RVA: 0x002B8880 File Offset: 0x002B6A80
		public static PhonographAlbum GetRootAsPhonographAlbum(ByteBuffer _bb, PhonographAlbum obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AAF6 RID: 43766 RVA: 0x002B889D File Offset: 0x002B6A9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AAF7 RID: 43767 RVA: 0x002B88AC File Offset: 0x002B6AAC
		public PhonographAlbum __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x0600AAF8 RID: 43768 RVA: 0x002B88BC File Offset: 0x002B6ABC
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

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x0600AAF9 RID: 43769 RVA: 0x002B88F8 File Offset: 0x002B6AF8
		public int TimeQuantum
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

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x0600AAFA RID: 43770 RVA: 0x002B8934 File Offset: 0x002B6B34
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

		// Token: 0x0600AAFB RID: 43771 RVA: 0x002B896B File Offset: 0x002B6B6B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AAFC RID: 43772 RVA: 0x002B897A File Offset: 0x002B6B7A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x0600AAFD RID: 43773 RVA: 0x002B8994 File Offset: 0x002B6B94
		public string Desc
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

		// Token: 0x0600AAFE RID: 43774 RVA: 0x002B89CC File Offset: 0x002B6BCC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AAFF RID: 43775 RVA: 0x002B89DC File Offset: 0x002B6BDC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x0600AB00 RID: 43776 RVA: 0x002B89F4 File Offset: 0x002B6BF4
		public string Icon
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

		// Token: 0x0600AB01 RID: 43777 RVA: 0x002B8A2C File Offset: 0x002B6C2C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AB02 RID: 43778 RVA: 0x002B8A3C File Offset: 0x002B6C3C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x0600AB03 RID: 43779 RVA: 0x002B8A54 File Offset: 0x002B6C54
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x0600AB04 RID: 43780 RVA: 0x002B8A94 File Offset: 0x002B6C94
		public string Cover
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

		// Token: 0x0600AB05 RID: 43781 RVA: 0x002B8ACC File Offset: 0x002B6CCC
		public Span<byte> GetCoverBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x002B8ADC File Offset: 0x002B6CDC
		public byte[] GetCoverArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FCA RID: 20426
		private Table __p;
	}
}
