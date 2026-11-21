using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBA RID: 3002
	public class EntityGroupComponent : IComponentBase
	{
		// Token: 0x06004499 RID: 17561 RVA: 0x000ADCF8 File Offset: 0x000ABEF8
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

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x0600449A RID: 17562 RVA: 0x000ADD18 File Offset: 0x000ABF18
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

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x000ADD50 File Offset: 0x000ABF50
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x0600449C RID: 17564 RVA: 0x000ADD68 File Offset: 0x000ABF68
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

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x0600449D RID: 17565 RVA: 0x000ADDCC File Offset: 0x000ABFCC
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

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x0600449E RID: 17566 RVA: 0x000ADE35 File Offset: 0x000AC035
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

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x0600449F RID: 17567 RVA: 0x000ADE69 File Offset: 0x000AC069
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

		// Token: 0x04002601 RID: 9729
		private IEntityGroupComponent Instance;

		// Token: 0x04002602 RID: 9730
		private List<int> _EntityIdsCache;

		// Token: 0x04002603 RID: 9731
		private bool _EntityIdsInited;

		// Token: 0x04002604 RID: 9732
		private List<IEntityStateTrigger> _StateTriggersCache;

		// Token: 0x04002605 RID: 9733
		private bool _StateTriggersInited;

		// Token: 0x04002606 RID: 9734
		[Nullable(2)]
		private IFinishStateTrigger _FinishStateCache;

		// Token: 0x04002607 RID: 9735
		private bool _FinishStateInited;

		// Token: 0x04002608 RID: 9736
		[Nullable(2)]
		private IFailureStateTrigger _FailureStateCache;

		// Token: 0x04002609 RID: 9737
		private bool _FailureStateInited;
	}
}
