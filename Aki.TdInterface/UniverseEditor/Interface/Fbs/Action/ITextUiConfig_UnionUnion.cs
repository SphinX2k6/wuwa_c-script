using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BBE RID: 31678
	public class ITextUiConfig_UnionUnion
	{
		// Token: 0x1700ED5D RID: 60765
		// (get) Token: 0x0603919C RID: 233884 RVA: 0x007B7A5C File Offset: 0x007B5C5C
		// (set) Token: 0x0603919D RID: 233885 RVA: 0x007B7A64 File Offset: 0x007B5C64
		public ITextUiConfig_Union Type { get; set; }

		// Token: 0x1700ED5E RID: 60766
		// (get) Token: 0x0603919E RID: 233886 RVA: 0x007B7A6D File Offset: 0x007B5C6D
		// (set) Token: 0x0603919F RID: 233887 RVA: 0x007B7A75 File Offset: 0x007B5C75
		public object Value { get; set; }

		// Token: 0x060391A0 RID: 233888 RVA: 0x007B7A7E File Offset: 0x007B5C7E
		public ITextUiConfig_UnionUnion()
		{
			this.Type = ITextUiConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060391A1 RID: 233889 RVA: 0x007B7A94 File Offset: 0x007B5C94
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060391A2 RID: 233890 RVA: 0x007B7AA6 File Offset: 0x007B5CA6
		public ITextUiConfigT AsITextUiConfig()
		{
			return this.As<ITextUiConfigT>();
		}

		// Token: 0x060391A3 RID: 233891 RVA: 0x007B7AAE File Offset: 0x007B5CAE
		public static ITextUiConfig_UnionUnion FromITextUiConfig(ITextUiConfigT _itextuiconfig)
		{
			return new ITextUiConfig_UnionUnion
			{
				Type = ITextUiConfig_Union.ITextUiConfig,
				Value = _itextuiconfig
			};
		}

		// Token: 0x060391A4 RID: 233892 RVA: 0x007B7AC3 File Offset: 0x007B5CC3
		public IAstrologyTextUiConfigT AsIAstrologyTextUiConfig()
		{
			return this.As<IAstrologyTextUiConfigT>();
		}

		// Token: 0x060391A5 RID: 233893 RVA: 0x007B7ACB File Offset: 0x007B5CCB
		public static ITextUiConfig_UnionUnion FromIAstrologyTextUiConfig(IAstrologyTextUiConfigT _iastrologytextuiconfig)
		{
			return new ITextUiConfig_UnionUnion
			{
				Type = ITextUiConfig_Union.IAstrologyTextUiConfig,
				Value = _iastrologytextuiconfig
			};
		}

		// Token: 0x060391A6 RID: 233894 RVA: 0x007B7AE0 File Offset: 0x007B5CE0
		public static int Pack(FlatBufferBuilder builder, ITextUiConfig_UnionUnion _o)
		{
			ITextUiConfig_Union type = _o.Type;
			if (type == ITextUiConfig_Union.ITextUiConfig)
			{
				return ITextUiConfig.Pack(builder, _o.AsITextUiConfig()).Value;
			}
			if (type != ITextUiConfig_Union.IAstrologyTextUiConfig)
			{
				return 0;
			}
			return IAstrologyTextUiConfig.Pack(builder, _o.AsIAstrologyTextUiConfig()).Value;
		}
	}
}
