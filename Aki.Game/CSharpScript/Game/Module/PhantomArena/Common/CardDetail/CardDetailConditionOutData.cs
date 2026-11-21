using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041E9 RID: 16873
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailConditionOutData : ICardDetailConditionOutData
	{
		// Token: 0x170055D7 RID: 21975
		// (get) Token: 0x0602AAE5 RID: 174821 RVA: 0x00C06722 File Offset: 0x00C04922
		// (set) Token: 0x0602AAE6 RID: 174822 RVA: 0x00C0672A File Offset: 0x00C0492A
		public int CurrentProgress { get; set; }

		// Token: 0x170055D8 RID: 21976
		// (get) Token: 0x0602AAE7 RID: 174823 RVA: 0x00C06733 File Offset: 0x00C04933
		// (set) Token: 0x0602AAE8 RID: 174824 RVA: 0x00C0673B File Offset: 0x00C0493B
		public int MaxProgress { get; set; }

		// Token: 0x170055D9 RID: 21977
		// (get) Token: 0x0602AAE9 RID: 174825 RVA: 0x00C06744 File Offset: 0x00C04944
		// (set) Token: 0x0602AAEA RID: 174826 RVA: 0x00C0674C File Offset: 0x00C0494C
		public string Icon { get; set; }

		// Token: 0x170055DA RID: 21978
		// (get) Token: 0x0602AAEB RID: 174827 RVA: 0x00C06755 File Offset: 0x00C04955
		// (set) Token: 0x0602AAEC RID: 174828 RVA: 0x00C0675D File Offset: 0x00C0495D
		public string ConditionDesc { get; set; }

		// Token: 0x170055DB RID: 21979
		// (get) Token: 0x0602AAED RID: 174829 RVA: 0x00C06766 File Offset: 0x00C04966
		// (set) Token: 0x0602AAEE RID: 174830 RVA: 0x00C0676E File Offset: 0x00C0496E
		public string Title { get; set; }

		// Token: 0x170055DC RID: 21980
		// (get) Token: 0x0602AAEF RID: 174831 RVA: 0x00C06777 File Offset: 0x00C04977
		// (set) Token: 0x0602AAF0 RID: 174832 RVA: 0x00C0677F File Offset: 0x00C0497F
		public bool? TitleChangeColor { get; set; }
	}
}
