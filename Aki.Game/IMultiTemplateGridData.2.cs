using System;
using System.Runtime.CompilerServices;

// Token: 0x02002CE1 RID: 11489
[NullableContext(1)]
public interface IMultiTemplateGridData
{
	// Token: 0x1700207E RID: 8318
	// (get) Token: 0x060181CB RID: 98763
	object Data { get; }

	// Token: 0x060181CC RID: 98764
	int GetTemplateIndex();

	// Token: 0x060181CD RID: 98765
	ISyncGridProxy CreateProxy();

	// Token: 0x060181CE RID: 98766 RVA: 0x00621EEC File Offset: 0x006200EC
	bool IsNavigable()
	{
		return true;
	}
}
