using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADC RID: 2780
	public struct AdvertisingTabInfo : IFlatbufferObject
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x001D0958 File Offset: 0x001CEB58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x001D0965 File Offset: 0x001CEB65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x001D096C File Offset: 0x001CEB6C
		public static AdvertisingTabInfo GetRootAsAdvertisingTabInfo(ByteBuffer _bb)
		{
			return AdvertisingTabInfo.GetRootAsAdvertisingTabInfo(_bb, default(AdvertisingTabInfo));
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x001D0988 File Offset: 0x001CEB88
		public static AdvertisingTabInfo GetRootAsAdvertisingTabInfo(ByteBuffer _bb, AdvertisingTabInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x001D09A5 File Offset: 0x001CEBA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x001D09B4 File Offset: 0x001CEBB4
		public AdvertisingTabInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x001D09C4 File Offset: 0x001CEBC4
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

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x001D0A00 File Offset: 0x001CEC00
		public int Type
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

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x001D0A3C File Offset: 0x001CEC3C
		public string EntryButtonImage
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

		// Token: 0x0600457D RID: 17789 RVA: 0x001D0A73 File Offset: 0x001CEC73
		public Span<byte> GetEntryButtonImageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x001D0A82 File Offset: 0x001CEC82
		public byte[] GetEntryButtonImageArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x001D0A9C File Offset: 0x001CEC9C
		public string EntryButtonText
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

		// Token: 0x06004580 RID: 17792 RVA: 0x001D0AD4 File Offset: 0x001CECD4
		public Span<byte> GetEntryButtonTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x001D0AE4 File Offset: 0x001CECE4
		public byte[] GetEntryButtonTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06004582 RID: 17794 RVA: 0x001D0AFC File Offset: 0x001CECFC
		public string TabTitle
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

		// Token: 0x06004583 RID: 17795 RVA: 0x001D0B34 File Offset: 0x001CED34
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x001D0B44 File Offset: 0x001CED44
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06004585 RID: 17797 RVA: 0x001D0B5C File Offset: 0x001CED5C
		public string TabIcon
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

		// Token: 0x06004586 RID: 17798 RVA: 0x001D0B94 File Offset: 0x001CED94
		public Span<byte> GetTabIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x001D0BA4 File Offset: 0x001CEDA4
		public byte[] GetTabIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x001D0BBC File Offset: 0x001CEDBC
		public int SubTabIdList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06004589 RID: 17801 RVA: 0x001D0BFC File Offset: 0x001CEDFC
		public int SubTabIdListLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x001D0C28 File Offset: 0x001CEE28
		public Span<int> GetSubTabIdListBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x001D0C38 File Offset: 0x001CEE38
		public int[] GetSubTabIdListArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x001D0C50 File Offset: 0x001CEE50
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubTabIdListIter()或GetSubTabIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SubTabIdList()
		{
			AdvertisingTabInfo advertisingTabInfo = this;
			return advertisingTabInfo.GetSubTabIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x001D0C74 File Offset: 0x001CEE74
		[NullableContext(1)]
		public readonly IEnumerable<int> SubTabIdListIter()
		{
			AdvertisingTabInfo.<SubTabIdListIter>d__34 <SubTabIdListIter>d__ = new AdvertisingTabInfo.<SubTabIdListIter>d__34(-2);
			<SubTabIdListIter>d__.<>3__<>4__this = this;
			return <SubTabIdListIter>d__;
		}

		// Token: 0x04004ABC RID: 19132
		private Table __p;
	}
}
