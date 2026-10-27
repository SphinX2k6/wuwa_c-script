using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200264D RID: 9805
	[NullableContext(1)]
	[Nullable(0)]
	public class AddBuffToFollowShooter : ActionParams
	{
		// Token: 0x0600DBE6 RID: 56294 RVA: 0x0020BAED File Offset: 0x00209CED
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

		// Token: 0x1700410E RID: 16654
		// (get) Token: 0x0600DBE7 RID: 56295 RVA: 0x0020BB0C File Offset: 0x00209D0C
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

		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x0600DBE8 RID: 56296 RVA: 0x0020BB70 File Offset: 0x00209D70
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

		// Token: 0x04007A3B RID: 31291
		private IAddBuffToFollowShooter Instance;

		// Token: 0x04007A3C RID: 31292
		private List<long> _BuffIdsCache;

		// Token: 0x04007A3D RID: 31293
		private bool _BuffIdsInited;
	}
}
