using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;

namespace CSharpScript.Game.LevelGamePlay.OperationRestrict
{
	// Token: 0x02006ABF RID: 27327
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkillOptionToInputAction
	{
		// Token: 0x17009967 RID: 39271
		// (get) Token: 0x06043E61 RID: 278113 RVA: 0x010A54E1 File Offset: 0x010A36E1
		// (set) Token: 0x06043E62 RID: 278114 RVA: 0x010A54E9 File Offset: 0x010A36E9
		public string OptionKey { get; set; }

		// Token: 0x17009968 RID: 39272
		// (get) Token: 0x06043E63 RID: 278115 RVA: 0x010A54F2 File Offset: 0x010A36F2
		// (set) Token: 0x06043E64 RID: 278116 RVA: 0x010A54FA File Offset: 0x010A36FA
		public EInputAction InputAction { get; set; }
	}
}
