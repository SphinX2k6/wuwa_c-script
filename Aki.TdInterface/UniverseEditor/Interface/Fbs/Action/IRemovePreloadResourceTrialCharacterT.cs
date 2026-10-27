using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E68 RID: 28264
	public class IRemovePreloadResourceTrialCharacterT
	{
		// Token: 0x1700D285 RID: 53893
		// (get) Token: 0x06031F28 RID: 204584 RVA: 0x006C1D5F File Offset: 0x006BFF5F
		// (set) Token: 0x06031F29 RID: 204585 RVA: 0x006C1D67 File Offset: 0x006BFF67
		public ERemovePreloadResourceObjectType Type { get; set; }

		// Token: 0x1700D286 RID: 53894
		// (get) Token: 0x06031F2A RID: 204586 RVA: 0x006C1D70 File Offset: 0x006BFF70
		// (set) Token: 0x06031F2B RID: 204587 RVA: 0x006C1D78 File Offset: 0x006BFF78
		public List<int> CharacterGroup { get; set; }

		// Token: 0x06031F2C RID: 204588 RVA: 0x006C1D81 File Offset: 0x006BFF81
		public IRemovePreloadResourceTrialCharacterT()
		{
			this.Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
			this.CharacterGroup = null;
		}
	}
}
