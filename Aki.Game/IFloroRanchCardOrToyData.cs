using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B0B RID: 6923
[NullableContext(1)]
public interface IFloroRanchCardOrToyData
{
	// Token: 0x17001131 RID: 4401
	// (get) Token: 0x0600CD85 RID: 52613
	int Id { get; }

	// Token: 0x0600CD86 RID: 52614
	string GetName();

	// Token: 0x17001132 RID: 4402
	// (get) Token: 0x0600CD87 RID: 52615
	string Name { get; }

	// Token: 0x17001133 RID: 4403
	// (get) Token: 0x0600CD88 RID: 52616
	string Desc { get; }

	// Token: 0x0600CD89 RID: 52617
	int GetRarity();

	// Token: 0x0600CD8A RID: 52618
	string GetIcon();
}
