using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064BC RID: 25788
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeGameplayContext
	{
		// Token: 0x06040BA3 RID: 265123 RVA: 0x00FAB820 File Offset: 0x00FA9A20
		public MatchThreeGameplayContext(int levelId, string traceId, int roleId = 0, bool isGm = false)
		{
		}

		// Token: 0x170094CD RID: 38093
		// (get) Token: 0x06040BA4 RID: 265124 RVA: 0x00FAB845 File Offset: 0x00FA9A45
		public int LevelId { get; } = levelId;

		// Token: 0x170094CE RID: 38094
		// (get) Token: 0x06040BA5 RID: 265125 RVA: 0x00FAB84D File Offset: 0x00FA9A4D
		public string TraceId { get; } = traceId;

		// Token: 0x170094CF RID: 38095
		// (get) Token: 0x06040BA6 RID: 265126 RVA: 0x00FAB855 File Offset: 0x00FA9A55
		public int RoleId { get; } = roleId;

		// Token: 0x170094D0 RID: 38096
		// (get) Token: 0x06040BA7 RID: 265127 RVA: 0x00FAB85D File Offset: 0x00FA9A5D
		public bool IsGm { get; } = isGm;
	}
}
