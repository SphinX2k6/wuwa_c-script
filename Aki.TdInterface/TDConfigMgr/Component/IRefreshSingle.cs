using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000711 RID: 1809
	public class IRefreshSingle
	{
		// Token: 0x06002654 RID: 9812 RVA: 0x000674F4 File Offset: 0x000656F4
		private IRefreshSingle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshSingle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshSingle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshSingle_SetValue());
			}
			return result;
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x0006752C File Offset: 0x0006572C
		public static IRefreshSingle Create([Nullable(2)] IRefreshSingle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshSingle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x0006753F File Offset: 0x0006573F
		public static IRefreshSingle CreateFromSetValue([Nullable(2)] IRefreshSingle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshSingle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00067552 File Offset: 0x00065752
		public IRefreshSingle_SetValue ToSetValue()
		{
			return new IRefreshSingle_SetValue
			{
				RefreshInterval = this.RefreshInterval,
				MaxRefreshTimes = this.MaxRefreshTimes,
				DelayRefresh = this.DelayRefresh,
				TemplateGuid = this.TemplateGuid
			};
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x00067589 File Offset: 0x00065789
		// (set) Token: 0x06002659 RID: 9817 RVA: 0x000675B4 File Offset: 0x000657B4
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

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x000675C2 File Offset: 0x000657C2
		// (set) Token: 0x0600265B RID: 9819 RVA: 0x000675ED File Offset: 0x000657ED
		public virtual int MaxRefreshTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxRefreshTimes;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxRefreshTimes;
			}
			set
			{
				this.GetOrCreatePoco().MaxRefreshTimes = value;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x000675FB File Offset: 0x000657FB
		// (set) Token: 0x0600265D RID: 9821 RVA: 0x00067626 File Offset: 0x00065826
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

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x00067634 File Offset: 0x00065834
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x00067695 File Offset: 0x00065895
		public virtual ITempleGuid TemplateGuid
		{
			get
			{
				if (this._TemplateGuidInited)
				{
					return this._TemplateGuidCache;
				}
				this._TemplateGuidInited = true;
				if (this.FbInstance != null)
				{
					this._TemplateGuidCache = ITempleGuid.Create(this.FbInstance.TemplateGuid);
				}
				else
				{
					IRefreshSingle_SetValue pocoInterface = this.PocoInterface;
					this._TemplateGuidCache = ((pocoInterface != null) ? pocoInterface.TemplateGuid : null);
				}
				return this._TemplateGuidCache;
			}
			set
			{
				this.GetOrCreatePoco().TemplateGuid = value;
				this._TemplateGuidInited = false;
			}
		}

		// Token: 0x04001A5A RID: 6746
		[Nullable(2)]
		protected IRefreshSingle FbInstance;

		// Token: 0x04001A5B RID: 6747
		[Nullable(2)]
		protected IRefreshSingle_SetValue PocoInterface;

		// Token: 0x04001A5C RID: 6748
		private ITempleGuid _TemplateGuidCache;

		// Token: 0x04001A5D RID: 6749
		private bool _TemplateGuidInited;
	}
}
