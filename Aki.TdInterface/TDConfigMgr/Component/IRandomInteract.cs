using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006ED RID: 1773
	public class IRandomInteract
	{
		// Token: 0x0600259A RID: 9626 RVA: 0x00065DF0 File Offset: 0x00063FF0
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

		// Token: 0x0600259B RID: 9627 RVA: 0x00065E28 File Offset: 0x00064028
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

		// Token: 0x0600259C RID: 9628 RVA: 0x00065E3B File Offset: 0x0006403B
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

		// Token: 0x0600259D RID: 9629 RVA: 0x00065E4E File Offset: 0x0006404E
		public IRandomInteract_SetValue ToSetValue()
		{
			return new IRandomInteract_SetValue
			{
				RandomCount = this.RandomCount,
				Options = this.Options
			};
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x00065E6D File Offset: 0x0006406D
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x00065E98 File Offset: 0x00064098
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

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x00065EA8 File Offset: 0x000640A8
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x00065F3B File Offset: 0x0006413B
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

		// Token: 0x040019F7 RID: 6647
		[Nullable(2)]
		protected IRandomInteract FbInstance;

		// Token: 0x040019F8 RID: 6648
		[Nullable(2)]
		protected IRandomInteract_SetValue PocoInterface;

		// Token: 0x040019F9 RID: 6649
		private List<IRandomInteractOption> _OptionsCache;

		// Token: 0x040019FA RID: 6650
		private bool _OptionsInited;
	}
}
