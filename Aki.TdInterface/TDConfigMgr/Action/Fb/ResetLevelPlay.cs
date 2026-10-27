using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002982 RID: 10626
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetLevelPlay : ActionParams
	{
		// Token: 0x0600EB64 RID: 60260 RVA: 0x00226ECE File Offset: 0x002250CE
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

		// Token: 0x17004A22 RID: 18978
		// (get) Token: 0x0600EB65 RID: 60261 RVA: 0x00226EF0 File Offset: 0x002250F0
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

		// Token: 0x040081A4 RID: 33188
		private IResetLevelPlay Instance;

		// Token: 0x040081A5 RID: 33189
		private List<int> _ResetLevelPlayListCache;

		// Token: 0x040081A6 RID: 33190
		private bool _ResetLevelPlayListInited;
	}
}
