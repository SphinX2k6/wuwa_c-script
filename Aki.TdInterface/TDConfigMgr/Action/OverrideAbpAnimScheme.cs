using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002357 RID: 9047
	public class OverrideAbpAnimScheme : ActionParams
	{
		// Token: 0x0600C534 RID: 50484 RVA: 0x001C4540 File Offset: 0x001C2740
		private OverrideAbpAnimScheme_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("OverrideAbpAnimScheme 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			OverrideAbpAnimScheme_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new OverrideAbpAnimScheme_SetValue());
			}
			return result;
		}

		// Token: 0x0600C535 RID: 50485 RVA: 0x001C4578 File Offset: 0x001C2778
		public static OverrideAbpAnimScheme Create([Nullable(2)] OverrideAbpAnimScheme instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OverrideAbpAnimScheme
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C536 RID: 50486 RVA: 0x001C458B File Offset: 0x001C278B
		public static OverrideAbpAnimScheme CreateFromSetValue([Nullable(2)] OverrideAbpAnimScheme_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new OverrideAbpAnimScheme
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C537 RID: 50487 RVA: 0x001C459E File Offset: 0x001C279E
		public OverrideAbpAnimScheme_SetValue ToSetValue()
		{
			return new OverrideAbpAnimScheme_SetValue
			{
				OverrideConfigs = this.OverrideConfigs
			};
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0600C538 RID: 50488 RVA: 0x001C45B4 File Offset: 0x001C27B4
		// (set) Token: 0x0600C539 RID: 50489 RVA: 0x001C4647 File Offset: 0x001C2847
		public virtual List<IOverrideAbpAnimSchemeConfig> OverrideConfigs
		{
			get
			{
				if (this._OverrideConfigsInited)
				{
					return this._OverrideConfigsCache;
				}
				this._OverrideConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IOverrideAbpAnimSchemeConfig> overrideConfigs = this.FbInstance.OverrideConfigs;
					if (overrideConfigs != null)
					{
						this._OverrideConfigsCache = new List<IOverrideAbpAnimSchemeConfig>(overrideConfigs.Count);
						for (int i = 0; i < overrideConfigs.Count; i++)
						{
							this._OverrideConfigsCache.Add(IOverrideAbpAnimSchemeConfig.Create(overrideConfigs[i]));
						}
					}
				}
				else
				{
					OverrideAbpAnimScheme_SetValue pocoInterface = this.PocoInterface;
					this._OverrideConfigsCache = ((pocoInterface != null) ? pocoInterface.OverrideConfigs : null);
				}
				return this._OverrideConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().OverrideConfigs = value;
				this._OverrideConfigsInited = false;
			}
		}

		// Token: 0x04007564 RID: 30052
		[Nullable(2)]
		protected new OverrideAbpAnimScheme FbInstance;

		// Token: 0x04007565 RID: 30053
		[Nullable(2)]
		protected OverrideAbpAnimScheme_SetValue PocoInterface;

		// Token: 0x04007566 RID: 30054
		private List<IOverrideAbpAnimSchemeConfig> _OverrideConfigsCache;

		// Token: 0x04007567 RID: 30055
		private bool _OverrideConfigsInited;
	}
}
