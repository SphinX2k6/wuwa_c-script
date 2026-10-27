using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001347 RID: 4935
	[NullableContext(1)]
	[Nullable(0)]
	public class IBindCrossSceneSyncKillMonster
	{
		// Token: 0x0600711B RID: 28955 RVA: 0x00110C67 File Offset: 0x0010EE67
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

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x0600711C RID: 28956 RVA: 0x00110C88 File Offset: 0x0010EE88
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

		// Token: 0x0400414F RID: 16719
		private IBindCrossSceneSyncKillMonster Instance;

		// Token: 0x04004150 RID: 16720
		private List<int> _EntityBundleIdsCache;

		// Token: 0x04004151 RID: 16721
		private bool _EntityBundleIdsInited;
	}
}
