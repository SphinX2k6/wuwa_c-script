using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005392 RID: 21394
	public class IAiGearStrategy_UnionUnion
	{
		// Token: 0x17009735 RID: 38709
		// (get) Token: 0x060215CD RID: 136653 RVA: 0x0049AA28 File Offset: 0x00498C28
		// (set) Token: 0x060215CE RID: 136654 RVA: 0x0049AA30 File Offset: 0x00498C30
		public IAiGearStrategy_Union Type { get; set; }

		// Token: 0x17009736 RID: 38710
		// (get) Token: 0x060215CF RID: 136655 RVA: 0x0049AA39 File Offset: 0x00498C39
		// (set) Token: 0x060215D0 RID: 136656 RVA: 0x0049AA41 File Offset: 0x00498C41
		public object Value { get; set; }

		// Token: 0x060215D1 RID: 136657 RVA: 0x0049AA4A File Offset: 0x00498C4A
		public IAiGearStrategy_UnionUnion()
		{
			this.Type = IAiGearStrategy_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060215D2 RID: 136658 RVA: 0x0049AA60 File Offset: 0x00498C60
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060215D3 RID: 136659 RVA: 0x0049AA72 File Offset: 0x00498C72
		public IAiGearStrategyT AsIAiGearStrategy()
		{
			return this.As<IAiGearStrategyT>();
		}

		// Token: 0x060215D4 RID: 136660 RVA: 0x0049AA7A File Offset: 0x00498C7A
		public static IAiGearStrategy_UnionUnion FromIAiGearStrategy(IAiGearStrategyT _iaigearstrategy)
		{
			return new IAiGearStrategy_UnionUnion
			{
				Type = IAiGearStrategy_Union.IAiGearStrategy,
				Value = _iaigearstrategy
			};
		}

		// Token: 0x060215D5 RID: 136661 RVA: 0x0049AA8F File Offset: 0x00498C8F
		public IRenjuStrategyT AsIRenjuStrategy()
		{
			return this.As<IRenjuStrategyT>();
		}

		// Token: 0x060215D6 RID: 136662 RVA: 0x0049AA97 File Offset: 0x00498C97
		public static IAiGearStrategy_UnionUnion FromIRenjuStrategy(IRenjuStrategyT _irenjustrategy)
		{
			return new IAiGearStrategy_UnionUnion
			{
				Type = IAiGearStrategy_Union.IRenjuStrategy,
				Value = _irenjustrategy
			};
		}

		// Token: 0x060215D7 RID: 136663 RVA: 0x0049AAAC File Offset: 0x00498CAC
		public IRaceStrategyT AsIRaceStrategy()
		{
			return this.As<IRaceStrategyT>();
		}

		// Token: 0x060215D8 RID: 136664 RVA: 0x0049AAB4 File Offset: 0x00498CB4
		public static IAiGearStrategy_UnionUnion FromIRaceStrategy(IRaceStrategyT _iracestrategy)
		{
			return new IAiGearStrategy_UnionUnion
			{
				Type = IAiGearStrategy_Union.IRaceStrategy,
				Value = _iracestrategy
			};
		}

		// Token: 0x060215D9 RID: 136665 RVA: 0x0049AACC File Offset: 0x00498CCC
		public static int Pack(FlatBufferBuilder builder, IAiGearStrategy_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAiGearStrategy_Union.IAiGearStrategy:
				return IAiGearStrategy.Pack(builder, _o.AsIAiGearStrategy()).Value;
			case IAiGearStrategy_Union.IRenjuStrategy:
				return IRenjuStrategy.Pack(builder, _o.AsIRenjuStrategy()).Value;
			case IAiGearStrategy_Union.IRaceStrategy:
				return IRaceStrategy.Pack(builder, _o.AsIRaceStrategy()).Value;
			default:
				return 0;
			}
		}
	}
}
