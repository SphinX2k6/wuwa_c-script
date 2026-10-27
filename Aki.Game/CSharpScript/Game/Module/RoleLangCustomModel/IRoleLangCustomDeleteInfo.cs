using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleLangCustomModel
{
	// Token: 0x02004D74 RID: 19828
	[NullableContext(1)]
	public interface IRoleLangCustomDeleteInfo
	{
		// Token: 0x17007E6F RID: 32367
		// (get) Token: 0x060333E0 RID: 209888
		// (set) Token: 0x060333E1 RID: 209889
		int RoleId { get; set; }

		// Token: 0x17007E70 RID: 32368
		// (get) Token: 0x060333E2 RID: 209890
		// (set) Token: 0x060333E3 RID: 209891
		Action RefreshCallback { get; set; }

		// Token: 0x17007E71 RID: 32369
		// (get) Token: 0x060333E4 RID: 209892
		// (set) Token: 0x060333E5 RID: 209893
		Action CloseCallback { get; set; }
	}
}
