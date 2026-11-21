using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C7F RID: 11391
	public class IClientFollowShooterLeisureInteractType
	{
		// Token: 0x0600FA2F RID: 64047 RVA: 0x00244DBE File Offset: 0x00242FBE
		public static IClientFollowShooterLeisureInteractType Create(IClientFollowShooterLeisureInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterLeisureInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DDF RID: 19935
		// (get) Token: 0x0600FA30 RID: 64048 RVA: 0x00244DDD File Offset: 0x00242FDD
		public virtual EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				return (EClientFollowShooterLeisureInteractType)this.Instance.Type;
			}
		}

		// Token: 0x040088B1 RID: 34993
		private IClientFollowShooterLeisureInteractType Instance;
	}
}
