using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026D2 RID: 9938
	[NullableContext(1)]
	[Nullable(0)]
	public class AddBuffToTriggeredEntity : ActionParams
	{
		// Token: 0x0600DE29 RID: 56873 RVA: 0x0020F88F File Offset: 0x0020DA8F
		public static AddBuffToTriggeredEntity Create(IAddBuffToTriggeredEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddBuffToTriggeredEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004247 RID: 16967
		// (get) Token: 0x0600DE2A RID: 56874 RVA: 0x0020F8B0 File Offset: 0x0020DAB0
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

		// Token: 0x04007B56 RID: 31574
		private IAddBuffToTriggeredEntity Instance;

		// Token: 0x04007B57 RID: 31575
		private List<long> _BuffIdsCache;

		// Token: 0x04007B58 RID: 31576
		private bool _BuffIdsInited;
	}
}
