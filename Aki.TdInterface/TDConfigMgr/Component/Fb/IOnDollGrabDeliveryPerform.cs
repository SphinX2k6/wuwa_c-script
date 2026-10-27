using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC7 RID: 3015
	[NullableContext(2)]
	[Nullable(0)]
	public class IOnDollGrabDeliveryPerform
	{
		// Token: 0x06004555 RID: 17749 RVA: 0x000AFA40 File Offset: 0x000ADC40
		[NullableContext(1)]
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

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06004556 RID: 17750 RVA: 0x000AFA5F File Offset: 0x000ADC5F
		public virtual string EventMontage
		{
			get
			{
				return this.Instance.EventMontage;
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06004557 RID: 17751 RVA: 0x000AFA6C File Offset: 0x000ADC6C
		public virtual string StandByMontage
		{
			get
			{
				return this.Instance.StandByMontage;
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06004558 RID: 17752 RVA: 0x000AFA79 File Offset: 0x000ADC79
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

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06004559 RID: 17753 RVA: 0x000AFAB0 File Offset: 0x000ADCB0
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

		// Token: 0x04002768 RID: 10088
		private IOnDollGrabDeliveryPerform Instance;

		// Token: 0x04002769 RID: 10089
		private PlayFlow _FlowCache;

		// Token: 0x0400276A RID: 10090
		private bool _FlowInited;
	}
}
