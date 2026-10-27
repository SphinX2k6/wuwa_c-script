using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002586 RID: 9606
	[NullableContext(1)]
	[Nullable(0)]
	public class ISolarSchoolTime
	{
		// Token: 0x0600D799 RID: 55193 RVA: 0x00201B6B File Offset: 0x001FFD6B
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

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x0600D79A RID: 55194 RVA: 0x00201B8A File Offset: 0x001FFD8A
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

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x0600D79B RID: 55195 RVA: 0x00201BBE File Offset: 0x001FFDBE
		public virtual int PeriodId
		{
			get
			{
				return this.Instance.PeriodId;
			}
		}

		// Token: 0x0400774A RID: 30538
		private ISolarSchoolTime Instance;

		// Token: 0x0400774B RID: 30539
		[Nullable(2)]
		private IVisualNovelDate _DateCache;

		// Token: 0x0400774C RID: 30540
		private bool _DateInited;
	}
}
