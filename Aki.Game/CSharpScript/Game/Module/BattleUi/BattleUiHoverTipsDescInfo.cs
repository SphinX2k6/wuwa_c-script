using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C5D RID: 19549
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiHoverTipsDescInfo : IBattleUiHoverTipsDescInfo
	{
		// Token: 0x170061A8 RID: 25000
		// (get) Token: 0x06030C87 RID: 199815 RVA: 0x00D9AC76 File Offset: 0x00D98E76
		// (set) Token: 0x06030C88 RID: 199816 RVA: 0x00D9AC7E File Offset: 0x00D98E7E
		public string DescKey { get; set; }

		// Token: 0x170061A9 RID: 25001
		// (get) Token: 0x06030C89 RID: 199817 RVA: 0x00D9AC87 File Offset: 0x00D98E87
		// (set) Token: 0x06030C8A RID: 199818 RVA: 0x00D9AC8F File Offset: 0x00D98E8F
		public bool? DescUseChangeColor { get; set; }

		// Token: 0x170061AA RID: 25002
		// (get) Token: 0x06030C8B RID: 199819 RVA: 0x00D9AC98 File Offset: 0x00D98E98
		// (set) Token: 0x06030C8C RID: 199820 RVA: 0x00D9ACA0 File Offset: 0x00D98EA0
		[Nullable(2)]
		public string StateTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170061AB RID: 25003
		// (get) Token: 0x06030C8D RID: 199821 RVA: 0x00D9ACA9 File Offset: 0x00D98EA9
		// (set) Token: 0x06030C8E RID: 199822 RVA: 0x00D9ACB1 File Offset: 0x00D98EB1
		public bool? IsUnlock { get; set; }

		// Token: 0x170061AC RID: 25004
		// (get) Token: 0x06030C8F RID: 199823 RVA: 0x00D9ACBA File Offset: 0x00D98EBA
		// (set) Token: 0x06030C90 RID: 199824 RVA: 0x00D9ACC2 File Offset: 0x00D98EC2
		public bool? IsShowState { get; set; }
	}
}
