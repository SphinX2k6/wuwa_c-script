using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002785 RID: 10117
	public class IFlowTemplateTransitionEffect
	{
		// Token: 0x0600E13E RID: 57662 RVA: 0x0021485E File Offset: 0x00212A5E
		[NullableContext(1)]
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

		// Token: 0x170043F6 RID: 17398
		// (get) Token: 0x0600E13F RID: 57663 RVA: 0x0021487D File Offset: 0x00212A7D
		public virtual EFlowTemplateTransitionEffectType Type
		{
			get
			{
				return (EFlowTemplateTransitionEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007CCF RID: 31951
		private IFlowTemplateTransitionEffect Instance;
	}
}
