using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C7C RID: 3196
	public class IIgnoreEntityIdsCollision
	{
		// Token: 0x060048EF RID: 18671 RVA: 0x000B831D File Offset: 0x000B651D
		public static IIgnoreEntityIdsCollision Create(IIgnoreEntityIdsCollision? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IIgnoreEntityIdsCollision
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x000B833C File Offset: 0x000B653C
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

		// Token: 0x0400290B RID: 10507
		private IIgnoreEntityIdsCollision Instance;

		// Token: 0x0400290C RID: 10508
		private List<int> _EntityIdsCache;

		// Token: 0x0400290D RID: 10509
		private bool _EntityIdsInited;
	}
}
