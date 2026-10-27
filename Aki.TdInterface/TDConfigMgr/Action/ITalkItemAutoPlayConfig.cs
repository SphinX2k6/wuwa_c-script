using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F2E RID: 7982
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkItemAutoPlayConfig
	{
		// Token: 0x0600AAEA RID: 43754 RVA: 0x001817F8 File Offset: 0x0017F9F8
		private ITalkItemAutoPlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemAutoPlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemAutoPlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemAutoPlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AAEB RID: 43755 RVA: 0x00181830 File Offset: 0x0017FA30
		public static ITalkItemAutoPlayConfig Create([Nullable(2)] ITalkItemAutoPlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAutoPlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AAEC RID: 43756 RVA: 0x00181843 File Offset: 0x0017FA43
		public static ITalkItemAutoPlayConfig CreateFromSetValue([Nullable(2)] ITalkItemAutoPlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemAutoPlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AAED RID: 43757 RVA: 0x00181856 File Offset: 0x0017FA56
		public ITalkItemAutoPlayConfig_SetValue ToSetValue()
		{
			return new ITalkItemAutoPlayConfig_SetValue
			{
				DisableAutoSelectOptionGroup = this.DisableAutoSelectOptionGroup
			};
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600AAEE RID: 43758 RVA: 0x0018186C File Offset: 0x0017FA6C
		// (set) Token: 0x0600AAEF RID: 43759 RVA: 0x001818CD File Offset: 0x0017FACD
		[Nullable(2)]
		public virtual ITalkItemDisableAutoSelectOptionGroup DisableAutoSelectOptionGroup
		{
			[NullableContext(2)]
			get
			{
				if (this._DisableAutoSelectOptionGroupInited)
				{
					return this._DisableAutoSelectOptionGroupCache;
				}
				this._DisableAutoSelectOptionGroupInited = true;
				if (this.FbInstance != null)
				{
					this._DisableAutoSelectOptionGroupCache = ITalkItemDisableAutoSelectOptionGroup.Create(this.FbInstance.DisableAutoSelectOptionGroup);
				}
				else
				{
					ITalkItemAutoPlayConfig_SetValue pocoInterface = this.PocoInterface;
					this._DisableAutoSelectOptionGroupCache = ((pocoInterface != null) ? pocoInterface.DisableAutoSelectOptionGroup : null);
				}
				return this._DisableAutoSelectOptionGroupCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DisableAutoSelectOptionGroup = value;
				this._DisableAutoSelectOptionGroupInited = false;
			}
		}

		// Token: 0x04006599 RID: 26009
		[Nullable(2)]
		protected ITalkItemAutoPlayConfig FbInstance;

		// Token: 0x0400659A RID: 26010
		[Nullable(2)]
		protected ITalkItemAutoPlayConfig_SetValue PocoInterface;

		// Token: 0x0400659B RID: 26011
		private ITalkItemDisableAutoSelectOptionGroup _DisableAutoSelectOptionGroupCache;

		// Token: 0x0400659C RID: 26012
		private bool _DisableAutoSelectOptionGroupInited;
	}
}
