using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200629B RID: 25243
	public class TNpcRideInVehiclePerformTypeUnion
	{
		// Token: 0x1700BB7E RID: 47998
		// (get) Token: 0x0602AEE9 RID: 175849 RVA: 0x005DBA78 File Offset: 0x005D9C78
		// (set) Token: 0x0602AEEA RID: 175850 RVA: 0x005DBA80 File Offset: 0x005D9C80
		public TNpcRideInVehiclePerformType Type { get; set; }

		// Token: 0x1700BB7F RID: 47999
		// (get) Token: 0x0602AEEB RID: 175851 RVA: 0x005DBA89 File Offset: 0x005D9C89
		// (set) Token: 0x0602AEEC RID: 175852 RVA: 0x005DBA91 File Offset: 0x005D9C91
		public object Value { get; set; }

		// Token: 0x0602AEED RID: 175853 RVA: 0x005DBA9A File Offset: 0x005D9C9A
		public TNpcRideInVehiclePerformTypeUnion()
		{
			this.Type = TNpcRideInVehiclePerformType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AEEE RID: 175854 RVA: 0x005DBAB0 File Offset: 0x005D9CB0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AEEF RID: 175855 RVA: 0x005DBAC2 File Offset: 0x005D9CC2
		public ICyberpunkShareEmptyVehiclePerformT AsICyberpunkShareEmptyVehiclePerform()
		{
			return this.As<ICyberpunkShareEmptyVehiclePerformT>();
		}

		// Token: 0x0602AEF0 RID: 175856 RVA: 0x005DBACA File Offset: 0x005D9CCA
		public static TNpcRideInVehiclePerformTypeUnion FromICyberpunkShareEmptyVehiclePerform(ICyberpunkShareEmptyVehiclePerformT _icyberpunkshareemptyvehicleperform)
		{
			return new TNpcRideInVehiclePerformTypeUnion
			{
				Type = TNpcRideInVehiclePerformType.ICyberpunkShareEmptyVehiclePerform,
				Value = _icyberpunkshareemptyvehicleperform
			};
		}

		// Token: 0x0602AEF1 RID: 175857 RVA: 0x005DBADF File Offset: 0x005D9CDF
		public INpcRideInAutoGongduolaPerformT AsINpcRideInAutoGongduolaPerform()
		{
			return this.As<INpcRideInAutoGongduolaPerformT>();
		}

		// Token: 0x0602AEF2 RID: 175858 RVA: 0x005DBAE7 File Offset: 0x005D9CE7
		public static TNpcRideInVehiclePerformTypeUnion FromINpcRideInAutoGongduolaPerform(INpcRideInAutoGongduolaPerformT _inpcrideinautogongduolaperform)
		{
			return new TNpcRideInVehiclePerformTypeUnion
			{
				Type = TNpcRideInVehiclePerformType.INpcRideInAutoGongduolaPerform,
				Value = _inpcrideinautogongduolaperform
			};
		}

		// Token: 0x0602AEF3 RID: 175859 RVA: 0x005DBAFC File Offset: 0x005D9CFC
		public INpcRideInGongduolaPerformT AsINpcRideInGongduolaPerform()
		{
			return this.As<INpcRideInGongduolaPerformT>();
		}

		// Token: 0x0602AEF4 RID: 175860 RVA: 0x005DBB04 File Offset: 0x005D9D04
		public static TNpcRideInVehiclePerformTypeUnion FromINpcRideInGongduolaPerform(INpcRideInGongduolaPerformT _inpcrideingongduolaperform)
		{
			return new TNpcRideInVehiclePerformTypeUnion
			{
				Type = TNpcRideInVehiclePerformType.INpcRideInGongduolaPerform,
				Value = _inpcrideingongduolaperform
			};
		}

		// Token: 0x0602AEF5 RID: 175861 RVA: 0x005DBB19 File Offset: 0x005D9D19
		public IWoodenOxenAndFlowingHorsesPerformT AsIWoodenOxenAndFlowingHorsesPerform()
		{
			return this.As<IWoodenOxenAndFlowingHorsesPerformT>();
		}

		// Token: 0x0602AEF6 RID: 175862 RVA: 0x005DBB21 File Offset: 0x005D9D21
		public static TNpcRideInVehiclePerformTypeUnion FromIWoodenOxenAndFlowingHorsesPerform(IWoodenOxenAndFlowingHorsesPerformT _iwoodenoxenandflowinghorsesperform)
		{
			return new TNpcRideInVehiclePerformTypeUnion
			{
				Type = TNpcRideInVehiclePerformType.IWoodenOxenAndFlowingHorsesPerform,
				Value = _iwoodenoxenandflowinghorsesperform
			};
		}

		// Token: 0x0602AEF7 RID: 175863 RVA: 0x005DBB38 File Offset: 0x005D9D38
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
