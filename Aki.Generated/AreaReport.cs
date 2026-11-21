using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE1 RID: 3041
	public struct AreaReport : IFlatbufferObject
	{
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06004E0C RID: 19980 RVA: 0x001F7ADE File Offset: 0x001F5CDE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x001F7AEB File Offset: 0x001F5CEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x001F7AF4 File Offset: 0x001F5CF4
		public static AreaReport GetRootAsAreaReport(ByteBuffer _bb)
		{
			return AreaReport.GetRootAsAreaReport(_bb, default(AreaReport));
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x001F7B10 File Offset: 0x001F5D10
		public static AreaReport GetRootAsAreaReport(ByteBuffer _bb, AreaReport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x001F7B2D File Offset: 0x001F5D2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x001F7B3C File Offset: 0x001F5D3C
		public AreaReport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06004E12 RID: 19986 RVA: 0x001F7B4C File Offset: 0x001F5D4C
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

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06004E13 RID: 19987 RVA: 0x001F7B88 File Offset: 0x001F5D88
		public int AreaId
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

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06004E14 RID: 19988 RVA: 0x001F7BC4 File Offset: 0x001F5DC4
		public int Stage
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

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06004E15 RID: 19989 RVA: 0x001F7C00 File Offset: 0x001F5E00
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

		// Token: 0x06004E16 RID: 19990 RVA: 0x001F7C38 File Offset: 0x001F5E38
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x001F7C48 File Offset: 0x001F5E48
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06004E18 RID: 19992 RVA: 0x001F7C60 File Offset: 0x001F5E60
		public int Unlock
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

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06004E19 RID: 19993 RVA: 0x001F7CA0 File Offset: 0x001F5EA0
		public string LockText
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

		// Token: 0x06004E1A RID: 19994 RVA: 0x001F7CD8 File Offset: 0x001F5ED8
		public Span<byte> GetLockTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x001F7CE8 File Offset: 0x001F5EE8
		public byte[] GetLockTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06004E1C RID: 19996 RVA: 0x001F7D00 File Offset: 0x001F5F00
		public string PicResource
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

		// Token: 0x06004E1D RID: 19997 RVA: 0x001F7D38 File Offset: 0x001F5F38
		public Span<byte> GetPicResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x001F7D48 File Offset: 0x001F5F48
		public byte[] GetPicResourceArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06004E1F RID: 19999 RVA: 0x001F7D60 File Offset: 0x001F5F60
		public string StageTitle
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

		// Token: 0x06004E20 RID: 20000 RVA: 0x001F7D98 File Offset: 0x001F5F98
		public Span<byte> GetStageTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x001F7DA8 File Offset: 0x001F5FA8
		public byte[] GetStageTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x040050C6 RID: 20678
		private Table __p;
	}
}
