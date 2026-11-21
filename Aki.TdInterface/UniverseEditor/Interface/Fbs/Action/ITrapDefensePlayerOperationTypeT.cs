using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C5A RID: 31834
	public class ITrapDefensePlayerOperationTypeT
	{
		// Token: 0x1700EE4D RID: 61005
		// (get) Token: 0x0603961F RID: 235039 RVA: 0x007BF3BA File Offset: 0x007BD5BA
		// (set) Token: 0x06039620 RID: 235040 RVA: 0x007BF3C2 File Offset: 0x007BD5C2
		public ETrapDefensePlayerOperationType Type { get; set; }

		// Token: 0x06039621 RID: 235041 RVA: 0x007BF3CB File Offset: 0x007BD5CB
		public ITrapDefensePlayerOperationTypeT()
		{
			this.Type = ETrapDefensePlayerOperationType.SpawnMonster;
		}
	}
}
