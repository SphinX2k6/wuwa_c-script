using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C75 RID: 23669
	public class EntranceButtonParameter
	{
		// Token: 0x0401F2CC RID: 127692
		public ERedDotName? RedDotName;

		// Token: 0x0401F2CD RID: 127693
		public EFunctionType? FunctionType;

		// Token: 0x0401F2CE RID: 127694
		public EBattleUiChild ChildType;

		// Token: 0x0401F2CF RID: 127695
		public bool HideInGamepad;

		// Token: 0x0401F2D0 RID: 127696
		public bool HideByRoleConfig;

		// Token: 0x0401F2D1 RID: 127697
		[Nullable(2)]
		public string IconPath;
	}
}
