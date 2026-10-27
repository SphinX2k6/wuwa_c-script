using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002675 RID: 9845
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveBuffFromEntity : ActionParams
	{
		// Token: 0x0600DCA5 RID: 56485 RVA: 0x0020D087 File Offset: 0x0020B287
		public static RemoveBuffFromEntity Create(IRemoveBuffFromEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveBuffFromEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700417D RID: 16765
		// (get) Token: 0x0600DCA6 RID: 56486 RVA: 0x0020D0A8 File Offset: 0x0020B2A8
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

		// Token: 0x1700417E RID: 16766
		// (get) Token: 0x0600DCA7 RID: 56487 RVA: 0x0020D0E0 File Offset: 0x0020B2E0
		[Nullable(2)]
		public virtual List<int> EntityIds
		{
			[NullableContext(2)]
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

		// Token: 0x1700417F RID: 16767
		// (get) Token: 0x0600DCA8 RID: 56488 RVA: 0x0020D158 File Offset: 0x0020B358
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

		// Token: 0x04007A9F RID: 31391
		private IRemoveBuffFromEntity Instance;

		// Token: 0x04007AA0 RID: 31392
		[Nullable(2)]
		private List<int> _EntityIdsCache;

		// Token: 0x04007AA1 RID: 31393
		private bool _EntityIdsInited;

		// Token: 0x04007AA2 RID: 31394
		private List<long> _BuffIdsCache;

		// Token: 0x04007AA3 RID: 31395
		private bool _BuffIdsInited;
	}
}
