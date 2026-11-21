using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050EF RID: 20719
	public class IElementalBoxStateFoundationTargetT
	{
		// Token: 0x1700947D RID: 38013
		// (get) Token: 0x060208ED RID: 133357 RVA: 0x0048430D File Offset: 0x0048250D
		// (set) Token: 0x060208EE RID: 133358 RVA: 0x00484315 File Offset: 0x00482515
		public EElementalBoxStateTargetType Type { get; set; }

		// Token: 0x1700947E RID: 38014
		// (get) Token: 0x060208EF RID: 133359 RVA: 0x0048431E File Offset: 0x0048251E
		// (set) Token: 0x060208F0 RID: 133360 RVA: 0x00484326 File Offset: 0x00482526
		public int EntityId { get; set; }

		// Token: 0x1700947F RID: 38015
		// (get) Token: 0x060208F1 RID: 133361 RVA: 0x0048432F File Offset: 0x0048252F
		// (set) Token: 0x060208F2 RID: 133362 RVA: 0x00484337 File Offset: 0x00482537
		public string State { get; set; }

		// Token: 0x060208F3 RID: 133363 RVA: 0x00484340 File Offset: 0x00482540
		public IElementalBoxStateFoundationTargetT()
		{
			this.Type = EElementalBoxStateTargetType.Player;
			this.EntityId = 0;
			this.State = null;
		}
	}
}
