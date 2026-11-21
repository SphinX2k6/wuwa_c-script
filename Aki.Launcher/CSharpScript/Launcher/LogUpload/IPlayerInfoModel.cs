using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C6 RID: 454
	[NullableContext(1)]
	public interface IPlayerInfoModel
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000C4D RID: 3149
		// (set) Token: 0x06000C4E RID: 3150
		Func<int?> GetId { get; set; }
	}
}
