using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F48 RID: 24392
	public class WheelTowerScoreLevelTargetData
	{
		// Token: 0x0603DFA0 RID: 253856 RVA: 0x00EF5CCE File Offset: 0x00EF3ECE
		public WheelTowerScoreLevelTargetData(int levelId, int score)
		{
			this.LevelId = levelId;
			this.Score = score;
		}

		// Token: 0x17008FB9 RID: 36793
		// (get) Token: 0x0603DFA1 RID: 253857 RVA: 0x00EF5CE4 File Offset: 0x00EF3EE4
		// (set) Token: 0x0603DFA2 RID: 253858 RVA: 0x00EF5CEC File Offset: 0x00EF3EEC
		public int LevelId { get; set; }

		// Token: 0x17008FBA RID: 36794
		// (get) Token: 0x0603DFA3 RID: 253859 RVA: 0x00EF5CF5 File Offset: 0x00EF3EF5
		// (set) Token: 0x0603DFA4 RID: 253860 RVA: 0x00EF5CFD File Offset: 0x00EF3EFD
		public int Score { get; set; }
	}
}
