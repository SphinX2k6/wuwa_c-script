using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060B9 RID: 24761
	public class ITimeScheduleNpcSource_UnionUnion
	{
		// Token: 0x1700B810 RID: 47120
		// (get) Token: 0x06029E4C RID: 171596 RVA: 0x005B7F49 File Offset: 0x005B6149
		// (set) Token: 0x06029E4D RID: 171597 RVA: 0x005B7F51 File Offset: 0x005B6151
		public ITimeScheduleNpcSource_Union Type { get; set; }

		// Token: 0x1700B811 RID: 47121
		// (get) Token: 0x06029E4E RID: 171598 RVA: 0x005B7F5A File Offset: 0x005B615A
		// (set) Token: 0x06029E4F RID: 171599 RVA: 0x005B7F62 File Offset: 0x005B6162
		public object Value { get; set; }

		// Token: 0x06029E50 RID: 171600 RVA: 0x005B7F6B File Offset: 0x005B616B
		public ITimeScheduleNpcSource_UnionUnion()
		{
			this.Type = ITimeScheduleNpcSource_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029E51 RID: 171601 RVA: 0x005B7F81 File Offset: 0x005B6181
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029E52 RID: 171602 RVA: 0x005B7F93 File Offset: 0x005B6193
		public ITimeScheduleNpcSourceT AsITimeScheduleNpcSource()
		{
			return this.As<ITimeScheduleNpcSourceT>();
		}

		// Token: 0x06029E53 RID: 171603 RVA: 0x005B7F9B File Offset: 0x005B619B
		public static ITimeScheduleNpcSource_UnionUnion FromITimeScheduleNpcSource(ITimeScheduleNpcSourceT _itimeschedulenpcsource)
		{
			return new ITimeScheduleNpcSource_UnionUnion
			{
				Type = ITimeScheduleNpcSource_Union.ITimeScheduleNpcSource,
				Value = _itimeschedulenpcsource
			};
		}

		// Token: 0x06029E54 RID: 171604 RVA: 0x005B7FB0 File Offset: 0x005B61B0
		public ITimeScheduleEntityTemplateNpcSourceT AsITimeScheduleEntityTemplateNpcSource()
		{
			return this.As<ITimeScheduleEntityTemplateNpcSourceT>();
		}

		// Token: 0x06029E55 RID: 171605 RVA: 0x005B7FB8 File Offset: 0x005B61B8
		public static ITimeScheduleNpcSource_UnionUnion FromITimeScheduleEntityTemplateNpcSource(ITimeScheduleEntityTemplateNpcSourceT _itimescheduleentitytemplatenpcsource)
		{
			return new ITimeScheduleNpcSource_UnionUnion
			{
				Type = ITimeScheduleNpcSource_Union.ITimeScheduleEntityTemplateNpcSource,
				Value = _itimescheduleentitytemplatenpcsource
			};
		}

		// Token: 0x06029E56 RID: 171606 RVA: 0x005B7FD0 File Offset: 0x005B61D0
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
