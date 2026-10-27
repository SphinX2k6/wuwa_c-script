using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC1 RID: 3009
	public struct DangoBrawlItem : IFlatbufferObject
	{
		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06005D7E RID: 23934 RVA: 0x00209198 File Offset: 0x00207398
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x002091A5 File Offset: 0x002073A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x002091AC File Offset: 0x002073AC
		public static DangoBrawlItem GetRootAsDangoBrawlItem(ByteBuffer _bb)
		{
			return DangoBrawlItem.GetRootAsDangoBrawlItem(_bb, default(DangoBrawlItem));
		}

		// Token: 0x06005D81 RID: 23937 RVA: 0x002091C8 File Offset: 0x002073C8
		public static DangoBrawlItem GetRootAsDangoBrawlItem(ByteBuffer _bb, DangoBrawlItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x002091E5 File Offset: 0x002073E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x002091F4 File Offset: 0x002073F4
		public DangoBrawlItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06005D84 RID: 23940 RVA: 0x00209204 File Offset: 0x00207404
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

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06005D85 RID: 23941 RVA: 0x00209240 File Offset: 0x00207440
		public int ShapeTemplateId
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

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06005D86 RID: 23942 RVA: 0x0020927C File Offset: 0x0020747C
		public int Type
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

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06005D87 RID: 23943 RVA: 0x002092B8 File Offset: 0x002074B8
		public bool IsSpeItem
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06005D88 RID: 23944 RVA: 0x002092F8 File Offset: 0x002074F8
		public int SubType
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

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06005D89 RID: 23945 RVA: 0x00209338 File Offset: 0x00207538
		public int ActiveSkill
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

		// Token: 0x06005D8A RID: 23946 RVA: 0x00209378 File Offset: 0x00207578
		public ProAddEntry? AddAttr(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new ProAddEntry?(default(ProAddEntry).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06005D8B RID: 23947 RVA: 0x002093DC File Offset: 0x002075DC
		public int AddAttrLength
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

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06005D8C RID: 23948 RVA: 0x00209408 File Offset: 0x00207608
		public int Price
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

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06005D8D RID: 23949 RVA: 0x00209448 File Offset: 0x00207648
		public int Damage
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06005D8E RID: 23950 RVA: 0x00209488 File Offset: 0x00207688
		public int Cd
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

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06005D8F RID: 23951 RVA: 0x002094C8 File Offset: 0x002076C8
		public int Cost
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

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06005D90 RID: 23952 RVA: 0x00209508 File Offset: 0x00207708
		public int Quality
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

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06005D91 RID: 23953 RVA: 0x00209548 File Offset: 0x00207748
		public int OccupationId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x00209588 File Offset: 0x00207788
		public int ItemTags(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06005D93 RID: 23955 RVA: 0x002095C8 File Offset: 0x002077C8
		public int ItemTagsLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x002095F4 File Offset: 0x002077F4
		public Span<int> GetItemTagsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x00209604 File Offset: 0x00207804
		public int[] GetItemTagsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x0020961C File Offset: 0x0020781C
		public int EffectItemTag(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06005D97 RID: 23959 RVA: 0x0020965C File Offset: 0x0020785C
		public int EffectItemTagLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x00209688 File Offset: 0x00207888
		public Span<int> GetEffectItemTagBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x00209698 File Offset: 0x00207898
		public int[] GetEffectItemTagArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06005D9A RID: 23962 RVA: 0x002096B0 File Offset: 0x002078B0
		public bool EffectNoSameItem
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06005D9B RID: 23963 RVA: 0x002096F0 File Offset: 0x002078F0
		public string Icon
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

		// Token: 0x06005D9C RID: 23964 RVA: 0x00209728 File Offset: 0x00207928
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x00209738 File Offset: 0x00207938
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06005D9E RID: 23966 RVA: 0x00209750 File Offset: 0x00207950
		public string IconHandBook
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

		// Token: 0x06005D9F RID: 23967 RVA: 0x00209788 File Offset: 0x00207988
		public Span<byte> GetIconHandBookBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x00209798 File Offset: 0x00207998
		public byte[] GetIconHandBookArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06005DA1 RID: 23969 RVA: 0x002097B0 File Offset: 0x002079B0
		public string IconRaycast
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

		// Token: 0x06005DA2 RID: 23970 RVA: 0x002097E8 File Offset: 0x002079E8
		public Span<byte> GetIconRaycastBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x002097F8 File Offset: 0x002079F8
		public byte[] GetIconRaycastArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06005DA4 RID: 23972 RVA: 0x00209810 File Offset: 0x00207A10
		public float IconBackpackScale
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06005DA5 RID: 23973 RVA: 0x00209854 File Offset: 0x00207A54
		public float IconShopScale
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06005DA6 RID: 23974 RVA: 0x00209898 File Offset: 0x00207A98
		public float IconCombineScale
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06005DA7 RID: 23975 RVA: 0x002098DC File Offset: 0x00207ADC
		public float IconHandBookScale
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06005DA8 RID: 23976 RVA: 0x00209920 File Offset: 0x00207B20
		public float IconHandBookScale2
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06005DA9 RID: 23977 RVA: 0x00209964 File Offset: 0x00207B64
		public float IconOccupationScale
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06005DAA RID: 23978 RVA: 0x002099A8 File Offset: 0x00207BA8
		public float IconOccupationScale2
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06005DAB RID: 23979 RVA: 0x002099EC File Offset: 0x00207BEC
		public float IconRoleScale
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06005DAC RID: 23980 RVA: 0x00209A30 File Offset: 0x00207C30
		public float IconBattleScale
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06005DAD RID: 23981 RVA: 0x00209A74 File Offset: 0x00207C74
		public float IconRoleDetailScale
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06005DAE RID: 23982 RVA: 0x00209AB8 File Offset: 0x00207CB8
		public string Name
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

		// Token: 0x06005DAF RID: 23983 RVA: 0x00209AF0 File Offset: 0x00207CF0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x00209B00 File Offset: 0x00207D00
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x00209B18 File Offset: 0x00207D18
		public string SpeEffectDesc(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06005DB2 RID: 23986 RVA: 0x00209B54 File Offset: 0x00207D54
		public int SpeEffectDescLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x00209B80 File Offset: 0x00207D80
		public StringArray? SpeEffectDescParam(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06005DB4 RID: 23988 RVA: 0x00209BE4 File Offset: 0x00207DE4
		public int SpeEffectDescParamLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06005DB5 RID: 23989 RVA: 0x00209C10 File Offset: 0x00207E10
		public string StarDesc
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

		// Token: 0x06005DB6 RID: 23990 RVA: 0x00209C48 File Offset: 0x00207E48
		public Span<byte> GetStarDescBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x00209C58 File Offset: 0x00207E58
		public byte[] GetStarDescArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x00209C70 File Offset: 0x00207E70
		public string StarDescParam(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06005DB9 RID: 23993 RVA: 0x00209CAC File Offset: 0x00207EAC
		public int StarDescParamLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06005DBA RID: 23994 RVA: 0x00209CD8 File Offset: 0x00207ED8
		public bool IsShowInHandBook
		{
			get
			{
				int num = this.__p.__offset(72);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06005DBB RID: 23995 RVA: 0x00209D18 File Offset: 0x00207F18
		public int UIAnimShowType
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06005DBC RID: 23996 RVA: 0x00209D58 File Offset: 0x00207F58
		public string UIAnimSeqName
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

		// Token: 0x06005DBD RID: 23997 RVA: 0x00209D90 File Offset: 0x00207F90
		public Span<byte> GetUIAnimSeqNameBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x06005DBE RID: 23998 RVA: 0x00209DA0 File Offset: 0x00207FA0
		public byte[] GetUIAnimSeqNameArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06005DBF RID: 23999 RVA: 0x00209DB8 File Offset: 0x00207FB8
		public int UINiagaraType
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06005DC0 RID: 24000 RVA: 0x00209DF8 File Offset: 0x00207FF8
		public string UINiagaraPath
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

		// Token: 0x06005DC1 RID: 24001 RVA: 0x00209E30 File Offset: 0x00208030
		public Span<byte> GetUINiagaraPathBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x00209E40 File Offset: 0x00208040
		public byte[] GetUINiagaraPathArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x00209E58 File Offset: 0x00208058
		public int RecommendOccupation(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06005DC4 RID: 24004 RVA: 0x00209E98 File Offset: 0x00208098
		public int RecommendOccupationLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x00209EC4 File Offset: 0x002080C4
		public Span<int> GetRecommendOccupationBytes()
		{
			return this.__p.__vector_as_span<int>(82, 4);
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x00209ED4 File Offset: 0x002080D4
		public int[] GetRecommendOccupationArray()
		{
			return this.__p.__vector_as_array<int>(82) ?? Array.Empty<int>();
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06005DC7 RID: 24007 RVA: 0x00209EEC File Offset: 0x002080EC
		public bool IsBlockSell
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x00209F2C File Offset: 0x0020812C
		public IntArray? CDMaskRange(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06005DC9 RID: 24009 RVA: 0x00209F90 File Offset: 0x00208190
		public int CDMaskRangeLength
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x00209FBC File Offset: 0x002081BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AddAttrIter()或GetAddAttrBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ProAddEntry[] AddAttr()
		{
			return this.AddAttrIter().ToArray<ProAddEntry>();
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x00209FC9 File Offset: 0x002081C9
		[NullableContext(1)]
		public readonly IEnumerable<ProAddEntry> AddAttrIter()
		{
			DangoBrawlItem.<AddAttrIter>d__121 <AddAttrIter>d__ = new DangoBrawlItem.<AddAttrIter>d__121(-2);
			<AddAttrIter>d__.<>3__<>4__this = this;
			return <AddAttrIter>d__;
		}

		// Token: 0x06005DCC RID: 24012 RVA: 0x00209FDE File Offset: 0x002081DE
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CDMaskRangeIter()或GetCDMaskRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] CDMaskRange()
		{
			return this.CDMaskRangeIter().ToArray<IntArray>();
		}

		// Token: 0x06005DCD RID: 24013 RVA: 0x00209FEB File Offset: 0x002081EB
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> CDMaskRangeIter()
		{
			DangoBrawlItem.<CDMaskRangeIter>d__123 <CDMaskRangeIter>d__ = new DangoBrawlItem.<CDMaskRangeIter>d__123(-2);
			<CDMaskRangeIter>d__.<>3__<>4__this = this;
			return <CDMaskRangeIter>d__;
		}

		// Token: 0x06005DCE RID: 24014 RVA: 0x0020A000 File Offset: 0x00208200
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectItemTagIter()或GetEffectItemTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EffectItemTag()
		{
			DangoBrawlItem dangoBrawlItem = this;
			return dangoBrawlItem.GetEffectItemTagArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x0020A024 File Offset: 0x00208224
		[NullableContext(1)]
		public readonly IEnumerable<int> EffectItemTagIter()
		{
			DangoBrawlItem.<EffectItemTagIter>d__125 <EffectItemTagIter>d__ = new DangoBrawlItem.<EffectItemTagIter>d__125(-2);
			<EffectItemTagIter>d__.<>3__<>4__this = this;
			return <EffectItemTagIter>d__;
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x0020A03C File Offset: 0x0020823C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemTagsIter()或GetItemTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemTags()
		{
			DangoBrawlItem dangoBrawlItem = this;
			return dangoBrawlItem.GetItemTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x0020A060 File Offset: 0x00208260
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemTagsIter()
		{
			DangoBrawlItem.<ItemTagsIter>d__127 <ItemTagsIter>d__ = new DangoBrawlItem.<ItemTagsIter>d__127(-2);
			<ItemTagsIter>d__.<>3__<>4__this = this;
			return <ItemTagsIter>d__;
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x0020A078 File Offset: 0x00208278
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendOccupationIter()或GetRecommendOccupationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendOccupation()
		{
			DangoBrawlItem dangoBrawlItem = this;
			return dangoBrawlItem.GetRecommendOccupationArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x0020A09C File Offset: 0x0020829C
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendOccupationIter()
		{
			DangoBrawlItem.<RecommendOccupationIter>d__129 <RecommendOccupationIter>d__ = new DangoBrawlItem.<RecommendOccupationIter>d__129(-2);
			<RecommendOccupationIter>d__.<>3__<>4__this = this;
			return <RecommendOccupationIter>d__;
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x0020A0B1 File Offset: 0x002082B1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpeEffectDescIter()或GetSpeEffectDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SpeEffectDesc()
		{
			return this.SpeEffectDescIter().ToArray<string>();
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x0020A0BE File Offset: 0x002082BE
		[NullableContext(1)]
		public readonly IEnumerable<string> SpeEffectDescIter()
		{
			DangoBrawlItem.<SpeEffectDescIter>d__131 <SpeEffectDescIter>d__ = new DangoBrawlItem.<SpeEffectDescIter>d__131(-2);
			<SpeEffectDescIter>d__.<>3__<>4__this = this;
			return <SpeEffectDescIter>d__;
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x0020A0D3 File Offset: 0x002082D3
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpeEffectDescParamIter()或GetSpeEffectDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly StringArray[] SpeEffectDescParam()
		{
			return this.SpeEffectDescParamIter().ToArray<StringArray>();
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x0020A0E0 File Offset: 0x002082E0
		[NullableContext(1)]
		public readonly IEnumerable<StringArray> SpeEffectDescParamIter()
		{
			DangoBrawlItem.<SpeEffectDescParamIter>d__133 <SpeEffectDescParamIter>d__ = new DangoBrawlItem.<SpeEffectDescParamIter>d__133(-2);
			<SpeEffectDescParamIter>d__.<>3__<>4__this = this;
			return <SpeEffectDescParamIter>d__;
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x0020A0F5 File Offset: 0x002082F5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StarDescParamIter()或GetStarDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] StarDescParam()
		{
			return this.StarDescParamIter().ToArray<string>();
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x0020A102 File Offset: 0x00208302
		[NullableContext(1)]
		public readonly IEnumerable<string> StarDescParamIter()
		{
			DangoBrawlItem.<StarDescParamIter>d__135 <StarDescParamIter>d__ = new DangoBrawlItem.<StarDescParamIter>d__135(-2);
			<StarDescParamIter>d__.<>3__<>4__this = this;
			return <StarDescParamIter>d__;
		}

		// Token: 0x04004BEA RID: 19434
		private Table __p;
	}
}
