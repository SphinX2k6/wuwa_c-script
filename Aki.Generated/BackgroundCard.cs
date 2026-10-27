using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B25 RID: 2853
	public struct BackgroundCard : IFlatbufferObject
	{
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x001DE548 File Offset: 0x001DC748
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x001DE555 File Offset: 0x001DC755
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x001DE55C File Offset: 0x001DC75C
		public static BackgroundCard GetRootAsBackgroundCard(ByteBuffer _bb)
		{
			return BackgroundCard.GetRootAsBackgroundCard(_bb, default(BackgroundCard));
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x001DE578 File Offset: 0x001DC778
		public static BackgroundCard GetRootAsBackgroundCard(ByteBuffer _bb, BackgroundCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x001DE595 File Offset: 0x001DC795
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x001DE5A4 File Offset: 0x001DC7A4
		public BackgroundCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06004B6C RID: 19308 RVA: 0x001DE5B4 File Offset: 0x001DC7B4
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

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06004B6D RID: 19309 RVA: 0x001DE5F0 File Offset: 0x001DC7F0
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x001DE62C File Offset: 0x001DC82C
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06004B6F RID: 19311 RVA: 0x001DE66C File Offset: 0x001DC86C
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x001DE697 File Offset: 0x001DC897
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x001DE6A6 File Offset: 0x001DC8A6
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06004B72 RID: 19314 RVA: 0x001DE6C0 File Offset: 0x001DC8C0
		public int SortIndex
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

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06004B73 RID: 19315 RVA: 0x001DE700 File Offset: 0x001DC900
		public string LongCardPath
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

		// Token: 0x06004B74 RID: 19316 RVA: 0x001DE738 File Offset: 0x001DC938
		public Span<byte> GetLongCardPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x001DE748 File Offset: 0x001DC948
		public byte[] GetLongCardPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06004B76 RID: 19318 RVA: 0x001DE760 File Offset: 0x001DC960
		public string CardPath
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

		// Token: 0x06004B77 RID: 19319 RVA: 0x001DE798 File Offset: 0x001DC998
		public Span<byte> GetCardPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x001DE7A8 File Offset: 0x001DC9A8
		public byte[] GetCardPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06004B79 RID: 19321 RVA: 0x001DE7C0 File Offset: 0x001DC9C0
		public string FunctionViewCardPath
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

		// Token: 0x06004B7A RID: 19322 RVA: 0x001DE7F8 File Offset: 0x001DC9F8
		public Span<byte> GetFunctionViewCardPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x001DE808 File Offset: 0x001DCA08
		public byte[] GetFunctionViewCardPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06004B7C RID: 19324 RVA: 0x001DE820 File Offset: 0x001DCA20
		public string Icon
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

		// Token: 0x06004B7D RID: 19325 RVA: 0x001DE858 File Offset: 0x001DCA58
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x001DE868 File Offset: 0x001DCA68
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06004B7F RID: 19327 RVA: 0x001DE880 File Offset: 0x001DCA80
		public string IconMiddle
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

		// Token: 0x06004B80 RID: 19328 RVA: 0x001DE8B8 File Offset: 0x001DCAB8
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x001DE8C8 File Offset: 0x001DCAC8
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x001DE8E0 File Offset: 0x001DCAE0
		public string IconSmall
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

		// Token: 0x06004B83 RID: 19331 RVA: 0x001DE918 File Offset: 0x001DCB18
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x001DE928 File Offset: 0x001DCB28
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06004B85 RID: 19333 RVA: 0x001DE940 File Offset: 0x001DCB40
		public string Title
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

		// Token: 0x06004B86 RID: 19334 RVA: 0x001DE978 File Offset: 0x001DCB78
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x001DE988 File Offset: 0x001DCB88
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06004B88 RID: 19336 RVA: 0x001DE9A0 File Offset: 0x001DCBA0
		public string AttributesDescription
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

		// Token: 0x06004B89 RID: 19337 RVA: 0x001DE9D8 File Offset: 0x001DCBD8
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x001DE9E8 File Offset: 0x001DCBE8
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06004B8B RID: 19339 RVA: 0x001DEA00 File Offset: 0x001DCC00
		public string ObtainedShowDescription
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

		// Token: 0x06004B8C RID: 19340 RVA: 0x001DEA38 File Offset: 0x001DCC38
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x001DEA48 File Offset: 0x001DCC48
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06004B8E RID: 19342 RVA: 0x001DEA60 File Offset: 0x001DCC60
		public string TypeDescription
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

		// Token: 0x06004B8F RID: 19343 RVA: 0x001DEA98 File Offset: 0x001DCC98
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x001DEAA8 File Offset: 0x001DCCA8
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06004B91 RID: 19345 RVA: 0x001DEAC0 File Offset: 0x001DCCC0
		public string BgDescription
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

		// Token: 0x06004B92 RID: 19346 RVA: 0x001DEAF8 File Offset: 0x001DCCF8
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x001DEB08 File Offset: 0x001DCD08
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06004B94 RID: 19348 RVA: 0x001DEB20 File Offset: 0x001DCD20
		public string Tips
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

		// Token: 0x06004B95 RID: 19349 RVA: 0x001DEB58 File Offset: 0x001DCD58
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x001DEB68 File Offset: 0x001DCD68
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06004B97 RID: 19351 RVA: 0x001DEB80 File Offset: 0x001DCD80
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06004B98 RID: 19352 RVA: 0x001DEBC0 File Offset: 0x001DCDC0
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06004B99 RID: 19353 RVA: 0x001DEC00 File Offset: 0x001DCE00
		public string FunctionSpineAtlasPath
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

		// Token: 0x06004B9A RID: 19354 RVA: 0x001DEC38 File Offset: 0x001DCE38
		public Span<byte> GetFunctionSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x001DEC48 File Offset: 0x001DCE48
		public byte[] GetFunctionSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06004B9C RID: 19356 RVA: 0x001DEC60 File Offset: 0x001DCE60
		public string FunctionSpineDataPath
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

		// Token: 0x06004B9D RID: 19357 RVA: 0x001DEC98 File Offset: 0x001DCE98
		public Span<byte> GetFunctionSpineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x001DECA8 File Offset: 0x001DCEA8
		public byte[] GetFunctionSpineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06004B9F RID: 19359 RVA: 0x001DECC0 File Offset: 0x001DCEC0
		public string LongSpineAtlasPath
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

		// Token: 0x06004BA0 RID: 19360 RVA: 0x001DECF8 File Offset: 0x001DCEF8
		public Span<byte> GetLongSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06004BA1 RID: 19361 RVA: 0x001DED08 File Offset: 0x001DCF08
		public byte[] GetLongSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06004BA2 RID: 19362 RVA: 0x001DED20 File Offset: 0x001DCF20
		public string LongSpineDataPath
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x001DED58 File Offset: 0x001DCF58
		public Span<byte> GetLongSpineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x001DED68 File Offset: 0x001DCF68
		public byte[] GetLongSpineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x001DED80 File Offset: 0x001DCF80
		public string NormalSpineAtlasPath
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004BA6 RID: 19366 RVA: 0x001DEDB8 File Offset: 0x001DCFB8
		public Span<byte> GetNormalSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x001DEDC8 File Offset: 0x001DCFC8
		public byte[] GetNormalSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06004BA8 RID: 19368 RVA: 0x001DEDE0 File Offset: 0x001DCFE0
		public string NormalSpineDataPath
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x001DEE18 File Offset: 0x001DD018
		public Span<byte> GetNormalSpineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x001DEE28 File Offset: 0x001DD028
		public byte[] GetNormalSpineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x001DEE40 File Offset: 0x001DD040
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			BackgroundCard backgroundCard = this;
			return backgroundCard.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x001DEE64 File Offset: 0x001DD064
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			BackgroundCard.<ItemAccessIter>d__96 <ItemAccessIter>d__ = new BackgroundCard.<ItemAccessIter>d__96(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x04004B17 RID: 19223
		private Table __p;
	}
}
