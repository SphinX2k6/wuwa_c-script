using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CE3 RID: 19683
	public class IGameServerConnectionConfigT
	{
		// Token: 0x17008CA2 RID: 36002
		// (get) Token: 0x0601E695 RID: 124565 RVA: 0x00442A83 File Offset: 0x00440C83
		// (set) Token: 0x0601E696 RID: 124566 RVA: 0x00442A8B File Offset: 0x00440C8B
		public string LocalGameServerNode { get; set; }

		// Token: 0x17008CA3 RID: 36003
		// (get) Token: 0x0601E697 RID: 124567 RVA: 0x00442A94 File Offset: 0x00440C94
		// (set) Token: 0x0601E698 RID: 124568 RVA: 0x00442A9C File Offset: 0x00440C9C
		public int LocalGameServerApiPort { get; set; }

		// Token: 0x17008CA4 RID: 36004
		// (get) Token: 0x0601E699 RID: 124569 RVA: 0x00442AA5 File Offset: 0x00440CA5
		// (set) Token: 0x0601E69A RID: 124570 RVA: 0x00442AAD File Offset: 0x00440CAD
		public int LocalGameServerLoginPort { get; set; }

		// Token: 0x17008CA5 RID: 36005
		// (get) Token: 0x0601E69B RID: 124571 RVA: 0x00442AB6 File Offset: 0x00440CB6
		// (set) Token: 0x0601E69C RID: 124572 RVA: 0x00442ABE File Offset: 0x00440CBE
		public byte NullMask { get; set; }

		// Token: 0x0601E69D RID: 124573 RVA: 0x00442AC7 File Offset: 0x00440CC7
		public IGameServerConnectionConfigT()
		{
			this.LocalGameServerNode = null;
			this.LocalGameServerApiPort = 0;
			this.LocalGameServerLoginPort = 0;
			this.NullMask = 0;
		}
	}
}
