using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002790 RID: 10128
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowSpecificEntities : ActionParams
	{
		// Token: 0x0600E176 RID: 57718 RVA: 0x002150D0 File Offset: 0x002132D0
		public static ShowSpecificEntities Create(IShowSpecificEntities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowSpecificEntities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004418 RID: 17432
		// (get) Token: 0x0600E177 RID: 57719 RVA: 0x002150F0 File Offset: 0x002132F0
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

		// Token: 0x17004419 RID: 17433
		// (get) Token: 0x0600E178 RID: 57720 RVA: 0x00215154 File Offset: 0x00213354
		public virtual bool DelayShow
		{
			get
			{
				return this.Instance.DelayShow;
			}
		}

		// Token: 0x04007CFE RID: 31998
		private IShowSpecificEntities Instance;

		// Token: 0x04007CFF RID: 31999
		private List<int> _EntityIdsCache;

		// Token: 0x04007D00 RID: 32000
		private bool _EntityIdsInited;
	}
}
