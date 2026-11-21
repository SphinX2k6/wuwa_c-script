using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C95 RID: 3221
	[NullableContext(2)]
	[Nullable(0)]
	public class IOnDollGrabDeliveryPerform
	{
		// Token: 0x060049AE RID: 18862 RVA: 0x000B9B04 File Offset: 0x000B7D04
		[NullableContext(0)]
		public static IOnDollGrabDeliveryPerform Create(IOnDollGrabDeliveryPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnDollGrabDeliveryPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x060049AF RID: 18863 RVA: 0x000B9B23 File Offset: 0x000B7D23
		public virtual string EventMontage
		{
			get
			{
				return this.Instance.EventMontage;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x060049B0 RID: 18864 RVA: 0x000B9B30 File Offset: 0x000B7D30
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x060049B1 RID: 18865 RVA: 0x000B9B3D File Offset: 0x000B7D3D
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

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x060049B2 RID: 18866 RVA: 0x000B9B74 File Offset: 0x000B7D74
		public virtual float? PerformDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.PerformDuration);
			}
		}

		// Token: 0x040029B0 RID: 10672
		private IOnDollGrabDeliveryPerform Instance;

		// Token: 0x040029B1 RID: 10673
		private PlayFlow _FlowCache;

		// Token: 0x040029B2 RID: 10674
		private bool _FlowInited;
	}
}
