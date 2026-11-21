using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B26 RID: 2854
	public class IRefreshSingle
	{
		// Token: 0x06004136 RID: 16694 RVA: 0x000A6585 File Offset: 0x000A4785
		public static IRefreshSingle Create(IRefreshSingle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshSingle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06004137 RID: 16695 RVA: 0x000A65A4 File Offset: 0x000A47A4
		public virtual int RefreshInterval
		{
			get
			{
				return this.Instance.RefreshInterval;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06004138 RID: 16696 RVA: 0x000A65B1 File Offset: 0x000A47B1
		public virtual int MaxRefreshTimes
		{
			get
			{
				return this.Instance.MaxRefreshTimes;
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x000A65BE File Offset: 0x000A47BE
		public virtual bool DelayRefresh
		{
			get
			{
				return this.Instance.DelayRefresh;
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x000A65CB File Offset: 0x000A47CB
		public virtual ITempleGuid TemplateGuid
		{
			get
			{
				if (this._TemplateGuidInited)
				{
					return this._TemplateGuidCache;
				}
				this._TemplateGuidInited = true;
				this._TemplateGuidCache = ITempleGuid.Create(this.Instance.TemplateGuid);
				return this._TemplateGuidCache;
			}
		}

		// Token: 0x0400241F RID: 9247
		private IRefreshSingle Instance;

		// Token: 0x04002420 RID: 9248
		[Nullable(2)]
		private ITempleGuid _TemplateGuidCache;

		// Token: 0x04002421 RID: 9249
		private bool _TemplateGuidInited;
	}
}
