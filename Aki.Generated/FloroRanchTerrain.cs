using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBB RID: 3259
	public struct FloroRanchTerrain : IFlatbufferObject
	{
		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x060074E5 RID: 29925 RVA: 0x0023ED70 File Offset: 0x0023CF70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x0023ED7D File Offset: 0x0023CF7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x0023ED84 File Offset: 0x0023CF84
		public static FloroRanchTerrain GetRootAsFloroRanchTerrain(ByteBuffer _bb)
		{
			return FloroRanchTerrain.GetRootAsFloroRanchTerrain(_bb, default(FloroRanchTerrain));
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x0023EDA0 File Offset: 0x0023CFA0
		public static FloroRanchTerrain GetRootAsFloroRanchTerrain(ByteBuffer _bb, FloroRanchTerrain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x0023EDBD File Offset: 0x0023CFBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x0023EDCC File Offset: 0x0023CFCC
		public FloroRanchTerrain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x060074EB RID: 29931 RVA: 0x0023EDDC File Offset: 0x0023CFDC
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

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x060074EC RID: 29932 RVA: 0x0023EE18 File Offset: 0x0023D018
		public string Name
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

		// Token: 0x060074ED RID: 29933 RVA: 0x0023EE4F File Offset: 0x0023D04F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x0023EE5E File Offset: 0x0023D05E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x060074EF RID: 29935 RVA: 0x0023EE78 File Offset: 0x0023D078
		public string Pic
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

		// Token: 0x060074F0 RID: 29936 RVA: 0x0023EEAF File Offset: 0x0023D0AF
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x0023EEBE File Offset: 0x0023D0BE
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x060074F2 RID: 29938 RVA: 0x0023EED8 File Offset: 0x0023D0D8
		public int Tag
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

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x060074F3 RID: 29939 RVA: 0x0023EF18 File Offset: 0x0023D118
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

		// Token: 0x060074F4 RID: 29940 RVA: 0x0023EF50 File Offset: 0x0023D150
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x0023EF60 File Offset: 0x0023D160
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x060074F6 RID: 29942 RVA: 0x0023EF78 File Offset: 0x0023D178
		public string Icon
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

		// Token: 0x060074F7 RID: 29943 RVA: 0x0023EFB0 File Offset: 0x0023D1B0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x0023EFC0 File Offset: 0x0023D1C0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D2B RID: 19755
		private Table __p;
	}
}
