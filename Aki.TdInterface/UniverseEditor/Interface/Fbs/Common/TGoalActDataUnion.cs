using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064CE RID: 25806
	public class TGoalActDataUnion
	{
		// Token: 0x1700BE44 RID: 48708
		// (get) Token: 0x0602BDDA RID: 179674 RVA: 0x005F7070 File Offset: 0x005F5270
		// (set) Token: 0x0602BDDB RID: 179675 RVA: 0x005F7078 File Offset: 0x005F5278
		public TGoalActData Type { get; set; }

		// Token: 0x1700BE45 RID: 48709
		// (get) Token: 0x0602BDDC RID: 179676 RVA: 0x005F7081 File Offset: 0x005F5281
		// (set) Token: 0x0602BDDD RID: 179677 RVA: 0x005F7089 File Offset: 0x005F5289
		public object Value { get; set; }

		// Token: 0x0602BDDE RID: 179678 RVA: 0x005F7092 File Offset: 0x005F5292
		public TGoalActDataUnion()
		{
			this.Type = TGoalActData.NONE;
			this.Value = null;
		}

		// Token: 0x0602BDDF RID: 179679 RVA: 0x005F70A8 File Offset: 0x005F52A8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BDE0 RID: 179680 RVA: 0x005F70BA File Offset: 0x005F52BA
		public IDiscardForEnergyToDeployTypeT AsIDiscardForEnergyToDeployType()
		{
			return this.As<IDiscardForEnergyToDeployTypeT>();
		}

		// Token: 0x0602BDE1 RID: 179681 RVA: 0x005F70C2 File Offset: 0x005F52C2
		public static TGoalActDataUnion FromIDiscardForEnergyToDeployType(IDiscardForEnergyToDeployTypeT _idiscardforenergytodeploytype)
		{
			return new TGoalActDataUnion
			{
				Type = TGoalActData.IDiscardForEnergyToDeployType,
				Value = _idiscardforenergytodeploytype
			};
		}

		// Token: 0x0602BDE2 RID: 179682 RVA: 0x005F70D7 File Offset: 0x005F52D7
		public IDiscardForEnergyToEvolutionTypeT AsIDiscardForEnergyToEvolutionType()
		{
			return this.As<IDiscardForEnergyToEvolutionTypeT>();
		}

		// Token: 0x0602BDE3 RID: 179683 RVA: 0x005F70DF File Offset: 0x005F52DF
		public static TGoalActDataUnion FromIDiscardForEnergyToEvolutionType(IDiscardForEnergyToEvolutionTypeT _idiscardforenergytoevolutiontype)
		{
			return new TGoalActDataUnion
			{
				Type = TGoalActData.IDiscardForEnergyToEvolutionType,
				Value = _idiscardforenergytoevolutiontype
			};
		}

		// Token: 0x0602BDE4 RID: 179684 RVA: 0x005F70F4 File Offset: 0x005F52F4
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
