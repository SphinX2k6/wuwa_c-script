using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AEF RID: 2799
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityGroupComponent : IComponentBase
	{
		// Token: 0x0600406A RID: 16490 RVA: 0x000A46C4 File Offset: 0x000A28C4
		public static EntityGroupComponent Create(IEntityGroupComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityGroupComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x000A46E4 File Offset: 0x000A28E4
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x000A471C File Offset: 0x000A291C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x000A4734 File Offset: 0x000A2934
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

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x000A4798 File Offset: 0x000A2998
		public virtual List<IEntityStateTrigger> StateTriggers
		{
			get
			{
				if (this._StateTriggersInited)
				{
					return this._StateTriggersCache;
				}
				this._StateTriggersInited = true;
				int stateTriggersLength = this.Instance.StateTriggersLength;
				this._StateTriggersCache = new List<IEntityStateTrigger>(stateTriggersLength);
				for (int i = 0; i < stateTriggersLength; i++)
				{
					this._StateTriggersCache.Add(IEntityStateTrigger.Create(this.Instance.StateTriggers(i)));
				}
				return this._StateTriggersCache;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x000A4801 File Offset: 0x000A2A01
		public virtual IFinishStateTrigger FinishState
		{
			get
			{
				if (this._FinishStateInited)
				{
					return this._FinishStateCache;
				}
				this._FinishStateInited = true;
				this._FinishStateCache = IFinishStateTrigger.Create(this.Instance.FinishState);
				return this._FinishStateCache;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06004070 RID: 16496 RVA: 0x000A4835 File Offset: 0x000A2A35
		[Nullable(2)]
		public virtual IFailureStateTrigger FailureState
		{
			[NullableContext(2)]
			get
			{
				if (this._FailureStateInited)
				{
					return this._FailureStateCache;
				}
				this._FailureStateInited = true;
				this._FailureStateCache = IFailureStateTrigger.Create(this.Instance.FailureState);
				return this._FailureStateCache;
			}
		}

		// Token: 0x040023E4 RID: 9188
		private IEntityGroupComponent Instance;

		// Token: 0x040023E5 RID: 9189
		private List<int> _EntityIdsCache;

		// Token: 0x040023E6 RID: 9190
		private bool _EntityIdsInited;

		// Token: 0x040023E7 RID: 9191
		private List<IEntityStateTrigger> _StateTriggersCache;

		// Token: 0x040023E8 RID: 9192
		private bool _StateTriggersInited;

		// Token: 0x040023E9 RID: 9193
		[Nullable(2)]
		private IFinishStateTrigger _FinishStateCache;

		// Token: 0x040023EA RID: 9194
		private bool _FinishStateInited;

		// Token: 0x040023EB RID: 9195
		[Nullable(2)]
		private IFailureStateTrigger _FailureStateCache;

		// Token: 0x040023EC RID: 9196
		private bool _FailureStateInited;
	}
}
