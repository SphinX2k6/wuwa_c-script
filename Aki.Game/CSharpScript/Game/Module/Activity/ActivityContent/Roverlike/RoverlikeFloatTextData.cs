using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200506D RID: 20589
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeFloatTextData : IRoverlikeFloatTextData
	{
		// Token: 0x170064AE RID: 25774
		// (get) Token: 0x060338D4 RID: 211156 RVA: 0x00E6FB1A File Offset: 0x00E6DD1A
		// (set) Token: 0x060338D5 RID: 211157 RVA: 0x00E6FB22 File Offset: 0x00E6DD22
		public ERoverlikeFloatTextType Type { get; set; }

		// Token: 0x170064AF RID: 25775
		// (get) Token: 0x060338D6 RID: 211158 RVA: 0x00E6FB2B File Offset: 0x00E6DD2B
		// (set) Token: 0x060338D7 RID: 211159 RVA: 0x00E6FB33 File Offset: 0x00E6DD33
		public string TextKey { get; set; } = string.Empty;

		// Token: 0x170064B0 RID: 25776
		// (get) Token: 0x060338D8 RID: 211160 RVA: 0x00E6FB3C File Offset: 0x00E6DD3C
		// (set) Token: 0x060338D9 RID: 211161 RVA: 0x00E6FB44 File Offset: 0x00E6DD44
		public string[] TextParam { get; set; } = new string[0];
	}
}
