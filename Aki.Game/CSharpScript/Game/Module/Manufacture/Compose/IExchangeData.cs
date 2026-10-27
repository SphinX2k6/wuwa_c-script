using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02005663 RID: 22115
	[NullableContext(1)]
	[Nullable(0)]
	public class IExchangeData : IBaseItemData
	{
		// Token: 0x17008762 RID: 34658
		// (get) Token: 0x0603841E RID: 230430 RVA: 0x00D556F0 File Offset: 0x00D538F0
		// (set) Token: 0x0603841F RID: 230431 RVA: 0x00D556F8 File Offset: 0x00D538F8
		public int ExchangeGroupId { get; set; }

		// Token: 0x17008763 RID: 34659
		// (get) Token: 0x06038420 RID: 230432 RVA: 0x00D55701 File Offset: 0x00D53901
		// (set) Token: 0x06038421 RID: 230433 RVA: 0x00D55709 File Offset: 0x00D53909
		public int LastRoleId { get; set; }

		// Token: 0x17008764 RID: 34660
		// (get) Token: 0x06038422 RID: 230434 RVA: 0x00D55712 File Offset: 0x00D53912
		// (set) Token: 0x06038423 RID: 230435 RVA: 0x00D5571A File Offset: 0x00D5391A
		public bool IsSingleDirection { get; set; }

		// Token: 0x17008765 RID: 34661
		// (get) Token: 0x06038424 RID: 230436 RVA: 0x00D55723 File Offset: 0x00D53923
		// (set) Token: 0x06038425 RID: 230437 RVA: 0x00D5572B File Offset: 0x00D5392B
		public int ExchangeParamId { get; set; }

		// Token: 0x17008766 RID: 34662
		// (get) Token: 0x06038426 RID: 230438 RVA: 0x00D55734 File Offset: 0x00D53934
		// (set) Token: 0x06038427 RID: 230439 RVA: 0x00D5573C File Offset: 0x00D5393C
		public int ExchangeConsume { get; set; }

		// Token: 0x17008767 RID: 34663
		// (get) Token: 0x06038428 RID: 230440 RVA: 0x00D55745 File Offset: 0x00D53945
		// (set) Token: 0x06038429 RID: 230441 RVA: 0x00D5574D File Offset: 0x00D5394D
		public int ExchangeTarget { get; set; }

		// Token: 0x17008768 RID: 34664
		// (get) Token: 0x0603842A RID: 230442 RVA: 0x00D55756 File Offset: 0x00D53956
		// (set) Token: 0x0603842B RID: 230443 RVA: 0x00D5575E File Offset: 0x00D5395E
		public int ExchangeTypeId { get; set; }

		// Token: 0x17008769 RID: 34665
		// (get) Token: 0x0603842C RID: 230444 RVA: 0x00D55767 File Offset: 0x00D53967
		// (set) Token: 0x0603842D RID: 230445 RVA: 0x00D5576F File Offset: 0x00D5396F
		public string ExchangeTypeDesc { get; set; } = "";
	}
}
