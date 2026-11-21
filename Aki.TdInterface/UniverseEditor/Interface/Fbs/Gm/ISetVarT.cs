using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AFF RID: 19199
	public class ISetVarT
	{
		// Token: 0x17008690 RID: 34448
		// (get) Token: 0x0601CEEE RID: 118510 RVA: 0x00412144 File Offset: 0x00410344
		// (set) Token: 0x0601CEEF RID: 118511 RVA: 0x0041214C File Offset: 0x0041034C
		public EGmCommand Type { get; set; }

		// Token: 0x17008691 RID: 34449
		// (get) Token: 0x0601CEF0 RID: 118512 RVA: 0x00412155 File Offset: 0x00410355
		// (set) Token: 0x0601CEF1 RID: 118513 RVA: 0x0041215D File Offset: 0x0041035D
		public EVarRefSource Source { get; set; }

		// Token: 0x17008692 RID: 34450
		// (get) Token: 0x0601CEF2 RID: 118514 RVA: 0x00412166 File Offset: 0x00410366
		// (set) Token: 0x0601CEF3 RID: 118515 RVA: 0x0041216E File Offset: 0x0041036E
		public string VarName { get; set; }

		// Token: 0x17008693 RID: 34451
		// (get) Token: 0x0601CEF4 RID: 118516 RVA: 0x00412177 File Offset: 0x00410377
		// (set) Token: 0x0601CEF5 RID: 118517 RVA: 0x0041217F File Offset: 0x0041037F
		public string VarValue { get; set; }

		// Token: 0x17008694 RID: 34452
		// (get) Token: 0x0601CEF6 RID: 118518 RVA: 0x00412188 File Offset: 0x00410388
		// (set) Token: 0x0601CEF7 RID: 118519 RVA: 0x00412190 File Offset: 0x00410390
		public EVar VarTypeParam { get; set; }

		// Token: 0x17008695 RID: 34453
		// (get) Token: 0x0601CEF8 RID: 118520 RVA: 0x00412199 File Offset: 0x00410399
		// (set) Token: 0x0601CEF9 RID: 118521 RVA: 0x004121A1 File Offset: 0x004103A1
		public ERefType TargetRefType { get; set; }

		// Token: 0x17008696 RID: 34454
		// (get) Token: 0x0601CEFA RID: 118522 RVA: 0x004121AA File Offset: 0x004103AA
		// (set) Token: 0x0601CEFB RID: 118523 RVA: 0x004121B2 File Offset: 0x004103B2
		public int TargetRefId { get; set; }

		// Token: 0x0601CEFC RID: 118524 RVA: 0x004121BB File Offset: 0x004103BB
		public ISetVarT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Source = EVarRefSource.Constant;
			this.VarName = null;
			this.VarValue = null;
			this.VarTypeParam = EVar.Boolean;
			this.TargetRefType = ERefType.Entity;
			this.TargetRefId = 0;
		}
	}
}
