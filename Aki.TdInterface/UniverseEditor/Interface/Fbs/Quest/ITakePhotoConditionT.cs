using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A9 RID: 16809
	public class ITakePhotoConditionT
	{
		// Token: 0x17007735 RID: 30517
		// (get) Token: 0x06018BEE RID: 101358 RVA: 0x0039031C File Offset: 0x0038E51C
		// (set) Token: 0x06018BEF RID: 101359 RVA: 0x00390324 File Offset: 0x0038E524
		public EChildQuest Type { get; set; }

		// Token: 0x17007736 RID: 30518
		// (get) Token: 0x06018BF0 RID: 101360 RVA: 0x0039032D File Offset: 0x0038E52D
		// (set) Token: 0x06018BF1 RID: 101361 RVA: 0x00390335 File Offset: 0x0038E535
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007737 RID: 30519
		// (get) Token: 0x06018BF2 RID: 101362 RVA: 0x0039033E File Offset: 0x0038E53E
		// (set) Token: 0x06018BF3 RID: 101363 RVA: 0x00390346 File Offset: 0x0038E546
		public ITakePhotoTimeConditionT TimeCondition { get; set; }

		// Token: 0x17007738 RID: 30520
		// (get) Token: 0x06018BF4 RID: 101364 RVA: 0x0039034F File Offset: 0x0038E54F
		// (set) Token: 0x06018BF5 RID: 101365 RVA: 0x00390357 File Offset: 0x0038E557
		public ITakePhotoPosConditionT PosCondition { get; set; }

		// Token: 0x17007739 RID: 30521
		// (get) Token: 0x06018BF6 RID: 101366 RVA: 0x00390360 File Offset: 0x0038E560
		// (set) Token: 0x06018BF7 RID: 101367 RVA: 0x00390368 File Offset: 0x0038E568
		public List<IPhotoTargetT> PhotoTargets { get; set; }

		// Token: 0x06018BF8 RID: 101368 RVA: 0x00390371 File Offset: 0x0038E571
		public ITakePhotoConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.TimeCondition = null;
			this.PosCondition = null;
			this.PhotoTargets = null;
		}
	}
}
