using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001040 RID: 4160
	public struct RoleDevCultivateProject : IFlatbufferObject
	{
		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600C7C3 RID: 51139 RVA: 0x002F8B11 File Offset: 0x002F6D11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C7C4 RID: 51140 RVA: 0x002F8B1E File Offset: 0x002F6D1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C7C5 RID: 51141 RVA: 0x002F8B28 File Offset: 0x002F6D28
		public static RoleDevCultivateProject GetRootAsRoleDevCultivateProject(ByteBuffer _bb)
		{
			return RoleDevCultivateProject.GetRootAsRoleDevCultivateProject(_bb, default(RoleDevCultivateProject));
		}

		// Token: 0x0600C7C6 RID: 51142 RVA: 0x002F8B44 File Offset: 0x002F6D44
		public static RoleDevCultivateProject GetRootAsRoleDevCultivateProject(ByteBuffer _bb, RoleDevCultivateProject obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C7C7 RID: 51143 RVA: 0x002F8B61 File Offset: 0x002F6D61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C7C8 RID: 51144 RVA: 0x002F8B70 File Offset: 0x002F6D70
		public RoleDevCultivateProject __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600C7C9 RID: 51145 RVA: 0x002F8B80 File Offset: 0x002F6D80
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

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600C7CA RID: 51146 RVA: 0x002F8BBC File Offset: 0x002F6DBC
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

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600C7CB RID: 51147 RVA: 0x002F8BF8 File Offset: 0x002F6DF8
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

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600C7CC RID: 51148 RVA: 0x002F8C34 File Offset: 0x002F6E34
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

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600C7CD RID: 51149 RVA: 0x002F8C74 File Offset: 0x002F6E74
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

		// Token: 0x0600C7CE RID: 51150 RVA: 0x002F8CB4 File Offset: 0x002F6EB4
		public int NormalSkillLevel(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600C7CF RID: 51151 RVA: 0x002F8CF4 File Offset: 0x002F6EF4
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

		// Token: 0x0600C7D0 RID: 51152 RVA: 0x002F8D20 File Offset: 0x002F6F20
		public Span<int> GetNormalSkillLevelBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C7D1 RID: 51153 RVA: 0x002F8D30 File Offset: 0x002F6F30
		public int[] GetNormalSkillLevelArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600C7D2 RID: 51154 RVA: 0x002F8D48 File Offset: 0x002F6F48
		public int PrefectSkillLevel(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600C7D3 RID: 51155 RVA: 0x002F8D88 File Offset: 0x002F6F88
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

		// Token: 0x0600C7D4 RID: 51156 RVA: 0x002F8DB4 File Offset: 0x002F6FB4
		public Span<int> GetPrefectSkillLevelBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600C7D5 RID: 51157 RVA: 0x002F8DC4 File Offset: 0x002F6FC4
		public int[] GetPrefectSkillLevelArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600C7D6 RID: 51158 RVA: 0x002F8DDC File Offset: 0x002F6FDC
		public int SkillTreeConfigArray(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600C7D7 RID: 51159 RVA: 0x002F8E1C File Offset: 0x002F701C
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

		// Token: 0x0600C7D8 RID: 51160 RVA: 0x002F8E48 File Offset: 0x002F7048
		public Span<int> GetSkillTreeConfigArrayBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C7D9 RID: 51161 RVA: 0x002F8E58 File Offset: 0x002F7058
		public int[] GetSkillTreeConfigArrayArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600C7DA RID: 51162 RVA: 0x002F8E70 File Offset: 0x002F7070
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NormalSkillLevelIter()或GetNormalSkillLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] NormalSkillLevel()
		{
			RoleDevCultivateProject roleDevCultivateProject = this;
			return roleDevCultivateProject.GetNormalSkillLevelArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C7DB RID: 51163 RVA: 0x002F8E94 File Offset: 0x002F7094
		[NullableContext(1)]
		public readonly IEnumerable<int> NormalSkillLevelIter()
		{
			RoleDevCultivateProject.<NormalSkillLevelIter>d__34 <NormalSkillLevelIter>d__ = new RoleDevCultivateProject.<NormalSkillLevelIter>d__34(-2);
			<NormalSkillLevelIter>d__.<>3__<>4__this = this;
			return <NormalSkillLevelIter>d__;
		}

		// Token: 0x0600C7DC RID: 51164 RVA: 0x002F8EAC File Offset: 0x002F70AC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PrefectSkillLevelIter()或GetPrefectSkillLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PrefectSkillLevel()
		{
			RoleDevCultivateProject roleDevCultivateProject = this;
			return roleDevCultivateProject.GetPrefectSkillLevelArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C7DD RID: 51165 RVA: 0x002F8ED0 File Offset: 0x002F70D0
		[NullableContext(1)]
		public readonly IEnumerable<int> PrefectSkillLevelIter()
		{
			RoleDevCultivateProject.<PrefectSkillLevelIter>d__36 <PrefectSkillLevelIter>d__ = new RoleDevCultivateProject.<PrefectSkillLevelIter>d__36(-2);
			<PrefectSkillLevelIter>d__.<>3__<>4__this = this;
			return <PrefectSkillLevelIter>d__;
		}

		// Token: 0x0600C7DE RID: 51166 RVA: 0x002F8EE8 File Offset: 0x002F70E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillTreeConfigArrayIter()或GetSkillTreeConfigArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillTreeConfigArray()
		{
			RoleDevCultivateProject roleDevCultivateProject = this;
			return roleDevCultivateProject.GetSkillTreeConfigArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C7DF RID: 51167 RVA: 0x002F8F0C File Offset: 0x002F710C
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillTreeConfigArrayIter()
		{
			RoleDevCultivateProject.<SkillTreeConfigArrayIter>d__38 <SkillTreeConfigArrayIter>d__ = new RoleDevCultivateProject.<SkillTreeConfigArrayIter>d__38(-2);
			<SkillTreeConfigArrayIter>d__.<>3__<>4__this = this;
			return <SkillTreeConfigArrayIter>d__;
		}

		// Token: 0x0400513E RID: 20798
		private Table __p;
	}
}
