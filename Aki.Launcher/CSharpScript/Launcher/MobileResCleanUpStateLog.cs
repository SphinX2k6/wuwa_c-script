using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x02000053 RID: 83
	[NullableContext(1)]
	[Nullable(0)]
	public class MobileResCleanUpStateLog : HotPatchLogData
	{
		// Token: 0x0600026F RID: 623 RVA: 0x0000C6DC File Offset: 0x0000A8DC
		public MobileResCleanUpStateLog(int cleanUpSpace, string uniqueId, string traceId, List<MobileResCleanUpStateLogContentData> content, int type, [Nullable(2)] string playerId = null) : base("1713", uniqueId, playerId)
		{
			this.i_required_space = cleanUpSpace;
			this.s_trace_id = traceId;
			this.o_content = content;
			this.i_type = type;
		}

		// Token: 0x0400015B RID: 347
		public int i_required_space;

		// Token: 0x0400015C RID: 348
		public List<MobileResCleanUpStateLogContentData> o_content = new List<MobileResCleanUpStateLogContentData>();

		// Token: 0x0400015D RID: 349
		public int i_type;

		// Token: 0x0400015E RID: 350
		public string s_trace_id = "";
	}
}
