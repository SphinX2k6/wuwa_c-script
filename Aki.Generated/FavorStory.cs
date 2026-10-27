using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C62 RID: 3170
	public struct FavorStory : IFlatbufferObject
	{
		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06006D15 RID: 27925 RVA: 0x0022BF64 File Offset: 0x0022A164
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D16 RID: 27926 RVA: 0x0022BF71 File Offset: 0x0022A171
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D17 RID: 27927 RVA: 0x0022BF78 File Offset: 0x0022A178
		public static FavorStory GetRootAsFavorStory(ByteBuffer _bb)
		{
			return FavorStory.GetRootAsFavorStory(_bb, default(FavorStory));
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x0022BF94 File Offset: 0x0022A194
		public static FavorStory GetRootAsFavorStory(ByteBuffer _bb, FavorStory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D19 RID: 27929 RVA: 0x0022BFB1 File Offset: 0x0022A1B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x0022BFC0 File Offset: 0x0022A1C0
		public FavorStory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06006D1B RID: 27931 RVA: 0x0022BFD0 File Offset: 0x0022A1D0
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

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06006D1C RID: 27932 RVA: 0x0022C00C File Offset: 0x0022A20C
		public int RoleId
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

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06006D1D RID: 27933 RVA: 0x0022C048 File Offset: 0x0022A248
		public int Sort
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

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06006D1E RID: 27934 RVA: 0x0022C084 File Offset: 0x0022A284
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

		// Token: 0x06006D1F RID: 27935 RVA: 0x0022C0BC File Offset: 0x0022A2BC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x0022C0CC File Offset: 0x0022A2CC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06006D21 RID: 27937 RVA: 0x0022C0E4 File Offset: 0x0022A2E4
		public string Content
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

		// Token: 0x06006D22 RID: 27938 RVA: 0x0022C11C File Offset: 0x0022A31C
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x0022C12C File Offset: 0x0022A32C
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06006D24 RID: 27940 RVA: 0x0022C144 File Offset: 0x0022A344
		public int CondGroupId
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

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06006D25 RID: 27941 RVA: 0x0022C184 File Offset: 0x0022A384
		public int Type
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

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06006D26 RID: 27942 RVA: 0x0022C1C4 File Offset: 0x0022A3C4
		public string MotionImg
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

		// Token: 0x06006D27 RID: 27943 RVA: 0x0022C1FC File Offset: 0x0022A3FC
		public Span<byte> GetMotionImgBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x0022C20C File Offset: 0x0022A40C
		public byte[] GetMotionImgArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06006D29 RID: 27945 RVA: 0x0022C224 File Offset: 0x0022A424
		public string AniBlueprint
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

		// Token: 0x06006D2A RID: 27946 RVA: 0x0022C25C File Offset: 0x0022A45C
		public Span<byte> GetAniBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x0022C26C File Offset: 0x0022A46C
		public byte[] GetAniBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06006D2C RID: 27948 RVA: 0x0022C284 File Offset: 0x0022A484
		public string AniMontage
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

		// Token: 0x06006D2D RID: 27949 RVA: 0x0022C2BC File Offset: 0x0022A4BC
		public Span<byte> GetAniMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x0022C2CC File Offset: 0x0022A4CC
		public byte[] GetAniMontageArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CAD RID: 19629
		private Table __p;
	}
}
