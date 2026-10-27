using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060EF RID: 24815
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeFloatTextData : IRoverlikeFloatTextData
	{
		// Token: 0x1700914C RID: 37196
		// (get) Token: 0x0603EC12 RID: 257042 RVA: 0x00F28D06 File Offset: 0x00F26F06
		// (set) Token: 0x0603EC13 RID: 257043 RVA: 0x00F28D0E File Offset: 0x00F26F0E
		public ERoverlikeFloatTextType Type { get; set; }

		// Token: 0x1700914D RID: 37197
		// (get) Token: 0x0603EC14 RID: 257044 RVA: 0x00F28D17 File Offset: 0x00F26F17
		// (set) Token: 0x0603EC15 RID: 257045 RVA: 0x00F28D1F File Offset: 0x00F26F1F
		public string TextKey { get; set; } = string.Empty;

		// Token: 0x1700914E RID: 37198
		// (get) Token: 0x0603EC16 RID: 257046 RVA: 0x00F28D28 File Offset: 0x00F26F28
		// (set) Token: 0x0603EC17 RID: 257047 RVA: 0x00F28D30 File Offset: 0x00F26F30
		public string[] TextParam { get; set; } = new string[0];
	}
}
