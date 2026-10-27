using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C9A RID: 23706
	public class TRefreshRuleUnion
	{
		// Token: 0x1700B244 RID: 45636
		// (get) Token: 0x0602898D RID: 166285 RVA: 0x005948B6 File Offset: 0x00592AB6
		// (set) Token: 0x0602898E RID: 166286 RVA: 0x005948BE File Offset: 0x00592ABE
		public TRefreshRule Type { get; set; }

		// Token: 0x1700B245 RID: 45637
		// (get) Token: 0x0602898F RID: 166287 RVA: 0x005948C7 File Offset: 0x00592AC7
		// (set) Token: 0x06028990 RID: 166288 RVA: 0x005948CF File Offset: 0x00592ACF
		public object Value { get; set; }

		// Token: 0x06028991 RID: 166289 RVA: 0x005948D8 File Offset: 0x00592AD8
		public TRefreshRuleUnion()
		{
			this.Type = TRefreshRule.NONE;
			this.Value = null;
		}

		// Token: 0x06028992 RID: 166290 RVA: 0x005948EE File Offset: 0x00592AEE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028993 RID: 166291 RVA: 0x00594900 File Offset: 0x00592B00
		public ICdRefreshRuleT AsICdRefreshRule()
		{
			return this.As<ICdRefreshRuleT>();
		}

		// Token: 0x06028994 RID: 166292 RVA: 0x00594908 File Offset: 0x00592B08
		public static TRefreshRuleUnion FromICdRefreshRule(ICdRefreshRuleT _icdrefreshrule)
		{
			return new TRefreshRuleUnion
			{
				Type = TRefreshRule.ICdRefreshRule,
				Value = _icdrefreshrule
			};
		}

		// Token: 0x06028995 RID: 166293 RVA: 0x0059491D File Offset: 0x00592B1D
		public IFixedDateTimeRefreshRuleT AsIFixedDateTimeRefreshRule()
		{
			return this.As<IFixedDateTimeRefreshRuleT>();
		}

		// Token: 0x06028996 RID: 166294 RVA: 0x00594925 File Offset: 0x00592B25
		public static TRefreshRuleUnion FromIFixedDateTimeRefreshRule(IFixedDateTimeRefreshRuleT _ifixeddatetimerefreshrule)
		{
			return new TRefreshRuleUnion
			{
				Type = TRefreshRule.IFixedDateTimeRefreshRule,
				Value = _ifixeddatetimerefreshrule
			};
		}

		// Token: 0x06028997 RID: 166295 RVA: 0x0059493A File Offset: 0x00592B3A
		public IRandomNpcRuleT AsIRandomNpcRule()
		{
			return this.As<IRandomNpcRuleT>();
		}

		// Token: 0x06028998 RID: 166296 RVA: 0x00594942 File Offset: 0x00592B42
		public static TRefreshRuleUnion FromIRandomNpcRule(IRandomNpcRuleT _irandomnpcrule)
		{
			return new TRefreshRuleUnion
			{
				Type = TRefreshRule.IRandomNpcRule,
				Value = _irandomnpcrule
			};
		}

		// Token: 0x06028999 RID: 166297 RVA: 0x00594958 File Offset: 0x00592B58
		public static int Pack(FlatBufferBuilder builder, TRefreshRuleUnion _o)
		{
			switch (_o.Type)
			{
			case TRefreshRule.ICdRefreshRule:
				return ICdRefreshRule.Pack(builder, _o.AsICdRefreshRule()).Value;
			case TRefreshRule.IFixedDateTimeRefreshRule:
				return IFixedDateTimeRefreshRule.Pack(builder, _o.AsIFixedDateTimeRefreshRule()).Value;
			case TRefreshRule.IRandomNpcRule:
				return IRandomNpcRule.Pack(builder, _o.AsIRandomNpcRule()).Value;
			default:
				return 0;
			}
		}
	}
}
