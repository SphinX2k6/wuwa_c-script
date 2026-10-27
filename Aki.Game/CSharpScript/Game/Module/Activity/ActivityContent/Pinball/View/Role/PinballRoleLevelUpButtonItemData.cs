using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006313 RID: 25363
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleLevelUpButtonItemData : IPinballRoleLevelUpButtonItemData
	{
		// Token: 0x170092E2 RID: 37602
		// (get) Token: 0x0603FCFA RID: 261370 RVA: 0x00F6FED0 File Offset: 0x00F6E0D0
		// (set) Token: 0x0603FCFB RID: 261371 RVA: 0x00F6FED8 File Offset: 0x00F6E0D8
		public int Times { get; set; }

		// Token: 0x170092E3 RID: 37603
		// (get) Token: 0x0603FCFC RID: 261372 RVA: 0x00F6FEE1 File Offset: 0x00F6E0E1
		// (set) Token: 0x0603FCFD RID: 261373 RVA: 0x00F6FEE9 File Offset: 0x00F6E0E9
		public bool IsToMaxLevel { get; set; }

		// Token: 0x170092E4 RID: 37604
		// (get) Token: 0x0603FCFE RID: 261374 RVA: 0x00F6FEF2 File Offset: 0x00F6E0F2
		// (set) Token: 0x0603FCFF RID: 261375 RVA: 0x00F6FEFA File Offset: 0x00F6E0FA
		public Action<int> ConfirmDelegate { get; set; }

		// Token: 0x170092E5 RID: 37605
		// (get) Token: 0x0603FD00 RID: 261376 RVA: 0x00F6FF03 File Offset: 0x00F6E103
		// (set) Token: 0x0603FD01 RID: 261377 RVA: 0x00F6FF0B File Offset: 0x00F6E10B
		public ICostData CostItemData { get; set; }
	}
}
