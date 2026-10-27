using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005483 RID: 21635
	public class IIntervalSplineSpawnT
	{
		// Token: 0x17009F4B RID: 40779
		// (get) Token: 0x0602399D RID: 145821 RVA: 0x004EC513 File Offset: 0x004EA713
		// (set) Token: 0x0602399E RID: 145822 RVA: 0x004EC51B File Offset: 0x004EA71B
		public EPathDrivenActorSpawnType Type { get; set; }

		// Token: 0x17009F4C RID: 40780
		// (get) Token: 0x0602399F RID: 145823 RVA: 0x004EC524 File Offset: 0x004EA724
		// (set) Token: 0x060239A0 RID: 145824 RVA: 0x004EC52C File Offset: 0x004EA72C
		public string ActorBlueprintPath { get; set; }

		// Token: 0x17009F4D RID: 40781
		// (get) Token: 0x060239A1 RID: 145825 RVA: 0x004EC535 File Offset: 0x004EA735
		// (set) Token: 0x060239A2 RID: 145826 RVA: 0x004EC53D File Offset: 0x004EA73D
		public IPathDrivenActorSplineMoveT MoveMode { get; set; }

		// Token: 0x17009F4E RID: 40782
		// (get) Token: 0x060239A3 RID: 145827 RVA: 0x004EC546 File Offset: 0x004EA746
		// (set) Token: 0x060239A4 RID: 145828 RVA: 0x004EC54E File Offset: 0x004EA74E
		public float SpawnInterval { get; set; }

		// Token: 0x17009F4F RID: 40783
		// (get) Token: 0x060239A5 RID: 145829 RVA: 0x004EC557 File Offset: 0x004EA757
		// (set) Token: 0x060239A6 RID: 145830 RVA: 0x004EC55F File Offset: 0x004EA75F
		public int MaxActiveCount { get; set; }

		// Token: 0x17009F50 RID: 40784
		// (get) Token: 0x060239A7 RID: 145831 RVA: 0x004EC568 File Offset: 0x004EA768
		// (set) Token: 0x060239A8 RID: 145832 RVA: 0x004EC570 File Offset: 0x004EA770
		public float MaxSpawnInterval { get; set; }

		// Token: 0x17009F51 RID: 40785
		// (get) Token: 0x060239A9 RID: 145833 RVA: 0x004EC579 File Offset: 0x004EA779
		// (set) Token: 0x060239AA RID: 145834 RVA: 0x004EC581 File Offset: 0x004EA781
		public IPathDrivenActorInitialSpawnConfigT InitialSpawnConfig { get; set; }

		// Token: 0x17009F52 RID: 40786
		// (get) Token: 0x060239AB RID: 145835 RVA: 0x004EC58A File Offset: 0x004EA78A
		// (set) Token: 0x060239AC RID: 145836 RVA: 0x004EC592 File Offset: 0x004EA792
		public IIntervalSplineSpawnAllActorAudioT AudioConfig { get; set; }

		// Token: 0x17009F53 RID: 40787
		// (get) Token: 0x060239AD RID: 145837 RVA: 0x004EC59B File Offset: 0x004EA79B
		// (set) Token: 0x060239AE RID: 145838 RVA: 0x004EC5A3 File Offset: 0x004EA7A3
		public byte NullMask { get; set; }

		// Token: 0x060239AF RID: 145839 RVA: 0x004EC5AC File Offset: 0x004EA7AC
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
