using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5F RID: 2911
	public struct CalabashSkin : IFlatbufferObject
	{
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06005224 RID: 21028 RVA: 0x001EEBF5 File Offset: 0x001ECDF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x001EEC02 File Offset: 0x001ECE02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x001EEC0C File Offset: 0x001ECE0C
		public static CalabashSkin GetRootAsCalabashSkin(ByteBuffer _bb)
		{
			return CalabashSkin.GetRootAsCalabashSkin(_bb, default(CalabashSkin));
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x001EEC28 File Offset: 0x001ECE28
		public static CalabashSkin GetRootAsCalabashSkin(ByteBuffer _bb, CalabashSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x001EEC45 File Offset: 0x001ECE45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x001EEC54 File Offset: 0x001ECE54
		public CalabashSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600522A RID: 21034 RVA: 0x001EEC64 File Offset: 0x001ECE64
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

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600522B RID: 21035 RVA: 0x001EECA0 File Offset: 0x001ECEA0
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x001EECE0 File Offset: 0x001ECEE0
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

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600522D RID: 21037 RVA: 0x001EED1C File Offset: 0x001ECF1C
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

		// Token: 0x0600522E RID: 21038 RVA: 0x001EED54 File Offset: 0x001ECF54
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x001EED64 File Offset: 0x001ECF64
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x001EED7C File Offset: 0x001ECF7C
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

		// Token: 0x06005231 RID: 21041 RVA: 0x001EEDB4 File Offset: 0x001ECFB4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x001EEDC4 File Offset: 0x001ECFC4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06005233 RID: 21043 RVA: 0x001EEDDC File Offset: 0x001ECFDC
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

		// Token: 0x06005234 RID: 21044 RVA: 0x001EEE14 File Offset: 0x001ED014
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x001EEE24 File Offset: 0x001ED024
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06005236 RID: 21046 RVA: 0x001EEE3C File Offset: 0x001ED03C
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

		// Token: 0x06005237 RID: 21047 RVA: 0x001EEE74 File Offset: 0x001ED074
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x001EEE84 File Offset: 0x001ED084
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06005239 RID: 21049 RVA: 0x001EEE9C File Offset: 0x001ED09C
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

		// Token: 0x0600523A RID: 21050 RVA: 0x001EEED4 File Offset: 0x001ED0D4
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x001EEEE4 File Offset: 0x001ED0E4
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600523C RID: 21052 RVA: 0x001EEEFC File Offset: 0x001ED0FC
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

		// Token: 0x0600523D RID: 21053 RVA: 0x001EEF34 File Offset: 0x001ED134
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x001EEF44 File Offset: 0x001ED144
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600523F RID: 21055 RVA: 0x001EEF5C File Offset: 0x001ED15C
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

		// Token: 0x06005240 RID: 21056 RVA: 0x001EEF94 File Offset: 0x001ED194
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x001EEFA4 File Offset: 0x001ED1A4
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06005242 RID: 21058 RVA: 0x001EEFBC File Offset: 0x001ED1BC
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

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06005243 RID: 21059 RVA: 0x001EEFFC File Offset: 0x001ED1FC
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

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06005244 RID: 21060 RVA: 0x001EF03C File Offset: 0x001ED23C
		public bool ShowUseButton
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06005245 RID: 21061 RVA: 0x001EF07C File Offset: 0x001ED27C
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

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06005246 RID: 21062 RVA: 0x001EF0BC File Offset: 0x001ED2BC
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

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06005247 RID: 21063 RVA: 0x001EF0FC File Offset: 0x001ED2FC
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

		// Token: 0x06005248 RID: 21064 RVA: 0x001EF134 File Offset: 0x001ED334
		public Span<byte> GetSwitchEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x001EF144 File Offset: 0x001ED344
		public byte[] GetSwitchEffectArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600524A RID: 21066 RVA: 0x001EF15C File Offset: 0x001ED35C
		public bool ShowWhenLocked
		{
			get
			{
				int num = this.__p.__offset(36);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600524B RID: 21067 RVA: 0x001EF19C File Offset: 0x001ED39C
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

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600524C RID: 21068 RVA: 0x001EF1DC File Offset: 0x001ED3DC
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

		// Token: 0x0600524D RID: 21069 RVA: 0x001EF21C File Offset: 0x001ED41C
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600524E RID: 21070 RVA: 0x001EF25C File Offset: 0x001ED45C
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

		// Token: 0x0600524F RID: 21071 RVA: 0x001EF288 File Offset: 0x001ED488
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x001EF298 File Offset: 0x001ED498
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06005251 RID: 21073 RVA: 0x001EF2B0 File Offset: 0x001ED4B0
		public bool ShowInInventory
		{
			get
			{
				int num = this.__p.__offset(44);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06005252 RID: 21074 RVA: 0x001EF2F0 File Offset: 0x001ED4F0
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

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06005253 RID: 21075 RVA: 0x001EF330 File Offset: 0x001ED530
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

		// Token: 0x06005254 RID: 21076 RVA: 0x001EF368 File Offset: 0x001ED568
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x001EF378 File Offset: 0x001ED578
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06005256 RID: 21078 RVA: 0x001EF390 File Offset: 0x001ED590
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(50);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06005257 RID: 21079 RVA: 0x001EF3D0 File Offset: 0x001ED5D0
		public bool Destructible
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06005258 RID: 21080 RVA: 0x001EF410 File Offset: 0x001ED610
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

		// Token: 0x06005259 RID: 21081 RVA: 0x001EF450 File Offset: 0x001ED650
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			CalabashSkin calabashSkin = this;
			return calabashSkin.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x001EF474 File Offset: 0x001ED674
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			CalabashSkin.<ItemAccessIter>d__82 <ItemAccessIter>d__ = new CalabashSkin.<ItemAccessIter>d__82(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x04004B5F RID: 19295
		private Table __p;
	}
}
