using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BBE RID: 7102
	public class IExitVehicleSeatStandUp : IExitVehicleType
	{
		// Token: 0x060096D8 RID: 38616 RVA: 0x0015EE14 File Offset: 0x0015D014
		private IExitVehicleSeatStandUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExitVehicleSeatStandUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExitVehicleSeatStandUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExitVehicleSeatStandUp_SetValue());
			}
			return result;
		}

		// Token: 0x060096D9 RID: 38617 RVA: 0x0015EE4C File Offset: 0x0015D04C
		public static IExitVehicleSeatStandUp Create([Nullable(2)] IExitVehicleSeatStandUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleSeatStandUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096DA RID: 38618 RVA: 0x0015EE5F File Offset: 0x0015D05F
		public static IExitVehicleSeatStandUp CreateFromSetValue([Nullable(2)] IExitVehicleSeatStandUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExitVehicleSeatStandUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096DB RID: 38619 RVA: 0x0015EE72 File Offset: 0x0015D072
		public new IExitVehicleSeatStandUp_SetValue ToSetValue()
		{
			return new IExitVehicleSeatStandUp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x060096DC RID: 38620 RVA: 0x0015EE85 File Offset: 0x0015D085
		// (set) Token: 0x060096DD RID: 38621 RVA: 0x0015EEB0 File Offset: 0x0015D0B0
		public override EExitVehicleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExitVehicleType.Launch;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D21 RID: 23841
		[Nullable(2)]
		protected new IExitVehicleSeatStandUp FbInstance;

		// Token: 0x04005D22 RID: 23842
		[Nullable(2)]
		protected new IExitVehicleSeatStandUp_SetValue PocoInterface;
	}
}
