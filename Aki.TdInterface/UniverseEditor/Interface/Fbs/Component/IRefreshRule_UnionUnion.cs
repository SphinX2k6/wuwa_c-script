using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E3D RID: 24125
	public class IRefreshRule_UnionUnion
	{
		// Token: 0x1700B1CE RID: 45518
		// (get) Token: 0x060284C9 RID: 165065 RVA: 0x00582795 File Offset: 0x00580995
		// (set) Token: 0x060284CA RID: 165066 RVA: 0x0058279D File Offset: 0x0058099D
		public IRefreshRule_Union Type { get; set; }

		// Token: 0x1700B1CF RID: 45519
		// (get) Token: 0x060284CB RID: 165067 RVA: 0x005827A6 File Offset: 0x005809A6
		// (set) Token: 0x060284CC RID: 165068 RVA: 0x005827AE File Offset: 0x005809AE
		public object Value { get; set; }

		// Token: 0x060284CD RID: 165069 RVA: 0x005827B7 File Offset: 0x005809B7
		public IRefreshRule_UnionUnion()
		{
			this.Type = IRefreshRule_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060284CE RID: 165070 RVA: 0x005827CD File Offset: 0x005809CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060284CF RID: 165071 RVA: 0x005827DF File Offset: 0x005809DF
		public IRefreshRuleT AsIRefreshRule()
		{
			return this.As<IRefreshRuleT>();
		}

		// Token: 0x060284D0 RID: 165072 RVA: 0x005827E7 File Offset: 0x005809E7
		public static IRefreshRule_UnionUnion FromIRefreshRule(IRefreshRuleT _irefreshrule)
		{
			return new IRefreshRule_UnionUnion
			{
				Type = IRefreshRule_Union.IRefreshRule,
				Value = _irefreshrule
			};
		}

		// Token: 0x060284D1 RID: 165073 RVA: 0x005827FC File Offset: 0x005809FC
		public ICdRefreshRuleT AsICdRefreshRule()
		{
			return this.As<ICdRefreshRuleT>();
		}

		// Token: 0x060284D2 RID: 165074 RVA: 0x00582804 File Offset: 0x00580A04
		public static IRefreshRule_UnionUnion FromICdRefreshRule(ICdRefreshRuleT _icdrefreshrule)
		{
			return new IRefreshRule_UnionUnion
			{
				Type = IRefreshRule_Union.ICdRefreshRule,
				Value = _icdrefreshrule
			};
		}

		// Token: 0x060284D3 RID: 165075 RVA: 0x00582819 File Offset: 0x00580A19
		public IFixedDateTimeRefreshRuleT AsIFixedDateTimeRefreshRule()
		{
			return this.As<IFixedDateTimeRefreshRuleT>();
		}

		// Token: 0x060284D4 RID: 165076 RVA: 0x00582821 File Offset: 0x00580A21
		public static IRefreshRule_UnionUnion FromIFixedDateTimeRefreshRule(IFixedDateTimeRefreshRuleT _ifixeddatetimerefreshrule)
		{
			return new IRefreshRule_UnionUnion
			{
				Type = IRefreshRule_Union.IFixedDateTimeRefreshRule,
				Value = _ifixeddatetimerefreshrule
			};
		}

		// Token: 0x060284D5 RID: 165077 RVA: 0x00582836 File Offset: 0x00580A36
		public IRandomNpcRuleT AsIRandomNpcRule()
		{
			return this.As<IRandomNpcRuleT>();
		}

		// Token: 0x060284D6 RID: 165078 RVA: 0x0058283E File Offset: 0x00580A3E
		public static IRefreshRule_UnionUnion FromIRandomNpcRule(IRandomNpcRuleT _irandomnpcrule)
		{
			return new IRefreshRule_UnionUnion
			{
				Type = IRefreshRule_Union.IRandomNpcRule,
				Value = _irandomnpcrule
			};
		}

		// Token: 0x060284D7 RID: 165079 RVA: 0x00582854 File Offset: 0x00580A54
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
