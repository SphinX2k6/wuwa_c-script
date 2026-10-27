using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001436 RID: 5174
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeRange
	{
		// Token: 0x060075A5 RID: 30117 RVA: 0x00118FCE File Offset: 0x001171CE
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

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x060075A6 RID: 30118 RVA: 0x00118FED File Offset: 0x001171ED
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

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x060075A7 RID: 30119 RVA: 0x00119021 File Offset: 0x00117221
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

		// Token: 0x04004428 RID: 17448
		private ITimeRange Instance;

		// Token: 0x04004429 RID: 17449
		[Nullable(2)]
		private IDateTime _StartTimeCache;

		// Token: 0x0400442A RID: 17450
		private bool _StartTimeInited;

		// Token: 0x0400442B RID: 17451
		[Nullable(2)]
		private IDateTime _EndTimeCache;

		// Token: 0x0400442C RID: 17452
		private bool _EndTimeInited;
	}
}
