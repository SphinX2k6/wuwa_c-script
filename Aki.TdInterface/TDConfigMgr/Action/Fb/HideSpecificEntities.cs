using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278F RID: 10127
	[NullableContext(1)]
	[Nullable(0)]
	public class HideSpecificEntities : ActionParams
	{
		// Token: 0x0600E173 RID: 57715 RVA: 0x00215045 File Offset: 0x00213245
		public static HideSpecificEntities Create(IHideSpecificEntities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HideSpecificEntities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004417 RID: 17431
		// (get) Token: 0x0600E174 RID: 57716 RVA: 0x00215064 File Offset: 0x00213264
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

		// Token: 0x04007CFB RID: 31995
		private IHideSpecificEntities Instance;

		// Token: 0x04007CFC RID: 31996
		private List<int> _EntityIdsCache;

		// Token: 0x04007CFD RID: 31997
		private bool _EntityIdsInited;
	}
}
