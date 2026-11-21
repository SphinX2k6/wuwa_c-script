using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000228 RID: 552
	public class IBuffArea : IEffectAreaMode
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x00028694 File Offset: 0x00026894
		private IBuffArea_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBuffArea 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBuffArea_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBuffArea_SetValue());
			}
			return result;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000286CC File Offset: 0x000268CC
		public static IBuffArea Create([Nullable(2)] IBuffArea instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBuffArea
			{
				FbInstance = instance
			};
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000286DF File Offset: 0x000268DF
		public static IBuffArea CreateFromSetValue([Nullable(2)] IBuffArea_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBuffArea
			{
				PocoInterface = value
			};
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x000286F2 File Offset: 0x000268F2
		public new IBuffArea_SetValue ToSetValue()
		{
			return new IBuffArea_SetValue
			{
				Type = this.Type,
				BuffConfigs = this.BuffConfigs
			};
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00028711 File Offset: 0x00026911
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0002873C File Offset: 0x0002693C
		public override EEffectAreaType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectAreaType.BuffArea;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0002874C File Offset: 0x0002694C
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x000287DF File Offset: 0x000269DF
		public virtual List<IBuffAreaStateConfig> BuffConfigs
		{
			get
			{
				if (this._BuffConfigsInited)
				{
					return this._BuffConfigsCache;
				}
				this._BuffConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IBuffAreaStateConfig> buffConfigs = this.FbInstance.BuffConfigs;
					if (buffConfigs != null)
					{
						this._BuffConfigsCache = new List<IBuffAreaStateConfig>(buffConfigs.Count);
						for (int i = 0; i < buffConfigs.Count; i++)
						{
							this._BuffConfigsCache.Add(IBuffAreaStateConfig.Create(buffConfigs[i]));
						}
					}
				}
				else
				{
					IBuffArea_SetValue pocoInterface = this.PocoInterface;
					this._BuffConfigsCache = ((pocoInterface != null) ? pocoInterface.BuffConfigs : null);
				}
				return this._BuffConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().BuffConfigs = value;
				this._BuffConfigsInited = false;
			}
		}

		// Token: 0x040009B5 RID: 2485
		[Nullable(2)]
		protected new IBuffArea FbInstance;

		// Token: 0x040009B6 RID: 2486
		[Nullable(2)]
		protected new IBuffArea_SetValue PocoInterface;

		// Token: 0x040009B7 RID: 2487
		private List<IBuffAreaStateConfig> _BuffConfigsCache;

		// Token: 0x040009B8 RID: 2488
		private bool _BuffConfigsInited;
	}
}
