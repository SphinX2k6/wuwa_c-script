using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200500D RID: 20493
	public class IConnectorPathAdvanceInitiatorT
	{
		// Token: 0x17009488 RID: 38024
		// (get) Token: 0x06020C8B RID: 134283 RVA: 0x0048F00F File Offset: 0x0048D20F
		// (set) Token: 0x06020C8C RID: 134284 RVA: 0x0048F017 File Offset: 0x0048D217
		public string ActiveState { get; set; }

		// Token: 0x17009489 RID: 38025
		// (get) Token: 0x06020C8D RID: 134285 RVA: 0x0048F020 File Offset: 0x0048D220
		// (set) Token: 0x06020C8E RID: 134286 RVA: 0x0048F028 File Offset: 0x0048D228
		public List<int> Paths { get; set; }

		// Token: 0x1700948A RID: 38026
		// (get) Token: 0x06020C8F RID: 134287 RVA: 0x0048F031 File Offset: 0x0048D231
		// (set) Token: 0x06020C90 RID: 134288 RVA: 0x0048F039 File Offset: 0x0048D239
		public int TargetEntity { get; set; }

		// Token: 0x1700948B RID: 38027
		// (get) Token: 0x06020C91 RID: 134289 RVA: 0x0048F042 File Offset: 0x0048D242
		// (set) Token: 0x06020C92 RID: 134290 RVA: 0x0048F04A File Offset: 0x0048D24A
		public float AdvanceSpeed { get; set; }

		// Token: 0x1700948C RID: 38028
		// (get) Token: 0x06020C93 RID: 134291 RVA: 0x0048F053 File Offset: 0x0048D253
		// (set) Token: 0x06020C94 RID: 134292 RVA: 0x0048F05B File Offset: 0x0048D25B
		public EConnectorPathAdvanceVisualType VisualType { get; set; }

		// Token: 0x1700948D RID: 38029
		// (get) Token: 0x06020C95 RID: 134293 RVA: 0x0048F064 File Offset: 0x0048D264
		// (set) Token: 0x06020C96 RID: 134294 RVA: 0x0048F06C File Offset: 0x0048D26C
		public IConnectorPathAdvanceVasePlantVisualT VisualConfig { get; set; }

		// Token: 0x1700948E RID: 38030
		// (get) Token: 0x06020C97 RID: 134295 RVA: 0x0048F075 File Offset: 0x0048D275
		// (set) Token: 0x06020C98 RID: 134296 RVA: 0x0048F07D File Offset: 0x0048D27D
		public List<IDynamicEntityMatchT> KeepConditions { get; set; }

		// Token: 0x1700948F RID: 38031
		// (get) Token: 0x06020C99 RID: 134297 RVA: 0x0048F086 File Offset: 0x0048D286
		// (set) Token: 0x06020C9A RID: 134298 RVA: 0x0048F08E File Offset: 0x0048D28E
		public byte NullMask { get; set; }

		// Token: 0x06020C9B RID: 134299 RVA: 0x0048F098 File Offset: 0x0048D298
		public IConnectorPathAdvanceInitiatorT()
		{
			this.ActiveState = null;
			this.Paths = null;
			this.TargetEntity = 0;
			this.AdvanceSpeed = 0f;
			this.VisualType = EConnectorPathAdvanceVisualType.VasePlant;
			this.VisualConfig = null;
			this.KeepConditions = null;
			this.NullMask = 0;
		}
	}
}
