using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200510D RID: 20749
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeLootViewOpenParam : IRoverlikeLootViewOpenParam
	{
		// Token: 0x1700654C RID: 25932
		// (get) Token: 0x06033E7D RID: 212605 RVA: 0x00E860C1 File Offset: 0x00E842C1
		// (set) Token: 0x06033E7E RID: 212606 RVA: 0x00E860C9 File Offset: 0x00E842C9
		public bool IsInGame { get; set; }

		// Token: 0x1700654D RID: 25933
		// (get) Token: 0x06033E7F RID: 212607 RVA: 0x00E860D2 File Offset: 0x00E842D2
		// (set) Token: 0x06033E80 RID: 212608 RVA: 0x00E860DA File Offset: 0x00E842DA
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RoverRogueGainEntry> Loots { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700654E RID: 25934
		// (get) Token: 0x06033E81 RID: 212609 RVA: 0x00E860E3 File Offset: 0x00E842E3
		// (set) Token: 0x06033E82 RID: 212610 RVA: 0x00E860EB File Offset: 0x00E842EB
		public bool? EnableUse { get; set; }

		// Token: 0x1700654F RID: 25935
		// (get) Token: 0x06033E83 RID: 212611 RVA: 0x00E860F4 File Offset: 0x00E842F4
		// (set) Token: 0x06033E84 RID: 212612 RVA: 0x00E860FC File Offset: 0x00E842FC
		public List<int> EquippedLootIds { get; set; }

		// Token: 0x17006550 RID: 25936
		// (get) Token: 0x06033E85 RID: 212613 RVA: 0x00E86105 File Offset: 0x00E84305
		// (set) Token: 0x06033E86 RID: 212614 RVA: 0x00E8610D File Offset: 0x00E8430D
		public Action<int, int> OnConfirmSelect { get; set; }

		// Token: 0x17006551 RID: 25937
		// (get) Token: 0x06033E87 RID: 212615 RVA: 0x00E86116 File Offset: 0x00E84316
		// (set) Token: 0x06033E88 RID: 212616 RVA: 0x00E8611E File Offset: 0x00E8431E
		public int DefaultSelectedLootId { get; set; }
	}
}
