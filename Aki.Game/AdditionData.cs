using System;
using System.Runtime.CompilerServices;

// Token: 0x020012F7 RID: 4855
[NullableContext(1)]
[Nullable(0)]
public class AdditionData : IAdditionData
{
	// Token: 0x17000B80 RID: 2944
	// (get) Token: 0x06008643 RID: 34371 RVA: 0x001CA2B8 File Offset: 0x001C84B8
	public string TextId { get; }

	// Token: 0x17000B81 RID: 2945
	// (get) Token: 0x06008644 RID: 34372 RVA: 0x001CA2C0 File Offset: 0x001C84C0
	public string ValueText { get; }

	// Token: 0x06008645 RID: 34373 RVA: 0x001CA2C8 File Offset: 0x001C84C8
	public AdditionData(string textId, string valueText)
	{
		this.TextId = textId;
		this.ValueText = valueText;
	}
}
