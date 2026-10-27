using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F36 RID: 3894
	public struct PinballRoleConfig : IFlatbufferObject
	{
		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x0600AFF1 RID: 45041 RVA: 0x002C4016 File Offset: 0x002C2216
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AFF2 RID: 45042 RVA: 0x002C4023 File Offset: 0x002C2223
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AFF3 RID: 45043 RVA: 0x002C402C File Offset: 0x002C222C
		public static PinballRoleConfig GetRootAsPinballRoleConfig(ByteBuffer _bb)
		{
			return PinballRoleConfig.GetRootAsPinballRoleConfig(_bb, default(PinballRoleConfig));
		}

		// Token: 0x0600AFF4 RID: 45044 RVA: 0x002C4048 File Offset: 0x002C2248
		public static PinballRoleConfig GetRootAsPinballRoleConfig(ByteBuffer _bb, PinballRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AFF5 RID: 45045 RVA: 0x002C4065 File Offset: 0x002C2265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AFF6 RID: 45046 RVA: 0x002C4074 File Offset: 0x002C2274
		public PinballRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x0600AFF7 RID: 45047 RVA: 0x002C4084 File Offset: 0x002C2284
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

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x0600AFF8 RID: 45048 RVA: 0x002C40C0 File Offset: 0x002C22C0
		public int SubId
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

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x0600AFF9 RID: 45049 RVA: 0x002C40FC File Offset: 0x002C22FC
		public int ActivityId
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

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x0600AFFA RID: 45050 RVA: 0x002C4138 File Offset: 0x002C2338
		public int InitLevelId
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

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x0600AFFB RID: 45051 RVA: 0x002C4178 File Offset: 0x002C2378
		public int GradeUpGroup
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

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x0600AFFC RID: 45052 RVA: 0x002C41B8 File Offset: 0x002C23B8
		public int RoleId
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

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x0600AFFD RID: 45053 RVA: 0x002C41F8 File Offset: 0x002C23F8
		public int QualityId
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

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x0600AFFE RID: 45054 RVA: 0x002C4238 File Offset: 0x002C2438
		public string AttributesDescription
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

		// Token: 0x0600AFFF RID: 45055 RVA: 0x002C4270 File Offset: 0x002C2470
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B000 RID: 45056 RVA: 0x002C4280 File Offset: 0x002C2480
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x0600B001 RID: 45057 RVA: 0x002C4298 File Offset: 0x002C2498
		public int WeaponType
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

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x0600B002 RID: 45058 RVA: 0x002C42D8 File Offset: 0x002C24D8
		public int InitWeapon
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

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x0600B003 RID: 45059 RVA: 0x002C4318 File Offset: 0x002C2518
		public int PersonWeaponType
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

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x0600B004 RID: 45060 RVA: 0x002C4358 File Offset: 0x002C2558
		public int Bd
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

		// Token: 0x0600B005 RID: 45061 RVA: 0x002C4398 File Offset: 0x002C2598
		public int PinballClass(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x0600B006 RID: 45062 RVA: 0x002C43D8 File Offset: 0x002C25D8
		public int PinballClassLength
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

		// Token: 0x0600B007 RID: 45063 RVA: 0x002C4404 File Offset: 0x002C2604
		public Span<int> GetPinballClassBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600B008 RID: 45064 RVA: 0x002C4414 File Offset: 0x002C2614
		public int[] GetPinballClassArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600B009 RID: 45065 RVA: 0x002C442C File Offset: 0x002C262C
		public int SkillDisplayList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x0600B00A RID: 45066 RVA: 0x002C446C File Offset: 0x002C266C
		public int SkillDisplayListLength
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

		// Token: 0x0600B00B RID: 45067 RVA: 0x002C4498 File Offset: 0x002C2698
		public Span<int> GetSkillDisplayListBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600B00C RID: 45068 RVA: 0x002C44A8 File Offset: 0x002C26A8
		public int[] GetSkillDisplayListArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x0600B00D RID: 45069 RVA: 0x002C44C0 File Offset: 0x002C26C0
		public bool IsTrail
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x0600B00E RID: 45070 RVA: 0x002C4500 File Offset: 0x002C2700
		public string SpineAtlasPath
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

		// Token: 0x0600B00F RID: 45071 RVA: 0x002C4538 File Offset: 0x002C2738
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600B010 RID: 45072 RVA: 0x002C4548 File Offset: 0x002C2748
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x0600B011 RID: 45073 RVA: 0x002C4560 File Offset: 0x002C2760
		public string SpineSkeletonDataPath
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

		// Token: 0x0600B012 RID: 45074 RVA: 0x002C4598 File Offset: 0x002C2798
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600B013 RID: 45075 RVA: 0x002C45A8 File Offset: 0x002C27A8
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x0600B014 RID: 45076 RVA: 0x002C45C0 File Offset: 0x002C27C0
		public string SmallIcon
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

		// Token: 0x0600B015 RID: 45077 RVA: 0x002C45F8 File Offset: 0x002C27F8
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600B016 RID: 45078 RVA: 0x002C4608 File Offset: 0x002C2808
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x0600B017 RID: 45079 RVA: 0x002C4620 File Offset: 0x002C2820
		public string MiddleIcon
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

		// Token: 0x0600B018 RID: 45080 RVA: 0x002C4658 File Offset: 0x002C2858
		public Span<byte> GetMiddleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600B019 RID: 45081 RVA: 0x002C4668 File Offset: 0x002C2868
		public byte[] GetMiddleIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x0600B01A RID: 45082 RVA: 0x002C4680 File Offset: 0x002C2880
		public string Icon
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

		// Token: 0x0600B01B RID: 45083 RVA: 0x002C46B8 File Offset: 0x002C28B8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x002C46C8 File Offset: 0x002C28C8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x0600B01D RID: 45085 RVA: 0x002C46E0 File Offset: 0x002C28E0
		public string BigIcon
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

		// Token: 0x0600B01E RID: 45086 RVA: 0x002C4718 File Offset: 0x002C2918
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600B01F RID: 45087 RVA: 0x002C4728 File Offset: 0x002C2928
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x0600B020 RID: 45088 RVA: 0x002C4740 File Offset: 0x002C2940
		public string CircleIcon
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

		// Token: 0x0600B021 RID: 45089 RVA: 0x002C4778 File Offset: 0x002C2978
		public Span<byte> GetCircleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600B022 RID: 45090 RVA: 0x002C4788 File Offset: 0x002C2988
		public byte[] GetCircleIconArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x0600B023 RID: 45091 RVA: 0x002C47A0 File Offset: 0x002C29A0
		public int SortId
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

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x0600B024 RID: 45092 RVA: 0x002C47E0 File Offset: 0x002C29E0
		public int TemplateId
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

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x0600B025 RID: 45093 RVA: 0x002C4820 File Offset: 0x002C2A20
		public int SimpleCombatSubtypeId
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x002C4860 File Offset: 0x002C2A60
		public string FailBubbleTxts(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x0600B027 RID: 45095 RVA: 0x002C489C File Offset: 0x002C2A9C
		public int FailBubbleTxtsLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x0600B028 RID: 45096 RVA: 0x002C48C8 File Offset: 0x002C2AC8
		public string RoleSkillIcon
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

		// Token: 0x0600B029 RID: 45097 RVA: 0x002C4900 File Offset: 0x002C2B00
		public Span<byte> GetRoleSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600B02A RID: 45098 RVA: 0x002C4910 File Offset: 0x002C2B10
		public byte[] GetRoleSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x0600B02B RID: 45099 RVA: 0x002C4928 File Offset: 0x002C2B28
		public string RoleSkillReleaseIcon
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

		// Token: 0x0600B02C RID: 45100 RVA: 0x002C4960 File Offset: 0x002C2B60
		public Span<byte> GetRoleSkillReleaseIconBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600B02D RID: 45101 RVA: 0x002C4970 File Offset: 0x002C2B70
		public byte[] GetRoleSkillReleaseIconArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x0600B02E RID: 45102 RVA: 0x002C4988 File Offset: 0x002C2B88
		public string RoleSkillReleaseDesc
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

		// Token: 0x0600B02F RID: 45103 RVA: 0x002C49C0 File Offset: 0x002C2BC0
		public Span<byte> GetRoleSkillReleaseDescBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600B030 RID: 45104 RVA: 0x002C49D0 File Offset: 0x002C2BD0
		public byte[] GetRoleSkillReleaseDescArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x0600B031 RID: 45105 RVA: 0x002C49E8 File Offset: 0x002C2BE8
		public int KscEntityId
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B032 RID: 45106 RVA: 0x002C4A28 File Offset: 0x002C2C28
		public int BornBuff(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x0600B033 RID: 45107 RVA: 0x002C4A68 File Offset: 0x002C2C68
		public int BornBuffLength
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

		// Token: 0x0600B034 RID: 45108 RVA: 0x002C4A94 File Offset: 0x002C2C94
		public Span<int> GetBornBuffBytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x0600B035 RID: 45109 RVA: 0x002C4AA4 File Offset: 0x002C2CA4
		public int[] GetBornBuffArray()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x0600B036 RID: 45110 RVA: 0x002C4ABC File Offset: 0x002C2CBC
		public int LeaderBuff(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x0600B037 RID: 45111 RVA: 0x002C4AFC File Offset: 0x002C2CFC
		public int LeaderBuffLength
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

		// Token: 0x0600B038 RID: 45112 RVA: 0x002C4B28 File Offset: 0x002C2D28
		public Span<int> GetLeaderBuffBytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x0600B039 RID: 45113 RVA: 0x002C4B38 File Offset: 0x002C2D38
		public int[] GetLeaderBuffArray()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x0600B03A RID: 45114 RVA: 0x002C4B50 File Offset: 0x002C2D50
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornBuffIter()或GetBornBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BornBuff()
		{
			PinballRoleConfig pinballRoleConfig = this;
			return pinballRoleConfig.GetBornBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B03B RID: 45115 RVA: 0x002C4B74 File Offset: 0x002C2D74
		[NullableContext(1)]
		public readonly IEnumerable<int> BornBuffIter()
		{
			PinballRoleConfig.<BornBuffIter>d__108 <BornBuffIter>d__ = new PinballRoleConfig.<BornBuffIter>d__108(-2);
			<BornBuffIter>d__.<>3__<>4__this = this;
			return <BornBuffIter>d__;
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x002C4B89 File Offset: 0x002C2D89
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FailBubbleTxtsIter()或GetFailBubbleTxtsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FailBubbleTxts()
		{
			return this.FailBubbleTxtsIter().ToArray<string>();
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x002C4B96 File Offset: 0x002C2D96
		[NullableContext(1)]
		public readonly IEnumerable<string> FailBubbleTxtsIter()
		{
			PinballRoleConfig.<FailBubbleTxtsIter>d__110 <FailBubbleTxtsIter>d__ = new PinballRoleConfig.<FailBubbleTxtsIter>d__110(-2);
			<FailBubbleTxtsIter>d__.<>3__<>4__this = this;
			return <FailBubbleTxtsIter>d__;
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x002C4BAC File Offset: 0x002C2DAC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LeaderBuffIter()或GetLeaderBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LeaderBuff()
		{
			PinballRoleConfig pinballRoleConfig = this;
			return pinballRoleConfig.GetLeaderBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B03F RID: 45119 RVA: 0x002C4BD0 File Offset: 0x002C2DD0
		[NullableContext(1)]
		public readonly IEnumerable<int> LeaderBuffIter()
		{
			PinballRoleConfig.<LeaderBuffIter>d__112 <LeaderBuffIter>d__ = new PinballRoleConfig.<LeaderBuffIter>d__112(-2);
			<LeaderBuffIter>d__.<>3__<>4__this = this;
			return <LeaderBuffIter>d__;
		}

		// Token: 0x0600B040 RID: 45120 RVA: 0x002C4BE8 File Offset: 0x002C2DE8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PinballClassIter()或GetPinballClassBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PinballClass()
		{
			PinballRoleConfig pinballRoleConfig = this;
			return pinballRoleConfig.GetPinballClassArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B041 RID: 45121 RVA: 0x002C4C0C File Offset: 0x002C2E0C
		[NullableContext(1)]
		public readonly IEnumerable<int> PinballClassIter()
		{
			PinballRoleConfig.<PinballClassIter>d__114 <PinballClassIter>d__ = new PinballRoleConfig.<PinballClassIter>d__114(-2);
			<PinballClassIter>d__.<>3__<>4__this = this;
			return <PinballClassIter>d__;
		}

		// Token: 0x0600B042 RID: 45122 RVA: 0x002C4C24 File Offset: 0x002C2E24
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillDisplayListIter()或GetSkillDisplayListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillDisplayList()
		{
			PinballRoleConfig pinballRoleConfig = this;
			return pinballRoleConfig.GetSkillDisplayListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B043 RID: 45123 RVA: 0x002C4C48 File Offset: 0x002C2E48
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillDisplayListIter()
		{
			PinballRoleConfig.<SkillDisplayListIter>d__116 <SkillDisplayListIter>d__ = new PinballRoleConfig.<SkillDisplayListIter>d__116(-2);
			<SkillDisplayListIter>d__.<>3__<>4__this = this;
			return <SkillDisplayListIter>d__;
		}

		// Token: 0x04005000 RID: 20480
		private Table __p;
	}
}
