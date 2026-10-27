using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002867 RID: 10343
	public class IFishingRoulette : IUiGame
	{
		// Token: 0x0600E53C RID: 58684 RVA: 0x0021B6EE File Offset: 0x002198EE
		[NullableContext(1)]
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

		// Token: 0x17004630 RID: 17968
		// (get) Token: 0x0600E53D RID: 58685 RVA: 0x0021B70D File Offset: 0x0021990D
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04007EC9 RID: 32457
		private IFishingRoulette Instance;
	}
}
