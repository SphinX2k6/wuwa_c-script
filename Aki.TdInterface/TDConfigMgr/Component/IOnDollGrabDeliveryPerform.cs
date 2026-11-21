using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000611 RID: 1553
	[NullableContext(2)]
	[Nullable(0)]
	public class IOnDollGrabDeliveryPerform
	{
		// Token: 0x06002096 RID: 8342 RVA: 0x0005B688 File Offset: 0x00059888
		[NullableContext(0)]
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

		// Token: 0x06002097 RID: 8343 RVA: 0x0005B6C0 File Offset: 0x000598C0
		[NullableContext(0)]
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

		// Token: 0x06002098 RID: 8344 RVA: 0x0005B6D3 File Offset: 0x000598D3
		[NullableContext(0)]
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

		// Token: 0x06002099 RID: 8345 RVA: 0x0005B6E6 File Offset: 0x000598E6
		[NullableContext(0)]
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

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600209A RID: 8346 RVA: 0x0005B71D File Offset: 0x0005991D
		// (set) Token: 0x0600209B RID: 8347 RVA: 0x0005B744 File Offset: 0x00059944
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

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x0005B752 File Offset: 0x00059952
		// (set) Token: 0x0600209D RID: 8349 RVA: 0x0005B779 File Offset: 0x00059979
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

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x0005B788 File Offset: 0x00059988
		// (set) Token: 0x0600209F RID: 8351 RVA: 0x0005B7E9 File Offset: 0x000599E9
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

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0005B800 File Offset: 0x00059A00
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x0005B83A File Offset: 0x00059A3A
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

		// Token: 0x04001733 RID: 5939
		protected IOnDollGrabDeliveryPerform FbInstance;

		// Token: 0x04001734 RID: 5940
		protected IOnDollGrabDeliveryPerform_SetValue PocoInterface;

		// Token: 0x04001735 RID: 5941
		[Nullable(0)]
		private PlayFlow _FlowCache;

		// Token: 0x04001736 RID: 5942
		private bool _FlowInited;
	}
}
