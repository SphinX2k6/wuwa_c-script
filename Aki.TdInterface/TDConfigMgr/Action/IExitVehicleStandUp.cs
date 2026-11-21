using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC0 RID: 7104
	public class IExitVehicleStandUp : IExitVehicleType
	{
		// Token: 0x060096E0 RID: 38624 RVA: 0x0015EED0 File Offset: 0x0015D0D0
		private IExitVehicleStandUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExitVehicleStandUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExitVehicleStandUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExitVehicleStandUp_SetValue());
			}
			return result;
		}

		// Token: 0x060096E1 RID: 38625 RVA: 0x0015EF08 File Offset: 0x0015D108
		public static IExitVehicleStandUp Create([Nullable(2)] IExitVehicleStandUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleStandUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096E2 RID: 38626 RVA: 0x0015EF1B File Offset: 0x0015D11B
		public static IExitVehicleStandUp CreateFromSetValue([Nullable(2)] IExitVehicleStandUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExitVehicleStandUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096E3 RID: 38627 RVA: 0x0015EF2E File Offset: 0x0015D12E
		public new IExitVehicleStandUp_SetValue ToSetValue()
		{
			return new IExitVehicleStandUp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x060096E4 RID: 38628 RVA: 0x0015EF41 File Offset: 0x0015D141
		// (set) Token: 0x060096E5 RID: 38629 RVA: 0x0015EF6C File Offset: 0x0015D16C
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

		// Token: 0x04005D24 RID: 23844
		[Nullable(2)]
		protected new IExitVehicleStandUp FbInstance;

		// Token: 0x04005D25 RID: 23845
		[Nullable(2)]
		protected new IExitVehicleStandUp_SetValue PocoInterface;
	}
}
