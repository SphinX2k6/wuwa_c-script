using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDC RID: 3292
	public struct DownLoadTab : IFlatbufferObject
	{
		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060068E0 RID: 26848 RVA: 0x00234751 File Offset: 0x00232951
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x0023475E File Offset: 0x0023295E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x00234768 File Offset: 0x00232968
		public static DownLoadTab GetRootAsDownLoadTab(ByteBuffer _bb)
		{
			return DownLoadTab.GetRootAsDownLoadTab(_bb, default(DownLoadTab));
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x00234784 File Offset: 0x00232984
		public static DownLoadTab GetRootAsDownLoadTab(ByteBuffer _bb, DownLoadTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x002347A1 File Offset: 0x002329A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x002347B0 File Offset: 0x002329B0
		public DownLoadTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060068E6 RID: 26854 RVA: 0x002347C0 File Offset: 0x002329C0
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

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060068E7 RID: 26855 RVA: 0x002347FC File Offset: 0x002329FC
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

		// Token: 0x060068E8 RID: 26856 RVA: 0x00234833 File Offset: 0x00232A33
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x00234842 File Offset: 0x00232A42
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060068EA RID: 26858 RVA: 0x0023485C File Offset: 0x00232A5C
		public string ContentTitle
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

		// Token: 0x060068EB RID: 26859 RVA: 0x00234893 File Offset: 0x00232A93
		public Span<byte> GetContentTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x002348A2 File Offset: 0x00232AA2
		public byte[] GetContentTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060068ED RID: 26861 RVA: 0x002348BC File Offset: 0x00232ABC
		public string Content
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

		// Token: 0x060068EE RID: 26862 RVA: 0x002348F4 File Offset: 0x00232AF4
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x00234904 File Offset: 0x00232B04
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060068F0 RID: 26864 RVA: 0x0023491C File Offset: 0x00232B1C
		public string ContentTitleHD
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

		// Token: 0x060068F1 RID: 26865 RVA: 0x00234954 File Offset: 0x00232B54
		public Span<byte> GetContentTitleHDBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x00234964 File Offset: 0x00232B64
		public byte[] GetContentTitleHDArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060068F3 RID: 26867 RVA: 0x0023497C File Offset: 0x00232B7C
		public string ContentHD
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

		// Token: 0x060068F4 RID: 26868 RVA: 0x002349B4 File Offset: 0x00232BB4
		public Span<byte> GetContentHDBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x002349C4 File Offset: 0x00232BC4
		public byte[] GetContentHDArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060068F6 RID: 26870 RVA: 0x002349DC File Offset: 0x00232BDC
		public string ContentTitleSD
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

		// Token: 0x060068F7 RID: 26871 RVA: 0x00234A14 File Offset: 0x00232C14
		public Span<byte> GetContentTitleSDBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060068F8 RID: 26872 RVA: 0x00234A24 File Offset: 0x00232C24
		public byte[] GetContentTitleSDArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060068F9 RID: 26873 RVA: 0x00234A3C File Offset: 0x00232C3C
		public string ContentSD
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

		// Token: 0x060068FA RID: 26874 RVA: 0x00234A74 File Offset: 0x00232C74
		public Span<byte> GetContentSDBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x00234A84 File Offset: 0x00232C84
		public byte[] GetContentSDArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005209 RID: 21001
		private Table __p;
	}
}
