using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F58 RID: 3928
	public struct PreheatVote : IFlatbufferObject
	{
		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x0600B31A RID: 45850 RVA: 0x002CACC8 File Offset: 0x002C8EC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x002CACD5 File Offset: 0x002C8ED5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B31C RID: 45852 RVA: 0x002CACDC File Offset: 0x002C8EDC
		public static PreheatVote GetRootAsPreheatVote(ByteBuffer _bb)
		{
			return PreheatVote.GetRootAsPreheatVote(_bb, default(PreheatVote));
		}

		// Token: 0x0600B31D RID: 45853 RVA: 0x002CACF8 File Offset: 0x002C8EF8
		public static PreheatVote GetRootAsPreheatVote(ByteBuffer _bb, PreheatVote obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x002CAD15 File Offset: 0x002C8F15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x002CAD24 File Offset: 0x002C8F24
		public PreheatVote __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x0600B320 RID: 45856 RVA: 0x002CAD34 File Offset: 0x002C8F34
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

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x0600B321 RID: 45857 RVA: 0x002CAD70 File Offset: 0x002C8F70
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

		// Token: 0x0600B322 RID: 45858 RVA: 0x002CADA7 File Offset: 0x002C8FA7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B323 RID: 45859 RVA: 0x002CADB6 File Offset: 0x002C8FB6
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x0600B324 RID: 45860 RVA: 0x002CADD0 File Offset: 0x002C8FD0
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

		// Token: 0x0600B325 RID: 45861 RVA: 0x002CAE07 File Offset: 0x002C9007
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B326 RID: 45862 RVA: 0x002CAE16 File Offset: 0x002C9016
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x0600B327 RID: 45863 RVA: 0x002CAE30 File Offset: 0x002C9030
		public string Option1
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

		// Token: 0x0600B328 RID: 45864 RVA: 0x002CAE68 File Offset: 0x002C9068
		public Span<byte> GetOption1Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B329 RID: 45865 RVA: 0x002CAE78 File Offset: 0x002C9078
		public byte[] GetOption1Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x0600B32A RID: 45866 RVA: 0x002CAE90 File Offset: 0x002C9090
		public string Option2
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

		// Token: 0x0600B32B RID: 45867 RVA: 0x002CAEC8 File Offset: 0x002C90C8
		public Span<byte> GetOption2Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B32C RID: 45868 RVA: 0x002CAED8 File Offset: 0x002C90D8
		public byte[] GetOption2Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x0600B32D RID: 45869 RVA: 0x002CAEF0 File Offset: 0x002C90F0
		public string NpcIconPath
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

		// Token: 0x0600B32E RID: 45870 RVA: 0x002CAF28 File Offset: 0x002C9128
		public Span<byte> GetNpcIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B32F RID: 45871 RVA: 0x002CAF38 File Offset: 0x002C9138
		public byte[] GetNpcIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x0600B330 RID: 45872 RVA: 0x002CAF50 File Offset: 0x002C9150
		public string NpcContent
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

		// Token: 0x0600B331 RID: 45873 RVA: 0x002CAF88 File Offset: 0x002C9188
		public Span<byte> GetNpcContentBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B332 RID: 45874 RVA: 0x002CAF98 File Offset: 0x002C9198
		public byte[] GetNpcContentArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x0600B333 RID: 45875 RVA: 0x002CAFB0 File Offset: 0x002C91B0
		public string OptionContent1
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

		// Token: 0x0600B334 RID: 45876 RVA: 0x002CAFE8 File Offset: 0x002C91E8
		public Span<byte> GetOptionContent1Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x002CAFF8 File Offset: 0x002C91F8
		public byte[] GetOptionContent1Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x0600B336 RID: 45878 RVA: 0x002CB010 File Offset: 0x002C9210
		public string OptionContent2
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

		// Token: 0x0600B337 RID: 45879 RVA: 0x002CB048 File Offset: 0x002C9248
		public Span<byte> GetOptionContent2Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B338 RID: 45880 RVA: 0x002CB058 File Offset: 0x002C9258
		public byte[] GetOptionContent2Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x0600B339 RID: 45881 RVA: 0x002CB070 File Offset: 0x002C9270
		public string OptionTheme1
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

		// Token: 0x0600B33A RID: 45882 RVA: 0x002CB0A8 File Offset: 0x002C92A8
		public Span<byte> GetOptionTheme1Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B33B RID: 45883 RVA: 0x002CB0B8 File Offset: 0x002C92B8
		public byte[] GetOptionTheme1Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x0600B33C RID: 45884 RVA: 0x002CB0D0 File Offset: 0x002C92D0
		public string OptionTheme2
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x002CB108 File Offset: 0x002C9308
		public Span<byte> GetOptionTheme2Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x002CB118 File Offset: 0x002C9318
		public byte[] GetOptionTheme2Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04005025 RID: 20517
		private Table __p;
	}
}
