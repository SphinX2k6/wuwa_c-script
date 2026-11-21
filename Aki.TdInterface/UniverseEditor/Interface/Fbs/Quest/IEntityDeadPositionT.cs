using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004242 RID: 16962
	public class IEntityDeadPositionT
	{
		// Token: 0x170073A2 RID: 29602
		// (get) Token: 0x060179A3 RID: 96675 RVA: 0x0035E007 File Offset: 0x0035C207
		// (set) Token: 0x060179A4 RID: 96676 RVA: 0x0035E00F File Offset: 0x0035C20F
		public int EntityId { get; set; }

		// Token: 0x170073A3 RID: 29603
		// (get) Token: 0x060179A5 RID: 96677 RVA: 0x0035E018 File Offset: 0x0035C218
		// (set) Token: 0x060179A6 RID: 96678 RVA: 0x0035E020 File Offset: 0x0035C220
		public TVarRefUnion Var { get; set; }

		// Token: 0x170073A4 RID: 29604
		// (get) Token: 0x060179A7 RID: 96679 RVA: 0x0035E029 File Offset: 0x0035C229
		// (set) Token: 0x060179A8 RID: 96680 RVA: 0x0035E031 File Offset: 0x0035C231
		public bool IsIgnoreRot { get; set; }

		// Token: 0x170073A5 RID: 29605
		// (get) Token: 0x060179A9 RID: 96681 RVA: 0x0035E03A File Offset: 0x0035C23A
		// (set) Token: 0x060179AA RID: 96682 RVA: 0x0035E042 File Offset: 0x0035C242
		public byte NullMask { get; set; }

		// Token: 0x060179AB RID: 96683 RVA: 0x0035E04B File Offset: 0x0035C24B
		public IEntityDeadPositionT()
		{
			this.EntityId = 0;
			this.Var = null;
			this.IsIgnoreRot = false;
			this.NullMask = 0;
		}
	}
}
