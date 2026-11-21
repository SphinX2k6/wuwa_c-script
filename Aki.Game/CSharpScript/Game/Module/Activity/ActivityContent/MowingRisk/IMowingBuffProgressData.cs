using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005333 RID: 21299
	[NullableContext(1)]
	public interface IMowingBuffProgressData
	{
		// Token: 0x170066E7 RID: 26343
		// (get) Token: 0x06035025 RID: 217125
		// (set) Token: 0x06035026 RID: 217126
		int ArtifactId { get; set; }

		// Token: 0x170066E8 RID: 26344
		// (get) Token: 0x06035027 RID: 217127
		// (set) Token: 0x06035028 RID: 217128
		int CurBasicBuffCount { get; set; }

		// Token: 0x170066E9 RID: 26345
		// (get) Token: 0x06035029 RID: 217129
		// (set) Token: 0x0603502A RID: 217130
		int MaxBasicBuffCount { get; set; }

		// Token: 0x170066EA RID: 26346
		// (get) Token: 0x0603502B RID: 217131
		// (set) Token: 0x0603502C RID: 217132
		string CountTextId { get; set; }

		// Token: 0x170066EB RID: 26347
		// (get) Token: 0x0603502D RID: 217133
		// (set) Token: 0x0603502E RID: 217134
		string[] CountTextArgs { get; set; }

		// Token: 0x170066EC RID: 26348
		// (get) Token: 0x0603502F RID: 217135
		// (set) Token: 0x06035030 RID: 217136
		float ProgressPercentage { get; set; }

		// Token: 0x170066ED RID: 26349
		// (get) Token: 0x06035031 RID: 217137
		// (set) Token: 0x06035032 RID: 217138
		IMowingBuffUnitData[] SuperBuffList { get; set; }

		// Token: 0x170066EE RID: 26350
		// (get) Token: 0x06035033 RID: 217139
		// (set) Token: 0x06035034 RID: 217140
		IMowingBuffIntroduceData IntroduceData { get; set; }
	}
}
