using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045A3 RID: 17827
	public class IRollBlockLevelConfigT
	{
		// Token: 0x17007EB0 RID: 32432
		// (get) Token: 0x0601AF21 RID: 110369 RVA: 0x003D805F File Offset: 0x003D625F
		// (set) Token: 0x0601AF22 RID: 110370 RVA: 0x003D8067 File Offset: 0x003D6267
		public int Difficulty { get; set; }

		// Token: 0x17007EB1 RID: 32433
		// (get) Token: 0x0601AF23 RID: 110371 RVA: 0x003D8070 File Offset: 0x003D6270
		// (set) Token: 0x0601AF24 RID: 110372 RVA: 0x003D8078 File Offset: 0x003D6278
		public IRollBlockBoardConfigT GridConfig { get; set; }

		// Token: 0x17007EB2 RID: 32434
		// (get) Token: 0x0601AF25 RID: 110373 RVA: 0x003D8081 File Offset: 0x003D6281
		// (set) Token: 0x0601AF26 RID: 110374 RVA: 0x003D8089 File Offset: 0x003D6289
		public int DefaultControlledBlockId { get; set; }

		// Token: 0x17007EB3 RID: 32435
		// (get) Token: 0x0601AF27 RID: 110375 RVA: 0x003D8092 File Offset: 0x003D6292
		// (set) Token: 0x0601AF28 RID: 110376 RVA: 0x003D809A File Offset: 0x003D629A
		public int HintStepThreshold { get; set; }

		// Token: 0x17007EB4 RID: 32436
		// (get) Token: 0x0601AF29 RID: 110377 RVA: 0x003D80A3 File Offset: 0x003D62A3
		// (set) Token: 0x0601AF2A RID: 110378 RVA: 0x003D80AB File Offset: 0x003D62AB
		public List<TRollBlockHintStepUnion> HintSteps { get; set; }

		// Token: 0x17007EB5 RID: 32437
		// (get) Token: 0x0601AF2B RID: 110379 RVA: 0x003D80B4 File Offset: 0x003D62B4
		// (set) Token: 0x0601AF2C RID: 110380 RVA: 0x003D80BC File Offset: 0x003D62BC
		public int RewardId { get; set; }

		// Token: 0x17007EB6 RID: 32438
		// (get) Token: 0x0601AF2D RID: 110381 RVA: 0x003D80C5 File Offset: 0x003D62C5
		// (set) Token: 0x0601AF2E RID: 110382 RVA: 0x003D80CD File Offset: 0x003D62CD
		public int SubCameraTag { get; set; }

		// Token: 0x17007EB7 RID: 32439
		// (get) Token: 0x0601AF2F RID: 110383 RVA: 0x003D80D6 File Offset: 0x003D62D6
		// (set) Token: 0x0601AF30 RID: 110384 RVA: 0x003D80DE File Offset: 0x003D62DE
		public byte NullMask { get; set; }

		// Token: 0x0601AF31 RID: 110385 RVA: 0x003D80E7 File Offset: 0x003D62E7
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
