using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C79 RID: 11385
	public class RemoveTrialFollowShooter : ActionParams
	{
		// Token: 0x0600FA1A RID: 64026 RVA: 0x00244C16 File Offset: 0x00242E16
		public static RemoveTrialFollowShooter Create(IRemoveTrialFollowShooter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveTrialFollowShooter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DD6 RID: 19926
		// (get) Token: 0x0600FA1B RID: 64027 RVA: 0x00244C35 File Offset: 0x00242E35
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040088A7 RID: 34983
		private IRemoveTrialFollowShooter Instance;
	}
}
