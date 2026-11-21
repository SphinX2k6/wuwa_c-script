using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045E4 RID: 17892
	public class ITakePhoto2TaggedActorTargetT
	{
		// Token: 0x17007D22 RID: 32034
		// (get) Token: 0x0601A237 RID: 107063 RVA: 0x003B9506 File Offset: 0x003B7706
		// (set) Token: 0x0601A238 RID: 107064 RVA: 0x003B950E File Offset: 0x003B770E
		public ETakePhoto2TargetType Type { get; set; }

		// Token: 0x17007D23 RID: 32035
		// (get) Token: 0x0601A239 RID: 107065 RVA: 0x003B9517 File Offset: 0x003B7717
		// (set) Token: 0x0601A23A RID: 107066 RVA: 0x003B951F File Offset: 0x003B771F
		public bool IsOptionalTarget { get; set; }

		// Token: 0x17007D24 RID: 32036
		// (get) Token: 0x0601A23B RID: 107067 RVA: 0x003B9528 File Offset: 0x003B7728
		// (set) Token: 0x0601A23C RID: 107068 RVA: 0x003B9530 File Offset: 0x003B7730
		public ITakePhoto2TargetCameraDistanceConditionT TargetCameraDistanceCondition { get; set; }

		// Token: 0x17007D25 RID: 32037
		// (get) Token: 0x0601A23D RID: 107069 RVA: 0x003B9539 File Offset: 0x003B7739
		// (set) Token: 0x0601A23E RID: 107070 RVA: 0x003B9541 File Offset: 0x003B7741
		public string Tag { get; set; }

		// Token: 0x17007D26 RID: 32038
		// (get) Token: 0x0601A23F RID: 107071 RVA: 0x003B954A File Offset: 0x003B774A
		// (set) Token: 0x0601A240 RID: 107072 RVA: 0x003B9552 File Offset: 0x003B7752
		public ITakePhoto2TargetPosByRangeConditionT TargetPosCondition { get; set; }

		// Token: 0x17007D27 RID: 32039
		// (get) Token: 0x0601A241 RID: 107073 RVA: 0x003B955B File Offset: 0x003B775B
		// (set) Token: 0x0601A242 RID: 107074 RVA: 0x003B9563 File Offset: 0x003B7763
		public int TargetSatisfiedCount { get; set; }

		// Token: 0x17007D28 RID: 32040
		// (get) Token: 0x0601A243 RID: 107075 RVA: 0x003B956C File Offset: 0x003B776C
		// (set) Token: 0x0601A244 RID: 107076 RVA: 0x003B9574 File Offset: 0x003B7774
		public byte NullMask { get; set; }

		// Token: 0x0601A245 RID: 107077 RVA: 0x003B957D File Offset: 0x003B777D
		public ITakePhoto2TaggedActorTargetT()
		{
			this.Type = ETakePhoto2TargetType.Entity;
			this.IsOptionalTarget = false;
			this.TargetCameraDistanceCondition = null;
			this.Tag = null;
			this.TargetPosCondition = null;
			this.TargetSatisfiedCount = 0;
			this.NullMask = 0;
		}
	}
}
