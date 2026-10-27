using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002691 RID: 9873
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithCenterText : ITeleportTransitionType
	{
		// Token: 0x0600DD0D RID: 56589 RVA: 0x0020DB43 File Offset: 0x0020BD43
		public static ITeleportTransitionWithCenterText Create(ITeleportTransitionWithCenterText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCenterText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041AD RID: 16813
		// (get) Token: 0x0600DD0E RID: 56590 RVA: 0x0020DB62 File Offset: 0x0020BD62
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x0600DD0F RID: 56591 RVA: 0x0020DB6F File Offset: 0x0020BD6F
		public virtual PlayFlow CenterTextFlow
		{
			get
			{
				if (this._CenterTextFlowInited)
				{
					return this._CenterTextFlowCache;
				}
				this._CenterTextFlowInited = true;
				this._CenterTextFlowCache = PlayFlow.Create(this.Instance.CenterTextFlow);
				return this._CenterTextFlowCache;
			}
		}

		// Token: 0x04007AC9 RID: 31433
		private ITeleportTransitionWithCenterText Instance;

		// Token: 0x04007ACA RID: 31434
		[Nullable(2)]
		private PlayFlow _CenterTextFlowCache;

		// Token: 0x04007ACB RID: 31435
		private bool _CenterTextFlowInited;
	}
}
