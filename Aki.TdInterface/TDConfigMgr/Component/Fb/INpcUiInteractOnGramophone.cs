using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8F RID: 3215
	public class INpcUiInteractOnGramophone : INpcUiInteractType
	{
		// Token: 0x06004968 RID: 18792 RVA: 0x000B91DE File Offset: 0x000B73DE
		public static INpcUiInteractOnGramophone Create(INpcUiInteractOnGramophone? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnGramophone
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06004969 RID: 18793 RVA: 0x000B91FD File Offset: 0x000B73FD
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x0600496A RID: 18794 RVA: 0x000B920A File Offset: 0x000B740A
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x0600496B RID: 18795 RVA: 0x000B9217 File Offset: 0x000B7417
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x0600496C RID: 18796 RVA: 0x000B9224 File Offset: 0x000B7424
		public virtual string SwitchMusicMontage
		{
			get
			{
				return this.Instance.SwitchMusicMontage;
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x000B9231 File Offset: 0x000B7431
		public virtual string ExitMontage
		{
			get
			{
				return this.Instance.ExitMontage;
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600496E RID: 18798 RVA: 0x000B923E File Offset: 0x000B743E
		[Nullable(2)]
		public virtual PlayFlow EnterFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._EnterFlowInited)
				{
					return this._EnterFlowCache;
				}
				this._EnterFlowInited = true;
				this._EnterFlowCache = PlayFlow.Create(this.Instance.EnterFlow);
				return this._EnterFlowCache;
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x0600496F RID: 18799 RVA: 0x000B9272 File Offset: 0x000B7472
		[Nullable(2)]
		public virtual PlayFlow FailedFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._FailedFlowInited)
				{
					return this._FailedFlowCache;
				}
				this._FailedFlowInited = true;
				this._FailedFlowCache = PlayFlow.Create(this.Instance.FailedFlow);
				return this._FailedFlowCache;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06004970 RID: 18800 RVA: 0x000B92A6 File Offset: 0x000B74A6
		[Nullable(2)]
		public virtual PlayFlow SuccessFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._SuccessFlowInited)
				{
					return this._SuccessFlowCache;
				}
				this._SuccessFlowInited = true;
				this._SuccessFlowCache = PlayFlow.Create(this.Instance.SuccessFlow);
				return this._SuccessFlowCache;
			}
		}

		// Token: 0x04002962 RID: 10594
		private INpcUiInteractOnGramophone Instance;

		// Token: 0x04002963 RID: 10595
		[Nullable(2)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x04002964 RID: 10596
		private bool _EnterFlowInited;

		// Token: 0x04002965 RID: 10597
		[Nullable(2)]
		private PlayFlow _FailedFlowCache;

		// Token: 0x04002966 RID: 10598
		private bool _FailedFlowInited;

		// Token: 0x04002967 RID: 10599
		[Nullable(2)]
		private PlayFlow _SuccessFlowCache;

		// Token: 0x04002968 RID: 10600
		private bool _SuccessFlowInited;
	}
}
