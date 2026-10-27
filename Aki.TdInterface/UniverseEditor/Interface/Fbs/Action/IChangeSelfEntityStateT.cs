using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006321 RID: 25377
	public class IChangeSelfEntityStateT
	{
		// Token: 0x1700BD6F RID: 48495
		// (get) Token: 0x0602BE59 RID: 179801 RVA: 0x0060901D File Offset: 0x0060721D
		// (set) Token: 0x0602BE5A RID: 179802 RVA: 0x00609025 File Offset: 0x00607225
		public string EntityState { get; set; }

		// Token: 0x0602BE5B RID: 179803 RVA: 0x0060902E File Offset: 0x0060722E
		public IChangeSelfEntityStateT()
		{
			this.EntityState = null;
		}
	}
}
