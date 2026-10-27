using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAC RID: 23212
	public class ITimeScheduleNpcSource_UnionUnion
	{
		// Token: 0x1700AED6 RID: 44758
		// (get) Token: 0x060278CA RID: 161994 RVA: 0x00570D09 File Offset: 0x0056EF09
		// (set) Token: 0x060278CB RID: 161995 RVA: 0x00570D11 File Offset: 0x0056EF11
		public ITimeScheduleNpcSource_Union Type { get; set; }

		// Token: 0x1700AED7 RID: 44759
		// (get) Token: 0x060278CC RID: 161996 RVA: 0x00570D1A File Offset: 0x0056EF1A
		// (set) Token: 0x060278CD RID: 161997 RVA: 0x00570D22 File Offset: 0x0056EF22
		public object Value { get; set; }

		// Token: 0x060278CE RID: 161998 RVA: 0x00570D2B File Offset: 0x0056EF2B
		public ITimeScheduleNpcSource_UnionUnion()
		{
			this.Type = ITimeScheduleNpcSource_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060278CF RID: 161999 RVA: 0x00570D41 File Offset: 0x0056EF41
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060278D0 RID: 162000 RVA: 0x00570D53 File Offset: 0x0056EF53
		public ITimeScheduleNpcSourceT AsITimeScheduleNpcSource()
		{
			return this.As<ITimeScheduleNpcSourceT>();
		}

		// Token: 0x060278D1 RID: 162001 RVA: 0x00570D5B File Offset: 0x0056EF5B
		public static ITimeScheduleNpcSource_UnionUnion FromITimeScheduleNpcSource(ITimeScheduleNpcSourceT _itimeschedulenpcsource)
		{
			return new ITimeScheduleNpcSource_UnionUnion
			{
				Type = ITimeScheduleNpcSource_Union.ITimeScheduleNpcSource,
				Value = _itimeschedulenpcsource
			};
		}

		// Token: 0x060278D2 RID: 162002 RVA: 0x00570D70 File Offset: 0x0056EF70
		public ITimeScheduleEntityTemplateNpcSourceT AsITimeScheduleEntityTemplateNpcSource()
		{
			return this.As<ITimeScheduleEntityTemplateNpcSourceT>();
		}

		// Token: 0x060278D3 RID: 162003 RVA: 0x00570D78 File Offset: 0x0056EF78
		public static ITimeScheduleNpcSource_UnionUnion FromITimeScheduleEntityTemplateNpcSource(ITimeScheduleEntityTemplateNpcSourceT _itimescheduleentitytemplatenpcsource)
		{
			return new ITimeScheduleNpcSource_UnionUnion
			{
				Type = ITimeScheduleNpcSource_Union.ITimeScheduleEntityTemplateNpcSource,
				Value = _itimescheduleentitytemplatenpcsource
			};
		}

		// Token: 0x060278D4 RID: 162004 RVA: 0x00570D90 File Offset: 0x0056EF90
		public static int Pack(FlatBufferBuilder builder, ITimeScheduleNpcSource_UnionUnion _o)
		{
			ITimeScheduleNpcSource_Union type = _o.Type;
			if (type == ITimeScheduleNpcSource_Union.ITimeScheduleNpcSource)
			{
				return ITimeScheduleNpcSource.Pack(builder, _o.AsITimeScheduleNpcSource()).Value;
			}
			if (type != ITimeScheduleNpcSource_Union.ITimeScheduleEntityTemplateNpcSource)
			{
				return 0;
			}
			return ITimeScheduleEntityTemplateNpcSource.Pack(builder, _o.AsITimeScheduleEntityTemplateNpcSource()).Value;
		}
	}
}
