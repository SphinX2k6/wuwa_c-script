using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A2B RID: 6699
	[NullableContext(1)]
	[Nullable(0)]
	public class IExitVehicleStandUp : IExitVehicleType
	{
		// Token: 0x06008F76 RID: 36726 RVA: 0x0014EFA4 File Offset: 0x0014D1A4
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

		// Token: 0x06008F77 RID: 36727 RVA: 0x0014EFDC File Offset: 0x0014D1DC
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

		// Token: 0x06008F78 RID: 36728 RVA: 0x0014EFEF File Offset: 0x0014D1EF
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

		// Token: 0x06008F79 RID: 36729 RVA: 0x0014F002 File Offset: 0x0014D202
		public new IExitVehicleStandUp_SetValue ToSetValue()
		{
			return new IExitVehicleStandUp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x06008F7A RID: 36730 RVA: 0x0014F015 File Offset: 0x0014D215
		// (set) Token: 0x06008F7B RID: 36731 RVA: 0x0014F040 File Offset: 0x0014D240
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

		// Token: 0x040058BF RID: 22719
		[Nullable(2)]
		protected new IExitVehicleStandUp FbInstance;

		// Token: 0x040058C0 RID: 22720
		[Nullable(2)]
		protected new IExitVehicleStandUp_SetValue PocoInterface;
	}
}
