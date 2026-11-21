using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001497 RID: 5271
	public class IBindCrossSceneSyncKillMonster
	{
		// Token: 0x060077BB RID: 30651 RVA: 0x0011F1D3 File Offset: 0x0011D3D3
		public static IBindCrossSceneSyncKillMonster Create(IBindCrossSceneSyncKillMonster? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBindCrossSceneSyncKillMonster
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x060077BC RID: 30652 RVA: 0x0011F1F4 File Offset: 0x0011D3F4
		public virtual List<int> EntityBundleIds
		{
			get
			{
				if (this._EntityBundleIdsInited)
				{
					return this._EntityBundleIdsCache;
				}
				this._EntityBundleIdsInited = true;
				int entityBundleIdsLength = this.Instance.EntityBundleIdsLength;
				this._EntityBundleIdsCache = new List<int>(entityBundleIdsLength);
				for (int i = 0; i < entityBundleIdsLength; i++)
				{
					this._EntityBundleIdsCache.Add(this.Instance.EntityBundleIds(i));
				}
				return this._EntityBundleIdsCache;
			}
		}

		// Token: 0x040044CB RID: 17611
		private IBindCrossSceneSyncKillMonster Instance;

		// Token: 0x040044CC RID: 17612
		private List<int> _EntityBundleIdsCache;

		// Token: 0x040044CD RID: 17613
		private bool _EntityBundleIdsInited;
	}
}
