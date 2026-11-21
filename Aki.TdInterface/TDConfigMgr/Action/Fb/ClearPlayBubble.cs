using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E0 RID: 10720
	public class ClearPlayBubble : ActionParams
	{
		// Token: 0x0600ED33 RID: 60723 RVA: 0x0022E102 File Offset: 0x0022C302
		public static ClearPlayBubble Create(IClearPlayBubble? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClearPlayBubble
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004621 RID: 17953
		// (get) Token: 0x0600ED34 RID: 60724 RVA: 0x0022E124 File Offset: 0x0022C324
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17004622 RID: 17954
		// (get) Token: 0x0600ED35 RID: 60725 RVA: 0x0022E188 File Offset: 0x0022C388
		public virtual bool? OnlyClearRedDot
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.OnlyClearRedDot);
			}
		}

		// Token: 0x0400828E RID: 33422
		private IClearPlayBubble Instance;

		// Token: 0x0400828F RID: 33423
		private List<int> _EntityIdsCache;

		// Token: 0x04008290 RID: 33424
		private bool _EntityIdsInited;
	}
}
