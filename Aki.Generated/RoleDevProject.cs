using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001046 RID: 4166
	public struct RoleDevProject : IFlatbufferObject
	{
		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600C828 RID: 51240 RVA: 0x002F9875 File Offset: 0x002F7A75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C829 RID: 51241 RVA: 0x002F9882 File Offset: 0x002F7A82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C82A RID: 51242 RVA: 0x002F988C File Offset: 0x002F7A8C
		public static RoleDevProject GetRootAsRoleDevProject(ByteBuffer _bb)
		{
			return RoleDevProject.GetRootAsRoleDevProject(_bb, default(RoleDevProject));
		}

		// Token: 0x0600C82B RID: 51243 RVA: 0x002F98A8 File Offset: 0x002F7AA8
		public static RoleDevProject GetRootAsRoleDevProject(ByteBuffer _bb, RoleDevProject obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C82C RID: 51244 RVA: 0x002F98C5 File Offset: 0x002F7AC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C82D RID: 51245 RVA: 0x002F98D4 File Offset: 0x002F7AD4
		public RoleDevProject __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600C82E RID: 51246 RVA: 0x002F98E4 File Offset: 0x002F7AE4
		public int RoleId
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

		// Token: 0x0600C82F RID: 51247 RVA: 0x002F9920 File Offset: 0x002F7B20
		public int ProjectGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600C830 RID: 51248 RVA: 0x002F9960 File Offset: 0x002F7B60
		public int ProjectGroupLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C831 RID: 51249 RVA: 0x002F998B File Offset: 0x002F7B8B
		public Span<int> GetProjectGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C832 RID: 51250 RVA: 0x002F999A File Offset: 0x002F7B9A
		public int[] GetProjectGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600C833 RID: 51251 RVA: 0x002F99B4 File Offset: 0x002F7BB4
		public int WeaponType
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

		// Token: 0x0600C834 RID: 51252 RVA: 0x002F99F0 File Offset: 0x002F7BF0
		public int RecommandWeapon(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600C835 RID: 51253 RVA: 0x002F9A30 File Offset: 0x002F7C30
		public int RecommandWeaponLength
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

		// Token: 0x0600C836 RID: 51254 RVA: 0x002F9A5C File Offset: 0x002F7C5C
		public Span<int> GetRecommandWeaponBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C837 RID: 51255 RVA: 0x002F9A6C File Offset: 0x002F7C6C
		public int[] GetRecommandWeaponArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600C838 RID: 51256 RVA: 0x002F9A84 File Offset: 0x002F7C84
		public IntArray? SkillItemJumpType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600C839 RID: 51257 RVA: 0x002F9AE8 File Offset: 0x002F7CE8
		public int SkillItemJumpTypeLength
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

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600C83A RID: 51258 RVA: 0x002F9B14 File Offset: 0x002F7D14
		public int KeyProperty
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

		// Token: 0x0600C83B RID: 51259 RVA: 0x002F9B54 File Offset: 0x002F7D54
		public int PropertyValue(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600C83C RID: 51260 RVA: 0x002F9B94 File Offset: 0x002F7D94
		public int PropertyValueLength
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

		// Token: 0x0600C83D RID: 51261 RVA: 0x002F9BC0 File Offset: 0x002F7DC0
		public Span<int> GetPropertyValueBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600C83E RID: 51262 RVA: 0x002F9BD0 File Offset: 0x002F7DD0
		public int[] GetPropertyValueArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600C83F RID: 51263 RVA: 0x002F9BE8 File Offset: 0x002F7DE8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ProjectGroupIter()或GetProjectGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ProjectGroup()
		{
			RoleDevProject roleDevProject = this;
			return roleDevProject.GetProjectGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C840 RID: 51264 RVA: 0x002F9C0C File Offset: 0x002F7E0C
		[NullableContext(1)]
		public readonly IEnumerable<int> ProjectGroupIter()
		{
			RoleDevProject.<ProjectGroupIter>d__33 <ProjectGroupIter>d__ = new RoleDevProject.<ProjectGroupIter>d__33(-2);
			<ProjectGroupIter>d__.<>3__<>4__this = this;
			return <ProjectGroupIter>d__;
		}

		// Token: 0x0600C841 RID: 51265 RVA: 0x002F9C24 File Offset: 0x002F7E24
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropertyValueIter()或GetPropertyValueBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PropertyValue()
		{
			RoleDevProject roleDevProject = this;
			return roleDevProject.GetPropertyValueArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C842 RID: 51266 RVA: 0x002F9C48 File Offset: 0x002F7E48
		[NullableContext(1)]
		public readonly IEnumerable<int> PropertyValueIter()
		{
			RoleDevProject.<PropertyValueIter>d__35 <PropertyValueIter>d__ = new RoleDevProject.<PropertyValueIter>d__35(-2);
			<PropertyValueIter>d__.<>3__<>4__this = this;
			return <PropertyValueIter>d__;
		}

		// Token: 0x0600C843 RID: 51267 RVA: 0x002F9C60 File Offset: 0x002F7E60
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommandWeaponIter()或GetRecommandWeaponBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommandWeapon()
		{
			RoleDevProject roleDevProject = this;
			return roleDevProject.GetRecommandWeaponArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C844 RID: 51268 RVA: 0x002F9C84 File Offset: 0x002F7E84
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommandWeaponIter()
		{
			RoleDevProject.<RecommandWeaponIter>d__37 <RecommandWeaponIter>d__ = new RoleDevProject.<RecommandWeaponIter>d__37(-2);
			<RecommandWeaponIter>d__.<>3__<>4__this = this;
			return <RecommandWeaponIter>d__;
		}

		// Token: 0x0600C845 RID: 51269 RVA: 0x002F9C99 File Offset: 0x002F7E99
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillItemJumpTypeIter()或GetSkillItemJumpTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] SkillItemJumpType()
		{
			return this.SkillItemJumpTypeIter().ToArray<IntArray>();
		}

		// Token: 0x0600C846 RID: 51270 RVA: 0x002F9CA6 File Offset: 0x002F7EA6
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> SkillItemJumpTypeIter()
		{
			RoleDevProject.<SkillItemJumpTypeIter>d__39 <SkillItemJumpTypeIter>d__ = new RoleDevProject.<SkillItemJumpTypeIter>d__39(-2);
			<SkillItemJumpTypeIter>d__.<>3__<>4__this = this;
			return <SkillItemJumpTypeIter>d__;
		}

		// Token: 0x04005144 RID: 20804
		private Table __p;
	}
}
