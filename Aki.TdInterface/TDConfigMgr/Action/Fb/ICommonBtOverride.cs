using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D71 RID: 11633
	public class ICommonBtOverride
	{
		// Token: 0x0600FDCF RID: 64975 RVA: 0x0024A389 File Offset: 0x00248589
		public static ICommonBtOverride Create(ICommonBtOverride? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtOverride
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F9B RID: 20379
		// (get) Token: 0x0600FDD0 RID: 64976 RVA: 0x0024A3A8 File Offset: 0x002485A8
		public virtual int CommonBtId
		{
			get
			{
				return this.Instance.CommonBtId;
			}
		}

		// Token: 0x17004F9C RID: 20380
		// (get) Token: 0x0600FDD1 RID: 64977 RVA: 0x0024A3B8 File Offset: 0x002485B8
		public virtual List<ICommonBtPlaceholder> OverridePlaceholders
		{
			get
			{
				if (this._OverridePlaceholdersInited)
				{
					return this._OverridePlaceholdersCache;
				}
				this._OverridePlaceholdersInited = true;
				int overridePlaceholdersLength = this.Instance.OverridePlaceholdersLength;
				this._OverridePlaceholdersCache = new List<ICommonBtPlaceholder>(overridePlaceholdersLength);
				for (int i = 0; i < overridePlaceholdersLength; i++)
				{
					this._OverridePlaceholdersCache.Add(ICommonBtPlaceholder.Create(this.Instance.OverridePlaceholders(i)));
				}
				return this._OverridePlaceholdersCache;
			}
		}

		// Token: 0x17004F9D RID: 20381
		// (get) Token: 0x0600FDD2 RID: 64978 RVA: 0x0024A424 File Offset: 0x00248624
		public virtual List<ICommonBtClientOverrideData> ClientOverrideData
		{
			get
			{
				if (this._ClientOverrideDataInited)
				{
					return this._ClientOverrideDataCache;
				}
				this._ClientOverrideDataInited = true;
				int clientOverrideDataLength = this.Instance.ClientOverrideDataLength;
				this._ClientOverrideDataCache = new List<ICommonBtClientOverrideData>(clientOverrideDataLength);
				for (int i = 0; i < clientOverrideDataLength; i++)
				{
					this._ClientOverrideDataCache.Add(ICommonBtClientOverrideData.Create(this.Instance.ClientOverrideData(i)));
				}
				return this._ClientOverrideDataCache;
			}
		}

		// Token: 0x04008A93 RID: 35475
		private ICommonBtOverride Instance;

		// Token: 0x04008A94 RID: 35476
		private List<ICommonBtPlaceholder> _OverridePlaceholdersCache;

		// Token: 0x04008A95 RID: 35477
		private bool _OverridePlaceholdersInited;

		// Token: 0x04008A96 RID: 35478
		private List<ICommonBtClientOverrideData> _ClientOverrideDataCache;

		// Token: 0x04008A97 RID: 35479
		private bool _ClientOverrideDataInited;
	}
}
