using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D16 RID: 3350
	public class IEffectSplineWholeLineMode : IEffectSplineCreationMode
	{
		// Token: 0x06004C4F RID: 19535 RVA: 0x000BF13D File Offset: 0x000BD33D
		public static IEffectSplineWholeLineMode Create(IEffectSplineWholeLineMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSplineWholeLineMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06004C50 RID: 19536 RVA: 0x000BF15C File Offset: 0x000BD35C
		public override EEffectSplineCreateMode Type
		{
			get
			{
				return (EEffectSplineCreateMode)this.Instance.Type;
			}
		}

		// Token: 0x04002B3D RID: 11069
		private IEffectSplineWholeLineMode Instance;
	}
}
