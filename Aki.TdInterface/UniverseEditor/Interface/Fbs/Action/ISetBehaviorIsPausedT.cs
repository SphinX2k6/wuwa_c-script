using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCA RID: 28618
	public class ISetBehaviorIsPausedT
	{
		// Token: 0x1700D477 RID: 54391
		// (get) Token: 0x06032954 RID: 207188 RVA: 0x006D34C2 File Offset: 0x006D16C2
		// (set) Token: 0x06032955 RID: 207189 RVA: 0x006D34CA File Offset: 0x006D16CA
		public bool IsPaused { get; set; }

		// Token: 0x06032956 RID: 207190 RVA: 0x006D34D3 File Offset: 0x006D16D3
		public ISetBehaviorIsPausedT()
		{
			this.IsPaused = false;
		}
	}
}
