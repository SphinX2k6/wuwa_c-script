using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000489 RID: 1161
	public class IHoldCfg
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x00047584 File Offset: 0x00045784
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

		// Token: 0x06001736 RID: 5942 RVA: 0x000475BC File Offset: 0x000457BC
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

		// Token: 0x06001737 RID: 5943 RVA: 0x000475CF File Offset: 0x000457CF
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

		// Token: 0x06001738 RID: 5944 RVA: 0x000475E2 File Offset: 0x000457E2
		public IHoldCfg_SetValue ToSetValue()
		{
			return new IHoldCfg_SetValue
			{
				TrackTarget = this.TrackTarget
			};
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x000475F8 File Offset: 0x000457F8
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x00047659 File Offset: 0x00045859
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

		// Token: 0x040011CA RID: 4554
		[Nullable(2)]
		protected IHoldCfg FbInstance;

		// Token: 0x040011CB RID: 4555
		[Nullable(2)]
		protected IHoldCfg_SetValue PocoInterface;

		// Token: 0x040011CC RID: 4556
		private IHoldingTrackTarget _TrackTargetCache;

		// Token: 0x040011CD RID: 4557
		private bool _TrackTargetInited;
	}
}
