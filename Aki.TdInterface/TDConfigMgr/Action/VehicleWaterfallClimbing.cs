using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024E8 RID: 9448
	public class VehicleWaterfallClimbing : ActionParams
	{
		// Token: 0x0600CD68 RID: 52584 RVA: 0x001D3B58 File Offset: 0x001D1D58
		private VehicleWaterfallClimbing_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VehicleWaterfallClimbing 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VehicleWaterfallClimbing_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VehicleWaterfallClimbing_SetValue());
			}
			return result;
		}

		// Token: 0x0600CD69 RID: 52585 RVA: 0x001D3B90 File Offset: 0x001D1D90
		public static VehicleWaterfallClimbing Create([Nullable(2)] VehicleWaterfallClimbing instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleWaterfallClimbing
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CD6A RID: 52586 RVA: 0x001D3BA3 File Offset: 0x001D1DA3
		public static VehicleWaterfallClimbing CreateFromSetValue([Nullable(2)] VehicleWaterfallClimbing_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VehicleWaterfallClimbing
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CD6B RID: 52587 RVA: 0x001D3BB6 File Offset: 0x001D1DB6
		public VehicleWaterfallClimbing_SetValue ToSetValue()
		{
			return new VehicleWaterfallClimbing_SetValue
			{
				SplineEntityId = this.SplineEntityId,
				ChangeGravity = this.ChangeGravity
			};
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x0600CD6C RID: 52588 RVA: 0x001D3BD5 File Offset: 0x001D1DD5
		// (set) Token: 0x0600CD6D RID: 52589 RVA: 0x001D3C00 File Offset: 0x001D1E00
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x0600CD6E RID: 52590 RVA: 0x001D3C10 File Offset: 0x001D1E10
		// (set) Token: 0x0600CD6F RID: 52591 RVA: 0x001D3C71 File Offset: 0x001D1E71
		[Nullable(2)]
		public virtual IVehicleWaterfallClimbGravityConfig ChangeGravity
		{
			[NullableContext(2)]
			get
			{
				if (this._ChangeGravityInited)
				{
					return this._ChangeGravityCache;
				}
				this._ChangeGravityInited = true;
				if (this.FbInstance != null)
				{
					this._ChangeGravityCache = IVehicleWaterfallClimbGravityConfig.Create(this.FbInstance.ChangeGravity);
				}
				else
				{
					VehicleWaterfallClimbing_SetValue pocoInterface = this.PocoInterface;
					this._ChangeGravityCache = ((pocoInterface != null) ? pocoInterface.ChangeGravity : null);
				}
				return this._ChangeGravityCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ChangeGravity = value;
				this._ChangeGravityInited = false;
			}
		}

		// Token: 0x040079A2 RID: 31138
		[Nullable(2)]
		protected new VehicleWaterfallClimbing FbInstance;

		// Token: 0x040079A3 RID: 31139
		[Nullable(2)]
		protected VehicleWaterfallClimbing_SetValue PocoInterface;

		// Token: 0x040079A4 RID: 31140
		private IVehicleWaterfallClimbGravityConfig _ChangeGravityCache;

		// Token: 0x040079A5 RID: 31141
		private bool _ChangeGravityInited;
	}
}
