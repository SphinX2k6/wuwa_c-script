using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002645 RID: 9797
	[NullableContext(1)]
	[Nullable(0)]
	public class SetEntityClientVisibleSave : ActionParams
	{
		// Token: 0x0600DBCA RID: 56266 RVA: 0x0020B5FD File Offset: 0x002097FD
		public static SetEntityClientVisibleSave Create(ISetEntityClientVisibleSave? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetEntityClientVisibleSave
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x0600DBCB RID: 56267 RVA: 0x0020B61C File Offset: 0x0020981C
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

		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x0600DBCC RID: 56268 RVA: 0x0020B680 File Offset: 0x00209880
		public virtual bool Visible
		{
			get
			{
				return this.Instance.Visible;
			}
		}

		// Token: 0x04007A23 RID: 31267
		private ISetEntityClientVisibleSave Instance;

		// Token: 0x04007A24 RID: 31268
		private List<int> _EntityIdsCache;

		// Token: 0x04007A25 RID: 31269
		private bool _EntityIdsInited;
	}
}
