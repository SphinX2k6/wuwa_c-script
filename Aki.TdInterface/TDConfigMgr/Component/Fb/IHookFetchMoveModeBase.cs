using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BEF RID: 3055
	public class IHookFetchMoveModeBase
	{
		// Token: 0x06004625 RID: 17957 RVA: 0x000B2D52 File Offset: 0x000B0F52
		public static IHookFetchMoveModeBase Create(IHookFetchMoveModeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookFetchMoveModeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x000B2D71 File Offset: 0x000B0F71
		public virtual EHookFetchMoveMode Type
		{
			get
			{
				return (EHookFetchMoveMode)this.Instance.Type;
			}
		}

		// Token: 0x04002762 RID: 10082
		private IHookFetchMoveModeBase Instance;
	}
}
