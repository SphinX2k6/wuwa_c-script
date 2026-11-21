using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FBC RID: 16316
	public class IShowTimelineCheckpointT
	{
		// Token: 0x17006E6C RID: 28268
		// (get) Token: 0x0601644D RID: 91213 RVA: 0x00330F88 File Offset: 0x0032F188
		// (set) Token: 0x0601644E RID: 91214 RVA: 0x00330F90 File Offset: 0x0032F190
		public EShowTimelineType Type { get; set; }

		// Token: 0x17006E6D RID: 28269
		// (get) Token: 0x0601644F RID: 91215 RVA: 0x00330F99 File Offset: 0x0032F199
		// (set) Token: 0x06016450 RID: 91216 RVA: 0x00330FA1 File Offset: 0x0032F1A1
		public bool IsEnabled { get; set; }

		// Token: 0x17006E6E RID: 28270
		// (get) Token: 0x06016451 RID: 91217 RVA: 0x00330FAA File Offset: 0x0032F1AA
		// (set) Token: 0x06016452 RID: 91218 RVA: 0x00330FB2 File Offset: 0x0032F1B2
		public int CheckpointId { get; set; }

		// Token: 0x17006E6F RID: 28271
		// (get) Token: 0x06016453 RID: 91219 RVA: 0x00330FBB File Offset: 0x0032F1BB
		// (set) Token: 0x06016454 RID: 91220 RVA: 0x00330FC3 File Offset: 0x0032F1C3
		public int ActiveRoleId { get; set; }

		// Token: 0x17006E70 RID: 28272
		// (get) Token: 0x06016455 RID: 91221 RVA: 0x00330FCC File Offset: 0x0032F1CC
		// (set) Token: 0x06016456 RID: 91222 RVA: 0x00330FD4 File Offset: 0x0032F1D4
		public List<IShowTimelineRoleStateT> RoleStates { get; set; }

		// Token: 0x17006E71 RID: 28273
		// (get) Token: 0x06016457 RID: 91223 RVA: 0x00330FDD File Offset: 0x0032F1DD
		// (set) Token: 0x06016458 RID: 91224 RVA: 0x00330FE5 File Offset: 0x0032F1E5
		public List<IShowTimelineMonsterStateT> MonsterStates { get; set; }

		// Token: 0x17006E72 RID: 28274
		// (get) Token: 0x06016459 RID: 91225 RVA: 0x00330FEE File Offset: 0x0032F1EE
		// (set) Token: 0x0601645A RID: 91226 RVA: 0x00330FF6 File Offset: 0x0032F1F6
		public ICheckpointDisplay_UnionUnion DisplayConfig { get; set; }

		// Token: 0x17006E73 RID: 28275
		// (get) Token: 0x0601645B RID: 91227 RVA: 0x00330FFF File Offset: 0x0032F1FF
		// (set) Token: 0x0601645C RID: 91228 RVA: 0x00331007 File Offset: 0x0032F207
		public string CustomName { get; set; }

		// Token: 0x17006E74 RID: 28276
		// (get) Token: 0x0601645D RID: 91229 RVA: 0x00331010 File Offset: 0x0032F210
		// (set) Token: 0x0601645E RID: 91230 RVA: 0x00331018 File Offset: 0x0032F218
		public IPosAT PlayerPosition { get; set; }

		// Token: 0x17006E75 RID: 28277
		// (get) Token: 0x0601645F RID: 91231 RVA: 0x00331021 File Offset: 0x0032F221
		// (set) Token: 0x06016460 RID: 91232 RVA: 0x00331029 File Offset: 0x0032F229
		public IPosAT MonsterPosition { get; set; }

		// Token: 0x06016461 RID: 91233 RVA: 0x00331034 File Offset: 0x0032F234
		public IShowTimelineCheckpointT()
		{
			this.Type = EShowTimelineType.Checkpoint;
			this.IsEnabled = false;
			this.CheckpointId = 0;
			this.ActiveRoleId = 0;
			this.RoleStates = null;
			this.MonsterStates = null;
			this.DisplayConfig = null;
			this.CustomName = null;
			this.PlayerPosition = null;
			this.MonsterPosition = null;
		}
	}
}
