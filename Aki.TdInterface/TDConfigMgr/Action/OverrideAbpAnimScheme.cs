using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020F6 RID: 8438
	[NullableContext(1)]
	[Nullable(0)]
	public class OverrideAbpAnimScheme : ActionParams
	{
		// Token: 0x0600B9A8 RID: 47528 RVA: 0x001AD3E0 File Offset: 0x001AB5E0
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

		// Token: 0x0600B9A9 RID: 47529 RVA: 0x001AD418 File Offset: 0x001AB618
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

		// Token: 0x0600B9AA RID: 47530 RVA: 0x001AD42B File Offset: 0x001AB62B
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

		// Token: 0x0600B9AB RID: 47531 RVA: 0x001AD43E File Offset: 0x001AB63E
		public OverrideAbpAnimScheme_SetValue ToSetValue()
		{
			return new OverrideAbpAnimScheme_SetValue
			{
				OverrideConfigs = this.OverrideConfigs
			};
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600B9AC RID: 47532 RVA: 0x001AD454 File Offset: 0x001AB654
		// (set) Token: 0x0600B9AD RID: 47533 RVA: 0x001AD4E7 File Offset: 0x001AB6E7
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

		// Token: 0x04006F30 RID: 28464
		[Nullable(2)]
		protected new OverrideAbpAnimScheme FbInstance;

		// Token: 0x04006F31 RID: 28465
		[Nullable(2)]
		protected OverrideAbpAnimScheme_SetValue PocoInterface;

		// Token: 0x04006F32 RID: 28466
		private List<IOverrideAbpAnimSchemeConfig> _OverrideConfigsCache;

		// Token: 0x04006F33 RID: 28467
		private bool _OverrideConfigsInited;
	}
}
