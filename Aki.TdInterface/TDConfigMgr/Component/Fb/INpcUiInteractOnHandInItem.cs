using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBD RID: 3005
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnHandInItem : INpcUiInteractType
	{
		// Token: 0x060044E3 RID: 17635 RVA: 0x000AEC1A File Offset: 0x000ACE1A
		public static INpcUiInteractOnHandInItem Create(INpcUiInteractOnHandInItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnHandInItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x000AEC39 File Offset: 0x000ACE39
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x000AEC46 File Offset: 0x000ACE46
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x000AEC53 File Offset: 0x000ACE53
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x000AEC60 File Offset: 0x000ACE60
		public virtual string HandInFailedMontage
		{
			get
			{
				return this.Instance.HandInFailedMontage;
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x000AEC6D File Offset: 0x000ACE6D
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

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x060044E9 RID: 17641 RVA: 0x000AECA1 File Offset: 0x000ACEA1
		[Nullable(2)]
		public virtual PlayFlow HandInFailedFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._HandInFailedFlowInited)
				{
					return this._HandInFailedFlowCache;
				}
				this._HandInFailedFlowInited = true;
				this._HandInFailedFlowCache = PlayFlow.Create(this.Instance.HandInFailedFlow);
				return this._HandInFailedFlowCache;
			}
		}

		// Token: 0x040026F6 RID: 9974
		private INpcUiInteractOnHandInItem Instance;

		// Token: 0x040026F7 RID: 9975
		[Nullable(2)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x040026F8 RID: 9976
		private bool _EnterFlowInited;

		// Token: 0x040026F9 RID: 9977
		[Nullable(2)]
		private PlayFlow _HandInFailedFlowCache;

		// Token: 0x040026FA RID: 9978
		private bool _HandInFailedFlowInited;
	}
}
