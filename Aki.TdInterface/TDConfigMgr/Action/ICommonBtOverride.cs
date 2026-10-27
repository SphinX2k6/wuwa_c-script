using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018FE RID: 6398
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtOverride
	{
		// Token: 0x06008917 RID: 35095 RVA: 0x00143CC4 File Offset: 0x00141EC4
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

		// Token: 0x06008918 RID: 35096 RVA: 0x00143CFC File Offset: 0x00141EFC
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

		// Token: 0x06008919 RID: 35097 RVA: 0x00143D0F File Offset: 0x00141F0F
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

		// Token: 0x0600891A RID: 35098 RVA: 0x00143D22 File Offset: 0x00141F22
		public ICommonBtOverride_SetValue ToSetValue()
		{
			return new ICommonBtOverride_SetValue
			{
				CommonBtId = this.CommonBtId,
				OverridePlaceholders = this.OverridePlaceholders,
				ClientOverrideData = this.ClientOverrideData
			};
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x0600891B RID: 35099 RVA: 0x00143D4D File Offset: 0x00141F4D
		// (set) Token: 0x0600891C RID: 35100 RVA: 0x00143D78 File Offset: 0x00141F78
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

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x0600891D RID: 35101 RVA: 0x00143D88 File Offset: 0x00141F88
		// (set) Token: 0x0600891E RID: 35102 RVA: 0x00143E1B File Offset: 0x0014201B
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

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x0600891F RID: 35103 RVA: 0x00143E30 File Offset: 0x00142030
		// (set) Token: 0x06008920 RID: 35104 RVA: 0x00143EC3 File Offset: 0x001420C3
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

		// Token: 0x040055F2 RID: 22002
		[Nullable(2)]
		protected ICommonBtOverride FbInstance;

		// Token: 0x040055F3 RID: 22003
		[Nullable(2)]
		protected ICommonBtOverride_SetValue PocoInterface;

		// Token: 0x040055F4 RID: 22004
		private List<ICommonBtPlaceholder> _OverridePlaceholdersCache;

		// Token: 0x040055F5 RID: 22005
		private bool _OverridePlaceholdersInited;

		// Token: 0x040055F6 RID: 22006
		private List<ICommonBtClientOverrideData> _ClientOverrideDataCache;

		// Token: 0x040055F7 RID: 22007
		private bool _ClientOverrideDataInited;
	}
}
