using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200797E RID: 31102
	public class IStandControlT
	{
		// Token: 0x1700E40F RID: 58383
		// (get) Token: 0x06036C72 RID: 224370 RVA: 0x00753C3E File Offset: 0x00751E3E
		// (set) Token: 0x06036C73 RID: 224371 RVA: 0x00753C46 File Offset: 0x00751E46
		public ELeisureInteract Type { get; set; }

		// Token: 0x06036C74 RID: 224372 RVA: 0x00753C4F File Offset: 0x00751E4F
		public IStandControlT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
