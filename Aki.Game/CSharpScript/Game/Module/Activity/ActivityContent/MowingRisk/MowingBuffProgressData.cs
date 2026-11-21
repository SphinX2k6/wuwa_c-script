using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005334 RID: 21300
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffProgressData : IMowingBuffProgressData
	{
		// Token: 0x170066EF RID: 26351
		// (get) Token: 0x06035035 RID: 217141 RVA: 0x00ED2571 File Offset: 0x00ED0771
		// (set) Token: 0x06035036 RID: 217142 RVA: 0x00ED2579 File Offset: 0x00ED0779
		public int ArtifactId { get; set; }

		// Token: 0x170066F0 RID: 26352
		// (get) Token: 0x06035037 RID: 217143 RVA: 0x00ED2582 File Offset: 0x00ED0782
		// (set) Token: 0x06035038 RID: 217144 RVA: 0x00ED258A File Offset: 0x00ED078A
		public int CurBasicBuffCount { get; set; }

		// Token: 0x170066F1 RID: 26353
		// (get) Token: 0x06035039 RID: 217145 RVA: 0x00ED2593 File Offset: 0x00ED0793
		// (set) Token: 0x0603503A RID: 217146 RVA: 0x00ED259B File Offset: 0x00ED079B
		public int MaxBasicBuffCount { get; set; }

		// Token: 0x170066F2 RID: 26354
		// (get) Token: 0x0603503B RID: 217147 RVA: 0x00ED25A4 File Offset: 0x00ED07A4
		// (set) Token: 0x0603503C RID: 217148 RVA: 0x00ED25AC File Offset: 0x00ED07AC
		public string CountTextId { get; set; }

		// Token: 0x170066F3 RID: 26355
		// (get) Token: 0x0603503D RID: 217149 RVA: 0x00ED25B5 File Offset: 0x00ED07B5
		// (set) Token: 0x0603503E RID: 217150 RVA: 0x00ED25BD File Offset: 0x00ED07BD
		public string[] CountTextArgs { get; set; }

		// Token: 0x170066F4 RID: 26356
		// (get) Token: 0x0603503F RID: 217151 RVA: 0x00ED25C6 File Offset: 0x00ED07C6
		// (set) Token: 0x06035040 RID: 217152 RVA: 0x00ED25CE File Offset: 0x00ED07CE
		public float ProgressPercentage { get; set; }

		// Token: 0x170066F5 RID: 26357
		// (get) Token: 0x06035041 RID: 217153 RVA: 0x00ED25D7 File Offset: 0x00ED07D7
		// (set) Token: 0x06035042 RID: 217154 RVA: 0x00ED25DF File Offset: 0x00ED07DF
		public IMowingBuffUnitData[] SuperBuffList { get; set; }

		// Token: 0x170066F6 RID: 26358
		// (get) Token: 0x06035043 RID: 217155 RVA: 0x00ED25E8 File Offset: 0x00ED07E8
		// (set) Token: 0x06035044 RID: 217156 RVA: 0x00ED25F0 File Offset: 0x00ED07F0
		public IMowingBuffIntroduceData IntroduceData { get; set; }
	}
}
