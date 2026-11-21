using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5E RID: 10846
	public class IHideSpecifyEntity : IHideRangeType
	{
		// Token: 0x0600EF83 RID: 61315 RVA: 0x00231BD1 File Offset: 0x0022FDD1
		public static IHideSpecifyEntity Create(IHideSpecifyEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004775 RID: 18293
		// (get) Token: 0x0600EF84 RID: 61316 RVA: 0x00231BF0 File Offset: 0x0022FDF0
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x17004776 RID: 18294
		// (get) Token: 0x0600EF85 RID: 61317 RVA: 0x00231C00 File Offset: 0x0022FE00
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

		// Token: 0x040083A8 RID: 33704
		private IHideSpecifyEntity Instance;

		// Token: 0x040083A9 RID: 33705
		private List<int> _EntityIdsCache;

		// Token: 0x040083AA RID: 33706
		private bool _EntityIdsInited;
	}
}
