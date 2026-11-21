using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;

namespace CSharpScript.Game.LevelGamePlay.OperationRestrict
{
	// Token: 0x02005C37 RID: 23607
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkillOptionToInputAction
	{
		// Token: 0x17006E6A RID: 28266
		// (get) Token: 0x06039FA8 RID: 237480 RVA: 0x0104EB11 File Offset: 0x0104CD11
		// (set) Token: 0x06039FA9 RID: 237481 RVA: 0x0104EB19 File Offset: 0x0104CD19
		public string OptionKey { get; set; }

		// Token: 0x17006E6B RID: 28267
		// (get) Token: 0x06039FAA RID: 237482 RVA: 0x0104EB22 File Offset: 0x0104CD22
		// (set) Token: 0x06039FAB RID: 237483 RVA: 0x0104EB2A File Offset: 0x0104CD2A
		public EInputAction InputAction { get; set; }
	}
}
