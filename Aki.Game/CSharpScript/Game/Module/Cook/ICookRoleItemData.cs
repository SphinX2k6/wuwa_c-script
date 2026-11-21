using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AEA RID: 19178
	[NullableContext(1)]
	public interface ICookRoleItemData
	{
		// Token: 0x17006055 RID: 24661
		// (get) Token: 0x0602FF8B RID: 196491
		// (set) Token: 0x0602FF8C RID: 196492
		int RoleId { get; set; }

		// Token: 0x17006056 RID: 24662
		// (get) Token: 0x0602FF8D RID: 196493
		// (set) Token: 0x0602FF8E RID: 196494
		string RoleName { get; set; }

		// Token: 0x17006057 RID: 24663
		// (get) Token: 0x0602FF8F RID: 196495
		// (set) Token: 0x0602FF90 RID: 196496
		string RoleIcon { get; set; }

		// Token: 0x17006058 RID: 24664
		// (get) Token: 0x0602FF91 RID: 196497
		// (set) Token: 0x0602FF92 RID: 196498
		bool IsBuff { get; set; }

		// Token: 0x17006059 RID: 24665
		// (get) Token: 0x0602FF93 RID: 196499
		// (set) Token: 0x0602FF94 RID: 196500
		int ItemId { get; set; }
	}
}
