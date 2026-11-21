using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BBC RID: 7100
	public class IExitVehicleLaunch : IExitVehicleType
	{
		// Token: 0x060096D0 RID: 38608 RVA: 0x0015ED58 File Offset: 0x0015CF58
		private IExitVehicleLaunch_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExitVehicleLaunch 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExitVehicleLaunch_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExitVehicleLaunch_SetValue());
			}
			return result;
		}

		// Token: 0x060096D1 RID: 38609 RVA: 0x0015ED90 File Offset: 0x0015CF90
		public static IExitVehicleLaunch Create([Nullable(2)] IExitVehicleLaunch instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleLaunch
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096D2 RID: 38610 RVA: 0x0015EDA3 File Offset: 0x0015CFA3
		public static IExitVehicleLaunch CreateFromSetValue([Nullable(2)] IExitVehicleLaunch_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExitVehicleLaunch
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096D3 RID: 38611 RVA: 0x0015EDB6 File Offset: 0x0015CFB6
		public new IExitVehicleLaunch_SetValue ToSetValue()
		{
			return new IExitVehicleLaunch_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x060096D4 RID: 38612 RVA: 0x0015EDC9 File Offset: 0x0015CFC9
		// (set) Token: 0x060096D5 RID: 38613 RVA: 0x0015EDF4 File Offset: 0x0015CFF4
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

		// Token: 0x04005D1E RID: 23838
		[Nullable(2)]
		protected new IExitVehicleLaunch FbInstance;

		// Token: 0x04005D1F RID: 23839
		[Nullable(2)]
		protected new IExitVehicleLaunch_SetValue PocoInterface;
	}
}
