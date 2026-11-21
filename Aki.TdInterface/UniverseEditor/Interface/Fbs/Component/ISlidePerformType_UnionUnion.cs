using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F40 RID: 24384
	public class ISlidePerformType_UnionUnion
	{
		// Token: 0x1700B48F RID: 46223
		// (get) Token: 0x06028F80 RID: 167808 RVA: 0x00598E69 File Offset: 0x00597069
		// (set) Token: 0x06028F81 RID: 167809 RVA: 0x00598E71 File Offset: 0x00597071
		public ISlidePerformType_Union Type { get; set; }

		// Token: 0x1700B490 RID: 46224
		// (get) Token: 0x06028F82 RID: 167810 RVA: 0x00598E7A File Offset: 0x0059707A
		// (set) Token: 0x06028F83 RID: 167811 RVA: 0x00598E82 File Offset: 0x00597082
		public object Value { get; set; }

		// Token: 0x06028F84 RID: 167812 RVA: 0x00598E8B File Offset: 0x0059708B
		public ISlidePerformType_UnionUnion()
		{
			this.Type = ISlidePerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028F85 RID: 167813 RVA: 0x00598EA1 File Offset: 0x005970A1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028F86 RID: 167814 RVA: 0x00598EB3 File Offset: 0x005970B3
		public ISlidePerformTypeT AsISlidePerformType()
		{
			return this.As<ISlidePerformTypeT>();
		}

		// Token: 0x06028F87 RID: 167815 RVA: 0x00598EBB File Offset: 0x005970BB
		public static ISlidePerformType_UnionUnion FromISlidePerformType(ISlidePerformTypeT _islideperformtype)
		{
			return new ISlidePerformType_UnionUnion
			{
				Type = ISlidePerformType_Union.ISlidePerformType,
				Value = _islideperformtype
			};
		}

		// Token: 0x06028F88 RID: 167816 RVA: 0x00598ED0 File Offset: 0x005970D0
		public ISlopeSlidePerformT AsISlopeSlidePerform()
		{
			return this.As<ISlopeSlidePerformT>();
		}

		// Token: 0x06028F89 RID: 167817 RVA: 0x00598ED8 File Offset: 0x005970D8
		public static ISlidePerformType_UnionUnion FromISlopeSlidePerform(ISlopeSlidePerformT _islopeslideperform)
		{
			return new ISlidePerformType_UnionUnion
			{
				Type = ISlidePerformType_Union.ISlopeSlidePerform,
				Value = _islopeslideperform
			};
		}

		// Token: 0x06028F8A RID: 167818 RVA: 0x00598EF0 File Offset: 0x005970F0
		public static int Pack(FlatBufferBuilder builder, ISlidePerformType_UnionUnion _o)
		{
			ISlidePerformType_Union type = _o.Type;
			if (type == ISlidePerformType_Union.ISlidePerformType)
			{
				return ISlidePerformType.Pack(builder, _o.AsISlidePerformType()).Value;
			}
			if (type != ISlidePerformType_Union.ISlopeSlidePerform)
			{
				return 0;
			}
			return ISlopeSlidePerform.Pack(builder, _o.AsISlopeSlidePerform()).Value;
		}
	}
}
