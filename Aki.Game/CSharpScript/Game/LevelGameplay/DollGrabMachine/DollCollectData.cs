using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006047 RID: 24647
	[RequiredMember]
	public class DollCollectData : IDollCollectData
	{
		// Token: 0x17006FF3 RID: 28659
		// (get) Token: 0x0603B27C RID: 242300 RVA: 0x010B90D2 File Offset: 0x010B72D2
		// (set) Token: 0x0603B27D RID: 242301 RVA: 0x010B90DA File Offset: 0x010B72DA
		[RequiredMember]
		public int CurrentCollectCount { get; set; }

		// Token: 0x17006FF4 RID: 28660
		// (get) Token: 0x0603B27E RID: 242302 RVA: 0x010B90E3 File Offset: 0x010B72E3
		// (set) Token: 0x0603B27F RID: 242303 RVA: 0x010B90EB File Offset: 0x010B72EB
		[RequiredMember]
		public int TotalCollectCount { get; set; }

		// Token: 0x17006FF5 RID: 28661
		// (get) Token: 0x0603B280 RID: 242304 RVA: 0x010B90F4 File Offset: 0x010B72F4
		// (set) Token: 0x0603B281 RID: 242305 RVA: 0x010B90FC File Offset: 0x010B72FC
		[RequiredMember]
		public int CurrentCollectItemCount { get; set; }

		// Token: 0x17006FF6 RID: 28662
		// (get) Token: 0x0603B282 RID: 242306 RVA: 0x010B9105 File Offset: 0x010B7305
		// (set) Token: 0x0603B283 RID: 242307 RVA: 0x010B910D File Offset: 0x010B730D
		[RequiredMember]
		public int TotalCollectItemCount { get; set; }

		// Token: 0x0603B284 RID: 242308 RVA: 0x010B9116 File Offset: 0x010B7316
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DollCollectData()
		{
		}
	}
}
