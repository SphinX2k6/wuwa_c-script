using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E2B RID: 24107
	public class IRefreshContent_UnionUnion
	{
		// Token: 0x1700B1A9 RID: 45481
		// (get) Token: 0x06028420 RID: 164896 RVA: 0x005812A5 File Offset: 0x0057F4A5
		// (set) Token: 0x06028421 RID: 164897 RVA: 0x005812AD File Offset: 0x0057F4AD
		public IRefreshContent_Union Type { get; set; }

		// Token: 0x1700B1AA RID: 45482
		// (get) Token: 0x06028422 RID: 164898 RVA: 0x005812B6 File Offset: 0x0057F4B6
		// (set) Token: 0x06028423 RID: 164899 RVA: 0x005812BE File Offset: 0x0057F4BE
		public object Value { get; set; }

		// Token: 0x06028424 RID: 164900 RVA: 0x005812C7 File Offset: 0x0057F4C7
		public IRefreshContent_UnionUnion()
		{
			this.Type = IRefreshContent_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028425 RID: 164901 RVA: 0x005812DD File Offset: 0x0057F4DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028426 RID: 164902 RVA: 0x005812EF File Offset: 0x0057F4EF
		public IRefreshContentT AsIRefreshContent()
		{
			return this.As<IRefreshContentT>();
		}

		// Token: 0x06028427 RID: 164903 RVA: 0x005812F7 File Offset: 0x0057F4F7
		public static IRefreshContent_UnionUnion FromIRefreshContent(IRefreshContentT _irefreshcontent)
		{
			return new IRefreshContent_UnionUnion
			{
				Type = IRefreshContent_Union.IRefreshContent,
				Value = _irefreshcontent
			};
		}

		// Token: 0x06028428 RID: 164904 RVA: 0x0058130C File Offset: 0x0057F50C
		public IAllRefreshContentT AsIAllRefreshContent()
		{
			return this.As<IAllRefreshContentT>();
		}

		// Token: 0x06028429 RID: 164905 RVA: 0x00581314 File Offset: 0x0057F514
		public static IRefreshContent_UnionUnion FromIAllRefreshContent(IAllRefreshContentT _iallrefreshcontent)
		{
			return new IRefreshContent_UnionUnion
			{
				Type = IRefreshContent_Union.IAllRefreshContent,
				Value = _iallrefreshcontent
			};
		}

		// Token: 0x0602842A RID: 164906 RVA: 0x00581329 File Offset: 0x0057F529
		public IRandomEntityRefreshContentT AsIRandomEntityRefreshContent()
		{
			return this.As<IRandomEntityRefreshContentT>();
		}

		// Token: 0x0602842B RID: 164907 RVA: 0x00581331 File Offset: 0x0057F531
		public static IRefreshContent_UnionUnion FromIRandomEntityRefreshContent(IRandomEntityRefreshContentT _irandomentityrefreshcontent)
		{
			return new IRefreshContent_UnionUnion
			{
				Type = IRefreshContent_Union.IRandomEntityRefreshContent,
				Value = _irandomentityrefreshcontent
			};
		}

		// Token: 0x0602842C RID: 164908 RVA: 0x00581348 File Offset: 0x0057F548
		public static int Pack(FlatBufferBuilder builder, IRefreshContent_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRefreshContent_Union.IRefreshContent:
				return IRefreshContent.Pack(builder, _o.AsIRefreshContent()).Value;
			case IRefreshContent_Union.IAllRefreshContent:
				return IAllRefreshContent.Pack(builder, _o.AsIAllRefreshContent()).Value;
			case IRefreshContent_Union.IRandomEntityRefreshContent:
				return IRandomEntityRefreshContent.Pack(builder, _o.AsIRandomEntityRefreshContent()).Value;
			default:
				return 0;
			}
		}
	}
}
