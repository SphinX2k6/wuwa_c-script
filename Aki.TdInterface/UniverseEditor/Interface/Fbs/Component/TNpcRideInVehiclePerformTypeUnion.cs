using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C73 RID: 23667
	public class TNpcRideInVehiclePerformTypeUnion
	{
		// Token: 0x1700B22A RID: 45610
		// (get) Token: 0x060288C9 RID: 166089 RVA: 0x00593686 File Offset: 0x00591886
		// (set) Token: 0x060288CA RID: 166090 RVA: 0x0059368E File Offset: 0x0059188E
		public TNpcRideInVehiclePerformType Type { get; set; }

		// Token: 0x1700B22B RID: 45611
		// (get) Token: 0x060288CB RID: 166091 RVA: 0x00593697 File Offset: 0x00591897
		// (set) Token: 0x060288CC RID: 166092 RVA: 0x0059369F File Offset: 0x0059189F
		public object Value { get; set; }

		// Token: 0x060288CD RID: 166093 RVA: 0x005936A8 File Offset: 0x005918A8
		public TNpcRideInVehiclePerformTypeUnion()
		{
			this.Type = TNpcRideInVehiclePerformType.NONE;
			this.Value = null;
		}

		// Token: 0x060288CE RID: 166094 RVA: 0x005936BE File Offset: 0x005918BE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060288CF RID: 166095 RVA: 0x005936D0 File Offset: 0x005918D0
		public ICyberpunkShareEmptyVehiclePerformT AsICyberpunkShareEmptyVehiclePerform()
		{
			return this.As<ICyberpunkShareEmptyVehiclePerformT>();
		}

		// Token: 0x060288D0 RID: 166096 RVA: 0x005936D8 File Offset: 0x005918D8
		public static TNpcRideInVehiclePerformTypeUnion FromICyberpunkShareEmptyVehiclePerform(ICyberpunkShareEmptyVehiclePerformT _icyberpunkshareemptyvehicleperform)
		{
			return new TNpcRideInVehiclePerformTypeUnion
			{
				Type = TNpcRideInVehiclePerformType.ICyberpunkShareEmptyVehiclePerform,
				Value = _icyberpunkshareemptyvehicleperform
			};
		}

		// Token: 0x060288D1 RID: 166097 RVA: 0x005936ED File Offset: 0x005918ED
		public INpcRideInAutoGongduolaPerformT AsINpcRideInAutoGongduolaPerform()
		{
			return this.As<INpcRideInAutoGongduolaPerformT>();
		}

		// Token: 0x060288D2 RID: 166098 RVA: 0x005936F5 File Offset: 0x005918F5
		public static TNpcRideInVehiclePerformTypeUnion FromINpcRideInAutoGongduolaPerform(INpcRideInAutoGongduolaPerformT _inpcrideinautogongduolaperform)
		{
			return new TNpcRideInVehiclePerformTypeUnion
			{
				Type = TNpcRideInVehiclePerformType.INpcRideInAutoGongduolaPerform,
				Value = _inpcrideinautogongduolaperform
			};
		}

		// Token: 0x060288D3 RID: 166099 RVA: 0x0059370A File Offset: 0x0059190A
		public INpcRideInGongduolaPerformT AsINpcRideInGongduolaPerform()
		{
			return this.As<INpcRideInGongduolaPerformT>();
		}

		// Token: 0x060288D4 RID: 166100 RVA: 0x00593712 File Offset: 0x00591912
		public static TNpcRideInVehiclePerformTypeUnion FromINpcRideInGongduolaPerform(INpcRideInGongduolaPerformT _inpcrideingongduolaperform)
		{
			return new TNpcRideInVehiclePerformTypeUnion
			{
				Type = TNpcRideInVehiclePerformType.INpcRideInGongduolaPerform,
				Value = _inpcrideingongduolaperform
			};
		}

		// Token: 0x060288D5 RID: 166101 RVA: 0x00593727 File Offset: 0x00591927
		public IWoodenOxenAndFlowingHorsesPerformT AsIWoodenOxenAndFlowingHorsesPerform()
		{
			return this.As<IWoodenOxenAndFlowingHorsesPerformT>();
		}

		// Token: 0x060288D6 RID: 166102 RVA: 0x0059372F File Offset: 0x0059192F
		public static TNpcRideInVehiclePerformTypeUnion FromIWoodenOxenAndFlowingHorsesPerform(IWoodenOxenAndFlowingHorsesPerformT _iwoodenoxenandflowinghorsesperform)
		{
			return new TNpcRideInVehiclePerformTypeUnion
			{
				Type = TNpcRideInVehiclePerformType.IWoodenOxenAndFlowingHorsesPerform,
				Value = _iwoodenoxenandflowinghorsesperform
			};
		}

		// Token: 0x060288D7 RID: 166103 RVA: 0x00593744 File Offset: 0x00591944
		public static int Pack(FlatBufferBuilder builder, TNpcRideInVehiclePerformTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TNpcRideInVehiclePerformType.ICyberpunkShareEmptyVehiclePerform:
				return ICyberpunkShareEmptyVehiclePerform.Pack(builder, _o.AsICyberpunkShareEmptyVehiclePerform()).Value;
			case TNpcRideInVehiclePerformType.INpcRideInAutoGongduolaPerform:
				return INpcRideInAutoGongduolaPerform.Pack(builder, _o.AsINpcRideInAutoGongduolaPerform()).Value;
			case TNpcRideInVehiclePerformType.INpcRideInGongduolaPerform:
				return INpcRideInGongduolaPerform.Pack(builder, _o.AsINpcRideInGongduolaPerform()).Value;
			case TNpcRideInVehiclePerformType.IWoodenOxenAndFlowingHorsesPerform:
				return IWoodenOxenAndFlowingHorsesPerform.Pack(builder, _o.AsIWoodenOxenAndFlowingHorsesPerform()).Value;
			default:
				return 0;
			}
		}
	}
}
