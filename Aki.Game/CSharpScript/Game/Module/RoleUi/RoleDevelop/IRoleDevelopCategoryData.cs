using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CBB RID: 15547
	[NullableContext(1)]
	public interface IRoleDevelopCategoryData
	{
		// Token: 0x1700518B RID: 20875
		// (get) Token: 0x06027D9C RID: 163228
		// (set) Token: 0x06027D9D RID: 163229
		ERoleDevelopCategoryType CategoryType { get; set; }

		// Token: 0x1700518C RID: 20876
		// (get) Token: 0x06027D9E RID: 163230
		// (set) Token: 0x06027D9F RID: 163231
		string CategoryName { get; set; }
	}
}
