using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062CB RID: 25291
	public class TRefreshRuleUnion
	{
		// Token: 0x1700BB9E RID: 48030
		// (get) Token: 0x0602AFD3 RID: 176083 RVA: 0x005DCFEE File Offset: 0x005DB1EE
		// (set) Token: 0x0602AFD4 RID: 176084 RVA: 0x005DCFF6 File Offset: 0x005DB1F6
		public TRefreshRule Type { get; set; }

		// Token: 0x1700BB9F RID: 48031
		// (get) Token: 0x0602AFD5 RID: 176085 RVA: 0x005DCFFF File Offset: 0x005DB1FF
		// (set) Token: 0x0602AFD6 RID: 176086 RVA: 0x005DD007 File Offset: 0x005DB207
		public object Value { get; set; }

		// Token: 0x0602AFD7 RID: 176087 RVA: 0x005DD010 File Offset: 0x005DB210
		public TRefreshRuleUnion()
		{
			this.Type = TRefreshRule.NONE;
			this.Value = null;
		}

		// Token: 0x0602AFD8 RID: 176088 RVA: 0x005DD026 File Offset: 0x005DB226
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AFD9 RID: 176089 RVA: 0x005DD038 File Offset: 0x005DB238
		public ICdRefreshRuleT AsICdRefreshRule()
		{
			return this.As<ICdRefreshRuleT>();
		}

		// Token: 0x0602AFDA RID: 176090 RVA: 0x005DD040 File Offset: 0x005DB240
		public static TRefreshRuleUnion FromICdRefreshRule(ICdRefreshRuleT _icdrefreshrule)
		{
			return new TRefreshRuleUnion
			{
				Type = TRefreshRule.ICdRefreshRule,
				Value = _icdrefreshrule
			};
		}

		// Token: 0x0602AFDB RID: 176091 RVA: 0x005DD055 File Offset: 0x005DB255
		public IFixedDateTimeRefreshRuleT AsIFixedDateTimeRefreshRule()
		{
			return this.As<IFixedDateTimeRefreshRuleT>();
		}

		// Token: 0x0602AFDC RID: 176092 RVA: 0x005DD05D File Offset: 0x005DB25D
		public static TRefreshRuleUnion FromIFixedDateTimeRefreshRule(IFixedDateTimeRefreshRuleT _ifixeddatetimerefreshrule)
		{
			return new TRefreshRuleUnion
			{
				Type = TRefreshRule.IFixedDateTimeRefreshRule,
				Value = _ifixeddatetimerefreshrule
			};
		}

		// Token: 0x0602AFDD RID: 176093 RVA: 0x005DD072 File Offset: 0x005DB272
		public IRandomNpcRuleT AsIRandomNpcRule()
		{
			return this.As<IRandomNpcRuleT>();
		}

		// Token: 0x0602AFDE RID: 176094 RVA: 0x005DD07A File Offset: 0x005DB27A
		public static TRefreshRuleUnion FromIRandomNpcRule(IRandomNpcRuleT _irandomnpcrule)
		{
			return new TRefreshRuleUnion
			{
				Type = TRefreshRule.IRandomNpcRule,
				Value = _irandomnpcrule
			};
		}

		// Token: 0x0602AFDF RID: 176095 RVA: 0x005DD090 File Offset: 0x005DB290
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
