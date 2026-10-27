using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A27 RID: 6695
	[NullableContext(1)]
	[Nullable(0)]
	public class IExitVehicleLaunch : IExitVehicleType
	{
		// Token: 0x06008F66 RID: 36710 RVA: 0x0014EE2C File Offset: 0x0014D02C
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

		// Token: 0x06008F67 RID: 36711 RVA: 0x0014EE64 File Offset: 0x0014D064
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

		// Token: 0x06008F68 RID: 36712 RVA: 0x0014EE77 File Offset: 0x0014D077
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

		// Token: 0x06008F69 RID: 36713 RVA: 0x0014EE8A File Offset: 0x0014D08A
		public new IExitVehicleLaunch_SetValue ToSetValue()
		{
			return new IExitVehicleLaunch_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x06008F6A RID: 36714 RVA: 0x0014EE9D File Offset: 0x0014D09D
		// (set) Token: 0x06008F6B RID: 36715 RVA: 0x0014EEC8 File Offset: 0x0014D0C8
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

		// Token: 0x040058B9 RID: 22713
		[Nullable(2)]
		protected new IExitVehicleLaunch FbInstance;

		// Token: 0x040058BA RID: 22714
		[Nullable(2)]
		protected new IExitVehicleLaunch_SetValue PocoInterface;
	}
}
