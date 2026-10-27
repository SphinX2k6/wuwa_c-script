using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005082 RID: 20610
	public class IDestroyCfgT
	{
		// Token: 0x1700958B RID: 38283
		// (get) Token: 0x060210C9 RID: 135369 RVA: 0x00497401 File Offset: 0x00495601
		// (set) Token: 0x060210CA RID: 135370 RVA: 0x00497409 File Offset: 0x00495609
		public List<TTeleControlDestroyConditionUnion> Conditions { get; set; }

		// Token: 0x1700958C RID: 38284
		// (get) Token: 0x060210CB RID: 135371 RVA: 0x00497412 File Offset: 0x00495612
		// (set) Token: 0x060210CC RID: 135372 RVA: 0x0049741A File Offset: 0x0049561A
		public bool StopPhysicAfterDestroyed { get; set; }

		// Token: 0x1700958D RID: 38285
		// (get) Token: 0x060210CD RID: 135373 RVA: 0x00497423 File Offset: 0x00495623
		// (set) Token: 0x060210CE RID: 135374 RVA: 0x0049742B File Offset: 0x0049562B
		public byte NullMask { get; set; }

		// Token: 0x060210CF RID: 135375 RVA: 0x00497434 File Offset: 0x00495634
		public IDestroyCfgT()
		{
			this.Conditions = null;
			this.StopPhysicAfterDestroyed = false;
			this.NullMask = 0;
		}
	}
}
