using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B7D RID: 23421
	public class IMovementPointHookT
	{
		// Token: 0x1700AB2F RID: 43823
		// (get) Token: 0x06026984 RID: 158084 RVA: 0x00549204 File Offset: 0x00547404
		// (set) Token: 0x06026985 RID: 158085 RVA: 0x0054920C File Offset: 0x0054740C
		public EHookInteractType Type { get; set; }

		// Token: 0x1700AB30 RID: 43824
		// (get) Token: 0x06026986 RID: 158086 RVA: 0x00549215 File Offset: 0x00547415
		// (set) Token: 0x06026987 RID: 158087 RVA: 0x0054921D File Offset: 0x0054741D
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700AB31 RID: 43825
		// (get) Token: 0x06026988 RID: 158088 RVA: 0x00549226 File Offset: 0x00547426
		// (set) Token: 0x06026989 RID: 158089 RVA: 0x0054922E File Offset: 0x0054742E
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700AB32 RID: 43826
		// (get) Token: 0x0602698A RID: 158090 RVA: 0x00549237 File Offset: 0x00547437
		// (set) Token: 0x0602698B RID: 158091 RVA: 0x0054923F File Offset: 0x0054743F
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700AB33 RID: 43827
		// (get) Token: 0x0602698C RID: 158092 RVA: 0x00549248 File Offset: 0x00547448
		// (set) Token: 0x0602698D RID: 158093 RVA: 0x00549250 File Offset: 0x00547450
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700AB34 RID: 43828
		// (get) Token: 0x0602698E RID: 158094 RVA: 0x00549259 File Offset: 0x00547459
		// (set) Token: 0x0602698F RID: 158095 RVA: 0x00549261 File Offset: 0x00547461
		public byte NullMask { get; set; }

		// Token: 0x06026990 RID: 158096 RVA: 0x0054926A File Offset: 0x0054746A
		public IMovementPointHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.NullMask = 0;
		}
	}
}
