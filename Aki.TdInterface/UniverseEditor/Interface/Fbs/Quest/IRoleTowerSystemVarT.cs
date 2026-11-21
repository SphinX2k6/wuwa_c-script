using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004527 RID: 17703
	public class IRoleTowerSystemVarT
	{
		// Token: 0x17007B24 RID: 31524
		// (get) Token: 0x06019A08 RID: 104968 RVA: 0x003A695F File Offset: 0x003A4B5F
		// (set) Token: 0x06019A09 RID: 104969 RVA: 0x003A6967 File Offset: 0x003A4B67
		public ERoleTowerSystemVarType VarType { get; set; }

		// Token: 0x17007B25 RID: 31525
		// (get) Token: 0x06019A0A RID: 104970 RVA: 0x003A6970 File Offset: 0x003A4B70
		// (set) Token: 0x06019A0B RID: 104971 RVA: 0x003A6978 File Offset: 0x003A4B78
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06019A0C RID: 104972 RVA: 0x003A6981 File Offset: 0x003A4B81
		public IRoleTowerSystemVarT()
		{
			this.VarType = ERoleTowerSystemVarType.Batch;
			this.VarRef = null;
		}
	}
}
