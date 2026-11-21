using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062E3 RID: 25315
	public class TStreamingSourceConfigUnion
	{
		// Token: 0x1700BBAE RID: 48046
		// (get) Token: 0x0602B055 RID: 176213 RVA: 0x005DDC64 File Offset: 0x005DBE64
		// (set) Token: 0x0602B056 RID: 176214 RVA: 0x005DDC6C File Offset: 0x005DBE6C
		public TStreamingSourceConfig Type { get; set; }

		// Token: 0x1700BBAF RID: 48047
		// (get) Token: 0x0602B057 RID: 176215 RVA: 0x005DDC75 File Offset: 0x005DBE75
		// (set) Token: 0x0602B058 RID: 176216 RVA: 0x005DDC7D File Offset: 0x005DBE7D
		public object Value { get; set; }

		// Token: 0x0602B059 RID: 176217 RVA: 0x005DDC86 File Offset: 0x005DBE86
		public TStreamingSourceConfigUnion()
		{
			this.Type = TStreamingSourceConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602B05A RID: 176218 RVA: 0x005DDC9C File Offset: 0x005DBE9C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B05B RID: 176219 RVA: 0x005DDCAE File Offset: 0x005DBEAE
		public IConditionalStreamingSourceT AsIConditionalStreamingSource()
		{
			return this.As<IConditionalStreamingSourceT>();
		}

		// Token: 0x0602B05C RID: 176220 RVA: 0x005DDCB6 File Offset: 0x005DBEB6
		public static TStreamingSourceConfigUnion FromIConditionalStreamingSource(IConditionalStreamingSourceT _iconditionalstreamingsource)
		{
			return new TStreamingSourceConfigUnion
			{
				Type = TStreamingSourceConfig.IConditionalStreamingSource,
				Value = _iconditionalstreamingsource
			};
		}

		// Token: 0x0602B05D RID: 176221 RVA: 0x005DDCCB File Offset: 0x005DBECB
		public IFixedStreamingSourceT AsIFixedStreamingSource()
		{
			return this.As<IFixedStreamingSourceT>();
		}

		// Token: 0x0602B05E RID: 176222 RVA: 0x005DDCD3 File Offset: 0x005DBED3
		public static TStreamingSourceConfigUnion FromIFixedStreamingSource(IFixedStreamingSourceT _ifixedstreamingsource)
		{
			return new TStreamingSourceConfigUnion
			{
				Type = TStreamingSourceConfig.IFixedStreamingSource,
				Value = _ifixedstreamingsource
			};
		}

		// Token: 0x0602B05F RID: 176223 RVA: 0x005DDCE8 File Offset: 0x005DBEE8
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
