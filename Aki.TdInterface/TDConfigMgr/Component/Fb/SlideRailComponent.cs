using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E91 RID: 3729
	public class SlideRailComponent : IComponentBase
	{
		// Token: 0x06005433 RID: 21555 RVA: 0x000CF895 File Offset: 0x000CDA95
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

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06005434 RID: 21556 RVA: 0x000CF8B4 File Offset: 0x000CDAB4
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

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x06005435 RID: 21557 RVA: 0x000CF8EC File Offset: 0x000CDAEC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x06005436 RID: 21558 RVA: 0x000CF904 File Offset: 0x000CDB04
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

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x06005437 RID: 21559 RVA: 0x000CF93C File Offset: 0x000CDB3C
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

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x000CF974 File Offset: 0x000CDB74
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

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06005439 RID: 21561 RVA: 0x000CF9AA File Offset: 0x000CDBAA
		public virtual int RailSplineEntityId
		{
			get
			{
				return this.Instance.RailSplineEntityId;
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x0600543A RID: 21562 RVA: 0x000CF9B8 File Offset: 0x000CDBB8
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

		// Token: 0x04003036 RID: 12342
		private ISlideRailComponent Instance;

		// Token: 0x04003037 RID: 12343
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IExchangeSlideRailConfig> _ExchangeRailConfigsCache;

		// Token: 0x04003038 RID: 12344
		private bool _ExchangeRailConfigsInited;
	}
}
