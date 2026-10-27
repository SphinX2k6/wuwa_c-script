using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005360 RID: 21344
	public class IHackManagementComponentT
	{
		// Token: 0x17009CD4 RID: 40148
		// (get) Token: 0x06022EBA RID: 143034 RVA: 0x004D6234 File Offset: 0x004D4434
		// (set) Token: 0x06022EBB RID: 143035 RVA: 0x004D623C File Offset: 0x004D443C
		public bool Disabled { get; set; }

		// Token: 0x17009CD5 RID: 40149
		// (get) Token: 0x06022EBC RID: 143036 RVA: 0x004D6245 File Offset: 0x004D4445
		// (set) Token: 0x06022EBD RID: 143037 RVA: 0x004D624D File Offset: 0x004D444D
		public int MaxHackingCount { get; set; }

		// Token: 0x17009CD6 RID: 40150
		// (get) Token: 0x06022EBE RID: 143038 RVA: 0x004D6256 File Offset: 0x004D4456
		// (set) Token: 0x06022EBF RID: 143039 RVA: 0x004D625E File Offset: 0x004D445E
		public float ValidDistance { get; set; }

		// Token: 0x17009CD7 RID: 40151
		// (get) Token: 0x06022EC0 RID: 143040 RVA: 0x004D6267 File Offset: 0x004D4467
		// (set) Token: 0x06022EC1 RID: 143041 RVA: 0x004D626F File Offset: 0x004D446F
		public byte NullMask { get; set; }

		// Token: 0x06022EC2 RID: 143042 RVA: 0x004D6278 File Offset: 0x004D4478
		public IHackManagementComponentT()
		{
			this.Disabled = false;
			this.MaxHackingCount = 0;
			this.ValidDistance = 0f;
			this.NullMask = 0;
		}
	}
}
