using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A3 RID: 1443
	public class IMovementVehicleFeature : IVehicleFeature
	{
		// Token: 0x06001D62 RID: 7522 RVA: 0x000542CC File Offset: 0x000524CC
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

		// Token: 0x06001D63 RID: 7523 RVA: 0x00054304 File Offset: 0x00052504
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

		// Token: 0x06001D64 RID: 7524 RVA: 0x00054317 File Offset: 0x00052517
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

		// Token: 0x06001D65 RID: 7525 RVA: 0x0005432A File Offset: 0x0005252A
		public new IMovementVehicleFeature_SetValue ToSetValue()
		{
			return new IMovementVehicleFeature_SetValue
			{
				Type = this.Type,
				MoveSpline = this.MoveSpline,
				MovePerformConfig = this.MovePerformConfig
			};
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00054355 File Offset: 0x00052555
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x00054380 File Offset: 0x00052580
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

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00054390 File Offset: 0x00052590
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x000543CA File Offset: 0x000525CA
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

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x000543D8 File Offset: 0x000525D8
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x00054439 File Offset: 0x00052639
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

		// Token: 0x0400152A RID: 5418
		[Nullable(2)]
		protected new IMovementVehicleFeature FbInstance;

		// Token: 0x0400152B RID: 5419
		[Nullable(2)]
		protected new IMovementVehicleFeature_SetValue PocoInterface;

		// Token: 0x0400152C RID: 5420
		private IMovementPerformConfig _MovePerformConfigCache;

		// Token: 0x0400152D RID: 5421
		private bool _MovePerformConfigInited;
	}
}
