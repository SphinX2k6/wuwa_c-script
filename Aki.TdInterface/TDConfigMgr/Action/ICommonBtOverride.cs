using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A85 RID: 6789
	public class ICommonBtOverride
	{
		// Token: 0x06009035 RID: 36917 RVA: 0x0015344C File Offset: 0x0015164C
		private ICommonBtOverride_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtOverride 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtOverride_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtOverride_SetValue());
			}
			return result;
		}

		// Token: 0x06009036 RID: 36918 RVA: 0x00153484 File Offset: 0x00151684
		public static ICommonBtOverride Create([Nullable(2)] ICommonBtOverride instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtOverride
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x00153497 File Offset: 0x00151697
		public static ICommonBtOverride CreateFromSetValue([Nullable(2)] ICommonBtOverride_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtOverride
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009038 RID: 36920 RVA: 0x001534AA File Offset: 0x001516AA
		public ICommonBtOverride_SetValue ToSetValue()
		{
			return new ICommonBtOverride_SetValue
			{
				CommonBtId = this.CommonBtId,
				OverridePlaceholders = this.OverridePlaceholders,
				ClientOverrideData = this.ClientOverrideData
			};
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x06009039 RID: 36921 RVA: 0x001534D5 File Offset: 0x001516D5
		// (set) Token: 0x0600903A RID: 36922 RVA: 0x00153500 File Offset: 0x00151700
		public virtual int CommonBtId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CommonBtId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CommonBtId;
			}
			set
			{
				this.GetOrCreatePoco().CommonBtId = value;
			}
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x0600903B RID: 36923 RVA: 0x00153510 File Offset: 0x00151710
		// (set) Token: 0x0600903C RID: 36924 RVA: 0x001535A3 File Offset: 0x001517A3
		public virtual List<ICommonBtPlaceholder> OverridePlaceholders
		{
			get
			{
				if (this._OverridePlaceholdersInited)
				{
					return this._OverridePlaceholdersCache;
				}
				this._OverridePlaceholdersInited = true;
				if (this.FbInstance != null)
				{
					List<ICommonBtPlaceholder> overridePlaceholders = this.FbInstance.OverridePlaceholders;
					if (overridePlaceholders != null)
					{
						this._OverridePlaceholdersCache = new List<ICommonBtPlaceholder>(overridePlaceholders.Count);
						for (int i = 0; i < overridePlaceholders.Count; i++)
						{
							this._OverridePlaceholdersCache.Add(ICommonBtPlaceholder.Create(overridePlaceholders[i]));
						}
					}
				}
				else
				{
					ICommonBtOverride_SetValue pocoInterface = this.PocoInterface;
					this._OverridePlaceholdersCache = ((pocoInterface != null) ? pocoInterface.OverridePlaceholders : null);
				}
				return this._OverridePlaceholdersCache;
			}
			set
			{
				this.GetOrCreatePoco().OverridePlaceholders = value;
				this._OverridePlaceholdersInited = false;
			}
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x0600903D RID: 36925 RVA: 0x001535B8 File Offset: 0x001517B8
		// (set) Token: 0x0600903E RID: 36926 RVA: 0x0015364B File Offset: 0x0015184B
		public virtual List<ICommonBtClientOverrideData> ClientOverrideData
		{
			get
			{
				if (this._ClientOverrideDataInited)
				{
					return this._ClientOverrideDataCache;
				}
				this._ClientOverrideDataInited = true;
				if (this.FbInstance != null)
				{
					List<ICommonBtClientOverrideData> clientOverrideData = this.FbInstance.ClientOverrideData;
					if (clientOverrideData != null)
					{
						this._ClientOverrideDataCache = new List<ICommonBtClientOverrideData>(clientOverrideData.Count);
						for (int i = 0; i < clientOverrideData.Count; i++)
						{
							this._ClientOverrideDataCache.Add(ICommonBtClientOverrideData.Create(clientOverrideData[i]));
						}
					}
				}
				else
				{
					ICommonBtOverride_SetValue pocoInterface = this.PocoInterface;
					this._ClientOverrideDataCache = ((pocoInterface != null) ? pocoInterface.ClientOverrideData : null);
				}
				return this._ClientOverrideDataCache;
			}
			set
			{
				this.GetOrCreatePoco().ClientOverrideData = value;
				this._ClientOverrideDataInited = false;
			}
		}

		// Token: 0x04005A3C RID: 23100
		[Nullable(2)]
		protected ICommonBtOverride FbInstance;

		// Token: 0x04005A3D RID: 23101
		[Nullable(2)]
		protected ICommonBtOverride_SetValue PocoInterface;

		// Token: 0x04005A3E RID: 23102
		private List<ICommonBtPlaceholder> _OverridePlaceholdersCache;

		// Token: 0x04005A3F RID: 23103
		private bool _OverridePlaceholdersInited;

		// Token: 0x04005A40 RID: 23104
		private List<ICommonBtClientOverrideData> _ClientOverrideDataCache;

		// Token: 0x04005A41 RID: 23105
		private bool _ClientOverrideDataInited;
	}
}
