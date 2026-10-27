using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B68 RID: 2920
	public struct ChatBg : IFlatbufferObject
	{
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600530F RID: 21263 RVA: 0x001F0DC5 File Offset: 0x001EEFC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x001F0DD2 File Offset: 0x001EEFD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x001F0DDC File Offset: 0x001EEFDC
		public static ChatBg GetRootAsChatBg(ByteBuffer _bb)
		{
			return ChatBg.GetRootAsChatBg(_bb, default(ChatBg));
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x001F0DF8 File Offset: 0x001EEFF8
		public static ChatBg GetRootAsChatBg(ByteBuffer _bb, ChatBg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x001F0E15 File Offset: 0x001EF015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x001F0E24 File Offset: 0x001EF024
		public ChatBg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06005315 RID: 21269 RVA: 0x001F0E34 File Offset: 0x001EF034
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

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06005316 RID: 21270 RVA: 0x001F0E70 File Offset: 0x001EF070
		public string ChatBgPathSmall
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

		// Token: 0x06005317 RID: 21271 RVA: 0x001F0EA7 File Offset: 0x001EF0A7
		public Span<byte> GetChatBgPathSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x001F0EB6 File Offset: 0x001EF0B6
		public byte[] GetChatBgPathSmallArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x001F0ED0 File Offset: 0x001EF0D0
		public string ChatBgPathBig
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

		// Token: 0x0600531A RID: 21274 RVA: 0x001F0F07 File Offset: 0x001EF107
		public Span<byte> GetChatBgPathBigBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x001F0F16 File Offset: 0x001EF116
		public byte[] GetChatBgPathBigArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x0600531C RID: 21276 RVA: 0x001F0F30 File Offset: 0x001EF130
		public string ScrollViewBgPath
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

		// Token: 0x0600531D RID: 21277 RVA: 0x001F0F68 File Offset: 0x001EF168
		public Span<byte> GetScrollViewBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600531E RID: 21278 RVA: 0x001F0F78 File Offset: 0x001EF178
		public byte[] GetScrollViewBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600531F RID: 21279 RVA: 0x001F0F90 File Offset: 0x001EF190
		public string ReviewBgPath
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

		// Token: 0x06005320 RID: 21280 RVA: 0x001F0FC8 File Offset: 0x001EF1C8
		public Span<byte> GetReviewBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x001F0FD8 File Offset: 0x001EF1D8
		public byte[] GetReviewBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x001F0FF0 File Offset: 0x001EF1F0
		public string SmallViewBgPath
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

		// Token: 0x06005323 RID: 21283 RVA: 0x001F1028 File Offset: 0x001EF228
		public Span<byte> GetSmallViewBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x001F1038 File Offset: 0x001EF238
		public byte[] GetSmallViewBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06005325 RID: 21285 RVA: 0x001F1050 File Offset: 0x001EF250
		public string BgPath
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

		// Token: 0x06005326 RID: 21286 RVA: 0x001F1088 File Offset: 0x001EF288
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x001F1098 File Offset: 0x001EF298
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x001F10B0 File Offset: 0x001EF2B0
		public string Name
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

		// Token: 0x06005329 RID: 21289 RVA: 0x001F10E8 File Offset: 0x001EF2E8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600532A RID: 21290 RVA: 0x001F10F8 File Offset: 0x001EF2F8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600532B RID: 21291 RVA: 0x001F1110 File Offset: 0x001EF310
		public string Desc
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

		// Token: 0x0600532C RID: 21292 RVA: 0x001F1148 File Offset: 0x001EF348
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x001F1158 File Offset: 0x001EF358
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600532E RID: 21294 RVA: 0x001F1170 File Offset: 0x001EF370
		public string GetWay
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

		// Token: 0x0600532F RID: 21295 RVA: 0x001F11A8 File Offset: 0x001EF3A8
		public Span<byte> GetGetWayBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x001F11B8 File Offset: 0x001EF3B8
		public byte[] GetGetWayArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06005331 RID: 21297 RVA: 0x001F11D0 File Offset: 0x001EF3D0
		public string Icon
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

		// Token: 0x06005332 RID: 21298 RVA: 0x001F1208 File Offset: 0x001EF408
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x001F1218 File Offset: 0x001EF418
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06005334 RID: 21300 RVA: 0x001F1230 File Offset: 0x001EF430
		public string IconMiddle
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

		// Token: 0x06005335 RID: 21301 RVA: 0x001F1268 File Offset: 0x001EF468
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x001F1278 File Offset: 0x001EF478
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06005337 RID: 21303 RVA: 0x001F1290 File Offset: 0x001EF490
		public string IconSmall
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

		// Token: 0x06005338 RID: 21304 RVA: 0x001F12C8 File Offset: 0x001EF4C8
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005339 RID: 21305 RVA: 0x001F12D8 File Offset: 0x001EF4D8
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600533A RID: 21306 RVA: 0x001F12F0 File Offset: 0x001EF4F0
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

		// Token: 0x0600533B RID: 21307 RVA: 0x001F1328 File Offset: 0x001EF528
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x001F1338 File Offset: 0x001EF538
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600533D RID: 21309 RVA: 0x001F1350 File Offset: 0x001EF550
		public string AttributesDescription
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

		// Token: 0x0600533E RID: 21310 RVA: 0x001F1388 File Offset: 0x001EF588
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x001F1398 File Offset: 0x001EF598
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06005340 RID: 21312 RVA: 0x001F13B0 File Offset: 0x001EF5B0
		public string BgDescription
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

		// Token: 0x06005341 RID: 21313 RVA: 0x001F13E8 File Offset: 0x001EF5E8
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x001F13F8 File Offset: 0x001EF5F8
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x001F1410 File Offset: 0x001EF610
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06005344 RID: 21316 RVA: 0x001F1450 File Offset: 0x001EF650
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x001F147C File Offset: 0x001EF67C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x001F148C File Offset: 0x001EF68C
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06005347 RID: 21319 RVA: 0x001F14A4 File Offset: 0x001EF6A4
		public int QualityId
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

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x001F14E4 File Offset: 0x001EF6E4
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x001F1524 File Offset: 0x001EF724
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			ChatBg chatBg = this;
			return chatBg.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x001F1548 File Offset: 0x001EF748
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			ChatBg.<ItemAccessIter>d__80 <ItemAccessIter>d__ = new ChatBg.<ItemAccessIter>d__80(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x04004B6A RID: 19306
		private Table __p;
	}
}
