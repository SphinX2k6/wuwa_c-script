using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB6 RID: 2998
	public struct AdvertisingTabInfo : IFlatbufferObject
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06004ABB RID: 19131 RVA: 0x001F040C File Offset: 0x001EE60C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x001F0419 File Offset: 0x001EE619
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004ABD RID: 19133 RVA: 0x001F0420 File Offset: 0x001EE620
		public static AdvertisingTabInfo GetRootAsAdvertisingTabInfo(ByteBuffer _bb)
		{
			return AdvertisingTabInfo.GetRootAsAdvertisingTabInfo(_bb, default(AdvertisingTabInfo));
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x001F043C File Offset: 0x001EE63C
		public static AdvertisingTabInfo GetRootAsAdvertisingTabInfo(ByteBuffer _bb, AdvertisingTabInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x001F0459 File Offset: 0x001EE659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x001F0468 File Offset: 0x001EE668
		public AdvertisingTabInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06004AC1 RID: 19137 RVA: 0x001F0478 File Offset: 0x001EE678
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

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x001F04B4 File Offset: 0x001EE6B4
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

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x001F04F0 File Offset: 0x001EE6F0
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

		// Token: 0x06004AC4 RID: 19140 RVA: 0x001F0527 File Offset: 0x001EE727
		public Span<byte> GetEntryButtonImageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x001F0536 File Offset: 0x001EE736
		public byte[] GetEntryButtonImageArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06004AC6 RID: 19142 RVA: 0x001F0550 File Offset: 0x001EE750
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

		// Token: 0x06004AC7 RID: 19143 RVA: 0x001F0588 File Offset: 0x001EE788
		public Span<byte> GetEntryButtonTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x001F0598 File Offset: 0x001EE798
		public byte[] GetEntryButtonTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x001F05B0 File Offset: 0x001EE7B0
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

		// Token: 0x06004ACA RID: 19146 RVA: 0x001F05E8 File Offset: 0x001EE7E8
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x001F05F8 File Offset: 0x001EE7F8
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x001F0610 File Offset: 0x001EE810
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

		// Token: 0x06004ACD RID: 19149 RVA: 0x001F0648 File Offset: 0x001EE848
		public Span<byte> GetTabIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x001F0658 File Offset: 0x001EE858
		public byte[] GetTabIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x001F0670 File Offset: 0x001EE870
		public int SubTabIdList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x001F06B0 File Offset: 0x001EE8B0
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

		// Token: 0x06004AD1 RID: 19153 RVA: 0x001F06DC File Offset: 0x001EE8DC
		public Span<int> GetSubTabIdListBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x001F06EC File Offset: 0x001EE8EC
		public int[] GetSubTabIdListArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x001F0704 File Offset: 0x001EE904
		[NullableContext(1)]
		public int[] SubTabIdList()
		{
			return this.GetSubTabIdListArray();
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x001F070C File Offset: 0x001EE90C
		[NullableContext(1)]
		public IEnumerable<int> SubTabIdListIter()
		{
			AdvertisingTabInfo.<SubTabIdListIter>d__34 <SubTabIdListIter>d__ = new AdvertisingTabInfo.<SubTabIdListIter>d__34(-2);
			<SubTabIdListIter>d__.<>3__<>4__this = this;
			return <SubTabIdListIter>d__;
		}

		// Token: 0x04005096 RID: 20630
		private Table __p;
	}
}
