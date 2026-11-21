using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200533E RID: 21310
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffOverviewData : IMowingBuffOverviewData
	{
		// Token: 0x17006725 RID: 26405
		// (get) Token: 0x060350A6 RID: 217254 RVA: 0x00ED2797 File Offset: 0x00ED0997
		// (set) Token: 0x060350A7 RID: 217255 RVA: 0x00ED279F File Offset: 0x00ED099F
		public IMowingBuffIntroduceData IntroduceData { get; set; }

		// Token: 0x17006726 RID: 26406
		// (get) Token: 0x060350A8 RID: 217256 RVA: 0x00ED27A8 File Offset: 0x00ED09A8
		// (set) Token: 0x060350A9 RID: 217257 RVA: 0x00ED27B0 File Offset: 0x00ED09B0
		public IMowingBuffGridGroupData[] BuffGroupData { get; set; }
	}
}
