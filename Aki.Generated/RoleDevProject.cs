using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112E RID: 4398
	public struct RoleDevProject : IFlatbufferObject
	{
		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600CE72 RID: 52850 RVA: 0x003155B5 File Offset: 0x003137B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE73 RID: 52851 RVA: 0x003155C2 File Offset: 0x003137C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE74 RID: 52852 RVA: 0x003155CC File Offset: 0x003137CC
		public static RoleDevProject GetRootAsRoleDevProject(ByteBuffer _bb)
		{
			return RoleDevProject.GetRootAsRoleDevProject(_bb, default(RoleDevProject));
		}

		// Token: 0x0600CE75 RID: 52853 RVA: 0x003155E8 File Offset: 0x003137E8
		public static RoleDevProject GetRootAsRoleDevProject(ByteBuffer _bb, RoleDevProject obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE76 RID: 52854 RVA: 0x00315605 File Offset: 0x00313805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE77 RID: 52855 RVA: 0x00315614 File Offset: 0x00313814
		public RoleDevProject __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600CE78 RID: 52856 RVA: 0x00315624 File Offset: 0x00313824
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

		// Token: 0x0600CE79 RID: 52857 RVA: 0x00315660 File Offset: 0x00313860
		public int ProjectGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600CE7A RID: 52858 RVA: 0x003156A0 File Offset: 0x003138A0
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

		// Token: 0x0600CE7B RID: 52859 RVA: 0x003156CB File Offset: 0x003138CB
		public Span<int> GetProjectGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CE7C RID: 52860 RVA: 0x003156DA File Offset: 0x003138DA
		public int[] GetProjectGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600CE7D RID: 52861 RVA: 0x003156F4 File Offset: 0x003138F4
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

		// Token: 0x0600CE7E RID: 52862 RVA: 0x00315730 File Offset: 0x00313930
		public int RecommandWeapon(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600CE7F RID: 52863 RVA: 0x00315770 File Offset: 0x00313970
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

		// Token: 0x0600CE80 RID: 52864 RVA: 0x0031579C File Offset: 0x0031399C
		public Span<int> GetRecommandWeaponBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CE81 RID: 52865 RVA: 0x003157AC File Offset: 0x003139AC
		public int[] GetRecommandWeaponArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600CE82 RID: 52866 RVA: 0x003157C4 File Offset: 0x003139C4
		public IntArray? SkillItemJumpType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600CE83 RID: 52867 RVA: 0x00315828 File Offset: 0x00313A28
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

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600CE84 RID: 52868 RVA: 0x00315854 File Offset: 0x00313A54
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

		// Token: 0x0600CE85 RID: 52869 RVA: 0x00315894 File Offset: 0x00313A94
		public int PropertyValue(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600CE86 RID: 52870 RVA: 0x003158D4 File Offset: 0x00313AD4
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

		// Token: 0x0600CE87 RID: 52871 RVA: 0x00315900 File Offset: 0x00313B00
		public Span<int> GetPropertyValueBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600CE88 RID: 52872 RVA: 0x00315910 File Offset: 0x00313B10
		public int[] GetPropertyValueArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600CE89 RID: 52873 RVA: 0x00315928 File Offset: 0x00313B28
		[NullableContext(1)]
		public int[] ProjectGroup()
		{
			return this.GetProjectGroupArray();
		}

		// Token: 0x0600CE8A RID: 52874 RVA: 0x00315930 File Offset: 0x00313B30
		[NullableContext(1)]
		public IEnumerable<int> ProjectGroupIter()
		{
			RoleDevProject.<ProjectGroupIter>d__33 <ProjectGroupIter>d__ = new RoleDevProject.<ProjectGroupIter>d__33(-2);
			<ProjectGroupIter>d__.<>3__<>4__this = this;
			return <ProjectGroupIter>d__;
		}

		// Token: 0x0600CE8B RID: 52875 RVA: 0x00315945 File Offset: 0x00313B45
		[NullableContext(1)]
		public int[] PropertyValue()
		{
			return this.GetPropertyValueArray();
		}

		// Token: 0x0600CE8C RID: 52876 RVA: 0x0031594D File Offset: 0x00313B4D
		[NullableContext(1)]
		public IEnumerable<int> PropertyValueIter()
		{
			RoleDevProject.<PropertyValueIter>d__35 <PropertyValueIter>d__ = new RoleDevProject.<PropertyValueIter>d__35(-2);
			<PropertyValueIter>d__.<>3__<>4__this = this;
			return <PropertyValueIter>d__;
		}

		// Token: 0x0600CE8D RID: 52877 RVA: 0x00315962 File Offset: 0x00313B62
		[NullableContext(1)]
		public int[] RecommandWeapon()
		{
			return this.GetRecommandWeaponArray();
		}

		// Token: 0x0600CE8E RID: 52878 RVA: 0x0031596A File Offset: 0x00313B6A
		[NullableContext(1)]
		public IEnumerable<int> RecommandWeaponIter()
		{
			RoleDevProject.<RecommandWeaponIter>d__37 <RecommandWeaponIter>d__ = new RoleDevProject.<RecommandWeaponIter>d__37(-2);
			<RecommandWeaponIter>d__.<>3__<>4__this = this;
			return <RecommandWeaponIter>d__;
		}

		// Token: 0x0600CE8F RID: 52879 RVA: 0x0031597F File Offset: 0x00313B7F
		[NullableContext(1)]
		public IntArray[] SkillItemJumpType()
		{
			return this.SkillItemJumpTypeIter().ToArray<IntArray>();
		}

		// Token: 0x0600CE90 RID: 52880 RVA: 0x0031598C File Offset: 0x00313B8C
		[NullableContext(1)]
		public IEnumerable<IntArray> SkillItemJumpTypeIter()
		{
			RoleDevProject.<SkillItemJumpTypeIter>d__39 <SkillItemJumpTypeIter>d__ = new RoleDevProject.<SkillItemJumpTypeIter>d__39(-2);
			<SkillItemJumpTypeIter>d__.<>3__<>4__this = this;
			return <SkillItemJumpTypeIter>d__;
		}

		// Token: 0x0400572C RID: 22316
		private Table __p;
	}
}
