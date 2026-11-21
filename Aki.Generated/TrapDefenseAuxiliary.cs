using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200128A RID: 4746
	public struct TrapDefenseAuxiliary : IFlatbufferObject
	{
		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x0600EF76 RID: 61302 RVA: 0x0036051C File Offset: 0x0035E71C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EF77 RID: 61303 RVA: 0x00360529 File Offset: 0x0035E729
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EF78 RID: 61304 RVA: 0x00360530 File Offset: 0x0035E730
		public static TrapDefenseAuxiliary GetRootAsTrapDefenseAuxiliary(ByteBuffer _bb)
		{
			return TrapDefenseAuxiliary.GetRootAsTrapDefenseAuxiliary(_bb, default(TrapDefenseAuxiliary));
		}

		// Token: 0x0600EF79 RID: 61305 RVA: 0x0036054C File Offset: 0x0035E74C
		public static TrapDefenseAuxiliary GetRootAsTrapDefenseAuxiliary(ByteBuffer _bb, TrapDefenseAuxiliary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EF7A RID: 61306 RVA: 0x00360569 File Offset: 0x0035E769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EF7B RID: 61307 RVA: 0x00360578 File Offset: 0x0035E778
		public TrapDefenseAuxiliary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x0600EF7C RID: 61308 RVA: 0x00360588 File Offset: 0x0035E788
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

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x0600EF7D RID: 61309 RVA: 0x003605C4 File Offset: 0x0035E7C4
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF7E RID: 61310 RVA: 0x003605FB File Offset: 0x0035E7FB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EF7F RID: 61311 RVA: 0x0036060A File Offset: 0x0035E80A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EF80 RID: 61312 RVA: 0x00360624 File Offset: 0x0035E824
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x0600EF81 RID: 61313 RVA: 0x00360660 File Offset: 0x0035E860
		public int DescArgsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x0600EF82 RID: 61314 RVA: 0x0036068C File Offset: 0x0035E88C
		public string DescDetail
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

		// Token: 0x0600EF83 RID: 61315 RVA: 0x003606C4 File Offset: 0x0035E8C4
		public Span<byte> GetDescDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EF84 RID: 61316 RVA: 0x003606D4 File Offset: 0x0035E8D4
		public byte[] GetDescDetailArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EF85 RID: 61317 RVA: 0x003606EC File Offset: 0x0035E8EC
		public string DescDetailArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x0600EF86 RID: 61318 RVA: 0x00360728 File Offset: 0x0035E928
		public int DescDetailArgsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x0600EF87 RID: 61319 RVA: 0x00360754 File Offset: 0x0035E954
		public int AuxiliaryType
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

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x0600EF88 RID: 61320 RVA: 0x00360794 File Offset: 0x0035E994
		public int SimpleCombatSubtypeId
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

		// Token: 0x0600EF89 RID: 61321 RVA: 0x003607D4 File Offset: 0x0035E9D4
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x0600EF8A RID: 61322 RVA: 0x00360814 File Offset: 0x0035EA14
		public int InitBuffsLength
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

		// Token: 0x0600EF8B RID: 61323 RVA: 0x00360840 File Offset: 0x0035EA40
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600EF8C RID: 61324 RVA: 0x00360850 File Offset: 0x0035EA50
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x0600EF8D RID: 61325 RVA: 0x00360868 File Offset: 0x0035EA68
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

		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x0600EF8E RID: 61326 RVA: 0x003608A8 File Offset: 0x0035EAA8
		public int Branch
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

		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x0600EF8F RID: 61327 RVA: 0x003608E8 File Offset: 0x0035EAE8
		public string BranchDesc
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

		// Token: 0x0600EF90 RID: 61328 RVA: 0x00360920 File Offset: 0x0035EB20
		public Span<byte> GetBranchDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600EF91 RID: 61329 RVA: 0x00360930 File Offset: 0x0035EB30
		public byte[] GetBranchDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EF92 RID: 61330 RVA: 0x00360948 File Offset: 0x0035EB48
		public string BranchDescArgs(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x0600EF93 RID: 61331 RVA: 0x00360984 File Offset: 0x0035EB84
		public int BranchDescArgsLength
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

		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x0600EF94 RID: 61332 RVA: 0x003609B0 File Offset: 0x0035EBB0
		public float CoolDown
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x0600EF95 RID: 61333 RVA: 0x003609F4 File Offset: 0x0035EBF4
		public int UpgradeCost
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

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x0600EF96 RID: 61334 RVA: 0x00360A34 File Offset: 0x0035EC34
		public int ConstructDefaultCost
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

		// Token: 0x0600EF97 RID: 61335 RVA: 0x00360A74 File Offset: 0x0035EC74
		public int InitSkills(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F11 RID: 16145
		// (get) Token: 0x0600EF98 RID: 61336 RVA: 0x00360AB4 File Offset: 0x0035ECB4
		public int InitSkillsLength
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

		// Token: 0x0600EF99 RID: 61337 RVA: 0x00360AE0 File Offset: 0x0035ECE0
		public Span<int> GetInitSkillsBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600EF9A RID: 61338 RVA: 0x00360AF0 File Offset: 0x0035ECF0
		public int[] GetInitSkillsArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x17003F12 RID: 16146
		// (get) Token: 0x0600EF9B RID: 61339 RVA: 0x00360B08 File Offset: 0x0035ED08
		public int InitProperty
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

		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x0600EF9C RID: 61340 RVA: 0x00360B48 File Offset: 0x0035ED48
		public int CDSkill
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

		// Token: 0x0600EF9D RID: 61341 RVA: 0x00360B88 File Offset: 0x0035ED88
		public int CueIds(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x0600EF9E RID: 61342 RVA: 0x00360BC8 File Offset: 0x0035EDC8
		public int CueIdsLength
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

		// Token: 0x0600EF9F RID: 61343 RVA: 0x00360BF4 File Offset: 0x0035EDF4
		public Span<int> GetCueIdsBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600EFA0 RID: 61344 RVA: 0x00360C04 File Offset: 0x0035EE04
		public int[] GetCueIdsArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x0600EFA1 RID: 61345 RVA: 0x00360C1C File Offset: 0x0035EE1C
		public int CDCueId(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x0600EFA2 RID: 61346 RVA: 0x00360C5C File Offset: 0x0035EE5C
		public int CDCueIdLength
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

		// Token: 0x0600EFA3 RID: 61347 RVA: 0x00360C88 File Offset: 0x0035EE88
		public Span<int> GetCDCueIdBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600EFA4 RID: 61348 RVA: 0x00360C98 File Offset: 0x0035EE98
		public int[] GetCDCueIdArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x0600EFA5 RID: 61349 RVA: 0x00360CB0 File Offset: 0x0035EEB0
		public int ReadyCueId(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x0600EFA6 RID: 61350 RVA: 0x00360CF0 File Offset: 0x0035EEF0
		public int ReadyCueIdLength
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

		// Token: 0x0600EFA7 RID: 61351 RVA: 0x00360D1C File Offset: 0x0035EF1C
		public Span<int> GetReadyCueIdBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600EFA8 RID: 61352 RVA: 0x00360D2C File Offset: 0x0035EF2C
		public int[] GetReadyCueIdArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x0600EFA9 RID: 61353 RVA: 0x00360D44 File Offset: 0x0035EF44
		[NullableContext(1)]
		public string[] BranchDescArgs()
		{
			return this.BranchDescArgsIter().ToArray<string>();
		}

		// Token: 0x0600EFAA RID: 61354 RVA: 0x00360D51 File Offset: 0x0035EF51
		[NullableContext(1)]
		public IEnumerable<string> BranchDescArgsIter()
		{
			TrapDefenseAuxiliary.<BranchDescArgsIter>d__75 <BranchDescArgsIter>d__ = new TrapDefenseAuxiliary.<BranchDescArgsIter>d__75(-2);
			<BranchDescArgsIter>d__.<>3__<>4__this = this;
			return <BranchDescArgsIter>d__;
		}

		// Token: 0x0600EFAB RID: 61355 RVA: 0x00360D66 File Offset: 0x0035EF66
		[NullableContext(1)]
		public int[] CDCueId()
		{
			return this.GetCDCueIdArray();
		}

		// Token: 0x0600EFAC RID: 61356 RVA: 0x00360D6E File Offset: 0x0035EF6E
		[NullableContext(1)]
		public IEnumerable<int> CDCueIdIter()
		{
			TrapDefenseAuxiliary.<CDCueIdIter>d__77 <CDCueIdIter>d__ = new TrapDefenseAuxiliary.<CDCueIdIter>d__77(-2);
			<CDCueIdIter>d__.<>3__<>4__this = this;
			return <CDCueIdIter>d__;
		}

		// Token: 0x0600EFAD RID: 61357 RVA: 0x00360D83 File Offset: 0x0035EF83
		[NullableContext(1)]
		public int[] CueIds()
		{
			return this.GetCueIdsArray();
		}

		// Token: 0x0600EFAE RID: 61358 RVA: 0x00360D8B File Offset: 0x0035EF8B
		[NullableContext(1)]
		public IEnumerable<int> CueIdsIter()
		{
			TrapDefenseAuxiliary.<CueIdsIter>d__79 <CueIdsIter>d__ = new TrapDefenseAuxiliary.<CueIdsIter>d__79(-2);
			<CueIdsIter>d__.<>3__<>4__this = this;
			return <CueIdsIter>d__;
		}

		// Token: 0x0600EFAF RID: 61359 RVA: 0x00360DA0 File Offset: 0x0035EFA0
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600EFB0 RID: 61360 RVA: 0x00360DAD File Offset: 0x0035EFAD
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			TrapDefenseAuxiliary.<DescArgsIter>d__81 <DescArgsIter>d__ = new TrapDefenseAuxiliary.<DescArgsIter>d__81(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600EFB1 RID: 61361 RVA: 0x00360DC2 File Offset: 0x0035EFC2
		[NullableContext(1)]
		public string[] DescDetailArgs()
		{
			return this.DescDetailArgsIter().ToArray<string>();
		}

		// Token: 0x0600EFB2 RID: 61362 RVA: 0x00360DCF File Offset: 0x0035EFCF
		[NullableContext(1)]
		public IEnumerable<string> DescDetailArgsIter()
		{
			TrapDefenseAuxiliary.<DescDetailArgsIter>d__83 <DescDetailArgsIter>d__ = new TrapDefenseAuxiliary.<DescDetailArgsIter>d__83(-2);
			<DescDetailArgsIter>d__.<>3__<>4__this = this;
			return <DescDetailArgsIter>d__;
		}

		// Token: 0x0600EFB3 RID: 61363 RVA: 0x00360DE4 File Offset: 0x0035EFE4
		[NullableContext(1)]
		public int[] InitBuffs()
		{
			return this.GetInitBuffsArray();
		}

		// Token: 0x0600EFB4 RID: 61364 RVA: 0x00360DEC File Offset: 0x0035EFEC
		[NullableContext(1)]
		public IEnumerable<int> InitBuffsIter()
		{
			TrapDefenseAuxiliary.<InitBuffsIter>d__85 <InitBuffsIter>d__ = new TrapDefenseAuxiliary.<InitBuffsIter>d__85(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x0600EFB5 RID: 61365 RVA: 0x00360E01 File Offset: 0x0035F001
		[NullableContext(1)]
		public int[] InitSkills()
		{
			return this.GetInitSkillsArray();
		}

		// Token: 0x0600EFB6 RID: 61366 RVA: 0x00360E09 File Offset: 0x0035F009
		[NullableContext(1)]
		public IEnumerable<int> InitSkillsIter()
		{
			TrapDefenseAuxiliary.<InitSkillsIter>d__87 <InitSkillsIter>d__ = new TrapDefenseAuxiliary.<InitSkillsIter>d__87(-2);
			<InitSkillsIter>d__.<>3__<>4__this = this;
			return <InitSkillsIter>d__;
		}

		// Token: 0x0600EFB7 RID: 61367 RVA: 0x00360E1E File Offset: 0x0035F01E
		[NullableContext(1)]
		public int[] ReadyCueId()
		{
			return this.GetReadyCueIdArray();
		}

		// Token: 0x0600EFB8 RID: 61368 RVA: 0x00360E26 File Offset: 0x0035F026
		[NullableContext(1)]
		public IEnumerable<int> ReadyCueIdIter()
		{
			TrapDefenseAuxiliary.<ReadyCueIdIter>d__89 <ReadyCueIdIter>d__ = new TrapDefenseAuxiliary.<ReadyCueIdIter>d__89(-2);
			<ReadyCueIdIter>d__.<>3__<>4__this = this;
			return <ReadyCueIdIter>d__;
		}

		// Token: 0x040058DC RID: 22748
		private Table __p;
	}
}
