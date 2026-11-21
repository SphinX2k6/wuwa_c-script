using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5C RID: 3164
	public struct CiacconaGalSubEnding : IFlatbufferObject
	{
		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06005B5F RID: 23391 RVA: 0x00215F25 File Offset: 0x00214125
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x00215F32 File Offset: 0x00214132
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x00215F3C File Offset: 0x0021413C
		public static CiacconaGalSubEnding GetRootAsCiacconaGalSubEnding(ByteBuffer _bb)
		{
			return CiacconaGalSubEnding.GetRootAsCiacconaGalSubEnding(_bb, default(CiacconaGalSubEnding));
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x00215F58 File Offset: 0x00214158
		public static CiacconaGalSubEnding GetRootAsCiacconaGalSubEnding(ByteBuffer _bb, CiacconaGalSubEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x00215F75 File Offset: 0x00214175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x00215F84 File Offset: 0x00214184
		public CiacconaGalSubEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06005B65 RID: 23397 RVA: 0x00215F94 File Offset: 0x00214194
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

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06005B66 RID: 23398 RVA: 0x00215FD0 File Offset: 0x002141D0
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

		// Token: 0x06005B67 RID: 23399 RVA: 0x00216007 File Offset: 0x00214207
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x00216016 File Offset: 0x00214216
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06005B69 RID: 23401 RVA: 0x00216030 File Offset: 0x00214230
		public string Desc
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

		// Token: 0x06005B6A RID: 23402 RVA: 0x00216067 File Offset: 0x00214267
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x00216076 File Offset: 0x00214276
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06005B6C RID: 23404 RVA: 0x00216090 File Offset: 0x00214290
		public int Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06005B6D RID: 23405 RVA: 0x002160D0 File Offset: 0x002142D0
		public string BackgroundImage
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

		// Token: 0x06005B6E RID: 23406 RVA: 0x00216108 File Offset: 0x00214308
		public Span<byte> GetBackgroundImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x00216118 File Offset: 0x00214318
		public byte[] GetBackgroundImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06005B70 RID: 23408 RVA: 0x00216130 File Offset: 0x00214330
		public int Reward
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

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06005B71 RID: 23409 RVA: 0x00216170 File Offset: 0x00214370
		public int TriggerEnding
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

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06005B72 RID: 23410 RVA: 0x002161B0 File Offset: 0x002143B0
		public bool ExitOnFinish
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005160 RID: 20832
		private Table __p;
	}
}
