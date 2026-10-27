using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC1 RID: 3009
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnGramophone : INpcUiInteractType
	{
		// Token: 0x0600450F RID: 17679 RVA: 0x000AF11A File Offset: 0x000AD31A
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

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06004510 RID: 17680 RVA: 0x000AF139 File Offset: 0x000AD339
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06004511 RID: 17681 RVA: 0x000AF146 File Offset: 0x000AD346
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06004512 RID: 17682 RVA: 0x000AF153 File Offset: 0x000AD353
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06004513 RID: 17683 RVA: 0x000AF160 File Offset: 0x000AD360
		public virtual string SwitchMusicMontage
		{
			get
			{
				return this.Instance.SwitchMusicMontage;
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06004514 RID: 17684 RVA: 0x000AF16D File Offset: 0x000AD36D
		public virtual string ExitMontage
		{
			get
			{
				return this.Instance.ExitMontage;
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06004515 RID: 17685 RVA: 0x000AF17A File Offset: 0x000AD37A
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

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06004516 RID: 17686 RVA: 0x000AF1AE File Offset: 0x000AD3AE
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

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06004517 RID: 17687 RVA: 0x000AF1E2 File Offset: 0x000AD3E2
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

		// Token: 0x0400271A RID: 10010
		private INpcUiInteractOnGramophone Instance;

		// Token: 0x0400271B RID: 10011
		[Nullable(2)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x0400271C RID: 10012
		private bool _EnterFlowInited;

		// Token: 0x0400271D RID: 10013
		[Nullable(2)]
		private PlayFlow _FailedFlowCache;

		// Token: 0x0400271E RID: 10014
		private bool _FailedFlowInited;

		// Token: 0x0400271F RID: 10015
		[Nullable(2)]
		private PlayFlow _SuccessFlowCache;

		// Token: 0x04002720 RID: 10016
		private bool _SuccessFlowInited;
	}
}
