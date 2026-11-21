using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CDA RID: 3290
	public class IColorChangeStrategyOfRGB : IColorStrategyOfSplineEffectType
	{
		// Token: 0x06004B23 RID: 19235 RVA: 0x000BCA92 File Offset: 0x000BAC92
		public static IColorChangeStrategyOfRGB Create(IColorChangeStrategyOfRGB? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IColorChangeStrategyOfRGB
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06004B24 RID: 19236 RVA: 0x000BCAB1 File Offset: 0x000BACB1
		public override EColorChangeStrategyOfSplineEffect Type
		{
			get
			{
				return (EColorChangeStrategyOfSplineEffect)this.Instance.Type;
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06004B25 RID: 19237 RVA: 0x000BCABE File Offset: 0x000BACBE
		public virtual string BlueState
		{
			get
			{
				return this.Instance.BlueState;
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x000BCACB File Offset: 0x000BACCB
		public virtual string YellowState
		{
			get
			{
				return this.Instance.YellowState;
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06004B27 RID: 19239 RVA: 0x000BCAD8 File Offset: 0x000BACD8
		public virtual string RedState
		{
			get
			{
				return this.Instance.RedState;
			}
		}

		// Token: 0x04002A85 RID: 10885
		private IColorChangeStrategyOfRGB Instance;
	}
}
