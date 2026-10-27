using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02005384 RID: 21380
	[RequiredMember]
	public class MovieModeAspectOffset : IMovieModeAspectOffset
	{
		// Token: 0x17008385 RID: 33669
		// (get) Token: 0x060369FF RID: 223743 RVA: 0x00CEE7E8 File Offset: 0x00CEC9E8
		// (set) Token: 0x06036A00 RID: 223744 RVA: 0x00CEE7F0 File Offset: 0x00CEC9F0
		[RequiredMember]
		public bool IsFadeIn { get; set; }

		// Token: 0x17008386 RID: 33670
		// (get) Token: 0x06036A01 RID: 223745 RVA: 0x00CEE7F9 File Offset: 0x00CEC9F9
		// (set) Token: 0x06036A02 RID: 223746 RVA: 0x00CEE801 File Offset: 0x00CECA01
		[RequiredMember]
		public bool IsWidthBlend { get; set; }

		// Token: 0x17008387 RID: 33671
		// (get) Token: 0x06036A03 RID: 223747 RVA: 0x00CEE80A File Offset: 0x00CECA0A
		// (set) Token: 0x06036A04 RID: 223748 RVA: 0x00CEE812 File Offset: 0x00CECA12
		[RequiredMember]
		public float Offset { get; set; }

		// Token: 0x17008388 RID: 33672
		// (get) Token: 0x06036A05 RID: 223749 RVA: 0x00CEE81B File Offset: 0x00CECA1B
		// (set) Token: 0x06036A06 RID: 223750 RVA: 0x00CEE823 File Offset: 0x00CECA23
		[RequiredMember]
		public float Progress { get; set; }

		// Token: 0x06036A07 RID: 223751 RVA: 0x00CEE82C File Offset: 0x00CECA2C
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MovieModeAspectOffset()
		{
		}
	}
}
