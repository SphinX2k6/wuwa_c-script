using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002868 RID: 10344
	public class ChangeBehaviorState : ActionParams
	{
		// Token: 0x0600E6B9 RID: 59065 RVA: 0x00222669 File Offset: 0x00220869
		public static ChangeBehaviorState Create(IChangeBehaviorState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeBehaviorState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004297 RID: 17047
		// (get) Token: 0x0600E6BA RID: 59066 RVA: 0x00222688 File Offset: 0x00220888
		public virtual int StateId
		{
			get
			{
				return this.Instance.StateId;
			}
		}

		// Token: 0x17004298 RID: 17048
		// (get) Token: 0x0600E6BB RID: 59067 RVA: 0x00222695 File Offset: 0x00220895
		public virtual bool IsInstant
		{
			get
			{
				return this.Instance.IsInstant;
			}
		}

		// Token: 0x04007F14 RID: 32532
		private IChangeBehaviorState Instance;
	}
}
