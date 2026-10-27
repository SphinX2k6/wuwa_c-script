using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB2 RID: 23730
	public class TStreamingSourceConfigUnion
	{
		// Token: 0x1700B254 RID: 45652
		// (get) Token: 0x06028A0D RID: 166413 RVA: 0x005954F0 File Offset: 0x005936F0
		// (set) Token: 0x06028A0E RID: 166414 RVA: 0x005954F8 File Offset: 0x005936F8
		public TStreamingSourceConfig Type { get; set; }

		// Token: 0x1700B255 RID: 45653
		// (get) Token: 0x06028A0F RID: 166415 RVA: 0x00595501 File Offset: 0x00593701
		// (set) Token: 0x06028A10 RID: 166416 RVA: 0x00595509 File Offset: 0x00593709
		public object Value { get; set; }

		// Token: 0x06028A11 RID: 166417 RVA: 0x00595512 File Offset: 0x00593712
		public TStreamingSourceConfigUnion()
		{
			this.Type = TStreamingSourceConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06028A12 RID: 166418 RVA: 0x00595528 File Offset: 0x00593728
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A13 RID: 166419 RVA: 0x0059553A File Offset: 0x0059373A
		public IConditionalStreamingSourceT AsIConditionalStreamingSource()
		{
			return this.As<IConditionalStreamingSourceT>();
		}

		// Token: 0x06028A14 RID: 166420 RVA: 0x00595542 File Offset: 0x00593742
		public static TStreamingSourceConfigUnion FromIConditionalStreamingSource(IConditionalStreamingSourceT _iconditionalstreamingsource)
		{
			return new TStreamingSourceConfigUnion
			{
				Type = TStreamingSourceConfig.IConditionalStreamingSource,
				Value = _iconditionalstreamingsource
			};
		}

		// Token: 0x06028A15 RID: 166421 RVA: 0x00595557 File Offset: 0x00593757
		public IFixedStreamingSourceT AsIFixedStreamingSource()
		{
			return this.As<IFixedStreamingSourceT>();
		}

		// Token: 0x06028A16 RID: 166422 RVA: 0x0059555F File Offset: 0x0059375F
		public static TStreamingSourceConfigUnion FromIFixedStreamingSource(IFixedStreamingSourceT _ifixedstreamingsource)
		{
			return new TStreamingSourceConfigUnion
			{
				Type = TStreamingSourceConfig.IFixedStreamingSource,
				Value = _ifixedstreamingsource
			};
		}

		// Token: 0x06028A17 RID: 166423 RVA: 0x00595574 File Offset: 0x00593774
		public static int Pack(FlatBufferBuilder builder, TStreamingSourceConfigUnion _o)
		{
			TStreamingSourceConfig type = _o.Type;
			if (type == TStreamingSourceConfig.IConditionalStreamingSource)
			{
				return IConditionalStreamingSource.Pack(builder, _o.AsIConditionalStreamingSource()).Value;
			}
			if (type != TStreamingSourceConfig.IFixedStreamingSource)
			{
				return 0;
			}
			return IFixedStreamingSource.Pack(builder, _o.AsIFixedStreamingSource()).Value;
		}
	}
}
