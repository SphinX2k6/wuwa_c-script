using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002834 RID: 10292
	[NullableContext(2)]
	[Nullable(0)]
	public class ISolarSchoolTime
	{
		// Token: 0x0600E513 RID: 58643 RVA: 0x0021D89F File Offset: 0x0021BA9F
		[NullableContext(0)]
		public static ISolarSchoolTime Create(ISolarSchoolTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISolarSchoolTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004159 RID: 16729
		// (get) Token: 0x0600E514 RID: 58644 RVA: 0x0021D8BE File Offset: 0x0021BABE
		public virtual IVisualNovelDate Date
		{
			get
			{
				if (this._DateInited)
				{
					return this._DateCache;
				}
				this._DateInited = true;
				this._DateCache = IVisualNovelDate.Create(this.Instance.Date);
				return this._DateCache;
			}
		}

		// Token: 0x1700415A RID: 16730
		// (get) Token: 0x0600E515 RID: 58645 RVA: 0x0021D8F2 File Offset: 0x0021BAF2
		public virtual int PeriodId
		{
			get
			{
				return this.Instance.PeriodId;
			}
		}

		// Token: 0x04007DB0 RID: 32176
		private ISolarSchoolTime Instance;

		// Token: 0x04007DB1 RID: 32177
		private IVisualNovelDate _DateCache;

		// Token: 0x04007DB2 RID: 32178
		private bool _DateInited;
	}
}
