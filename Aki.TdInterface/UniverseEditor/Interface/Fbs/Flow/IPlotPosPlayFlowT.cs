using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200474C RID: 18252
	public class IPlotPosPlayFlowT
	{
		// Token: 0x170082F6 RID: 33526
		// (get) Token: 0x0601C183 RID: 115075 RVA: 0x003FB0B7 File Offset: 0x003F92B7
		// (set) Token: 0x0601C184 RID: 115076 RVA: 0x003FB0BF File Offset: 0x003F92BF
		public string Guid { get; set; }

		// Token: 0x170082F7 RID: 33527
		// (get) Token: 0x0601C185 RID: 115077 RVA: 0x003FB0C8 File Offset: 0x003F92C8
		// (set) Token: 0x0601C186 RID: 115078 RVA: 0x003FB0D0 File Offset: 0x003F92D0
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0601C187 RID: 115079 RVA: 0x003FB0D9 File Offset: 0x003F92D9
		public IPlotPosPlayFlowT()
		{
			this.Guid = null;
			this.Pos = null;
		}
	}
}
