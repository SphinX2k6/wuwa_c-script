using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052A4 RID: 21156
	public class IFollowShooterInteractPointT
	{
		// Token: 0x17009B22 RID: 39714
		// (get) Token: 0x060227CE RID: 141262 RVA: 0x004C7FC3 File Offset: 0x004C61C3
		// (set) Token: 0x060227CF RID: 141263 RVA: 0x004C7FCB File Offset: 0x004C61CB
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x17009B23 RID: 39715
		// (get) Token: 0x060227D0 RID: 141264 RVA: 0x004C7FD4 File Offset: 0x004C61D4
		// (set) Token: 0x060227D1 RID: 141265 RVA: 0x004C7FDC File Offset: 0x004C61DC
		public IThrowFollowShooterInteractConfigT ThrowInteractConfig { get; set; }

		// Token: 0x060227D2 RID: 141266 RVA: 0x004C7FE5 File Offset: 0x004C61E5
		public IFollowShooterInteractPointT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.ThrowInteractConfig = null;
		}
	}
}
