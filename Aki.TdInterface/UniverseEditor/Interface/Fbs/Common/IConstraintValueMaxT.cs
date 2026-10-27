using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D7A RID: 23930
	public class IConstraintValueMaxT
	{
		// Token: 0x1700B33D RID: 45885
		// (get) Token: 0x06028F0A RID: 167690 RVA: 0x0059F7E4 File Offset: 0x0059D9E4
		// (set) Token: 0x06028F0B RID: 167691 RVA: 0x0059F7EC File Offset: 0x0059D9EC
		public EConstraintValueType Type { get; set; }

		// Token: 0x1700B33E RID: 45886
		// (get) Token: 0x06028F0C RID: 167692 RVA: 0x0059F7F5 File Offset: 0x0059D9F5
		// (set) Token: 0x06028F0D RID: 167693 RVA: 0x0059F7FD File Offset: 0x0059D9FD
		public float MaxValue { get; set; }

		// Token: 0x06028F0E RID: 167694 RVA: 0x0059F806 File Offset: 0x0059DA06
		public IConstraintValueMaxT()
		{
			this.Type = EConstraintValueType.Max;
			this.MaxValue = 0f;
		}
	}
}
