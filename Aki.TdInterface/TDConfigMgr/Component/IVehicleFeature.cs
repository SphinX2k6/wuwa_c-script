using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000856 RID: 2134
	public class IVehicleFeature
	{
		// Token: 0x06002DE9 RID: 11753 RVA: 0x0007719C File Offset: 0x0007539C
		private IVehicleFeature_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleFeature 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleFeature_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleFeature_SetValue());
			}
			return result;
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x000771D4 File Offset: 0x000753D4
		public static IVehicleFeature Create([Nullable(2)] IVehicleFeature instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleFeature
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000771E7 File Offset: 0x000753E7
		public static IVehicleFeature CreateFromSetValue([Nullable(2)] IVehicleFeature_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleFeature
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x000771FA File Offset: 0x000753FA
		public IVehicleFeature_SetValue ToSetValue()
		{
			return new IVehicleFeature_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x0007720D File Offset: 0x0007540D
		// (set) Token: 0x06002DEE RID: 11758 RVA: 0x00077238 File Offset: 0x00075438
		public virtual EVehicleFeatureFlag Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EVehicleFeatureFlag)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001E85 RID: 7813
		[Nullable(2)]
		protected IVehicleFeature FbInstance;

		// Token: 0x04001E86 RID: 7814
		[Nullable(2)]
		protected IVehicleFeature_SetValue PocoInterface;
	}
}
