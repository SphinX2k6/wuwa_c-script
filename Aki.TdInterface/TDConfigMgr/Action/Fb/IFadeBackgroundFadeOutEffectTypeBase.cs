using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002689 RID: 9865
	public class IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x0600DCEA RID: 56554 RVA: 0x0020D7F5 File Offset: 0x0020B9F5
		[NullableContext(1)]
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

		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x0600DCEB RID: 56555 RVA: 0x0020D814 File Offset: 0x0020BA14
		public virtual EFadeBackgroundFadeOutEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeOutEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007ABD RID: 31421
		private IFadeBackgroundFadeOutEffectTypeBase Instance;
	}
}
