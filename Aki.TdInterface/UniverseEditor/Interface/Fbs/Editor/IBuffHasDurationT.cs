using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C9E RID: 19614
	public class IBuffHasDurationT
	{
		// Token: 0x17008AF3 RID: 35571
		// (get) Token: 0x0601E134 RID: 123188 RVA: 0x00436E90 File Offset: 0x00435090
		// (set) Token: 0x0601E135 RID: 123189 RVA: 0x00436E98 File Offset: 0x00435098
		public EBuffDurationType Type { get; set; }

		// Token: 0x17008AF4 RID: 35572
		// (get) Token: 0x0601E136 RID: 123190 RVA: 0x00436EA1 File Offset: 0x004350A1
		// (set) Token: 0x0601E137 RID: 123191 RVA: 0x00436EA9 File Offset: 0x004350A9
		public int Duration { get; set; }

		// Token: 0x0601E138 RID: 123192 RVA: 0x00436EB2 File Offset: 0x004350B2
		public IBuffHasDurationT()
		{
			this.Type = EBuffDurationType.Instant;
			this.Duration = 0;
		}
	}
}
