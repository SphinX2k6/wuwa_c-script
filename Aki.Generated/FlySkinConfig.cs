using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC6 RID: 3270
	public struct FlySkinConfig : IFlatbufferObject
	{
		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x060075A0 RID: 30112 RVA: 0x00240544 File Offset: 0x0023E744
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00240551 File Offset: 0x0023E751
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x00240558 File Offset: 0x0023E758
		public static FlySkinConfig GetRootAsFlySkinConfig(ByteBuffer _bb)
		{
			return FlySkinConfig.GetRootAsFlySkinConfig(_bb, default(FlySkinConfig));
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00240574 File Offset: 0x0023E774
		public static FlySkinConfig GetRootAsFlySkinConfig(ByteBuffer _bb, FlySkinConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00240591 File Offset: 0x0023E791
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x002405A0 File Offset: 0x0023E7A0
		public FlySkinConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x060075A6 RID: 30118 RVA: 0x002405B0 File Offset: 0x0023E7B0
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

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x060075A7 RID: 30119 RVA: 0x002405EC File Offset: 0x0023E7EC
		public int SkinType
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

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x060075A8 RID: 30120 RVA: 0x00240628 File Offset: 0x0023E828
		public int ModelId
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

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x060075A9 RID: 30121 RVA: 0x00240664 File Offset: 0x0023E864
		public string StandAnim
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

		// Token: 0x060075AA RID: 30122 RVA: 0x0024069C File Offset: 0x0023E89C
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x002406AC File Offset: 0x0023E8AC
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x060075AC RID: 30124 RVA: 0x002406C4 File Offset: 0x0023E8C4
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x060075AD RID: 30125 RVA: 0x00240704 File Offset: 0x0023E904
		public int SkinGrade
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x060075AE RID: 30126 RVA: 0x00240744 File Offset: 0x0023E944
		public string Name
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

		// Token: 0x060075AF RID: 30127 RVA: 0x0024077C File Offset: 0x0023E97C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x0024078C File Offset: 0x0023E98C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x060075B1 RID: 30129 RVA: 0x002407A4 File Offset: 0x0023E9A4
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

		// Token: 0x060075B2 RID: 30130 RVA: 0x002407DC File Offset: 0x0023E9DC
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x002407EC File Offset: 0x0023E9EC
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x060075B4 RID: 30132 RVA: 0x00240804 File Offset: 0x0023EA04
		public string AttributesDescription
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

		// Token: 0x060075B5 RID: 30133 RVA: 0x0024083C File Offset: 0x0023EA3C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x0024084C File Offset: 0x0023EA4C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x060075B7 RID: 30135 RVA: 0x00240864 File Offset: 0x0023EA64
		public string BgDescription
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

		// Token: 0x060075B8 RID: 30136 RVA: 0x0024089C File Offset: 0x0023EA9C
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060075B9 RID: 30137 RVA: 0x002408AC File Offset: 0x0023EAAC
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x060075BA RID: 30138 RVA: 0x002408C4 File Offset: 0x0023EAC4
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

		// Token: 0x060075BB RID: 30139 RVA: 0x002408FC File Offset: 0x0023EAFC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x0024090C File Offset: 0x0023EB0C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x060075BD RID: 30141 RVA: 0x00240924 File Offset: 0x0023EB24
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

		// Token: 0x060075BE RID: 30142 RVA: 0x0024095C File Offset: 0x0023EB5C
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060075BF RID: 30143 RVA: 0x0024096C File Offset: 0x0023EB6C
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x060075C0 RID: 30144 RVA: 0x00240984 File Offset: 0x0023EB84
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

		// Token: 0x060075C1 RID: 30145 RVA: 0x002409BC File Offset: 0x0023EBBC
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x002409CC File Offset: 0x0023EBCC
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x060075C3 RID: 30147 RVA: 0x002409E4 File Offset: 0x0023EBE4
		public string Mesh
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

		// Token: 0x060075C4 RID: 30148 RVA: 0x00240A1C File Offset: 0x0023EC1C
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x00240A2C File Offset: 0x0023EC2C
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x060075C6 RID: 30150 RVA: 0x00240A44 File Offset: 0x0023EC44
		public string ObtainedShowDescription
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

		// Token: 0x060075C7 RID: 30151 RVA: 0x00240A7C File Offset: 0x0023EC7C
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00240A8C File Offset: 0x0023EC8C
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x060075C9 RID: 30153 RVA: 0x00240AA4 File Offset: 0x0023ECA4
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(34);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x00240AE4 File Offset: 0x0023ECE4
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x060075CB RID: 30155 RVA: 0x00240B24 File Offset: 0x0023ED24
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

		// Token: 0x060075CC RID: 30156 RVA: 0x00240B50 File Offset: 0x0023ED50
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x00240B60 File Offset: 0x0023ED60
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x060075CE RID: 30158 RVA: 0x00240B78 File Offset: 0x0023ED78
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

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x060075CF RID: 30159 RVA: 0x00240BB8 File Offset: 0x0023EDB8
		public int RedDotDisableRule
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

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x060075D0 RID: 30160 RVA: 0x00240BF8 File Offset: 0x0023EDF8
		public string PreviewTextureInBuyView
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

		// Token: 0x060075D1 RID: 30161 RVA: 0x00240C30 File Offset: 0x0023EE30
		public Span<byte> GetPreviewTextureInBuyViewBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00240C40 File Offset: 0x0023EE40
		public byte[] GetPreviewTextureInBuyViewArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x060075D3 RID: 30163 RVA: 0x00240C58 File Offset: 0x0023EE58
		public string PreviewTextureInPayShop
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

		// Token: 0x060075D4 RID: 30164 RVA: 0x00240C90 File Offset: 0x0023EE90
		public Span<byte> GetPreviewTextureInPayShopBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00240CA0 File Offset: 0x0023EEA0
		public byte[] GetPreviewTextureInPayShopArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x060075D6 RID: 30166 RVA: 0x00240CB8 File Offset: 0x0023EEB8
		public string PreviewTextureInPop
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

		// Token: 0x060075D7 RID: 30167 RVA: 0x00240CF0 File Offset: 0x0023EEF0
		public Span<byte> GetPreviewTextureInPopBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x00240D00 File Offset: 0x0023EF00
		public byte[] GetPreviewTextureInPopArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x060075D9 RID: 30169 RVA: 0x00240D18 File Offset: 0x0023EF18
		public string SkinObtainColor1
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

		// Token: 0x060075DA RID: 30170 RVA: 0x00240D50 File Offset: 0x0023EF50
		public Span<byte> GetSkinObtainColor1Bytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x00240D60 File Offset: 0x0023EF60
		public byte[] GetSkinObtainColor1Array()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x060075DC RID: 30172 RVA: 0x00240D78 File Offset: 0x0023EF78
		public string SkinObtainColor2
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

		// Token: 0x060075DD RID: 30173 RVA: 0x00240DB0 File Offset: 0x0023EFB0
		public Span<byte> GetSkinObtainColor2Bytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x00240DC0 File Offset: 0x0023EFC0
		public byte[] GetSkinObtainColor2Array()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x060075DF RID: 30175 RVA: 0x00240DD8 File Offset: 0x0023EFD8
		public string SkinObtainImage
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

		// Token: 0x060075E0 RID: 30176 RVA: 0x00240E10 File Offset: 0x0023F010
		public Span<byte> GetSkinObtainImageBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x00240E20 File Offset: 0x0023F020
		public byte[] GetSkinObtainImageArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x060075E2 RID: 30178 RVA: 0x00240E38 File Offset: 0x0023F038
		public bool IsSpecialViewAfterObtain
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x00240E78 File Offset: 0x0023F078
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			FlySkinConfig flySkinConfig = this;
			return flySkinConfig.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x00240E9C File Offset: 0x0023F09C
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			FlySkinConfig.<ItemAccessIter>d__96 <ItemAccessIter>d__ = new FlySkinConfig.<ItemAccessIter>d__96(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x04004D36 RID: 19766
		private Table __p;
	}
}
