using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200227B RID: 8827
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleWaterfallClimbing : ActionParams
	{
		// Token: 0x0600C1A2 RID: 49570 RVA: 0x001BC3D4 File Offset: 0x001BA5D4
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

		// Token: 0x0600C1A3 RID: 49571 RVA: 0x001BC40C File Offset: 0x001BA60C
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

		// Token: 0x0600C1A4 RID: 49572 RVA: 0x001BC41F File Offset: 0x001BA61F
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

		// Token: 0x0600C1A5 RID: 49573 RVA: 0x001BC432 File Offset: 0x001BA632
		public VehicleWaterfallClimbing_SetValue ToSetValue()
		{
			return new VehicleWaterfallClimbing_SetValue
			{
				SplineEntityId = this.SplineEntityId,
				ChangeGravity = this.ChangeGravity
			};
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x0600C1A6 RID: 49574 RVA: 0x001BC451 File Offset: 0x001BA651
		// (set) Token: 0x0600C1A7 RID: 49575 RVA: 0x001BC47C File Offset: 0x001BA67C
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

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x0600C1A8 RID: 49576 RVA: 0x001BC48C File Offset: 0x001BA68C
		// (set) Token: 0x0600C1A9 RID: 49577 RVA: 0x001BC4ED File Offset: 0x001BA6ED
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

		// Token: 0x04007355 RID: 29525
		[Nullable(2)]
		protected new VehicleWaterfallClimbing FbInstance;

		// Token: 0x04007356 RID: 29526
		[Nullable(2)]
		protected VehicleWaterfallClimbing_SetValue PocoInterface;

		// Token: 0x04007357 RID: 29527
		private IVehicleWaterfallClimbGravityConfig _ChangeGravityCache;

		// Token: 0x04007358 RID: 29528
		private bool _ChangeGravityInited;
	}
}
