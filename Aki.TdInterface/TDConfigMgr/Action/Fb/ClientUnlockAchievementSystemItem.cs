using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DB RID: 10715
	public class ClientUnlockAchievementSystemItem : ActionParams
	{
		// Token: 0x0600ED14 RID: 60692 RVA: 0x0022DC15 File Offset: 0x0022BE15
		public static ClientUnlockAchievementSystemItem Create(IClientUnlockAchievementSystemItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientUnlockAchievementSystemItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700460C RID: 17932
		// (get) Token: 0x0600ED15 RID: 60693 RVA: 0x0022DC34 File Offset: 0x0022BE34
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x0400827B RID: 33403
		private IClientUnlockAchievementSystemItem Instance;
	}
}
