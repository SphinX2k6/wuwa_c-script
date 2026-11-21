using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200709B RID: 28827
	public class ILevelPlayActionContextT
	{
		// Token: 0x1700D32B RID: 54059
		// (get) Token: 0x060320C5 RID: 204997 RVA: 0x006C660D File Offset: 0x006C480D
		// (set) Token: 0x060320C6 RID: 204998 RVA: 0x006C6615 File Offset: 0x006C4815
		public string Type { get; set; }

		// Token: 0x1700D32C RID: 54060
		// (get) Token: 0x060320C7 RID: 204999 RVA: 0x006C661E File Offset: 0x006C481E
		// (set) Token: 0x060320C8 RID: 205000 RVA: 0x006C6626 File Offset: 0x006C4826
		public EDecisionBtType DecisionBtType { get; set; }

		// Token: 0x1700D32D RID: 54061
		// (get) Token: 0x060320C9 RID: 205001 RVA: 0x006C662F File Offset: 0x006C482F
		// (set) Token: 0x060320CA RID: 205002 RVA: 0x006C6637 File Offset: 0x006C4837
		public byte NullMask { get; set; }

		// Token: 0x060320CB RID: 205003 RVA: 0x006C6640 File Offset: 0x006C4840
		public ILevelPlayActionContextT()
		{
			this.Type = null;
			this.DecisionBtType = EDecisionBtType.Bvb;
			this.NullMask = 0;
		}
	}
}
