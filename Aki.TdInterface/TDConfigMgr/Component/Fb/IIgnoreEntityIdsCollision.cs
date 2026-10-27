using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAE RID: 2990
	[NullableContext(1)]
	[Nullable(0)]
	public class IIgnoreEntityIdsCollision
	{
		// Token: 0x06004496 RID: 17558 RVA: 0x000AE259 File Offset: 0x000AC459
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

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x000AE278 File Offset: 0x000AC478
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

		// Token: 0x040026C3 RID: 9923
		private IIgnoreEntityIdsCollision Instance;

		// Token: 0x040026C4 RID: 9924
		private List<int> _EntityIdsCache;

		// Token: 0x040026C5 RID: 9925
		private bool _EntityIdsInited;
	}
}
