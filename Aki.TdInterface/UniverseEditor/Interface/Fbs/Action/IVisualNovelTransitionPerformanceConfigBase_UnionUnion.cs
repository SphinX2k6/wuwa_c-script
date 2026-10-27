using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075ED RID: 30189
	public class IVisualNovelTransitionPerformanceConfigBase_UnionUnion
	{
		// Token: 0x1700E552 RID: 58706
		// (get) Token: 0x06036FCE RID: 225230 RVA: 0x0077616D File Offset: 0x0077436D
		// (set) Token: 0x06036FCF RID: 225231 RVA: 0x00776175 File Offset: 0x00774375
		public IVisualNovelTransitionPerformanceConfigBase_Union Type { get; set; }

		// Token: 0x1700E553 RID: 58707
		// (get) Token: 0x06036FD0 RID: 225232 RVA: 0x0077617E File Offset: 0x0077437E
		// (set) Token: 0x06036FD1 RID: 225233 RVA: 0x00776186 File Offset: 0x00774386
		public object Value { get; set; }

		// Token: 0x06036FD2 RID: 225234 RVA: 0x0077618F File Offset: 0x0077438F
		public IVisualNovelTransitionPerformanceConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelTransitionPerformanceConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036FD3 RID: 225235 RVA: 0x007761A5 File Offset: 0x007743A5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036FD4 RID: 225236 RVA: 0x007761B7 File Offset: 0x007743B7
		public IVisualNovelTransitionPerformanceConfigBaseT AsIVisualNovelTransitionPerformanceConfigBase()
		{
			return this.As<IVisualNovelTransitionPerformanceConfigBaseT>();
		}

		// Token: 0x06036FD5 RID: 225237 RVA: 0x007761BF File Offset: 0x007743BF
		public static IVisualNovelTransitionPerformanceConfigBase_UnionUnion FromIVisualNovelTransitionPerformanceConfigBase(IVisualNovelTransitionPerformanceConfigBaseT _ivisualnoveltransitionperformanceconfigbase)
		{
			return new IVisualNovelTransitionPerformanceConfigBase_UnionUnion
			{
				Type = IVisualNovelTransitionPerformanceConfigBase_Union.IVisualNovelTransitionPerformanceConfigBase,
				Value = _ivisualnoveltransitionperformanceconfigbase
			};
		}

		// Token: 0x06036FD6 RID: 225238 RVA: 0x007761D4 File Offset: 0x007743D4
		public IVisualNovelTransitionPerformanceSolarSchoolT AsIVisualNovelTransitionPerformanceSolarSchool()
		{
			return this.As<IVisualNovelTransitionPerformanceSolarSchoolT>();
		}

		// Token: 0x06036FD7 RID: 225239 RVA: 0x007761DC File Offset: 0x007743DC
		public static IVisualNovelTransitionPerformanceConfigBase_UnionUnion FromIVisualNovelTransitionPerformanceSolarSchool(IVisualNovelTransitionPerformanceSolarSchoolT _ivisualnoveltransitionperformancesolarschool)
		{
			return new IVisualNovelTransitionPerformanceConfigBase_UnionUnion
			{
				Type = IVisualNovelTransitionPerformanceConfigBase_Union.IVisualNovelTransitionPerformanceSolarSchool,
				Value = _ivisualnoveltransitionperformancesolarschool
			};
		}

		// Token: 0x06036FD8 RID: 225240 RVA: 0x007761F4 File Offset: 0x007743F4
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
