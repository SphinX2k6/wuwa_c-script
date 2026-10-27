using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6E RID: 2926
	public struct ChatPartner : IFlatbufferObject
	{
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x001F28D5 File Offset: 0x001F0AD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x001F28E2 File Offset: 0x001F0AE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x001F28EC File Offset: 0x001F0AEC
		public static ChatPartner GetRootAsChatPartner(ByteBuffer _bb)
		{
			return ChatPartner.GetRootAsChatPartner(_bb, default(ChatPartner));
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x001F2908 File Offset: 0x001F0B08
		public static ChatPartner GetRootAsChatPartner(ByteBuffer _bb, ChatPartner obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x001F2925 File Offset: 0x001F0B25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x001F2934 File Offset: 0x001F0B34
		public ChatPartner __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060053EE RID: 21486 RVA: 0x001F2944 File Offset: 0x001F0B44
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

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060053EF RID: 21487 RVA: 0x001F2980 File Offset: 0x001F0B80
		public string Icon
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

		// Token: 0x060053F0 RID: 21488 RVA: 0x001F29B7 File Offset: 0x001F0BB7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x001F29C6 File Offset: 0x001F0BC6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060053F2 RID: 21490 RVA: 0x001F29E0 File Offset: 0x001F0BE0
		public string IconMid
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

		// Token: 0x060053F3 RID: 21491 RVA: 0x001F2A17 File Offset: 0x001F0C17
		public Span<byte> GetIconMidBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x001F2A26 File Offset: 0x001F0C26
		public byte[] GetIconMidArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060053F5 RID: 21493 RVA: 0x001F2A40 File Offset: 0x001F0C40
		public string IconSmall
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

		// Token: 0x060053F6 RID: 21494 RVA: 0x001F2A78 File Offset: 0x001F0C78
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x001F2A88 File Offset: 0x001F0C88
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060053F8 RID: 21496 RVA: 0x001F2AA0 File Offset: 0x001F0CA0
		public string Name
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

		// Token: 0x060053F9 RID: 21497 RVA: 0x001F2AD8 File Offset: 0x001F0CD8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x001F2AE8 File Offset: 0x001F0CE8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060053FB RID: 21499 RVA: 0x001F2B00 File Offset: 0x001F0D00
		public bool IsGroupChat
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x001F2B40 File Offset: 0x001F0D40
		public string Desc
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

		// Token: 0x060053FD RID: 21501 RVA: 0x001F2B78 File Offset: 0x001F0D78
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060053FE RID: 21502 RVA: 0x001F2B88 File Offset: 0x001F0D88
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060053FF RID: 21503 RVA: 0x001F2BA0 File Offset: 0x001F0DA0
		public int PeopleNum
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x001F2BE0 File Offset: 0x001F0DE0
		public int TypeFilter
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1001;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x001F2C24 File Offset: 0x001F0E24
		public int RegionFilterList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x001F2C64 File Offset: 0x001F0E64
		public int RegionFilterListLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x001F2C90 File Offset: 0x001F0E90
		public Span<int> GetRegionFilterListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x001F2CA0 File Offset: 0x001F0EA0
		public int[] GetRegionFilterListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x001F2CB8 File Offset: 0x001F0EB8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RegionFilterListIter()或GetRegionFilterListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RegionFilterList()
		{
			ChatPartner chatPartner = this;
			return chatPartner.GetRegionFilterListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x001F2CDC File Offset: 0x001F0EDC
		[NullableContext(1)]
		public readonly IEnumerable<int> RegionFilterListIter()
		{
			ChatPartner.<RegionFilterListIter>d__42 <RegionFilterListIter>d__ = new ChatPartner.<RegionFilterListIter>d__42(-2);
			<RegionFilterListIter>d__.<>3__<>4__this = this;
			return <RegionFilterListIter>d__;
		}

		// Token: 0x04004B70 RID: 19312
		private Table __p;
	}
}
