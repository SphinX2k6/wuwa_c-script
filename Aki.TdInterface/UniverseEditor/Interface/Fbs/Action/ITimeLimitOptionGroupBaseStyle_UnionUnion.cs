using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E0 RID: 29664
	public class ITimeLimitOptionGroupBaseStyle_UnionUnion
	{
		// Token: 0x1700E155 RID: 57685
		// (get) Token: 0x06035E31 RID: 220721 RVA: 0x00755989 File Offset: 0x00753B89
		// (set) Token: 0x06035E32 RID: 220722 RVA: 0x00755991 File Offset: 0x00753B91
		public ITimeLimitOptionGroupBaseStyle_Union Type { get; set; }

		// Token: 0x1700E156 RID: 57686
		// (get) Token: 0x06035E33 RID: 220723 RVA: 0x0075599A File Offset: 0x00753B9A
		// (set) Token: 0x06035E34 RID: 220724 RVA: 0x007559A2 File Offset: 0x00753BA2
		public object Value { get; set; }

		// Token: 0x06035E35 RID: 220725 RVA: 0x007559AB File Offset: 0x00753BAB
		public ITimeLimitOptionGroupBaseStyle_UnionUnion()
		{
			this.Type = ITimeLimitOptionGroupBaseStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035E36 RID: 220726 RVA: 0x007559C1 File Offset: 0x00753BC1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035E37 RID: 220727 RVA: 0x007559D3 File Offset: 0x00753BD3
		public ITimeLimitOptionGroupBaseStyleT AsITimeLimitOptionGroupBaseStyle()
		{
			return this.As<ITimeLimitOptionGroupBaseStyleT>();
		}

		// Token: 0x06035E38 RID: 220728 RVA: 0x007559DB File Offset: 0x00753BDB
		public static ITimeLimitOptionGroupBaseStyle_UnionUnion FromITimeLimitOptionGroupBaseStyle(ITimeLimitOptionGroupBaseStyleT _itimelimitoptiongroupbasestyle)
		{
			return new ITimeLimitOptionGroupBaseStyle_UnionUnion
			{
				Type = ITimeLimitOptionGroupBaseStyle_Union.ITimeLimitOptionGroupBaseStyle,
				Value = _itimelimitoptiongroupbasestyle
			};
		}

		// Token: 0x06035E39 RID: 220729 RVA: 0x007559F0 File Offset: 0x00753BF0
		public ITimeLimitOptionGroupDefaultT AsITimeLimitOptionGroupDefault()
		{
			return this.As<ITimeLimitOptionGroupDefaultT>();
		}

		// Token: 0x06035E3A RID: 220730 RVA: 0x007559F8 File Offset: 0x00753BF8
		public static ITimeLimitOptionGroupBaseStyle_UnionUnion FromITimeLimitOptionGroupDefault(ITimeLimitOptionGroupDefaultT _itimelimitoptiongroupdefault)
		{
			return new ITimeLimitOptionGroupBaseStyle_UnionUnion
			{
				Type = ITimeLimitOptionGroupBaseStyle_Union.ITimeLimitOptionGroupDefault,
				Value = _itimelimitoptiongroupdefault
			};
		}

		// Token: 0x06035E3B RID: 220731 RVA: 0x00755A10 File Offset: 0x00753C10
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
