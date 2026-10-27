using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C7 RID: 16839
	public class ITetrisPlayModeMainLineT
	{
		// Token: 0x17007767 RID: 30567
		// (get) Token: 0x06018CDA RID: 101594 RVA: 0x00391D9D File Offset: 0x0038FF9D
		// (set) Token: 0x06018CDB RID: 101595 RVA: 0x00391DA5 File Offset: 0x0038FFA5
		public ETetrisPlayMode Type { get; set; }

		// Token: 0x17007768 RID: 30568
		// (get) Token: 0x06018CDC RID: 101596 RVA: 0x00391DAE File Offset: 0x0038FFAE
		// (set) Token: 0x06018CDD RID: 101597 RVA: 0x00391DB6 File Offset: 0x0038FFB6
		public int EntityId { get; set; }

		// Token: 0x17007769 RID: 30569
		// (get) Token: 0x06018CDE RID: 101598 RVA: 0x00391DBF File Offset: 0x0038FFBF
		// (set) Token: 0x06018CDF RID: 101599 RVA: 0x00391DC7 File Offset: 0x0038FFC7
		public string EntityState { get; set; }

		// Token: 0x1700776A RID: 30570
		// (get) Token: 0x06018CE0 RID: 101600 RVA: 0x00391DD0 File Offset: 0x0038FFD0
		// (set) Token: 0x06018CE1 RID: 101601 RVA: 0x00391DD8 File Offset: 0x0038FFD8
		public int FieldHeight { get; set; }

		// Token: 0x1700776B RID: 30571
		// (get) Token: 0x06018CE2 RID: 101602 RVA: 0x00391DE1 File Offset: 0x0038FFE1
		// (set) Token: 0x06018CE3 RID: 101603 RVA: 0x00391DE9 File Offset: 0x0038FFE9
		public byte NullMask { get; set; }

		// Token: 0x06018CE4 RID: 101604 RVA: 0x00391DF2 File Offset: 0x0038FFF2
		public ITetrisPlayModeMainLineT()
		{
			this.Type = ETetrisPlayMode.Normal;
			this.EntityId = 0;
			this.EntityState = null;
			this.FieldHeight = 0;
			this.NullMask = 0;
		}
	}
}
