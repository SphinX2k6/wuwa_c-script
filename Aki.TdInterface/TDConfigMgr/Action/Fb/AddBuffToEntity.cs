using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200264B RID: 9803
	[NullableContext(2)]
	[Nullable(0)]
	public class AddBuffToEntity : ActionParams
	{
		// Token: 0x0600DBDC RID: 56284 RVA: 0x0020B83B File Offset: 0x00209A3B
		[NullableContext(1)]
		public static AddBuffToEntity Create(IAddBuffToEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddBuffToEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x0600DBDD RID: 56285 RVA: 0x0020B85C File Offset: 0x00209A5C
		public virtual int? EntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EntityId);
			}
		}

		// Token: 0x17004109 RID: 16649
		// (get) Token: 0x0600DBDE RID: 56286 RVA: 0x0020B894 File Offset: 0x00209A94
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x1700410A RID: 16650
		// (get) Token: 0x0600DBDF RID: 56287 RVA: 0x0020B90C File Offset: 0x00209B0C
		[Nullable(1)]
		public virtual List<long> BuffIds
		{
			[NullableContext(1)]
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

		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x0600DBE0 RID: 56288 RVA: 0x0020B970 File Offset: 0x00209B70
		public virtual List<long> PersistOnOfflineBuffIds
		{
			get
			{
				if (this._PersistOnOfflineBuffIdsInited)
				{
					return this._PersistOnOfflineBuffIdsCache;
				}
				this._PersistOnOfflineBuffIdsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int persistOnOfflineBuffIdsLength = this.Instance.PersistOnOfflineBuffIdsLength;
				this._PersistOnOfflineBuffIdsCache = new List<long>(persistOnOfflineBuffIdsLength);
				for (int i = 0; i < persistOnOfflineBuffIdsLength; i++)
				{
					this._PersistOnOfflineBuffIdsCache.Add(this.Instance.PersistOnOfflineBuffIds(i));
				}
				return this._PersistOnOfflineBuffIdsCache;
			}
		}

		// Token: 0x04007A2F RID: 31279
		private IAddBuffToEntity Instance;

		// Token: 0x04007A30 RID: 31280
		private List<int> _EntityIdsCache;

		// Token: 0x04007A31 RID: 31281
		private bool _EntityIdsInited;

		// Token: 0x04007A32 RID: 31282
		[Nullable(1)]
		private List<long> _BuffIdsCache;

		// Token: 0x04007A33 RID: 31283
		private bool _BuffIdsInited;

		// Token: 0x04007A34 RID: 31284
		private List<long> _PersistOnOfflineBuffIdsCache;

		// Token: 0x04007A35 RID: 31285
		private bool _PersistOnOfflineBuffIdsInited;
	}
}
