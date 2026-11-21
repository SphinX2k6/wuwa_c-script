using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A66 RID: 10854
	public class IHideSpecifyEntityGroup : IHideGroupType
	{
		// Token: 0x0600EFA7 RID: 61351 RVA: 0x00232241 File Offset: 0x00230441
		public static IHideSpecifyEntityGroup Create(IHideSpecifyEntityGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyEntityGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004789 RID: 18313
		// (get) Token: 0x0600EFA8 RID: 61352 RVA: 0x00232260 File Offset: 0x00230460
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x1700478A RID: 18314
		// (get) Token: 0x0600EFA9 RID: 61353 RVA: 0x00232270 File Offset: 0x00230470
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

		// Token: 0x1700478B RID: 18315
		// (get) Token: 0x0600EFAA RID: 61354 RVA: 0x002322D4 File Offset: 0x002304D4
		public virtual bool? ForceClean
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ForceClean);
			}
		}

		// Token: 0x040083C6 RID: 33734
		private IHideSpecifyEntityGroup Instance;

		// Token: 0x040083C7 RID: 33735
		private List<int> _EntityIdsCache;

		// Token: 0x040083C8 RID: 33736
		private bool _EntityIdsInited;
	}
}
