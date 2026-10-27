using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200264C RID: 9804
	[NullableContext(1)]
	[Nullable(0)]
	public class AddBuffToPlayer : ActionParams
	{
		// Token: 0x0600DBE2 RID: 56290 RVA: 0x0020B9ED File Offset: 0x00209BED
		public static AddBuffToPlayer Create(IAddBuffToPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddBuffToPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x0600DBE3 RID: 56291 RVA: 0x0020BA0C File Offset: 0x00209C0C
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

		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x0600DBE4 RID: 56292 RVA: 0x0020BA70 File Offset: 0x00209C70
		[Nullable(2)]
		public virtual List<long> PersistOnDestroyBuffIds
		{
			[NullableContext(2)]
			get
			{
				if (this._PersistOnDestroyBuffIdsInited)
				{
					return this._PersistOnDestroyBuffIdsCache;
				}
				this._PersistOnDestroyBuffIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int persistOnDestroyBuffIdsLength = this.Instance.PersistOnDestroyBuffIdsLength;
				this._PersistOnDestroyBuffIdsCache = new List<long>(persistOnDestroyBuffIdsLength);
				for (int i = 0; i < persistOnDestroyBuffIdsLength; i++)
				{
					this._PersistOnDestroyBuffIdsCache.Add(this.Instance.PersistOnDestroyBuffIds(i));
				}
				return this._PersistOnDestroyBuffIdsCache;
			}
		}

		// Token: 0x04007A36 RID: 31286
		private IAddBuffToPlayer Instance;

		// Token: 0x04007A37 RID: 31287
		private List<long> _BuffIdsCache;

		// Token: 0x04007A38 RID: 31288
		private bool _BuffIdsInited;

		// Token: 0x04007A39 RID: 31289
		[Nullable(2)]
		private List<long> _PersistOnDestroyBuffIdsCache;

		// Token: 0x04007A3A RID: 31290
		private bool _PersistOnDestroyBuffIdsInited;
	}
}
