using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8B RID: 3211
	public class INpcUiInteractOnHandInItem : INpcUiInteractType
	{
		// Token: 0x0600493C RID: 18748 RVA: 0x000B8CDE File Offset: 0x000B6EDE
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

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x0600493D RID: 18749 RVA: 0x000B8CFD File Offset: 0x000B6EFD
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x0600493E RID: 18750 RVA: 0x000B8D0A File Offset: 0x000B6F0A
		public virtual string EnterMontage
		{
			get
			{
				return this.Instance.EnterMontage;
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x0600493F RID: 18751 RVA: 0x000B8D17 File Offset: 0x000B6F17
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06004940 RID: 18752 RVA: 0x000B8D24 File Offset: 0x000B6F24
		public virtual string HandInFailedMontage
		{
			get
			{
				return this.Instance.HandInFailedMontage;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06004941 RID: 18753 RVA: 0x000B8D31 File Offset: 0x000B6F31
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

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06004942 RID: 18754 RVA: 0x000B8D65 File Offset: 0x000B6F65
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

		// Token: 0x0400293E RID: 10558
		private INpcUiInteractOnHandInItem Instance;

		// Token: 0x0400293F RID: 10559
		[Nullable(2)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x04002940 RID: 10560
		private bool _EnterFlowInited;

		// Token: 0x04002941 RID: 10561
		[Nullable(2)]
		private PlayFlow _HandInFailedFlowCache;

		// Token: 0x04002942 RID: 10562
		private bool _HandInFailedFlowInited;
	}
}
