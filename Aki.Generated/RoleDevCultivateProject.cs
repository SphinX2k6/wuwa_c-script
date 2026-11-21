using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001128 RID: 4392
	public struct RoleDevCultivateProject : IFlatbufferObject
	{
		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600CE0D RID: 52749 RVA: 0x00314909 File Offset: 0x00312B09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE0E RID: 52750 RVA: 0x00314916 File Offset: 0x00312B16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE0F RID: 52751 RVA: 0x00314920 File Offset: 0x00312B20
		public static RoleDevCultivateProject GetRootAsRoleDevCultivateProject(ByteBuffer _bb)
		{
			return RoleDevCultivateProject.GetRootAsRoleDevCultivateProject(_bb, default(RoleDevCultivateProject));
		}

		// Token: 0x0600CE10 RID: 52752 RVA: 0x0031493C File Offset: 0x00312B3C
		public static RoleDevCultivateProject GetRootAsRoleDevCultivateProject(ByteBuffer _bb, RoleDevCultivateProject obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE11 RID: 52753 RVA: 0x00314959 File Offset: 0x00312B59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE12 RID: 52754 RVA: 0x00314968 File Offset: 0x00312B68
		public RoleDevCultivateProject __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600CE13 RID: 52755 RVA: 0x00314978 File Offset: 0x00312B78
		public int ProjectProjectId
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

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600CE14 RID: 52756 RVA: 0x003149B4 File Offset: 0x00312BB4
		public int RoleBreachLevel
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

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600CE15 RID: 52757 RVA: 0x003149F0 File Offset: 0x00312BF0
		public int RoleLevel
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

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600CE16 RID: 52758 RVA: 0x00314A2C File Offset: 0x00312C2C
		public int WeaponBreachLevel
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

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600CE17 RID: 52759 RVA: 0x00314A6C File Offset: 0x00312C6C
		public int WeaponLevel
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

		// Token: 0x0600CE18 RID: 52760 RVA: 0x00314AAC File Offset: 0x00312CAC
		public int NormalSkillLevel(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600CE19 RID: 52761 RVA: 0x00314AEC File Offset: 0x00312CEC
		public int NormalSkillLevelLength
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

		// Token: 0x0600CE1A RID: 52762 RVA: 0x00314B18 File Offset: 0x00312D18
		public Span<int> GetNormalSkillLevelBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600CE1B RID: 52763 RVA: 0x00314B28 File Offset: 0x00312D28
		public int[] GetNormalSkillLevelArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600CE1C RID: 52764 RVA: 0x00314B40 File Offset: 0x00312D40
		public int PrefectSkillLevel(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600CE1D RID: 52765 RVA: 0x00314B80 File Offset: 0x00312D80
		public int PrefectSkillLevelLength
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

		// Token: 0x0600CE1E RID: 52766 RVA: 0x00314BAC File Offset: 0x00312DAC
		public Span<int> GetPrefectSkillLevelBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600CE1F RID: 52767 RVA: 0x00314BBC File Offset: 0x00312DBC
		public int[] GetPrefectSkillLevelArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600CE20 RID: 52768 RVA: 0x00314BD4 File Offset: 0x00312DD4
		public int SkillTreeConfigArray(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600CE21 RID: 52769 RVA: 0x00314C14 File Offset: 0x00312E14
		public int SkillTreeConfigArrayLength
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

		// Token: 0x0600CE22 RID: 52770 RVA: 0x00314C40 File Offset: 0x00312E40
		public Span<int> GetSkillTreeConfigArrayBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600CE23 RID: 52771 RVA: 0x00314C50 File Offset: 0x00312E50
		public int[] GetSkillTreeConfigArrayArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600CE24 RID: 52772 RVA: 0x00314C68 File Offset: 0x00312E68
		[NullableContext(1)]
		public int[] NormalSkillLevel()
		{
			return this.GetNormalSkillLevelArray();
		}

		// Token: 0x0600CE25 RID: 52773 RVA: 0x00314C70 File Offset: 0x00312E70
		[NullableContext(1)]
		public IEnumerable<int> NormalSkillLevelIter()
		{
			RoleDevCultivateProject.<NormalSkillLevelIter>d__34 <NormalSkillLevelIter>d__ = new RoleDevCultivateProject.<NormalSkillLevelIter>d__34(-2);
			<NormalSkillLevelIter>d__.<>3__<>4__this = this;
			return <NormalSkillLevelIter>d__;
		}

		// Token: 0x0600CE26 RID: 52774 RVA: 0x00314C85 File Offset: 0x00312E85
		[NullableContext(1)]
		public int[] PrefectSkillLevel()
		{
			return this.GetPrefectSkillLevelArray();
		}

		// Token: 0x0600CE27 RID: 52775 RVA: 0x00314C8D File Offset: 0x00312E8D
		[NullableContext(1)]
		public IEnumerable<int> PrefectSkillLevelIter()
		{
			RoleDevCultivateProject.<PrefectSkillLevelIter>d__36 <PrefectSkillLevelIter>d__ = new RoleDevCultivateProject.<PrefectSkillLevelIter>d__36(-2);
			<PrefectSkillLevelIter>d__.<>3__<>4__this = this;
			return <PrefectSkillLevelIter>d__;
		}

		// Token: 0x0600CE28 RID: 52776 RVA: 0x00314CA2 File Offset: 0x00312EA2
		[NullableContext(1)]
		public int[] SkillTreeConfigArray()
		{
			return this.GetSkillTreeConfigArrayArray();
		}

		// Token: 0x0600CE29 RID: 52777 RVA: 0x00314CAA File Offset: 0x00312EAA
		[NullableContext(1)]
		public IEnumerable<int> SkillTreeConfigArrayIter()
		{
			RoleDevCultivateProject.<SkillTreeConfigArrayIter>d__38 <SkillTreeConfigArrayIter>d__ = new RoleDevCultivateProject.<SkillTreeConfigArrayIter>d__38(-2);
			<SkillTreeConfigArrayIter>d__.<>3__<>4__this = this;
			return <SkillTreeConfigArrayIter>d__;
		}

		// Token: 0x04005726 RID: 22310
		private Table __p;
	}
}
