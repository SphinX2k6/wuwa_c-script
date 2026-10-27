using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002620 RID: 9760
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroyEntity : ActionParams
	{
		// Token: 0x0600DB1C RID: 56092 RVA: 0x0020A205 File Offset: 0x00208405
		public static DestroyEntity Create(IDestroyEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x0600DB1D RID: 56093 RVA: 0x0020A224 File Offset: 0x00208424
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

		// Token: 0x1700409F RID: 16543
		// (get) Token: 0x0600DB1E RID: 56094 RVA: 0x0020A288 File Offset: 0x00208488
		public virtual bool? DelayDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DelayDestroy);
			}
		}

		// Token: 0x040079BE RID: 31166
		private IDestroyEntity Instance;

		// Token: 0x040079BF RID: 31167
		private List<int> _EntityIdsCache;

		// Token: 0x040079C0 RID: 31168
		private bool _EntityIdsInited;
	}
}
