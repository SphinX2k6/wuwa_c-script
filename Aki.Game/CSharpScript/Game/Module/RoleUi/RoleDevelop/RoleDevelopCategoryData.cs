using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D09 RID: 19721
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopCategoryData : IRoleDevelopCategoryData
	{
		// Token: 0x17007DE3 RID: 32227
		// (get) Token: 0x06032FC5 RID: 208837 RVA: 0x00BE1A7C File Offset: 0x00BDFC7C
		// (set) Token: 0x06032FC6 RID: 208838 RVA: 0x00BE1A84 File Offset: 0x00BDFC84
		public ERoleDevelopCategoryType CategoryType { get; set; }

		// Token: 0x17007DE4 RID: 32228
		// (get) Token: 0x06032FC7 RID: 208839 RVA: 0x00BE1A8D File Offset: 0x00BDFC8D
		// (set) Token: 0x06032FC8 RID: 208840 RVA: 0x00BE1A95 File Offset: 0x00BDFC95
		public string CategoryName { get; set; }
	}
}
