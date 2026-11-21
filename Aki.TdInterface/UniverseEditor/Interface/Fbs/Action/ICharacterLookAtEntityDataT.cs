using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B8 RID: 27064
	public class ICharacterLookAtEntityDataT
	{
		// Token: 0x1700C72B RID: 50987
		// (get) Token: 0x0602E6D2 RID: 190162 RVA: 0x00655D4C File Offset: 0x00653F4C
		// (set) Token: 0x0602E6D3 RID: 190163 RVA: 0x00655D54 File Offset: 0x00653F54
		public ECharacterLookAt Type { get; set; }

		// Token: 0x1700C72C RID: 50988
		// (get) Token: 0x0602E6D4 RID: 190164 RVA: 0x00655D5D File Offset: 0x00653F5D
		// (set) Token: 0x0602E6D5 RID: 190165 RVA: 0x00655D65 File Offset: 0x00653F65
		public int EntityId { get; set; }

		// Token: 0x0602E6D6 RID: 190166 RVA: 0x00655D6E File Offset: 0x00653F6E
		public ICharacterLookAtEntityDataT()
		{
			this.Type = ECharacterLookAt.Empty;
			this.EntityId = 0;
		}
	}
}
