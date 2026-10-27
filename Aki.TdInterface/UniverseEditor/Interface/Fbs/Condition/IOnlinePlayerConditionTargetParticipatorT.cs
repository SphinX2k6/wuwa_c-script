using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C65 RID: 19557
	public class IOnlinePlayerConditionTargetParticipatorT
	{
		// Token: 0x17008E0E RID: 36366
		// (get) Token: 0x0601F029 RID: 127017 RVA: 0x00456028 File Offset: 0x00454228
		// (set) Token: 0x0601F02A RID: 127018 RVA: 0x00456030 File Offset: 0x00454230
		public EOnlinePlayerConditionTarget Type { get; set; }

		// Token: 0x17008E0F RID: 36367
		// (get) Token: 0x0601F02B RID: 127019 RVA: 0x00456039 File Offset: 0x00454239
		// (set) Token: 0x0601F02C RID: 127020 RVA: 0x00456041 File Offset: 0x00454241
		public bool AnyPlayer { get; set; }

		// Token: 0x0601F02D RID: 127021 RVA: 0x0045604A File Offset: 0x0045424A
		public IOnlinePlayerConditionTargetParticipatorT()
		{
			this.Type = EOnlinePlayerConditionTarget.Host;
			this.AnyPlayer = false;
		}
	}
}
