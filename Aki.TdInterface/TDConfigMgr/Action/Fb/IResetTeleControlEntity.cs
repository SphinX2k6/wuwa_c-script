using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C65 RID: 11365
	public class IResetTeleControlEntity : IResetEntityConfig
	{
		// Token: 0x0600F9D4 RID: 63956 RVA: 0x0024449E File Offset: 0x0024269E
		public static IResetTeleControlEntity Create(IResetTeleControlEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetTeleControlEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DB8 RID: 19896
		// (get) Token: 0x0600F9D5 RID: 63957 RVA: 0x002444BD File Offset: 0x002426BD
		public override EResetEntityType Type
		{
			get
			{
				return (EResetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004DB9 RID: 19897
		// (get) Token: 0x0600F9D6 RID: 63958 RVA: 0x002444CC File Offset: 0x002426CC
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

		// Token: 0x0400887F RID: 34943
		private IResetTeleControlEntity Instance;

		// Token: 0x04008880 RID: 34944
		private List<int> _EntityIdsCache;

		// Token: 0x04008881 RID: 34945
		private bool _EntityIdsInited;
	}
}
