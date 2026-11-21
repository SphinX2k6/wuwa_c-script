using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE7 RID: 4071
	public struct PhonographAlbum : IFlatbufferObject
	{
		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x0600B113 RID: 45331 RVA: 0x002D55CE File Offset: 0x002D37CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B114 RID: 45332 RVA: 0x002D55DB File Offset: 0x002D37DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B115 RID: 45333 RVA: 0x002D55E4 File Offset: 0x002D37E4
		public static PhonographAlbum GetRootAsPhonographAlbum(ByteBuffer _bb)
		{
			return PhonographAlbum.GetRootAsPhonographAlbum(_bb, default(PhonographAlbum));
		}

		// Token: 0x0600B116 RID: 45334 RVA: 0x002D5600 File Offset: 0x002D3800
		public static PhonographAlbum GetRootAsPhonographAlbum(ByteBuffer _bb, PhonographAlbum obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B117 RID: 45335 RVA: 0x002D561D File Offset: 0x002D381D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B118 RID: 45336 RVA: 0x002D562C File Offset: 0x002D382C
		public PhonographAlbum __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x0600B119 RID: 45337 RVA: 0x002D563C File Offset: 0x002D383C
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

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x0600B11A RID: 45338 RVA: 0x002D5678 File Offset: 0x002D3878
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

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x0600B11B RID: 45339 RVA: 0x002D56B4 File Offset: 0x002D38B4
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

		// Token: 0x0600B11C RID: 45340 RVA: 0x002D56EB File Offset: 0x002D38EB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B11D RID: 45341 RVA: 0x002D56FA File Offset: 0x002D38FA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x0600B11E RID: 45342 RVA: 0x002D5714 File Offset: 0x002D3914
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

		// Token: 0x0600B11F RID: 45343 RVA: 0x002D574C File Offset: 0x002D394C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B120 RID: 45344 RVA: 0x002D575C File Offset: 0x002D395C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x0600B121 RID: 45345 RVA: 0x002D5774 File Offset: 0x002D3974
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

		// Token: 0x0600B122 RID: 45346 RVA: 0x002D57AC File Offset: 0x002D39AC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B123 RID: 45347 RVA: 0x002D57BC File Offset: 0x002D39BC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x0600B124 RID: 45348 RVA: 0x002D57D4 File Offset: 0x002D39D4
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

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x0600B125 RID: 45349 RVA: 0x002D5814 File Offset: 0x002D3A14
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

		// Token: 0x0600B126 RID: 45350 RVA: 0x002D584C File Offset: 0x002D3A4C
		public Span<byte> GetCoverBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B127 RID: 45351 RVA: 0x002D585C File Offset: 0x002D3A5C
		public byte[] GetCoverArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040055AF RID: 21935
		private Table __p;
	}
}
