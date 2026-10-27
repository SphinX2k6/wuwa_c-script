using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000674 RID: 1652
	[NullableContext(1)]
	[Nullable(0)]
	public class IRefreshSingle
	{
		// Token: 0x0600234E RID: 9038 RVA: 0x000607E0 File Offset: 0x0005E9E0
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

		// Token: 0x0600234F RID: 9039 RVA: 0x00060818 File Offset: 0x0005EA18
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

		// Token: 0x06002350 RID: 9040 RVA: 0x0006082B File Offset: 0x0005EA2B
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

		// Token: 0x06002351 RID: 9041 RVA: 0x0006083E File Offset: 0x0005EA3E
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

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x00060875 File Offset: 0x0005EA75
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x000608A0 File Offset: 0x0005EAA0
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

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x000608AE File Offset: 0x0005EAAE
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x000608D9 File Offset: 0x0005EAD9
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

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x000608E7 File Offset: 0x0005EAE7
		// (set) Token: 0x06002357 RID: 9047 RVA: 0x00060912 File Offset: 0x0005EB12
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

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x00060920 File Offset: 0x0005EB20
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x00060981 File Offset: 0x0005EB81
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

		// Token: 0x04001868 RID: 6248
		[Nullable(2)]
		protected IRefreshSingle FbInstance;

		// Token: 0x04001869 RID: 6249
		[Nullable(2)]
		protected IRefreshSingle_SetValue PocoInterface;

		// Token: 0x0400186A RID: 6250
		private ITempleGuid _TemplateGuidCache;

		// Token: 0x0400186B RID: 6251
		private bool _TemplateGuidInited;
	}
}
