using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E1E RID: 11806
	public class ILiveInteractDanmakuListenerGroup
	{
		// Token: 0x0601006E RID: 65646 RVA: 0x0024E464 File Offset: 0x0024C664
		public static ILiveInteractDanmakuListenerGroup Create(ILiveInteractDanmakuListenerGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuListenerGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050E0 RID: 20704
		// (get) Token: 0x0601006F RID: 65647 RVA: 0x0024E483 File Offset: 0x0024C683
		public virtual ILiveInteractDanmakuTrigger Trigger
		{
			get
			{
				if (this._TriggerInited)
				{
					return this._TriggerCache;
				}
				this._TriggerInited = true;
				this._TriggerCache = ActionReadHelper.ReadILiveInteractDanmakuListenerGroup_Trigger(this.Instance);
				return this._TriggerCache;
			}
		}

		// Token: 0x170050E1 RID: 20705
		// (get) Token: 0x06010070 RID: 65648 RVA: 0x0024E4B2 File Offset: 0x0024C6B2
		public virtual int DanmakuPoolId
		{
			get
			{
				return this.Instance.DanmakuPoolId;
			}
		}

		// Token: 0x170050E2 RID: 20706
		// (get) Token: 0x06010071 RID: 65649 RVA: 0x0024E4BF File Offset: 0x0024C6BF
		public virtual int TriggerCount
		{
			get
			{
				return this.Instance.TriggerCount;
			}
		}

		// Token: 0x170050E3 RID: 20707
		// (get) Token: 0x06010072 RID: 65650 RVA: 0x0024E4CC File Offset: 0x0024C6CC
		public virtual int MaxTriggerCount
		{
			get
			{
				return this.Instance.MaxTriggerCount;
			}
		}

		// Token: 0x04008BE6 RID: 35814
		private ILiveInteractDanmakuListenerGroup Instance;

		// Token: 0x04008BE7 RID: 35815
		private ILiveInteractDanmakuTrigger _TriggerCache;

		// Token: 0x04008BE8 RID: 35816
		private bool _TriggerInited;
	}
}
