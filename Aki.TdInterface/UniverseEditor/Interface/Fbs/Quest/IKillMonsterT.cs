using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004308 RID: 17160
	public class IKillMonsterT
	{
		// Token: 0x1700758B RID: 30091
		// (get) Token: 0x06018216 RID: 98838 RVA: 0x003717B1 File Offset: 0x0036F9B1
		// (set) Token: 0x06018217 RID: 98839 RVA: 0x003717B9 File Offset: 0x0036F9B9
		public int NormalAddTime { get; set; }

		// Token: 0x1700758C RID: 30092
		// (get) Token: 0x06018218 RID: 98840 RVA: 0x003717C2 File Offset: 0x0036F9C2
		// (set) Token: 0x06018219 RID: 98841 RVA: 0x003717CA File Offset: 0x0036F9CA
		public List<IKillSingleMonsterT> SpecialTime { get; set; }

		// Token: 0x1700758D RID: 30093
		// (get) Token: 0x0601821A RID: 98842 RVA: 0x003717D3 File Offset: 0x0036F9D3
		// (set) Token: 0x0601821B RID: 98843 RVA: 0x003717DB File Offset: 0x0036F9DB
		public byte NullMask { get; set; }

		// Token: 0x0601821C RID: 98844 RVA: 0x003717E4 File Offset: 0x0036F9E4
		public IKillMonsterT()
		{
			this.NormalAddTime = 0;
			this.SpecialTime = null;
			this.NullMask = 0;
		}
	}
}
