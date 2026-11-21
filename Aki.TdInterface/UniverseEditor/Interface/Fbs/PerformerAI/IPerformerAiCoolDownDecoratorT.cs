using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047C3 RID: 18371
	public class IPerformerAiCoolDownDecoratorT
	{
		// Token: 0x17007FF5 RID: 32757
		// (get) Token: 0x0601B0E4 RID: 110820 RVA: 0x003D51AC File Offset: 0x003D33AC
		// (set) Token: 0x0601B0E5 RID: 110821 RVA: 0x003D51B4 File Offset: 0x003D33B4
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x17007FF6 RID: 32758
		// (get) Token: 0x0601B0E6 RID: 110822 RVA: 0x003D51BD File Offset: 0x003D33BD
		// (set) Token: 0x0601B0E7 RID: 110823 RVA: 0x003D51C5 File Offset: 0x003D33C5
		public int CoolDown { get; set; }

		// Token: 0x0601B0E8 RID: 110824 RVA: 0x003D51CE File Offset: 0x003D33CE
		public IPerformerAiCoolDownDecoratorT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
			this.CoolDown = 0;
		}
	}
}
