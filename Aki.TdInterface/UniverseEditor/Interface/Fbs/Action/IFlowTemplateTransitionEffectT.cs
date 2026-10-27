using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200682C RID: 26668
	public class IFlowTemplateTransitionEffectT
	{
		// Token: 0x1700C619 RID: 50713
		// (get) Token: 0x0602E7E3 RID: 190435 RVA: 0x0065848A File Offset: 0x0065668A
		// (set) Token: 0x0602E7E4 RID: 190436 RVA: 0x00658492 File Offset: 0x00656692
		public EFlowTemplateTransitionEffectType Type { get; set; }

		// Token: 0x0602E7E5 RID: 190437 RVA: 0x0065849B File Offset: 0x0065669B
		public IFlowTemplateTransitionEffectT()
		{
			this.Type = EFlowTemplateTransitionEffectType.Blur;
		}
	}
}
