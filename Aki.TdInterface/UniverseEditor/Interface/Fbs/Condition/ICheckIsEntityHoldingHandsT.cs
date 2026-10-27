using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A85 RID: 19077
	public class ICheckIsEntityHoldingHandsT
	{
		// Token: 0x17008A35 RID: 35381
		// (get) Token: 0x0601DEA6 RID: 122534 RVA: 0x00433984 File Offset: 0x00431B84
		// (set) Token: 0x0601DEA7 RID: 122535 RVA: 0x0043398C File Offset: 0x00431B8C
		public ECheckHoldingHandsCharacter Type { get; set; }

		// Token: 0x17008A36 RID: 35382
		// (get) Token: 0x0601DEA8 RID: 122536 RVA: 0x00433995 File Offset: 0x00431B95
		// (set) Token: 0x0601DEA9 RID: 122537 RVA: 0x0043399D File Offset: 0x00431B9D
		public int EntityId { get; set; }

		// Token: 0x0601DEAA RID: 122538 RVA: 0x004339A6 File Offset: 0x00431BA6
		public ICheckIsEntityHoldingHandsT()
		{
			this.Type = ECheckHoldingHandsCharacter.Player;
			this.EntityId = 0;
		}
	}
}
