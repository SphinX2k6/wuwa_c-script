using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5D RID: 27741
	public class IDisableRideFlyingCarUiGameplayT
	{
		// Token: 0x1700CB73 RID: 52083
		// (get) Token: 0x0602FC72 RID: 195698 RVA: 0x00681D86 File Offset: 0x0067FF86
		// (set) Token: 0x0602FC73 RID: 195699 RVA: 0x00681D8E File Offset: 0x0067FF8E
		public EToggleRideFlyingCarUiGameplayType Type { get; set; }

		// Token: 0x0602FC74 RID: 195700 RVA: 0x00681D97 File Offset: 0x0067FF97
		public IDisableRideFlyingCarUiGameplayT()
		{
			this.Type = EToggleRideFlyingCarUiGameplayType.Enable;
		}
	}
}
