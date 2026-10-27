using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A46 RID: 10822
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventFlyingFlowerUpdateSubtitle : IClientEventFlyingFlowerEvent
	{
		// Token: 0x0600EE3C RID: 60988 RVA: 0x0022B13D File Offset: 0x0022933D
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

		// Token: 0x17004B72 RID: 19314
		// (get) Token: 0x0600EE3D RID: 60989 RVA: 0x0022B15C File Offset: 0x0022935C
		public override EClientEventFlyingFlowerEventType Type
		{
			get
			{
				return (EClientEventFlyingFlowerEventType)this.Instance.Type;
			}
		}

		// Token: 0x17004B73 RID: 19315
		// (get) Token: 0x0600EE3E RID: 60990 RVA: 0x0022B169 File Offset: 0x00229369
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

		// Token: 0x04008318 RID: 33560
		private IClientEventFlyingFlowerUpdateSubtitle Instance;

		// Token: 0x04008319 RID: 33561
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x0400831A RID: 33562
		private bool _FlowInited;
	}
}
