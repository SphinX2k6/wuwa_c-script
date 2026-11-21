using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C48 RID: 3144
	public struct ChatBg : IFlatbufferObject
	{
		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060058D1 RID: 22737 RVA: 0x00210B55 File Offset: 0x0020ED55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x00210B62 File Offset: 0x0020ED62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x00210B6C File Offset: 0x0020ED6C
		public static ChatBg GetRootAsChatBg(ByteBuffer _bb)
		{
			return ChatBg.GetRootAsChatBg(_bb, default(ChatBg));
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x00210B88 File Offset: 0x0020ED88
		public static ChatBg GetRootAsChatBg(ByteBuffer _bb, ChatBg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x00210BA5 File Offset: 0x0020EDA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x00210BB4 File Offset: 0x0020EDB4
		public ChatBg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060058D7 RID: 22743 RVA: 0x00210BC4 File Offset: 0x0020EDC4
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

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060058D8 RID: 22744 RVA: 0x00210C00 File Offset: 0x0020EE00
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

		// Token: 0x060058D9 RID: 22745 RVA: 0x00210C37 File Offset: 0x0020EE37
		public Span<byte> GetChatBgPathSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x00210C46 File Offset: 0x0020EE46
		public byte[] GetChatBgPathSmallArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060058DB RID: 22747 RVA: 0x00210C60 File Offset: 0x0020EE60
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

		// Token: 0x060058DC RID: 22748 RVA: 0x00210C97 File Offset: 0x0020EE97
		public Span<byte> GetChatBgPathBigBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x00210CA6 File Offset: 0x0020EEA6
		public byte[] GetChatBgPathBigArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060058DE RID: 22750 RVA: 0x00210CC0 File Offset: 0x0020EEC0
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

		// Token: 0x060058DF RID: 22751 RVA: 0x00210CF8 File Offset: 0x0020EEF8
		public Span<byte> GetScrollViewBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x00210D08 File Offset: 0x0020EF08
		public byte[] GetScrollViewBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060058E1 RID: 22753 RVA: 0x00210D20 File Offset: 0x0020EF20
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

		// Token: 0x060058E2 RID: 22754 RVA: 0x00210D58 File Offset: 0x0020EF58
		public Span<byte> GetReviewBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00210D68 File Offset: 0x0020EF68
		public byte[] GetReviewBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060058E4 RID: 22756 RVA: 0x00210D80 File Offset: 0x0020EF80
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

		// Token: 0x060058E5 RID: 22757 RVA: 0x00210DB8 File Offset: 0x0020EFB8
		public Span<byte> GetSmallViewBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x00210DC8 File Offset: 0x0020EFC8
		public byte[] GetSmallViewBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060058E7 RID: 22759 RVA: 0x00210DE0 File Offset: 0x0020EFE0
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

		// Token: 0x060058E8 RID: 22760 RVA: 0x00210E18 File Offset: 0x0020F018
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x00210E28 File Offset: 0x0020F028
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060058EA RID: 22762 RVA: 0x00210E40 File Offset: 0x0020F040
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

		// Token: 0x060058EB RID: 22763 RVA: 0x00210E78 File Offset: 0x0020F078
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x00210E88 File Offset: 0x0020F088
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060058ED RID: 22765 RVA: 0x00210EA0 File Offset: 0x0020F0A0
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

		// Token: 0x060058EE RID: 22766 RVA: 0x00210ED8 File Offset: 0x0020F0D8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x00210EE8 File Offset: 0x0020F0E8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060058F0 RID: 22768 RVA: 0x00210F00 File Offset: 0x0020F100
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

		// Token: 0x060058F1 RID: 22769 RVA: 0x00210F38 File Offset: 0x0020F138
		public Span<byte> GetGetWayBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x00210F48 File Offset: 0x0020F148
		public byte[] GetGetWayArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060058F3 RID: 22771 RVA: 0x00210F60 File Offset: 0x0020F160
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

		// Token: 0x060058F4 RID: 22772 RVA: 0x00210F98 File Offset: 0x0020F198
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x00210FA8 File Offset: 0x0020F1A8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060058F6 RID: 22774 RVA: 0x00210FC0 File Offset: 0x0020F1C0
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

		// Token: 0x060058F7 RID: 22775 RVA: 0x00210FF8 File Offset: 0x0020F1F8
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x00211008 File Offset: 0x0020F208
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060058F9 RID: 22777 RVA: 0x00211020 File Offset: 0x0020F220
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

		// Token: 0x060058FA RID: 22778 RVA: 0x00211058 File Offset: 0x0020F258
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x00211068 File Offset: 0x0020F268
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060058FC RID: 22780 RVA: 0x00211080 File Offset: 0x0020F280
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

		// Token: 0x060058FD RID: 22781 RVA: 0x002110B8 File Offset: 0x0020F2B8
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x002110C8 File Offset: 0x0020F2C8
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060058FF RID: 22783 RVA: 0x002110E0 File Offset: 0x0020F2E0
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

		// Token: 0x06005900 RID: 22784 RVA: 0x00211118 File Offset: 0x0020F318
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x00211128 File Offset: 0x0020F328
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06005902 RID: 22786 RVA: 0x00211140 File Offset: 0x0020F340
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

		// Token: 0x06005903 RID: 22787 RVA: 0x00211178 File Offset: 0x0020F378
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x00211188 File Offset: 0x0020F388
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x002111A0 File Offset: 0x0020F3A0
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06005906 RID: 22790 RVA: 0x002111E0 File Offset: 0x0020F3E0
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

		// Token: 0x06005907 RID: 22791 RVA: 0x0021120C File Offset: 0x0020F40C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x0021121C File Offset: 0x0020F41C
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06005909 RID: 22793 RVA: 0x00211234 File Offset: 0x0020F434
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

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600590A RID: 22794 RVA: 0x00211274 File Offset: 0x0020F474
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

		// Token: 0x0600590B RID: 22795 RVA: 0x002112B1 File Offset: 0x0020F4B1
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x002112B9 File Offset: 0x0020F4B9
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			ChatBg.<ItemAccessIter>d__80 <ItemAccessIter>d__ = new ChatBg.<ItemAccessIter>d__80(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0400514A RID: 20810
		private Table __p;
	}
}
