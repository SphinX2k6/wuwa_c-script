using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C7C RID: 11388
	public class IFollowShooterResetToPlayer : IFollowShooterLeisureInteractType
	{
		// Token: 0x0600FA25 RID: 64037 RVA: 0x00244CF3 File Offset: 0x00242EF3
		public static IFollowShooterResetToPlayer Create(IFollowShooterResetToPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterResetToPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DDB RID: 19931
		// (get) Token: 0x0600FA26 RID: 64038 RVA: 0x00244D12 File Offset: 0x00242F12
		public override EFollowShooterLeisureInteractType Type
		{
			get
			{
				return (EFollowShooterLeisureInteractType)this.Instance.Type;
			}
		}

		// Token: 0x040088AC RID: 34988
		private IFollowShooterResetToPlayer Instance;
	}
}
