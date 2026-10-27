using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060ED RID: 24813
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeFloatTextKeyPair : IRoverlikeFloatTextKeyPair
	{
		// Token: 0x17009147 RID: 37191
		// (get) Token: 0x0603EC07 RID: 257031 RVA: 0x00F28CC6 File Offset: 0x00F26EC6
		// (set) Token: 0x0603EC08 RID: 257032 RVA: 0x00F28CCE File Offset: 0x00F26ECE
		public string Increment { get; set; } = string.Empty;

		// Token: 0x17009148 RID: 37192
		// (get) Token: 0x0603EC09 RID: 257033 RVA: 0x00F28CD7 File Offset: 0x00F26ED7
		// (set) Token: 0x0603EC0A RID: 257034 RVA: 0x00F28CDF File Offset: 0x00F26EDF
		public string Decrements { get; set; } = string.Empty;
	}
}
