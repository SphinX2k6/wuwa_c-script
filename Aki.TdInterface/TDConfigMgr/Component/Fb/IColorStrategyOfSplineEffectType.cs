using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD9 RID: 3289
	public class IColorStrategyOfSplineEffectType
	{
		// Token: 0x06004B20 RID: 19232 RVA: 0x000BCA5E File Offset: 0x000BAC5E
		public static IColorStrategyOfSplineEffectType Create(IColorStrategyOfSplineEffectType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IColorStrategyOfSplineEffectType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06004B21 RID: 19233 RVA: 0x000BCA7D File Offset: 0x000BAC7D
		public virtual EColorChangeStrategyOfSplineEffect Type
		{
			get
			{
				return (EColorChangeStrategyOfSplineEffect)this.Instance.Type;
			}
		}

		// Token: 0x04002A84 RID: 10884
		private IColorStrategyOfSplineEffectType Instance;
	}
}
