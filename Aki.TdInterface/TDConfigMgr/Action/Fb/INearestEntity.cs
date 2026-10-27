using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026B7 RID: 9911
	[NullableContext(1)]
	[Nullable(0)]
	public class INearestEntity : ITeleportConfig
	{
		// Token: 0x0600DDBB RID: 56763 RVA: 0x0020EC7A File Offset: 0x0020CE7A
		public static INearestEntity Create(INearestEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INearestEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x0600DDBC RID: 56764 RVA: 0x0020EC99 File Offset: 0x0020CE99
		public override ETeleportType Type
		{
			get
			{
				return (ETeleportType)this.Instance.Type;
			}
		}

		// Token: 0x17004210 RID: 16912
		// (get) Token: 0x0600DDBD RID: 56765 RVA: 0x0020ECA8 File Offset: 0x0020CEA8
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

		// Token: 0x04007B1B RID: 31515
		private INearestEntity Instance;

		// Token: 0x04007B1C RID: 31516
		private List<int> _EntityIdsCache;

		// Token: 0x04007B1D RID: 31517
		private bool _EntityIdsInited;
	}
}
