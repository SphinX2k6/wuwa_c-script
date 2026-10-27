using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D08 RID: 19720
	[NullableContext(1)]
	public interface IRoleDevelopCategoryData
	{
		// Token: 0x17007DE1 RID: 32225
		// (get) Token: 0x06032FC1 RID: 208833
		// (set) Token: 0x06032FC2 RID: 208834
		ERoleDevelopCategoryType CategoryType { get; set; }

		// Token: 0x17007DE2 RID: 32226
		// (get) Token: 0x06032FC3 RID: 208835
		// (set) Token: 0x06032FC4 RID: 208836
		string CategoryName { get; set; }
	}
}
