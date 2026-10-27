using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064E4 RID: 25828
	public class ICreatePrefabT
	{
		// Token: 0x1700C028 RID: 49192
		// (get) Token: 0x0602CCE7 RID: 183527 RVA: 0x00628475 File Offset: 0x00626675
		// (set) Token: 0x0602CCE8 RID: 183528 RVA: 0x0062847D File Offset: 0x0062667D
		public int PosEntityId { get; set; }

		// Token: 0x1700C029 RID: 49193
		// (get) Token: 0x0602CCE9 RID: 183529 RVA: 0x00628486 File Offset: 0x00626686
		// (set) Token: 0x0602CCEA RID: 183530 RVA: 0x0062848E File Offset: 0x0062668E
		public TPrefabConfigUnion Config { get; set; }

		// Token: 0x1700C02A RID: 49194
		// (get) Token: 0x0602CCEB RID: 183531 RVA: 0x00628497 File Offset: 0x00626697
		// (set) Token: 0x0602CCEC RID: 183532 RVA: 0x0062849F File Offset: 0x0062669F
		public TVarRefUnion VarName { get; set; }

		// Token: 0x0602CCED RID: 183533 RVA: 0x006284A8 File Offset: 0x006266A8
		public ICreatePrefabT()
		{
			this.PosEntityId = 0;
			this.Config = null;
			this.VarName = null;
		}
	}
}
