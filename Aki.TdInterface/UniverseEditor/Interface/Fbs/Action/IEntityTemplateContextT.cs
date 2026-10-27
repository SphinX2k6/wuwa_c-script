using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066EE RID: 26350
	public class IEntityTemplateContextT
	{
		// Token: 0x1700C3D1 RID: 50129
		// (get) Token: 0x0602DD23 RID: 187683 RVA: 0x00644213 File Offset: 0x00642413
		// (set) Token: 0x0602DD24 RID: 187684 RVA: 0x0064421B File Offset: 0x0064241B
		public EVarContext Type { get; set; }

		// Token: 0x1700C3D2 RID: 50130
		// (get) Token: 0x0602DD25 RID: 187685 RVA: 0x00644224 File Offset: 0x00642424
		// (set) Token: 0x0602DD26 RID: 187686 RVA: 0x0064422C File Offset: 0x0064242C
		public string Id { get; set; }

		// Token: 0x0602DD27 RID: 187687 RVA: 0x00644235 File Offset: 0x00642435
		public IEntityTemplateContextT()
		{
			this.Type = EVarContext.None;
			this.Id = null;
		}
	}
}
