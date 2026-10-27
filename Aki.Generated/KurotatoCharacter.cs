using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D97 RID: 3479
	public struct KurotatoCharacter : IFlatbufferObject
	{
		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x060088BB RID: 35003 RVA: 0x0026C0A4 File Offset: 0x0026A2A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060088BC RID: 35004 RVA: 0x0026C0B1 File Offset: 0x0026A2B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060088BD RID: 35005 RVA: 0x0026C0B8 File Offset: 0x0026A2B8
		public static KurotatoCharacter GetRootAsKurotatoCharacter(ByteBuffer _bb)
		{
			return KurotatoCharacter.GetRootAsKurotatoCharacter(_bb, default(KurotatoCharacter));
		}

		// Token: 0x060088BE RID: 35006 RVA: 0x0026C0D4 File Offset: 0x0026A2D4
		public static KurotatoCharacter GetRootAsKurotatoCharacter(ByteBuffer _bb, KurotatoCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060088BF RID: 35007 RVA: 0x0026C0F1 File Offset: 0x0026A2F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060088C0 RID: 35008 RVA: 0x0026C100 File Offset: 0x0026A300
		public KurotatoCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x060088C1 RID: 35009 RVA: 0x0026C110 File Offset: 0x0026A310
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

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x060088C2 RID: 35010 RVA: 0x0026C14C File Offset: 0x0026A34C
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 3401;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x060088C3 RID: 35011 RVA: 0x0026C18C File Offset: 0x0026A38C
		public int BasicProperty
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

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x060088C4 RID: 35012 RVA: 0x0026C1C8 File Offset: 0x0026A3C8
		public int TemplateId
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

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x060088C5 RID: 35013 RVA: 0x0026C208 File Offset: 0x0026A408
		public int UnlockConditionId
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

		// Token: 0x060088C6 RID: 35014 RVA: 0x0026C248 File Offset: 0x0026A448
		public int InitItemIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x060088C7 RID: 35015 RVA: 0x0026C288 File Offset: 0x0026A488
		public int InitItemIdsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x0026C2B4 File Offset: 0x0026A4B4
		public Span<int> GetInitItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x0026C2C4 File Offset: 0x0026A4C4
		public int[] GetInitItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x060088CA RID: 35018 RVA: 0x0026C2DC File Offset: 0x0026A4DC
		public int InitWeaponIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x060088CB RID: 35019 RVA: 0x0026C31C File Offset: 0x0026A51C
		public int InitWeaponIdsLength
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

		// Token: 0x060088CC RID: 35020 RVA: 0x0026C348 File Offset: 0x0026A548
		public Span<int> GetInitWeaponIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060088CD RID: 35021 RVA: 0x0026C358 File Offset: 0x0026A558
		public int[] GetInitWeaponIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x060088CE RID: 35022 RVA: 0x0026C370 File Offset: 0x0026A570
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

		// Token: 0x060088CF RID: 35023 RVA: 0x0026C3A8 File Offset: 0x0026A5A8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060088D0 RID: 35024 RVA: 0x0026C3B8 File Offset: 0x0026A5B8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x060088D1 RID: 35025 RVA: 0x0026C3D0 File Offset: 0x0026A5D0
		public int SortId
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

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x060088D2 RID: 35026 RVA: 0x0026C410 File Offset: 0x0026A610
		public string Desc
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

		// Token: 0x060088D3 RID: 35027 RVA: 0x0026C448 File Offset: 0x0026A648
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060088D4 RID: 35028 RVA: 0x0026C458 File Offset: 0x0026A658
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060088D5 RID: 35029 RVA: 0x0026C470 File Offset: 0x0026A670
		public string DescParams(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x060088D6 RID: 35030 RVA: 0x0026C4AC File Offset: 0x0026A6AC
		public int DescParamsLength
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

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x060088D7 RID: 35031 RVA: 0x0026C4D8 File Offset: 0x0026A6D8
		public string Icon
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

		// Token: 0x060088D8 RID: 35032 RVA: 0x0026C510 File Offset: 0x0026A710
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x0026C520 File Offset: 0x0026A720
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x060088DA RID: 35034 RVA: 0x0026C538 File Offset: 0x0026A738
		public int RelatedCharacterId
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

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x060088DB RID: 35035 RVA: 0x0026C578 File Offset: 0x0026A778
		public int TrialRole
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

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x060088DC RID: 35036 RVA: 0x0026C5B8 File Offset: 0x0026A7B8
		public int Type
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

		// Token: 0x060088DD RID: 35037 RVA: 0x0026C5F8 File Offset: 0x0026A7F8
		public string ExcludedTags(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x060088DE RID: 35038 RVA: 0x0026C634 File Offset: 0x0026A834
		public int ExcludedTagsLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x0026C660 File Offset: 0x0026A860
		public string RecommendedTags(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x060088E0 RID: 35040 RVA: 0x0026C69C File Offset: 0x0026A89C
		public int RecommendedTagsLength
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

		// Token: 0x060088E1 RID: 35041 RVA: 0x0026C6C8 File Offset: 0x0026A8C8
		public int ExcludedRecommendWeaponIds(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x060088E2 RID: 35042 RVA: 0x0026C708 File Offset: 0x0026A908
		public int ExcludedRecommendWeaponIdsLength
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

		// Token: 0x060088E3 RID: 35043 RVA: 0x0026C734 File Offset: 0x0026A934
		public Span<int> GetExcludedRecommendWeaponIdsBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x0026C744 File Offset: 0x0026A944
		public int[] GetExcludedRecommendWeaponIdsArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x060088E5 RID: 35045 RVA: 0x0026C75C File Offset: 0x0026A95C
		public int ExcludedRecommendItemIds(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x060088E6 RID: 35046 RVA: 0x0026C79C File Offset: 0x0026A99C
		public int ExcludedRecommendItemIdsLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060088E7 RID: 35047 RVA: 0x0026C7C8 File Offset: 0x0026A9C8
		public Span<int> GetExcludedRecommendItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x060088E8 RID: 35048 RVA: 0x0026C7D8 File Offset: 0x0026A9D8
		public int[] GetExcludedRecommendItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x060088E9 RID: 35049 RVA: 0x0026C7F0 File Offset: 0x0026A9F0
		public int SimpleCombatSubtypeId
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x0026C830 File Offset: 0x0026AA30
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x060088EB RID: 35051 RVA: 0x0026C870 File Offset: 0x0026AA70
		public int InitBuffsLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060088EC RID: 35052 RVA: 0x0026C89C File Offset: 0x0026AA9C
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x060088ED RID: 35053 RVA: 0x0026C8AC File Offset: 0x0026AAAC
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x060088EE RID: 35054 RVA: 0x0026C8C4 File Offset: 0x0026AAC4
		public int MainProperty(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x060088EF RID: 35055 RVA: 0x0026C904 File Offset: 0x0026AB04
		public int MainPropertyLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060088F0 RID: 35056 RVA: 0x0026C930 File Offset: 0x0026AB30
		public Span<int> GetMainPropertyBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x060088F1 RID: 35057 RVA: 0x0026C940 File Offset: 0x0026AB40
		public int[] GetMainPropertyArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x060088F2 RID: 35058 RVA: 0x0026C958 File Offset: 0x0026AB58
		public int JumpLevelId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088F3 RID: 35059 RVA: 0x0026C995 File Offset: 0x0026AB95
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x060088F4 RID: 35060 RVA: 0x0026C9A2 File Offset: 0x0026ABA2
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamsIter()
		{
			KurotatoCharacter.<DescParamsIter>d__82 <DescParamsIter>d__ = new KurotatoCharacter.<DescParamsIter>d__82(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x060088F5 RID: 35061 RVA: 0x0026C9B8 File Offset: 0x0026ABB8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExcludedRecommendItemIdsIter()或GetExcludedRecommendItemIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExcludedRecommendItemIds()
		{
			KurotatoCharacter kurotatoCharacter = this;
			return kurotatoCharacter.GetExcludedRecommendItemIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060088F6 RID: 35062 RVA: 0x0026C9DC File Offset: 0x0026ABDC
		[NullableContext(1)]
		public readonly IEnumerable<int> ExcludedRecommendItemIdsIter()
		{
			KurotatoCharacter.<ExcludedRecommendItemIdsIter>d__84 <ExcludedRecommendItemIdsIter>d__ = new KurotatoCharacter.<ExcludedRecommendItemIdsIter>d__84(-2);
			<ExcludedRecommendItemIdsIter>d__.<>3__<>4__this = this;
			return <ExcludedRecommendItemIdsIter>d__;
		}

		// Token: 0x060088F7 RID: 35063 RVA: 0x0026C9F4 File Offset: 0x0026ABF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExcludedRecommendWeaponIdsIter()或GetExcludedRecommendWeaponIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExcludedRecommendWeaponIds()
		{
			KurotatoCharacter kurotatoCharacter = this;
			return kurotatoCharacter.GetExcludedRecommendWeaponIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x0026CA18 File Offset: 0x0026AC18
		[NullableContext(1)]
		public readonly IEnumerable<int> ExcludedRecommendWeaponIdsIter()
		{
			KurotatoCharacter.<ExcludedRecommendWeaponIdsIter>d__86 <ExcludedRecommendWeaponIdsIter>d__ = new KurotatoCharacter.<ExcludedRecommendWeaponIdsIter>d__86(-2);
			<ExcludedRecommendWeaponIdsIter>d__.<>3__<>4__this = this;
			return <ExcludedRecommendWeaponIdsIter>d__;
		}

		// Token: 0x060088F9 RID: 35065 RVA: 0x0026CA2D File Offset: 0x0026AC2D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExcludedTagsIter()或GetExcludedTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExcludedTags()
		{
			return this.ExcludedTagsIter().ToArray<string>();
		}

		// Token: 0x060088FA RID: 35066 RVA: 0x0026CA3A File Offset: 0x0026AC3A
		[NullableContext(1)]
		public readonly IEnumerable<string> ExcludedTagsIter()
		{
			KurotatoCharacter.<ExcludedTagsIter>d__88 <ExcludedTagsIter>d__ = new KurotatoCharacter.<ExcludedTagsIter>d__88(-2);
			<ExcludedTagsIter>d__.<>3__<>4__this = this;
			return <ExcludedTagsIter>d__;
		}

		// Token: 0x060088FB RID: 35067 RVA: 0x0026CA50 File Offset: 0x0026AC50
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitBuffsIter()或GetInitBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitBuffs()
		{
			KurotatoCharacter kurotatoCharacter = this;
			return kurotatoCharacter.GetInitBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x0026CA74 File Offset: 0x0026AC74
		[NullableContext(1)]
		public readonly IEnumerable<int> InitBuffsIter()
		{
			KurotatoCharacter.<InitBuffsIter>d__90 <InitBuffsIter>d__ = new KurotatoCharacter.<InitBuffsIter>d__90(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x060088FD RID: 35069 RVA: 0x0026CA8C File Offset: 0x0026AC8C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitItemIdsIter()或GetInitItemIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitItemIds()
		{
			KurotatoCharacter kurotatoCharacter = this;
			return kurotatoCharacter.GetInitItemIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060088FE RID: 35070 RVA: 0x0026CAB0 File Offset: 0x0026ACB0
		[NullableContext(1)]
		public readonly IEnumerable<int> InitItemIdsIter()
		{
			KurotatoCharacter.<InitItemIdsIter>d__92 <InitItemIdsIter>d__ = new KurotatoCharacter.<InitItemIdsIter>d__92(-2);
			<InitItemIdsIter>d__.<>3__<>4__this = this;
			return <InitItemIdsIter>d__;
		}

		// Token: 0x060088FF RID: 35071 RVA: 0x0026CAC8 File Offset: 0x0026ACC8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitWeaponIdsIter()或GetInitWeaponIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitWeaponIds()
		{
			KurotatoCharacter kurotatoCharacter = this;
			return kurotatoCharacter.GetInitWeaponIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x0026CAEC File Offset: 0x0026ACEC
		[NullableContext(1)]
		public readonly IEnumerable<int> InitWeaponIdsIter()
		{
			KurotatoCharacter.<InitWeaponIdsIter>d__94 <InitWeaponIdsIter>d__ = new KurotatoCharacter.<InitWeaponIdsIter>d__94(-2);
			<InitWeaponIdsIter>d__.<>3__<>4__this = this;
			return <InitWeaponIdsIter>d__;
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x0026CB04 File Offset: 0x0026AD04
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MainPropertyIter()或GetMainPropertyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MainProperty()
		{
			KurotatoCharacter kurotatoCharacter = this;
			return kurotatoCharacter.GetMainPropertyArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008902 RID: 35074 RVA: 0x0026CB28 File Offset: 0x0026AD28
		[NullableContext(1)]
		public readonly IEnumerable<int> MainPropertyIter()
		{
			KurotatoCharacter.<MainPropertyIter>d__96 <MainPropertyIter>d__ = new KurotatoCharacter.<MainPropertyIter>d__96(-2);
			<MainPropertyIter>d__.<>3__<>4__this = this;
			return <MainPropertyIter>d__;
		}

		// Token: 0x06008903 RID: 35075 RVA: 0x0026CB3D File Offset: 0x0026AD3D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendedTagsIter()或GetRecommendedTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] RecommendedTags()
		{
			return this.RecommendedTagsIter().ToArray<string>();
		}

		// Token: 0x06008904 RID: 35076 RVA: 0x0026CB4A File Offset: 0x0026AD4A
		[NullableContext(1)]
		public readonly IEnumerable<string> RecommendedTagsIter()
		{
			KurotatoCharacter.<RecommendedTagsIter>d__98 <RecommendedTagsIter>d__ = new KurotatoCharacter.<RecommendedTagsIter>d__98(-2);
			<RecommendedTagsIter>d__.<>3__<>4__this = this;
			return <RecommendedTagsIter>d__;
		}

		// Token: 0x04004E27 RID: 20007
		private Table __p;
	}
}
