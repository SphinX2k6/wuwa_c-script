using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E5F RID: 28255
	public class IRemovePreloadResourceCharacterTypeT
	{
		// Token: 0x1700D278 RID: 53880
		// (get) Token: 0x06031EE0 RID: 204512 RVA: 0x006C1576 File Offset: 0x006BF776
		// (set) Token: 0x06031EE1 RID: 204513 RVA: 0x006C157E File Offset: 0x006BF77E
		public ERemovePreloadResourceObjectType Type { get; set; }

		// Token: 0x06031EE2 RID: 204514 RVA: 0x006C1587 File Offset: 0x006BF787
		public IRemovePreloadResourceCharacterTypeT()
		{
			this.Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
		}
	}
}
