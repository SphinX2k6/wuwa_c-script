using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012C8 RID: 4808
	public struct WeaponConf : IFlatbufferObject
	{
		// Token: 0x1700411B RID: 16667
		// (get) Token: 0x0600F4DD RID: 62685 RVA: 0x0036C4D4 File Offset: 0x0036A6D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F4DE RID: 62686 RVA: 0x0036C4E1 File Offset: 0x0036A6E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F4DF RID: 62687 RVA: 0x0036C4E8 File Offset: 0x0036A6E8
		public static WeaponConf GetRootAsWeaponConf(ByteBuffer _bb)
		{
			return WeaponConf.GetRootAsWeaponConf(_bb, default(WeaponConf));
		}

		// Token: 0x0600F4E0 RID: 62688 RVA: 0x0036C504 File Offset: 0x0036A704
		public static WeaponConf GetRootAsWeaponConf(ByteBuffer _bb, WeaponConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F4E1 RID: 62689 RVA: 0x0036C521 File Offset: 0x0036A721
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F4E2 RID: 62690 RVA: 0x0036C530 File Offset: 0x0036A730
		public WeaponConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700411C RID: 16668
		// (get) Token: 0x0600F4E3 RID: 62691 RVA: 0x0036C540 File Offset: 0x0036A740
		public int ItemId
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

		// Token: 0x1700411D RID: 16669
		// (get) Token: 0x0600F4E4 RID: 62692 RVA: 0x0036C57C File Offset: 0x0036A77C
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700411E RID: 16670
		// (get) Token: 0x0600F4E5 RID: 62693 RVA: 0x0036C5BC File Offset: 0x0036A7BC
		public string WeaponName
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

		// Token: 0x0600F4E6 RID: 62694 RVA: 0x0036C5F3 File Offset: 0x0036A7F3
		public Span<byte> GetWeaponNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F4E7 RID: 62695 RVA: 0x0036C602 File Offset: 0x0036A802
		public byte[] GetWeaponNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700411F RID: 16671
		// (get) Token: 0x0600F4E8 RID: 62696 RVA: 0x0036C61C File Offset: 0x0036A81C
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004120 RID: 16672
		// (get) Token: 0x0600F4E9 RID: 62697 RVA: 0x0036C65C File Offset: 0x0036A85C
		public int WeaponType
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

		// Token: 0x17004121 RID: 16673
		// (get) Token: 0x0600F4EA RID: 62698 RVA: 0x0036C69C File Offset: 0x0036A89C
		public int ModelId
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

		// Token: 0x17004122 RID: 16674
		// (get) Token: 0x0600F4EB RID: 62699 RVA: 0x0036C6DC File Offset: 0x0036A8DC
		public int TransformId
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

		// Token: 0x0600F4EC RID: 62700 RVA: 0x0036C71C File Offset: 0x0036A91C
		public int Models(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004123 RID: 16675
		// (get) Token: 0x0600F4ED RID: 62701 RVA: 0x0036C75C File Offset: 0x0036A95C
		public int ModelsLength
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

		// Token: 0x0600F4EE RID: 62702 RVA: 0x0036C788 File Offset: 0x0036A988
		public Span<int> GetModelsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600F4EF RID: 62703 RVA: 0x0036C798 File Offset: 0x0036A998
		public int[] GetModelsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600F4F0 RID: 62704 RVA: 0x0036C7B0 File Offset: 0x0036A9B0
		public int ModelsIndex(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004124 RID: 16676
		// (get) Token: 0x0600F4F1 RID: 62705 RVA: 0x0036C7F0 File Offset: 0x0036A9F0
		public int ModelsIndexLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F4F2 RID: 62706 RVA: 0x0036C81C File Offset: 0x0036AA1C
		public Span<int> GetModelsIndexBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600F4F3 RID: 62707 RVA: 0x0036C82C File Offset: 0x0036AA2C
		public int[] GetModelsIndexArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17004125 RID: 16677
		// (get) Token: 0x0600F4F4 RID: 62708 RVA: 0x0036C844 File Offset: 0x0036AA44
		public int ResonLevelLimit
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004126 RID: 16678
		// (get) Token: 0x0600F4F5 RID: 62709 RVA: 0x0036C884 File Offset: 0x0036AA84
		public ConfigPropValue? FirstPropId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17004127 RID: 16679
		// (get) Token: 0x0600F4F6 RID: 62710 RVA: 0x0036C8E4 File Offset: 0x0036AAE4
		public int FirstCurve
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

		// Token: 0x17004128 RID: 16680
		// (get) Token: 0x0600F4F7 RID: 62711 RVA: 0x0036C924 File Offset: 0x0036AB24
		public ConfigPropValue? SecondPropId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17004129 RID: 16681
		// (get) Token: 0x0600F4F8 RID: 62712 RVA: 0x0036C984 File Offset: 0x0036AB84
		public int SecondCurve
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

		// Token: 0x1700412A RID: 16682
		// (get) Token: 0x0600F4F9 RID: 62713 RVA: 0x0036C9C4 File Offset: 0x0036ABC4
		public int ResonId
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

		// Token: 0x1700412B RID: 16683
		// (get) Token: 0x0600F4FA RID: 62714 RVA: 0x0036CA04 File Offset: 0x0036AC04
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700412C RID: 16684
		// (get) Token: 0x0600F4FB RID: 62715 RVA: 0x0036CA44 File Offset: 0x0036AC44
		public int BreachId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F4FC RID: 62716 RVA: 0x0036CA84 File Offset: 0x0036AC84
		public string StandAnim(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700412D RID: 16685
		// (get) Token: 0x0600F4FD RID: 62717 RVA: 0x0036CAC0 File Offset: 0x0036ACC0
		public int StandAnimLength
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

		// Token: 0x1700412E RID: 16686
		// (get) Token: 0x0600F4FE RID: 62718 RVA: 0x0036CAEC File Offset: 0x0036ACEC
		public string Desc
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

		// Token: 0x0600F4FF RID: 62719 RVA: 0x0036CB24 File Offset: 0x0036AD24
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600F500 RID: 62720 RVA: 0x0036CB34 File Offset: 0x0036AD34
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F501 RID: 62721 RVA: 0x0036CB4C File Offset: 0x0036AD4C
		public StringArray? DescParams(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700412F RID: 16687
		// (get) Token: 0x0600F502 RID: 62722 RVA: 0x0036CBB0 File Offset: 0x0036ADB0
		public int DescParamsLength
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

		// Token: 0x17004130 RID: 16688
		// (get) Token: 0x0600F503 RID: 62723 RVA: 0x0036CBDC File Offset: 0x0036ADDC
		public string TypeDescription
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

		// Token: 0x0600F504 RID: 62724 RVA: 0x0036CC14 File Offset: 0x0036AE14
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600F505 RID: 62725 RVA: 0x0036CC24 File Offset: 0x0036AE24
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17004131 RID: 16689
		// (get) Token: 0x0600F506 RID: 62726 RVA: 0x0036CC3C File Offset: 0x0036AE3C
		public string AttributesDescription
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

		// Token: 0x0600F507 RID: 62727 RVA: 0x0036CC74 File Offset: 0x0036AE74
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600F508 RID: 62728 RVA: 0x0036CC84 File Offset: 0x0036AE84
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17004132 RID: 16690
		// (get) Token: 0x0600F509 RID: 62729 RVA: 0x0036CC9C File Offset: 0x0036AE9C
		public string BgDescription
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

		// Token: 0x0600F50A RID: 62730 RVA: 0x0036CCD4 File Offset: 0x0036AED4
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600F50B RID: 62731 RVA: 0x0036CCE4 File Offset: 0x0036AEE4
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17004133 RID: 16691
		// (get) Token: 0x0600F50C RID: 62732 RVA: 0x0036CCFC File Offset: 0x0036AEFC
		public string Icon
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

		// Token: 0x0600F50D RID: 62733 RVA: 0x0036CD34 File Offset: 0x0036AF34
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600F50E RID: 62734 RVA: 0x0036CD44 File Offset: 0x0036AF44
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17004134 RID: 16692
		// (get) Token: 0x0600F50F RID: 62735 RVA: 0x0036CD5C File Offset: 0x0036AF5C
		public string IconMiddle
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

		// Token: 0x0600F510 RID: 62736 RVA: 0x0036CD94 File Offset: 0x0036AF94
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600F511 RID: 62737 RVA: 0x0036CDA4 File Offset: 0x0036AFA4
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17004135 RID: 16693
		// (get) Token: 0x0600F512 RID: 62738 RVA: 0x0036CDBC File Offset: 0x0036AFBC
		public string IconSmall
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

		// Token: 0x0600F513 RID: 62739 RVA: 0x0036CDF4 File Offset: 0x0036AFF4
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600F514 RID: 62740 RVA: 0x0036CE04 File Offset: 0x0036B004
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17004136 RID: 16694
		// (get) Token: 0x0600F515 RID: 62741 RVA: 0x0036CE1C File Offset: 0x0036B01C
		public string IconBig
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

		// Token: 0x0600F516 RID: 62742 RVA: 0x0036CE54 File Offset: 0x0036B054
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600F517 RID: 62743 RVA: 0x0036CE64 File Offset: 0x0036B064
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17004137 RID: 16695
		// (get) Token: 0x0600F518 RID: 62744 RVA: 0x0036CE7C File Offset: 0x0036B07C
		public string Mesh
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

		// Token: 0x0600F519 RID: 62745 RVA: 0x0036CEB4 File Offset: 0x0036B0B4
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600F51A RID: 62746 RVA: 0x0036CEC4 File Offset: 0x0036B0C4
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17004138 RID: 16696
		// (get) Token: 0x0600F51B RID: 62747 RVA: 0x0036CEDC File Offset: 0x0036B0DC
		public int MaxCapcity
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 999999999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F51C RID: 62748 RVA: 0x0036CF20 File Offset: 0x0036B120
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004139 RID: 16697
		// (get) Token: 0x0600F51D RID: 62749 RVA: 0x0036CF60 File Offset: 0x0036B160
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F51E RID: 62750 RVA: 0x0036CF8C File Offset: 0x0036B18C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(62, 4);
		}

		// Token: 0x0600F51F RID: 62751 RVA: 0x0036CF9C File Offset: 0x0036B19C
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(62) ?? Array.Empty<int>();
		}

		// Token: 0x1700413A RID: 16698
		// (get) Token: 0x0600F520 RID: 62752 RVA: 0x0036CFB4 File Offset: 0x0036B1B4
		public int ObtainedShow
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700413B RID: 16699
		// (get) Token: 0x0600F521 RID: 62753 RVA: 0x0036CFF4 File Offset: 0x0036B1F4
		public string ObtainedShowDescription
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

		// Token: 0x0600F522 RID: 62754 RVA: 0x0036D02C File Offset: 0x0036B22C
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600F523 RID: 62755 RVA: 0x0036D03C File Offset: 0x0036B23C
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x1700413C RID: 16700
		// (get) Token: 0x0600F524 RID: 62756 RVA: 0x0036D054 File Offset: 0x0036B254
		public int NumLimit
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700413D RID: 16701
		// (get) Token: 0x0600F525 RID: 62757 RVA: 0x0036D094 File Offset: 0x0036B294
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(70);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700413E RID: 16702
		// (get) Token: 0x0600F526 RID: 62758 RVA: 0x0036D0D4 File Offset: 0x0036B2D4
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700413F RID: 16703
		// (get) Token: 0x0600F527 RID: 62759 RVA: 0x0036D114 File Offset: 0x0036B314
		public string ResonanceIcon
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

		// Token: 0x0600F528 RID: 62760 RVA: 0x0036D14C File Offset: 0x0036B34C
		public Span<byte> GetResonanceIconBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600F529 RID: 62761 RVA: 0x0036D15C File Offset: 0x0036B35C
		public byte[] GetResonanceIconArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17004140 RID: 16704
		// (get) Token: 0x0600F52A RID: 62762 RVA: 0x0036D174 File Offset: 0x0036B374
		public float HiddenTime
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 10f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004141 RID: 16705
		// (get) Token: 0x0600F52B RID: 62763 RVA: 0x0036D1B8 File Offset: 0x0036B3B8
		public bool Destructible
		{
			get
			{
				int num = this.__p.__offset(78);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17004142 RID: 16706
		// (get) Token: 0x0600F52C RID: 62764 RVA: 0x0036D1F8 File Offset: 0x0036B3F8
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004143 RID: 16707
		// (get) Token: 0x0600F52D RID: 62765 RVA: 0x0036D238 File Offset: 0x0036B438
		public int HandBookTrialId
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 21110501;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F52E RID: 62766 RVA: 0x0036D279 File Offset: 0x0036B479
		[NullableContext(1)]
		public StringArray[] DescParams()
		{
			return this.DescParamsIter().ToArray<StringArray>();
		}

		// Token: 0x0600F52F RID: 62767 RVA: 0x0036D286 File Offset: 0x0036B486
		[NullableContext(1)]
		public IEnumerable<StringArray> DescParamsIter()
		{
			WeaponConf.<DescParamsIter>d__124 <DescParamsIter>d__ = new WeaponConf.<DescParamsIter>d__124(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600F530 RID: 62768 RVA: 0x0036D29B File Offset: 0x0036B49B
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600F531 RID: 62769 RVA: 0x0036D2A3 File Offset: 0x0036B4A3
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			WeaponConf.<ItemAccessIter>d__126 <ItemAccessIter>d__ = new WeaponConf.<ItemAccessIter>d__126(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600F532 RID: 62770 RVA: 0x0036D2B8 File Offset: 0x0036B4B8
		[NullableContext(1)]
		public int[] Models()
		{
			return this.GetModelsArray();
		}

		// Token: 0x0600F533 RID: 62771 RVA: 0x0036D2C0 File Offset: 0x0036B4C0
		[NullableContext(1)]
		public IEnumerable<int> ModelsIter()
		{
			WeaponConf.<ModelsIter>d__128 <ModelsIter>d__ = new WeaponConf.<ModelsIter>d__128(-2);
			<ModelsIter>d__.<>3__<>4__this = this;
			return <ModelsIter>d__;
		}

		// Token: 0x0600F534 RID: 62772 RVA: 0x0036D2D5 File Offset: 0x0036B4D5
		[NullableContext(1)]
		public int[] ModelsIndex()
		{
			return this.GetModelsIndexArray();
		}

		// Token: 0x0600F535 RID: 62773 RVA: 0x0036D2DD File Offset: 0x0036B4DD
		[NullableContext(1)]
		public IEnumerable<int> ModelsIndexIter()
		{
			WeaponConf.<ModelsIndexIter>d__130 <ModelsIndexIter>d__ = new WeaponConf.<ModelsIndexIter>d__130(-2);
			<ModelsIndexIter>d__.<>3__<>4__this = this;
			return <ModelsIndexIter>d__;
		}

		// Token: 0x0600F536 RID: 62774 RVA: 0x0036D2F2 File Offset: 0x0036B4F2
		[NullableContext(1)]
		public string[] StandAnim()
		{
			return this.StandAnimIter().ToArray<string>();
		}

		// Token: 0x0600F537 RID: 62775 RVA: 0x0036D2FF File Offset: 0x0036B4FF
		[NullableContext(1)]
		public IEnumerable<string> StandAnimIter()
		{
			WeaponConf.<StandAnimIter>d__132 <StandAnimIter>d__ = new WeaponConf.<StandAnimIter>d__132(-2);
			<StandAnimIter>d__.<>3__<>4__this = this;
			return <StandAnimIter>d__;
		}

		// Token: 0x04005920 RID: 22816
		private Table __p;
	}
}
