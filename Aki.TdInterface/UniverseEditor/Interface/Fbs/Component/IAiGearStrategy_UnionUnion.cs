using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E81 RID: 20097
	public class IAiGearStrategy_UnionUnion
	{
		// Token: 0x17008FFC RID: 36860
		// (get) Token: 0x0601F982 RID: 129410 RVA: 0x00466A10 File Offset: 0x00464C10
		// (set) Token: 0x0601F983 RID: 129411 RVA: 0x00466A18 File Offset: 0x00464C18
		public IAiGearStrategy_Union Type { get; set; }

		// Token: 0x17008FFD RID: 36861
		// (get) Token: 0x0601F984 RID: 129412 RVA: 0x00466A21 File Offset: 0x00464C21
		// (set) Token: 0x0601F985 RID: 129413 RVA: 0x00466A29 File Offset: 0x00464C29
		public object Value { get; set; }

		// Token: 0x0601F986 RID: 129414 RVA: 0x00466A32 File Offset: 0x00464C32
		public IAiGearStrategy_UnionUnion()
		{
			this.Type = IAiGearStrategy_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F987 RID: 129415 RVA: 0x00466A48 File Offset: 0x00464C48
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F988 RID: 129416 RVA: 0x00466A5A File Offset: 0x00464C5A
		public IAiGearStrategyT AsIAiGearStrategy()
		{
			return this.As<IAiGearStrategyT>();
		}

		// Token: 0x0601F989 RID: 129417 RVA: 0x00466A62 File Offset: 0x00464C62
		public static IAiGearStrategy_UnionUnion FromIAiGearStrategy(IAiGearStrategyT _iaigearstrategy)
		{
			return new IAiGearStrategy_UnionUnion
			{
				Type = IAiGearStrategy_Union.IAiGearStrategy,
				Value = _iaigearstrategy
			};
		}

		// Token: 0x0601F98A RID: 129418 RVA: 0x00466A77 File Offset: 0x00464C77
		public IRenjuStrategyT AsIRenjuStrategy()
		{
			return this.As<IRenjuStrategyT>();
		}

		// Token: 0x0601F98B RID: 129419 RVA: 0x00466A7F File Offset: 0x00464C7F
		public static IAiGearStrategy_UnionUnion FromIRenjuStrategy(IRenjuStrategyT _irenjustrategy)
		{
			return new IAiGearStrategy_UnionUnion
			{
				Type = IAiGearStrategy_Union.IRenjuStrategy,
				Value = _irenjustrategy
			};
		}

		// Token: 0x0601F98C RID: 129420 RVA: 0x00466A94 File Offset: 0x00464C94
		public IRaceStrategyT AsIRaceStrategy()
		{
			return this.As<IRaceStrategyT>();
		}

		// Token: 0x0601F98D RID: 129421 RVA: 0x00466A9C File Offset: 0x00464C9C
		public static IAiGearStrategy_UnionUnion FromIRaceStrategy(IRaceStrategyT _iracestrategy)
		{
			return new IAiGearStrategy_UnionUnion
			{
				Type = IAiGearStrategy_Union.IRaceStrategy,
				Value = _iracestrategy
			};
		}

		// Token: 0x0601F98E RID: 129422 RVA: 0x00466AB4 File Offset: 0x00464CB4
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
