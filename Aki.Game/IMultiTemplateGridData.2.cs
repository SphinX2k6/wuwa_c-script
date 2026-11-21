using System;
using System.Runtime.CompilerServices;

// Token: 0x0200223A RID: 8762
[NullableContext(1)]
public interface IMultiTemplateGridData
{
	// Token: 0x170020D1 RID: 8401
	// (get) Token: 0x06015A4A RID: 88650
	object Data { get; }

	// Token: 0x06015A4B RID: 88651
	int GetTemplateIndex();

	// Token: 0x06015A4C RID: 88652
	ISyncGridProxy CreateProxy();

	// Token: 0x06015A4D RID: 88653 RVA: 0x00647B60 File Offset: 0x00645D60
	bool IsNavigable()
	{
		return true;
	}
}
