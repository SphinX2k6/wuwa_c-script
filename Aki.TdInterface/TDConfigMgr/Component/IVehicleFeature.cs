using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007B3 RID: 1971
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleFeature
	{
		// Token: 0x06002AB9 RID: 10937 RVA: 0x0006FE38 File Offset: 0x0006E038
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

		// Token: 0x06002ABA RID: 10938 RVA: 0x0006FE70 File Offset: 0x0006E070
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

		// Token: 0x06002ABB RID: 10939 RVA: 0x0006FE83 File Offset: 0x0006E083
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

		// Token: 0x06002ABC RID: 10940 RVA: 0x0006FE96 File Offset: 0x0006E096
		public IVehicleFeature_SetValue ToSetValue()
		{
			return new IVehicleFeature_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x0006FEA9 File Offset: 0x0006E0A9
		// (set) Token: 0x06002ABE RID: 10942 RVA: 0x0006FED4 File Offset: 0x0006E0D4
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

		// Token: 0x04001C79 RID: 7289
		[Nullable(2)]
		protected IVehicleFeature FbInstance;

		// Token: 0x04001C7A RID: 7290
		[Nullable(2)]
		protected IVehicleFeature_SetValue PocoInterface;
	}
}
