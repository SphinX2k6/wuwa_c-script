using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A60 RID: 23136
	[NullableContext(2)]
	[Nullable(0)]
	public class FlagChallengeFormationRoleItemData : IFlagChallengeFormationRoleItemData
	{
		// Token: 0x17008BFA RID: 35834
		// (get) Token: 0x0603AA50 RID: 240208 RVA: 0x00DF62AE File Offset: 0x00DF44AE
		// (set) Token: 0x0603AA51 RID: 240209 RVA: 0x00DF62B6 File Offset: 0x00DF44B6
		public int Index { get; set; }

		// Token: 0x17008BFB RID: 35835
		// (get) Token: 0x0603AA52 RID: 240210 RVA: 0x00DF62BF File Offset: 0x00DF44BF
		// (set) Token: 0x0603AA53 RID: 240211 RVA: 0x00DF62C7 File Offset: 0x00DF44C7
		public RoleDataBase RoleData { get; set; }
	}
}
