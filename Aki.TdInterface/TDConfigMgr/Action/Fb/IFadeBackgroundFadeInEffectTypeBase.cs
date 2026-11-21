using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002948 RID: 10568
	public class IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x0600EAB1 RID: 60081 RVA: 0x00229E19 File Offset: 0x00228019
		public static IFadeBackgroundFadeInEffectTypeBase Create(IFadeBackgroundFadeInEffectTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffectTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044CF RID: 17615
		// (get) Token: 0x0600EAB2 RID: 60082 RVA: 0x00229E38 File Offset: 0x00228038
		public virtual EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeInEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04008154 RID: 33108
		private IFadeBackgroundFadeInEffectTypeBase Instance;
	}
}
