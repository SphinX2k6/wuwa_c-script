using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C44 RID: 3140
	public class IEffectSplineEquidistantPointMode : IEffectSplineCreationMode
	{
		// Token: 0x060047E2 RID: 18402 RVA: 0x000B4DC1 File Offset: 0x000B2FC1
		[NullableContext(1)]
		public static IEffectSplineEquidistantPointMode Create(IEffectSplineEquidistantPointMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSplineEquidistantPointMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060047E3 RID: 18403 RVA: 0x000B4DE0 File Offset: 0x000B2FE0
		public override EEffectSplineCreateMode Type
		{
			get
			{
				return (EEffectSplineCreateMode)this.Instance.Type;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060047E4 RID: 18404 RVA: 0x000B4DED File Offset: 0x000B2FED
		public virtual int Space
		{
			get
			{
				return this.Instance.Space;
			}
		}

		// Token: 0x040028E9 RID: 10473
		private IEffectSplineEquidistantPointMode Instance;
	}
}
