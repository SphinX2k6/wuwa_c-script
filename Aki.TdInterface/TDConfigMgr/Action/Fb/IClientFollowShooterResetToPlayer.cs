using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002995 RID: 10645
	public class IClientFollowShooterResetToPlayer : IClientFollowShooterLeisureInteractType
	{
		// Token: 0x0600EBA7 RID: 60327 RVA: 0x00227567 File Offset: 0x00225767
		[NullableContext(1)]
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

		// Token: 0x17004A3F RID: 19007
		// (get) Token: 0x0600EBA8 RID: 60328 RVA: 0x00227586 File Offset: 0x00225786
		public override EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				return (EClientFollowShooterLeisureInteractType)this.Instance.Type;
			}
		}

		// Token: 0x040081C7 RID: 33223
		private IClientFollowShooterResetToPlayer Instance;
	}
}
