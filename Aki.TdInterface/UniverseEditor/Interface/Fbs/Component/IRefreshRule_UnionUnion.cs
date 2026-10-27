using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005836 RID: 22582
	public class IRefreshRule_UnionUnion
	{
		// Token: 0x1700A8AA RID: 43178
		// (get) Token: 0x06025FA9 RID: 155561 RVA: 0x0053C609 File Offset: 0x0053A809
		// (set) Token: 0x06025FAA RID: 155562 RVA: 0x0053C611 File Offset: 0x0053A811
		public IRefreshRule_Union Type { get; set; }

		// Token: 0x1700A8AB RID: 43179
		// (get) Token: 0x06025FAB RID: 155563 RVA: 0x0053C61A File Offset: 0x0053A81A
		// (set) Token: 0x06025FAC RID: 155564 RVA: 0x0053C622 File Offset: 0x0053A822
		public object Value { get; set; }

		// Token: 0x06025FAD RID: 155565 RVA: 0x0053C62B File Offset: 0x0053A82B
		public IRefreshRule_UnionUnion()
		{
			this.Type = IRefreshRule_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025FAE RID: 155566 RVA: 0x0053C641 File Offset: 0x0053A841
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025FAF RID: 155567 RVA: 0x0053C653 File Offset: 0x0053A853
		public IRefreshRuleT AsIRefreshRule()
		{
			return this.As<IRefreshRuleT>();
		}

		// Token: 0x06025FB0 RID: 155568 RVA: 0x0053C65B File Offset: 0x0053A85B
		public static IRefreshRule_UnionUnion FromIRefreshRule(IRefreshRuleT _irefreshrule)
		{
			return new IRefreshRule_UnionUnion
			{
				Type = IRefreshRule_Union.IRefreshRule,
				Value = _irefreshrule
			};
		}

		// Token: 0x06025FB1 RID: 155569 RVA: 0x0053C670 File Offset: 0x0053A870
		public ICdRefreshRuleT AsICdRefreshRule()
		{
			return this.As<ICdRefreshRuleT>();
		}

		// Token: 0x06025FB2 RID: 155570 RVA: 0x0053C678 File Offset: 0x0053A878
		public static IRefreshRule_UnionUnion FromICdRefreshRule(ICdRefreshRuleT _icdrefreshrule)
		{
			return new IRefreshRule_UnionUnion
			{
				Type = IRefreshRule_Union.ICdRefreshRule,
				Value = _icdrefreshrule
			};
		}

		// Token: 0x06025FB3 RID: 155571 RVA: 0x0053C68D File Offset: 0x0053A88D
		public IFixedDateTimeRefreshRuleT AsIFixedDateTimeRefreshRule()
		{
			return this.As<IFixedDateTimeRefreshRuleT>();
		}

		// Token: 0x06025FB4 RID: 155572 RVA: 0x0053C695 File Offset: 0x0053A895
		public static IRefreshRule_UnionUnion FromIFixedDateTimeRefreshRule(IFixedDateTimeRefreshRuleT _ifixeddatetimerefreshrule)
		{
			return new IRefreshRule_UnionUnion
			{
				Type = IRefreshRule_Union.IFixedDateTimeRefreshRule,
				Value = _ifixeddatetimerefreshrule
			};
		}

		// Token: 0x06025FB5 RID: 155573 RVA: 0x0053C6AA File Offset: 0x0053A8AA
		public IRandomNpcRuleT AsIRandomNpcRule()
		{
			return this.As<IRandomNpcRuleT>();
		}

		// Token: 0x06025FB6 RID: 155574 RVA: 0x0053C6B2 File Offset: 0x0053A8B2
		public static IRefreshRule_UnionUnion FromIRandomNpcRule(IRandomNpcRuleT _irandomnpcrule)
		{
			return new IRefreshRule_UnionUnion
			{
				Type = IRefreshRule_Union.IRandomNpcRule,
				Value = _irandomnpcrule
			};
		}

		// Token: 0x06025FB7 RID: 155575 RVA: 0x0053C6C8 File Offset: 0x0053A8C8
		public static int Pack(FlatBufferBuilder builder, IRefreshRule_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRefreshRule_Union.IRefreshRule:
				return IRefreshRule.Pack(builder, _o.AsIRefreshRule()).Value;
			case IRefreshRule_Union.ICdRefreshRule:
				return ICdRefreshRule.Pack(builder, _o.AsICdRefreshRule()).Value;
			case IRefreshRule_Union.IFixedDateTimeRefreshRule:
				return IFixedDateTimeRefreshRule.Pack(builder, _o.AsIFixedDateTimeRefreshRule()).Value;
			case IRefreshRule_Union.IRandomNpcRule:
				return IRandomNpcRule.Pack(builder, _o.AsIRandomNpcRule()).Value;
			default:
				return 0;
			}
		}
	}
}
