using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E9 RID: 30185
	public class IRemovePreloadResourceTrialCharacterT
	{
		// Token: 0x1700DDD7 RID: 56791
		// (get) Token: 0x06034F50 RID: 216912 RVA: 0x0071D85F File Offset: 0x0071BA5F
		// (set) Token: 0x06034F51 RID: 216913 RVA: 0x0071D867 File Offset: 0x0071BA67
		public ERemovePreloadResourceObjectType Type { get; set; }

		// Token: 0x1700DDD8 RID: 56792
		// (get) Token: 0x06034F52 RID: 216914 RVA: 0x0071D870 File Offset: 0x0071BA70
		// (set) Token: 0x06034F53 RID: 216915 RVA: 0x0071D878 File Offset: 0x0071BA78
		public List<int> CharacterGroup { get; set; }

		// Token: 0x06034F54 RID: 216916 RVA: 0x0071D881 File Offset: 0x0071BA81
		public IRemovePreloadResourceTrialCharacterT()
		{
			this.Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
			this.CharacterGroup = null;
		}
	}
}
