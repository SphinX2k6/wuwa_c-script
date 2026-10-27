using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D2 RID: 22226
	public class IPasserbyNpcSource_UnionUnion
	{
		// Token: 0x1700A565 RID: 42341
		// (get) Token: 0x06025204 RID: 152068 RVA: 0x00520065 File Offset: 0x0051E265
		// (set) Token: 0x06025205 RID: 152069 RVA: 0x0052006D File Offset: 0x0051E26D
		public IPasserbyNpcSource_Union Type { get; set; }

		// Token: 0x1700A566 RID: 42342
		// (get) Token: 0x06025206 RID: 152070 RVA: 0x00520076 File Offset: 0x0051E276
		// (set) Token: 0x06025207 RID: 152071 RVA: 0x0052007E File Offset: 0x0051E27E
		public object Value { get; set; }

		// Token: 0x06025208 RID: 152072 RVA: 0x00520087 File Offset: 0x0051E287
		public IPasserbyNpcSource_UnionUnion()
		{
			this.Type = IPasserbyNpcSource_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025209 RID: 152073 RVA: 0x0052009D File Offset: 0x0051E29D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602520A RID: 152074 RVA: 0x005200AF File Offset: 0x0051E2AF
		public IPasserbyNpcSourceT AsIPasserbyNpcSource()
		{
			return this.As<IPasserbyNpcSourceT>();
		}

		// Token: 0x0602520B RID: 152075 RVA: 0x005200B7 File Offset: 0x0051E2B7
		public static IPasserbyNpcSource_UnionUnion FromIPasserbyNpcSource(IPasserbyNpcSourceT _ipasserbynpcsource)
		{
			return new IPasserbyNpcSource_UnionUnion
			{
				Type = IPasserbyNpcSource_Union.IPasserbyNpcSource,
				Value = _ipasserbynpcsource
			};
		}

		// Token: 0x0602520C RID: 152076 RVA: 0x005200CC File Offset: 0x0051E2CC
		public IPasserbyNpcTemplateSourceT AsIPasserbyNpcTemplateSource()
		{
			return this.As<IPasserbyNpcTemplateSourceT>();
		}

		// Token: 0x0602520D RID: 152077 RVA: 0x005200D4 File Offset: 0x0051E2D4
		public static IPasserbyNpcSource_UnionUnion FromIPasserbyNpcTemplateSource(IPasserbyNpcTemplateSourceT _ipasserbynpctemplatesource)
		{
			return new IPasserbyNpcSource_UnionUnion
			{
				Type = IPasserbyNpcSource_Union.IPasserbyNpcTemplateSource,
				Value = _ipasserbynpctemplatesource
			};
		}

		// Token: 0x0602520E RID: 152078 RVA: 0x005200EC File Offset: 0x0051E2EC
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcSource_UnionUnion _o)
		{
			IPasserbyNpcSource_Union type = _o.Type;
			if (type == IPasserbyNpcSource_Union.IPasserbyNpcSource)
			{
				return IPasserbyNpcSource.Pack(builder, _o.AsIPasserbyNpcSource()).Value;
			}
			if (type != IPasserbyNpcSource_Union.IPasserbyNpcTemplateSource)
			{
				return 0;
			}
			return IPasserbyNpcTemplateSource.Pack(builder, _o.AsIPasserbyNpcTemplateSource()).Value;
		}
	}
}
