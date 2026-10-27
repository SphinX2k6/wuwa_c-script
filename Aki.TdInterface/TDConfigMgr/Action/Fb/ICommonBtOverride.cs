using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A7D RID: 10877
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtOverride
	{
		// Token: 0x0600EF19 RID: 61209 RVA: 0x0022C67D File Offset: 0x0022A87D
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

		// Token: 0x17004BE1 RID: 19425
		// (get) Token: 0x0600EF1A RID: 61210 RVA: 0x0022C69C File Offset: 0x0022A89C
		public virtual int CommonBtId
		{
			get
			{
				return this.Instance.CommonBtId;
			}
		}

		// Token: 0x17004BE2 RID: 19426
		// (get) Token: 0x0600EF1B RID: 61211 RVA: 0x0022C6AC File Offset: 0x0022A8AC
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

		// Token: 0x17004BE3 RID: 19427
		// (get) Token: 0x0600EF1C RID: 61212 RVA: 0x0022C718 File Offset: 0x0022A918
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

		// Token: 0x0400838F RID: 33679
		private ICommonBtOverride Instance;

		// Token: 0x04008390 RID: 33680
		private List<ICommonBtPlaceholder> _OverridePlaceholdersCache;

		// Token: 0x04008391 RID: 33681
		private bool _OverridePlaceholdersInited;

		// Token: 0x04008392 RID: 33682
		private List<ICommonBtClientOverrideData> _ClientOverrideDataCache;

		// Token: 0x04008393 RID: 33683
		private bool _ClientOverrideDataInited;
	}
}
