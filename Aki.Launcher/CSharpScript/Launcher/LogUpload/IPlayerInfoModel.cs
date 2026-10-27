using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C2 RID: 450
	[NullableContext(1)]
	public interface IPlayerInfoModel
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000C16 RID: 3094
		// (set) Token: 0x06000C17 RID: 3095
		Func<int?> GetId { get; set; }
	}
}
