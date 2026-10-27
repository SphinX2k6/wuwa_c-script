using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001000 RID: 4096
	public struct RogueResEventBg : IFlatbufferObject
	{
		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x0600C21D RID: 49693 RVA: 0x002EBD01 File Offset: 0x002E9F01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C21E RID: 49694 RVA: 0x002EBD0E File Offset: 0x002E9F0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C21F RID: 49695 RVA: 0x002EBD18 File Offset: 0x002E9F18
		public static RogueResEventBg GetRootAsRogueResEventBg(ByteBuffer _bb)
		{
			return RogueResEventBg.GetRootAsRogueResEventBg(_bb, default(RogueResEventBg));
		}

		// Token: 0x0600C220 RID: 49696 RVA: 0x002EBD34 File Offset: 0x002E9F34
		public static RogueResEventBg GetRootAsRogueResEventBg(ByteBuffer _bb, RogueResEventBg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C221 RID: 49697 RVA: 0x002EBD51 File Offset: 0x002E9F51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C222 RID: 49698 RVA: 0x002EBD60 File Offset: 0x002E9F60
		public RogueResEventBg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x0600C223 RID: 49699 RVA: 0x002EBD70 File Offset: 0x002E9F70
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

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x0600C224 RID: 49700 RVA: 0x002EBDAC File Offset: 0x002E9FAC
		public string BgName
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

		// Token: 0x0600C225 RID: 49701 RVA: 0x002EBDE3 File Offset: 0x002E9FE3
		public Span<byte> GetBgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C226 RID: 49702 RVA: 0x002EBDF2 File Offset: 0x002E9FF2
		public byte[] GetBgNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x0600C227 RID: 49703 RVA: 0x002EBE0C File Offset: 0x002EA00C
		public string BgPath
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

		// Token: 0x0600C228 RID: 49704 RVA: 0x002EBE43 File Offset: 0x002EA043
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C229 RID: 49705 RVA: 0x002EBE52 File Offset: 0x002EA052
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x0600C22A RID: 49706 RVA: 0x002EBE6C File Offset: 0x002EA06C
		public string BgFemalePath
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

		// Token: 0x0600C22B RID: 49707 RVA: 0x002EBEA4 File Offset: 0x002EA0A4
		public Span<byte> GetBgFemalePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C22C RID: 49708 RVA: 0x002EBEB4 File Offset: 0x002EA0B4
		public byte[] GetBgFemalePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x0600C22D RID: 49709 RVA: 0x002EBECC File Offset: 0x002EA0CC
		public string HandBookBgPath
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

		// Token: 0x0600C22E RID: 49710 RVA: 0x002EBF04 File Offset: 0x002EA104
		public Span<byte> GetHandBookBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C22F RID: 49711 RVA: 0x002EBF14 File Offset: 0x002EA114
		public byte[] GetHandBookBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x0600C230 RID: 49712 RVA: 0x002EBF2C File Offset: 0x002EA12C
		public string HandBookBgFemalePath
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

		// Token: 0x0600C231 RID: 49713 RVA: 0x002EBF64 File Offset: 0x002EA164
		public Span<byte> GetHandBookBgFemalePathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C232 RID: 49714 RVA: 0x002EBF74 File Offset: 0x002EA174
		public byte[] GetHandBookBgFemalePathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x0600C233 RID: 49715 RVA: 0x002EBF8C File Offset: 0x002EA18C
		public string BgSpineAtlasPath
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

		// Token: 0x0600C234 RID: 49716 RVA: 0x002EBFC4 File Offset: 0x002EA1C4
		public Span<byte> GetBgSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C235 RID: 49717 RVA: 0x002EBFD4 File Offset: 0x002EA1D4
		public byte[] GetBgSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x0600C236 RID: 49718 RVA: 0x002EBFEC File Offset: 0x002EA1EC
		public string BgSpineSkeletonPath
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

		// Token: 0x0600C237 RID: 49719 RVA: 0x002EC024 File Offset: 0x002EA224
		public Span<byte> GetBgSpineSkeletonPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C238 RID: 49720 RVA: 0x002EC034 File Offset: 0x002EA234
		public byte[] GetBgSpineSkeletonPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x0600C239 RID: 49721 RVA: 0x002EC04C File Offset: 0x002EA24C
		public string BgSpineAtlasFemalePath
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

		// Token: 0x0600C23A RID: 49722 RVA: 0x002EC084 File Offset: 0x002EA284
		public Span<byte> GetBgSpineAtlasFemalePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C23B RID: 49723 RVA: 0x002EC094 File Offset: 0x002EA294
		public byte[] GetBgSpineAtlasFemalePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x0600C23C RID: 49724 RVA: 0x002EC0AC File Offset: 0x002EA2AC
		public string BgSpineSkeletonFemalePath
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

		// Token: 0x0600C23D RID: 49725 RVA: 0x002EC0E4 File Offset: 0x002EA2E4
		public Span<byte> GetBgSpineSkeletonFemalePathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C23E RID: 49726 RVA: 0x002EC0F4 File Offset: 0x002EA2F4
		public byte[] GetBgSpineSkeletonFemalePathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x040050E8 RID: 20712
		private Table __p;
	}
}
