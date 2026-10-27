using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A5D RID: 2653
	[NullableContext(1)]
	[Nullable(0)]
	public class IRefreshSingle
	{
		// Token: 0x06003D16 RID: 15638 RVA: 0x0009D10D File Offset: 0x0009B30D
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

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x0009D12C File Offset: 0x0009B32C
		public virtual int RefreshInterval
		{
			get
			{
				return this.Instance.RefreshInterval;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06003D18 RID: 15640 RVA: 0x0009D139 File Offset: 0x0009B339
		public virtual int MaxRefreshTimes
		{
			get
			{
				return this.Instance.MaxRefreshTimes;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06003D19 RID: 15641 RVA: 0x0009D146 File Offset: 0x0009B346
		public virtual bool DelayRefresh
		{
			get
			{
				return this.Instance.DelayRefresh;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x0009D153 File Offset: 0x0009B353
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

		// Token: 0x04002208 RID: 8712
		private IRefreshSingle Instance;

		// Token: 0x04002209 RID: 8713
		[Nullable(2)]
		private ITempleGuid _TemplateGuidCache;

		// Token: 0x0400220A RID: 8714
		private bool _TemplateGuidInited;
	}
}
