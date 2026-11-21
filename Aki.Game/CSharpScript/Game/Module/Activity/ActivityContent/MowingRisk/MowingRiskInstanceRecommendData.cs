using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005342 RID: 21314
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskInstanceRecommendData : IMowingRiskInstanceRecommendData
	{
		// Token: 0x17006732 RID: 26418
		// (get) Token: 0x060350C2 RID: 217282 RVA: 0x00ED280D File Offset: 0x00ED0A0D
		// (set) Token: 0x060350C3 RID: 217283 RVA: 0x00ED2815 File Offset: 0x00ED0A15
		public string TextId { get; set; }

		// Token: 0x17006733 RID: 26419
		// (get) Token: 0x060350C4 RID: 217284 RVA: 0x00ED281E File Offset: 0x00ED0A1E
		// (set) Token: 0x060350C5 RID: 217285 RVA: 0x00ED2826 File Offset: 0x00ED0A26
		public string[] TextArgs { get; set; }

		// Token: 0x17006734 RID: 26420
		// (get) Token: 0x060350C6 RID: 217286 RVA: 0x00ED282F File Offset: 0x00ED0A2F
		// (set) Token: 0x060350C7 RID: 217287 RVA: 0x00ED2837 File Offset: 0x00ED0A37
		public int RecommendLevel { get; set; }
	}
}
