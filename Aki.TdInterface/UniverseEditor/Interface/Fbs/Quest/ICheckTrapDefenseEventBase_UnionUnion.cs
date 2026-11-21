using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004194 RID: 16788
	public class ICheckTrapDefenseEventBase_UnionUnion
	{
		// Token: 0x170071BE RID: 29118
		// (get) Token: 0x060171E3 RID: 94691 RVA: 0x0034B60D File Offset: 0x0034980D
		// (set) Token: 0x060171E4 RID: 94692 RVA: 0x0034B615 File Offset: 0x00349815
		public ICheckTrapDefenseEventBase_Union Type { get; set; }

		// Token: 0x170071BF RID: 29119
		// (get) Token: 0x060171E5 RID: 94693 RVA: 0x0034B61E File Offset: 0x0034981E
		// (set) Token: 0x060171E6 RID: 94694 RVA: 0x0034B626 File Offset: 0x00349826
		public object Value { get; set; }

		// Token: 0x060171E7 RID: 94695 RVA: 0x0034B62F File Offset: 0x0034982F
		public ICheckTrapDefenseEventBase_UnionUnion()
		{
			this.Type = ICheckTrapDefenseEventBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060171E8 RID: 94696 RVA: 0x0034B645 File Offset: 0x00349845
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060171E9 RID: 94697 RVA: 0x0034B657 File Offset: 0x00349857
		public ICheckTrapDefenseEventBaseT AsICheckTrapDefenseEventBase()
		{
			return this.As<ICheckTrapDefenseEventBaseT>();
		}

		// Token: 0x060171EA RID: 94698 RVA: 0x0034B65F File Offset: 0x0034985F
		public static ICheckTrapDefenseEventBase_UnionUnion FromICheckTrapDefenseEventBase(ICheckTrapDefenseEventBaseT _ichecktrapdefenseeventbase)
		{
			return new ICheckTrapDefenseEventBase_UnionUnion
			{
				Type = ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseEventBase,
				Value = _ichecktrapdefenseeventbase
			};
		}

		// Token: 0x060171EB RID: 94699 RVA: 0x0034B674 File Offset: 0x00349874
		public ICheckTrapDefenseEventMonsterKilledT AsICheckTrapDefenseEventMonsterKilled()
		{
			return this.As<ICheckTrapDefenseEventMonsterKilledT>();
		}

		// Token: 0x060171EC RID: 94700 RVA: 0x0034B67C File Offset: 0x0034987C
		public static ICheckTrapDefenseEventBase_UnionUnion FromICheckTrapDefenseEventMonsterKilled(ICheckTrapDefenseEventMonsterKilledT _ichecktrapdefenseeventmonsterkilled)
		{
			return new ICheckTrapDefenseEventBase_UnionUnion
			{
				Type = ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseEventMonsterKilled,
				Value = _ichecktrapdefenseeventmonsterkilled
			};
		}

		// Token: 0x060171ED RID: 94701 RVA: 0x0034B691 File Offset: 0x00349891
		public ICheckTrapDefenseBdBuffQualityUpT AsICheckTrapDefenseBdBuffQualityUp()
		{
			return this.As<ICheckTrapDefenseBdBuffQualityUpT>();
		}

		// Token: 0x060171EE RID: 94702 RVA: 0x0034B699 File Offset: 0x00349899
		public static ICheckTrapDefenseEventBase_UnionUnion FromICheckTrapDefenseBdBuffQualityUp(ICheckTrapDefenseBdBuffQualityUpT _ichecktrapdefensebdbuffqualityup)
		{
			return new ICheckTrapDefenseEventBase_UnionUnion
			{
				Type = ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseBdBuffQualityUp,
				Value = _ichecktrapdefensebdbuffqualityup
			};
		}

		// Token: 0x060171EF RID: 94703 RVA: 0x0034B6B0 File Offset: 0x003498B0
		public static int Pack(FlatBufferBuilder builder, ICheckTrapDefenseEventBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseEventBase:
				return ICheckTrapDefenseEventBase.Pack(builder, _o.AsICheckTrapDefenseEventBase()).Value;
			case ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseEventMonsterKilled:
				return ICheckTrapDefenseEventMonsterKilled.Pack(builder, _o.AsICheckTrapDefenseEventMonsterKilled()).Value;
			case ICheckTrapDefenseEventBase_Union.ICheckTrapDefenseBdBuffQualityUp:
				return ICheckTrapDefenseBdBuffQualityUp.Pack(builder, _o.AsICheckTrapDefenseBdBuffQualityUp()).Value;
			default:
				return 0;
			}
		}
	}
}
