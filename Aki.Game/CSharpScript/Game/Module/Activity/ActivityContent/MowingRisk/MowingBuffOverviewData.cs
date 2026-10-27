using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063C0 RID: 25536
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffOverviewData : IMowingBuffOverviewData
	{
		// Token: 0x170093C3 RID: 37827
		// (get) Token: 0x060403E5 RID: 263141 RVA: 0x00F8B7FF File Offset: 0x00F899FF
		// (set) Token: 0x060403E6 RID: 263142 RVA: 0x00F8B807 File Offset: 0x00F89A07
		public IMowingBuffIntroduceData IntroduceData { get; set; }

		// Token: 0x170093C4 RID: 37828
		// (get) Token: 0x060403E7 RID: 263143 RVA: 0x00F8B810 File Offset: 0x00F89A10
		// (set) Token: 0x060403E8 RID: 263144 RVA: 0x00F8B818 File Offset: 0x00F89A18
		public IMowingBuffGridGroupData[] BuffGroupData { get; set; }
	}
}
