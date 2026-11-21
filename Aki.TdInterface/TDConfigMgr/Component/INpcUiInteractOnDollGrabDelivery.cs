using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F1 RID: 1521
	public class INpcUiInteractOnDollGrabDelivery : INpcUiInteractType
	{
		// Token: 0x06001F3A RID: 7994 RVA: 0x00057F7C File Offset: 0x0005617C
		private INpcUiInteractOnDollGrabDelivery_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnDollGrabDelivery 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnDollGrabDelivery_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnDollGrabDelivery_SetValue());
			}
			return result;
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00057FB4 File Offset: 0x000561B4
		public static INpcUiInteractOnDollGrabDelivery Create([Nullable(2)] INpcUiInteractOnDollGrabDelivery instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnDollGrabDelivery
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00057FC7 File Offset: 0x000561C7
		public static INpcUiInteractOnDollGrabDelivery CreateFromSetValue([Nullable(2)] INpcUiInteractOnDollGrabDelivery_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnDollGrabDelivery
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00057FDC File Offset: 0x000561DC
		public new INpcUiInteractOnDollGrabDelivery_SetValue ToSetValue()
		{
			return new INpcUiInteractOnDollGrabDelivery_SetValue
			{
				Type = this.Type,
				OnFirstAchievementPerform = this.OnFirstAchievementPerform,
				OnSubsequentAchievementPerform = this.OnSubsequentAchievementPerform,
				OnNeverAchievementPerform = this.OnNeverAchievementPerform,
				OnAlreadyAchievementPerform = this.OnAlreadyAchievementPerform
			};
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0005802A File Offset: 0x0005622A
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x00058055 File Offset: 0x00056255
		public override ENpcUiInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00058064 File Offset: 0x00056264
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x000580C5 File Offset: 0x000562C5
		public virtual IOnDollGrabDeliveryPerform OnFirstAchievementPerform
		{
			get
			{
				if (this._OnFirstAchievementPerformInited)
				{
					return this._OnFirstAchievementPerformCache;
				}
				this._OnFirstAchievementPerformInited = true;
				if (this.FbInstance != null)
				{
					this._OnFirstAchievementPerformCache = IOnDollGrabDeliveryPerform.Create(this.FbInstance.OnFirstAchievementPerform);
				}
				else
				{
					INpcUiInteractOnDollGrabDelivery_SetValue pocoInterface = this.PocoInterface;
					this._OnFirstAchievementPerformCache = ((pocoInterface != null) ? pocoInterface.OnFirstAchievementPerform : null);
				}
				return this._OnFirstAchievementPerformCache;
			}
			set
			{
				this.GetOrCreatePoco().OnFirstAchievementPerform = value;
				this._OnFirstAchievementPerformInited = false;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x000580DC File Offset: 0x000562DC
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x0005813D File Offset: 0x0005633D
		public virtual IOnDollGrabDeliveryPerform OnSubsequentAchievementPerform
		{
			get
			{
				if (this._OnSubsequentAchievementPerformInited)
				{
					return this._OnSubsequentAchievementPerformCache;
				}
				this._OnSubsequentAchievementPerformInited = true;
				if (this.FbInstance != null)
				{
					this._OnSubsequentAchievementPerformCache = IOnDollGrabDeliveryPerform.Create(this.FbInstance.OnSubsequentAchievementPerform);
				}
				else
				{
					INpcUiInteractOnDollGrabDelivery_SetValue pocoInterface = this.PocoInterface;
					this._OnSubsequentAchievementPerformCache = ((pocoInterface != null) ? pocoInterface.OnSubsequentAchievementPerform : null);
				}
				return this._OnSubsequentAchievementPerformCache;
			}
			set
			{
				this.GetOrCreatePoco().OnSubsequentAchievementPerform = value;
				this._OnSubsequentAchievementPerformInited = false;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00058154 File Offset: 0x00056354
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x000581B5 File Offset: 0x000563B5
		public virtual IOnDollGrabDeliveryPerform OnNeverAchievementPerform
		{
			get
			{
				if (this._OnNeverAchievementPerformInited)
				{
					return this._OnNeverAchievementPerformCache;
				}
				this._OnNeverAchievementPerformInited = true;
				if (this.FbInstance != null)
				{
					this._OnNeverAchievementPerformCache = IOnDollGrabDeliveryPerform.Create(this.FbInstance.OnNeverAchievementPerform);
				}
				else
				{
					INpcUiInteractOnDollGrabDelivery_SetValue pocoInterface = this.PocoInterface;
					this._OnNeverAchievementPerformCache = ((pocoInterface != null) ? pocoInterface.OnNeverAchievementPerform : null);
				}
				return this._OnNeverAchievementPerformCache;
			}
			set
			{
				this.GetOrCreatePoco().OnNeverAchievementPerform = value;
				this._OnNeverAchievementPerformInited = false;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x000581CC File Offset: 0x000563CC
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x0005822D File Offset: 0x0005642D
		public virtual IOnDollGrabDeliveryPerform OnAlreadyAchievementPerform
		{
			get
			{
				if (this._OnAlreadyAchievementPerformInited)
				{
					return this._OnAlreadyAchievementPerformCache;
				}
				this._OnAlreadyAchievementPerformInited = true;
				if (this.FbInstance != null)
				{
					this._OnAlreadyAchievementPerformCache = IOnDollGrabDeliveryPerform.Create(this.FbInstance.OnAlreadyAchievementPerform);
				}
				else
				{
					INpcUiInteractOnDollGrabDelivery_SetValue pocoInterface = this.PocoInterface;
					this._OnAlreadyAchievementPerformCache = ((pocoInterface != null) ? pocoInterface.OnAlreadyAchievementPerform : null);
				}
				return this._OnAlreadyAchievementPerformCache;
			}
			set
			{
				this.GetOrCreatePoco().OnAlreadyAchievementPerform = value;
				this._OnAlreadyAchievementPerformInited = false;
			}
		}

		// Token: 0x04001631 RID: 5681
		[Nullable(2)]
		protected new INpcUiInteractOnDollGrabDelivery FbInstance;

		// Token: 0x04001632 RID: 5682
		[Nullable(2)]
		protected new INpcUiInteractOnDollGrabDelivery_SetValue PocoInterface;

		// Token: 0x04001633 RID: 5683
		private IOnDollGrabDeliveryPerform _OnFirstAchievementPerformCache;

		// Token: 0x04001634 RID: 5684
		private bool _OnFirstAchievementPerformInited;

		// Token: 0x04001635 RID: 5685
		private IOnDollGrabDeliveryPerform _OnSubsequentAchievementPerformCache;

		// Token: 0x04001636 RID: 5686
		private bool _OnSubsequentAchievementPerformInited;

		// Token: 0x04001637 RID: 5687
		private IOnDollGrabDeliveryPerform _OnNeverAchievementPerformCache;

		// Token: 0x04001638 RID: 5688
		private bool _OnNeverAchievementPerformInited;

		// Token: 0x04001639 RID: 5689
		private IOnDollGrabDeliveryPerform _OnAlreadyAchievementPerformCache;

		// Token: 0x0400163A RID: 5690
		private bool _OnAlreadyAchievementPerformInited;
	}
}
