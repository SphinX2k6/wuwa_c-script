using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C50 RID: 3152
	public struct ChatTheme : IFlatbufferObject
	{
		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x00212BF1 File Offset: 0x00210DF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x00212BFE File Offset: 0x00210DFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x00212C08 File Offset: 0x00210E08
		public static ChatTheme GetRootAsChatTheme(ByteBuffer _bb)
		{
			return ChatTheme.GetRootAsChatTheme(_bb, default(ChatTheme));
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x00212C24 File Offset: 0x00210E24
		public static ChatTheme GetRootAsChatTheme(ByteBuffer _bb, ChatTheme obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x00212C41 File Offset: 0x00210E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x00212C50 File Offset: 0x00210E50
		public ChatTheme __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060059DE RID: 23006 RVA: 0x00212C60 File Offset: 0x00210E60
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

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060059DF RID: 23007 RVA: 0x00212C9C File Offset: 0x00210E9C
		public int QualityId
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

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060059E0 RID: 23008 RVA: 0x00212CD8 File Offset: 0x00210ED8
		public string ChatThemePathSmall
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

		// Token: 0x060059E1 RID: 23009 RVA: 0x00212D0F File Offset: 0x00210F0F
		public Span<byte> GetChatThemePathSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x00212D1E File Offset: 0x00210F1E
		public byte[] GetChatThemePathSmallArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060059E3 RID: 23011 RVA: 0x00212D38 File Offset: 0x00210F38
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

		// Token: 0x060059E4 RID: 23012 RVA: 0x00212D70 File Offset: 0x00210F70
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x00212D80 File Offset: 0x00210F80
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060059E6 RID: 23014 RVA: 0x00212D98 File Offset: 0x00210F98
		public string Desc
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

		// Token: 0x060059E7 RID: 23015 RVA: 0x00212DD0 File Offset: 0x00210FD0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x00212DE0 File Offset: 0x00210FE0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060059E9 RID: 23017 RVA: 0x00212DF8 File Offset: 0x00210FF8
		public string GetWay
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

		// Token: 0x060059EA RID: 23018 RVA: 0x00212E30 File Offset: 0x00211030
		public Span<byte> GetGetWayBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060059EB RID: 23019 RVA: 0x00212E40 File Offset: 0x00211040
		public byte[] GetGetWayArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060059EC RID: 23020 RVA: 0x00212E58 File Offset: 0x00211058
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059ED RID: 23021 RVA: 0x00212E98 File Offset: 0x00211098
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060059EE RID: 23022 RVA: 0x00212ED8 File Offset: 0x002110D8
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060059EF RID: 23023 RVA: 0x00212F04 File Offset: 0x00211104
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060059F0 RID: 23024 RVA: 0x00212F14 File Offset: 0x00211114
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060059F1 RID: 23025 RVA: 0x00212F2C File Offset: 0x0021112C
		public string TogChatItemANml
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

		// Token: 0x060059F2 RID: 23026 RVA: 0x00212F64 File Offset: 0x00211164
		public Span<byte> GetTogChatItemANmlBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060059F3 RID: 23027 RVA: 0x00212F74 File Offset: 0x00211174
		public byte[] GetTogChatItemANmlArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060059F4 RID: 23028 RVA: 0x00212F8C File Offset: 0x0021118C
		public string TogChatItemAHold
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

		// Token: 0x060059F5 RID: 23029 RVA: 0x00212FC4 File Offset: 0x002111C4
		public Span<byte> GetTogChatItemAHoldBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x00212FD4 File Offset: 0x002111D4
		public byte[] GetTogChatItemAHoldArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060059F7 RID: 23031 RVA: 0x00212FEC File Offset: 0x002111EC
		public string TogChatItemAPress
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

		// Token: 0x060059F8 RID: 23032 RVA: 0x00213024 File Offset: 0x00211224
		public Span<byte> GetTogChatItemAPressBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060059F9 RID: 23033 RVA: 0x00213034 File Offset: 0x00211234
		public byte[] GetTogChatItemAPressArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060059FA RID: 23034 RVA: 0x0021304C File Offset: 0x0021124C
		public string TogChatItemASel
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

		// Token: 0x060059FB RID: 23035 RVA: 0x00213084 File Offset: 0x00211284
		public Span<byte> GetTogChatItemASelBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x00213094 File Offset: 0x00211294
		public byte[] GetTogChatItemASelArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x002130AC File Offset: 0x002112AC
		public string TogChatItemATextcol(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060059FE RID: 23038 RVA: 0x002130E8 File Offset: 0x002112E8
		public int TogChatItemATextcolLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060059FF RID: 23039 RVA: 0x00213114 File Offset: 0x00211314
		public string TogChatItemBNml
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

		// Token: 0x06005A00 RID: 23040 RVA: 0x0021314C File Offset: 0x0021134C
		public Span<byte> GetTogChatItemBNmlBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x0021315C File Offset: 0x0021135C
		public byte[] GetTogChatItemBNmlArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06005A02 RID: 23042 RVA: 0x00213174 File Offset: 0x00211374
		public string TogChatItemBHold
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

		// Token: 0x06005A03 RID: 23043 RVA: 0x002131AC File Offset: 0x002113AC
		public Span<byte> GetTogChatItemBHoldBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x002131BC File Offset: 0x002113BC
		public byte[] GetTogChatItemBHoldArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06005A05 RID: 23045 RVA: 0x002131D4 File Offset: 0x002113D4
		public string TogChatItemBPress
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

		// Token: 0x06005A06 RID: 23046 RVA: 0x0021320C File Offset: 0x0021140C
		public Span<byte> GetTogChatItemBPressBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x0021321C File Offset: 0x0021141C
		public byte[] GetTogChatItemBPressArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06005A08 RID: 23048 RVA: 0x00213234 File Offset: 0x00211434
		public string TogChatItemBSel
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

		// Token: 0x06005A09 RID: 23049 RVA: 0x0021326C File Offset: 0x0021146C
		public Span<byte> GetTogChatItemBSelBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06005A0A RID: 23050 RVA: 0x0021327C File Offset: 0x0021147C
		public byte[] GetTogChatItemBSelArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x00213294 File Offset: 0x00211494
		public string TogChatItemBTextcol(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06005A0C RID: 23052 RVA: 0x002132D0 File Offset: 0x002114D0
		public int TogChatItemBTextcolLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06005A0D RID: 23053 RVA: 0x002132FC File Offset: 0x002114FC
		public string TxtTitle1
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

		// Token: 0x06005A0E RID: 23054 RVA: 0x00213334 File Offset: 0x00211534
		public Span<byte> GetTxtTitle1Bytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x00213344 File Offset: 0x00211544
		public byte[] GetTxtTitle1Array()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06005A10 RID: 23056 RVA: 0x0021335C File Offset: 0x0021155C
		public string TxtTitle2
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

		// Token: 0x06005A11 RID: 23057 RVA: 0x00213394 File Offset: 0x00211594
		public Span<byte> GetTxtTitle2Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x002133A4 File Offset: 0x002115A4
		public byte[] GetTxtTitle2Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06005A13 RID: 23059 RVA: 0x002133BC File Offset: 0x002115BC
		public string TxtDescri
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

		// Token: 0x06005A14 RID: 23060 RVA: 0x002133F4 File Offset: 0x002115F4
		public Span<byte> GetTxtDescriBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x00213404 File Offset: 0x00211604
		public byte[] GetTxtDescriArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06005A16 RID: 23062 RVA: 0x0021341C File Offset: 0x0021161C
		public string TxtGroup
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

		// Token: 0x06005A17 RID: 23063 RVA: 0x00213454 File Offset: 0x00211654
		public Span<byte> GetTxtGroupBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x00213464 File Offset: 0x00211664
		public byte[] GetTxtGroupArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06005A19 RID: 23065 RVA: 0x0021347C File Offset: 0x0021167C
		public string TxtFilter
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

		// Token: 0x06005A1A RID: 23066 RVA: 0x002134B4 File Offset: 0x002116B4
		public Span<byte> GetTxtFilterBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x002134C4 File Offset: 0x002116C4
		public byte[] GetTxtFilterArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06005A1C RID: 23068 RVA: 0x002134DC File Offset: 0x002116DC
		public string BgTitle1
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

		// Token: 0x06005A1D RID: 23069 RVA: 0x00213514 File Offset: 0x00211714
		public Span<byte> GetBgTitle1Bytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x00213524 File Offset: 0x00211724
		public byte[] GetBgTitle1Array()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06005A1F RID: 23071 RVA: 0x0021353C File Offset: 0x0021173C
		public string PrefabTitle1
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x00213574 File Offset: 0x00211774
		public Span<byte> GetPrefabTitle1Bytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06005A21 RID: 23073 RVA: 0x00213584 File Offset: 0x00211784
		public byte[] GetPrefabTitle1Array()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06005A22 RID: 23074 RVA: 0x0021359C File Offset: 0x0021179C
		public string BgTitle2
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A23 RID: 23075 RVA: 0x002135D4 File Offset: 0x002117D4
		public Span<byte> GetBgTitle2Bytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x002135E4 File Offset: 0x002117E4
		public byte[] GetBgTitle2Array()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06005A25 RID: 23077 RVA: 0x002135FC File Offset: 0x002117FC
		public string PrefabTitle2
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x00213634 File Offset: 0x00211834
		public Span<byte> GetPrefabTitle2Bytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x00213644 File Offset: 0x00211844
		public byte[] GetPrefabTitle2Array()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06005A28 RID: 23080 RVA: 0x0021365C File Offset: 0x0021185C
		public string BgTitleSmall1
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00213694 File Offset: 0x00211894
		public Span<byte> GetBgTitleSmall1Bytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x002136A4 File Offset: 0x002118A4
		public byte[] GetBgTitleSmall1Array()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06005A2B RID: 23083 RVA: 0x002136BC File Offset: 0x002118BC
		public string PrefabTitleSmall1
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x002136F4 File Offset: 0x002118F4
		public Span<byte> GetPrefabTitleSmall1Bytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x00213704 File Offset: 0x00211904
		public byte[] GetPrefabTitleSmall1Array()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06005A2E RID: 23086 RVA: 0x0021371C File Offset: 0x0021191C
		public string BgTitleSmall2
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x00213754 File Offset: 0x00211954
		public Span<byte> GetBgTitleSmall2Bytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06005A30 RID: 23088 RVA: 0x00213764 File Offset: 0x00211964
		public byte[] GetBgTitleSmall2Array()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06005A31 RID: 23089 RVA: 0x0021377C File Offset: 0x0021197C
		public string PrefabTitleSmall2
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x002137B4 File Offset: 0x002119B4
		public Span<byte> GetPrefabTitleSmall2Bytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x002137C4 File Offset: 0x002119C4
		public byte[] GetPrefabTitleSmall2Array()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06005A34 RID: 23092 RVA: 0x002137DC File Offset: 0x002119DC
		public string BgFilterNml
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00213814 File Offset: 0x00211A14
		public Span<byte> GetBgFilterNmlBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x00213824 File Offset: 0x00211A24
		public byte[] GetBgFilterNmlArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06005A37 RID: 23095 RVA: 0x0021383C File Offset: 0x00211A3C
		public string BgFilterHold
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x00213874 File Offset: 0x00211A74
		public Span<byte> GetBgFilterHoldBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x00213884 File Offset: 0x00211A84
		public byte[] GetBgFilterHoldArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06005A3A RID: 23098 RVA: 0x0021389C File Offset: 0x00211A9C
		public string BgFilterPress
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A3B RID: 23099 RVA: 0x002138D4 File Offset: 0x00211AD4
		public Span<byte> GetBgFilterPressBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x002138E4 File Offset: 0x00211AE4
		public byte[] GetBgFilterPressArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06005A3D RID: 23101 RVA: 0x002138FC File Offset: 0x00211AFC
		public string BgLeftChat
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x00213934 File Offset: 0x00211B34
		public Span<byte> GetBgLeftChatBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x00213944 File Offset: 0x00211B44
		public byte[] GetBgLeftChatArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06005A40 RID: 23104 RVA: 0x0021395C File Offset: 0x00211B5C
		public string PrefabLeftChat
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x00213994 File Offset: 0x00211B94
		public Span<byte> GetPrefabLeftChatBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x002139A4 File Offset: 0x00211BA4
		public byte[] GetPrefabLeftChatArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06005A43 RID: 23107 RVA: 0x002139BC File Offset: 0x00211BBC
		public string BgBlankChat
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x002139F4 File Offset: 0x00211BF4
		public Span<byte> GetBgBlankChatBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x00213A04 File Offset: 0x00211C04
		public byte[] GetBgBlankChatArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06005A46 RID: 23110 RVA: 0x00213A1C File Offset: 0x00211C1C
		public string PrefabBlankChat
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00213A54 File Offset: 0x00211C54
		public Span<byte> GetPrefabBlankChatBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x00213A64 File Offset: 0x00211C64
		public byte[] GetPrefabBlankChatArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06005A49 RID: 23113 RVA: 0x00213A7C File Offset: 0x00211C7C
		public string BgSelected
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x00213AB4 File Offset: 0x00211CB4
		public Span<byte> GetBgSelectedBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x00213AC4 File Offset: 0x00211CC4
		public byte[] GetBgSelectedArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06005A4C RID: 23116 RVA: 0x00213ADC File Offset: 0x00211CDC
		public string BgGroupChat
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x00213B14 File Offset: 0x00211D14
		public Span<byte> GetBgGroupChatBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00213B24 File Offset: 0x00211D24
		public byte[] GetBgGroupChatArray()
		{
			return this.__p.__vector_as_array<byte>(82) ?? Array.Empty<byte>();
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06005A4F RID: 23119 RVA: 0x00213B3C File Offset: 0x00211D3C
		public string BgName
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x00213B74 File Offset: 0x00211D74
		public Span<byte> GetBgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x00213B84 File Offset: 0x00211D84
		public byte[] GetBgNameArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06005A52 RID: 23122 RVA: 0x00213B9C File Offset: 0x00211D9C
		public string BgDescri
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x00213BD4 File Offset: 0x00211DD4
		public Span<byte> GetBgDescriBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x00213BE4 File Offset: 0x00211DE4
		public byte[] GetBgDescriArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06005A55 RID: 23125 RVA: 0x00213BFC File Offset: 0x00211DFC
		public string BgRightBig
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x00213C34 File Offset: 0x00211E34
		public Span<byte> GetBgRightBigBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x00213C44 File Offset: 0x00211E44
		public byte[] GetBgRightBigArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06005A58 RID: 23128 RVA: 0x00213C5C File Offset: 0x00211E5C
		public string BgRightBigPrefab
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x00213C94 File Offset: 0x00211E94
		public Span<byte> GetBgRightBigPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x00213CA4 File Offset: 0x00211EA4
		public byte[] GetBgRightBigPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06005A5B RID: 23131 RVA: 0x00213CBC File Offset: 0x00211EBC
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A5C RID: 23132 RVA: 0x00213CF4 File Offset: 0x00211EF4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x00213D04 File Offset: 0x00211F04
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06005A5E RID: 23134 RVA: 0x00213D1C File Offset: 0x00211F1C
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x00213D54 File Offset: 0x00211F54
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x06005A60 RID: 23136 RVA: 0x00213D64 File Offset: 0x00211F64
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06005A61 RID: 23137 RVA: 0x00213D7C File Offset: 0x00211F7C
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A62 RID: 23138 RVA: 0x00213DB4 File Offset: 0x00211FB4
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x00213DC4 File Offset: 0x00211FC4
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06005A64 RID: 23140 RVA: 0x00213DDC File Offset: 0x00211FDC
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x00213E14 File Offset: 0x00212014
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x00213E24 File Offset: 0x00212024
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(98) ?? Array.Empty<byte>();
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06005A67 RID: 23143 RVA: 0x00213E3C File Offset: 0x0021203C
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x00213E74 File Offset: 0x00212074
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x06005A69 RID: 23145 RVA: 0x00213E84 File Offset: 0x00212084
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06005A6A RID: 23146 RVA: 0x00213E9C File Offset: 0x0021209C
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x00213ED4 File Offset: 0x002120D4
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x00213EE4 File Offset: 0x002120E4
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x00213EFC File Offset: 0x002120FC
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x00213F04 File Offset: 0x00212104
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			ChatTheme.<ItemAccessIter>d__202 <ItemAccessIter>d__ = new ChatTheme.<ItemAccessIter>d__202(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00213F19 File Offset: 0x00212119
		[NullableContext(1)]
		public string[] TogChatItemATextcol()
		{
			return this.TogChatItemATextcolIter().ToArray<string>();
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x00213F26 File Offset: 0x00212126
		[NullableContext(1)]
		public IEnumerable<string> TogChatItemATextcolIter()
		{
			ChatTheme.<TogChatItemATextcolIter>d__204 <TogChatItemATextcolIter>d__ = new ChatTheme.<TogChatItemATextcolIter>d__204(-2);
			<TogChatItemATextcolIter>d__.<>3__<>4__this = this;
			return <TogChatItemATextcolIter>d__;
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x00213F3B File Offset: 0x0021213B
		[NullableContext(1)]
		public string[] TogChatItemBTextcol()
		{
			return this.TogChatItemBTextcolIter().ToArray<string>();
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x00213F48 File Offset: 0x00212148
		[NullableContext(1)]
		public IEnumerable<string> TogChatItemBTextcolIter()
		{
			ChatTheme.<TogChatItemBTextcolIter>d__206 <TogChatItemBTextcolIter>d__ = new ChatTheme.<TogChatItemBTextcolIter>d__206(-2);
			<TogChatItemBTextcolIter>d__.<>3__<>4__this = this;
			return <TogChatItemBTextcolIter>d__;
		}

		// Token: 0x04005152 RID: 20818
		private Table __p;
	}
}
