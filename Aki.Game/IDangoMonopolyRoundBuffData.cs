using System;
using System.Runtime.CompilerServices;

// Token: 0x02001230 RID: 4656
[NullableContext(1)]
public interface IDangoMonopolyRoundBuffData
{
	// Token: 0x17000AA0 RID: 2720
	// (get) Token: 0x06007DDF RID: 32223
	int DangoId { get; }

	// Token: 0x17000AA1 RID: 2721
	// (get) Token: 0x06007DE0 RID: 32224
	int PropertyId { get; }

	// Token: 0x17000AA2 RID: 2722
	// (get) Token: 0x06007DE1 RID: 32225
	int GridId { get; }

	// Token: 0x17000AA3 RID: 2723
	// (get) Token: 0x06007DE2 RID: 32226
	bool IsActive { get; }

	// Token: 0x17000AA4 RID: 2724
	// (get) Token: 0x06007DE3 RID: 32227
	string DangoIcon { get; }

	// Token: 0x17000AA5 RID: 2725
	// (get) Token: 0x06007DE4 RID: 32228
	string DangoName { get; }

	// Token: 0x17000AA6 RID: 2726
	// (get) Token: 0x06007DE5 RID: 32229
	string PropertyDesc { get; }

	// Token: 0x17000AA7 RID: 2727
	// (get) Token: 0x06007DE6 RID: 32230
	string PropertyTitle { get; }
}
