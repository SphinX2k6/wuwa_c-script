using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D9C RID: 28060
	public class IPreloadPhantomCharacterForSkillT
	{
		// Token: 0x1700D14E RID: 53582
		// (get) Token: 0x0603191D RID: 203037 RVA: 0x006B7D64 File Offset: 0x006B5F64
		// (set) Token: 0x0603191E RID: 203038 RVA: 0x006B7D6C File Offset: 0x006B5F6C
		public EPreloadObjectType Type { get; set; }

		// Token: 0x1700D14F RID: 53583
		// (get) Token: 0x0603191F RID: 203039 RVA: 0x006B7D75 File Offset: 0x006B5F75
		// (set) Token: 0x06031920 RID: 203040 RVA: 0x006B7D7D File Offset: 0x006B5F7D
		public int Id { get; set; }

		// Token: 0x06031921 RID: 203041 RVA: 0x006B7D86 File Offset: 0x006B5F86
		public IPreloadPhantomCharacterForSkillT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
			this.Id = 0;
		}
	}
}
