using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004969 RID: 18793
	public class ILevelPlayInteractResetOptionT
	{
		// Token: 0x1700837A RID: 33658
		// (get) Token: 0x0601C050 RID: 114768 RVA: 0x003F61BC File Offset: 0x003F43BC
		// (set) Token: 0x0601C051 RID: 114769 RVA: 0x003F61C4 File Offset: 0x003F43C4
		public int Count { get; set; }

		// Token: 0x1700837B RID: 33659
		// (get) Token: 0x0601C052 RID: 114770 RVA: 0x003F61CD File Offset: 0x003F43CD
		// (set) Token: 0x0601C053 RID: 114771 RVA: 0x003F61D5 File Offset: 0x003F43D5
		public ELevelPlayInteractResetTime Type { get; set; }

		// Token: 0x0601C054 RID: 114772 RVA: 0x003F61DE File Offset: 0x003F43DE
		public ILevelPlayInteractResetOptionT()
		{
			this.Count = 0;
			this.Type = ELevelPlayInteractResetTime.Weekly;
		}
	}
}
