using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B4D RID: 11085
	public class ITuningStandBubbleConfig
	{
		// Token: 0x0600F3B2 RID: 62386 RVA: 0x00238CF1 File Offset: 0x00236EF1
		public static ITuningStandBubbleConfig Create(ITuningStandBubbleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITuningStandBubbleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049C6 RID: 18886
		// (get) Token: 0x0600F3B3 RID: 62387 RVA: 0x00238D10 File Offset: 0x00236F10
		public virtual ETuningStandBubbleTriggerType TriggerType
		{
			get
			{
				return (ETuningStandBubbleTriggerType)this.Instance.TriggerType;
			}
		}

		// Token: 0x170049C7 RID: 18887
		// (get) Token: 0x0600F3B4 RID: 62388 RVA: 0x00238D1D File Offset: 0x00236F1D
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

		// Token: 0x040085A7 RID: 34215
		private ITuningStandBubbleConfig Instance;

		// Token: 0x040085A8 RID: 34216
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x040085A9 RID: 34217
		private bool _FlowInited;
	}
}
