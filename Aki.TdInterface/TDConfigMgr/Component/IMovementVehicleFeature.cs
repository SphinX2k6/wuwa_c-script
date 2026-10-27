using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200053C RID: 1340
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovementVehicleFeature : IVehicleFeature
	{
		// Token: 0x06001B66 RID: 7014 RVA: 0x0004F510 File Offset: 0x0004D710
		private IMovementVehicleFeature_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovementVehicleFeature 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovementVehicleFeature_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovementVehicleFeature_SetValue());
			}
			return result;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0004F548 File Offset: 0x0004D748
		public static IMovementVehicleFeature Create([Nullable(2)] IMovementVehicleFeature instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovementVehicleFeature
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0004F55B File Offset: 0x0004D75B
		public static IMovementVehicleFeature CreateFromSetValue([Nullable(2)] IMovementVehicleFeature_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovementVehicleFeature
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0004F56E File Offset: 0x0004D76E
		public new IMovementVehicleFeature_SetValue ToSetValue()
		{
			return new IMovementVehicleFeature_SetValue
			{
				Type = this.Type,
				MoveSpline = this.MoveSpline,
				MovePerformConfig = this.MovePerformConfig
			};
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0004F599 File Offset: 0x0004D799
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0004F5C4 File Offset: 0x0004D7C4
		public override EVehicleFeatureFlag Type
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

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0004F5D4 File Offset: 0x0004D7D4
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0004F60E File Offset: 0x0004D80E
		public virtual int? MoveSpline
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveSpline;
				}
				IMovementVehicleFeature_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveSpline;
			}
			set
			{
				this.GetOrCreatePoco().MoveSpline = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x0004F61C File Offset: 0x0004D81C
		// (set) Token: 0x06001B6F RID: 7023 RVA: 0x0004F67D File Offset: 0x0004D87D
		[Nullable(2)]
		public virtual IMovementPerformConfig MovePerformConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._MovePerformConfigInited)
				{
					return this._MovePerformConfigCache;
				}
				this._MovePerformConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MovePerformConfigCache = IMovementPerformConfig.Create(this.FbInstance.MovePerformConfig);
				}
				else
				{
					IMovementVehicleFeature_SetValue pocoInterface = this.PocoInterface;
					this._MovePerformConfigCache = ((pocoInterface != null) ? pocoInterface.MovePerformConfig : null);
				}
				return this._MovePerformConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MovePerformConfig = value;
				this._MovePerformConfigInited = false;
			}
		}

		// Token: 0x040013C0 RID: 5056
		[Nullable(2)]
		protected new IMovementVehicleFeature FbInstance;

		// Token: 0x040013C1 RID: 5057
		[Nullable(2)]
		protected new IMovementVehicleFeature_SetValue PocoInterface;

		// Token: 0x040013C2 RID: 5058
		private IMovementPerformConfig _MovePerformConfigCache;

		// Token: 0x040013C3 RID: 5059
		private bool _MovePerformConfigInited;
	}
}
