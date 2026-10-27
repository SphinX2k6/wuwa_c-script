using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200066C RID: 1644
	[NullableContext(1)]
	[Nullable(0)]
	public class IRefreshGroup : IComponentBase
	{
		// Token: 0x06002324 RID: 8996 RVA: 0x00060340 File Offset: 0x0005E540
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

		// Token: 0x06002325 RID: 8997 RVA: 0x00060378 File Offset: 0x0005E578
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

		// Token: 0x06002326 RID: 8998 RVA: 0x0006038B File Offset: 0x0005E58B
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

		// Token: 0x06002327 RID: 8999 RVA: 0x000603A0 File Offset: 0x0005E5A0
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

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x000603FC File Offset: 0x0005E5FC
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x00060436 File Offset: 0x0005E636
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

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x00060444 File Offset: 0x0005E644
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x0006046E File Offset: 0x0005E66E
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

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x0006047C File Offset: 0x0005E67C
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x000604A7 File Offset: 0x0005E6A7
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

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x000604B5 File Offset: 0x0005E6B5
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x000604E0 File Offset: 0x0005E6E0
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

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000604EE File Offset: 0x0005E6EE
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x00060515 File Offset: 0x0005E715
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

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x00060524 File Offset: 0x0005E724
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x00060585 File Offset: 0x0005E785
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

		// Token: 0x04001855 RID: 6229
		[Nullable(2)]
		protected new IRefreshGroup FbInstance;

		// Token: 0x04001856 RID: 6230
		[Nullable(2)]
		protected new IRefreshGroup_SetValue PocoInterface;

		// Token: 0x04001857 RID: 6231
		private ICylinder _IsUesCylinderCache;

		// Token: 0x04001858 RID: 6232
		private bool _IsUesCylinderInited;
	}
}
