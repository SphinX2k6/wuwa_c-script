using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001480 RID: 5248
	public class IProgressBar
	{
		// Token: 0x06007743 RID: 30531 RVA: 0x0011E298 File Offset: 0x0011C498
		public static IProgressBar Create(IProgressBar? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgressBar
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x06007744 RID: 30532 RVA: 0x0011E2B7 File Offset: 0x0011C4B7
		public virtual EProgressBarStyle ProgressStyle
		{
			get
			{
				return (EProgressBarStyle)this.Instance.ProgressStyle;
			}
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x06007745 RID: 30533 RVA: 0x0011E2C4 File Offset: 0x0011C4C4
		public virtual IProgressCalculate ProgressCalculate
		{
			get
			{
				if (this._ProgressCalculateInited)
				{
					return this._ProgressCalculateCache;
				}
				this._ProgressCalculateInited = true;
				this._ProgressCalculateCache = IProgressCalculate.Create(this.Instance.ProgressCalculate);
				return this._ProgressCalculateCache;
			}
		}

		// Token: 0x04004476 RID: 17526
		private IProgressBar Instance;

		// Token: 0x04004477 RID: 17527
		[Nullable(2)]
		private IProgressCalculate _ProgressCalculateCache;

		// Token: 0x04004478 RID: 17528
		private bool _ProgressCalculateInited;
	}
}
