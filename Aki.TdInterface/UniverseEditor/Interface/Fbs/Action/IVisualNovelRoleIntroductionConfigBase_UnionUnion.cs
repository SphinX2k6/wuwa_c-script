using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DE0 RID: 32224
	public class IVisualNovelRoleIntroductionConfigBase_UnionUnion
	{
		// Token: 0x1700F16A RID: 61802
		// (get) Token: 0x0603A3C3 RID: 238531 RVA: 0x007D924D File Offset: 0x007D744D
		// (set) Token: 0x0603A3C4 RID: 238532 RVA: 0x007D9255 File Offset: 0x007D7455
		public IVisualNovelRoleIntroductionConfigBase_Union Type { get; set; }

		// Token: 0x1700F16B RID: 61803
		// (get) Token: 0x0603A3C5 RID: 238533 RVA: 0x007D925E File Offset: 0x007D745E
		// (set) Token: 0x0603A3C6 RID: 238534 RVA: 0x007D9266 File Offset: 0x007D7466
		public object Value { get; set; }

		// Token: 0x0603A3C7 RID: 238535 RVA: 0x007D926F File Offset: 0x007D746F
		public IVisualNovelRoleIntroductionConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelRoleIntroductionConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603A3C8 RID: 238536 RVA: 0x007D9285 File Offset: 0x007D7485
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A3C9 RID: 238537 RVA: 0x007D9297 File Offset: 0x007D7497
		public IVisualNovelRoleIntroductionConfigBaseT AsIVisualNovelRoleIntroductionConfigBase()
		{
			return this.As<IVisualNovelRoleIntroductionConfigBaseT>();
		}

		// Token: 0x0603A3CA RID: 238538 RVA: 0x007D929F File Offset: 0x007D749F
		public static IVisualNovelRoleIntroductionConfigBase_UnionUnion FromIVisualNovelRoleIntroductionConfigBase(IVisualNovelRoleIntroductionConfigBaseT _ivisualnovelroleintroductionconfigbase)
		{
			return new IVisualNovelRoleIntroductionConfigBase_UnionUnion
			{
				Type = IVisualNovelRoleIntroductionConfigBase_Union.IVisualNovelRoleIntroductionConfigBase,
				Value = _ivisualnovelroleintroductionconfigbase
			};
		}

		// Token: 0x0603A3CB RID: 238539 RVA: 0x007D92B4 File Offset: 0x007D74B4
		public IVisualNovelRoleIntroductionSolarSchoolT AsIVisualNovelRoleIntroductionSolarSchool()
		{
			return this.As<IVisualNovelRoleIntroductionSolarSchoolT>();
		}

		// Token: 0x0603A3CC RID: 238540 RVA: 0x007D92BC File Offset: 0x007D74BC
		public static IVisualNovelRoleIntroductionConfigBase_UnionUnion FromIVisualNovelRoleIntroductionSolarSchool(IVisualNovelRoleIntroductionSolarSchoolT _ivisualnovelroleintroductionsolarschool)
		{
			return new IVisualNovelRoleIntroductionConfigBase_UnionUnion
			{
				Type = IVisualNovelRoleIntroductionConfigBase_Union.IVisualNovelRoleIntroductionSolarSchool,
				Value = _ivisualnovelroleintroductionsolarschool
			};
		}

		// Token: 0x0603A3CD RID: 238541 RVA: 0x007D92D4 File Offset: 0x007D74D4
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
