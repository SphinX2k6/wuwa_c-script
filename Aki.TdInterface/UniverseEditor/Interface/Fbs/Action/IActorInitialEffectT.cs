using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200672B RID: 26411
	public class IActorInitialEffectT
	{
		// Token: 0x1700BFFC RID: 49148
		// (get) Token: 0x0602CBCB RID: 183243 RVA: 0x0061EAB6 File Offset: 0x0061CCB6
		// (set) Token: 0x0602CBCC RID: 183244 RVA: 0x0061EABE File Offset: 0x0061CCBE
		public List<int> EffectIds { get; set; }

		// Token: 0x1700BFFD RID: 49149
		// (get) Token: 0x0602CBCD RID: 183245 RVA: 0x0061EAC7 File Offset: 0x0061CCC7
		// (set) Token: 0x0602CBCE RID: 183246 RVA: 0x0061EACF File Offset: 0x0061CCCF
		public List<int> EffectIdsMaleVariant { get; set; }

		// Token: 0x1700BFFE RID: 49150
		// (get) Token: 0x0602CBCF RID: 183247 RVA: 0x0061EAD8 File Offset: 0x0061CCD8
		// (set) Token: 0x0602CBD0 RID: 183248 RVA: 0x0061EAE0 File Offset: 0x0061CCE0
		public byte NullMask { get; set; }

		// Token: 0x0602CBD1 RID: 183249 RVA: 0x0061EAE9 File Offset: 0x0061CCE9
		public IActorInitialEffectT()
		{
			this.EffectIds = null;
			this.EffectIdsMaleVariant = null;
			this.NullMask = 0;
		}
	}
}
