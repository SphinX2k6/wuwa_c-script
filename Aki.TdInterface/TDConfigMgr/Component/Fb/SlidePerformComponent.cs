using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D98 RID: 3480
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidePerformComponent : SlideRailComponent
	{
		// Token: 0x06004F20 RID: 20256 RVA: 0x000C42FA File Offset: 0x000C24FA
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

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06004F21 RID: 20257 RVA: 0x000C431C File Offset: 0x000C251C
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

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06004F22 RID: 20258 RVA: 0x000C4354 File Offset: 0x000C2554
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

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x06004F23 RID: 20259 RVA: 0x000C438C File Offset: 0x000C258C
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

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06004F24 RID: 20260 RVA: 0x000C43C4 File Offset: 0x000C25C4
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

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x06004F25 RID: 20261 RVA: 0x000C43FA File Offset: 0x000C25FA
		public override int RailSplineEntityId
		{
			get
			{
				return this.Instance.RailSplineEntityId;
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06004F26 RID: 20262 RVA: 0x000C4408 File Offset: 0x000C2608
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

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06004F27 RID: 20263 RVA: 0x000C4484 File Offset: 0x000C2684
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06004F28 RID: 20264 RVA: 0x000C449A File Offset: 0x000C269A
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

		// Token: 0x04002D75 RID: 11637
		private ISlidePerformComponent Instance;

		// Token: 0x04002D76 RID: 11638
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IExchangeSlideRailConfig> _ExchangeRailConfigsCache;

		// Token: 0x04002D77 RID: 11639
		private bool _ExchangeRailConfigsInited;

		// Token: 0x04002D78 RID: 11640
		[Nullable(2)]
		private ISlopeSlidePerform _SlidePerformConfigCache;

		// Token: 0x04002D79 RID: 11641
		private bool _SlidePerformConfigInited;
	}
}
