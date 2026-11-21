using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000940 RID: 2368
	public class SlideRailComponent : IComponentBase
	{
		// Token: 0x06003487 RID: 13447 RVA: 0x00085F58 File Offset: 0x00084158
		private SlideRailComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SlideRailComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SlideRailComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SlideRailComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00085F90 File Offset: 0x00084190
		public static SlideRailComponent Create([Nullable(2)] SlideRailComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlideRailComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x00085FA3 File Offset: 0x000841A3
		public static SlideRailComponent CreateFromSetValue([Nullable(2)] SlideRailComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SlideRailComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00085FB8 File Offset: 0x000841B8
		public new SlideRailComponent_SetValue ToSetValue()
		{
			return new SlideRailComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				SlideSpeed = this.SlideSpeed,
				UpSpeed = this.UpSpeed,
				DownSpeed = this.DownSpeed,
				RailSplineEntityId = this.RailSplineEntityId,
				ExchangeRailConfigs = this.ExchangeRailConfigs
			};
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x00086020 File Offset: 0x00084220
		// (set) Token: 0x0600348C RID: 13452 RVA: 0x0008605A File Offset: 0x0008425A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SlideRailComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x0600348D RID: 13453 RVA: 0x00086068 File Offset: 0x00084268
		// (set) Token: 0x0600348E RID: 13454 RVA: 0x00086092 File Offset: 0x00084292
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x0600348F RID: 13455 RVA: 0x000860A0 File Offset: 0x000842A0
		// (set) Token: 0x06003490 RID: 13456 RVA: 0x000860DA File Offset: 0x000842DA
		public virtual int? SlideSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SlideSpeed;
				}
				SlideRailComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SlideSpeed;
			}
			set
			{
				this.GetOrCreatePoco().SlideSpeed = value;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06003491 RID: 13457 RVA: 0x000860E8 File Offset: 0x000842E8
		// (set) Token: 0x06003492 RID: 13458 RVA: 0x00086122 File Offset: 0x00084322
		public virtual int? UpSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UpSpeed;
				}
				SlideRailComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UpSpeed;
			}
			set
			{
				this.GetOrCreatePoco().UpSpeed = value;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06003493 RID: 13459 RVA: 0x00086130 File Offset: 0x00084330
		// (set) Token: 0x06003494 RID: 13460 RVA: 0x0008616A File Offset: 0x0008436A
		public virtual int? DownSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DownSpeed;
				}
				SlideRailComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DownSpeed;
			}
			set
			{
				this.GetOrCreatePoco().DownSpeed = value;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x00086178 File Offset: 0x00084378
		// (set) Token: 0x06003496 RID: 13462 RVA: 0x000861A3 File Offset: 0x000843A3
		public virtual int RailSplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RailSplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RailSplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().RailSplineEntityId = value;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06003497 RID: 13463 RVA: 0x000861B4 File Offset: 0x000843B4
		// (set) Token: 0x06003498 RID: 13464 RVA: 0x00086247 File Offset: 0x00084447
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IExchangeSlideRailConfig> ExchangeRailConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ExchangeRailConfigsInited)
				{
					return this._ExchangeRailConfigsCache;
				}
				this._ExchangeRailConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IExchangeSlideRailConfig> exchangeRailConfigs = this.FbInstance.ExchangeRailConfigs;
					if (exchangeRailConfigs != null)
					{
						this._ExchangeRailConfigsCache = new List<IExchangeSlideRailConfig>(exchangeRailConfigs.Count);
						for (int i = 0; i < exchangeRailConfigs.Count; i++)
						{
							this._ExchangeRailConfigsCache.Add(IExchangeSlideRailConfig.Create(exchangeRailConfigs[i]));
						}
					}
				}
				else
				{
					SlideRailComponent_SetValue pocoInterface = this.PocoInterface;
					this._ExchangeRailConfigsCache = ((pocoInterface != null) ? pocoInterface.ExchangeRailConfigs : null);
				}
				return this._ExchangeRailConfigsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().ExchangeRailConfigs = value;
				this._ExchangeRailConfigsInited = false;
			}
		}

		// Token: 0x04002275 RID: 8821
		[Nullable(2)]
		protected new SlideRailComponent FbInstance;

		// Token: 0x04002276 RID: 8822
		[Nullable(2)]
		protected new SlideRailComponent_SetValue PocoInterface;

		// Token: 0x04002277 RID: 8823
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IExchangeSlideRailConfig> _ExchangeRailConfigsCache;

		// Token: 0x04002278 RID: 8824
		private bool _ExchangeRailConfigsInited;
	}
}
