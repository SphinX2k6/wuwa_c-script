using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A09 RID: 23049
	public class IIntervalSplineSpawnT
	{
		// Token: 0x1700A785 RID: 42885
		// (get) Token: 0x06025A55 RID: 154197 RVA: 0x00529587 File Offset: 0x00527787
		// (set) Token: 0x06025A56 RID: 154198 RVA: 0x0052958F File Offset: 0x0052778F
		public EPathDrivenActorSpawnType Type { get; set; }

		// Token: 0x1700A786 RID: 42886
		// (get) Token: 0x06025A57 RID: 154199 RVA: 0x00529598 File Offset: 0x00527798
		// (set) Token: 0x06025A58 RID: 154200 RVA: 0x005295A0 File Offset: 0x005277A0
		public string ActorBlueprintPath { get; set; }

		// Token: 0x1700A787 RID: 42887
		// (get) Token: 0x06025A59 RID: 154201 RVA: 0x005295A9 File Offset: 0x005277A9
		// (set) Token: 0x06025A5A RID: 154202 RVA: 0x005295B1 File Offset: 0x005277B1
		public IPathDrivenActorSplineMoveT MoveMode { get; set; }

		// Token: 0x1700A788 RID: 42888
		// (get) Token: 0x06025A5B RID: 154203 RVA: 0x005295BA File Offset: 0x005277BA
		// (set) Token: 0x06025A5C RID: 154204 RVA: 0x005295C2 File Offset: 0x005277C2
		public float SpawnInterval { get; set; }

		// Token: 0x1700A789 RID: 42889
		// (get) Token: 0x06025A5D RID: 154205 RVA: 0x005295CB File Offset: 0x005277CB
		// (set) Token: 0x06025A5E RID: 154206 RVA: 0x005295D3 File Offset: 0x005277D3
		public int MaxActiveCount { get; set; }

		// Token: 0x1700A78A RID: 42890
		// (get) Token: 0x06025A5F RID: 154207 RVA: 0x005295DC File Offset: 0x005277DC
		// (set) Token: 0x06025A60 RID: 154208 RVA: 0x005295E4 File Offset: 0x005277E4
		public float MaxSpawnInterval { get; set; }

		// Token: 0x1700A78B RID: 42891
		// (get) Token: 0x06025A61 RID: 154209 RVA: 0x005295ED File Offset: 0x005277ED
		// (set) Token: 0x06025A62 RID: 154210 RVA: 0x005295F5 File Offset: 0x005277F5
		public IPathDrivenActorInitialSpawnConfigT InitialSpawnConfig { get; set; }

		// Token: 0x1700A78C RID: 42892
		// (get) Token: 0x06025A63 RID: 154211 RVA: 0x005295FE File Offset: 0x005277FE
		// (set) Token: 0x06025A64 RID: 154212 RVA: 0x00529606 File Offset: 0x00527806
		public IIntervalSplineSpawnAllActorAudioT AudioConfig { get; set; }

		// Token: 0x1700A78D RID: 42893
		// (get) Token: 0x06025A65 RID: 154213 RVA: 0x0052960F File Offset: 0x0052780F
		// (set) Token: 0x06025A66 RID: 154214 RVA: 0x00529617 File Offset: 0x00527817
		public byte NullMask { get; set; }

		// Token: 0x06025A67 RID: 154215 RVA: 0x00529620 File Offset: 0x00527820
		public IIntervalSplineSpawnT()
		{
			this.Type = EPathDrivenActorSpawnType.IntervalSplineSpawn;
			this.ActorBlueprintPath = null;
			this.MoveMode = null;
			this.SpawnInterval = 0f;
			this.MaxActiveCount = 0;
			this.MaxSpawnInterval = 0f;
			this.InitialSpawnConfig = null;
			this.AudioConfig = null;
			this.NullMask = 0;
		}
	}
}
