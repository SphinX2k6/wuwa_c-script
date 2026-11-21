using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E90 RID: 3728
	public class IExchangeSlideRailConfig
	{
		// Token: 0x0600542E RID: 21550 RVA: 0x000CF792 File Offset: 0x000CD992
		public static IExchangeSlideRailConfig Create(IExchangeSlideRailConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExchangeSlideRailConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x0600542F RID: 21551 RVA: 0x000CF7B4 File Offset: 0x000CD9B4
		public virtual int? MaxExchangeDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MaxExchangeDistance);
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06005430 RID: 21552 RVA: 0x000CF7EC File Offset: 0x000CD9EC
		public virtual int? MaxExchangeHigh
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MaxExchangeHigh);
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06005431 RID: 21553 RVA: 0x000CF824 File Offset: 0x000CDA24
		public virtual List<INextSlideRail> NextRails
		{
			get
			{
				if (this._NextRailsInited)
				{
					return this._NextRailsCache;
				}
				this._NextRailsInited = true;
				int nextRailsLength = this.Instance.NextRailsLength;
				this._NextRailsCache = new List<INextSlideRail>(nextRailsLength);
				for (int i = 0; i < nextRailsLength; i++)
				{
					this._NextRailsCache.Add(INextSlideRail.Create(this.Instance.NextRails(i)));
				}
				return this._NextRailsCache;
			}
		}

		// Token: 0x04003033 RID: 12339
		private IExchangeSlideRailConfig Instance;

		// Token: 0x04003034 RID: 12340
		private List<INextSlideRail> _NextRailsCache;

		// Token: 0x04003035 RID: 12341
		private bool _NextRailsInited;
	}
}
