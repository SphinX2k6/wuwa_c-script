using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDA RID: 3546
	public struct GeographyHandBook : IFlatbufferObject
	{
		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06008013 RID: 32787 RVA: 0x00268D85 File Offset: 0x00266F85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008014 RID: 32788 RVA: 0x00268D92 File Offset: 0x00266F92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x00268D9C File Offset: 0x00266F9C
		public static GeographyHandBook GetRootAsGeographyHandBook(ByteBuffer _bb)
		{
			return GeographyHandBook.GetRootAsGeographyHandBook(_bb, default(GeographyHandBook));
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x00268DB8 File Offset: 0x00266FB8
		public static GeographyHandBook GetRootAsGeographyHandBook(ByteBuffer _bb, GeographyHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008017 RID: 32791 RVA: 0x00268DD5 File Offset: 0x00266FD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008018 RID: 32792 RVA: 0x00268DE4 File Offset: 0x00266FE4
		public GeographyHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06008019 RID: 32793 RVA: 0x00268DF4 File Offset: 0x00266FF4
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

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x0600801A RID: 32794 RVA: 0x00268E30 File Offset: 0x00267030
		public int GeographyTabType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x0600801B RID: 32795 RVA: 0x00268E6C File Offset: 0x0026706C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x0600801C RID: 32796 RVA: 0x00268EA8 File Offset: 0x002670A8
		public string Name
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

		// Token: 0x0600801D RID: 32797 RVA: 0x00268EE0 File Offset: 0x002670E0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600801E RID: 32798 RVA: 0x00268EF0 File Offset: 0x002670F0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x0600801F RID: 32799 RVA: 0x00268F08 File Offset: 0x00267108
		public string Texture
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

		// Token: 0x06008020 RID: 32800 RVA: 0x00268F40 File Offset: 0x00267140
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008021 RID: 32801 RVA: 0x00268F50 File Offset: 0x00267150
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06008022 RID: 32802 RVA: 0x00268F68 File Offset: 0x00267168
		public string TypeDescrtption
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

		// Token: 0x06008023 RID: 32803 RVA: 0x00268FA0 File Offset: 0x002671A0
		public Span<byte> GetTypeDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008024 RID: 32804 RVA: 0x00268FB0 File Offset: 0x002671B0
		public byte[] GetTypeDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06008025 RID: 32805 RVA: 0x00268FC8 File Offset: 0x002671C8
		public string Descrtption
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

		// Token: 0x06008026 RID: 32806 RVA: 0x00269000 File Offset: 0x00267200
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008027 RID: 32807 RVA: 0x00269010 File Offset: 0x00267210
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400534D RID: 21325
		private Table __p;
	}
}
