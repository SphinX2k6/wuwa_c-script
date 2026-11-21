using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB8 RID: 23736
	public class IPasserbyNpcSource_UnionUnion
	{
		// Token: 0x1700AE5A RID: 44634
		// (get) Token: 0x06027625 RID: 161317 RVA: 0x00564131 File Offset: 0x00562331
		// (set) Token: 0x06027626 RID: 161318 RVA: 0x00564139 File Offset: 0x00562339
		public IPasserbyNpcSource_Union Type { get; set; }

		// Token: 0x1700AE5B RID: 44635
		// (get) Token: 0x06027627 RID: 161319 RVA: 0x00564142 File Offset: 0x00562342
		// (set) Token: 0x06027628 RID: 161320 RVA: 0x0056414A File Offset: 0x0056234A
		public object Value { get; set; }

		// Token: 0x06027629 RID: 161321 RVA: 0x00564153 File Offset: 0x00562353
		public IPasserbyNpcSource_UnionUnion()
		{
			this.Type = IPasserbyNpcSource_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602762A RID: 161322 RVA: 0x00564169 File Offset: 0x00562369
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602762B RID: 161323 RVA: 0x0056417B File Offset: 0x0056237B
		public IPasserbyNpcSourceT AsIPasserbyNpcSource()
		{
			return this.As<IPasserbyNpcSourceT>();
		}

		// Token: 0x0602762C RID: 161324 RVA: 0x00564183 File Offset: 0x00562383
		public static IPasserbyNpcSource_UnionUnion FromIPasserbyNpcSource(IPasserbyNpcSourceT _ipasserbynpcsource)
		{
			return new IPasserbyNpcSource_UnionUnion
			{
				Type = IPasserbyNpcSource_Union.IPasserbyNpcSource,
				Value = _ipasserbynpcsource
			};
		}

		// Token: 0x0602762D RID: 161325 RVA: 0x00564198 File Offset: 0x00562398
		public IPasserbyNpcTemplateSourceT AsIPasserbyNpcTemplateSource()
		{
			return this.As<IPasserbyNpcTemplateSourceT>();
		}

		// Token: 0x0602762E RID: 161326 RVA: 0x005641A0 File Offset: 0x005623A0
		public static IPasserbyNpcSource_UnionUnion FromIPasserbyNpcTemplateSource(IPasserbyNpcTemplateSourceT _ipasserbynpctemplatesource)
		{
			return new IPasserbyNpcSource_UnionUnion
			{
				Type = IPasserbyNpcSource_Union.IPasserbyNpcTemplateSource,
				Value = _ipasserbynpctemplatesource
			};
		}

		// Token: 0x0602762F RID: 161327 RVA: 0x005641B8 File Offset: 0x005623B8
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
