using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035FC RID: 13820
	[NullableContext(1)]
	[Nullable(0)]
	public class PrepareLoadStruct : IPrepareLoadStruct
	{
		// Token: 0x1700492F RID: 18735
		// (get) Token: 0x06023305 RID: 144133 RVA: 0x009FF66D File Offset: 0x009FD86D
		// (set) Token: 0x06023306 RID: 144134 RVA: 0x009FF675 File Offset: 0x009FD875
		public string ResourceId { get; set; } = "";

		// Token: 0x17004930 RID: 18736
		// (get) Token: 0x06023307 RID: 144135 RVA: 0x009FF67E File Offset: 0x009FD87E
		// (set) Token: 0x06023308 RID: 144136 RVA: 0x009FF686 File Offset: 0x009FD886
		public Func<int> CacheCount { get; set; } = () => 0;
	}
}
