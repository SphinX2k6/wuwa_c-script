using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062C7 RID: 25287
	public class IChangeActorStateT
	{
		// Token: 0x1700BCC4 RID: 48324
		// (get) Token: 0x0602BB49 RID: 179017 RVA: 0x00603CA1 File Offset: 0x00601EA1
		// (set) Token: 0x0602BB4A RID: 179018 RVA: 0x00603CA9 File Offset: 0x00601EA9
		public string State { get; set; }

		// Token: 0x0602BB4B RID: 179019 RVA: 0x00603CB2 File Offset: 0x00601EB2
		public IChangeActorStateT()
		{
			this.State = null;
		}
	}
}
