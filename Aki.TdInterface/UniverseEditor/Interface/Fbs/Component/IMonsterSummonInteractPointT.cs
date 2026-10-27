using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A3 RID: 21923
	public class IMonsterSummonInteractPointT
	{
		// Token: 0x1700A1ED RID: 41453
		// (get) Token: 0x060244B3 RID: 148659 RVA: 0x00502ABB File Offset: 0x00500CBB
		// (set) Token: 0x060244B4 RID: 148660 RVA: 0x00502AC3 File Offset: 0x00500CC3
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A1EE RID: 41454
		// (get) Token: 0x060244B5 RID: 148661 RVA: 0x00502ACC File Offset: 0x00500CCC
		// (set) Token: 0x060244B6 RID: 148662 RVA: 0x00502AD4 File Offset: 0x00500CD4
		public float Range { get; set; }

		// Token: 0x1700A1EF RID: 41455
		// (get) Token: 0x060244B7 RID: 148663 RVA: 0x00502ADD File Offset: 0x00500CDD
		// (set) Token: 0x060244B8 RID: 148664 RVA: 0x00502AE5 File Offset: 0x00500CE5
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A1F0 RID: 41456
		// (get) Token: 0x060244B9 RID: 148665 RVA: 0x00502AEE File Offset: 0x00500CEE
		// (set) Token: 0x060244BA RID: 148666 RVA: 0x00502AF6 File Offset: 0x00500CF6
		public byte NullMask { get; set; }

		// Token: 0x060244BB RID: 148667 RVA: 0x00502AFF File Offset: 0x00500CFF
		public IMonsterSummonInteractPointT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.Range = 0f;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
