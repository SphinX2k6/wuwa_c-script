using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000388 RID: 904
	public class IExchangeSlideRailConfig
	{
		// Token: 0x060011A8 RID: 4520 RVA: 0x0003BF78 File Offset: 0x0003A178
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

		// Token: 0x060011A9 RID: 4521 RVA: 0x0003BFB0 File Offset: 0x0003A1B0
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

		// Token: 0x060011AA RID: 4522 RVA: 0x0003BFC3 File Offset: 0x0003A1C3
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

		// Token: 0x060011AB RID: 4523 RVA: 0x0003BFD6 File Offset: 0x0003A1D6
		public IExchangeSlideRailConfig_SetValue ToSetValue()
		{
			return new IExchangeSlideRailConfig_SetValue
			{
				MaxExchangeDistance = this.MaxExchangeDistance,
				MaxExchangeHigh = this.MaxExchangeHigh,
				NextRails = this.NextRails
			};
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x0003C004 File Offset: 0x0003A204
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x0003C03E File Offset: 0x0003A23E
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

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0003C04C File Offset: 0x0003A24C
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x0003C086 File Offset: 0x0003A286
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

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0003C094 File Offset: 0x0003A294
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x0003C127 File Offset: 0x0003A327
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

		// Token: 0x04000EC0 RID: 3776
		[Nullable(2)]
		protected IExchangeSlideRailConfig FbInstance;

		// Token: 0x04000EC1 RID: 3777
		[Nullable(2)]
		protected IExchangeSlideRailConfig_SetValue PocoInterface;

		// Token: 0x04000EC2 RID: 3778
		private List<INextSlideRail> _NextRailsCache;

		// Token: 0x04000EC3 RID: 3779
		private bool _NextRailsInited;
	}
}
