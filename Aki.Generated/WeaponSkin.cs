using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012D2 RID: 4818
	public struct WeaponSkin : IFlatbufferObject
	{
		// Token: 0x17004179 RID: 16761
		// (get) Token: 0x0600F5AF RID: 62895 RVA: 0x0036E41D File Offset: 0x0036C61D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F5B0 RID: 62896 RVA: 0x0036E42A File Offset: 0x0036C62A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F5B1 RID: 62897 RVA: 0x0036E434 File Offset: 0x0036C634
		public static WeaponSkin GetRootAsWeaponSkin(ByteBuffer _bb)
		{
			return WeaponSkin.GetRootAsWeaponSkin(_bb, default(WeaponSkin));
		}

		// Token: 0x0600F5B2 RID: 62898 RVA: 0x0036E450 File Offset: 0x0036C650
		public static WeaponSkin GetRootAsWeaponSkin(ByteBuffer _bb, WeaponSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F5B3 RID: 62899 RVA: 0x0036E46D File Offset: 0x0036C66D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F5B4 RID: 62900 RVA: 0x0036E47C File Offset: 0x0036C67C
		public WeaponSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700417A RID: 16762
		// (get) Token: 0x0600F5B5 RID: 62901 RVA: 0x0036E48C File Offset: 0x0036C68C
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

		// Token: 0x1700417B RID: 16763
		// (get) Token: 0x0600F5B6 RID: 62902 RVA: 0x0036E4C8 File Offset: 0x0036C6C8
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700417C RID: 16764
		// (get) Token: 0x0600F5B7 RID: 62903 RVA: 0x0036E508 File Offset: 0x0036C708
		public int WeaponSkinType
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

		// Token: 0x1700417D RID: 16765
		// (get) Token: 0x0600F5B8 RID: 62904 RVA: 0x0036E544 File Offset: 0x0036C744
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

		// Token: 0x0600F5B9 RID: 62905 RVA: 0x0036E57C File Offset: 0x0036C77C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F5BA RID: 62906 RVA: 0x0036E58C File Offset: 0x0036C78C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700417E RID: 16766
		// (get) Token: 0x0600F5BB RID: 62907 RVA: 0x0036E5A4 File Offset: 0x0036C7A4
		public bool HideInSkinView
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700417F RID: 16767
		// (get) Token: 0x0600F5BC RID: 62908 RVA: 0x0036E5E4 File Offset: 0x0036C7E4
		public int QualityId
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

		// Token: 0x17004180 RID: 16768
		// (get) Token: 0x0600F5BD RID: 62909 RVA: 0x0036E624 File Offset: 0x0036C824
		public int ModelId
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

		// Token: 0x17004181 RID: 16769
		// (get) Token: 0x0600F5BE RID: 62910 RVA: 0x0036E664 File Offset: 0x0036C864
		public int TransformId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F5BF RID: 62911 RVA: 0x0036E6A4 File Offset: 0x0036C8A4
		public int Models(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004182 RID: 16770
		// (get) Token: 0x0600F5C0 RID: 62912 RVA: 0x0036E6E4 File Offset: 0x0036C8E4
		public int ModelsLength
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

		// Token: 0x0600F5C1 RID: 62913 RVA: 0x0036E710 File Offset: 0x0036C910
		public Span<int> GetModelsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600F5C2 RID: 62914 RVA: 0x0036E720 File Offset: 0x0036C920
		public int[] GetModelsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600F5C3 RID: 62915 RVA: 0x0036E738 File Offset: 0x0036C938
		public int ModelsIndex(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004183 RID: 16771
		// (get) Token: 0x0600F5C4 RID: 62916 RVA: 0x0036E778 File Offset: 0x0036C978
		public int ModelsIndexLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F5C5 RID: 62917 RVA: 0x0036E7A4 File Offset: 0x0036C9A4
		public Span<int> GetModelsIndexBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600F5C6 RID: 62918 RVA: 0x0036E7B4 File Offset: 0x0036C9B4
		public int[] GetModelsIndexArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600F5C7 RID: 62919 RVA: 0x0036E7CC File Offset: 0x0036C9CC
		public long Effect(int j)
		{
			int num = this.__p.__offset(24);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17004184 RID: 16772
		// (get) Token: 0x0600F5C8 RID: 62920 RVA: 0x0036E818 File Offset: 0x0036CA18
		public int EffectLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F5C9 RID: 62921 RVA: 0x0036E844 File Offset: 0x0036CA44
		public Span<long> GetEffectBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(24, 8));
		}

		// Token: 0x0600F5CA RID: 62922 RVA: 0x0036E859 File Offset: 0x0036CA59
		public long[] GetEffectArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(24) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600F5CB RID: 62923 RVA: 0x0036E898 File Offset: 0x0036CA98
		public string StandAnim(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004185 RID: 16773
		// (get) Token: 0x0600F5CC RID: 62924 RVA: 0x0036E8D4 File Offset: 0x0036CAD4
		public int StandAnimLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17004186 RID: 16774
		// (get) Token: 0x0600F5CD RID: 62925 RVA: 0x0036E900 File Offset: 0x0036CB00
		public string TypeDescription
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

		// Token: 0x0600F5CE RID: 62926 RVA: 0x0036E938 File Offset: 0x0036CB38
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600F5CF RID: 62927 RVA: 0x0036E948 File Offset: 0x0036CB48
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17004187 RID: 16775
		// (get) Token: 0x0600F5D0 RID: 62928 RVA: 0x0036E960 File Offset: 0x0036CB60
		public string AttributesDescription
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

		// Token: 0x0600F5D1 RID: 62929 RVA: 0x0036E998 File Offset: 0x0036CB98
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600F5D2 RID: 62930 RVA: 0x0036E9A8 File Offset: 0x0036CBA8
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17004188 RID: 16776
		// (get) Token: 0x0600F5D3 RID: 62931 RVA: 0x0036E9C0 File Offset: 0x0036CBC0
		public string BgDescription
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

		// Token: 0x0600F5D4 RID: 62932 RVA: 0x0036E9F8 File Offset: 0x0036CBF8
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600F5D5 RID: 62933 RVA: 0x0036EA08 File Offset: 0x0036CC08
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17004189 RID: 16777
		// (get) Token: 0x0600F5D6 RID: 62934 RVA: 0x0036EA20 File Offset: 0x0036CC20
		public string CardIconPath
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

		// Token: 0x0600F5D7 RID: 62935 RVA: 0x0036EA58 File Offset: 0x0036CC58
		public Span<byte> GetCardIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600F5D8 RID: 62936 RVA: 0x0036EA68 File Offset: 0x0036CC68
		public byte[] GetCardIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700418A RID: 16778
		// (get) Token: 0x0600F5D9 RID: 62937 RVA: 0x0036EA80 File Offset: 0x0036CC80
		public string IconBig
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

		// Token: 0x0600F5DA RID: 62938 RVA: 0x0036EAB8 File Offset: 0x0036CCB8
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600F5DB RID: 62939 RVA: 0x0036EAC8 File Offset: 0x0036CCC8
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700418B RID: 16779
		// (get) Token: 0x0600F5DC RID: 62940 RVA: 0x0036EAE0 File Offset: 0x0036CCE0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F5DD RID: 62941 RVA: 0x0036EB18 File Offset: 0x0036CD18
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600F5DE RID: 62942 RVA: 0x0036EB28 File Offset: 0x0036CD28
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700418C RID: 16780
		// (get) Token: 0x0600F5DF RID: 62943 RVA: 0x0036EB40 File Offset: 0x0036CD40
		public string IconMiddle
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

		// Token: 0x0600F5E0 RID: 62944 RVA: 0x0036EB78 File Offset: 0x0036CD78
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600F5E1 RID: 62945 RVA: 0x0036EB88 File Offset: 0x0036CD88
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x1700418D RID: 16781
		// (get) Token: 0x0600F5E2 RID: 62946 RVA: 0x0036EBA0 File Offset: 0x0036CDA0
		public string IconSmall
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

		// Token: 0x0600F5E3 RID: 62947 RVA: 0x0036EBD8 File Offset: 0x0036CDD8
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600F5E4 RID: 62948 RVA: 0x0036EBE8 File Offset: 0x0036CDE8
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700418E RID: 16782
		// (get) Token: 0x0600F5E5 RID: 62949 RVA: 0x0036EC00 File Offset: 0x0036CE00
		public string Mesh
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

		// Token: 0x0600F5E6 RID: 62950 RVA: 0x0036EC38 File Offset: 0x0036CE38
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600F5E7 RID: 62951 RVA: 0x0036EC48 File Offset: 0x0036CE48
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700418F RID: 16783
		// (get) Token: 0x0600F5E8 RID: 62952 RVA: 0x0036EC60 File Offset: 0x0036CE60
		public int MaxCapcity
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 99;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F5E9 RID: 62953 RVA: 0x0036ECA0 File Offset: 0x0036CEA0
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004190 RID: 16784
		// (get) Token: 0x0600F5EA RID: 62954 RVA: 0x0036ECE0 File Offset: 0x0036CEE0
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F5EB RID: 62955 RVA: 0x0036ED0C File Offset: 0x0036CF0C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x0600F5EC RID: 62956 RVA: 0x0036ED1C File Offset: 0x0036CF1C
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x17004191 RID: 16785
		// (get) Token: 0x0600F5ED RID: 62957 RVA: 0x0036ED34 File Offset: 0x0036CF34
		public int ObtainedShow
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004192 RID: 16786
		// (get) Token: 0x0600F5EE RID: 62958 RVA: 0x0036ED74 File Offset: 0x0036CF74
		public string ObtainedShowDescription
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

		// Token: 0x0600F5EF RID: 62959 RVA: 0x0036EDAC File Offset: 0x0036CFAC
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600F5F0 RID: 62960 RVA: 0x0036EDBC File Offset: 0x0036CFBC
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17004193 RID: 16787
		// (get) Token: 0x0600F5F1 RID: 62961 RVA: 0x0036EDD4 File Offset: 0x0036CFD4
		public int NumLimit
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004194 RID: 16788
		// (get) Token: 0x0600F5F2 RID: 62962 RVA: 0x0036EE14 File Offset: 0x0036D014
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(56);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17004195 RID: 16789
		// (get) Token: 0x0600F5F3 RID: 62963 RVA: 0x0036EE54 File Offset: 0x0036D054
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004196 RID: 16790
		// (get) Token: 0x0600F5F4 RID: 62964 RVA: 0x0036EE94 File Offset: 0x0036D094
		public float HiddenTime
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 10f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004197 RID: 16791
		// (get) Token: 0x0600F5F5 RID: 62965 RVA: 0x0036EED8 File Offset: 0x0036D0D8
		public bool Destructible
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17004198 RID: 16792
		// (get) Token: 0x0600F5F6 RID: 62966 RVA: 0x0036EF18 File Offset: 0x0036D118
		public int RedDotDisableRule
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

		// Token: 0x17004199 RID: 16793
		// (get) Token: 0x0600F5F7 RID: 62967 RVA: 0x0036EF58 File Offset: 0x0036D158
		public int HandBookTrialId
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 21110501;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F5F8 RID: 62968 RVA: 0x0036EF99 File Offset: 0x0036D199
		[NullableContext(1)]
		public long[] Effect()
		{
			return this.GetEffectArray();
		}

		// Token: 0x0600F5F9 RID: 62969 RVA: 0x0036EFA1 File Offset: 0x0036D1A1
		[NullableContext(1)]
		public IEnumerable<long> EffectIter()
		{
			WeaponSkin.<EffectIter>d__108 <EffectIter>d__ = new WeaponSkin.<EffectIter>d__108(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x0600F5FA RID: 62970 RVA: 0x0036EFB6 File Offset: 0x0036D1B6
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600F5FB RID: 62971 RVA: 0x0036EFBE File Offset: 0x0036D1BE
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			WeaponSkin.<ItemAccessIter>d__110 <ItemAccessIter>d__ = new WeaponSkin.<ItemAccessIter>d__110(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600F5FC RID: 62972 RVA: 0x0036EFD3 File Offset: 0x0036D1D3
		[NullableContext(1)]
		public int[] Models()
		{
			return this.GetModelsArray();
		}

		// Token: 0x0600F5FD RID: 62973 RVA: 0x0036EFDB File Offset: 0x0036D1DB
		[NullableContext(1)]
		public IEnumerable<int> ModelsIter()
		{
			WeaponSkin.<ModelsIter>d__112 <ModelsIter>d__ = new WeaponSkin.<ModelsIter>d__112(-2);
			<ModelsIter>d__.<>3__<>4__this = this;
			return <ModelsIter>d__;
		}

		// Token: 0x0600F5FE RID: 62974 RVA: 0x0036EFF0 File Offset: 0x0036D1F0
		[NullableContext(1)]
		public int[] ModelsIndex()
		{
			return this.GetModelsIndexArray();
		}

		// Token: 0x0600F5FF RID: 62975 RVA: 0x0036EFF8 File Offset: 0x0036D1F8
		[NullableContext(1)]
		public IEnumerable<int> ModelsIndexIter()
		{
			WeaponSkin.<ModelsIndexIter>d__114 <ModelsIndexIter>d__ = new WeaponSkin.<ModelsIndexIter>d__114(-2);
			<ModelsIndexIter>d__.<>3__<>4__this = this;
			return <ModelsIndexIter>d__;
		}

		// Token: 0x0600F600 RID: 62976 RVA: 0x0036F00D File Offset: 0x0036D20D
		[NullableContext(1)]
		public string[] StandAnim()
		{
			return this.StandAnimIter().ToArray<string>();
		}

		// Token: 0x0600F601 RID: 62977 RVA: 0x0036F01A File Offset: 0x0036D21A
		[NullableContext(1)]
		public IEnumerable<string> StandAnimIter()
		{
			WeaponSkin.<StandAnimIter>d__116 <StandAnimIter>d__ = new WeaponSkin.<StandAnimIter>d__116(-2);
			<StandAnimIter>d__.<>3__<>4__this = this;
			return <StandAnimIter>d__;
		}

		// Token: 0x0400592A RID: 22826
		private Table __p;
	}
}
