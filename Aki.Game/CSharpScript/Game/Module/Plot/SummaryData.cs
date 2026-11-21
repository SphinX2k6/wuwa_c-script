using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FB3 RID: 16307
	[NullableContext(2)]
	[Nullable(0)]
	public class SummaryData
	{
		// Token: 0x17005383 RID: 21379
		// (get) Token: 0x0602943B RID: 169019 RVA: 0x00B978D2 File Offset: 0x00B95AD2
		// (set) Token: 0x0602943C RID: 169020 RVA: 0x00B978DA File Offset: 0x00B95ADA
		[Nullable(1)]
		public string Text { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005384 RID: 21380
		// (get) Token: 0x0602943D RID: 169021 RVA: 0x00B978E3 File Offset: 0x00B95AE3
		// (set) Token: 0x0602943E RID: 169022 RVA: 0x00B978EB File Offset: 0x00B95AEB
		public Action ConfirmFunc { get; set; }

		// Token: 0x17005385 RID: 21381
		// (get) Token: 0x0602943F RID: 169023 RVA: 0x00B978F4 File Offset: 0x00B95AF4
		// (set) Token: 0x06029440 RID: 169024 RVA: 0x00B978FC File Offset: 0x00B95AFC
		public Action CancelFunc { get; set; }
	}
}
