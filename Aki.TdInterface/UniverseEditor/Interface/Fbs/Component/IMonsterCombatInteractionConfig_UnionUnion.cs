using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B05 RID: 23301
	public class IMonsterCombatInteractionConfig_UnionUnion
	{
		// Token: 0x1700AA09 RID: 43529
		// (get) Token: 0x06026494 RID: 156820 RVA: 0x0053EC75 File Offset: 0x0053CE75
		// (set) Token: 0x06026495 RID: 156821 RVA: 0x0053EC7D File Offset: 0x0053CE7D
		public IMonsterCombatInteractionConfig_Union Type { get; set; }

		// Token: 0x1700AA0A RID: 43530
		// (get) Token: 0x06026496 RID: 156822 RVA: 0x0053EC86 File Offset: 0x0053CE86
		// (set) Token: 0x06026497 RID: 156823 RVA: 0x0053EC8E File Offset: 0x0053CE8E
		public object Value { get; set; }

		// Token: 0x06026498 RID: 156824 RVA: 0x0053EC97 File Offset: 0x0053CE97
		public IMonsterCombatInteractionConfig_UnionUnion()
		{
			this.Type = IMonsterCombatInteractionConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026499 RID: 156825 RVA: 0x0053ECAD File Offset: 0x0053CEAD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602649A RID: 156826 RVA: 0x0053ECBF File Offset: 0x0053CEBF
		public IMonsterCombatInteractionConfigT AsIMonsterCombatInteractionConfig()
		{
			return this.As<IMonsterCombatInteractionConfigT>();
		}

		// Token: 0x0602649B RID: 156827 RVA: 0x0053ECC7 File Offset: 0x0053CEC7
		public static IMonsterCombatInteractionConfig_UnionUnion FromIMonsterCombatInteractionConfig(IMonsterCombatInteractionConfigT _imonstercombatinteractionconfig)
		{
			return new IMonsterCombatInteractionConfig_UnionUnion
			{
				Type = IMonsterCombatInteractionConfig_Union.IMonsterCombatInteractionConfig,
				Value = _imonstercombatinteractionconfig
			};
		}

		// Token: 0x0602649C RID: 156828 RVA: 0x0053ECDC File Offset: 0x0053CEDC
		public IMonsterCombatInteractionWaterBoxStagnationT AsIMonsterCombatInteractionWaterBoxStagnation()
		{
			return this.As<IMonsterCombatInteractionWaterBoxStagnationT>();
		}

		// Token: 0x0602649D RID: 156829 RVA: 0x0053ECE4 File Offset: 0x0053CEE4
		public static IMonsterCombatInteractionConfig_UnionUnion FromIMonsterCombatInteractionWaterBoxStagnation(IMonsterCombatInteractionWaterBoxStagnationT _imonstercombatinteractionwaterboxstagnation)
		{
			return new IMonsterCombatInteractionConfig_UnionUnion
			{
				Type = IMonsterCombatInteractionConfig_Union.IMonsterCombatInteractionWaterBoxStagnation,
				Value = _imonstercombatinteractionwaterboxstagnation
			};
		}

		// Token: 0x0602649E RID: 156830 RVA: 0x0053ECF9 File Offset: 0x0053CEF9
		public IMonsterCombatInteractionFrequencyPaintT AsIMonsterCombatInteractionFrequencyPaint()
		{
			return this.As<IMonsterCombatInteractionFrequencyPaintT>();
		}

		// Token: 0x0602649F RID: 156831 RVA: 0x0053ED01 File Offset: 0x0053CF01
		public static IMonsterCombatInteractionConfig_UnionUnion FromIMonsterCombatInteractionFrequencyPaint(IMonsterCombatInteractionFrequencyPaintT _imonstercombatinteractionfrequencypaint)
		{
			return new IMonsterCombatInteractionConfig_UnionUnion
			{
				Type = IMonsterCombatInteractionConfig_Union.IMonsterCombatInteractionFrequencyPaint,
				Value = _imonstercombatinteractionfrequencypaint
			};
		}

		// Token: 0x060264A0 RID: 156832 RVA: 0x0053ED18 File Offset: 0x0053CF18
		public static int Pack(FlatBufferBuilder builder, IMonsterCombatInteractionConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMonsterCombatInteractionConfig_Union.IMonsterCombatInteractionConfig:
				return IMonsterCombatInteractionConfig.Pack(builder, _o.AsIMonsterCombatInteractionConfig()).Value;
			case IMonsterCombatInteractionConfig_Union.IMonsterCombatInteractionWaterBoxStagnation:
				return IMonsterCombatInteractionWaterBoxStagnation.Pack(builder, _o.AsIMonsterCombatInteractionWaterBoxStagnation()).Value;
			case IMonsterCombatInteractionConfig_Union.IMonsterCombatInteractionFrequencyPaint:
				return IMonsterCombatInteractionFrequencyPaint.Pack(builder, _o.AsIMonsterCombatInteractionFrequencyPaint()).Value;
			default:
				return 0;
			}
		}
	}
}
