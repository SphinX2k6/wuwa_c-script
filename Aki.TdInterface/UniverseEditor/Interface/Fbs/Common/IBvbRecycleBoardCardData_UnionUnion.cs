using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006396 RID: 25494
	public class IBvbRecycleBoardCardData_UnionUnion
	{
		// Token: 0x1700BC75 RID: 48245
		// (get) Token: 0x0602B4AE RID: 177326 RVA: 0x005E6F35 File Offset: 0x005E5135
		// (set) Token: 0x0602B4AF RID: 177327 RVA: 0x005E6F3D File Offset: 0x005E513D
		public IBvbRecycleBoardCardData_Union Type { get; set; }

		// Token: 0x1700BC76 RID: 48246
		// (get) Token: 0x0602B4B0 RID: 177328 RVA: 0x005E6F46 File Offset: 0x005E5146
		// (set) Token: 0x0602B4B1 RID: 177329 RVA: 0x005E6F4E File Offset: 0x005E514E
		public object Value { get; set; }

		// Token: 0x0602B4B2 RID: 177330 RVA: 0x005E6F57 File Offset: 0x005E5157
		public IBvbRecycleBoardCardData_UnionUnion()
		{
			this.Type = IBvbRecycleBoardCardData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B4B3 RID: 177331 RVA: 0x005E6F6D File Offset: 0x005E516D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B4B4 RID: 177332 RVA: 0x005E6F7F File Offset: 0x005E517F
		public IBvbRecycleBoardCardDataT AsIBvbRecycleBoardCardData()
		{
			return this.As<IBvbRecycleBoardCardDataT>();
		}

		// Token: 0x0602B4B5 RID: 177333 RVA: 0x005E6F87 File Offset: 0x005E5187
		public static IBvbRecycleBoardCardData_UnionUnion FromIBvbRecycleBoardCardData(IBvbRecycleBoardCardDataT _ibvbrecycleboardcarddata)
		{
			return new IBvbRecycleBoardCardData_UnionUnion
			{
				Type = IBvbRecycleBoardCardData_Union.IBvbRecycleBoardCardData,
				Value = _ibvbrecycleboardcarddata
			};
		}

		// Token: 0x0602B4B6 RID: 177334 RVA: 0x005E6F9C File Offset: 0x005E519C
		public IDiscardForEnergyToDeployTypeT AsIDiscardForEnergyToDeployType()
		{
			return this.As<IDiscardForEnergyToDeployTypeT>();
		}

		// Token: 0x0602B4B7 RID: 177335 RVA: 0x005E6FA4 File Offset: 0x005E51A4
		public static IBvbRecycleBoardCardData_UnionUnion FromIDiscardForEnergyToDeployType(IDiscardForEnergyToDeployTypeT _idiscardforenergytodeploytype)
		{
			return new IBvbRecycleBoardCardData_UnionUnion
			{
				Type = IBvbRecycleBoardCardData_Union.IDiscardForEnergyToDeployType,
				Value = _idiscardforenergytodeploytype
			};
		}

		// Token: 0x0602B4B8 RID: 177336 RVA: 0x005E6FB9 File Offset: 0x005E51B9
		public IDiscardForEnergyToEvolutionTypeT AsIDiscardForEnergyToEvolutionType()
		{
			return this.As<IDiscardForEnergyToEvolutionTypeT>();
		}

		// Token: 0x0602B4B9 RID: 177337 RVA: 0x005E6FC1 File Offset: 0x005E51C1
		public static IBvbRecycleBoardCardData_UnionUnion FromIDiscardForEnergyToEvolutionType(IDiscardForEnergyToEvolutionTypeT _idiscardforenergytoevolutiontype)
		{
			return new IBvbRecycleBoardCardData_UnionUnion
			{
				Type = IBvbRecycleBoardCardData_Union.IDiscardForEnergyToEvolutionType,
				Value = _idiscardforenergytoevolutiontype
			};
		}

		// Token: 0x0602B4BA RID: 177338 RVA: 0x005E6FD8 File Offset: 0x005E51D8
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
