using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001330 RID: 4912
	[NullableContext(1)]
	[Nullable(0)]
	public class IProgressBar
	{
		// Token: 0x060070A3 RID: 28835 RVA: 0x0010FD2C File Offset: 0x0010DF2C
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

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x060070A4 RID: 28836 RVA: 0x0010FD4B File Offset: 0x0010DF4B
		public virtual EProgressBarStyle ProgressStyle
		{
			get
			{
				return (EProgressBarStyle)this.Instance.ProgressStyle;
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x060070A5 RID: 28837 RVA: 0x0010FD58 File Offset: 0x0010DF58
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

		// Token: 0x040040FA RID: 16634
		private IProgressBar Instance;

		// Token: 0x040040FB RID: 16635
		[Nullable(2)]
		private IProgressCalculate _ProgressCalculateCache;

		// Token: 0x040040FC RID: 16636
		private bool _ProgressCalculateInited;
	}
}
