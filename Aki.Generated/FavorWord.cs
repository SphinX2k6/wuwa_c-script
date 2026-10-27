using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C64 RID: 3172
	public struct FavorWord : IFlatbufferObject
	{
		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06006D39 RID: 27961 RVA: 0x0022C3E9 File Offset: 0x0022A5E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D3A RID: 27962 RVA: 0x0022C3F6 File Offset: 0x0022A5F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x0022C400 File Offset: 0x0022A600
		public static FavorWord GetRootAsFavorWord(ByteBuffer _bb)
		{
			return FavorWord.GetRootAsFavorWord(_bb, default(FavorWord));
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x0022C41C File Offset: 0x0022A61C
		public static FavorWord GetRootAsFavorWord(ByteBuffer _bb, FavorWord obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x0022C439 File Offset: 0x0022A639
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x0022C448 File Offset: 0x0022A648
		public FavorWord __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06006D3F RID: 27967 RVA: 0x0022C458 File Offset: 0x0022A658
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

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06006D40 RID: 27968 RVA: 0x0022C494 File Offset: 0x0022A694
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

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06006D41 RID: 27969 RVA: 0x0022C4D0 File Offset: 0x0022A6D0
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

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06006D42 RID: 27970 RVA: 0x0022C50C File Offset: 0x0022A70C
		public int Sort
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

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06006D43 RID: 27971 RVA: 0x0022C54C File Offset: 0x0022A74C
		public string Title
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

		// Token: 0x06006D44 RID: 27972 RVA: 0x0022C584 File Offset: 0x0022A784
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x0022C594 File Offset: 0x0022A794
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06006D46 RID: 27974 RVA: 0x0022C5AC File Offset: 0x0022A7AC
		public string Content
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

		// Token: 0x06006D47 RID: 27975 RVA: 0x0022C5E4 File Offset: 0x0022A7E4
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x0022C5F4 File Offset: 0x0022A7F4
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06006D49 RID: 27977 RVA: 0x0022C60C File Offset: 0x0022A80C
		public string Voice
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

		// Token: 0x06006D4A RID: 27978 RVA: 0x0022C644 File Offset: 0x0022A844
		public Span<byte> GetVoiceBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x0022C654 File Offset: 0x0022A854
		public byte[] GetVoiceArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06006D4C RID: 27980 RVA: 0x0022C66C File Offset: 0x0022A86C
		public string CVCn
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

		// Token: 0x06006D4D RID: 27981 RVA: 0x0022C6A4 File Offset: 0x0022A8A4
		public Span<byte> GetCVCnBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006D4E RID: 27982 RVA: 0x0022C6B4 File Offset: 0x0022A8B4
		public byte[] GetCVCnArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06006D4F RID: 27983 RVA: 0x0022C6CC File Offset: 0x0022A8CC
		public string CVJp
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

		// Token: 0x06006D50 RID: 27984 RVA: 0x0022C704 File Offset: 0x0022A904
		public Span<byte> GetCVJpBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x0022C714 File Offset: 0x0022A914
		public byte[] GetCVJpArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06006D52 RID: 27986 RVA: 0x0022C72C File Offset: 0x0022A92C
		public string CVEn
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

		// Token: 0x06006D53 RID: 27987 RVA: 0x0022C764 File Offset: 0x0022A964
		public Span<byte> GetCVEnBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x0022C774 File Offset: 0x0022A974
		public byte[] GetCVEnArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06006D55 RID: 27989 RVA: 0x0022C78C File Offset: 0x0022A98C
		public string CVKo
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

		// Token: 0x06006D56 RID: 27990 RVA: 0x0022C7C4 File Offset: 0x0022A9C4
		public Span<byte> GetCVKoBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x0022C7D4 File Offset: 0x0022A9D4
		public byte[] GetCVKoArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06006D58 RID: 27992 RVA: 0x0022C7EC File Offset: 0x0022A9EC
		public int CondGroupId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06006D59 RID: 27993 RVA: 0x0022C82C File Offset: 0x0022AA2C
		public string MotionImg
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x0022C864 File Offset: 0x0022AA64
		public Span<byte> GetMotionImgBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x0022C874 File Offset: 0x0022AA74
		public byte[] GetMotionImgArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06006D5C RID: 27996 RVA: 0x0022C88C File Offset: 0x0022AA8C
		public string AniBlueprint
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x0022C8C4 File Offset: 0x0022AAC4
		public Span<byte> GetAniBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x0022C8D4 File Offset: 0x0022AAD4
		public byte[] GetAniBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06006D5F RID: 27999 RVA: 0x0022C8EC File Offset: 0x0022AAEC
		public string AniMontage
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x0022C924 File Offset: 0x0022AB24
		public Span<byte> GetAniMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x0022C934 File Offset: 0x0022AB34
		public byte[] GetAniMontageArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06006D62 RID: 28002 RVA: 0x0022C94C File Offset: 0x0022AB4C
		public int Morph
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004CAF RID: 19631
		private Table __p;
	}
}
