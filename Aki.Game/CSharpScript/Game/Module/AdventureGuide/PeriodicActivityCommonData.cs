using System;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EB5 RID: 20149
	public class PeriodicActivityCommonData : IPeriodicActivityCommonData
	{
		// Token: 0x170062B5 RID: 25269
		// (get) Token: 0x06032AD7 RID: 207575 RVA: 0x00E373FA File Offset: 0x00E355FA
		// (set) Token: 0x06032AD8 RID: 207576 RVA: 0x00E37402 File Offset: 0x00E35602
		public int ActivityId { get; set; }

		// Token: 0x170062B6 RID: 25270
		// (get) Token: 0x06032AD9 RID: 207577 RVA: 0x00E3740B File Offset: 0x00E3560B
		// (set) Token: 0x06032ADA RID: 207578 RVA: 0x00E37413 File Offset: 0x00E35613
		public int Round { get; set; }
	}
}
