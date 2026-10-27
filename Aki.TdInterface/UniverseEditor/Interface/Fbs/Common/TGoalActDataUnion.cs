using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E8B RID: 24203
	public class TGoalActDataUnion
	{
		// Token: 0x1700B4D9 RID: 46297
		// (get) Token: 0x06029732 RID: 169778 RVA: 0x005AE0CC File Offset: 0x005AC2CC
		// (set) Token: 0x06029733 RID: 169779 RVA: 0x005AE0D4 File Offset: 0x005AC2D4
		public TGoalActData Type { get; set; }

		// Token: 0x1700B4DA RID: 46298
		// (get) Token: 0x06029734 RID: 169780 RVA: 0x005AE0DD File Offset: 0x005AC2DD
		// (set) Token: 0x06029735 RID: 169781 RVA: 0x005AE0E5 File Offset: 0x005AC2E5
		public object Value { get; set; }

		// Token: 0x06029736 RID: 169782 RVA: 0x005AE0EE File Offset: 0x005AC2EE
		public TGoalActDataUnion()
		{
			this.Type = TGoalActData.NONE;
			this.Value = null;
		}

		// Token: 0x06029737 RID: 169783 RVA: 0x005AE104 File Offset: 0x005AC304
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029738 RID: 169784 RVA: 0x005AE116 File Offset: 0x005AC316
		public IDiscardForEnergyToDeployTypeT AsIDiscardForEnergyToDeployType()
		{
			return this.As<IDiscardForEnergyToDeployTypeT>();
		}

		// Token: 0x06029739 RID: 169785 RVA: 0x005AE11E File Offset: 0x005AC31E
		public static TGoalActDataUnion FromIDiscardForEnergyToDeployType(IDiscardForEnergyToDeployTypeT _idiscardforenergytodeploytype)
		{
			return new TGoalActDataUnion
			{
				Type = TGoalActData.IDiscardForEnergyToDeployType,
				Value = _idiscardforenergytodeploytype
			};
		}

		// Token: 0x0602973A RID: 169786 RVA: 0x005AE133 File Offset: 0x005AC333
		public IDiscardForEnergyToEvolutionTypeT AsIDiscardForEnergyToEvolutionType()
		{
			return this.As<IDiscardForEnergyToEvolutionTypeT>();
		}

		// Token: 0x0602973B RID: 169787 RVA: 0x005AE13B File Offset: 0x005AC33B
		public static TGoalActDataUnion FromIDiscardForEnergyToEvolutionType(IDiscardForEnergyToEvolutionTypeT _idiscardforenergytoevolutiontype)
		{
			return new TGoalActDataUnion
			{
				Type = TGoalActData.IDiscardForEnergyToEvolutionType,
				Value = _idiscardforenergytoevolutiontype
			};
		}

		// Token: 0x0602973C RID: 169788 RVA: 0x005AE150 File Offset: 0x005AC350
		public static int Pack(FlatBufferBuilder builder, TGoalActDataUnion _o)
		{
			TGoalActData type = _o.Type;
			if (type == TGoalActData.IDiscardForEnergyToDeployType)
			{
				return IDiscardForEnergyToDeployType.Pack(builder, _o.AsIDiscardForEnergyToDeployType()).Value;
			}
			if (type != TGoalActData.IDiscardForEnergyToEvolutionType)
			{
				return 0;
			}
			return IDiscardForEnergyToEvolutionType.Pack(builder, _o.AsIDiscardForEnergyToEvolutionType()).Value;
		}
	}
}
