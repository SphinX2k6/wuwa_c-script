using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x0200543A RID: 21562
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeGameplayContext
	{
		// Token: 0x06035867 RID: 219239 RVA: 0x00EF2868 File Offset: 0x00EF0A68
		public MatchThreeGameplayContext(int levelId, string traceId, int roleId = 0, bool isGm = false)
		{
		}

		// Token: 0x1700682F RID: 26671
		// (get) Token: 0x06035868 RID: 219240 RVA: 0x00EF288D File Offset: 0x00EF0A8D
		public int LevelId { get; } = levelId;

		// Token: 0x17006830 RID: 26672
		// (get) Token: 0x06035869 RID: 219241 RVA: 0x00EF2895 File Offset: 0x00EF0A95
		public string TraceId { get; } = traceId;

		// Token: 0x17006831 RID: 26673
		// (get) Token: 0x0603586A RID: 219242 RVA: 0x00EF289D File Offset: 0x00EF0A9D
		public int RoleId { get; } = roleId;

		// Token: 0x17006832 RID: 26674
		// (get) Token: 0x0603586B RID: 219243 RVA: 0x00EF28A5 File Offset: 0x00EF0AA5
		public bool IsGm { get; } = isGm;
	}
}
