using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061F9 RID: 25081
	public class TAiGearStrategyUnion
	{
		// Token: 0x1700BB09 RID: 47881
		// (get) Token: 0x0602AAC9 RID: 174793 RVA: 0x005D1AD8 File Offset: 0x005CFCD8
		// (set) Token: 0x0602AACA RID: 174794 RVA: 0x005D1AE0 File Offset: 0x005CFCE0
		public TAiGearStrategy Type { get; set; }

		// Token: 0x1700BB0A RID: 47882
		// (get) Token: 0x0602AACB RID: 174795 RVA: 0x005D1AE9 File Offset: 0x005CFCE9
		// (set) Token: 0x0602AACC RID: 174796 RVA: 0x005D1AF1 File Offset: 0x005CFCF1
		public object Value { get; set; }

		// Token: 0x0602AACD RID: 174797 RVA: 0x005D1AFA File Offset: 0x005CFCFA
		public TAiGearStrategyUnion()
		{
			this.Type = TAiGearStrategy.NONE;
			this.Value = null;
		}

		// Token: 0x0602AACE RID: 174798 RVA: 0x005D1B10 File Offset: 0x005CFD10
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AACF RID: 174799 RVA: 0x005D1B22 File Offset: 0x005CFD22
		public IRaceStrategyT AsIRaceStrategy()
		{
			return this.As<IRaceStrategyT>();
		}

		// Token: 0x0602AAD0 RID: 174800 RVA: 0x005D1B2A File Offset: 0x005CFD2A
		public static TAiGearStrategyUnion FromIRaceStrategy(IRaceStrategyT _iracestrategy)
		{
			return new TAiGearStrategyUnion
			{
				Type = TAiGearStrategy.IRaceStrategy,
				Value = _iracestrategy
			};
		}

		// Token: 0x0602AAD1 RID: 174801 RVA: 0x005D1B3F File Offset: 0x005CFD3F
		public IRenjuStrategyT AsIRenjuStrategy()
		{
			return this.As<IRenjuStrategyT>();
		}

		// Token: 0x0602AAD2 RID: 174802 RVA: 0x005D1B47 File Offset: 0x005CFD47
		public static TAiGearStrategyUnion FromIRenjuStrategy(IRenjuStrategyT _irenjustrategy)
		{
			return new TAiGearStrategyUnion
			{
				Type = TAiGearStrategy.IRenjuStrategy,
				Value = _irenjustrategy
			};
		}

		// Token: 0x0602AAD3 RID: 174803 RVA: 0x005D1B5C File Offset: 0x005CFD5C
		public static int Pack(FlatBufferBuilder builder, TAiGearStrategyUnion _o)
		{
			TAiGearStrategy type = _o.Type;
			if (type == TAiGearStrategy.IRaceStrategy)
			{
				return IRaceStrategy.Pack(builder, _o.AsIRaceStrategy()).Value;
			}
			if (type != TAiGearStrategy.IRenjuStrategy)
			{
				return 0;
			}
			return IRenjuStrategy.Pack(builder, _o.AsIRenjuStrategy()).Value;
		}
	}
}
