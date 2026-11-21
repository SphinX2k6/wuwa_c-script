using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751D RID: 29981
	public class IPreloadTrialCharacterForSkillT
	{
		// Token: 0x1700DCA0 RID: 56480
		// (get) Token: 0x06034951 RID: 215377 RVA: 0x00713B17 File Offset: 0x00711D17
		// (set) Token: 0x06034952 RID: 215378 RVA: 0x00713B1F File Offset: 0x00711D1F
		public EPreloadObjectType Type { get; set; }

		// Token: 0x1700DCA1 RID: 56481
		// (get) Token: 0x06034953 RID: 215379 RVA: 0x00713B28 File Offset: 0x00711D28
		// (set) Token: 0x06034954 RID: 215380 RVA: 0x00713B30 File Offset: 0x00711D30
		public List<ICharacterGroupNewT> CharacterGroupNew { get; set; }

		// Token: 0x06034955 RID: 215381 RVA: 0x00713B39 File Offset: 0x00711D39
		public IPreloadTrialCharacterForSkillT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
			this.CharacterGroupNew = null;
		}
	}
}
