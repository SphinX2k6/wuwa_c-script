using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DFB RID: 32251
	public class IVisualNovelTransitionPerformanceConfigBase_UnionUnion
	{
		// Token: 0x1700F190 RID: 61840
		// (get) Token: 0x0603A473 RID: 238707 RVA: 0x007DA269 File Offset: 0x007D8469
		// (set) Token: 0x0603A474 RID: 238708 RVA: 0x007DA271 File Offset: 0x007D8471
		public IVisualNovelTransitionPerformanceConfigBase_Union Type { get; set; }

		// Token: 0x1700F191 RID: 61841
		// (get) Token: 0x0603A475 RID: 238709 RVA: 0x007DA27A File Offset: 0x007D847A
		// (set) Token: 0x0603A476 RID: 238710 RVA: 0x007DA282 File Offset: 0x007D8482
		public object Value { get; set; }

		// Token: 0x0603A477 RID: 238711 RVA: 0x007DA28B File Offset: 0x007D848B
		public IVisualNovelTransitionPerformanceConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelTransitionPerformanceConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603A478 RID: 238712 RVA: 0x007DA2A1 File Offset: 0x007D84A1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A479 RID: 238713 RVA: 0x007DA2B3 File Offset: 0x007D84B3
		public IVisualNovelTransitionPerformanceConfigBaseT AsIVisualNovelTransitionPerformanceConfigBase()
		{
			return this.As<IVisualNovelTransitionPerformanceConfigBaseT>();
		}

		// Token: 0x0603A47A RID: 238714 RVA: 0x007DA2BB File Offset: 0x007D84BB
		public static IVisualNovelTransitionPerformanceConfigBase_UnionUnion FromIVisualNovelTransitionPerformanceConfigBase(IVisualNovelTransitionPerformanceConfigBaseT _ivisualnoveltransitionperformanceconfigbase)
		{
			return new IVisualNovelTransitionPerformanceConfigBase_UnionUnion
			{
				Type = IVisualNovelTransitionPerformanceConfigBase_Union.IVisualNovelTransitionPerformanceConfigBase,
				Value = _ivisualnoveltransitionperformanceconfigbase
			};
		}

		// Token: 0x0603A47B RID: 238715 RVA: 0x007DA2D0 File Offset: 0x007D84D0
		public IVisualNovelTransitionPerformanceSolarSchoolT AsIVisualNovelTransitionPerformanceSolarSchool()
		{
			return this.As<IVisualNovelTransitionPerformanceSolarSchoolT>();
		}

		// Token: 0x0603A47C RID: 238716 RVA: 0x007DA2D8 File Offset: 0x007D84D8
		public static IVisualNovelTransitionPerformanceConfigBase_UnionUnion FromIVisualNovelTransitionPerformanceSolarSchool(IVisualNovelTransitionPerformanceSolarSchoolT _ivisualnoveltransitionperformancesolarschool)
		{
			return new IVisualNovelTransitionPerformanceConfigBase_UnionUnion
			{
				Type = IVisualNovelTransitionPerformanceConfigBase_Union.IVisualNovelTransitionPerformanceSolarSchool,
				Value = _ivisualnoveltransitionperformancesolarschool
			};
		}

		// Token: 0x0603A47D RID: 238717 RVA: 0x007DA2F0 File Offset: 0x007D84F0
		public static int Pack(FlatBufferBuilder builder, IVisualNovelTransitionPerformanceConfigBase_UnionUnion _o)
		{
			IVisualNovelTransitionPerformanceConfigBase_Union type = _o.Type;
			if (type == IVisualNovelTransitionPerformanceConfigBase_Union.IVisualNovelTransitionPerformanceConfigBase)
			{
				return IVisualNovelTransitionPerformanceConfigBase.Pack(builder, _o.AsIVisualNovelTransitionPerformanceConfigBase()).Value;
			}
			if (type != IVisualNovelTransitionPerformanceConfigBase_Union.IVisualNovelTransitionPerformanceSolarSchool)
			{
				return 0;
			}
			return IVisualNovelTransitionPerformanceSolarSchool.Pack(builder, _o.AsIVisualNovelTransitionPerformanceSolarSchool()).Value;
		}
	}
}
