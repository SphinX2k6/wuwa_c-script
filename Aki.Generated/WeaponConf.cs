using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001192 RID: 4498
	public struct WeaponConf : IFlatbufferObject
	{
		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x0600E76F RID: 59247 RVA: 0x0034171C File Offset: 0x0033F91C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E770 RID: 59248 RVA: 0x00341729 File Offset: 0x0033F929
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E771 RID: 59249 RVA: 0x00341730 File Offset: 0x0033F930
		public static WeaponConf GetRootAsWeaponConf(ByteBuffer _bb)
		{
			return WeaponConf.GetRootAsWeaponConf(_bb, default(WeaponConf));
		}

		// Token: 0x0600E772 RID: 59250 RVA: 0x0034174C File Offset: 0x0033F94C
		public static WeaponConf GetRootAsWeaponConf(ByteBuffer _bb, WeaponConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E773 RID: 59251 RVA: 0x00341769 File Offset: 0x0033F969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E774 RID: 59252 RVA: 0x00341778 File Offset: 0x0033F978
		public WeaponConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x0600E775 RID: 59253 RVA: 0x00341788 File Offset: 0x0033F988
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

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x0600E776 RID: 59254 RVA: 0x003417C4 File Offset: 0x0033F9C4
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x0600E777 RID: 59255 RVA: 0x00341804 File Offset: 0x0033FA04
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

		// Token: 0x0600E778 RID: 59256 RVA: 0x0034183B File Offset: 0x0033FA3B
		public Span<byte> GetWeaponNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E779 RID: 59257 RVA: 0x0034184A File Offset: 0x0033FA4A
		public byte[] GetWeaponNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x0600E77A RID: 59258 RVA: 0x00341864 File Offset: 0x0033FA64
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

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x0600E77B RID: 59259 RVA: 0x003418A4 File Offset: 0x0033FAA4
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

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x0600E77C RID: 59260 RVA: 0x003418E4 File Offset: 0x0033FAE4
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

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x0600E77D RID: 59261 RVA: 0x00341924 File Offset: 0x0033FB24
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

		// Token: 0x0600E77E RID: 59262 RVA: 0x00341964 File Offset: 0x0033FB64
		public int Models(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x0600E77F RID: 59263 RVA: 0x003419A4 File Offset: 0x0033FBA4
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

		// Token: 0x0600E780 RID: 59264 RVA: 0x003419D0 File Offset: 0x0033FBD0
		public Span<int> GetModelsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E781 RID: 59265 RVA: 0x003419E0 File Offset: 0x0033FBE0
		public int[] GetModelsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600E782 RID: 59266 RVA: 0x003419F8 File Offset: 0x0033FBF8
		public int ModelsIndex(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x0600E783 RID: 59267 RVA: 0x00341A38 File Offset: 0x0033FC38
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

		// Token: 0x0600E784 RID: 59268 RVA: 0x00341A64 File Offset: 0x0033FC64
		public Span<int> GetModelsIndexBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E785 RID: 59269 RVA: 0x00341A74 File Offset: 0x0033FC74
		public int[] GetModelsIndexArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x0600E786 RID: 59270 RVA: 0x00341A8C File Offset: 0x0033FC8C
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

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x0600E787 RID: 59271 RVA: 0x00341ACC File Offset: 0x0033FCCC
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

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x0600E788 RID: 59272 RVA: 0x00341B2C File Offset: 0x0033FD2C
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

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x0600E789 RID: 59273 RVA: 0x00341B6C File Offset: 0x0033FD6C
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

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x0600E78A RID: 59274 RVA: 0x00341BCC File Offset: 0x0033FDCC
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

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x0600E78B RID: 59275 RVA: 0x00341C0C File Offset: 0x0033FE0C
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

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x0600E78C RID: 59276 RVA: 0x00341C4C File Offset: 0x0033FE4C
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

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x0600E78D RID: 59277 RVA: 0x00341C8C File Offset: 0x0033FE8C
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

		// Token: 0x0600E78E RID: 59278 RVA: 0x00341CCC File Offset: 0x0033FECC
		public string StandAnim(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x0600E78F RID: 59279 RVA: 0x00341D08 File Offset: 0x0033FF08
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

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x0600E790 RID: 59280 RVA: 0x00341D34 File Offset: 0x0033FF34
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

		// Token: 0x0600E791 RID: 59281 RVA: 0x00341D6C File Offset: 0x0033FF6C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600E792 RID: 59282 RVA: 0x00341D7C File Offset: 0x0033FF7C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E793 RID: 59283 RVA: 0x00341D94 File Offset: 0x0033FF94
		public StringArray? DescParams(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x0600E794 RID: 59284 RVA: 0x00341DF8 File Offset: 0x0033FFF8
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

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x0600E795 RID: 59285 RVA: 0x00341E24 File Offset: 0x00340024
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

		// Token: 0x0600E796 RID: 59286 RVA: 0x00341E5C File Offset: 0x0034005C
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600E797 RID: 59287 RVA: 0x00341E6C File Offset: 0x0034006C
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x0600E798 RID: 59288 RVA: 0x00341E84 File Offset: 0x00340084
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

		// Token: 0x0600E799 RID: 59289 RVA: 0x00341EBC File Offset: 0x003400BC
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600E79A RID: 59290 RVA: 0x00341ECC File Offset: 0x003400CC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x0600E79B RID: 59291 RVA: 0x00341EE4 File Offset: 0x003400E4
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

		// Token: 0x0600E79C RID: 59292 RVA: 0x00341F1C File Offset: 0x0034011C
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600E79D RID: 59293 RVA: 0x00341F2C File Offset: 0x0034012C
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x0600E79E RID: 59294 RVA: 0x00341F44 File Offset: 0x00340144
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

		// Token: 0x0600E79F RID: 59295 RVA: 0x00341F7C File Offset: 0x0034017C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600E7A0 RID: 59296 RVA: 0x00341F8C File Offset: 0x0034018C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x0600E7A1 RID: 59297 RVA: 0x00341FA4 File Offset: 0x003401A4
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

		// Token: 0x0600E7A2 RID: 59298 RVA: 0x00341FDC File Offset: 0x003401DC
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600E7A3 RID: 59299 RVA: 0x00341FEC File Offset: 0x003401EC
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x0600E7A4 RID: 59300 RVA: 0x00342004 File Offset: 0x00340204
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

		// Token: 0x0600E7A5 RID: 59301 RVA: 0x0034203C File Offset: 0x0034023C
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600E7A6 RID: 59302 RVA: 0x0034204C File Offset: 0x0034024C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x0600E7A7 RID: 59303 RVA: 0x00342064 File Offset: 0x00340264
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

		// Token: 0x0600E7A8 RID: 59304 RVA: 0x0034209C File Offset: 0x0034029C
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600E7A9 RID: 59305 RVA: 0x003420AC File Offset: 0x003402AC
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x0600E7AA RID: 59306 RVA: 0x003420C4 File Offset: 0x003402C4
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

		// Token: 0x0600E7AB RID: 59307 RVA: 0x003420FC File Offset: 0x003402FC
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600E7AC RID: 59308 RVA: 0x0034210C File Offset: 0x0034030C
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x0600E7AD RID: 59309 RVA: 0x00342124 File Offset: 0x00340324
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

		// Token: 0x0600E7AE RID: 59310 RVA: 0x00342168 File Offset: 0x00340368
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x0600E7AF RID: 59311 RVA: 0x003421A8 File Offset: 0x003403A8
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

		// Token: 0x0600E7B0 RID: 59312 RVA: 0x003421D4 File Offset: 0x003403D4
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(62, 4);
		}

		// Token: 0x0600E7B1 RID: 59313 RVA: 0x003421E4 File Offset: 0x003403E4
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(62) ?? Array.Empty<int>();
		}

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x0600E7B2 RID: 59314 RVA: 0x003421FC File Offset: 0x003403FC
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

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x0600E7B3 RID: 59315 RVA: 0x0034223C File Offset: 0x0034043C
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

		// Token: 0x0600E7B4 RID: 59316 RVA: 0x00342274 File Offset: 0x00340474
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600E7B5 RID: 59317 RVA: 0x00342284 File Offset: 0x00340484
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x0600E7B6 RID: 59318 RVA: 0x0034229C File Offset: 0x0034049C
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

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x0600E7B7 RID: 59319 RVA: 0x003422DC File Offset: 0x003404DC
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(70);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x0600E7B8 RID: 59320 RVA: 0x0034231C File Offset: 0x0034051C
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

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x0600E7B9 RID: 59321 RVA: 0x0034235C File Offset: 0x0034055C
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

		// Token: 0x0600E7BA RID: 59322 RVA: 0x00342394 File Offset: 0x00340594
		public Span<byte> GetResonanceIconBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600E7BB RID: 59323 RVA: 0x003423A4 File Offset: 0x003405A4
		public byte[] GetResonanceIconArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x0600E7BC RID: 59324 RVA: 0x003423BC File Offset: 0x003405BC
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

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x0600E7BD RID: 59325 RVA: 0x00342400 File Offset: 0x00340600
		public bool Destructible
		{
			get
			{
				int num = this.__p.__offset(78);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x0600E7BE RID: 59326 RVA: 0x00342440 File Offset: 0x00340640
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

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x0600E7BF RID: 59327 RVA: 0x00342480 File Offset: 0x00340680
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

		// Token: 0x0600E7C0 RID: 59328 RVA: 0x003424C1 File Offset: 0x003406C1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly StringArray[] DescParams()
		{
			return this.DescParamsIter().ToArray<StringArray>();
		}

		// Token: 0x0600E7C1 RID: 59329 RVA: 0x003424CE File Offset: 0x003406CE
		[NullableContext(1)]
		public readonly IEnumerable<StringArray> DescParamsIter()
		{
			WeaponConf.<DescParamsIter>d__124 <DescParamsIter>d__ = new WeaponConf.<DescParamsIter>d__124(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600E7C2 RID: 59330 RVA: 0x003424E4 File Offset: 0x003406E4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			WeaponConf weaponConf = this;
			return weaponConf.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E7C3 RID: 59331 RVA: 0x00342508 File Offset: 0x00340708
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			WeaponConf.<ItemAccessIter>d__126 <ItemAccessIter>d__ = new WeaponConf.<ItemAccessIter>d__126(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600E7C4 RID: 59332 RVA: 0x00342520 File Offset: 0x00340720
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ModelsIter()或GetModelsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Models()
		{
			WeaponConf weaponConf = this;
			return weaponConf.GetModelsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E7C5 RID: 59333 RVA: 0x00342544 File Offset: 0x00340744
		[NullableContext(1)]
		public readonly IEnumerable<int> ModelsIter()
		{
			WeaponConf.<ModelsIter>d__128 <ModelsIter>d__ = new WeaponConf.<ModelsIter>d__128(-2);
			<ModelsIter>d__.<>3__<>4__this = this;
			return <ModelsIter>d__;
		}

		// Token: 0x0600E7C6 RID: 59334 RVA: 0x0034255C File Offset: 0x0034075C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ModelsIndexIter()或GetModelsIndexBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ModelsIndex()
		{
			WeaponConf weaponConf = this;
			return weaponConf.GetModelsIndexArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E7C7 RID: 59335 RVA: 0x00342580 File Offset: 0x00340780
		[NullableContext(1)]
		public readonly IEnumerable<int> ModelsIndexIter()
		{
			WeaponConf.<ModelsIndexIter>d__130 <ModelsIndexIter>d__ = new WeaponConf.<ModelsIndexIter>d__130(-2);
			<ModelsIndexIter>d__.<>3__<>4__this = this;
			return <ModelsIndexIter>d__;
		}

		// Token: 0x0600E7C8 RID: 59336 RVA: 0x00342595 File Offset: 0x00340795
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StandAnimIter()或GetStandAnimBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] StandAnim()
		{
			return this.StandAnimIter().ToArray<string>();
		}

		// Token: 0x0600E7C9 RID: 59337 RVA: 0x003425A2 File Offset: 0x003407A2
		[NullableContext(1)]
		public readonly IEnumerable<string> StandAnimIter()
		{
			WeaponConf.<StandAnimIter>d__132 <StandAnimIter>d__ = new WeaponConf.<StandAnimIter>d__132(-2);
			<StandAnimIter>d__.<>3__<>4__this = this;
			return <StandAnimIter>d__;
		}

		// Token: 0x040052DD RID: 21213
		private Table __p;
	}
}
