using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200562F RID: 22063
	[NullableContext(1)]
	public interface IItemInfoData
	{
		// Token: 0x1700872E RID: 34606
		// (get) Token: 0x060381D8 RID: 229848
		// (set) Token: 0x060381D9 RID: 229849
		string TitleId { get; set; }

		// Token: 0x1700872F RID: 34607
		// (get) Token: 0x060381DA RID: 229850
		// (set) Token: 0x060381DB RID: 229851
		string Value { get; set; }

		// Token: 0x17008730 RID: 34608
		// (get) Token: 0x060381DC RID: 229852
		// (set) Token: 0x060381DD RID: 229853
		bool ValueChangeColor { get; set; }
	}
}
