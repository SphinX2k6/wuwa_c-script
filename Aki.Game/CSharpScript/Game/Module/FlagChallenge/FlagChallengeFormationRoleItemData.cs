using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A3C RID: 19004
	[NullableContext(2)]
	[Nullable(0)]
	public class FlagChallengeFormationRoleItemData : IFlagChallengeFormationRoleItemData
	{
		// Token: 0x17005FC8 RID: 24520
		// (get) Token: 0x0602F999 RID: 194969 RVA: 0x00D46832 File Offset: 0x00D44A32
		// (set) Token: 0x0602F99A RID: 194970 RVA: 0x00D4683A File Offset: 0x00D44A3A
		public int Index { get; set; }

		// Token: 0x17005FC9 RID: 24521
		// (get) Token: 0x0602F99B RID: 194971 RVA: 0x00D46843 File Offset: 0x00D44A43
		// (set) Token: 0x0602F99C RID: 194972 RVA: 0x00D4684B File Offset: 0x00D44A4B
		public RoleDataBase RoleData { get; set; }
	}
}
