using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002994 RID: 10644
	public class IClientFollowShooterLeisureInteractType
	{
		// Token: 0x0600EBA4 RID: 60324 RVA: 0x00227533 File Offset: 0x00225733
		[NullableContext(1)]
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

		// Token: 0x17004A3E RID: 19006
		// (get) Token: 0x0600EBA5 RID: 60325 RVA: 0x00227552 File Offset: 0x00225752
		public virtual EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				return (EClientFollowShooterLeisureInteractType)this.Instance.Type;
			}
		}

		// Token: 0x040081C6 RID: 33222
		private IClientFollowShooterLeisureInteractType Instance;
	}
}
