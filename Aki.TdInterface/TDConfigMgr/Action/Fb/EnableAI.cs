using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200273E RID: 10046
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableAI : ActionParams
	{
		// Token: 0x0600DFE4 RID: 57316 RVA: 0x002127BC File Offset: 0x002109BC
		public static EnableAI Create(IEnableAI? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableAI
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700432A RID: 17194
		// (get) Token: 0x0600DFE5 RID: 57317 RVA: 0x002127DC File Offset: 0x002109DC
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

		// Token: 0x1700432B RID: 17195
		// (get) Token: 0x0600DFE6 RID: 57318 RVA: 0x00212840 File Offset: 0x00210A40
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x04007C38 RID: 31800
		private IEnableAI Instance;

		// Token: 0x04007C39 RID: 31801
		private List<int> _EntityIdsCache;

		// Token: 0x04007C3A RID: 31802
		private bool _EntityIdsInited;
	}
}
