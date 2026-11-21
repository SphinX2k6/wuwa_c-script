using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002911 RID: 10513
	public class AddBuffToFollowShooter : ActionParams
	{
		// Token: 0x0600E9C2 RID: 59842 RVA: 0x002283C5 File Offset: 0x002265C5
		public static AddBuffToFollowShooter Create(IAddBuffToFollowShooter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddBuffToFollowShooter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700444E RID: 17486
		// (get) Token: 0x0600E9C3 RID: 59843 RVA: 0x002283E4 File Offset: 0x002265E4
		public virtual List<long> BuffIds
		{
			get
			{
				if (this._BuffIdsInited)
				{
					return this._BuffIdsCache;
				}
				this._BuffIdsInited = true;
				int buffIdsLength = this.Instance.BuffIdsLength;
				this._BuffIdsCache = new List<long>(buffIdsLength);
				for (int i = 0; i < buffIdsLength; i++)
				{
					this._BuffIdsCache.Add(this.Instance.BuffIds(i));
				}
				return this._BuffIdsCache;
			}
		}

		// Token: 0x1700444F RID: 17487
		// (get) Token: 0x0600E9C4 RID: 59844 RVA: 0x00228448 File Offset: 0x00226648
		public virtual int? FollowShooterId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FollowShooterId);
			}
		}

		// Token: 0x040080DD RID: 32989
		private IAddBuffToFollowShooter Instance;

		// Token: 0x040080DE RID: 32990
		private List<long> _BuffIdsCache;

		// Token: 0x040080DF RID: 32991
		private bool _BuffIdsInited;
	}
}
