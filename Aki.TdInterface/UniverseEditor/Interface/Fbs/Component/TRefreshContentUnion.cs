using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062C8 RID: 25288
	public class TRefreshContentUnion
	{
		// Token: 0x1700BB9C RID: 48028
		// (get) Token: 0x0602AFC7 RID: 176071 RVA: 0x005DCEF2 File Offset: 0x005DB0F2
		// (set) Token: 0x0602AFC8 RID: 176072 RVA: 0x005DCEFA File Offset: 0x005DB0FA
		public TRefreshContent Type { get; set; }

		// Token: 0x1700BB9D RID: 48029
		// (get) Token: 0x0602AFC9 RID: 176073 RVA: 0x005DCF03 File Offset: 0x005DB103
		// (set) Token: 0x0602AFCA RID: 176074 RVA: 0x005DCF0B File Offset: 0x005DB10B
		public object Value { get; set; }

		// Token: 0x0602AFCB RID: 176075 RVA: 0x005DCF14 File Offset: 0x005DB114
		public TRefreshContentUnion()
		{
			this.Type = TRefreshContent.NONE;
			this.Value = null;
		}

		// Token: 0x0602AFCC RID: 176076 RVA: 0x005DCF2A File Offset: 0x005DB12A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AFCD RID: 176077 RVA: 0x005DCF3C File Offset: 0x005DB13C
		public IAllRefreshContentT AsIAllRefreshContent()
		{
			return this.As<IAllRefreshContentT>();
		}

		// Token: 0x0602AFCE RID: 176078 RVA: 0x005DCF44 File Offset: 0x005DB144
		public static TRefreshContentUnion FromIAllRefreshContent(IAllRefreshContentT _iallrefreshcontent)
		{
			return new TRefreshContentUnion
			{
				Type = TRefreshContent.IAllRefreshContent,
				Value = _iallrefreshcontent
			};
		}

		// Token: 0x0602AFCF RID: 176079 RVA: 0x005DCF59 File Offset: 0x005DB159
		public IRandomEntityRefreshContentT AsIRandomEntityRefreshContent()
		{
			return this.As<IRandomEntityRefreshContentT>();
		}

		// Token: 0x0602AFD0 RID: 176080 RVA: 0x005DCF61 File Offset: 0x005DB161
		public static TRefreshContentUnion FromIRandomEntityRefreshContent(IRandomEntityRefreshContentT _irandomentityrefreshcontent)
		{
			return new TRefreshContentUnion
			{
				Type = TRefreshContent.IRandomEntityRefreshContent,
				Value = _irandomentityrefreshcontent
			};
		}

		// Token: 0x0602AFD1 RID: 176081 RVA: 0x005DCF78 File Offset: 0x005DB178
		public static int Pack(FlatBufferBuilder builder, TRefreshContentUnion _o)
		{
			TRefreshContent type = _o.Type;
			if (type == TRefreshContent.IAllRefreshContent)
			{
				return IAllRefreshContent.Pack(builder, _o.AsIAllRefreshContent()).Value;
			}
			if (type != TRefreshContent.IRandomEntityRefreshContent)
			{
				return 0;
			}
			return IRandomEntityRefreshContent.Pack(builder, _o.AsIRandomEntityRefreshContent()).Value;
		}
	}
}
