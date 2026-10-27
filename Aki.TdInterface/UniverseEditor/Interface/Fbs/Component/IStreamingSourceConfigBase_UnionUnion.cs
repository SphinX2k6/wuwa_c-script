using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059DB RID: 23003
	public class IStreamingSourceConfigBase_UnionUnion
	{
		// Token: 0x1700ACD1 RID: 44241
		// (get) Token: 0x06027058 RID: 159832 RVA: 0x0055E8D9 File Offset: 0x0055CAD9
		// (set) Token: 0x06027059 RID: 159833 RVA: 0x0055E8E1 File Offset: 0x0055CAE1
		public IStreamingSourceConfigBase_Union Type { get; set; }

		// Token: 0x1700ACD2 RID: 44242
		// (get) Token: 0x0602705A RID: 159834 RVA: 0x0055E8EA File Offset: 0x0055CAEA
		// (set) Token: 0x0602705B RID: 159835 RVA: 0x0055E8F2 File Offset: 0x0055CAF2
		public object Value { get; set; }

		// Token: 0x0602705C RID: 159836 RVA: 0x0055E8FB File Offset: 0x0055CAFB
		public IStreamingSourceConfigBase_UnionUnion()
		{
			this.Type = IStreamingSourceConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602705D RID: 159837 RVA: 0x0055E911 File Offset: 0x0055CB11
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602705E RID: 159838 RVA: 0x0055E923 File Offset: 0x0055CB23
		public IStreamingSourceConfigBaseT AsIStreamingSourceConfigBase()
		{
			return this.As<IStreamingSourceConfigBaseT>();
		}

		// Token: 0x0602705F RID: 159839 RVA: 0x0055E92B File Offset: 0x0055CB2B
		public static IStreamingSourceConfigBase_UnionUnion FromIStreamingSourceConfigBase(IStreamingSourceConfigBaseT _istreamingsourceconfigbase)
		{
			return new IStreamingSourceConfigBase_UnionUnion
			{
				Type = IStreamingSourceConfigBase_Union.IStreamingSourceConfigBase,
				Value = _istreamingsourceconfigbase
			};
		}

		// Token: 0x06027060 RID: 159840 RVA: 0x0055E940 File Offset: 0x0055CB40
		public IFixedStreamingSourceT AsIFixedStreamingSource()
		{
			return this.As<IFixedStreamingSourceT>();
		}

		// Token: 0x06027061 RID: 159841 RVA: 0x0055E948 File Offset: 0x0055CB48
		public static IStreamingSourceConfigBase_UnionUnion FromIFixedStreamingSource(IFixedStreamingSourceT _ifixedstreamingsource)
		{
			return new IStreamingSourceConfigBase_UnionUnion
			{
				Type = IStreamingSourceConfigBase_Union.IFixedStreamingSource,
				Value = _ifixedstreamingsource
			};
		}

		// Token: 0x06027062 RID: 159842 RVA: 0x0055E95D File Offset: 0x0055CB5D
		public IConditionalStreamingSourceT AsIConditionalStreamingSource()
		{
			return this.As<IConditionalStreamingSourceT>();
		}

		// Token: 0x06027063 RID: 159843 RVA: 0x0055E965 File Offset: 0x0055CB65
		public static IStreamingSourceConfigBase_UnionUnion FromIConditionalStreamingSource(IConditionalStreamingSourceT _iconditionalstreamingsource)
		{
			return new IStreamingSourceConfigBase_UnionUnion
			{
				Type = IStreamingSourceConfigBase_Union.IConditionalStreamingSource,
				Value = _iconditionalstreamingsource
			};
		}

		// Token: 0x06027064 RID: 159844 RVA: 0x0055E97C File Offset: 0x0055CB7C
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
