using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002867 RID: 10343
	public class ChangeState : ActionParams
	{
		// Token: 0x0600E6B6 RID: 59062 RVA: 0x00222635 File Offset: 0x00220835
		public static ChangeState Create(IChangeState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x0600E6B7 RID: 59063 RVA: 0x00222654 File Offset: 0x00220854
		public virtual int StateId
		{
			get
			{
				return this.Instance.StateId;
			}
		}

		// Token: 0x04007F13 RID: 32531
		private IChangeState Instance;
	}
}
