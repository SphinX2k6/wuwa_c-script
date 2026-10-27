using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A29 RID: 6697
	[NullableContext(1)]
	[Nullable(0)]
	public class IExitVehicleSeatStandUp : IExitVehicleType
	{
		// Token: 0x06008F6E RID: 36718 RVA: 0x0014EEE8 File Offset: 0x0014D0E8
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

		// Token: 0x06008F6F RID: 36719 RVA: 0x0014EF20 File Offset: 0x0014D120
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

		// Token: 0x06008F70 RID: 36720 RVA: 0x0014EF33 File Offset: 0x0014D133
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

		// Token: 0x06008F71 RID: 36721 RVA: 0x0014EF46 File Offset: 0x0014D146
		public new IExitVehicleSeatStandUp_SetValue ToSetValue()
		{
			return new IExitVehicleSeatStandUp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x06008F72 RID: 36722 RVA: 0x0014EF59 File Offset: 0x0014D159
		// (set) Token: 0x06008F73 RID: 36723 RVA: 0x0014EF84 File Offset: 0x0014D184
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

		// Token: 0x040058BC RID: 22716
		[Nullable(2)]
		protected new IExitVehicleSeatStandUp FbInstance;

		// Token: 0x040058BD RID: 22717
		[Nullable(2)]
		protected new IExitVehicleSeatStandUp_SetValue PocoInterface;
	}
}
