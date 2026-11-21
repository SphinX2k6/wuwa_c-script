using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002910 RID: 10512
	public class AddBuffToPlayer : ActionParams
	{
		// Token: 0x0600E9BE RID: 59838 RVA: 0x002282C5 File Offset: 0x002264C5
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

		// Token: 0x1700444C RID: 17484
		// (get) Token: 0x0600E9BF RID: 59839 RVA: 0x002282E4 File Offset: 0x002264E4
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

		// Token: 0x1700444D RID: 17485
		// (get) Token: 0x0600E9C0 RID: 59840 RVA: 0x00228348 File Offset: 0x00226548
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

		// Token: 0x040080D8 RID: 32984
		private IAddBuffToPlayer Instance;

		// Token: 0x040080D9 RID: 32985
		private List<long> _BuffIdsCache;

		// Token: 0x040080DA RID: 32986
		private bool _BuffIdsInited;

		// Token: 0x040080DB RID: 32987
		[Nullable(2)]
		private List<long> _PersistOnDestroyBuffIdsCache;

		// Token: 0x040080DC RID: 32988
		private bool _PersistOnDestroyBuffIdsInited;
	}
}
