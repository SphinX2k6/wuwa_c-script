using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C80 RID: 11392
	public class IClientFollowShooterResetToPlayer : IClientFollowShooterLeisureInteractType
	{
		// Token: 0x0600FA32 RID: 64050 RVA: 0x00244DF2 File Offset: 0x00242FF2
		public static IClientFollowShooterResetToPlayer Create(IClientFollowShooterResetToPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterResetToPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DE0 RID: 19936
		// (get) Token: 0x0600FA33 RID: 64051 RVA: 0x00244E11 File Offset: 0x00243011
		public override EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				return (EClientFollowShooterLeisureInteractType)this.Instance.Type;
			}
		}

		// Token: 0x040088B2 RID: 34994
		private IClientFollowShooterResetToPlayer Instance;
	}
}
