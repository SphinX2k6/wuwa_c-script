using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200158E RID: 5518
	public class ITimeRange
	{
		// Token: 0x06007C6A RID: 31850 RVA: 0x00127A1A File Offset: 0x00125C1A
		public static ITimeRange Create(ITimeRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x06007C6B RID: 31851 RVA: 0x00127A39 File Offset: 0x00125C39
		public virtual IDateTime StartTime
		{
			get
			{
				if (this._StartTimeInited)
				{
					return this._StartTimeCache;
				}
				this._StartTimeInited = true;
				this._StartTimeCache = IDateTime.Create(this.Instance.StartTime);
				return this._StartTimeCache;
			}
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x06007C6C RID: 31852 RVA: 0x00127A6D File Offset: 0x00125C6D
		public virtual IDateTime EndTime
		{
			get
			{
				if (this._EndTimeInited)
				{
					return this._EndTimeCache;
				}
				this._EndTimeInited = true;
				this._EndTimeCache = IDateTime.Create(this.Instance.EndTime);
				return this._EndTimeCache;
			}
		}

		// Token: 0x040047BC RID: 18364
		private ITimeRange Instance;

		// Token: 0x040047BD RID: 18365
		[Nullable(2)]
		private IDateTime _StartTimeCache;

		// Token: 0x040047BE RID: 18366
		private bool _StartTimeInited;

		// Token: 0x040047BF RID: 18367
		[Nullable(2)]
		private IDateTime _EndTimeCache;

		// Token: 0x040047C0 RID: 18368
		private bool _EndTimeInited;
	}
}
