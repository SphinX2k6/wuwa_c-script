using System;
using System.Runtime.CompilerServices;

// Token: 0x020007AB RID: 1963
[NullableContext(1)]
[Nullable(0)]
public class AdditionData : IAdditionData
{
	// Token: 0x17000BA0 RID: 2976
	// (get) Token: 0x060059DE RID: 23006 RVA: 0x001D3124 File Offset: 0x001D1324
	public string TextId { get; }

	// Token: 0x17000BA1 RID: 2977
	// (get) Token: 0x060059DF RID: 23007 RVA: 0x001D312C File Offset: 0x001D132C
	public string ValueText { get; }

	// Token: 0x060059E0 RID: 23008 RVA: 0x001D3134 File Offset: 0x001D1334
	public AdditionData(string textId, string valueText)
	{
		this.TextId = textId;
		this.ValueText = valueText;
	}
}
