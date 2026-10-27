using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200478E RID: 18318
	public class IEffectConfigMonsterDeathGroupT
	{
		// Token: 0x17008365 RID: 33637
		// (get) Token: 0x0601C36D RID: 115565 RVA: 0x003FEAD7 File Offset: 0x003FCCD7
		// (set) Token: 0x0601C36E RID: 115566 RVA: 0x003FEADF File Offset: 0x003FCCDF
		public EEffectConfigType Type { get; set; }

		// Token: 0x17008366 RID: 33638
		// (get) Token: 0x0601C36F RID: 115567 RVA: 0x003FEAE8 File Offset: 0x003FCCE8
		// (set) Token: 0x0601C370 RID: 115568 RVA: 0x003FEAF0 File Offset: 0x003FCCF0
		public List<IMonsterTagDeathEffectDataT> EffectGroup { get; set; }

		// Token: 0x0601C371 RID: 115569 RVA: 0x003FEAF9 File Offset: 0x003FCCF9
		public IEffectConfigMonsterDeathGroupT()
		{
			this.Type = EEffectConfigType.Death;
			this.EffectGroup = null;
		}
	}
}
