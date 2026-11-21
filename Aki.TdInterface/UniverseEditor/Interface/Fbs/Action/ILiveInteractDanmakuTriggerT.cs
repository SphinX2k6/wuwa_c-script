using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FE RID: 28926
	public class ILiveInteractDanmakuTriggerT
	{
		// Token: 0x1700D3D8 RID: 54232
		// (get) Token: 0x060323D7 RID: 205783 RVA: 0x006CB7C6 File Offset: 0x006C99C6
		// (set) Token: 0x060323D8 RID: 205784 RVA: 0x006CB7CE File Offset: 0x006C99CE
		public ELiveInteractDanmakuTriggerType Type { get; set; }

		// Token: 0x060323D9 RID: 205785 RVA: 0x006CB7D7 File Offset: 0x006C99D7
		public ILiveInteractDanmakuTriggerT()
		{
			this.Type = ELiveInteractDanmakuTriggerType.SkillGenre;
		}
	}
}
