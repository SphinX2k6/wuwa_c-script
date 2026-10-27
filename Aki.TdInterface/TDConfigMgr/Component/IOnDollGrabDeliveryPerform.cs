using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A8 RID: 1448
	[NullableContext(2)]
	[Nullable(0)]
	public class IOnDollGrabDeliveryPerform
	{
		// Token: 0x06001E90 RID: 7824 RVA: 0x000567CC File Offset: 0x000549CC
		[NullableContext(1)]
		private IOnDollGrabDeliveryPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnDollGrabDeliveryPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnDollGrabDeliveryPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnDollGrabDeliveryPerform_SetValue());
			}
			return result;
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00056804 File Offset: 0x00054A04
		[NullableContext(1)]
		public static IOnDollGrabDeliveryPerform Create([Nullable(2)] IOnDollGrabDeliveryPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnDollGrabDeliveryPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00056817 File Offset: 0x00054A17
		[NullableContext(1)]
		public static IOnDollGrabDeliveryPerform CreateFromSetValue([Nullable(2)] IOnDollGrabDeliveryPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnDollGrabDeliveryPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0005682A File Offset: 0x00054A2A
		[NullableContext(1)]
		public IOnDollGrabDeliveryPerform_SetValue ToSetValue()
		{
			return new IOnDollGrabDeliveryPerform_SetValue
			{
				EventMontage = this.EventMontage,
				StandByMontage = this.StandByMontage,
				Flow = this.Flow,
				PerformDuration = this.PerformDuration
			};
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x00056861 File Offset: 0x00054A61
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x00056888 File Offset: 0x00054A88
		public virtual string EventMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventMontage;
				}
				IOnDollGrabDeliveryPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EventMontage;
			}
			set
			{
				this.GetOrCreatePoco().EventMontage = value;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x00056896 File Offset: 0x00054A96
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x000568BD File Offset: 0x00054ABD
		public virtual string StandByMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StandByMontage;
				}
				IOnDollGrabDeliveryPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StandByMontage;
			}
			set
			{
				this.GetOrCreatePoco().StandByMontage = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x000568CC File Offset: 0x00054ACC
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x0005692D File Offset: 0x00054B2D
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = PlayFlow.Create(this.FbInstance.Flow);
				}
				else
				{
					IOnDollGrabDeliveryPerform_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x00056944 File Offset: 0x00054B44
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x0005697E File Offset: 0x00054B7E
		public virtual float? PerformDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformDuration;
				}
				IOnDollGrabDeliveryPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformDuration;
			}
			set
			{
				this.GetOrCreatePoco().PerformDuration = value;
			}
		}

		// Token: 0x040015C5 RID: 5573
		protected IOnDollGrabDeliveryPerform FbInstance;

		// Token: 0x040015C6 RID: 5574
		protected IOnDollGrabDeliveryPerform_SetValue PocoInterface;

		// Token: 0x040015C7 RID: 5575
		[Nullable(1)]
		private PlayFlow _FlowCache;

		// Token: 0x040015C8 RID: 5576
		private bool _FlowInited;
	}
}
