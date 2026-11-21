using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093E RID: 2366
	public class SlidePerformComponent : SlideRailComponent
	{
		// Token: 0x06003471 RID: 13425 RVA: 0x00085BC0 File Offset: 0x00083DC0
		private SlidePerformComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SlidePerformComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SlidePerformComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SlidePerformComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00085BF8 File Offset: 0x00083DF8
		public static SlidePerformComponent Create([Nullable(2)] SlidePerformComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlidePerformComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x00085C0B File Offset: 0x00083E0B
		public static SlidePerformComponent CreateFromSetValue([Nullable(2)] SlidePerformComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SlidePerformComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x00085C20 File Offset: 0x00083E20
		public new SlidePerformComponent_SetValue ToSetValue()
		{
			return new SlidePerformComponent_SetValue
			{
				Disabled = this.Disabled,
				SlideSpeed = this.SlideSpeed,
				UpSpeed = this.UpSpeed,
				DownSpeed = this.DownSpeed,
				RailSplineEntityId = this.RailSplineEntityId,
				ExchangeRailConfigs = this.ExchangeRailConfigs,
				EdIsLocked = this.EdIsLocked,
				SlidePerformConfig = this.SlidePerformConfig
			};
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x00085C94 File Offset: 0x00083E94
		// (set) Token: 0x06003476 RID: 13430 RVA: 0x00085CCE File Offset: 0x00083ECE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SlidePerformComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x00085CDC File Offset: 0x00083EDC
		// (set) Token: 0x06003478 RID: 13432 RVA: 0x00085D16 File Offset: 0x00083F16
		public override int? SlideSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SlideSpeed;
				}
				SlidePerformComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06003479 RID: 13433 RVA: 0x00085D24 File Offset: 0x00083F24
		// (set) Token: 0x0600347A RID: 13434 RVA: 0x00085D5E File Offset: 0x00083F5E
		public override int? UpSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UpSpeed;
				}
				SlidePerformComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x0600347B RID: 13435 RVA: 0x00085D6C File Offset: 0x00083F6C
		// (set) Token: 0x0600347C RID: 13436 RVA: 0x00085DA6 File Offset: 0x00083FA6
		public override int? DownSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DownSpeed;
				}
				SlidePerformComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x0600347D RID: 13437 RVA: 0x00085DB4 File Offset: 0x00083FB4
		// (set) Token: 0x0600347E RID: 13438 RVA: 0x00085DDF File Offset: 0x00083FDF
		public override int RailSplineEntityId
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

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x00085DF0 File Offset: 0x00083FF0
		// (set) Token: 0x06003480 RID: 13440 RVA: 0x00085E83 File Offset: 0x00084083
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<IExchangeSlideRailConfig> ExchangeRailConfigs
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
					SlidePerformComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06003481 RID: 13441 RVA: 0x00085E98 File Offset: 0x00084098
		// (set) Token: 0x06003482 RID: 13442 RVA: 0x00085EC2 File Offset: 0x000840C2
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

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06003483 RID: 13443 RVA: 0x00085ED0 File Offset: 0x000840D0
		// (set) Token: 0x06003484 RID: 13444 RVA: 0x00085F31 File Offset: 0x00084131
		public virtual ISlopeSlidePerform SlidePerformConfig
		{
			get
			{
				if (this._SlidePerformConfigInited)
				{
					return this._SlidePerformConfigCache;
				}
				this._SlidePerformConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SlidePerformConfigCache = ISlopeSlidePerform.Create(this.FbInstance.SlidePerformConfig);
				}
				else
				{
					SlidePerformComponent_SetValue pocoInterface = this.PocoInterface;
					this._SlidePerformConfigCache = ((pocoInterface != null) ? pocoInterface.SlidePerformConfig : null);
				}
				return this._SlidePerformConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().SlidePerformConfig = value;
				this._SlidePerformConfigInited = false;
			}
		}

		// Token: 0x04002267 RID: 8807
		[Nullable(2)]
		protected new SlidePerformComponent FbInstance;

		// Token: 0x04002268 RID: 8808
		[Nullable(2)]
		protected new SlidePerformComponent_SetValue PocoInterface;

		// Token: 0x04002269 RID: 8809
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IExchangeSlideRailConfig> _ExchangeRailConfigsCache;

		// Token: 0x0400226A RID: 8810
		private bool _ExchangeRailConfigsInited;

		// Token: 0x0400226B RID: 8811
		private ISlopeSlidePerform _SlidePerformConfigCache;

		// Token: 0x0400226C RID: 8812
		private bool _SlidePerformConfigInited;
	}
}
