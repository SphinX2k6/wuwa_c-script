using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075DB RID: 30171
	public class IVisualNovelRoleIntroductionConfigBase_UnionUnion
	{
		// Token: 0x1700E536 RID: 58678
		// (get) Token: 0x06036F54 RID: 225108 RVA: 0x007755F9 File Offset: 0x007737F9
		// (set) Token: 0x06036F55 RID: 225109 RVA: 0x00775601 File Offset: 0x00773801
		public IVisualNovelRoleIntroductionConfigBase_Union Type { get; set; }

		// Token: 0x1700E537 RID: 58679
		// (get) Token: 0x06036F56 RID: 225110 RVA: 0x0077560A File Offset: 0x0077380A
		// (set) Token: 0x06036F57 RID: 225111 RVA: 0x00775612 File Offset: 0x00773812
		public object Value { get; set; }

		// Token: 0x06036F58 RID: 225112 RVA: 0x0077561B File Offset: 0x0077381B
		public IVisualNovelRoleIntroductionConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelRoleIntroductionConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036F59 RID: 225113 RVA: 0x00775631 File Offset: 0x00773831
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036F5A RID: 225114 RVA: 0x00775643 File Offset: 0x00773843
		public IVisualNovelRoleIntroductionConfigBaseT AsIVisualNovelRoleIntroductionConfigBase()
		{
			return this.As<IVisualNovelRoleIntroductionConfigBaseT>();
		}

		// Token: 0x06036F5B RID: 225115 RVA: 0x0077564B File Offset: 0x0077384B
		public static IVisualNovelRoleIntroductionConfigBase_UnionUnion FromIVisualNovelRoleIntroductionConfigBase(IVisualNovelRoleIntroductionConfigBaseT _ivisualnovelroleintroductionconfigbase)
		{
			return new IVisualNovelRoleIntroductionConfigBase_UnionUnion
			{
				Type = IVisualNovelRoleIntroductionConfigBase_Union.IVisualNovelRoleIntroductionConfigBase,
				Value = _ivisualnovelroleintroductionconfigbase
			};
		}

		// Token: 0x06036F5C RID: 225116 RVA: 0x00775660 File Offset: 0x00773860
		public IVisualNovelRoleIntroductionSolarSchoolT AsIVisualNovelRoleIntroductionSolarSchool()
		{
			return this.As<IVisualNovelRoleIntroductionSolarSchoolT>();
		}

		// Token: 0x06036F5D RID: 225117 RVA: 0x00775668 File Offset: 0x00773868
		public static IVisualNovelRoleIntroductionConfigBase_UnionUnion FromIVisualNovelRoleIntroductionSolarSchool(IVisualNovelRoleIntroductionSolarSchoolT _ivisualnovelroleintroductionsolarschool)
		{
			return new IVisualNovelRoleIntroductionConfigBase_UnionUnion
			{
				Type = IVisualNovelRoleIntroductionConfigBase_Union.IVisualNovelRoleIntroductionSolarSchool,
				Value = _ivisualnovelroleintroductionsolarschool
			};
		}

		// Token: 0x06036F5E RID: 225118 RVA: 0x00775680 File Offset: 0x00773880
		public static int Pack(FlatBufferBuilder builder, IVisualNovelRoleIntroductionConfigBase_UnionUnion _o)
		{
			IVisualNovelRoleIntroductionConfigBase_Union type = _o.Type;
			if (type == IVisualNovelRoleIntroductionConfigBase_Union.IVisualNovelRoleIntroductionConfigBase)
			{
				return IVisualNovelRoleIntroductionConfigBase.Pack(builder, _o.AsIVisualNovelRoleIntroductionConfigBase()).Value;
			}
			if (type != IVisualNovelRoleIntroductionConfigBase_Union.IVisualNovelRoleIntroductionSolarSchool)
			{
				return 0;
			}
			return IVisualNovelRoleIntroductionSolarSchool.Pack(builder, _o.AsIVisualNovelRoleIntroductionSolarSchool()).Value;
		}
	}
}
