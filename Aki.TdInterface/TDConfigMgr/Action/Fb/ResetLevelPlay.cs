using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C68 RID: 11368
	public class ResetLevelPlay : ActionParams
	{
		// Token: 0x0600F9DF RID: 63967 RVA: 0x00244626 File Offset: 0x00242826
		public static ResetLevelPlay Create(IResetLevelPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetLevelPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DBD RID: 19901
		// (get) Token: 0x0600F9E0 RID: 63968 RVA: 0x00244648 File Offset: 0x00242848
		public virtual List<int> ResetLevelPlayList
		{
			get
			{
				if (this._ResetLevelPlayListInited)
				{
					return this._ResetLevelPlayListCache;
				}
				this._ResetLevelPlayListInited = true;
				int resetLevelPlayListLength = this.Instance.ResetLevelPlayListLength;
				this._ResetLevelPlayListCache = new List<int>(resetLevelPlayListLength);
				for (int i = 0; i < resetLevelPlayListLength; i++)
				{
					this._ResetLevelPlayListCache.Add(this.Instance.ResetLevelPlayList(i));
				}
				return this._ResetLevelPlayListCache;
			}
		}

		// Token: 0x04008888 RID: 34952
		private IResetLevelPlay Instance;

		// Token: 0x04008889 RID: 34953
		private List<int> _ResetLevelPlayListCache;

		// Token: 0x0400888A RID: 34954
		private bool _ResetLevelPlayListInited;
	}
}
