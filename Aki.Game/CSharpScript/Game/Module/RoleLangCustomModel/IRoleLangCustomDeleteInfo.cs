using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleLangCustomModel
{
	// Token: 0x02003D3D RID: 15677
	[NullableContext(1)]
	public interface IRoleLangCustomDeleteInfo
	{
		// Token: 0x1700521F RID: 21023
		// (get) Token: 0x0602824E RID: 164430
		// (set) Token: 0x0602824F RID: 164431
		int RoleId { get; set; }

		// Token: 0x17005220 RID: 21024
		// (get) Token: 0x06028250 RID: 164432
		// (set) Token: 0x06028251 RID: 164433
		Action RefreshCallback { get; set; }

		// Token: 0x17005221 RID: 21025
		// (get) Token: 0x06028252 RID: 164434
		// (set) Token: 0x06028253 RID: 164435
		Action CloseCallback { get; set; }
	}
}
