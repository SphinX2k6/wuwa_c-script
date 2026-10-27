using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D5F RID: 23903
	public class IBvbRecycleBoardCardData_UnionUnion
	{
		// Token: 0x1700B314 RID: 45844
		// (get) Token: 0x06028E44 RID: 167492 RVA: 0x0059E4C5 File Offset: 0x0059C6C5
		// (set) Token: 0x06028E45 RID: 167493 RVA: 0x0059E4CD File Offset: 0x0059C6CD
		public IBvbRecycleBoardCardData_Union Type { get; set; }

		// Token: 0x1700B315 RID: 45845
		// (get) Token: 0x06028E46 RID: 167494 RVA: 0x0059E4D6 File Offset: 0x0059C6D6
		// (set) Token: 0x06028E47 RID: 167495 RVA: 0x0059E4DE File Offset: 0x0059C6DE
		public object Value { get; set; }

		// Token: 0x06028E48 RID: 167496 RVA: 0x0059E4E7 File Offset: 0x0059C6E7
		public IBvbRecycleBoardCardData_UnionUnion()
		{
			this.Type = IBvbRecycleBoardCardData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028E49 RID: 167497 RVA: 0x0059E4FD File Offset: 0x0059C6FD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028E4A RID: 167498 RVA: 0x0059E50F File Offset: 0x0059C70F
		public IBvbRecycleBoardCardDataT AsIBvbRecycleBoardCardData()
		{
			return this.As<IBvbRecycleBoardCardDataT>();
		}

		// Token: 0x06028E4B RID: 167499 RVA: 0x0059E517 File Offset: 0x0059C717
		public static IBvbRecycleBoardCardData_UnionUnion FromIBvbRecycleBoardCardData(IBvbRecycleBoardCardDataT _ibvbrecycleboardcarddata)
		{
			return new IBvbRecycleBoardCardData_UnionUnion
			{
				Type = IBvbRecycleBoardCardData_Union.IBvbRecycleBoardCardData,
				Value = _ibvbrecycleboardcarddata
			};
		}

		// Token: 0x06028E4C RID: 167500 RVA: 0x0059E52C File Offset: 0x0059C72C
		public IDiscardForEnergyToDeployTypeT AsIDiscardForEnergyToDeployType()
		{
			return this.As<IDiscardForEnergyToDeployTypeT>();
		}

		// Token: 0x06028E4D RID: 167501 RVA: 0x0059E534 File Offset: 0x0059C734
		public static IBvbRecycleBoardCardData_UnionUnion FromIDiscardForEnergyToDeployType(IDiscardForEnergyToDeployTypeT _idiscardforenergytodeploytype)
		{
			return new IBvbRecycleBoardCardData_UnionUnion
			{
				Type = IBvbRecycleBoardCardData_Union.IDiscardForEnergyToDeployType,
				Value = _idiscardforenergytodeploytype
			};
		}

		// Token: 0x06028E4E RID: 167502 RVA: 0x0059E549 File Offset: 0x0059C749
		public IDiscardForEnergyToEvolutionTypeT AsIDiscardForEnergyToEvolutionType()
		{
			return this.As<IDiscardForEnergyToEvolutionTypeT>();
		}

		// Token: 0x06028E4F RID: 167503 RVA: 0x0059E551 File Offset: 0x0059C751
		public static IBvbRecycleBoardCardData_UnionUnion FromIDiscardForEnergyToEvolutionType(IDiscardForEnergyToEvolutionTypeT _idiscardforenergytoevolutiontype)
		{
			return new IBvbRecycleBoardCardData_UnionUnion
			{
				Type = IBvbRecycleBoardCardData_Union.IDiscardForEnergyToEvolutionType,
				Value = _idiscardforenergytoevolutiontype
			};
		}

		// Token: 0x06028E50 RID: 167504 RVA: 0x0059E568 File Offset: 0x0059C768
		public static int Pack(FlatBufferBuilder builder, IBvbRecycleBoardCardData_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBvbRecycleBoardCardData_Union.IBvbRecycleBoardCardData:
				return IBvbRecycleBoardCardData.Pack(builder, _o.AsIBvbRecycleBoardCardData()).Value;
			case IBvbRecycleBoardCardData_Union.IDiscardForEnergyToDeployType:
				return IDiscardForEnergyToDeployType.Pack(builder, _o.AsIDiscardForEnergyToDeployType()).Value;
			case IBvbRecycleBoardCardData_Union.IDiscardForEnergyToEvolutionType:
				return IDiscardForEnergyToEvolutionType.Pack(builder, _o.AsIDiscardForEnergyToEvolutionType()).Value;
			default:
				return 0;
			}
		}
	}
}
