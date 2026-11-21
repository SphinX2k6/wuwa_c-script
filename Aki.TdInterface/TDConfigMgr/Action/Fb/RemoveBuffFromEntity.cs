using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002934 RID: 10548
	public class RemoveBuffFromEntity : ActionParams
	{
		// Token: 0x0600EA71 RID: 60017 RVA: 0x00229797 File Offset: 0x00227997
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

		// Token: 0x170044B7 RID: 17591
		// (get) Token: 0x0600EA72 RID: 60018 RVA: 0x002297B8 File Offset: 0x002279B8
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

		// Token: 0x170044B8 RID: 17592
		// (get) Token: 0x0600EA73 RID: 60019 RVA: 0x002297F0 File Offset: 0x002279F0
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

		// Token: 0x170044B9 RID: 17593
		// (get) Token: 0x0600EA74 RID: 60020 RVA: 0x00229868 File Offset: 0x00227A68
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

		// Token: 0x04008136 RID: 33078
		private IRemoveBuffFromEntity Instance;

		// Token: 0x04008137 RID: 33079
		[Nullable(2)]
		private List<int> _EntityIdsCache;

		// Token: 0x04008138 RID: 33080
		private bool _EntityIdsInited;

		// Token: 0x04008139 RID: 33081
		private List<long> _BuffIdsCache;

		// Token: 0x0400813A RID: 33082
		private bool _BuffIdsInited;
	}
}
