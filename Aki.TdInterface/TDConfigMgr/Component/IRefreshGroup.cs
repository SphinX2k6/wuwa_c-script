using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000709 RID: 1801
	public class IRefreshGroup : IComponentBase
	{
		// Token: 0x0600262A RID: 9770 RVA: 0x00067054 File Offset: 0x00065254
		private IRefreshGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshGroup_SetValue());
			}
			return result;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x0006708C File Offset: 0x0006528C
		public static IRefreshGroup Create([Nullable(2)] IRefreshGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x0006709F File Offset: 0x0006529F
		public static IRefreshGroup CreateFromSetValue([Nullable(2)] IRefreshGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x000670B4 File Offset: 0x000652B4
		public new IRefreshGroup_SetValue ToSetValue()
		{
			return new IRefreshGroup_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				RefreshInterval = this.RefreshInterval,
				DelayRefresh = this.DelayRefresh,
				EntityIdList = this.EntityIdList,
				IsUesCylinder = this.IsUesCylinder
			};
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x00067110 File Offset: 0x00065310
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x0006714A File Offset: 0x0006534A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				IRefreshGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x00067158 File Offset: 0x00065358
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x00067182 File Offset: 0x00065382
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x00067190 File Offset: 0x00065390
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x000671BB File Offset: 0x000653BB
		public virtual int RefreshInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefreshInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RefreshInterval;
			}
			set
			{
				this.GetOrCreatePoco().RefreshInterval = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x000671C9 File Offset: 0x000653C9
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x000671F4 File Offset: 0x000653F4
		public virtual bool DelayRefresh
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayRefresh;
				}
				return this.PocoInterface != null && this.PocoInterface.DelayRefresh;
			}
			set
			{
				this.GetOrCreatePoco().DelayRefresh = value;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x00067202 File Offset: 0x00065402
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x00067229 File Offset: 0x00065429
		public virtual List<int> EntityIdList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIdList;
				}
				IRefreshGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIdList;
			}
			set
			{
				this.GetOrCreatePoco().EntityIdList = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x00067238 File Offset: 0x00065438
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x00067299 File Offset: 0x00065499
		public virtual ICylinder IsUesCylinder
		{
			get
			{
				if (this._IsUesCylinderInited)
				{
					return this._IsUesCylinderCache;
				}
				this._IsUesCylinderInited = true;
				if (this.FbInstance != null)
				{
					this._IsUesCylinderCache = ICylinder.Create(this.FbInstance.IsUesCylinder);
				}
				else
				{
					IRefreshGroup_SetValue pocoInterface = this.PocoInterface;
					this._IsUesCylinderCache = ((pocoInterface != null) ? pocoInterface.IsUesCylinder : null);
				}
				return this._IsUesCylinderCache;
			}
			set
			{
				this.GetOrCreatePoco().IsUesCylinder = value;
				this._IsUesCylinderInited = false;
			}
		}

		// Token: 0x04001A47 RID: 6727
		[Nullable(2)]
		protected new IRefreshGroup FbInstance;

		// Token: 0x04001A48 RID: 6728
		[Nullable(2)]
		protected new IRefreshGroup_SetValue PocoInterface;

		// Token: 0x04001A49 RID: 6729
		private ICylinder _IsUesCylinderCache;

		// Token: 0x04001A4A RID: 6730
		private bool _IsUesCylinderInited;
	}
}
