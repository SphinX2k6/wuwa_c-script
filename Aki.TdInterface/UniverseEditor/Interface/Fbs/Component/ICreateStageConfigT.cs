using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A5 RID: 21925
	public class ICreateStageConfigT
	{
		// Token: 0x17009CFF RID: 40191
		// (get) Token: 0x06022E05 RID: 142853 RVA: 0x004CDAC0 File Offset: 0x004CBCC0
		// (set) Token: 0x06022E06 RID: 142854 RVA: 0x004CDAC8 File Offset: 0x004CBCC8
		public float PerformDuration { get; set; }

		// Token: 0x17009D00 RID: 40192
		// (get) Token: 0x06022E07 RID: 142855 RVA: 0x004CDAD1 File Offset: 0x004CBCD1
		// (set) Token: 0x06022E08 RID: 142856 RVA: 0x004CDAD9 File Offset: 0x004CBCD9
		public ICreateBulletConfigT BulletConfig { get; set; }

		// Token: 0x17009D01 RID: 40193
		// (get) Token: 0x06022E09 RID: 142857 RVA: 0x004CDAE2 File Offset: 0x004CBCE2
		// (set) Token: 0x06022E0A RID: 142858 RVA: 0x004CDAEA File Offset: 0x004CBCEA
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009D02 RID: 40194
		// (get) Token: 0x06022E0B RID: 142859 RVA: 0x004CDAF3 File Offset: 0x004CBCF3
		// (set) Token: 0x06022E0C RID: 142860 RVA: 0x004CDAFB File Offset: 0x004CBCFB
		public byte NullMask { get; set; }

		// Token: 0x06022E0D RID: 142861 RVA: 0x004CDB04 File Offset: 0x004CBD04
		public ICreateStageConfigT()
		{
			this.PerformDuration = 0f;
			this.BulletConfig = null;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
