using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002286 RID: 8838
	public class IVehicleEntity : ITargetEntityType
	{
		// Token: 0x0600C088 RID: 49288 RVA: 0x001BBB00 File Offset: 0x001B9D00
		private IVehicleEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600C089 RID: 49289 RVA: 0x001BBB38 File Offset: 0x001B9D38
		public static IVehicleEntity Create([Nullable(2)] IVehicleEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C08A RID: 49290 RVA: 0x001BBB4B File Offset: 0x001B9D4B
		public static IVehicleEntity CreateFromSetValue([Nullable(2)] IVehicleEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C08B RID: 49291 RVA: 0x001BBB5E File Offset: 0x001B9D5E
		public new IVehicleEntity_SetValue ToSetValue()
		{
			return new IVehicleEntity_SetValue
			{
				Type = this.Type,
				Vehicle = this.Vehicle
			};
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x0600C08C RID: 49292 RVA: 0x001BBB7D File Offset: 0x001B9D7D
		// (set) Token: 0x0600C08D RID: 49293 RVA: 0x001BBBA8 File Offset: 0x001B9DA8
		public override ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x0600C08E RID: 49294 RVA: 0x001BBBB6 File Offset: 0x001B9DB6
		// (set) Token: 0x0600C08F RID: 49295 RVA: 0x001BBBDD File Offset: 0x001B9DDD
		public virtual ITargetVehicle Vehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Vehicle;
				}
				IVehicleEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Vehicle;
			}
			set
			{
				this.GetOrCreatePoco().Vehicle = value;
			}
		}

		// Token: 0x04007330 RID: 29488
		[Nullable(2)]
		protected new IVehicleEntity FbInstance;

		// Token: 0x04007331 RID: 29489
		[Nullable(2)]
		protected new IVehicleEntity_SetValue PocoInterface;
	}
}
