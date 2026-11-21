using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200487E RID: 18558
	public class ISubWpDataT
	{
		// Token: 0x17008136 RID: 33078
		// (get) Token: 0x0601B72B RID: 112427 RVA: 0x003E28A3 File Offset: 0x003E0AA3
		// (set) Token: 0x0601B72C RID: 112428 RVA: 0x003E28AB File Offset: 0x003E0AAB
		public int SubWpId { get; set; }

		// Token: 0x17008137 RID: 33079
		// (get) Token: 0x0601B72D RID: 112429 RVA: 0x003E28B4 File Offset: 0x003E0AB4
		// (set) Token: 0x0601B72E RID: 112430 RVA: 0x003E28BC File Offset: 0x003E0ABC
		public IVectorInfoT Location { get; set; }

		// Token: 0x0601B72F RID: 112431 RVA: 0x003E28C5 File Offset: 0x003E0AC5
		public ISubWpDataT()
		{
			this.SubWpId = 0;
			this.Location = null;
		}
	}
}
