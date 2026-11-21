using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200228C RID: 8844
	public class IVehicleNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600C0A8 RID: 49320 RVA: 0x001BBE48 File Offset: 0x001BA048
		private IVehicleNewSplineStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleNewSplineStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleNewSplineStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleNewSplineStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600C0A9 RID: 49321 RVA: 0x001BBE80 File Offset: 0x001BA080
		public static IVehicleNewSplineStopTarget Create([Nullable(2)] IVehicleNewSplineStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleNewSplineStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C0AA RID: 49322 RVA: 0x001BBE93 File Offset: 0x001BA093
		public static IVehicleNewSplineStopTarget CreateFromSetValue([Nullable(2)] IVehicleNewSplineStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleNewSplineStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C0AB RID: 49323 RVA: 0x001BBEA6 File Offset: 0x001BA0A6
		public new IVehicleNewSplineStopTarget_SetValue ToSetValue()
		{
			return new IVehicleNewSplineStopTarget_SetValue
			{
				Type = this.Type,
				TargetVehicle = this.TargetVehicle
			};
		}

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x0600C0AC RID: 49324 RVA: 0x001BBEC5 File Offset: 0x001BA0C5
		// (set) Token: 0x0600C0AD RID: 49325 RVA: 0x001BBEF0 File Offset: 0x001BA0F0
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x0600C0AE RID: 49326 RVA: 0x001BBEFE File Offset: 0x001BA0FE
		// (set) Token: 0x0600C0AF RID: 49327 RVA: 0x001BBF25 File Offset: 0x001BA125
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetVehicle;
				}
				IVehicleNewSplineStopTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400733D RID: 29501
		[Nullable(2)]
		protected new IVehicleNewSplineStopTarget FbInstance;

		// Token: 0x0400733E RID: 29502
		[Nullable(2)]
		protected new IVehicleNewSplineStopTarget_SetValue PocoInterface;
	}
}
