using System;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005ED0 RID: 24272
	public class PeriodicActivityCommonData : IPeriodicActivityCommonData
	{
		// Token: 0x17008EE3 RID: 36579
		// (get) Token: 0x0603DB47 RID: 252743 RVA: 0x00EE5EAE File Offset: 0x00EE40AE
		// (set) Token: 0x0603DB48 RID: 252744 RVA: 0x00EE5EB6 File Offset: 0x00EE40B6
		public int ActivityId { get; set; }

		// Token: 0x17008EE4 RID: 36580
		// (get) Token: 0x0603DB49 RID: 252745 RVA: 0x00EE5EBF File Offset: 0x00EE40BF
		// (set) Token: 0x0603DB4A RID: 252746 RVA: 0x00EE5EC7 File Offset: 0x00EE40C7
		public int Round { get; set; }
	}
}
