using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005291 RID: 21137
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleLevelUpButtonItemData : IPinballRoleLevelUpButtonItemData
	{
		// Token: 0x17006644 RID: 26180
		// (get) Token: 0x060349BB RID: 215483 RVA: 0x00EB6E2C File Offset: 0x00EB502C
		// (set) Token: 0x060349BC RID: 215484 RVA: 0x00EB6E34 File Offset: 0x00EB5034
		public int Times { get; set; }

		// Token: 0x17006645 RID: 26181
		// (get) Token: 0x060349BD RID: 215485 RVA: 0x00EB6E3D File Offset: 0x00EB503D
		// (set) Token: 0x060349BE RID: 215486 RVA: 0x00EB6E45 File Offset: 0x00EB5045
		public bool IsToMaxLevel { get; set; }

		// Token: 0x17006646 RID: 26182
		// (get) Token: 0x060349BF RID: 215487 RVA: 0x00EB6E4E File Offset: 0x00EB504E
		// (set) Token: 0x060349C0 RID: 215488 RVA: 0x00EB6E56 File Offset: 0x00EB5056
		public Action<int> ConfirmDelegate { get; set; }

		// Token: 0x17006647 RID: 26183
		// (get) Token: 0x060349C1 RID: 215489 RVA: 0x00EB6E5F File Offset: 0x00EB505F
		// (set) Token: 0x060349C2 RID: 215490 RVA: 0x00EB6E67 File Offset: 0x00EB5067
		public ICostData CostItemData { get; set; }
	}
}
