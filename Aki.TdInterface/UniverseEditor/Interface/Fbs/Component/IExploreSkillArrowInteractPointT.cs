using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051DB RID: 20955
	public class IExploreSkillArrowInteractPointT
	{
		// Token: 0x1700995C RID: 39260
		// (get) Token: 0x06021FB8 RID: 139192 RVA: 0x004B6BB4 File Offset: 0x004B4DB4
		// (set) Token: 0x06021FB9 RID: 139193 RVA: 0x004B6BBC File Offset: 0x004B4DBC
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700995D RID: 39261
		// (get) Token: 0x06021FBA RID: 139194 RVA: 0x004B6BC5 File Offset: 0x004B4DC5
		// (set) Token: 0x06021FBB RID: 139195 RVA: 0x004B6BCD File Offset: 0x004B4DCD
		public float MinDistance { get; set; }

		// Token: 0x1700995E RID: 39262
		// (get) Token: 0x06021FBC RID: 139196 RVA: 0x004B6BD6 File Offset: 0x004B4DD6
		// (set) Token: 0x06021FBD RID: 139197 RVA: 0x004B6BDE File Offset: 0x004B4DDE
		public float InteractWaitTime { get; set; }

		// Token: 0x1700995F RID: 39263
		// (get) Token: 0x06021FBE RID: 139198 RVA: 0x004B6BE7 File Offset: 0x004B4DE7
		// (set) Token: 0x06021FBF RID: 139199 RVA: 0x004B6BEF File Offset: 0x004B4DEF
		public float ShootWaitTime { get; set; }

		// Token: 0x06021FC0 RID: 139200 RVA: 0x004B6BF8 File Offset: 0x004B4DF8
		public IExploreSkillArrowInteractPointT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.MinDistance = 0f;
			this.InteractWaitTime = 0f;
			this.ShootWaitTime = 0f;
		}
	}
}
