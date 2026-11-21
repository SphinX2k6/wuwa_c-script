using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001445 RID: 5189
	public class IDisableUro : ILogicProgramSpecialProcessOperation
	{
		// Token: 0x06007557 RID: 30039 RVA: 0x00119BC7 File Offset: 0x00117DC7
		public static IDisableUro Create(IDisableUro? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableUro
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x06007558 RID: 30040 RVA: 0x00119BE6 File Offset: 0x00117DE6
		public override ELogicProgramSpecialProcess Type
		{
			get
			{
				return (ELogicProgramSpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x06007559 RID: 30041 RVA: 0x00119BF4 File Offset: 0x00117DF4
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

		// Token: 0x040042F1 RID: 17137
		private IDisableUro Instance;

		// Token: 0x040042F2 RID: 17138
		private List<int> _EntityIdsCache;

		// Token: 0x040042F3 RID: 17139
		private bool _EntityIdsInited;
	}
}
