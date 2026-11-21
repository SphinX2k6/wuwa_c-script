using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B57 RID: 11095
	public class IDisableRideFlyingCarUiGameplay : IToggleRideFlyingCarUiGameplayConfig
	{
		// Token: 0x0600F3E4 RID: 62436 RVA: 0x002392CA File Offset: 0x002374CA
		public static IDisableRideFlyingCarUiGameplay Create(IDisableRideFlyingCarUiGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableRideFlyingCarUiGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E4 RID: 18916
		// (get) Token: 0x0600F3E5 RID: 62437 RVA: 0x002392E9 File Offset: 0x002374E9
		public override EToggleRideFlyingCarUiGameplayType Type
		{
			get
			{
				return (EToggleRideFlyingCarUiGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x040085C3 RID: 34243
		private IDisableRideFlyingCarUiGameplay Instance;
	}
}
