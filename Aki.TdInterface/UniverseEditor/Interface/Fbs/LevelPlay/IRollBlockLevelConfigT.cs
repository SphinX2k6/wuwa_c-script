using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A0B RID: 18955
	public class IRollBlockLevelConfigT
	{
		// Token: 0x170084F1 RID: 34033
		// (get) Token: 0x0601C6F6 RID: 116470 RVA: 0x004042FB File Offset: 0x004024FB
		// (set) Token: 0x0601C6F7 RID: 116471 RVA: 0x00404303 File Offset: 0x00402503
		public int Difficulty { get; set; }

		// Token: 0x170084F2 RID: 34034
		// (get) Token: 0x0601C6F8 RID: 116472 RVA: 0x0040430C File Offset: 0x0040250C
		// (set) Token: 0x0601C6F9 RID: 116473 RVA: 0x00404314 File Offset: 0x00402514
		public IRollBlockBoardConfigT GridConfig { get; set; }

		// Token: 0x170084F3 RID: 34035
		// (get) Token: 0x0601C6FA RID: 116474 RVA: 0x0040431D File Offset: 0x0040251D
		// (set) Token: 0x0601C6FB RID: 116475 RVA: 0x00404325 File Offset: 0x00402525
		public int DefaultControlledBlockId { get; set; }

		// Token: 0x170084F4 RID: 34036
		// (get) Token: 0x0601C6FC RID: 116476 RVA: 0x0040432E File Offset: 0x0040252E
		// (set) Token: 0x0601C6FD RID: 116477 RVA: 0x00404336 File Offset: 0x00402536
		public int HintStepThreshold { get; set; }

		// Token: 0x170084F5 RID: 34037
		// (get) Token: 0x0601C6FE RID: 116478 RVA: 0x0040433F File Offset: 0x0040253F
		// (set) Token: 0x0601C6FF RID: 116479 RVA: 0x00404347 File Offset: 0x00402547
		public List<TRollBlockHintStepUnion> HintSteps { get; set; }

		// Token: 0x170084F6 RID: 34038
		// (get) Token: 0x0601C700 RID: 116480 RVA: 0x00404350 File Offset: 0x00402550
		// (set) Token: 0x0601C701 RID: 116481 RVA: 0x00404358 File Offset: 0x00402558
		public int RewardId { get; set; }

		// Token: 0x170084F7 RID: 34039
		// (get) Token: 0x0601C702 RID: 116482 RVA: 0x00404361 File Offset: 0x00402561
		// (set) Token: 0x0601C703 RID: 116483 RVA: 0x00404369 File Offset: 0x00402569
		public int SubCameraTag { get; set; }

		// Token: 0x170084F8 RID: 34040
		// (get) Token: 0x0601C704 RID: 116484 RVA: 0x00404372 File Offset: 0x00402572
		// (set) Token: 0x0601C705 RID: 116485 RVA: 0x0040437A File Offset: 0x0040257A
		public byte NullMask { get; set; }

		// Token: 0x0601C706 RID: 116486 RVA: 0x00404383 File Offset: 0x00402583
		public IRollBlockLevelConfigT()
		{
			this.Difficulty = 0;
			this.GridConfig = null;
			this.DefaultControlledBlockId = 0;
			this.HintStepThreshold = 0;
			this.HintSteps = null;
			this.RewardId = 0;
			this.SubCameraTag = 0;
			this.NullMask = 0;
		}
	}
}
