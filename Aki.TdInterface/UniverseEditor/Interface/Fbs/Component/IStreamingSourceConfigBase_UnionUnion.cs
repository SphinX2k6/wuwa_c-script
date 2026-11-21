using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FE8 RID: 24552
	public class IStreamingSourceConfigBase_UnionUnion
	{
		// Token: 0x1700B609 RID: 46601
		// (get) Token: 0x060295D0 RID: 169424 RVA: 0x005A589D File Offset: 0x005A3A9D
		// (set) Token: 0x060295D1 RID: 169425 RVA: 0x005A58A5 File Offset: 0x005A3AA5
		public IStreamingSourceConfigBase_Union Type { get; set; }

		// Token: 0x1700B60A RID: 46602
		// (get) Token: 0x060295D2 RID: 169426 RVA: 0x005A58AE File Offset: 0x005A3AAE
		// (set) Token: 0x060295D3 RID: 169427 RVA: 0x005A58B6 File Offset: 0x005A3AB6
		public object Value { get; set; }

		// Token: 0x060295D4 RID: 169428 RVA: 0x005A58BF File Offset: 0x005A3ABF
		public IStreamingSourceConfigBase_UnionUnion()
		{
			this.Type = IStreamingSourceConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060295D5 RID: 169429 RVA: 0x005A58D5 File Offset: 0x005A3AD5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060295D6 RID: 169430 RVA: 0x005A58E7 File Offset: 0x005A3AE7
		public IStreamingSourceConfigBaseT AsIStreamingSourceConfigBase()
		{
			return this.As<IStreamingSourceConfigBaseT>();
		}

		// Token: 0x060295D7 RID: 169431 RVA: 0x005A58EF File Offset: 0x005A3AEF
		public static IStreamingSourceConfigBase_UnionUnion FromIStreamingSourceConfigBase(IStreamingSourceConfigBaseT _istreamingsourceconfigbase)
		{
			return new IStreamingSourceConfigBase_UnionUnion
			{
				Type = IStreamingSourceConfigBase_Union.IStreamingSourceConfigBase,
				Value = _istreamingsourceconfigbase
			};
		}

		// Token: 0x060295D8 RID: 169432 RVA: 0x005A5904 File Offset: 0x005A3B04
		public IFixedStreamingSourceT AsIFixedStreamingSource()
		{
			return this.As<IFixedStreamingSourceT>();
		}

		// Token: 0x060295D9 RID: 169433 RVA: 0x005A590C File Offset: 0x005A3B0C
		public static IStreamingSourceConfigBase_UnionUnion FromIFixedStreamingSource(IFixedStreamingSourceT _ifixedstreamingsource)
		{
			return new IStreamingSourceConfigBase_UnionUnion
			{
				Type = IStreamingSourceConfigBase_Union.IFixedStreamingSource,
				Value = _ifixedstreamingsource
			};
		}

		// Token: 0x060295DA RID: 169434 RVA: 0x005A5921 File Offset: 0x005A3B21
		public IConditionalStreamingSourceT AsIConditionalStreamingSource()
		{
			return this.As<IConditionalStreamingSourceT>();
		}

		// Token: 0x060295DB RID: 169435 RVA: 0x005A5929 File Offset: 0x005A3B29
		public static IStreamingSourceConfigBase_UnionUnion FromIConditionalStreamingSource(IConditionalStreamingSourceT _iconditionalstreamingsource)
		{
			return new IStreamingSourceConfigBase_UnionUnion
			{
				Type = IStreamingSourceConfigBase_Union.IConditionalStreamingSource,
				Value = _iconditionalstreamingsource
			};
		}

		// Token: 0x060295DC RID: 169436 RVA: 0x005A5940 File Offset: 0x005A3B40
		public static int Pack(FlatBufferBuilder builder, IStreamingSourceConfigBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IStreamingSourceConfigBase_Union.IStreamingSourceConfigBase:
				return IStreamingSourceConfigBase.Pack(builder, _o.AsIStreamingSourceConfigBase()).Value;
			case IStreamingSourceConfigBase_Union.IFixedStreamingSource:
				return IFixedStreamingSource.Pack(builder, _o.AsIFixedStreamingSource()).Value;
			case IStreamingSourceConfigBase_Union.IConditionalStreamingSource:
				return IConditionalStreamingSource.Pack(builder, _o.AsIConditionalStreamingSource()).Value;
			default:
				return 0;
			}
		}
	}
}
