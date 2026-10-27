using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A8 RID: 26536
	public class IFinishDungeonT
	{
		// Token: 0x1700C4F9 RID: 50425
		// (get) Token: 0x0602E2E0 RID: 189152 RVA: 0x0064E93A File Offset: 0x0064CB3A
		// (set) Token: 0x0602E2E1 RID: 189153 RVA: 0x0064E942 File Offset: 0x0064CB42
		public bool IsSuccess { get; set; }

		// Token: 0x0602E2E2 RID: 189154 RVA: 0x0064E94B File Offset: 0x0064CB4B
		public IFinishDungeonT()
		{
			this.IsSuccess = false;
		}
	}
}
