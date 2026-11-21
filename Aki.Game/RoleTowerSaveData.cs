using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001CBB RID: 7355
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerSaveData
{
	// Token: 0x04009F31 RID: 40753
	public int LevelId;

	// Token: 0x04009F32 RID: 40754
	public int MainRoleId;

	// Token: 0x04009F33 RID: 40755
	public bool IsMainTrial;

	// Token: 0x04009F34 RID: 40756
	public List<int> AssistRoleIds = new List<int>();

	// Token: 0x04009F35 RID: 40757
	public int TeamStar;

	// Token: 0x04009F36 RID: 40758
	public bool HasTeamStarInfo;

	// Token: 0x04009F37 RID: 40759
	public int CarryTokenId;

	// Token: 0x04009F38 RID: 40760
	public int EchoLevel;

	// Token: 0x04009F39 RID: 40761
	public int EchoExp;

	// Token: 0x04009F3A RID: 40762
	public bool HasEchoInfo;

	// Token: 0x04009F3B RID: 40763
	public int CurStageId;

	// Token: 0x04009F3C RID: 40764
	public int CurFloorId;

	// Token: 0x04009F3D RID: 40765
	public int CurWaveIndex;

	// Token: 0x04009F3E RID: 40766
	public long DungeonRemainTime;

	// Token: 0x04009F3F RID: 40767
	public Dictionary<int, int> FatigueMap = new Dictionary<int, int>();

	// Token: 0x04009F40 RID: 40768
	public Dictionary<int, int> InitialTokens = new Dictionary<int, int>();
}
