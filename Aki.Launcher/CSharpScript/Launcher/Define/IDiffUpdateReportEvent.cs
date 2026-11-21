using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200024B RID: 587
	[NullableContext(1)]
	public interface IDiffUpdateReportEvent
	{
		// Token: 0x06000EE6 RID: 3814
		void Start(HotPatchLog log, [Nullable(2)] string suffixTag = null);

		// Token: 0x06000EE7 RID: 3815
		void End(HotPatchLog log, [Nullable(2)] string suffixTag = null);

		// Token: 0x06000EE8 RID: 3816
		void Event(HotPatchLog log, [Nullable(2)] string suffixTag = null);
	}
}
