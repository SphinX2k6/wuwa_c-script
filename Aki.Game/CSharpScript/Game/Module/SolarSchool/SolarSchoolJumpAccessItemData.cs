using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059D6 RID: 22998
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolJumpAccessItemData
	{
		// Token: 0x0401DD68 RID: 122216
		public SolarSchoolJumpAccessInfo Info;

		// Token: 0x0401DD69 RID: 122217
		public string TextId = string.Empty;

		// Token: 0x0401DD6A RID: 122218
		public string TextParam = string.Empty;

		// Token: 0x0401DD6B RID: 122219
		[Nullable(2)]
		public Action OnJump;
	}
}
