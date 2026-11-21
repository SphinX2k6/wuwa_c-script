using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDD RID: 3293
	public struct DownLoadVersion : IFlatbufferObject
	{
		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060068FC RID: 26876 RVA: 0x00234A9C File Offset: 0x00232C9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x00234AA9 File Offset: 0x00232CA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x00234AB0 File Offset: 0x00232CB0
		public static DownLoadVersion GetRootAsDownLoadVersion(ByteBuffer _bb)
		{
			return DownLoadVersion.GetRootAsDownLoadVersion(_bb, default(DownLoadVersion));
		}

		// Token: 0x060068FF RID: 26879 RVA: 0x00234ACC File Offset: 0x00232CCC
		public static DownLoadVersion GetRootAsDownLoadVersion(ByteBuffer _bb, DownLoadVersion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006900 RID: 26880 RVA: 0x00234AE9 File Offset: 0x00232CE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006901 RID: 26881 RVA: 0x00234AF8 File Offset: 0x00232CF8
		public DownLoadVersion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06006902 RID: 26882 RVA: 0x00234B08 File Offset: 0x00232D08
		public int Version
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

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06006903 RID: 26883 RVA: 0x00234B44 File Offset: 0x00232D44
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

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06006904 RID: 26884 RVA: 0x00234B80 File Offset: 0x00232D80
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

		// Token: 0x06006905 RID: 26885 RVA: 0x00234BB7 File Offset: 0x00232DB7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x00234BC6 File Offset: 0x00232DC6
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06006907 RID: 26887 RVA: 0x00234BE0 File Offset: 0x00232DE0
		public int SortId
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

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06006908 RID: 26888 RVA: 0x00234C20 File Offset: 0x00232E20
		public string HelpTitle
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

		// Token: 0x06006909 RID: 26889 RVA: 0x00234C58 File Offset: 0x00232E58
		public Span<byte> GetHelpTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x00234C68 File Offset: 0x00232E68
		public byte[] GetHelpTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x0600690B RID: 26891 RVA: 0x00234C80 File Offset: 0x00232E80
		public string HelpDesc
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

		// Token: 0x0600690C RID: 26892 RVA: 0x00234CB8 File Offset: 0x00232EB8
		public Span<byte> GetHelpDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x00234CC8 File Offset: 0x00232EC8
		public byte[] GetHelpDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x0600690E RID: 26894 RVA: 0x00234CE0 File Offset: 0x00232EE0
		public string Pic
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

		// Token: 0x0600690F RID: 26895 RVA: 0x00234D18 File Offset: 0x00232F18
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x00234D28 File Offset: 0x00232F28
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06006911 RID: 26897 RVA: 0x00234D40 File Offset: 0x00232F40
		public bool IsRecommend
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400520A RID: 21002
		private Table __p;
	}
}
