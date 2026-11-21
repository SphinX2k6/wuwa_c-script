using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DA2 RID: 3490
[NullableContext(1)]
public interface IButtonInfo
{
	// Token: 0x17000FAB RID: 4011
	// (get) Token: 0x06008EBE RID: 36542
	// (set) Token: 0x06008EBF RID: 36543
	Action<int> Function { get; set; }

	// Token: 0x17000FAC RID: 4012
	// (get) Token: 0x06008EC0 RID: 36544
	// (set) Token: 0x06008EC1 RID: 36545
	string Text { get; set; }

	// Token: 0x17000FAD RID: 4013
	// (get) Token: 0x06008EC2 RID: 36546
	// (set) Token: 0x06008EC3 RID: 36547
	int Index { get; set; }

	// Token: 0x17000FAE RID: 4014
	// (get) Token: 0x06008EC4 RID: 36548
	// (set) Token: 0x06008EC5 RID: 36549
	ERedDotName? RedDotName { get; set; }

	// Token: 0x17000FAF RID: 4015
	// (get) Token: 0x06008EC6 RID: 36550
	// (set) Token: 0x06008EC7 RID: 36551
	int? RedDotId { get; set; }
}
