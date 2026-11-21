using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A4 RID: 30628
	public class ISetElementalBoxToTargetT
	{
		// Token: 0x1700E06E RID: 57454
		// (get) Token: 0x06035C58 RID: 220248 RVA: 0x0073442B File Offset: 0x0073262B
		// (set) Token: 0x06035C59 RID: 220249 RVA: 0x00734433 File Offset: 0x00732633
		public int ElementalBoxId { get; set; }

		// Token: 0x1700E06F RID: 57455
		// (get) Token: 0x06035C5A RID: 220250 RVA: 0x0073443C File Offset: 0x0073263C
		// (set) Token: 0x06035C5B RID: 220251 RVA: 0x00734444 File Offset: 0x00732644
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x06035C5C RID: 220252 RVA: 0x0073444D File Offset: 0x0073264D
		public ISetElementalBoxToTargetT()
		{
			this.ElementalBoxId = 0;
			this.Target = null;
		}
	}
}
