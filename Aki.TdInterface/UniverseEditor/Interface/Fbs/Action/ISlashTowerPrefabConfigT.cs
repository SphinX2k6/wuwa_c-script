using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200713D RID: 28989
	public class ISlashTowerPrefabConfigT
	{
		// Token: 0x1700D769 RID: 55145
		// (get) Token: 0x0603364A RID: 210506 RVA: 0x006ED108 File Offset: 0x006EB308
		// (set) Token: 0x0603364B RID: 210507 RVA: 0x006ED110 File Offset: 0x006EB310
		public ECreatePrefabType Type { get; set; }

		// Token: 0x1700D76A RID: 55146
		// (get) Token: 0x0603364C RID: 210508 RVA: 0x006ED119 File Offset: 0x006EB319
		// (set) Token: 0x0603364D RID: 210509 RVA: 0x006ED121 File Offset: 0x006EB321
		public int Index { get; set; }

		// Token: 0x0603364E RID: 210510 RVA: 0x006ED12A File Offset: 0x006EB32A
		public ISlashTowerPrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
			this.Index = 0;
		}
	}
}
