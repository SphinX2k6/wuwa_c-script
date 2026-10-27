using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001CA RID: 458
	[NullableContext(1)]
	[Nullable(0)]
	public class KuroSdkController : IKuroSdkController
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0004B649 File Offset: 0x00049849
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x0004B651 File Offset: 0x00049851
		public Func<bool> CanUseSdk { get; set; }
	}
}
