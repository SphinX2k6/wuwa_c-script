using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B09 RID: 23305
	[NullableContext(1)]
	public interface ICookRoleItemData
	{
		// Token: 0x17008C7B RID: 35963
		// (get) Token: 0x0603B019 RID: 241689
		// (set) Token: 0x0603B01A RID: 241690
		int RoleId { get; set; }

		// Token: 0x17008C7C RID: 35964
		// (get) Token: 0x0603B01B RID: 241691
		// (set) Token: 0x0603B01C RID: 241692
		string RoleName { get; set; }

		// Token: 0x17008C7D RID: 35965
		// (get) Token: 0x0603B01D RID: 241693
		// (set) Token: 0x0603B01E RID: 241694
		string RoleIcon { get; set; }

		// Token: 0x17008C7E RID: 35966
		// (get) Token: 0x0603B01F RID: 241695
		// (set) Token: 0x0603B020 RID: 241696
		bool IsBuff { get; set; }

		// Token: 0x17008C7F RID: 35967
		// (get) Token: 0x0603B021 RID: 241697
		// (set) Token: 0x0603B022 RID: 241698
		int ItemId { get; set; }
	}
}
