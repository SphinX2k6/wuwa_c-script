using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000588 RID: 1416
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnDollGrabDelivery : INpcUiInteractType
	{
		// Token: 0x06001D34 RID: 7476 RVA: 0x000530C0 File Offset: 0x000512C0
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

		// Token: 0x06001D35 RID: 7477 RVA: 0x000530F8 File Offset: 0x000512F8
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

		// Token: 0x06001D36 RID: 7478 RVA: 0x0005310B File Offset: 0x0005130B
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

		// Token: 0x06001D37 RID: 7479 RVA: 0x00053120 File Offset: 0x00051320
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

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x0005316E File Offset: 0x0005136E
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x00053199 File Offset: 0x00051399
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

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x000531A8 File Offset: 0x000513A8
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00053209 File Offset: 0x00051409
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

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00053220 File Offset: 0x00051420
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00053281 File Offset: 0x00051481
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

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00053298 File Offset: 0x00051498
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x000532F9 File Offset: 0x000514F9
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

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00053310 File Offset: 0x00051510
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x00053371 File Offset: 0x00051571
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

		// Token: 0x040014C3 RID: 5315
		[Nullable(2)]
		protected new INpcUiInteractOnDollGrabDelivery FbInstance;

		// Token: 0x040014C4 RID: 5316
		[Nullable(2)]
		protected new INpcUiInteractOnDollGrabDelivery_SetValue PocoInterface;

		// Token: 0x040014C5 RID: 5317
		private IOnDollGrabDeliveryPerform _OnFirstAchievementPerformCache;

		// Token: 0x040014C6 RID: 5318
		private bool _OnFirstAchievementPerformInited;

		// Token: 0x040014C7 RID: 5319
		private IOnDollGrabDeliveryPerform _OnSubsequentAchievementPerformCache;

		// Token: 0x040014C8 RID: 5320
		private bool _OnSubsequentAchievementPerformInited;

		// Token: 0x040014C9 RID: 5321
		private IOnDollGrabDeliveryPerform _OnNeverAchievementPerformCache;

		// Token: 0x040014CA RID: 5322
		private bool _OnNeverAchievementPerformInited;

		// Token: 0x040014CB RID: 5323
		private IOnDollGrabDeliveryPerform _OnAlreadyAchievementPerformCache;

		// Token: 0x040014CC RID: 5324
		private bool _OnAlreadyAchievementPerformInited;
	}
}
