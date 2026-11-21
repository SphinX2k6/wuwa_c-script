using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294C RID: 10572
	public class IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x0600EAC1 RID: 60097 RVA: 0x00229F95 File Offset: 0x00228195
		public static IFadeBackgroundFadeOutEffectTypeBase Create(IFadeBackgroundFadeOutEffectTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffectTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044D7 RID: 17623
		// (get) Token: 0x0600EAC2 RID: 60098 RVA: 0x00229FB4 File Offset: 0x002281B4
		public virtual EFadeBackgroundFadeOutEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeOutEffectType)this.Instance.Type;
			}
		}

		// Token: 0x0400815A RID: 33114
		private IFadeBackgroundFadeOutEffectTypeBase Instance;
	}
}
