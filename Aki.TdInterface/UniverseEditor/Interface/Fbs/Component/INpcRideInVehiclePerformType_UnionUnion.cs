using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200564B RID: 22091
	public class INpcRideInVehiclePerformType_UnionUnion
	{
		// Token: 0x1700A3A5 RID: 41893
		// (get) Token: 0x06024B93 RID: 150419 RVA: 0x005115D1 File Offset: 0x0050F7D1
		// (set) Token: 0x06024B94 RID: 150420 RVA: 0x005115D9 File Offset: 0x0050F7D9
		public INpcRideInVehiclePerformType_Union Type { get; set; }

		// Token: 0x1700A3A6 RID: 41894
		// (get) Token: 0x06024B95 RID: 150421 RVA: 0x005115E2 File Offset: 0x0050F7E2
		// (set) Token: 0x06024B96 RID: 150422 RVA: 0x005115EA File Offset: 0x0050F7EA
		public object Value { get; set; }

		// Token: 0x06024B97 RID: 150423 RVA: 0x005115F3 File Offset: 0x0050F7F3
		public INpcRideInVehiclePerformType_UnionUnion()
		{
			this.Type = INpcRideInVehiclePerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024B98 RID: 150424 RVA: 0x00511609 File Offset: 0x0050F809
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024B99 RID: 150425 RVA: 0x0051161B File Offset: 0x0050F81B
		public INpcRideInVehiclePerformTypeT AsINpcRideInVehiclePerformType()
		{
			return this.As<INpcRideInVehiclePerformTypeT>();
		}

		// Token: 0x06024B9A RID: 150426 RVA: 0x00511623 File Offset: 0x0050F823
		public static INpcRideInVehiclePerformType_UnionUnion FromINpcRideInVehiclePerformType(INpcRideInVehiclePerformTypeT _inpcrideinvehicleperformtype)
		{
			return new INpcRideInVehiclePerformType_UnionUnion
			{
				Type = INpcRideInVehiclePerformType_Union.INpcRideInVehiclePerformType,
				Value = _inpcrideinvehicleperformtype
			};
		}

		// Token: 0x06024B9B RID: 150427 RVA: 0x00511638 File Offset: 0x0050F838
		public INpcRideInGongduolaPerformT AsINpcRideInGongduolaPerform()
		{
			return this.As<INpcRideInGongduolaPerformT>();
		}

		// Token: 0x06024B9C RID: 150428 RVA: 0x00511640 File Offset: 0x0050F840
		public static INpcRideInVehiclePerformType_UnionUnion FromINpcRideInGongduolaPerform(INpcRideInGongduolaPerformT _inpcrideingongduolaperform)
		{
			return new INpcRideInVehiclePerformType_UnionUnion
			{
				Type = INpcRideInVehiclePerformType_Union.INpcRideInGongduolaPerform,
				Value = _inpcrideingongduolaperform
			};
		}

		// Token: 0x06024B9D RID: 150429 RVA: 0x00511655 File Offset: 0x0050F855
		public INpcRideInAutoGongduolaPerformT AsINpcRideInAutoGongduolaPerform()
		{
			return this.As<INpcRideInAutoGongduolaPerformT>();
		}

		// Token: 0x06024B9E RID: 150430 RVA: 0x0051165D File Offset: 0x0050F85D
		public static INpcRideInVehiclePerformType_UnionUnion FromINpcRideInAutoGongduolaPerform(INpcRideInAutoGongduolaPerformT _inpcrideinautogongduolaperform)
		{
			return new INpcRideInVehiclePerformType_UnionUnion
			{
				Type = INpcRideInVehiclePerformType_Union.INpcRideInAutoGongduolaPerform,
				Value = _inpcrideinautogongduolaperform
			};
		}

		// Token: 0x06024B9F RID: 150431 RVA: 0x00511672 File Offset: 0x0050F872
		public ICyberpunkShareEmptyVehiclePerformT AsICyberpunkShareEmptyVehiclePerform()
		{
			return this.As<ICyberpunkShareEmptyVehiclePerformT>();
		}

		// Token: 0x06024BA0 RID: 150432 RVA: 0x0051167A File Offset: 0x0050F87A
		public static INpcRideInVehiclePerformType_UnionUnion FromICyberpunkShareEmptyVehiclePerform(ICyberpunkShareEmptyVehiclePerformT _icyberpunkshareemptyvehicleperform)
		{
			return new INpcRideInVehiclePerformType_UnionUnion
			{
				Type = INpcRideInVehiclePerformType_Union.ICyberpunkShareEmptyVehiclePerform,
				Value = _icyberpunkshareemptyvehicleperform
			};
		}

		// Token: 0x06024BA1 RID: 150433 RVA: 0x0051168F File Offset: 0x0050F88F
		public IWoodenOxenAndFlowingHorsesPerformT AsIWoodenOxenAndFlowingHorsesPerform()
		{
			return this.As<IWoodenOxenAndFlowingHorsesPerformT>();
		}

		// Token: 0x06024BA2 RID: 150434 RVA: 0x00511697 File Offset: 0x0050F897
		public static INpcRideInVehiclePerformType_UnionUnion FromIWoodenOxenAndFlowingHorsesPerform(IWoodenOxenAndFlowingHorsesPerformT _iwoodenoxenandflowinghorsesperform)
		{
			return new INpcRideInVehiclePerformType_UnionUnion
			{
				Type = INpcRideInVehiclePerformType_Union.IWoodenOxenAndFlowingHorsesPerform,
				Value = _iwoodenoxenandflowinghorsesperform
			};
		}

		// Token: 0x06024BA3 RID: 150435 RVA: 0x005116AC File Offset: 0x0050F8AC
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
