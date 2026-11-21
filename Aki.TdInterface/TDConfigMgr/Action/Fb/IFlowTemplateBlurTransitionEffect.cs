using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A58 RID: 10840
	public class IFlowTemplateBlurTransitionEffect : IFlowTemplateTransitionEffect
	{
		// Token: 0x0600EF5F RID: 61279 RVA: 0x00231626 File Offset: 0x0022F826
		public static IFlowTemplateBlurTransitionEffect Create(IFlowTemplateBlurTransitionEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateBlurTransitionEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700475D RID: 18269
		// (get) Token: 0x0600EF60 RID: 61280 RVA: 0x00231645 File Offset: 0x0022F845
		public override EFlowTemplateTransitionEffectType Type
		{
			get
			{
				return (EFlowTemplateTransitionEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700475E RID: 18270
		// (get) Token: 0x0600EF61 RID: 61281 RVA: 0x00231652 File Offset: 0x0022F852
		public virtual float Aperture
		{
			get
			{
				return this.Instance.Aperture;
			}
		}

		// Token: 0x1700475F RID: 18271
		// (get) Token: 0x0600EF62 RID: 61282 RVA: 0x0023165F File Offset: 0x0022F85F
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x17004760 RID: 18272
		// (get) Token: 0x0600EF63 RID: 61283 RVA: 0x0023166C File Offset: 0x0022F86C
		public virtual float FadeOutTime
		{
			get
			{
				return this.Instance.FadeOutTime;
			}
		}

		// Token: 0x04008386 RID: 33670
		private IFlowTemplateBlurTransitionEffect Instance;
	}
}
