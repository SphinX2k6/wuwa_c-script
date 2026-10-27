using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D94 RID: 3476
	[NullableContext(1)]
	[Nullable(0)]
	public class IExchangeSlideRailConfig
	{
		// Token: 0x06004F09 RID: 20233 RVA: 0x000C3F42 File Offset: 0x000C2142
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

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06004F0A RID: 20234 RVA: 0x000C3F64 File Offset: 0x000C2164
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

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06004F0B RID: 20235 RVA: 0x000C3F9C File Offset: 0x000C219C
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

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x000C3FD4 File Offset: 0x000C21D4
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

		// Token: 0x04002D6D RID: 11629
		private IExchangeSlideRailConfig Instance;

		// Token: 0x04002D6E RID: 11630
		private List<INextSlideRail> _NextRailsCache;

		// Token: 0x04002D6F RID: 11631
		private bool _NextRailsInited;
	}
}
