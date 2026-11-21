using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290F RID: 10511
	[NullableContext(2)]
	[Nullable(0)]
	public class AddBuffToEntity : ActionParams
	{
		// Token: 0x0600E9B8 RID: 59832 RVA: 0x00228113 File Offset: 0x00226313
		[NullableContext(0)]
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

		// Token: 0x17004448 RID: 17480
		// (get) Token: 0x0600E9B9 RID: 59833 RVA: 0x00228134 File Offset: 0x00226334
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

		// Token: 0x17004449 RID: 17481
		// (get) Token: 0x0600E9BA RID: 59834 RVA: 0x0022816C File Offset: 0x0022636C
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

		// Token: 0x1700444A RID: 17482
		// (get) Token: 0x0600E9BB RID: 59835 RVA: 0x002281E4 File Offset: 0x002263E4
		[Nullable(0)]
		public virtual List<long> BuffIds
		{
			[NullableContext(0)]
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

		// Token: 0x1700444B RID: 17483
		// (get) Token: 0x0600E9BC RID: 59836 RVA: 0x00228248 File Offset: 0x00226448
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

		// Token: 0x040080D1 RID: 32977
		private IAddBuffToEntity Instance;

		// Token: 0x040080D2 RID: 32978
		private List<int> _EntityIdsCache;

		// Token: 0x040080D3 RID: 32979
		private bool _EntityIdsInited;

		// Token: 0x040080D4 RID: 32980
		[Nullable(0)]
		private List<long> _BuffIdsCache;

		// Token: 0x040080D5 RID: 32981
		private bool _BuffIdsInited;

		// Token: 0x040080D6 RID: 32982
		private List<long> _PersistOnOfflineBuffIdsCache;

		// Token: 0x040080D7 RID: 32983
		private bool _PersistOnOfflineBuffIdsInited;
	}
}
