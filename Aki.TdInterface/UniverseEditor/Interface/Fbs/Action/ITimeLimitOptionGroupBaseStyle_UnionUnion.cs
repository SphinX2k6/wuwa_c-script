using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BCA RID: 31690
	public class ITimeLimitOptionGroupBaseStyle_UnionUnion
	{
		// Token: 0x1700ED6A RID: 60778
		// (get) Token: 0x060391E4 RID: 233956 RVA: 0x007B80FD File Offset: 0x007B62FD
		// (set) Token: 0x060391E5 RID: 233957 RVA: 0x007B8105 File Offset: 0x007B6305
		public ITimeLimitOptionGroupBaseStyle_Union Type { get; set; }

		// Token: 0x1700ED6B RID: 60779
		// (get) Token: 0x060391E6 RID: 233958 RVA: 0x007B810E File Offset: 0x007B630E
		// (set) Token: 0x060391E7 RID: 233959 RVA: 0x007B8116 File Offset: 0x007B6316
		public object Value { get; set; }

		// Token: 0x060391E8 RID: 233960 RVA: 0x007B811F File Offset: 0x007B631F
		public ITimeLimitOptionGroupBaseStyle_UnionUnion()
		{
			this.Type = ITimeLimitOptionGroupBaseStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060391E9 RID: 233961 RVA: 0x007B8135 File Offset: 0x007B6335
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060391EA RID: 233962 RVA: 0x007B8147 File Offset: 0x007B6347
		public ITimeLimitOptionGroupBaseStyleT AsITimeLimitOptionGroupBaseStyle()
		{
			return this.As<ITimeLimitOptionGroupBaseStyleT>();
		}

		// Token: 0x060391EB RID: 233963 RVA: 0x007B814F File Offset: 0x007B634F
		public static ITimeLimitOptionGroupBaseStyle_UnionUnion FromITimeLimitOptionGroupBaseStyle(ITimeLimitOptionGroupBaseStyleT _itimelimitoptiongroupbasestyle)
		{
			return new ITimeLimitOptionGroupBaseStyle_UnionUnion
			{
				Type = ITimeLimitOptionGroupBaseStyle_Union.ITimeLimitOptionGroupBaseStyle,
				Value = _itimelimitoptiongroupbasestyle
			};
		}

		// Token: 0x060391EC RID: 233964 RVA: 0x007B8164 File Offset: 0x007B6364
		public ITimeLimitOptionGroupDefaultT AsITimeLimitOptionGroupDefault()
		{
			return this.As<ITimeLimitOptionGroupDefaultT>();
		}

		// Token: 0x060391ED RID: 233965 RVA: 0x007B816C File Offset: 0x007B636C
		public static ITimeLimitOptionGroupBaseStyle_UnionUnion FromITimeLimitOptionGroupDefault(ITimeLimitOptionGroupDefaultT _itimelimitoptiongroupdefault)
		{
			return new ITimeLimitOptionGroupBaseStyle_UnionUnion
			{
				Type = ITimeLimitOptionGroupBaseStyle_Union.ITimeLimitOptionGroupDefault,
				Value = _itimelimitoptiongroupdefault
			};
		}

		// Token: 0x060391EE RID: 233966 RVA: 0x007B8184 File Offset: 0x007B6384
		public static int Pack(FlatBufferBuilder builder, ITimeLimitOptionGroupBaseStyle_UnionUnion _o)
		{
			ITimeLimitOptionGroupBaseStyle_Union type = _o.Type;
			if (type == ITimeLimitOptionGroupBaseStyle_Union.ITimeLimitOptionGroupBaseStyle)
			{
				return ITimeLimitOptionGroupBaseStyle.Pack(builder, _o.AsITimeLimitOptionGroupBaseStyle()).Value;
			}
			if (type != ITimeLimitOptionGroupBaseStyle_Union.ITimeLimitOptionGroupDefault)
			{
				return 0;
			}
			return ITimeLimitOptionGroupDefault.Pack(builder, _o.AsITimeLimitOptionGroupDefault()).Value;
		}
	}
}
