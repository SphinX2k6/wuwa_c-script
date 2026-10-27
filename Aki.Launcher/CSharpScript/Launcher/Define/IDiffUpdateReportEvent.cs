using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000246 RID: 582
	[NullableContext(1)]
	public interface IDiffUpdateReportEvent
	{
		// Token: 0x06000EA5 RID: 3749
		void Start(HotPatchLog log, [Nullable(2)] string suffixTag = null);

		// Token: 0x06000EA6 RID: 3750
		void End(HotPatchLog log, [Nullable(2)] string suffixTag = null);

		// Token: 0x06000EA7 RID: 3751
		void Event(HotPatchLog log, [Nullable(2)] string suffixTag = null);
	}
}
