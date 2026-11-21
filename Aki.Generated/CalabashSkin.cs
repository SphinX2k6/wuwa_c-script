using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3F RID: 3135
	public struct CalabashSkin : IFlatbufferObject
	{
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060057E6 RID: 22502 RVA: 0x0020E9A5 File Offset: 0x0020CBA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x0020E9B2 File Offset: 0x0020CBB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x0020E9BC File Offset: 0x0020CBBC
		public static CalabashSkin GetRootAsCalabashSkin(ByteBuffer _bb)
		{
			return CalabashSkin.GetRootAsCalabashSkin(_bb, default(CalabashSkin));
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x0020E9D8 File Offset: 0x0020CBD8
		public static CalabashSkin GetRootAsCalabashSkin(ByteBuffer _bb, CalabashSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x0020E9F5 File Offset: 0x0020CBF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x0020EA04 File Offset: 0x0020CC04
		public CalabashSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060057EC RID: 22508 RVA: 0x0020EA14 File Offset: 0x0020CC14
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

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060057ED RID: 22509 RVA: 0x0020EA50 File Offset: 0x0020CC50
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060057EE RID: 22510 RVA: 0x0020EA90 File Offset: 0x0020CC90
		public int ItemType
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

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060057EF RID: 22511 RVA: 0x0020EACC File Offset: 0x0020CCCC
		public string Name
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

		// Token: 0x060057F0 RID: 22512 RVA: 0x0020EB04 File Offset: 0x0020CD04
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x0020EB14 File Offset: 0x0020CD14
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060057F2 RID: 22514 RVA: 0x0020EB2C File Offset: 0x0020CD2C
		public string Icon
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

		// Token: 0x060057F3 RID: 22515 RVA: 0x0020EB64 File Offset: 0x0020CD64
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x0020EB74 File Offset: 0x0020CD74
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060057F5 RID: 22517 RVA: 0x0020EB8C File Offset: 0x0020CD8C
		public string IconMiddle
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

		// Token: 0x060057F6 RID: 22518 RVA: 0x0020EBC4 File Offset: 0x0020CDC4
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x0020EBD4 File Offset: 0x0020CDD4
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060057F8 RID: 22520 RVA: 0x0020EBEC File Offset: 0x0020CDEC
		public string IconSmall
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

		// Token: 0x060057F9 RID: 22521 RVA: 0x0020EC24 File Offset: 0x0020CE24
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x0020EC34 File Offset: 0x0020CE34
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060057FB RID: 22523 RVA: 0x0020EC4C File Offset: 0x0020CE4C
		public string TypeDescription
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

		// Token: 0x060057FC RID: 22524 RVA: 0x0020EC84 File Offset: 0x0020CE84
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x0020EC94 File Offset: 0x0020CE94
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060057FE RID: 22526 RVA: 0x0020ECAC File Offset: 0x0020CEAC
		public string BgDescription
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

		// Token: 0x060057FF RID: 22527 RVA: 0x0020ECE4 File Offset: 0x0020CEE4
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x0020ECF4 File Offset: 0x0020CEF4
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06005801 RID: 22529 RVA: 0x0020ED0C File Offset: 0x0020CF0C
		public string AttributesDescription
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

		// Token: 0x06005802 RID: 22530 RVA: 0x0020ED44 File Offset: 0x0020CF44
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x0020ED54 File Offset: 0x0020CF54
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06005804 RID: 22532 RVA: 0x0020ED6C File Offset: 0x0020CF6C
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06005805 RID: 22533 RVA: 0x0020EDAC File Offset: 0x0020CFAC
		public int MainTypeId
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

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x0020EDEC File Offset: 0x0020CFEC
		public bool ShowUseButton
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06005807 RID: 22535 RVA: 0x0020EE2C File Offset: 0x0020D02C
		public int ModelId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06005808 RID: 22536 RVA: 0x0020EE6C File Offset: 0x0020D06C
		public int TransformId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06005809 RID: 22537 RVA: 0x0020EEAC File Offset: 0x0020D0AC
		public string SwitchEffect
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

		// Token: 0x0600580A RID: 22538 RVA: 0x0020EEE4 File Offset: 0x0020D0E4
		public Span<byte> GetSwitchEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x0020EEF4 File Offset: 0x0020D0F4
		public byte[] GetSwitchEffectArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600580C RID: 22540 RVA: 0x0020EF0C File Offset: 0x0020D10C
		public bool ShowWhenLocked
		{
			get
			{
				int num = this.__p.__offset(36);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600580D RID: 22541 RVA: 0x0020EF4C File Offset: 0x0020D14C
		public int SortIndex
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

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600580E RID: 22542 RVA: 0x0020EF8C File Offset: 0x0020D18C
		public int MaxCapcity
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 99;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x0020EFCC File Offset: 0x0020D1CC
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06005810 RID: 22544 RVA: 0x0020F00C File Offset: 0x0020D20C
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x0020F038 File Offset: 0x0020D238
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x0020F048 File Offset: 0x0020D248
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06005813 RID: 22547 RVA: 0x0020F060 File Offset: 0x0020D260
		public bool ShowInInventory
		{
			get
			{
				int num = this.__p.__offset(44);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06005814 RID: 22548 RVA: 0x0020F0A0 File Offset: 0x0020D2A0
		public int ObtainedShow
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06005815 RID: 22549 RVA: 0x0020F0E0 File Offset: 0x0020D2E0
		public string ObtainedShowDescription
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

		// Token: 0x06005816 RID: 22550 RVA: 0x0020F118 File Offset: 0x0020D318
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x0020F128 File Offset: 0x0020D328
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06005818 RID: 22552 RVA: 0x0020F140 File Offset: 0x0020D340
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(50);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06005819 RID: 22553 RVA: 0x0020F180 File Offset: 0x0020D380
		public bool Destructible
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600581A RID: 22554 RVA: 0x0020F1C0 File Offset: 0x0020D3C0
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x0020F1FD File Offset: 0x0020D3FD
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600581C RID: 22556 RVA: 0x0020F205 File Offset: 0x0020D405
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			CalabashSkin.<ItemAccessIter>d__82 <ItemAccessIter>d__ = new CalabashSkin.<ItemAccessIter>d__82(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0400513F RID: 20799
		private Table __p;
	}
}
