using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000430 RID: 1072
	[NullableContext(1)]
	[Nullable(0)]
	public class IHoldCfg
	{
		// Token: 0x0600159B RID: 5531 RVA: 0x0004383C File Offset: 0x00041A3C
		private IHoldCfg_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHoldCfg 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHoldCfg_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHoldCfg_SetValue());
			}
			return result;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00043874 File Offset: 0x00041A74
		public static IHoldCfg Create([Nullable(2)] IHoldCfg instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHoldCfg
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00043887 File Offset: 0x00041A87
		public static IHoldCfg CreateFromSetValue([Nullable(2)] IHoldCfg_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHoldCfg
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0004389A File Offset: 0x00041A9A
		public IHoldCfg_SetValue ToSetValue()
		{
			return new IHoldCfg_SetValue
			{
				TrackTarget = this.TrackTarget
			};
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x000438B0 File Offset: 0x00041AB0
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x00043911 File Offset: 0x00041B11
		[Nullable(2)]
		public virtual IHoldingTrackTarget TrackTarget
		{
			[NullableContext(2)]
			get
			{
				if (this._TrackTargetInited)
				{
					return this._TrackTargetCache;
				}
				this._TrackTargetInited = true;
				if (this.FbInstance != null)
				{
					this._TrackTargetCache = IHoldingTrackTarget.Create(this.FbInstance.TrackTarget);
				}
				else
				{
					IHoldCfg_SetValue pocoInterface = this.PocoInterface;
					this._TrackTargetCache = ((pocoInterface != null) ? pocoInterface.TrackTarget : null);
				}
				return this._TrackTargetCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TrackTarget = value;
				this._TrackTargetInited = false;
			}
		}

		// Token: 0x040010A8 RID: 4264
		[Nullable(2)]
		protected IHoldCfg FbInstance;

		// Token: 0x040010A9 RID: 4265
		[Nullable(2)]
		protected IHoldCfg_SetValue PocoInterface;

		// Token: 0x040010AA RID: 4266
		private IHoldingTrackTarget _TrackTargetCache;

		// Token: 0x040010AB RID: 4267
		private bool _TrackTargetInited;
	}
}
