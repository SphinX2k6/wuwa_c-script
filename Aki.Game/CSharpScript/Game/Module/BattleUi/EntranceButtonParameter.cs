using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C55 RID: 19541
	public class EntranceButtonParameter
	{
		// Token: 0x04019D80 RID: 105856
		public ERedDotName? RedDotName;

		// Token: 0x04019D81 RID: 105857
		public EFunctionType? FunctionType;

		// Token: 0x04019D82 RID: 105858
		public EBattleUiChild ChildType;

		// Token: 0x04019D83 RID: 105859
		public bool HideInGamepad;

		// Token: 0x04019D84 RID: 105860
		public bool HideByRoleConfig;

		// Token: 0x04019D85 RID: 105861
		[Nullable(2)]
		public string IconPath;
	}
}
