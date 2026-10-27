using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C09 RID: 3081
	public class IColorStrategyOfSplineEffectType
	{
		// Token: 0x060046BD RID: 18109 RVA: 0x000B2892 File Offset: 0x000B0A92
		[NullableContext(1)]
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

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x000B28B1 File Offset: 0x000B0AB1
		public virtual EColorChangeStrategyOfSplineEffect Type
		{
			get
			{
				return (EColorChangeStrategyOfSplineEffect)this.Instance.Type;
			}
		}

		// Token: 0x04002838 RID: 10296
		private IColorStrategyOfSplineEffectType Instance;
	}
}
