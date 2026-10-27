using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA2 RID: 28066
	public class IPreloadTrialCharacterForSkillT
	{
		// Token: 0x1700D158 RID: 53592
		// (get) Token: 0x06031955 RID: 203093 RVA: 0x006B842F File Offset: 0x006B662F
		// (set) Token: 0x06031956 RID: 203094 RVA: 0x006B8437 File Offset: 0x006B6637
		public EPreloadObjectType Type { get; set; }

		// Token: 0x1700D159 RID: 53593
		// (get) Token: 0x06031957 RID: 203095 RVA: 0x006B8440 File Offset: 0x006B6640
		// (set) Token: 0x06031958 RID: 203096 RVA: 0x006B8448 File Offset: 0x006B6648
		public List<ICharacterGroupNewT> CharacterGroupNew { get; set; }

		// Token: 0x06031959 RID: 203097 RVA: 0x006B8451 File Offset: 0x006B6651
		public IPreloadTrialCharacterForSkillT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
			this.CharacterGroupNew = null;
		}
	}
}
