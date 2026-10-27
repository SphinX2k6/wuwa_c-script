using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D95 RID: 3477
	public class SlideRailComponent : IComponentBase
	{
		// Token: 0x06004F0E RID: 20238 RVA: 0x000C4045 File Offset: 0x000C2245
		[NullableContext(1)]
		public static SlideRailComponent Create(ISlideRailComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlideRailComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x000C4064 File Offset: 0x000C2264
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

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06004F10 RID: 20240 RVA: 0x000C409C File Offset: 0x000C229C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06004F11 RID: 20241 RVA: 0x000C40B4 File Offset: 0x000C22B4
		public virtual int? SlideSpeed
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

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06004F12 RID: 20242 RVA: 0x000C40EC File Offset: 0x000C22EC
		public virtual int? UpSpeed
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

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06004F13 RID: 20243 RVA: 0x000C4124 File Offset: 0x000C2324
		public virtual int? DownSpeed
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

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06004F14 RID: 20244 RVA: 0x000C415A File Offset: 0x000C235A
		public virtual int RailSplineEntityId
		{
			get
			{
				return this.Instance.RailSplineEntityId;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06004F15 RID: 20245 RVA: 0x000C4168 File Offset: 0x000C2368
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

		// Token: 0x04002D70 RID: 11632
		private ISlideRailComponent Instance;

		// Token: 0x04002D71 RID: 11633
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IExchangeSlideRailConfig> _ExchangeRailConfigsCache;

		// Token: 0x04002D72 RID: 11634
		private bool _ExchangeRailConfigsInited;
	}
}
