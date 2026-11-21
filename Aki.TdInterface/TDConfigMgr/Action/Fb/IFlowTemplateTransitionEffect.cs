using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A57 RID: 10839
	public class IFlowTemplateTransitionEffect
	{
		// Token: 0x0600EF5C RID: 61276 RVA: 0x002315F2 File Offset: 0x0022F7F2
		public static IFlowTemplateTransitionEffect Create(IFlowTemplateTransitionEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateTransitionEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700475C RID: 18268
		// (get) Token: 0x0600EF5D RID: 61277 RVA: 0x00231611 File Offset: 0x0022F811
		public virtual EFlowTemplateTransitionEffectType Type
		{
			get
			{
				return (EFlowTemplateTransitionEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04008385 RID: 33669
		private IFlowTemplateTransitionEffect Instance;
	}
}
