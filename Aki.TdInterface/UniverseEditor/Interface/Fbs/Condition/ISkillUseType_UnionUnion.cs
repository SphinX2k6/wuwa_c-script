using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051CD RID: 20941
	public class ISkillUseType_UnionUnion
	{
		// Token: 0x170095EF RID: 38383
		// (get) Token: 0x06020F75 RID: 135029 RVA: 0x0048EDA2 File Offset: 0x0048CFA2
		// (set) Token: 0x06020F76 RID: 135030 RVA: 0x0048EDAA File Offset: 0x0048CFAA
		public ISkillUseType_Union Type { get; set; }

		// Token: 0x170095F0 RID: 38384
		// (get) Token: 0x06020F77 RID: 135031 RVA: 0x0048EDB3 File Offset: 0x0048CFB3
		// (set) Token: 0x06020F78 RID: 135032 RVA: 0x0048EDBB File Offset: 0x0048CFBB
		public object Value { get; set; }

		// Token: 0x06020F79 RID: 135033 RVA: 0x0048EDC4 File Offset: 0x0048CFC4
		public ISkillUseType_UnionUnion()
		{
			this.Type = ISkillUseType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020F7A RID: 135034 RVA: 0x0048EDDA File Offset: 0x0048CFDA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020F7B RID: 135035 RVA: 0x0048EDEC File Offset: 0x0048CFEC
		public ISkillUseTypeT AsISkillUseType()
		{
			return this.As<ISkillUseTypeT>();
		}

		// Token: 0x06020F7C RID: 135036 RVA: 0x0048EDF4 File Offset: 0x0048CFF4
		public static ISkillUseType_UnionUnion FromISkillUseType(ISkillUseTypeT _iskillusetype)
		{
			return new ISkillUseType_UnionUnion
			{
				Type = ISkillUseType_Union.ISkillUseType,
				Value = _iskillusetype
			};
		}

		// Token: 0x06020F7D RID: 135037 RVA: 0x0048EE09 File Offset: 0x0048D009
		public ISkillUseTypeRoleSkillT AsISkillUseTypeRoleSkill()
		{
			return this.As<ISkillUseTypeRoleSkillT>();
		}

		// Token: 0x06020F7E RID: 135038 RVA: 0x0048EE11 File Offset: 0x0048D011
		public static ISkillUseType_UnionUnion FromISkillUseTypeRoleSkill(ISkillUseTypeRoleSkillT _iskillusetyperoleskill)
		{
			return new ISkillUseType_UnionUnion
			{
				Type = ISkillUseType_Union.ISkillUseTypeRoleSkill,
				Value = _iskillusetyperoleskill
			};
		}

		// Token: 0x06020F7F RID: 135039 RVA: 0x0048EE28 File Offset: 0x0048D028
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
