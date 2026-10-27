using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063B6 RID: 25526
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffProgressData : IMowingBuffProgressData
	{
		// Token: 0x1700938D RID: 37773
		// (get) Token: 0x06040374 RID: 263028 RVA: 0x00F8B5D9 File Offset: 0x00F897D9
		// (set) Token: 0x06040375 RID: 263029 RVA: 0x00F8B5E1 File Offset: 0x00F897E1
		public int ArtifactId { get; set; }

		// Token: 0x1700938E RID: 37774
		// (get) Token: 0x06040376 RID: 263030 RVA: 0x00F8B5EA File Offset: 0x00F897EA
		// (set) Token: 0x06040377 RID: 263031 RVA: 0x00F8B5F2 File Offset: 0x00F897F2
		public int CurBasicBuffCount { get; set; }

		// Token: 0x1700938F RID: 37775
		// (get) Token: 0x06040378 RID: 263032 RVA: 0x00F8B5FB File Offset: 0x00F897FB
		// (set) Token: 0x06040379 RID: 263033 RVA: 0x00F8B603 File Offset: 0x00F89803
		public int MaxBasicBuffCount { get; set; }

		// Token: 0x17009390 RID: 37776
		// (get) Token: 0x0604037A RID: 263034 RVA: 0x00F8B60C File Offset: 0x00F8980C
		// (set) Token: 0x0604037B RID: 263035 RVA: 0x00F8B614 File Offset: 0x00F89814
		public string CountTextId { get; set; }

		// Token: 0x17009391 RID: 37777
		// (get) Token: 0x0604037C RID: 263036 RVA: 0x00F8B61D File Offset: 0x00F8981D
		// (set) Token: 0x0604037D RID: 263037 RVA: 0x00F8B625 File Offset: 0x00F89825
		public string[] CountTextArgs { get; set; }

		// Token: 0x17009392 RID: 37778
		// (get) Token: 0x0604037E RID: 263038 RVA: 0x00F8B62E File Offset: 0x00F8982E
		// (set) Token: 0x0604037F RID: 263039 RVA: 0x00F8B636 File Offset: 0x00F89836
		public float ProgressPercentage { get; set; }

		// Token: 0x17009393 RID: 37779
		// (get) Token: 0x06040380 RID: 263040 RVA: 0x00F8B63F File Offset: 0x00F8983F
		// (set) Token: 0x06040381 RID: 263041 RVA: 0x00F8B647 File Offset: 0x00F89847
		public IMowingBuffUnitData[] SuperBuffList { get; set; }

		// Token: 0x17009394 RID: 37780
		// (get) Token: 0x06040382 RID: 263042 RVA: 0x00F8B650 File Offset: 0x00F89850
		// (set) Token: 0x06040383 RID: 263043 RVA: 0x00F8B658 File Offset: 0x00F89858
		public IMowingBuffIntroduceData IntroduceData { get; set; }
	}
}
