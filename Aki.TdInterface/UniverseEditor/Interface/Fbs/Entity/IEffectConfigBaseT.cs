using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004785 RID: 18309
	public class IEffectConfigBaseT
	{
		// Token: 0x17008354 RID: 33620
		// (get) Token: 0x0601C31F RID: 115487 RVA: 0x003FE21E File Offset: 0x003FC41E
		// (set) Token: 0x0601C320 RID: 115488 RVA: 0x003FE226 File Offset: 0x003FC426
		public EEffectConfigType Type { get; set; }

		// Token: 0x0601C321 RID: 115489 RVA: 0x003FE22F File Offset: 0x003FC42F
		public IEffectConfigBaseT()
		{
			this.Type = EEffectConfigType.Death;
		}
	}
}
