using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B70 RID: 2928
	public struct ChatTheme : IFlatbufferObject
	{
		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x001F2ED5 File Offset: 0x001F10D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x001F2EE2 File Offset: 0x001F10E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x001F2EEC File Offset: 0x001F10EC
		public static ChatTheme GetRootAsChatTheme(ByteBuffer _bb)
		{
			return ChatTheme.GetRootAsChatTheme(_bb, default(ChatTheme));
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x001F2F08 File Offset: 0x001F1108
		public static ChatTheme GetRootAsChatTheme(ByteBuffer _bb, ChatTheme obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x001F2F25 File Offset: 0x001F1125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x001F2F34 File Offset: 0x001F1134
		public ChatTheme __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600541C RID: 21532 RVA: 0x001F2F44 File Offset: 0x001F1144
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

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x0600541D RID: 21533 RVA: 0x001F2F80 File Offset: 0x001F1180
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

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x0600541E RID: 21534 RVA: 0x001F2FBC File Offset: 0x001F11BC
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

		// Token: 0x0600541F RID: 21535 RVA: 0x001F2FF3 File Offset: 0x001F11F3
		public Span<byte> GetChatThemePathSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x001F3002 File Offset: 0x001F1202
		public byte[] GetChatThemePathSmallArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06005421 RID: 21537 RVA: 0x001F301C File Offset: 0x001F121C
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

		// Token: 0x06005422 RID: 21538 RVA: 0x001F3054 File Offset: 0x001F1254
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x001F3064 File Offset: 0x001F1264
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x001F307C File Offset: 0x001F127C
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

		// Token: 0x06005425 RID: 21541 RVA: 0x001F30B4 File Offset: 0x001F12B4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x001F30C4 File Offset: 0x001F12C4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06005427 RID: 21543 RVA: 0x001F30DC File Offset: 0x001F12DC
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

		// Token: 0x06005428 RID: 21544 RVA: 0x001F3114 File Offset: 0x001F1314
		public Span<byte> GetGetWayBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x001F3124 File Offset: 0x001F1324
		public byte[] GetGetWayArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x0600542A RID: 21546 RVA: 0x001F313C File Offset: 0x001F133C
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

		// Token: 0x0600542B RID: 21547 RVA: 0x001F317C File Offset: 0x001F137C
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600542C RID: 21548 RVA: 0x001F31BC File Offset: 0x001F13BC
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

		// Token: 0x0600542D RID: 21549 RVA: 0x001F31E8 File Offset: 0x001F13E8
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x001F31F8 File Offset: 0x001F13F8
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600542F RID: 21551 RVA: 0x001F3210 File Offset: 0x001F1410
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

		// Token: 0x06005430 RID: 21552 RVA: 0x001F3248 File Offset: 0x001F1448
		public Span<byte> GetTogChatItemANmlBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x001F3258 File Offset: 0x001F1458
		public byte[] GetTogChatItemANmlArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x001F3270 File Offset: 0x001F1470
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

		// Token: 0x06005433 RID: 21555 RVA: 0x001F32A8 File Offset: 0x001F14A8
		public Span<byte> GetTogChatItemAHoldBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x001F32B8 File Offset: 0x001F14B8
		public byte[] GetTogChatItemAHoldArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06005435 RID: 21557 RVA: 0x001F32D0 File Offset: 0x001F14D0
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

		// Token: 0x06005436 RID: 21558 RVA: 0x001F3308 File Offset: 0x001F1508
		public Span<byte> GetTogChatItemAPressBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x001F3318 File Offset: 0x001F1518
		public byte[] GetTogChatItemAPressArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x001F3330 File Offset: 0x001F1530
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

		// Token: 0x06005439 RID: 21561 RVA: 0x001F3368 File Offset: 0x001F1568
		public Span<byte> GetTogChatItemASelBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x001F3378 File Offset: 0x001F1578
		public byte[] GetTogChatItemASelArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x001F3390 File Offset: 0x001F1590
		public string TogChatItemATextcol(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600543C RID: 21564 RVA: 0x001F33CC File Offset: 0x001F15CC
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

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x001F33F8 File Offset: 0x001F15F8
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

		// Token: 0x0600543E RID: 21566 RVA: 0x001F3430 File Offset: 0x001F1630
		public Span<byte> GetTogChatItemBNmlBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x001F3440 File Offset: 0x001F1640
		public byte[] GetTogChatItemBNmlArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06005440 RID: 21568 RVA: 0x001F3458 File Offset: 0x001F1658
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

		// Token: 0x06005441 RID: 21569 RVA: 0x001F3490 File Offset: 0x001F1690
		public Span<byte> GetTogChatItemBHoldBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x001F34A0 File Offset: 0x001F16A0
		public byte[] GetTogChatItemBHoldArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x001F34B8 File Offset: 0x001F16B8
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

		// Token: 0x06005444 RID: 21572 RVA: 0x001F34F0 File Offset: 0x001F16F0
		public Span<byte> GetTogChatItemBPressBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x001F3500 File Offset: 0x001F1700
		public byte[] GetTogChatItemBPressArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06005446 RID: 21574 RVA: 0x001F3518 File Offset: 0x001F1718
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

		// Token: 0x06005447 RID: 21575 RVA: 0x001F3550 File Offset: 0x001F1750
		public Span<byte> GetTogChatItemBSelBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x001F3560 File Offset: 0x001F1760
		public byte[] GetTogChatItemBSelArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x001F3578 File Offset: 0x001F1778
		public string TogChatItemBTextcol(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600544A RID: 21578 RVA: 0x001F35B4 File Offset: 0x001F17B4
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

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600544B RID: 21579 RVA: 0x001F35E0 File Offset: 0x001F17E0
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

		// Token: 0x0600544C RID: 21580 RVA: 0x001F3618 File Offset: 0x001F1818
		public Span<byte> GetTxtTitle1Bytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x001F3628 File Offset: 0x001F1828
		public byte[] GetTxtTitle1Array()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600544E RID: 21582 RVA: 0x001F3640 File Offset: 0x001F1840
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

		// Token: 0x0600544F RID: 21583 RVA: 0x001F3678 File Offset: 0x001F1878
		public Span<byte> GetTxtTitle2Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x001F3688 File Offset: 0x001F1888
		public byte[] GetTxtTitle2Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06005451 RID: 21585 RVA: 0x001F36A0 File Offset: 0x001F18A0
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

		// Token: 0x06005452 RID: 21586 RVA: 0x001F36D8 File Offset: 0x001F18D8
		public Span<byte> GetTxtDescriBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x001F36E8 File Offset: 0x001F18E8
		public byte[] GetTxtDescriArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06005454 RID: 21588 RVA: 0x001F3700 File Offset: 0x001F1900
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

		// Token: 0x06005455 RID: 21589 RVA: 0x001F3738 File Offset: 0x001F1938
		public Span<byte> GetTxtGroupBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x001F3748 File Offset: 0x001F1948
		public byte[] GetTxtGroupArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06005457 RID: 21591 RVA: 0x001F3760 File Offset: 0x001F1960
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

		// Token: 0x06005458 RID: 21592 RVA: 0x001F3798 File Offset: 0x001F1998
		public Span<byte> GetTxtFilterBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x001F37A8 File Offset: 0x001F19A8
		public byte[] GetTxtFilterArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x0600545A RID: 21594 RVA: 0x001F37C0 File Offset: 0x001F19C0
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

		// Token: 0x0600545B RID: 21595 RVA: 0x001F37F8 File Offset: 0x001F19F8
		public Span<byte> GetBgTitle1Bytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x001F3808 File Offset: 0x001F1A08
		public byte[] GetBgTitle1Array()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x001F3820 File Offset: 0x001F1A20
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

		// Token: 0x0600545E RID: 21598 RVA: 0x001F3858 File Offset: 0x001F1A58
		public Span<byte> GetPrefabTitle1Bytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x001F3868 File Offset: 0x001F1A68
		public byte[] GetPrefabTitle1Array()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06005460 RID: 21600 RVA: 0x001F3880 File Offset: 0x001F1A80
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

		// Token: 0x06005461 RID: 21601 RVA: 0x001F38B8 File Offset: 0x001F1AB8
		public Span<byte> GetBgTitle2Bytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x001F38C8 File Offset: 0x001F1AC8
		public byte[] GetBgTitle2Array()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06005463 RID: 21603 RVA: 0x001F38E0 File Offset: 0x001F1AE0
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

		// Token: 0x06005464 RID: 21604 RVA: 0x001F3918 File Offset: 0x001F1B18
		public Span<byte> GetPrefabTitle2Bytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x001F3928 File Offset: 0x001F1B28
		public byte[] GetPrefabTitle2Array()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06005466 RID: 21606 RVA: 0x001F3940 File Offset: 0x001F1B40
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

		// Token: 0x06005467 RID: 21607 RVA: 0x001F3978 File Offset: 0x001F1B78
		public Span<byte> GetBgTitleSmall1Bytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x001F3988 File Offset: 0x001F1B88
		public byte[] GetBgTitleSmall1Array()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06005469 RID: 21609 RVA: 0x001F39A0 File Offset: 0x001F1BA0
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

		// Token: 0x0600546A RID: 21610 RVA: 0x001F39D8 File Offset: 0x001F1BD8
		public Span<byte> GetPrefabTitleSmall1Bytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x001F39E8 File Offset: 0x001F1BE8
		public byte[] GetPrefabTitleSmall1Array()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600546C RID: 21612 RVA: 0x001F3A00 File Offset: 0x001F1C00
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

		// Token: 0x0600546D RID: 21613 RVA: 0x001F3A38 File Offset: 0x001F1C38
		public Span<byte> GetBgTitleSmall2Bytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x001F3A48 File Offset: 0x001F1C48
		public byte[] GetBgTitleSmall2Array()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600546F RID: 21615 RVA: 0x001F3A60 File Offset: 0x001F1C60
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

		// Token: 0x06005470 RID: 21616 RVA: 0x001F3A98 File Offset: 0x001F1C98
		public Span<byte> GetPrefabTitleSmall2Bytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x001F3AA8 File Offset: 0x001F1CA8
		public byte[] GetPrefabTitleSmall2Array()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06005472 RID: 21618 RVA: 0x001F3AC0 File Offset: 0x001F1CC0
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

		// Token: 0x06005473 RID: 21619 RVA: 0x001F3AF8 File Offset: 0x001F1CF8
		public Span<byte> GetBgFilterNmlBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x001F3B08 File Offset: 0x001F1D08
		public byte[] GetBgFilterNmlArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06005475 RID: 21621 RVA: 0x001F3B20 File Offset: 0x001F1D20
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

		// Token: 0x06005476 RID: 21622 RVA: 0x001F3B58 File Offset: 0x001F1D58
		public Span<byte> GetBgFilterHoldBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x001F3B68 File Offset: 0x001F1D68
		public byte[] GetBgFilterHoldArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06005478 RID: 21624 RVA: 0x001F3B80 File Offset: 0x001F1D80
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

		// Token: 0x06005479 RID: 21625 RVA: 0x001F3BB8 File Offset: 0x001F1DB8
		public Span<byte> GetBgFilterPressBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x001F3BC8 File Offset: 0x001F1DC8
		public byte[] GetBgFilterPressArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600547B RID: 21627 RVA: 0x001F3BE0 File Offset: 0x001F1DE0
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

		// Token: 0x0600547C RID: 21628 RVA: 0x001F3C18 File Offset: 0x001F1E18
		public Span<byte> GetBgLeftChatBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x001F3C28 File Offset: 0x001F1E28
		public byte[] GetBgLeftChatArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x0600547E RID: 21630 RVA: 0x001F3C40 File Offset: 0x001F1E40
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

		// Token: 0x0600547F RID: 21631 RVA: 0x001F3C78 File Offset: 0x001F1E78
		public Span<byte> GetPrefabLeftChatBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x001F3C88 File Offset: 0x001F1E88
		public byte[] GetPrefabLeftChatArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06005481 RID: 21633 RVA: 0x001F3CA0 File Offset: 0x001F1EA0
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

		// Token: 0x06005482 RID: 21634 RVA: 0x001F3CD8 File Offset: 0x001F1ED8
		public Span<byte> GetBgBlankChatBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x001F3CE8 File Offset: 0x001F1EE8
		public byte[] GetBgBlankChatArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06005484 RID: 21636 RVA: 0x001F3D00 File Offset: 0x001F1F00
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

		// Token: 0x06005485 RID: 21637 RVA: 0x001F3D38 File Offset: 0x001F1F38
		public Span<byte> GetPrefabBlankChatBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x001F3D48 File Offset: 0x001F1F48
		public byte[] GetPrefabBlankChatArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06005487 RID: 21639 RVA: 0x001F3D60 File Offset: 0x001F1F60
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

		// Token: 0x06005488 RID: 21640 RVA: 0x001F3D98 File Offset: 0x001F1F98
		public Span<byte> GetBgSelectedBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x001F3DA8 File Offset: 0x001F1FA8
		public byte[] GetBgSelectedArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600548A RID: 21642 RVA: 0x001F3DC0 File Offset: 0x001F1FC0
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

		// Token: 0x0600548B RID: 21643 RVA: 0x001F3DF8 File Offset: 0x001F1FF8
		public Span<byte> GetBgGroupChatBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x001F3E08 File Offset: 0x001F2008
		public byte[] GetBgGroupChatArray()
		{
			return this.__p.__vector_as_array<byte>(82) ?? Array.Empty<byte>();
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x0600548D RID: 21645 RVA: 0x001F3E20 File Offset: 0x001F2020
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

		// Token: 0x0600548E RID: 21646 RVA: 0x001F3E58 File Offset: 0x001F2058
		public Span<byte> GetBgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x001F3E68 File Offset: 0x001F2068
		public byte[] GetBgNameArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06005490 RID: 21648 RVA: 0x001F3E80 File Offset: 0x001F2080
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

		// Token: 0x06005491 RID: 21649 RVA: 0x001F3EB8 File Offset: 0x001F20B8
		public Span<byte> GetBgDescriBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x001F3EC8 File Offset: 0x001F20C8
		public byte[] GetBgDescriArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06005493 RID: 21651 RVA: 0x001F3EE0 File Offset: 0x001F20E0
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

		// Token: 0x06005494 RID: 21652 RVA: 0x001F3F18 File Offset: 0x001F2118
		public Span<byte> GetBgRightBigBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x06005495 RID: 21653 RVA: 0x001F3F28 File Offset: 0x001F2128
		public byte[] GetBgRightBigArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06005496 RID: 21654 RVA: 0x001F3F40 File Offset: 0x001F2140
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

		// Token: 0x06005497 RID: 21655 RVA: 0x001F3F78 File Offset: 0x001F2178
		public Span<byte> GetBgRightBigPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x001F3F88 File Offset: 0x001F2188
		public byte[] GetBgRightBigPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06005499 RID: 21657 RVA: 0x001F3FA0 File Offset: 0x001F21A0
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

		// Token: 0x0600549A RID: 21658 RVA: 0x001F3FD8 File Offset: 0x001F21D8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x001F3FE8 File Offset: 0x001F21E8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600549C RID: 21660 RVA: 0x001F4000 File Offset: 0x001F2200
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

		// Token: 0x0600549D RID: 21661 RVA: 0x001F4038 File Offset: 0x001F2238
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x001F4048 File Offset: 0x001F2248
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600549F RID: 21663 RVA: 0x001F4060 File Offset: 0x001F2260
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

		// Token: 0x060054A0 RID: 21664 RVA: 0x001F4098 File Offset: 0x001F2298
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x001F40A8 File Offset: 0x001F22A8
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060054A2 RID: 21666 RVA: 0x001F40C0 File Offset: 0x001F22C0
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

		// Token: 0x060054A3 RID: 21667 RVA: 0x001F40F8 File Offset: 0x001F22F8
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x001F4108 File Offset: 0x001F2308
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(98) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060054A5 RID: 21669 RVA: 0x001F4120 File Offset: 0x001F2320
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

		// Token: 0x060054A6 RID: 21670 RVA: 0x001F4158 File Offset: 0x001F2358
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x060054A7 RID: 21671 RVA: 0x001F4168 File Offset: 0x001F2368
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x001F4180 File Offset: 0x001F2380
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

		// Token: 0x060054A9 RID: 21673 RVA: 0x001F41B8 File Offset: 0x001F23B8
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x001F41C8 File Offset: 0x001F23C8
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x001F41E0 File Offset: 0x001F23E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			ChatTheme chatTheme = this;
			return chatTheme.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x001F4204 File Offset: 0x001F2404
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			ChatTheme.<ItemAccessIter>d__202 <ItemAccessIter>d__ = new ChatTheme.<ItemAccessIter>d__202(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x001F4219 File Offset: 0x001F2419
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TogChatItemATextcolIter()或GetTogChatItemATextcolBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TogChatItemATextcol()
		{
			return this.TogChatItemATextcolIter().ToArray<string>();
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x001F4226 File Offset: 0x001F2426
		[NullableContext(1)]
		public readonly IEnumerable<string> TogChatItemATextcolIter()
		{
			ChatTheme.<TogChatItemATextcolIter>d__204 <TogChatItemATextcolIter>d__ = new ChatTheme.<TogChatItemATextcolIter>d__204(-2);
			<TogChatItemATextcolIter>d__.<>3__<>4__this = this;
			return <TogChatItemATextcolIter>d__;
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x001F423B File Offset: 0x001F243B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TogChatItemBTextcolIter()或GetTogChatItemBTextcolBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TogChatItemBTextcol()
		{
			return this.TogChatItemBTextcolIter().ToArray<string>();
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x001F4248 File Offset: 0x001F2448
		[NullableContext(1)]
		public readonly IEnumerable<string> TogChatItemBTextcolIter()
		{
			ChatTheme.<TogChatItemBTextcolIter>d__206 <TogChatItemBTextcolIter>d__ = new ChatTheme.<TogChatItemBTextcolIter>d__206(-2);
			<TogChatItemBTextcolIter>d__.<>3__<>4__this = this;
			return <TogChatItemBTextcolIter>d__;
		}

		// Token: 0x04004B72 RID: 19314
		private Table __p;
	}
}
