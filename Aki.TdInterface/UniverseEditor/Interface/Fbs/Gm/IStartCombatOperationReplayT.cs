using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046AC RID: 18092
	public class IStartCombatOperationReplayT
	{
		// Token: 0x17008083 RID: 32899
		// (get) Token: 0x0601B7D9 RID: 112601 RVA: 0x003E71BF File Offset: 0x003E53BF
		// (set) Token: 0x0601B7DA RID: 112602 RVA: 0x003E71C7 File Offset: 0x003E53C7
		public EGmCommand Type { get; set; }

		// Token: 0x17008084 RID: 32900
		// (get) Token: 0x0601B7DB RID: 112603 RVA: 0x003E71D0 File Offset: 0x003E53D0
		// (set) Token: 0x0601B7DC RID: 112604 RVA: 0x003E71D8 File Offset: 0x003E53D8
		public string FileId { get; set; }

		// Token: 0x0601B7DD RID: 112605 RVA: 0x003E71E1 File Offset: 0x003E53E1
		public IStartCombatOperationReplayT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.FileId = null;
		}
	}
}
