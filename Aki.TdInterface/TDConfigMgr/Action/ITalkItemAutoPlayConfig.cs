using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002167 RID: 8551
	public class ITalkItemAutoPlayConfig
	{
		// Token: 0x0600B5BC RID: 46524 RVA: 0x001977F0 File Offset: 0x001959F0
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

		// Token: 0x0600B5BD RID: 46525 RVA: 0x00197828 File Offset: 0x00195A28
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

		// Token: 0x0600B5BE RID: 46526 RVA: 0x0019783B File Offset: 0x00195A3B
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

		// Token: 0x0600B5BF RID: 46527 RVA: 0x0019784E File Offset: 0x00195A4E
		public ITalkItemAutoPlayConfig_SetValue ToSetValue()
		{
			return new ITalkItemAutoPlayConfig_SetValue
			{
				DisableAutoSelectOptionGroup = this.DisableAutoSelectOptionGroup
			};
		}

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x0600B5C0 RID: 46528 RVA: 0x00197864 File Offset: 0x00195A64
		// (set) Token: 0x0600B5C1 RID: 46529 RVA: 0x001978C5 File Offset: 0x00195AC5
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

		// Token: 0x04006B88 RID: 27528
		[Nullable(2)]
		protected ITalkItemAutoPlayConfig FbInstance;

		// Token: 0x04006B89 RID: 27529
		[Nullable(2)]
		protected ITalkItemAutoPlayConfig_SetValue PocoInterface;

		// Token: 0x04006B8A RID: 27530
		private ITalkItemDisableAutoSelectOptionGroup _DisableAutoSelectOptionGroupCache;

		// Token: 0x04006B8B RID: 27531
		private bool _DisableAutoSelectOptionGroupInited;
	}
}
