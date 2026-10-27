using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C97 RID: 23703
	public class TRefreshContentUnion
	{
		// Token: 0x1700B242 RID: 45634
		// (get) Token: 0x06028981 RID: 166273 RVA: 0x005947BA File Offset: 0x005929BA
		// (set) Token: 0x06028982 RID: 166274 RVA: 0x005947C2 File Offset: 0x005929C2
		public TRefreshContent Type { get; set; }

		// Token: 0x1700B243 RID: 45635
		// (get) Token: 0x06028983 RID: 166275 RVA: 0x005947CB File Offset: 0x005929CB
		// (set) Token: 0x06028984 RID: 166276 RVA: 0x005947D3 File Offset: 0x005929D3
		public object Value { get; set; }

		// Token: 0x06028985 RID: 166277 RVA: 0x005947DC File Offset: 0x005929DC
		public TRefreshContentUnion()
		{
			this.Type = TRefreshContent.NONE;
			this.Value = null;
		}

		// Token: 0x06028986 RID: 166278 RVA: 0x005947F2 File Offset: 0x005929F2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028987 RID: 166279 RVA: 0x00594804 File Offset: 0x00592A04
		public IAllRefreshContentT AsIAllRefreshContent()
		{
			return this.As<IAllRefreshContentT>();
		}

		// Token: 0x06028988 RID: 166280 RVA: 0x0059480C File Offset: 0x00592A0C
		public static TRefreshContentUnion FromIAllRefreshContent(IAllRefreshContentT _iallrefreshcontent)
		{
			return new TRefreshContentUnion
			{
				Type = TRefreshContent.IAllRefreshContent,
				Value = _iallrefreshcontent
			};
		}

		// Token: 0x06028989 RID: 166281 RVA: 0x00594821 File Offset: 0x00592A21
		public IRandomEntityRefreshContentT AsIRandomEntityRefreshContent()
		{
			return this.As<IRandomEntityRefreshContentT>();
		}

		// Token: 0x0602898A RID: 166282 RVA: 0x00594829 File Offset: 0x00592A29
		public static TRefreshContentUnion FromIRandomEntityRefreshContent(IRandomEntityRefreshContentT _irandomentityrefreshcontent)
		{
			return new TRefreshContentUnion
			{
				Type = TRefreshContent.IRandomEntityRefreshContent,
				Value = _irandomentityrefreshcontent
			};
		}

		// Token: 0x0602898B RID: 166283 RVA: 0x00594840 File Offset: 0x00592A40
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
