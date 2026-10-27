using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0A RID: 3082
	[NullableContext(1)]
	[Nullable(0)]
	public class IColorChangeStrategyOfRGB : IColorStrategyOfSplineEffectType
	{
		// Token: 0x060046C0 RID: 18112 RVA: 0x000B28C6 File Offset: 0x000B0AC6
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

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x060046C1 RID: 18113 RVA: 0x000B28E5 File Offset: 0x000B0AE5
		public override EColorChangeStrategyOfSplineEffect Type
		{
			get
			{
				return (EColorChangeStrategyOfSplineEffect)this.Instance.Type;
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x000B28F2 File Offset: 0x000B0AF2
		public virtual string BlueState
		{
			get
			{
				return this.Instance.BlueState;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x000B28FF File Offset: 0x000B0AFF
		public virtual string YellowState
		{
			get
			{
				return this.Instance.YellowState;
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x060046C4 RID: 18116 RVA: 0x000B290C File Offset: 0x000B0B0C
		public virtual string RedState
		{
			get
			{
				return this.Instance.RedState;
			}
		}

		// Token: 0x04002839 RID: 10297
		private IColorChangeStrategyOfRGB Instance;
	}
}
