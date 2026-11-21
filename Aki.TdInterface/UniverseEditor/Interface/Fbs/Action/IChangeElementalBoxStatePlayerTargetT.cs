using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006947 RID: 26951
	public class IChangeElementalBoxStatePlayerTargetT
	{
		// Token: 0x1700C669 RID: 50793
		// (get) Token: 0x0602E336 RID: 189238 RVA: 0x0064FA8A File Offset: 0x0064DC8A
		// (set) Token: 0x0602E337 RID: 189239 RVA: 0x0064FA92 File Offset: 0x0064DC92
		public EChangeElementalBoxStateTargetType Type { get; set; }

		// Token: 0x0602E338 RID: 189240 RVA: 0x0064FA9B File Offset: 0x0064DC9B
		public IChangeElementalBoxStatePlayerTargetT()
		{
			this.Type = EChangeElementalBoxStateTargetType.Player;
		}
	}
}
