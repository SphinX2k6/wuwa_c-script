using System;
using System.Runtime.CompilerServices;

// Token: 0x02002340 RID: 9024
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopTextData
{
	// Token: 0x06011E4E RID: 73294 RVA: 0x0046711C File Offset: 0x0046531C
	public void SetContent(string content)
	{
		this.Content = content;
		this.Data = null;
	}

	// Token: 0x06011E4F RID: 73295 RVA: 0x0046712C File Offset: 0x0046532C
	[NullableContext(2)]
	public void SetData(TableTextArgNew data)
	{
		this.Data = data;
		this.Content = "";
	}

	// Token: 0x04008787 RID: 34695
	public string Content = "";

	// Token: 0x04008788 RID: 34696
	[Nullable(2)]
	public TableTextArgNew Data;
}
