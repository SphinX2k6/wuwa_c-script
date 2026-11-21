using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D33 RID: 11571
	public class IClientEventFlyingFlowerUpdateSubtitle : IClientEventFlyingFlowerEvent
	{
		// Token: 0x0600FCD4 RID: 64724 RVA: 0x00248AF1 File Offset: 0x00246CF1
		public static IClientEventFlyingFlowerUpdateSubtitle Create(IClientEventFlyingFlowerUpdateSubtitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventFlyingFlowerUpdateSubtitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F1C RID: 20252
		// (get) Token: 0x0600FCD5 RID: 64725 RVA: 0x00248B10 File Offset: 0x00246D10
		public override EClientEventFlyingFlowerEventType Type
		{
			get
			{
				return (EClientEventFlyingFlowerEventType)this.Instance.Type;
			}
		}

		// Token: 0x17004F1D RID: 20253
		// (get) Token: 0x0600FCD6 RID: 64726 RVA: 0x00248B1D File Offset: 0x00246D1D
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = PlayFlow.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x04008A0B RID: 35339
		private IClientEventFlyingFlowerUpdateSubtitle Instance;

		// Token: 0x04008A0C RID: 35340
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04008A0D RID: 35341
		private bool _FlowInited;
	}
}
