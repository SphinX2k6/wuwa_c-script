using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CD1 RID: 19665
	public class ISkillUseType_UnionUnion
	{
		// Token: 0x17008EB6 RID: 36534
		// (get) Token: 0x0601F331 RID: 127793 RVA: 0x0045AEAA File Offset: 0x004590AA
		// (set) Token: 0x0601F332 RID: 127794 RVA: 0x0045AEB2 File Offset: 0x004590B2
		public ISkillUseType_Union Type { get; set; }

		// Token: 0x17008EB7 RID: 36535
		// (get) Token: 0x0601F333 RID: 127795 RVA: 0x0045AEBB File Offset: 0x004590BB
		// (set) Token: 0x0601F334 RID: 127796 RVA: 0x0045AEC3 File Offset: 0x004590C3
		public object Value { get; set; }

		// Token: 0x0601F335 RID: 127797 RVA: 0x0045AECC File Offset: 0x004590CC
		public ISkillUseType_UnionUnion()
		{
			this.Type = ISkillUseType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F336 RID: 127798 RVA: 0x0045AEE2 File Offset: 0x004590E2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F337 RID: 127799 RVA: 0x0045AEF4 File Offset: 0x004590F4
		public ISkillUseTypeT AsISkillUseType()
		{
			return this.As<ISkillUseTypeT>();
		}

		// Token: 0x0601F338 RID: 127800 RVA: 0x0045AEFC File Offset: 0x004590FC
		public static ISkillUseType_UnionUnion FromISkillUseType(ISkillUseTypeT _iskillusetype)
		{
			return new ISkillUseType_UnionUnion
			{
				Type = ISkillUseType_Union.ISkillUseType,
				Value = _iskillusetype
			};
		}

		// Token: 0x0601F339 RID: 127801 RVA: 0x0045AF11 File Offset: 0x00459111
		public ISkillUseTypeRoleSkillT AsISkillUseTypeRoleSkill()
		{
			return this.As<ISkillUseTypeRoleSkillT>();
		}

		// Token: 0x0601F33A RID: 127802 RVA: 0x0045AF19 File Offset: 0x00459119
		public static ISkillUseType_UnionUnion FromISkillUseTypeRoleSkill(ISkillUseTypeRoleSkillT _iskillusetyperoleskill)
		{
			return new ISkillUseType_UnionUnion
			{
				Type = ISkillUseType_Union.ISkillUseTypeRoleSkill,
				Value = _iskillusetyperoleskill
			};
		}

		// Token: 0x0601F33B RID: 127803 RVA: 0x0045AF30 File Offset: 0x00459130
		public static int Pack(FlatBufferBuilder builder, ISkillUseType_UnionUnion _o)
		{
			ISkillUseType_Union type = _o.Type;
			if (type == ISkillUseType_Union.ISkillUseType)
			{
				return ISkillUseType.Pack(builder, _o.AsISkillUseType()).Value;
			}
			if (type != ISkillUseType_Union.ISkillUseTypeRoleSkill)
			{
				return 0;
			}
			return ISkillUseTypeRoleSkill.Pack(builder, _o.AsISkillUseTypeRoleSkill()).Value;
		}
	}
}
