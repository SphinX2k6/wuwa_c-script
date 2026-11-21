using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012AF RID: 4783
	public struct TrialRoleInfo : IFlatbufferObject
	{
		// Token: 0x17004042 RID: 16450
		// (get) Token: 0x0600F2D9 RID: 62169 RVA: 0x0036792D File Offset: 0x00365B2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F2DA RID: 62170 RVA: 0x0036793A File Offset: 0x00365B3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F2DB RID: 62171 RVA: 0x00367944 File Offset: 0x00365B44
		public static TrialRoleInfo GetRootAsTrialRoleInfo(ByteBuffer _bb)
		{
			return TrialRoleInfo.GetRootAsTrialRoleInfo(_bb, default(TrialRoleInfo));
		}

		// Token: 0x0600F2DC RID: 62172 RVA: 0x00367960 File Offset: 0x00365B60
		public static TrialRoleInfo GetRootAsTrialRoleInfo(ByteBuffer _bb, TrialRoleInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F2DD RID: 62173 RVA: 0x0036797D File Offset: 0x00365B7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F2DE RID: 62174 RVA: 0x0036798C File Offset: 0x00365B8C
		public TrialRoleInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004043 RID: 16451
		// (get) Token: 0x0600F2DF RID: 62175 RVA: 0x0036799C File Offset: 0x00365B9C
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

		// Token: 0x17004044 RID: 16452
		// (get) Token: 0x0600F2E0 RID: 62176 RVA: 0x003679D8 File Offset: 0x00365BD8
		public int GroupId
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

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x0600F2E1 RID: 62177 RVA: 0x00367A14 File Offset: 0x00365C14
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004046 RID: 16454
		// (get) Token: 0x0600F2E2 RID: 62178 RVA: 0x00367A50 File Offset: 0x00365C50
		public int WorldLevel
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004047 RID: 16455
		// (get) Token: 0x0600F2E3 RID: 62179 RVA: 0x00367A90 File Offset: 0x00365C90
		public int Gender
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x0600F2E4 RID: 62180 RVA: 0x00367AD0 File Offset: 0x00365CD0
		public bool OnlyTrial
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x0600F2E5 RID: 62181 RVA: 0x00367B10 File Offset: 0x00365D10
		public bool HideTrialLabel
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700404A RID: 16458
		// (get) Token: 0x0600F2E6 RID: 62182 RVA: 0x00367B50 File Offset: 0x00365D50
		public int ParentId
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

		// Token: 0x1700404B RID: 16459
		// (get) Token: 0x0600F2E7 RID: 62183 RVA: 0x00367B90 File Offset: 0x00365D90
		public int Level
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

		// Token: 0x1700404C RID: 16460
		// (get) Token: 0x0600F2E8 RID: 62184 RVA: 0x00367BD0 File Offset: 0x00365DD0
		public int ResonanceLevel
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

		// Token: 0x1700404D RID: 16461
		// (get) Token: 0x0600F2E9 RID: 62185 RVA: 0x00367C10 File Offset: 0x00365E10
		public int UnlockSkillLevel
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F2EA RID: 62186 RVA: 0x00367C50 File Offset: 0x00365E50
		public int UnlockSkillNodeList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700404E RID: 16462
		// (get) Token: 0x0600F2EB RID: 62187 RVA: 0x00367C90 File Offset: 0x00365E90
		public int UnlockSkillNodeListLength
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

		// Token: 0x0600F2EC RID: 62188 RVA: 0x00367CBC File Offset: 0x00365EBC
		public Span<int> GetUnlockSkillNodeListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600F2ED RID: 62189 RVA: 0x00367CCC File Offset: 0x00365ECC
		public int[] GetUnlockSkillNodeListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x1700404F RID: 16463
		// (get) Token: 0x0600F2EE RID: 62190 RVA: 0x00367CE4 File Offset: 0x00365EE4
		public int DefaultSkillBranchId
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

		// Token: 0x17004050 RID: 16464
		// (get) Token: 0x0600F2EF RID: 62191 RVA: 0x00367D24 File Offset: 0x00365F24
		public int RoleSkin
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

		// Token: 0x17004051 RID: 16465
		// (get) Token: 0x0600F2F0 RID: 62192 RVA: 0x00367D64 File Offset: 0x00365F64
		public int TrailWeapon
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

		// Token: 0x0600F2F1 RID: 62193 RVA: 0x00367DA4 File Offset: 0x00365FA4
		public IntPair? PhantomEquipList(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004052 RID: 16466
		// (get) Token: 0x0600F2F2 RID: 62194 RVA: 0x00367E08 File Offset: 0x00366008
		public int PhantomEquipListLength
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

		// Token: 0x17004053 RID: 16467
		// (get) Token: 0x0600F2F3 RID: 62195 RVA: 0x00367E34 File Offset: 0x00366034
		public string SpinePrefabResource
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

		// Token: 0x0600F2F4 RID: 62196 RVA: 0x00367E6C File Offset: 0x0036606C
		public Span<byte> GetSpinePrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600F2F5 RID: 62197 RVA: 0x00367E7C File Offset: 0x0036607C
		public byte[] GetSpinePrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17004054 RID: 16468
		// (get) Token: 0x0600F2F6 RID: 62198 RVA: 0x00367E94 File Offset: 0x00366094
		public string ContentTexturePath
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

		// Token: 0x0600F2F7 RID: 62199 RVA: 0x00367ECC File Offset: 0x003660CC
		public Span<byte> GetContentTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600F2F8 RID: 62200 RVA: 0x00367EDC File Offset: 0x003660DC
		public byte[] GetContentTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F2F9 RID: 62201 RVA: 0x00367EF4 File Offset: 0x003660F4
		[NullableContext(1)]
		public IntPair[] PhantomEquipList()
		{
			return this.PhantomEquipListIter().ToArray<IntPair>();
		}

		// Token: 0x0600F2FA RID: 62202 RVA: 0x00367F01 File Offset: 0x00366101
		[NullableContext(1)]
		public IEnumerable<IntPair> PhantomEquipListIter()
		{
			TrialRoleInfo.<PhantomEquipListIter>d__53 <PhantomEquipListIter>d__ = new TrialRoleInfo.<PhantomEquipListIter>d__53(-2);
			<PhantomEquipListIter>d__.<>3__<>4__this = this;
			return <PhantomEquipListIter>d__;
		}

		// Token: 0x0600F2FB RID: 62203 RVA: 0x00367F16 File Offset: 0x00366116
		[NullableContext(1)]
		public int[] UnlockSkillNodeList()
		{
			return this.GetUnlockSkillNodeListArray();
		}

		// Token: 0x0600F2FC RID: 62204 RVA: 0x00367F1E File Offset: 0x0036611E
		[NullableContext(1)]
		public IEnumerable<int> UnlockSkillNodeListIter()
		{
			TrialRoleInfo.<UnlockSkillNodeListIter>d__55 <UnlockSkillNodeListIter>d__ = new TrialRoleInfo.<UnlockSkillNodeListIter>d__55(-2);
			<UnlockSkillNodeListIter>d__.<>3__<>4__this = this;
			return <UnlockSkillNodeListIter>d__;
		}

		// Token: 0x04005902 RID: 22786
		private Table __p;
	}
}
