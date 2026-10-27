using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024D9 RID: 9433
	[NullableContext(1)]
	[Nullable(0)]
	public class ClearEntityVisibleTag : ActionParams
	{
		// Token: 0x0600D2A6 RID: 53926 RVA: 0x001F3F8A File Offset: 0x001F218A
		public static ClearEntityVisibleTag Create(IClearEntityVisibleTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClearEntityVisibleTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x0600D2A7 RID: 53927 RVA: 0x001F3FAC File Offset: 0x001F21AC
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

		// Token: 0x04007387 RID: 29575
		private IClearEntityVisibleTag Instance;

		// Token: 0x04007388 RID: 29576
		private List<int> _EntityIdsCache;

		// Token: 0x04007389 RID: 29577
		private bool _EntityIdsInited;
	}
}
