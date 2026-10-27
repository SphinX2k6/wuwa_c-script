using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200089D RID: 2205
	[NullableContext(1)]
	[Nullable(0)]
	public class SlideRailComponent : IComponentBase
	{
		// Token: 0x0600314B RID: 12619 RVA: 0x0007EA70 File Offset: 0x0007CC70
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

		// Token: 0x0600314C RID: 12620 RVA: 0x0007EAA8 File Offset: 0x0007CCA8
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

		// Token: 0x0600314D RID: 12621 RVA: 0x0007EABB File Offset: 0x0007CCBB
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

		// Token: 0x0600314E RID: 12622 RVA: 0x0007EAD0 File Offset: 0x0007CCD0
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

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x0600314F RID: 12623 RVA: 0x0007EB38 File Offset: 0x0007CD38
		// (set) Token: 0x06003150 RID: 12624 RVA: 0x0007EB72 File Offset: 0x0007CD72
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

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06003151 RID: 12625 RVA: 0x0007EB80 File Offset: 0x0007CD80
		// (set) Token: 0x06003152 RID: 12626 RVA: 0x0007EBAA File Offset: 0x0007CDAA
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

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06003153 RID: 12627 RVA: 0x0007EBB8 File Offset: 0x0007CDB8
		// (set) Token: 0x06003154 RID: 12628 RVA: 0x0007EBF2 File Offset: 0x0007CDF2
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

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06003155 RID: 12629 RVA: 0x0007EC00 File Offset: 0x0007CE00
		// (set) Token: 0x06003156 RID: 12630 RVA: 0x0007EC3A File Offset: 0x0007CE3A
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

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x0007EC48 File Offset: 0x0007CE48
		// (set) Token: 0x06003158 RID: 12632 RVA: 0x0007EC82 File Offset: 0x0007CE82
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

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06003159 RID: 12633 RVA: 0x0007EC90 File Offset: 0x0007CE90
		// (set) Token: 0x0600315A RID: 12634 RVA: 0x0007ECBB File Offset: 0x0007CEBB
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

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x0600315B RID: 12635 RVA: 0x0007ECCC File Offset: 0x0007CECC
		// (set) Token: 0x0600315C RID: 12636 RVA: 0x0007ED5F File Offset: 0x0007CF5F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IExchangeSlideRailConfig> ExchangeRailConfigs
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
					SlideRailComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04002063 RID: 8291
		[Nullable(2)]
		protected new SlideRailComponent FbInstance;

		// Token: 0x04002064 RID: 8292
		[Nullable(2)]
		protected new SlideRailComponent_SetValue PocoInterface;

		// Token: 0x04002065 RID: 8293
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IExchangeSlideRailConfig> _ExchangeRailConfigsCache;

		// Token: 0x04002066 RID: 8294
		private bool _ExchangeRailConfigsInited;
	}
}
