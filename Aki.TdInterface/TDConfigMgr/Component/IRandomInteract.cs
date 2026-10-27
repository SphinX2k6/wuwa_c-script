using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000650 RID: 1616
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomInteract
	{
		// Token: 0x06002294 RID: 8852 RVA: 0x0005F0DC File Offset: 0x0005D2DC
		private IRandomInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0005F114 File Offset: 0x0005D314
		public static IRandomInteract Create([Nullable(2)] IRandomInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0005F127 File Offset: 0x0005D327
		public static IRandomInteract CreateFromSetValue([Nullable(2)] IRandomInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0005F13A File Offset: 0x0005D33A
		public IRandomInteract_SetValue ToSetValue()
		{
			return new IRandomInteract_SetValue
			{
				RandomCount = this.RandomCount,
				Options = this.Options
			};
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x0005F159 File Offset: 0x0005D359
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x0005F184 File Offset: 0x0005D384
		public virtual int RandomCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RandomCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RandomCount;
			}
			set
			{
				this.GetOrCreatePoco().RandomCount = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0005F194 File Offset: 0x0005D394
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x0005F227 File Offset: 0x0005D427
		public virtual List<IRandomInteractOption> Options
		{
			get
			{
				if (this._OptionsInited)
				{
					return this._OptionsCache;
				}
				this._OptionsInited = true;
				if (this.FbInstance != null)
				{
					List<IRandomInteractOption> options = this.FbInstance.Options;
					if (options != null)
					{
						this._OptionsCache = new List<IRandomInteractOption>(options.Count);
						for (int i = 0; i < options.Count; i++)
						{
							this._OptionsCache.Add(IRandomInteractOption.Create(options[i]));
						}
					}
				}
				else
				{
					IRandomInteract_SetValue pocoInterface = this.PocoInterface;
					this._OptionsCache = ((pocoInterface != null) ? pocoInterface.Options : null);
				}
				return this._OptionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Options = value;
				this._OptionsInited = false;
			}
		}

		// Token: 0x04001805 RID: 6149
		[Nullable(2)]
		protected IRandomInteract FbInstance;

		// Token: 0x04001806 RID: 6150
		[Nullable(2)]
		protected IRandomInteract_SetValue PocoInterface;

		// Token: 0x04001807 RID: 6151
		private List<IRandomInteractOption> _OptionsCache;

		// Token: 0x04001808 RID: 6152
		private bool _OptionsInited;
	}
}
