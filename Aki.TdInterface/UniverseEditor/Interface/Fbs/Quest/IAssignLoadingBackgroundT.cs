using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D14 RID: 15636
	public class IAssignLoadingBackgroundT
	{
		// Token: 0x17006B45 RID: 27461
		// (get) Token: 0x06015935 RID: 88373 RVA: 0x0031DB6F File Offset: 0x0031BD6F
		// (set) Token: 0x06015936 RID: 88374 RVA: 0x0031DB77 File Offset: 0x0031BD77
		public EOperation Type { get; set; }

		// Token: 0x17006B46 RID: 27462
		// (get) Token: 0x06015937 RID: 88375 RVA: 0x0031DB80 File Offset: 0x0031BD80
		// (set) Token: 0x06015938 RID: 88376 RVA: 0x0031DB88 File Offset: 0x0031BD88
		public string ImagePath { get; set; }

		// Token: 0x06015939 RID: 88377 RVA: 0x0031DB91 File Offset: 0x0031BD91
		public IAssignLoadingBackgroundT()
		{
			this.Type = EOperation.DisableHLOD;
			this.ImagePath = null;
		}
	}
}
