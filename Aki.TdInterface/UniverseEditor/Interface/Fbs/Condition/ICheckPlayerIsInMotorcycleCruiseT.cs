using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AF1 RID: 19185
	public class ICheckPlayerIsInMotorcycleCruiseT
	{
		// Token: 0x17008B1D RID: 35613
		// (get) Token: 0x0601E264 RID: 123492 RVA: 0x0043A744 File Offset: 0x00438944
		// (set) Token: 0x0601E265 RID: 123493 RVA: 0x0043A74C File Offset: 0x0043894C
		public ECondition Type { get; set; }

		// Token: 0x17008B1E RID: 35614
		// (get) Token: 0x0601E266 RID: 123494 RVA: 0x0043A755 File Offset: 0x00438955
		// (set) Token: 0x0601E267 RID: 123495 RVA: 0x0043A75D File Offset: 0x0043895D
		public bool IsInMotorcycleCruise { get; set; }

		// Token: 0x0601E268 RID: 123496 RVA: 0x0043A766 File Offset: 0x00438966
		public ICheckPlayerIsInMotorcycleCruiseT()
		{
			this.Type = ECondition.CompareVar;
			this.IsInMotorcycleCruise = false;
		}
	}
}
