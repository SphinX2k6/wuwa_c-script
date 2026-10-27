using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE3 RID: 23523
	public class TAiGearStrategyUnion
	{
		// Token: 0x1700B1C1 RID: 45505
		// (get) Token: 0x06028505 RID: 165125 RVA: 0x0058A048 File Offset: 0x00588248
		// (set) Token: 0x06028506 RID: 165126 RVA: 0x0058A050 File Offset: 0x00588250
		public TAiGearStrategy Type { get; set; }

		// Token: 0x1700B1C2 RID: 45506
		// (get) Token: 0x06028507 RID: 165127 RVA: 0x0058A059 File Offset: 0x00588259
		// (set) Token: 0x06028508 RID: 165128 RVA: 0x0058A061 File Offset: 0x00588261
		public object Value { get; set; }

		// Token: 0x06028509 RID: 165129 RVA: 0x0058A06A File Offset: 0x0058826A
		public TAiGearStrategyUnion()
		{
			this.Type = TAiGearStrategy.NONE;
			this.Value = null;
		}

		// Token: 0x0602850A RID: 165130 RVA: 0x0058A080 File Offset: 0x00588280
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602850B RID: 165131 RVA: 0x0058A092 File Offset: 0x00588292
		public IRaceStrategyT AsIRaceStrategy()
		{
			return this.As<IRaceStrategyT>();
		}

		// Token: 0x0602850C RID: 165132 RVA: 0x0058A09A File Offset: 0x0058829A
		public static TAiGearStrategyUnion FromIRaceStrategy(IRaceStrategyT _iracestrategy)
		{
			return new TAiGearStrategyUnion
			{
				Type = TAiGearStrategy.IRaceStrategy,
				Value = _iracestrategy
			};
		}

		// Token: 0x0602850D RID: 165133 RVA: 0x0058A0AF File Offset: 0x005882AF
		public IRenjuStrategyT AsIRenjuStrategy()
		{
			return this.As<IRenjuStrategyT>();
		}

		// Token: 0x0602850E RID: 165134 RVA: 0x0058A0B7 File Offset: 0x005882B7
		public static TAiGearStrategyUnion FromIRenjuStrategy(IRenjuStrategyT _irenjustrategy)
		{
			return new TAiGearStrategyUnion
			{
				Type = TAiGearStrategy.IRenjuStrategy,
				Value = _irenjustrategy
			};
		}

		// Token: 0x0602850F RID: 165135 RVA: 0x0058A0CC File Offset: 0x005882CC
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
