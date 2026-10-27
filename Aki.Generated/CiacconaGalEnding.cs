using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B79 RID: 2937
	public struct CiacconaGalEnding : IFlatbufferObject
	{
		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06005555 RID: 21845 RVA: 0x001F59B5 File Offset: 0x001F3BB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x001F59C2 File Offset: 0x001F3BC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x001F59CC File Offset: 0x001F3BCC
		public static CiacconaGalEnding GetRootAsCiacconaGalEnding(ByteBuffer _bb)
		{
			return CiacconaGalEnding.GetRootAsCiacconaGalEnding(_bb, default(CiacconaGalEnding));
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x001F59E8 File Offset: 0x001F3BE8
		public static CiacconaGalEnding GetRootAsCiacconaGalEnding(ByteBuffer _bb, CiacconaGalEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x001F5A05 File Offset: 0x001F3C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x001F5A14 File Offset: 0x001F3C14
		public CiacconaGalEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x0600555B RID: 21851 RVA: 0x001F5A24 File Offset: 0x001F3C24
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

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x0600555C RID: 21852 RVA: 0x001F5A60 File Offset: 0x001F3C60
		public string BackgroundImage
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

		// Token: 0x0600555D RID: 21853 RVA: 0x001F5A97 File Offset: 0x001F3C97
		public Span<byte> GetBackgroundImageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x001F5AA6 File Offset: 0x001F3CA6
		public byte[] GetBackgroundImageArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x0600555F RID: 21855 RVA: 0x001F5AC0 File Offset: 0x001F3CC0
		public string DetailBackgroundImage
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

		// Token: 0x06005560 RID: 21856 RVA: 0x001F5AF7 File Offset: 0x001F3CF7
		public Span<byte> GetDetailBackgroundImageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x001F5B06 File Offset: 0x001F3D06
		public byte[] GetDetailBackgroundImageArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06005562 RID: 21858 RVA: 0x001F5B20 File Offset: 0x001F3D20
		public string Title
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

		// Token: 0x06005563 RID: 21859 RVA: 0x001F5B58 File Offset: 0x001F3D58
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x001F5B68 File Offset: 0x001F3D68
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06005565 RID: 21861 RVA: 0x001F5B80 File Offset: 0x001F3D80
		public string Desc
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

		// Token: 0x06005566 RID: 21862 RVA: 0x001F5BB8 File Offset: 0x001F3DB8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x001F5BC8 File Offset: 0x001F3DC8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06005568 RID: 21864 RVA: 0x001F5BE0 File Offset: 0x001F3DE0
		public int Type
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06005569 RID: 21865 RVA: 0x001F5C20 File Offset: 0x001F3E20
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004B7D RID: 19325
		private Table __p;
	}
}
