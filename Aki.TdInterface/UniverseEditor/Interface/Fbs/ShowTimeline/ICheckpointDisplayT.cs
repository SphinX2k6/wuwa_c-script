using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003F98 RID: 16280
	public class ICheckpointDisplayT
	{
		// Token: 0x17006E20 RID: 28192
		// (get) Token: 0x060162FA RID: 90874 RVA: 0x0032E53A File Offset: 0x0032C73A
		// (set) Token: 0x060162FB RID: 90875 RVA: 0x0032E542 File Offset: 0x0032C742
		public ECheckpointDisplayType Type { get; set; }

		// Token: 0x060162FC RID: 90876 RVA: 0x0032E54B File Offset: 0x0032C74B
		public ICheckpointDisplayT()
		{
			this.Type = ECheckpointDisplayType.Role;
		}
	}
}
