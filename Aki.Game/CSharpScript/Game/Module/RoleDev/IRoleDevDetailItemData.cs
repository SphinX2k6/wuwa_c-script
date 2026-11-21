using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C6F RID: 15471
	[NullableContext(1)]
	public interface IRoleDevDetailItemData
	{
		// Token: 0x170050CF RID: 20687
		// (get) Token: 0x06027943 RID: 162115
		// (set) Token: 0x06027944 RID: 162116
		int RoleId { get; set; }

		// Token: 0x170050D0 RID: 20688
		// (get) Token: 0x06027945 RID: 162117
		// (set) Token: 0x06027946 RID: 162118
		ERoleDevMainPage MainPage { get; set; }

		// Token: 0x170050D1 RID: 20689
		// (get) Token: 0x06027947 RID: 162119
		// (set) Token: 0x06027948 RID: 162120
		ERoleDevSubPageButton ButtonType { get; set; }

		// Token: 0x170050D2 RID: 20690
		// (get) Token: 0x06027949 RID: 162121
		// (set) Token: 0x0602794A RID: 162122
		string Title { get; set; }

		// Token: 0x170050D3 RID: 20691
		// (get) Token: 0x0602794B RID: 162123
		// (set) Token: 0x0602794C RID: 162124
		int ItemGroupId { get; set; }

		// Token: 0x170050D4 RID: 20692
		// (get) Token: 0x0602794D RID: 162125
		// (set) Token: 0x0602794E RID: 162126
		List<IItemMaterial> ItemGroup { get; set; }
	}
}
