using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E0 RID: 10464
	public class DestroyEntity : ActionParams
	{
		// Token: 0x0600E8EA RID: 59626 RVA: 0x002269D1 File Offset: 0x00224BD1
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

		// Token: 0x170043D8 RID: 17368
		// (get) Token: 0x0600E8EB RID: 59627 RVA: 0x002269F0 File Offset: 0x00224BF0
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

		// Token: 0x170043D9 RID: 17369
		// (get) Token: 0x0600E8EC RID: 59628 RVA: 0x00226A54 File Offset: 0x00224C54
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

		// Token: 0x0400805A RID: 32858
		private IDestroyEntity Instance;

		// Token: 0x0400805B RID: 32859
		private List<int> _EntityIdsCache;

		// Token: 0x0400805C RID: 32860
		private bool _EntityIdsInited;
	}
}
