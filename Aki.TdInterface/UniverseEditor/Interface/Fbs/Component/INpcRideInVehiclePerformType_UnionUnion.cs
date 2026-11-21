using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE9 RID: 23529
	public class INpcRideInVehiclePerformType_UnionUnion
	{
		// Token: 0x1700AC2F RID: 44079
		// (get) Token: 0x06026DB2 RID: 159154 RVA: 0x00551EF5 File Offset: 0x005500F5
		// (set) Token: 0x06026DB3 RID: 159155 RVA: 0x00551EFD File Offset: 0x005500FD
		public INpcRideInVehiclePerformType_Union Type { get; set; }

		// Token: 0x1700AC30 RID: 44080
		// (get) Token: 0x06026DB4 RID: 159156 RVA: 0x00551F06 File Offset: 0x00550106
		// (set) Token: 0x06026DB5 RID: 159157 RVA: 0x00551F0E File Offset: 0x0055010E
		public object Value { get; set; }

		// Token: 0x06026DB6 RID: 159158 RVA: 0x00551F17 File Offset: 0x00550117
		public INpcRideInVehiclePerformType_UnionUnion()
		{
			this.Type = INpcRideInVehiclePerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026DB7 RID: 159159 RVA: 0x00551F2D File Offset: 0x0055012D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026DB8 RID: 159160 RVA: 0x00551F3F File Offset: 0x0055013F
		public INpcRideInVehiclePerformTypeT AsINpcRideInVehiclePerformType()
		{
			return this.As<INpcRideInVehiclePerformTypeT>();
		}

		// Token: 0x06026DB9 RID: 159161 RVA: 0x00551F47 File Offset: 0x00550147
		public static INpcRideInVehiclePerformType_UnionUnion FromINpcRideInVehiclePerformType(INpcRideInVehiclePerformTypeT _inpcrideinvehicleperformtype)
		{
			return new INpcRideInVehiclePerformType_UnionUnion
			{
				Type = INpcRideInVehiclePerformType_Union.INpcRideInVehiclePerformType,
				Value = _inpcrideinvehicleperformtype
			};
		}

		// Token: 0x06026DBA RID: 159162 RVA: 0x00551F5C File Offset: 0x0055015C
		public INpcRideInGongduolaPerformT AsINpcRideInGongduolaPerform()
		{
			return this.As<INpcRideInGongduolaPerformT>();
		}

		// Token: 0x06026DBB RID: 159163 RVA: 0x00551F64 File Offset: 0x00550164
		public static INpcRideInVehiclePerformType_UnionUnion FromINpcRideInGongduolaPerform(INpcRideInGongduolaPerformT _inpcrideingongduolaperform)
		{
			return new INpcRideInVehiclePerformType_UnionUnion
			{
				Type = INpcRideInVehiclePerformType_Union.INpcRideInGongduolaPerform,
				Value = _inpcrideingongduolaperform
			};
		}

		// Token: 0x06026DBC RID: 159164 RVA: 0x00551F79 File Offset: 0x00550179
		public INpcRideInAutoGongduolaPerformT AsINpcRideInAutoGongduolaPerform()
		{
			return this.As<INpcRideInAutoGongduolaPerformT>();
		}

		// Token: 0x06026DBD RID: 159165 RVA: 0x00551F81 File Offset: 0x00550181
		public static INpcRideInVehiclePerformType_UnionUnion FromINpcRideInAutoGongduolaPerform(INpcRideInAutoGongduolaPerformT _inpcrideinautogongduolaperform)
		{
			return new INpcRideInVehiclePerformType_UnionUnion
			{
				Type = INpcRideInVehiclePerformType_Union.INpcRideInAutoGongduolaPerform,
				Value = _inpcrideinautogongduolaperform
			};
		}

		// Token: 0x06026DBE RID: 159166 RVA: 0x00551F96 File Offset: 0x00550196
		public ICyberpunkShareEmptyVehiclePerformT AsICyberpunkShareEmptyVehiclePerform()
		{
			return this.As<ICyberpunkShareEmptyVehiclePerformT>();
		}

		// Token: 0x06026DBF RID: 159167 RVA: 0x00551F9E File Offset: 0x0055019E
		public static INpcRideInVehiclePerformType_UnionUnion FromICyberpunkShareEmptyVehiclePerform(ICyberpunkShareEmptyVehiclePerformT _icyberpunkshareemptyvehicleperform)
		{
			return new INpcRideInVehiclePerformType_UnionUnion
			{
				Type = INpcRideInVehiclePerformType_Union.ICyberpunkShareEmptyVehiclePerform,
				Value = _icyberpunkshareemptyvehicleperform
			};
		}

		// Token: 0x06026DC0 RID: 159168 RVA: 0x00551FB3 File Offset: 0x005501B3
		public IWoodenOxenAndFlowingHorsesPerformT AsIWoodenOxenAndFlowingHorsesPerform()
		{
			return this.As<IWoodenOxenAndFlowingHorsesPerformT>();
		}

		// Token: 0x06026DC1 RID: 159169 RVA: 0x00551FBB File Offset: 0x005501BB
		public static INpcRideInVehiclePerformType_UnionUnion FromIWoodenOxenAndFlowingHorsesPerform(IWoodenOxenAndFlowingHorsesPerformT _iwoodenoxenandflowinghorsesperform)
		{
			return new INpcRideInVehiclePerformType_UnionUnion
			{
				Type = INpcRideInVehiclePerformType_Union.IWoodenOxenAndFlowingHorsesPerform,
				Value = _iwoodenoxenandflowinghorsesperform
			};
		}

		// Token: 0x06026DC2 RID: 159170 RVA: 0x00551FD0 File Offset: 0x005501D0
		public static int Pack(FlatBufferBuilder builder, INpcRideInVehiclePerformType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INpcRideInVehiclePerformType_Union.INpcRideInVehiclePerformType:
				return INpcRideInVehiclePerformType.Pack(builder, _o.AsINpcRideInVehiclePerformType()).Value;
			case INpcRideInVehiclePerformType_Union.INpcRideInGongduolaPerform:
				return INpcRideInGongduolaPerform.Pack(builder, _o.AsINpcRideInGongduolaPerform()).Value;
			case INpcRideInVehiclePerformType_Union.INpcRideInAutoGongduolaPerform:
				return INpcRideInAutoGongduolaPerform.Pack(builder, _o.AsINpcRideInAutoGongduolaPerform()).Value;
			case INpcRideInVehiclePerformType_Union.ICyberpunkShareEmptyVehiclePerform:
				return ICyberpunkShareEmptyVehiclePerform.Pack(builder, _o.AsICyberpunkShareEmptyVehiclePerform()).Value;
			case INpcRideInVehiclePerformType_Union.IWoodenOxenAndFlowingHorsesPerform:
				return IWoodenOxenAndFlowingHorsesPerform.Pack(builder, _o.AsIWoodenOxenAndFlowingHorsesPerform()).Value;
			default:
				return 0;
			}
		}
	}
}
