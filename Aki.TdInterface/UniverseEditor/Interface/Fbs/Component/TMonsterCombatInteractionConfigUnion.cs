using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006289 RID: 25225
	public class TMonsterCombatInteractionConfigUnion
	{
		// Token: 0x1700BB72 RID: 47986
		// (get) Token: 0x0602AE95 RID: 175765 RVA: 0x005DB2E2 File Offset: 0x005D94E2
		// (set) Token: 0x0602AE96 RID: 175766 RVA: 0x005DB2EA File Offset: 0x005D94EA
		public TMonsterCombatInteractionConfig Type { get; set; }

		// Token: 0x1700BB73 RID: 47987
		// (get) Token: 0x0602AE97 RID: 175767 RVA: 0x005DB2F3 File Offset: 0x005D94F3
		// (set) Token: 0x0602AE98 RID: 175768 RVA: 0x005DB2FB File Offset: 0x005D94FB
		public object Value { get; set; }

		// Token: 0x0602AE99 RID: 175769 RVA: 0x005DB304 File Offset: 0x005D9504
		public TMonsterCombatInteractionConfigUnion()
		{
			this.Type = TMonsterCombatInteractionConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE9A RID: 175770 RVA: 0x005DB31A File Offset: 0x005D951A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE9B RID: 175771 RVA: 0x005DB32C File Offset: 0x005D952C
		public IMonsterCombatInteractionFrequencyPaintT AsIMonsterCombatInteractionFrequencyPaint()
		{
			return this.As<IMonsterCombatInteractionFrequencyPaintT>();
		}

		// Token: 0x0602AE9C RID: 175772 RVA: 0x005DB334 File Offset: 0x005D9534
		public static TMonsterCombatInteractionConfigUnion FromIMonsterCombatInteractionFrequencyPaint(IMonsterCombatInteractionFrequencyPaintT _imonstercombatinteractionfrequencypaint)
		{
			return new TMonsterCombatInteractionConfigUnion
			{
				Type = TMonsterCombatInteractionConfig.IMonsterCombatInteractionFrequencyPaint,
				Value = _imonstercombatinteractionfrequencypaint
			};
		}

		// Token: 0x0602AE9D RID: 175773 RVA: 0x005DB349 File Offset: 0x005D9549
		public IMonsterCombatInteractionWaterBoxStagnationT AsIMonsterCombatInteractionWaterBoxStagnation()
		{
			return this.As<IMonsterCombatInteractionWaterBoxStagnationT>();
		}

		// Token: 0x0602AE9E RID: 175774 RVA: 0x005DB351 File Offset: 0x005D9551
		public static TMonsterCombatInteractionConfigUnion FromIMonsterCombatInteractionWaterBoxStagnation(IMonsterCombatInteractionWaterBoxStagnationT _imonstercombatinteractionwaterboxstagnation)
		{
			return new TMonsterCombatInteractionConfigUnion
			{
				Type = TMonsterCombatInteractionConfig.IMonsterCombatInteractionWaterBoxStagnation,
				Value = _imonstercombatinteractionwaterboxstagnation
			};
		}

		// Token: 0x0602AE9F RID: 175775 RVA: 0x005DB368 File Offset: 0x005D9568
		public static int Pack(FlatBufferBuilder builder, TMonsterCombatInteractionConfigUnion _o)
		{
			TMonsterCombatInteractionConfig type = _o.Type;
			if (type == TMonsterCombatInteractionConfig.IMonsterCombatInteractionFrequencyPaint)
			{
				return IMonsterCombatInteractionFrequencyPaint.Pack(builder, _o.AsIMonsterCombatInteractionFrequencyPaint()).Value;
			}
			if (type != TMonsterCombatInteractionConfig.IMonsterCombatInteractionWaterBoxStagnation)
			{
				return 0;
			}
			return IMonsterCombatInteractionWaterBoxStagnation.Pack(builder, _o.AsIMonsterCombatInteractionWaterBoxStagnation()).Value;
		}
	}
}
