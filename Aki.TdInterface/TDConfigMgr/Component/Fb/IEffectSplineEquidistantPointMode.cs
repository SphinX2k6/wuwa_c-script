using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D17 RID: 3351
	public class IEffectSplineEquidistantPointMode : IEffectSplineCreationMode
	{
		// Token: 0x06004C52 RID: 19538 RVA: 0x000BF171 File Offset: 0x000BD371
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

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x000BF190 File Offset: 0x000BD390
		public override EEffectSplineCreateMode Type
		{
			get
			{
				return (EEffectSplineCreateMode)this.Instance.Type;
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06004C54 RID: 19540 RVA: 0x000BF19D File Offset: 0x000BD39D
		public virtual int Space
		{
			get
			{
				return this.Instance.Space;
			}
		}

		// Token: 0x04002B3E RID: 11070
		private IEffectSplineEquidistantPointMode Instance;
	}
}
