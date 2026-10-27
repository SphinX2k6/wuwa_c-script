using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C42 RID: 3138
	public class IEffectSplineCreationMode
	{
		// Token: 0x060047DC RID: 18396 RVA: 0x000B4D59 File Offset: 0x000B2F59
		[NullableContext(1)]
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

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x000B4D78 File Offset: 0x000B2F78
		public virtual EEffectSplineCreateMode Type
		{
			get
			{
				return (EEffectSplineCreateMode)this.Instance.Type;
			}
		}

		// Token: 0x040028E7 RID: 10471
		private IEffectSplineCreationMode Instance;
	}
}
