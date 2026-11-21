using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200125A RID: 4698
	public struct TetrisGem : IFlatbufferObject
	{
		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x0600EB61 RID: 60257 RVA: 0x003574E8 File Offset: 0x003556E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB62 RID: 60258 RVA: 0x003574F5 File Offset: 0x003556F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB63 RID: 60259 RVA: 0x003574FC File Offset: 0x003556FC
		public static TetrisGem GetRootAsTetrisGem(ByteBuffer _bb)
		{
			return TetrisGem.GetRootAsTetrisGem(_bb, default(TetrisGem));
		}

		// Token: 0x0600EB64 RID: 60260 RVA: 0x00357518 File Offset: 0x00355718
		public static TetrisGem GetRootAsTetrisGem(ByteBuffer _bb, TetrisGem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB65 RID: 60261 RVA: 0x00357535 File Offset: 0x00355735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB66 RID: 60262 RVA: 0x00357544 File Offset: 0x00355744
		public TetrisGem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x0600EB67 RID: 60263 RVA: 0x00357554 File Offset: 0x00355754
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

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x0600EB68 RID: 60264 RVA: 0x00357590 File Offset: 0x00355790
		public string BgPath
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

		// Token: 0x0600EB69 RID: 60265 RVA: 0x003575C7 File Offset: 0x003557C7
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EB6A RID: 60266 RVA: 0x003575D6 File Offset: 0x003557D6
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x0600EB6B RID: 60267 RVA: 0x003575F0 File Offset: 0x003557F0
		public string FramePath
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

		// Token: 0x0600EB6C RID: 60268 RVA: 0x00357627 File Offset: 0x00355827
		public Span<byte> GetFramePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EB6D RID: 60269 RVA: 0x00357636 File Offset: 0x00355836
		public byte[] GetFramePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D8A RID: 15754
		// (get) Token: 0x0600EB6E RID: 60270 RVA: 0x00357650 File Offset: 0x00355850
		public string GemPath
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

		// Token: 0x0600EB6F RID: 60271 RVA: 0x00357688 File Offset: 0x00355888
		public Span<byte> GetGemPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EB70 RID: 60272 RVA: 0x00357698 File Offset: 0x00355898
		public byte[] GetGemPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x0600EB71 RID: 60273 RVA: 0x003576B0 File Offset: 0x003558B0
		public string IconPath
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

		// Token: 0x0600EB72 RID: 60274 RVA: 0x003576E8 File Offset: 0x003558E8
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600EB73 RID: 60275 RVA: 0x003576F8 File Offset: 0x003558F8
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x0600EB74 RID: 60276 RVA: 0x00357710 File Offset: 0x00355910
		public string TargetIconPath
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

		// Token: 0x0600EB75 RID: 60277 RVA: 0x00357748 File Offset: 0x00355948
		public Span<byte> GetTargetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600EB76 RID: 60278 RVA: 0x00357758 File Offset: 0x00355958
		public byte[] GetTargetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x0600EB77 RID: 60279 RVA: 0x00357770 File Offset: 0x00355970
		public string TargetBgPath
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

		// Token: 0x0600EB78 RID: 60280 RVA: 0x003577A8 File Offset: 0x003559A8
		public Span<byte> GetTargetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600EB79 RID: 60281 RVA: 0x003577B8 File Offset: 0x003559B8
		public byte[] GetTargetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x0600EB7A RID: 60282 RVA: 0x003577D0 File Offset: 0x003559D0
		public string TargetTextureBgPath
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

		// Token: 0x0600EB7B RID: 60283 RVA: 0x00357808 File Offset: 0x00355A08
		public Span<byte> GetTargetTextureBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600EB7C RID: 60284 RVA: 0x00357818 File Offset: 0x00355A18
		public byte[] GetTargetTextureBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x0600EB7D RID: 60285 RVA: 0x00357830 File Offset: 0x00355A30
		public string ColorValue
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

		// Token: 0x0600EB7E RID: 60286 RVA: 0x00357868 File Offset: 0x00355A68
		public Span<byte> GetColorValueBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600EB7F RID: 60287 RVA: 0x00357878 File Offset: 0x00355A78
		public byte[] GetColorValueArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x0600EB80 RID: 60288 RVA: 0x00357890 File Offset: 0x00355A90
		public string NiaGlowColorValue
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

		// Token: 0x0600EB81 RID: 60289 RVA: 0x003578C8 File Offset: 0x00355AC8
		public Span<byte> GetNiaGlowColorValueBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600EB82 RID: 60290 RVA: 0x003578D8 File Offset: 0x00355AD8
		public byte[] GetNiaGlowColorValueArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x0600EB83 RID: 60291 RVA: 0x003578F0 File Offset: 0x00355AF0
		public string NiaGlowSweepColorValue
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

		// Token: 0x0600EB84 RID: 60292 RVA: 0x00357928 File Offset: 0x00355B28
		public Span<byte> GetNiaGlowSweepColorValueBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600EB85 RID: 60293 RVA: 0x00357938 File Offset: 0x00355B38
		public byte[] GetNiaGlowSweepColorValueArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x0600EB86 RID: 60294 RVA: 0x00357950 File Offset: 0x00355B50
		public string OneSealPath
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB87 RID: 60295 RVA: 0x00357988 File Offset: 0x00355B88
		public Span<byte> GetOneSealPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600EB88 RID: 60296 RVA: 0x00357998 File Offset: 0x00355B98
		public byte[] GetOneSealPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x0600EB89 RID: 60297 RVA: 0x003579B0 File Offset: 0x00355BB0
		public string TwoSealPath
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

		// Token: 0x0600EB8A RID: 60298 RVA: 0x003579E8 File Offset: 0x00355BE8
		public Span<byte> GetTwoSealPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600EB8B RID: 60299 RVA: 0x003579F8 File Offset: 0x00355BF8
		public byte[] GetTwoSealPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x0600EB8C RID: 60300 RVA: 0x00357A10 File Offset: 0x00355C10
		public string BombBgPath
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

		// Token: 0x0600EB8D RID: 60301 RVA: 0x00357A48 File Offset: 0x00355C48
		public Span<byte> GetBombBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600EB8E RID: 60302 RVA: 0x00357A58 File Offset: 0x00355C58
		public byte[] GetBombBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x0600EB8F RID: 60303 RVA: 0x00357A70 File Offset: 0x00355C70
		public string BombLargeIconPath
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

		// Token: 0x0600EB90 RID: 60304 RVA: 0x00357AA8 File Offset: 0x00355CA8
		public Span<byte> GetBombLargeIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600EB91 RID: 60305 RVA: 0x00357AB8 File Offset: 0x00355CB8
		public byte[] GetBombLargeIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x0600EB92 RID: 60306 RVA: 0x00357AD0 File Offset: 0x00355CD0
		public string BombSmallIconPath
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB93 RID: 60307 RVA: 0x00357B08 File Offset: 0x00355D08
		public Span<byte> GetBombSmallIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600EB94 RID: 60308 RVA: 0x00357B18 File Offset: 0x00355D18
		public byte[] GetBombSmallIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x0600EB95 RID: 60309 RVA: 0x00357B30 File Offset: 0x00355D30
		public string SuperBombBgPath
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB96 RID: 60310 RVA: 0x00357B68 File Offset: 0x00355D68
		public Span<byte> GetSuperBombBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600EB97 RID: 60311 RVA: 0x00357B78 File Offset: 0x00355D78
		public byte[] GetSuperBombBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x0600EB98 RID: 60312 RVA: 0x00357B90 File Offset: 0x00355D90
		public string SuperBombLargeIconPath
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB99 RID: 60313 RVA: 0x00357BC8 File Offset: 0x00355DC8
		public Span<byte> GetSuperBombLargeIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600EB9A RID: 60314 RVA: 0x00357BD8 File Offset: 0x00355DD8
		public byte[] GetSuperBombLargeIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x0600EB9B RID: 60315 RVA: 0x00357BF0 File Offset: 0x00355DF0
		public string SuperBombSmallIconPath
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB9C RID: 60316 RVA: 0x00357C28 File Offset: 0x00355E28
		public Span<byte> GetSuperBombSmallIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600EB9D RID: 60317 RVA: 0x00357C38 File Offset: 0x00355E38
		public byte[] GetSuperBombSmallIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x0600EB9E RID: 60318 RVA: 0x00357C50 File Offset: 0x00355E50
		public string BombDecorationColorValue
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB9F RID: 60319 RVA: 0x00357C88 File Offset: 0x00355E88
		public Span<byte> GetBombDecorationColorValueBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600EBA0 RID: 60320 RVA: 0x00357C98 File Offset: 0x00355E98
		public byte[] GetBombDecorationColorValueArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x0600EBA1 RID: 60321 RVA: 0x00357CB0 File Offset: 0x00355EB0
		public string BombDecorationChargeColorValue
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EBA2 RID: 60322 RVA: 0x00357CE8 File Offset: 0x00355EE8
		public Span<byte> GetBombDecorationChargeColorValueBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600EBA3 RID: 60323 RVA: 0x00357CF8 File Offset: 0x00355EF8
		public byte[] GetBombDecorationChargeColorValueArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x040058A5 RID: 22693
		private Table __p;
	}
}
