using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002282 RID: 8834
	public class IVehicleEnteringTarget
	{
		// Token: 0x0600C072 RID: 49266 RVA: 0x001BB870 File Offset: 0x001B9A70
		private IVehicleEnteringTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleEnteringTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleEnteringTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleEnteringTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600C073 RID: 49267 RVA: 0x001BB8A8 File Offset: 0x001B9AA8
		public static IVehicleEnteringTarget Create([Nullable(2)] IVehicleEnteringTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnteringTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C074 RID: 49268 RVA: 0x001BB8BB File Offset: 0x001B9ABB
		public static IVehicleEnteringTarget CreateFromSetValue([Nullable(2)] IVehicleEnteringTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleEnteringTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C075 RID: 49269 RVA: 0x001BB8CE File Offset: 0x001B9ACE
		public IVehicleEnteringTarget_SetValue ToSetValue()
		{
			return new IVehicleEnteringTarget_SetValue
			{
				Type = this.Type,
				TargetVehicle = this.TargetVehicle
			};
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x0600C076 RID: 49270 RVA: 0x001BB8ED File Offset: 0x001B9AED
		// (set) Token: 0x0600C077 RID: 49271 RVA: 0x001BB918 File Offset: 0x001B9B18
		public virtual EVehicleEnteringTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVehicleEnteringTarget.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x0600C078 RID: 49272 RVA: 0x001BB928 File Offset: 0x001B9B28
		// (set) Token: 0x0600C079 RID: 49273 RVA: 0x001BB962 File Offset: 0x001B9B62
		public virtual int? TargetVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetVehicle;
				}
				IVehicleEnteringTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetVehicle;
			}
			set
			{
				this.GetOrCreatePoco().TargetVehicle = value;
			}
		}

		// Token: 0x04007325 RID: 29477
		[Nullable(2)]
		protected IVehicleEnteringTarget FbInstance;

		// Token: 0x04007326 RID: 29478
		[Nullable(2)]
		protected IVehicleEnteringTarget_SetValue PocoInterface;
	}
}
