using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E6 RID: 30182
	public class IRemovePreloadResourcePhantomCharacterT
	{
		// Token: 0x1700DDD1 RID: 56785
		// (get) Token: 0x06034F30 RID: 216880 RVA: 0x0071D4E5 File Offset: 0x0071B6E5
		// (set) Token: 0x06034F31 RID: 216881 RVA: 0x0071D4ED File Offset: 0x0071B6ED
		public ERemovePreloadResourceObjectType Type { get; set; }

		// Token: 0x1700DDD2 RID: 56786
		// (get) Token: 0x06034F32 RID: 216882 RVA: 0x0071D4F6 File Offset: 0x0071B6F6
		// (set) Token: 0x06034F33 RID: 216883 RVA: 0x0071D4FE File Offset: 0x0071B6FE
		public int Id { get; set; }

		// Token: 0x1700DDD3 RID: 56787
		// (get) Token: 0x06034F34 RID: 216884 RVA: 0x0071D507 File Offset: 0x0071B707
		// (set) Token: 0x06034F35 RID: 216885 RVA: 0x0071D50F File Offset: 0x0071B70F
		public IDelayRemoveAfterSkillFinishT DelayReMove { get; set; }

		// Token: 0x06034F36 RID: 216886 RVA: 0x0071D518 File Offset: 0x0071B718
		public IRemovePreloadResourcePhantomCharacterT()
		{
			this.Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
			this.Id = 0;
			this.DelayReMove = null;
		}
	}
}
