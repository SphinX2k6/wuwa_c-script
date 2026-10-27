using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004697 RID: 18071
	public class ISetVarT
	{
		// Token: 0x1700804F RID: 32847
		// (get) Token: 0x0601B719 RID: 112409 RVA: 0x003E5EA8 File Offset: 0x003E40A8
		// (set) Token: 0x0601B71A RID: 112410 RVA: 0x003E5EB0 File Offset: 0x003E40B0
		public EGmCommand Type { get; set; }

		// Token: 0x17008050 RID: 32848
		// (get) Token: 0x0601B71B RID: 112411 RVA: 0x003E5EB9 File Offset: 0x003E40B9
		// (set) Token: 0x0601B71C RID: 112412 RVA: 0x003E5EC1 File Offset: 0x003E40C1
		public EVarRefSource Source { get; set; }

		// Token: 0x17008051 RID: 32849
		// (get) Token: 0x0601B71D RID: 112413 RVA: 0x003E5ECA File Offset: 0x003E40CA
		// (set) Token: 0x0601B71E RID: 112414 RVA: 0x003E5ED2 File Offset: 0x003E40D2
		public string VarName { get; set; }

		// Token: 0x17008052 RID: 32850
		// (get) Token: 0x0601B71F RID: 112415 RVA: 0x003E5EDB File Offset: 0x003E40DB
		// (set) Token: 0x0601B720 RID: 112416 RVA: 0x003E5EE3 File Offset: 0x003E40E3
		public string VarValue { get; set; }

		// Token: 0x17008053 RID: 32851
		// (get) Token: 0x0601B721 RID: 112417 RVA: 0x003E5EEC File Offset: 0x003E40EC
		// (set) Token: 0x0601B722 RID: 112418 RVA: 0x003E5EF4 File Offset: 0x003E40F4
		public EVar VarTypeParam { get; set; }

		// Token: 0x17008054 RID: 32852
		// (get) Token: 0x0601B723 RID: 112419 RVA: 0x003E5EFD File Offset: 0x003E40FD
		// (set) Token: 0x0601B724 RID: 112420 RVA: 0x003E5F05 File Offset: 0x003E4105
		public ERefType TargetRefType { get; set; }

		// Token: 0x17008055 RID: 32853
		// (get) Token: 0x0601B725 RID: 112421 RVA: 0x003E5F0E File Offset: 0x003E410E
		// (set) Token: 0x0601B726 RID: 112422 RVA: 0x003E5F16 File Offset: 0x003E4116
		public int TargetRefId { get; set; }

		// Token: 0x0601B727 RID: 112423 RVA: 0x003E5F1F File Offset: 0x003E411F
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
