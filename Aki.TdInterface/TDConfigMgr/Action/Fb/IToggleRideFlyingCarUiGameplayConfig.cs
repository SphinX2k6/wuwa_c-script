using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B55 RID: 11093
	public class IToggleRideFlyingCarUiGameplayConfig
	{
		// Token: 0x0600F3DC RID: 62428 RVA: 0x002391F3 File Offset: 0x002373F3
		public static IToggleRideFlyingCarUiGameplayConfig Create(IToggleRideFlyingCarUiGameplayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleRideFlyingCarUiGameplayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E0 RID: 18912
		// (get) Token: 0x0600F3DD RID: 62429 RVA: 0x00239212 File Offset: 0x00237412
		public virtual EToggleRideFlyingCarUiGameplayType Type
		{
			get
			{
				return (EToggleRideFlyingCarUiGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x040085C1 RID: 34241
		private IToggleRideFlyingCarUiGameplayConfig Instance;
	}
}
