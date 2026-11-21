using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004996 RID: 18838
	public class INoBustResultT
	{
		// Token: 0x170083E2 RID: 33762
		// (get) Token: 0x0601C1FA RID: 115194 RVA: 0x003F94E0 File Offset: 0x003F76E0
		// (set) Token: 0x0601C1FB RID: 115195 RVA: 0x003F94E8 File Offset: 0x003F76E8
		public EDartSkillResultType Type { get; set; }

		// Token: 0x170083E3 RID: 33763
		// (get) Token: 0x0601C1FC RID: 115196 RVA: 0x003F94F1 File Offset: 0x003F76F1
		// (set) Token: 0x0601C1FD RID: 115197 RVA: 0x003F94F9 File Offset: 0x003F76F9
		public int Probability { get; set; }

		// Token: 0x0601C1FE RID: 115198 RVA: 0x003F9502 File Offset: 0x003F7702
		public INoBustResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.Probability = 0;
		}
	}
}
