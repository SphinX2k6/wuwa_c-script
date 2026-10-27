using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C43 RID: 3139
	public class IEffectSplineWholeLineMode : IEffectSplineCreationMode
	{
		// Token: 0x060047DF RID: 18399 RVA: 0x000B4D8D File Offset: 0x000B2F8D
		[NullableContext(1)]
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

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x060047E0 RID: 18400 RVA: 0x000B4DAC File Offset: 0x000B2FAC
		public override EEffectSplineCreateMode Type
		{
			get
			{
				return (EEffectSplineCreateMode)this.Instance.Type;
			}
		}

		// Token: 0x040028E8 RID: 10472
		private IEffectSplineWholeLineMode Instance;
	}
}
