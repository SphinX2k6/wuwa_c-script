using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004361 RID: 17249
	public class IPerformerAiCoolDownDecoratorT
	{
		// Token: 0x170079C0 RID: 31168
		// (get) Token: 0x06019956 RID: 104790 RVA: 0x003A9784 File Offset: 0x003A7984
		// (set) Token: 0x06019957 RID: 104791 RVA: 0x003A978C File Offset: 0x003A798C
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x170079C1 RID: 31169
		// (get) Token: 0x06019958 RID: 104792 RVA: 0x003A9795 File Offset: 0x003A7995
		// (set) Token: 0x06019959 RID: 104793 RVA: 0x003A979D File Offset: 0x003A799D
		public int CoolDown { get; set; }

		// Token: 0x0601995A RID: 104794 RVA: 0x003A97A6 File Offset: 0x003A79A6
		public IPerformerAiCoolDownDecoratorT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
			this.CoolDown = 0;
		}
	}
}
