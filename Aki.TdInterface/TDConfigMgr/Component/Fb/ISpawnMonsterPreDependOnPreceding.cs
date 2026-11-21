using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C4D RID: 3149
	public class ISpawnMonsterPreDependOnPreceding : ISpawnMonsterPreConditonType
	{
		// Token: 0x06004817 RID: 18455 RVA: 0x000B6812 File Offset: 0x000B4A12
		public static ISpawnMonsterPreDependOnPreceding Create(ISpawnMonsterPreDependOnPreceding? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterPreDependOnPreceding
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x000B6831 File Offset: 0x000B4A31
		public override ESpawnMonsterPreCondition Type
		{
			get
			{
				return (ESpawnMonsterPreCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x000B6840 File Offset: 0x000B4A40
		public virtual List<int> Ids
		{
			get
			{
				if (this._IdsInited)
				{
					return this._IdsCache;
				}
				this._IdsInited = true;
				int idsLength = this.Instance.IdsLength;
				this._IdsCache = new List<int>(idsLength);
				for (int i = 0; i < idsLength; i++)
				{
					this._IdsCache.Add(this.Instance.Ids(i));
				}
				return this._IdsCache;
			}
		}

		// Token: 0x04002878 RID: 10360
		private ISpawnMonsterPreDependOnPreceding Instance;

		// Token: 0x04002879 RID: 10361
		private List<int> _IdsCache;

		// Token: 0x0400287A RID: 10362
		private bool _IdsInited;
	}
}
