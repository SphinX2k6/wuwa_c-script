using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002896 RID: 10390
	public class PlayCustomSequence : ActionParams
	{
		// Token: 0x0600E78D RID: 59277 RVA: 0x0022409B File Offset: 0x0022229B
		public static PlayCustomSequence Create(IPlayCustomSequence? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayCustomSequence
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700430F RID: 17167
		// (get) Token: 0x0600E78E RID: 59278 RVA: 0x002240BA File Offset: 0x002222BA
		public virtual int CustomSeqId
		{
			get
			{
				return this.Instance.CustomSeqId;
			}
		}

		// Token: 0x17004310 RID: 17168
		// (get) Token: 0x0600E78F RID: 59279 RVA: 0x002240C8 File Offset: 0x002222C8
		public virtual List<int> WhoIds
		{
			get
			{
				if (this._WhoIdsInited)
				{
					return this._WhoIdsCache;
				}
				this._WhoIdsInited = true;
				int whoIdsLength = this.Instance.WhoIdsLength;
				this._WhoIdsCache = new List<int>(whoIdsLength);
				for (int i = 0; i < whoIdsLength; i++)
				{
					this._WhoIdsCache.Add(this.Instance.WhoIds(i));
				}
				return this._WhoIdsCache;
			}
		}

		// Token: 0x17004311 RID: 17169
		// (get) Token: 0x0600E790 RID: 59280 RVA: 0x0022412C File Offset: 0x0022232C
		public virtual bool? ResetCamera
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ResetCamera);
			}
		}

		// Token: 0x04007F88 RID: 32648
		private IPlayCustomSequence Instance;

		// Token: 0x04007F89 RID: 32649
		private List<int> _WhoIdsCache;

		// Token: 0x04007F8A RID: 32650
		private bool _WhoIdsInited;
	}
}
