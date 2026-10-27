using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046C4 RID: 18116
	public class ITeleportToPosT
	{
		// Token: 0x170080B9 RID: 32953
		// (get) Token: 0x0601B8A5 RID: 112805 RVA: 0x003E8617 File Offset: 0x003E6817
		// (set) Token: 0x0601B8A6 RID: 112806 RVA: 0x003E861F File Offset: 0x003E681F
		public EGmCommand Type { get; set; }

		// Token: 0x170080BA RID: 32954
		// (get) Token: 0x0601B8A7 RID: 112807 RVA: 0x003E8628 File Offset: 0x003E6828
		// (set) Token: 0x0601B8A8 RID: 112808 RVA: 0x003E8630 File Offset: 0x003E6830
		public IPosAT Pos { get; set; }

		// Token: 0x0601B8A9 RID: 112809 RVA: 0x003E8639 File Offset: 0x003E6839
		public ITeleportToPosT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Pos = null;
		}
	}
}
