using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A4B RID: 19019
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopTabData : ITrapDefenseBuildingDevelopTabData
	{
		// Token: 0x17007A54 RID: 31316
		// (get) Token: 0x0603159F RID: 202143 RVA: 0x00B7233D File Offset: 0x00B7053D
		// (set) Token: 0x060315A0 RID: 202144 RVA: 0x00B72345 File Offset: 0x00B70545
		public ETrapDefenseBuildingDevelopTab TabType { get; set; }

		// Token: 0x17007A55 RID: 31317
		// (get) Token: 0x060315A1 RID: 202145 RVA: 0x00B7234E File Offset: 0x00B7054E
		// (set) Token: 0x060315A2 RID: 202146 RVA: 0x00B72356 File Offset: 0x00B70556
		public string Icon { get; set; } = "";

		// Token: 0x17007A56 RID: 31318
		// (get) Token: 0x060315A3 RID: 202147 RVA: 0x00B7235F File Offset: 0x00B7055F
		// (set) Token: 0x060315A4 RID: 202148 RVA: 0x00B72367 File Offset: 0x00B70567
		public string TabName { get; set; } = "";

		// Token: 0x17007A57 RID: 31319
		// (get) Token: 0x060315A5 RID: 202149 RVA: 0x00B72370 File Offset: 0x00B70570
		// (set) Token: 0x060315A6 RID: 202150 RVA: 0x00B72378 File Offset: 0x00B70578
		public ERedDotName? RedDot { get; set; }
	}
}
