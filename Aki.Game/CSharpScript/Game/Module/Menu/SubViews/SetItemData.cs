using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200543E RID: 21566
	[NullableContext(1)]
	[Nullable(0)]
	public class SetItemData : ISetItemData
	{
		// Token: 0x17008440 RID: 33856
		// (get) Token: 0x06037111 RID: 225553 RVA: 0x00D0CFB6 File Offset: 0x00D0B1B6
		// (set) Token: 0x06037112 RID: 225554 RVA: 0x00D0CFBE File Offset: 0x00D0B1BE
		public int Index { get; set; }

		// Token: 0x17008441 RID: 33857
		// (get) Token: 0x06037113 RID: 225555 RVA: 0x00D0CFC7 File Offset: 0x00D0B1C7
		// (set) Token: 0x06037114 RID: 225556 RVA: 0x00D0CFCF File Offset: 0x00D0B1CF
		public int Value { get; set; }

		// Token: 0x17008442 RID: 33858
		// (get) Token: 0x06037115 RID: 225557 RVA: 0x00D0CFD8 File Offset: 0x00D0B1D8
		// (set) Token: 0x06037116 RID: 225558 RVA: 0x00D0CFE0 File Offset: 0x00D0B1E0
		public string Name { get; set; } = "";
	}
}
