using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C02 RID: 3074
	public struct BabelTowerLevel : IFlatbufferObject
	{
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060050BC RID: 20668 RVA: 0x001FDA8C File Offset: 0x001FBC8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x001FDA99 File Offset: 0x001FBC99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x001FDAA0 File Offset: 0x001FBCA0
		public static BabelTowerLevel GetRootAsBabelTowerLevel(ByteBuffer _bb)
		{
			return BabelTowerLevel.GetRootAsBabelTowerLevel(_bb, default(BabelTowerLevel));
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x001FDABC File Offset: 0x001FBCBC
		public static BabelTowerLevel GetRootAsBabelTowerLevel(ByteBuffer _bb, BabelTowerLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x001FDAD9 File Offset: 0x001FBCD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x001FDAE8 File Offset: 0x001FBCE8
		public BabelTowerLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060050C2 RID: 20674 RVA: 0x001FDAF8 File Offset: 0x001FBCF8
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

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060050C3 RID: 20675 RVA: 0x001FDB34 File Offset: 0x001FBD34
		public int ActivityId
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

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060050C4 RID: 20676 RVA: 0x001FDB70 File Offset: 0x001FBD70
		public int InstId
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

		// Token: 0x060050C5 RID: 20677 RVA: 0x001FDBAC File Offset: 0x001FBDAC
		public DicIntInt? MonstMaxLifeAddRatio(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060050C6 RID: 20678 RVA: 0x001FDC10 File Offset: 0x001FBE10
		public int MonstMaxLifeAddRatioLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060050C7 RID: 20679 RVA: 0x001FDC3C File Offset: 0x001FBE3C
		public bool IsDifficult
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060050C8 RID: 20680 RVA: 0x001FDC7C File Offset: 0x001FBE7C
		public string NameText
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

		// Token: 0x060050C9 RID: 20681 RVA: 0x001FDCB4 File Offset: 0x001FBEB4
		public Span<byte> GetNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x001FDCC4 File Offset: 0x001FBEC4
		public byte[] GetNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060050CB RID: 20683 RVA: 0x001FDCDC File Offset: 0x001FBEDC
		public string DesText
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

		// Token: 0x060050CC RID: 20684 RVA: 0x001FDD14 File Offset: 0x001FBF14
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x001FDD24 File Offset: 0x001FBF24
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060050CE RID: 20686 RVA: 0x001FDD3C File Offset: 0x001FBF3C
		public string LevelDesText
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

		// Token: 0x060050CF RID: 20687 RVA: 0x001FDD74 File Offset: 0x001FBF74
		public Span<byte> GetLevelDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x001FDD84 File Offset: 0x001FBF84
		public byte[] GetLevelDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060050D1 RID: 20689 RVA: 0x001FDD9C File Offset: 0x001FBF9C
		public string BossNameText
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

		// Token: 0x060050D2 RID: 20690 RVA: 0x001FDDD4 File Offset: 0x001FBFD4
		public Span<byte> GetBossNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x001FDDE4 File Offset: 0x001FBFE4
		public byte[] GetBossNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060050D4 RID: 20692 RVA: 0x001FDDFC File Offset: 0x001FBFFC
		public string Texture
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

		// Token: 0x060050D5 RID: 20693 RVA: 0x001FDE34 File Offset: 0x001FC034
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x001FDE44 File Offset: 0x001FC044
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060050D7 RID: 20695 RVA: 0x001FDE5C File Offset: 0x001FC05C
		public string BossTexture
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

		// Token: 0x060050D8 RID: 20696 RVA: 0x001FDE94 File Offset: 0x001FC094
		public Span<byte> GetBossTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x001FDEA4 File Offset: 0x001FC0A4
		public byte[] GetBossTextureArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060050DA RID: 20698 RVA: 0x001FDEBC File Offset: 0x001FC0BC
		public string BossTitleTexture
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

		// Token: 0x060050DB RID: 20699 RVA: 0x001FDEF4 File Offset: 0x001FC0F4
		public Span<byte> GetBossTitleTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x001FDF04 File Offset: 0x001FC104
		public byte[] GetBossTitleTextureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060050DD RID: 20701 RVA: 0x001FDF1C File Offset: 0x001FC11C
		public int OpenDay
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

		// Token: 0x060050DE RID: 20702 RVA: 0x001FDF5C File Offset: 0x001FC15C
		public int FixBabelDeTermds(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060050DF RID: 20703 RVA: 0x001FDF9C File Offset: 0x001FC19C
		public int FixBabelDeTermdsLength
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

		// Token: 0x060050E0 RID: 20704 RVA: 0x001FDFC8 File Offset: 0x001FC1C8
		public Span<int> GetFixBabelDeTermdsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x001FDFD8 File Offset: 0x001FC1D8
		public int[] GetFixBabelDeTermdsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x001FDFF0 File Offset: 0x001FC1F0
		public int OptionalBabelBuff(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060050E3 RID: 20707 RVA: 0x001FE030 File Offset: 0x001FC230
		public int OptionalBabelBuffLength
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

		// Token: 0x060050E4 RID: 20708 RVA: 0x001FE05C File Offset: 0x001FC25C
		public Span<int> GetOptionalBabelBuffBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x001FE06C File Offset: 0x001FC26C
		public int[] GetOptionalBabelBuffArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060050E6 RID: 20710 RVA: 0x001FE084 File Offset: 0x001FC284
		public int OptionalBabelBuffNum
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

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060050E7 RID: 20711 RVA: 0x001FE0C4 File Offset: 0x001FC2C4
		public int PassStar
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

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060050E8 RID: 20712 RVA: 0x001FE104 File Offset: 0x001FC304
		public int ReviveStar
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

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060050E9 RID: 20713 RVA: 0x001FE144 File Offset: 0x001FC344
		public int ReviveBuffId
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

		// Token: 0x060050EA RID: 20714 RVA: 0x001FE184 File Offset: 0x001FC384
		public int BabelTowerDeTermMutexArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060050EB RID: 20715 RVA: 0x001FE1C4 File Offset: 0x001FC3C4
		public int BabelTowerDeTermMutexArrayLength
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

		// Token: 0x060050EC RID: 20716 RVA: 0x001FE1F0 File Offset: 0x001FC3F0
		public Span<int> GetBabelTowerDeTermMutexArrayBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x001FE200 File Offset: 0x001FC400
		public int[] GetBabelTowerDeTermMutexArrayArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x001FE218 File Offset: 0x001FC418
		public int UnRecommendRoleList(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060050EF RID: 20719 RVA: 0x001FE258 File Offset: 0x001FC458
		public int UnRecommendRoleListLength
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

		// Token: 0x060050F0 RID: 20720 RVA: 0x001FE284 File Offset: 0x001FC484
		public Span<int> GetUnRecommendRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x001FE294 File Offset: 0x001FC494
		public int[] GetUnRecommendRoleListArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x001FE2AC File Offset: 0x001FC4AC
		public int RecommendBuff(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060050F3 RID: 20723 RVA: 0x001FE2EC File Offset: 0x001FC4EC
		public int RecommendBuffLength
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

		// Token: 0x060050F4 RID: 20724 RVA: 0x001FE318 File Offset: 0x001FC518
		public Span<int> GetRecommendBuffBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x001FE328 File Offset: 0x001FC528
		public int[] GetRecommendBuffArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x001FE340 File Offset: 0x001FC540
		[NullableContext(1)]
		public int[] BabelTowerDeTermMutexArray()
		{
			return this.GetBabelTowerDeTermMutexArrayArray();
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x001FE348 File Offset: 0x001FC548
		[NullableContext(1)]
		public IEnumerable<int> BabelTowerDeTermMutexArrayIter()
		{
			BabelTowerLevel.<BabelTowerDeTermMutexArrayIter>d__83 <BabelTowerDeTermMutexArrayIter>d__ = new BabelTowerLevel.<BabelTowerDeTermMutexArrayIter>d__83(-2);
			<BabelTowerDeTermMutexArrayIter>d__.<>3__<>4__this = this;
			return <BabelTowerDeTermMutexArrayIter>d__;
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x001FE35D File Offset: 0x001FC55D
		[NullableContext(1)]
		public int[] FixBabelDeTermds()
		{
			return this.GetFixBabelDeTermdsArray();
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x001FE365 File Offset: 0x001FC565
		[NullableContext(1)]
		public IEnumerable<int> FixBabelDeTermdsIter()
		{
			BabelTowerLevel.<FixBabelDeTermdsIter>d__85 <FixBabelDeTermdsIter>d__ = new BabelTowerLevel.<FixBabelDeTermdsIter>d__85(-2);
			<FixBabelDeTermdsIter>d__.<>3__<>4__this = this;
			return <FixBabelDeTermdsIter>d__;
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x001FE37C File Offset: 0x001FC57C
		[NullableContext(1)]
		public Dictionary<int, int> MonstMaxLifeAddRatio()
		{
			return this.MonstMaxLifeAddRatioIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x001FE3D2 File Offset: 0x001FC5D2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> MonstMaxLifeAddRatioIter()
		{
			BabelTowerLevel.<MonstMaxLifeAddRatioIter>d__87 <MonstMaxLifeAddRatioIter>d__ = new BabelTowerLevel.<MonstMaxLifeAddRatioIter>d__87(-2);
			<MonstMaxLifeAddRatioIter>d__.<>3__<>4__this = this;
			return <MonstMaxLifeAddRatioIter>d__;
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x001FE3E7 File Offset: 0x001FC5E7
		[NullableContext(1)]
		public int[] OptionalBabelBuff()
		{
			return this.GetOptionalBabelBuffArray();
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x001FE3EF File Offset: 0x001FC5EF
		[NullableContext(1)]
		public IEnumerable<int> OptionalBabelBuffIter()
		{
			BabelTowerLevel.<OptionalBabelBuffIter>d__89 <OptionalBabelBuffIter>d__ = new BabelTowerLevel.<OptionalBabelBuffIter>d__89(-2);
			<OptionalBabelBuffIter>d__.<>3__<>4__this = this;
			return <OptionalBabelBuffIter>d__;
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x001FE404 File Offset: 0x001FC604
		[NullableContext(1)]
		public int[] RecommendBuff()
		{
			return this.GetRecommendBuffArray();
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x001FE40C File Offset: 0x001FC60C
		[NullableContext(1)]
		public IEnumerable<int> RecommendBuffIter()
		{
			BabelTowerLevel.<RecommendBuffIter>d__91 <RecommendBuffIter>d__ = new BabelTowerLevel.<RecommendBuffIter>d__91(-2);
			<RecommendBuffIter>d__.<>3__<>4__this = this;
			return <RecommendBuffIter>d__;
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x001FE421 File Offset: 0x001FC621
		[NullableContext(1)]
		public int[] UnRecommendRoleList()
		{
			return this.GetUnRecommendRoleListArray();
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x001FE429 File Offset: 0x001FC629
		[NullableContext(1)]
		public IEnumerable<int> UnRecommendRoleListIter()
		{
			BabelTowerLevel.<UnRecommendRoleListIter>d__93 <UnRecommendRoleListIter>d__ = new BabelTowerLevel.<UnRecommendRoleListIter>d__93(-2);
			<UnRecommendRoleListIter>d__.<>3__<>4__this = this;
			return <UnRecommendRoleListIter>d__;
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x001FE440 File Offset: 0x001FC640
		public int? GetMonstMaxLifeAddRatio(int key)
		{
			this.EnsureMonstMaxLifeAddRatioCacheIfNeeded();
			int value;
			if (!this.MonstMaxLifeAddRatioCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x001FE474 File Offset: 0x001FC674
		private void EnsureMonstMaxLifeAddRatioCacheIfNeeded()
		{
			if (this.MonstMaxLifeAddRatioCache != null)
			{
				return;
			}
			this.MonstMaxLifeAddRatioCache = this.MonstMaxLifeAddRatioIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x001FE4DA File Offset: 0x001FC6DA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetMonstMaxLifeAddRatioFrozenDict()
		{
			this.EnsureMonstMaxLifeAddRatioCacheIfNeeded();
			return this.MonstMaxLifeAddRatioCache;
		}

		// Token: 0x040050F3 RID: 20723
		private Table __p;

		// Token: 0x040050F4 RID: 20724
		[Nullable(2)]
		private FrozenDictionary<int, int> MonstMaxLifeAddRatioCache;
	}
}
