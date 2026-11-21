using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B3D RID: 11069
	public class IFishingRoulette : IUiGame
	{
		// Token: 0x0600F36C RID: 62316 RVA: 0x00238608 File Offset: 0x00236808
		public static IFishingRoulette Create(IFishingRoulette? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFishingRoulette
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A0 RID: 18848
		// (get) Token: 0x0600F36D RID: 62317 RVA: 0x00238627 File Offset: 0x00236827
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04008589 RID: 34185
		private IFishingRoulette Instance;
	}
}
