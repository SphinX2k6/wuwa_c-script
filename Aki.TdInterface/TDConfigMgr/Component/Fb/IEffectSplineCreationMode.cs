using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D15 RID: 3349
	public class IEffectSplineCreationMode
	{
		// Token: 0x06004C4C RID: 19532 RVA: 0x000BF109 File Offset: 0x000BD309
		public static IEffectSplineCreationMode Create(IEffectSplineCreationMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSplineCreationMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06004C4D RID: 19533 RVA: 0x000BF128 File Offset: 0x000BD328
		public virtual EEffectSplineCreateMode Type
		{
			get
			{
				return (EEffectSplineCreateMode)this.Instance.Type;
			}
		}

		// Token: 0x04002B3C RID: 11068
		private IEffectSplineCreationMode Instance;
	}
}
