using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002685 RID: 9861
	public class IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x0600DCDA RID: 56538 RVA: 0x0020D679 File Offset: 0x0020B879
		[NullableContext(1)]
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

		// Token: 0x17004192 RID: 16786
		// (get) Token: 0x0600DCDB RID: 56539 RVA: 0x0020D698 File Offset: 0x0020B898
		public virtual EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeInEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007AB7 RID: 31415
		private IFadeBackgroundFadeInEffectTypeBase Instance;
	}
}
