using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200089B RID: 2203
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidePerformComponent : SlideRailComponent
	{
		// Token: 0x06003135 RID: 12597 RVA: 0x0007E6D8 File Offset: 0x0007C8D8
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

		// Token: 0x06003136 RID: 12598 RVA: 0x0007E710 File Offset: 0x0007C910
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

		// Token: 0x06003137 RID: 12599 RVA: 0x0007E723 File Offset: 0x0007C923
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

		// Token: 0x06003138 RID: 12600 RVA: 0x0007E738 File Offset: 0x0007C938
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

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x0007E7AC File Offset: 0x0007C9AC
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x0007E7E6 File Offset: 0x0007C9E6
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

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600313B RID: 12603 RVA: 0x0007E7F4 File Offset: 0x0007C9F4
		// (set) Token: 0x0600313C RID: 12604 RVA: 0x0007E82E File Offset: 0x0007CA2E
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

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x0007E83C File Offset: 0x0007CA3C
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x0007E876 File Offset: 0x0007CA76
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

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x0007E884 File Offset: 0x0007CA84
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x0007E8BE File Offset: 0x0007CABE
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

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x0007E8CC File Offset: 0x0007CACC
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x0007E8F7 File Offset: 0x0007CAF7
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

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x0007E908 File Offset: 0x0007CB08
		// (set) Token: 0x06003144 RID: 12612 RVA: 0x0007E99B File Offset: 0x0007CB9B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IExchangeSlideRailConfig> ExchangeRailConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().ExchangeRailConfigs = value;
				this._ExchangeRailConfigsInited = false;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x0007E9B0 File Offset: 0x0007CBB0
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x0007E9DA File Offset: 0x0007CBDA
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

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x0007E9E8 File Offset: 0x0007CBE8
		// (set) Token: 0x06003148 RID: 12616 RVA: 0x0007EA49 File Offset: 0x0007CC49
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

		// Token: 0x04002055 RID: 8277
		[Nullable(2)]
		protected new SlidePerformComponent FbInstance;

		// Token: 0x04002056 RID: 8278
		[Nullable(2)]
		protected new SlidePerformComponent_SetValue PocoInterface;

		// Token: 0x04002057 RID: 8279
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IExchangeSlideRailConfig> _ExchangeRailConfigsCache;

		// Token: 0x04002058 RID: 8280
		private bool _ExchangeRailConfigsInited;

		// Token: 0x04002059 RID: 8281
		private ISlopeSlidePerform _SlidePerformConfigCache;

		// Token: 0x0400205A RID: 8282
		private bool _SlidePerformConfigInited;
	}
}
