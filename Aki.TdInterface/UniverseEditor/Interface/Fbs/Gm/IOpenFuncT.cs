using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200467C RID: 18044
	public class IOpenFuncT
	{
		// Token: 0x17008023 RID: 32803
		// (get) Token: 0x0601B651 RID: 112209 RVA: 0x003E4B30 File Offset: 0x003E2D30
		// (set) Token: 0x0601B652 RID: 112210 RVA: 0x003E4B38 File Offset: 0x003E2D38
		public EGmCommand Type { get; set; }

		// Token: 0x17008024 RID: 32804
		// (get) Token: 0x0601B653 RID: 112211 RVA: 0x003E4B41 File Offset: 0x003E2D41
		// (set) Token: 0x0601B654 RID: 112212 RVA: 0x003E4B49 File Offset: 0x003E2D49
		public int FuncId { get; set; }

		// Token: 0x0601B655 RID: 112213 RVA: 0x003E4B52 File Offset: 0x003E2D52
		public IOpenFuncT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.FuncId = 0;
		}
	}
}
