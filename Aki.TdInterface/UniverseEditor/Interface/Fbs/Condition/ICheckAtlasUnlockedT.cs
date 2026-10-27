using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004986 RID: 18822
	public class ICheckAtlasUnlockedT
	{
		// Token: 0x170087F1 RID: 34801
		// (get) Token: 0x0601D586 RID: 120198 RVA: 0x004234E1 File Offset: 0x004216E1
		// (set) Token: 0x0601D587 RID: 120199 RVA: 0x004234E9 File Offset: 0x004216E9
		public ECondition Type { get; set; }

		// Token: 0x170087F2 RID: 34802
		// (get) Token: 0x0601D588 RID: 120200 RVA: 0x004234F2 File Offset: 0x004216F2
		// (set) Token: 0x0601D589 RID: 120201 RVA: 0x004234FA File Offset: 0x004216FA
		public TUnlockAtlasSystemOptionV2Union Atlas { get; set; }

		// Token: 0x170087F3 RID: 34803
		// (get) Token: 0x0601D58A RID: 120202 RVA: 0x00423503 File Offset: 0x00421703
		// (set) Token: 0x0601D58B RID: 120203 RVA: 0x0042350B File Offset: 0x0042170B
		public bool Unlocked { get; set; }

		// Token: 0x0601D58C RID: 120204 RVA: 0x00423514 File Offset: 0x00421714
		public ICheckAtlasUnlockedT()
		{
			this.Type = ECondition.CompareVar;
			this.Atlas = null;
			this.Unlocked = false;
		}
	}
}
