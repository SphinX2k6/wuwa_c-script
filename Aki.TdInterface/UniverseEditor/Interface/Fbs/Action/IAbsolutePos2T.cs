using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C8 RID: 26312
	public class IAbsolutePos2T
	{
		// Token: 0x1700BF40 RID: 48960
		// (get) Token: 0x0602C33C RID: 181052 RVA: 0x00605027 File Offset: 0x00603227
		// (set) Token: 0x0602C33D RID: 181053 RVA: 0x0060502F File Offset: 0x0060322F
		public EPos2 Type { get; set; }

		// Token: 0x1700BF41 RID: 48961
		// (get) Token: 0x0602C33E RID: 181054 RVA: 0x00605038 File Offset: 0x00603238
		// (set) Token: 0x0602C33F RID: 181055 RVA: 0x00605040 File Offset: 0x00603240
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0602C340 RID: 181056 RVA: 0x00605049 File Offset: 0x00603249
		public IAbsolutePos2T()
		{
			this.Type = EPos2.Player;
			this.Pos = null;
		}
	}
}
