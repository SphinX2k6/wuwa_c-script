using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200533D RID: 21309
	[NullableContext(1)]
	public interface IMowingBuffOverviewData
	{
		// Token: 0x17006723 RID: 26403
		// (get) Token: 0x060350A2 RID: 217250
		// (set) Token: 0x060350A3 RID: 217251
		IMowingBuffIntroduceData IntroduceData { get; set; }

		// Token: 0x17006724 RID: 26404
		// (get) Token: 0x060350A4 RID: 217252
		// (set) Token: 0x060350A5 RID: 217253
		IMowingBuffGridGroupData[] BuffGroupData { get; set; }
	}
}
