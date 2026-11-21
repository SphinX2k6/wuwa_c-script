using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CBC RID: 15548
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopCategoryData : IRoleDevelopCategoryData
	{
		// Token: 0x1700518D RID: 20877
		// (get) Token: 0x06027DA0 RID: 163232 RVA: 0x00B27384 File Offset: 0x00B25584
		// (set) Token: 0x06027DA1 RID: 163233 RVA: 0x00B2738C File Offset: 0x00B2558C
		public ERoleDevelopCategoryType CategoryType { get; set; }

		// Token: 0x1700518E RID: 20878
		// (get) Token: 0x06027DA2 RID: 163234 RVA: 0x00B27395 File Offset: 0x00B25595
		// (set) Token: 0x06027DA3 RID: 163235 RVA: 0x00B2739D File Offset: 0x00B2559D
		public string CategoryName { get; set; }
	}
}
