using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580C RID: 22540
	public class IFollowShooterInteractPointT
	{
		// Token: 0x1700A320 RID: 41760
		// (get) Token: 0x06024768 RID: 149352 RVA: 0x00502B33 File Offset: 0x00500D33
		// (set) Token: 0x06024769 RID: 149353 RVA: 0x00502B3B File Offset: 0x00500D3B
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A321 RID: 41761
		// (get) Token: 0x0602476A RID: 149354 RVA: 0x00502B44 File Offset: 0x00500D44
		// (set) Token: 0x0602476B RID: 149355 RVA: 0x00502B4C File Offset: 0x00500D4C
		public IThrowFollowShooterInteractConfigT ThrowInteractConfig { get; set; }

		// Token: 0x0602476C RID: 149356 RVA: 0x00502B55 File Offset: 0x00500D55
		public IFollowShooterInteractPointT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.ThrowInteractConfig = null;
		}
	}
}
