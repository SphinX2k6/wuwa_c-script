using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000341 RID: 833
	[NullableContext(1)]
	[Nullable(0)]
	public class IExchangeSlideRailConfig
	{
		// Token: 0x06001076 RID: 4214 RVA: 0x00038FAC File Offset: 0x000371AC
		private IExchangeSlideRailConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExchangeSlideRailConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExchangeSlideRailConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExchangeSlideRailConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00038FE4 File Offset: 0x000371E4
		public static IExchangeSlideRailConfig Create([Nullable(2)] IExchangeSlideRailConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExchangeSlideRailConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00038FF7 File Offset: 0x000371F7
		public static IExchangeSlideRailConfig CreateFromSetValue([Nullable(2)] IExchangeSlideRailConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExchangeSlideRailConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0003900A File Offset: 0x0003720A
		public IExchangeSlideRailConfig_SetValue ToSetValue()
		{
			return new IExchangeSlideRailConfig_SetValue
			{
				MaxExchangeDistance = this.MaxExchangeDistance,
				MaxExchangeHigh = this.MaxExchangeHigh,
				NextRails = this.NextRails
			};
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x00039038 File Offset: 0x00037238
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x00039072 File Offset: 0x00037272
		public virtual int? MaxExchangeDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxExchangeDistance;
				}
				IExchangeSlideRailConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxExchangeDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxExchangeDistance = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00039080 File Offset: 0x00037280
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x000390BA File Offset: 0x000372BA
		public virtual int? MaxExchangeHigh
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxExchangeHigh;
				}
				IExchangeSlideRailConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxExchangeHigh;
			}
			set
			{
				this.GetOrCreatePoco().MaxExchangeHigh = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x000390C8 File Offset: 0x000372C8
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x0003915B File Offset: 0x0003735B
		public virtual List<INextSlideRail> NextRails
		{
			get
			{
				if (this._NextRailsInited)
				{
					return this._NextRailsCache;
				}
				this._NextRailsInited = true;
				if (this.FbInstance != null)
				{
					List<INextSlideRail> nextRails = this.FbInstance.NextRails;
					if (nextRails != null)
					{
						this._NextRailsCache = new List<INextSlideRail>(nextRails.Count);
						for (int i = 0; i < nextRails.Count; i++)
						{
							this._NextRailsCache.Add(INextSlideRail.Create(nextRails[i]));
						}
					}
				}
				else
				{
					IExchangeSlideRailConfig_SetValue pocoInterface = this.PocoInterface;
					this._NextRailsCache = ((pocoInterface != null) ? pocoInterface.NextRails : null);
				}
				return this._NextRailsCache;
			}
			set
			{
				this.GetOrCreatePoco().NextRails = value;
				this._NextRailsInited = false;
			}
		}

		// Token: 0x04000DD5 RID: 3541
		[Nullable(2)]
		protected IExchangeSlideRailConfig FbInstance;

		// Token: 0x04000DD6 RID: 3542
		[Nullable(2)]
		protected IExchangeSlideRailConfig_SetValue PocoInterface;

		// Token: 0x04000DD7 RID: 3543
		private List<INextSlideRail> _NextRailsCache;

		// Token: 0x04000DD8 RID: 3544
		private bool _NextRailsInited;
	}
}
