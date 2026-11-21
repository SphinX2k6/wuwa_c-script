using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E94 RID: 3732
	public class SlidePerformComponent : SlideRailComponent
	{
		// Token: 0x06005445 RID: 21573 RVA: 0x000CFB4A File Offset: 0x000CDD4A
		public static SlidePerformComponent Create(ISlidePerformComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlidePerformComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x06005446 RID: 21574 RVA: 0x000CFB6C File Offset: 0x000CDD6C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x000CFBA4 File Offset: 0x000CDDA4
		public override int? SlideSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SlideSpeed);
			}
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06005448 RID: 21576 RVA: 0x000CFBDC File Offset: 0x000CDDDC
		public override int? UpSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.UpSpeed);
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06005449 RID: 21577 RVA: 0x000CFC14 File Offset: 0x000CDE14
		public override int? DownSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DownSpeed);
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x0600544A RID: 21578 RVA: 0x000CFC4A File Offset: 0x000CDE4A
		public override int RailSplineEntityId
		{
			get
			{
				return this.Instance.RailSplineEntityId;
			}
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x0600544B RID: 21579 RVA: 0x000CFC58 File Offset: 0x000CDE58
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
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				int exchangeRailConfigsLength = this.Instance.ExchangeRailConfigsLength;
				this._ExchangeRailConfigsCache = new List<IExchangeSlideRailConfig>(exchangeRailConfigsLength);
				for (int i = 0; i < exchangeRailConfigsLength; i++)
				{
					this._ExchangeRailConfigsCache.Add(IExchangeSlideRailConfig.Create(this.Instance.ExchangeRailConfigs(i)));
				}
				return this._ExchangeRailConfigsCache;
			}
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x0600544C RID: 21580 RVA: 0x000CFCD4 File Offset: 0x000CDED4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x0600544D RID: 21581 RVA: 0x000CFCEA File Offset: 0x000CDEEA
		public virtual ISlopeSlidePerform SlidePerformConfig
		{
			get
			{
				if (this._SlidePerformConfigInited)
				{
					return this._SlidePerformConfigCache;
				}
				this._SlidePerformConfigInited = true;
				this._SlidePerformConfigCache = ISlopeSlidePerform.Create(this.Instance.SlidePerformConfig);
				return this._SlidePerformConfigCache;
			}
		}

		// Token: 0x0400303B RID: 12347
		private ISlidePerformComponent Instance;

		// Token: 0x0400303C RID: 12348
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IExchangeSlideRailConfig> _ExchangeRailConfigsCache;

		// Token: 0x0400303D RID: 12349
		private bool _ExchangeRailConfigsInited;

		// Token: 0x0400303E RID: 12350
		[Nullable(2)]
		private ISlopeSlidePerform _SlidePerformConfigCache;

		// Token: 0x0400303F RID: 12351
		private bool _SlidePerformConfigInited;
	}
}
