using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026D3 RID: 9939
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveBuffToTriggeredEntity : ActionParams
	{
		// Token: 0x0600DE2C RID: 56876 RVA: 0x0020F91C File Offset: 0x0020DB1C
		public static RemoveBuffToTriggeredEntity Create(IRemoveBuffToTriggeredEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveBuffToTriggeredEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004248 RID: 16968
		// (get) Token: 0x0600DE2D RID: 56877 RVA: 0x0020F93C File Offset: 0x0020DB3C
		public virtual List<long> BuffIds
		{
			get
			{
				if (this._BuffIdsInited)
				{
					return this._BuffIdsCache;
				}
				this._BuffIdsInited = true;
				int buffIdsLength = this.Instance.BuffIdsLength;
				this._BuffIdsCache = new List<long>(buffIdsLength);
				for (int i = 0; i < buffIdsLength; i++)
				{
					this._BuffIdsCache.Add(this.Instance.BuffIds(i));
				}
				return this._BuffIdsCache;
			}
		}

		// Token: 0x04007B59 RID: 31577
		private IRemoveBuffToTriggeredEntity Instance;

		// Token: 0x04007B5A RID: 31578
		private List<long> _BuffIdsCache;

		// Token: 0x04007B5B RID: 31579
		private bool _BuffIdsInited;
	}
}
