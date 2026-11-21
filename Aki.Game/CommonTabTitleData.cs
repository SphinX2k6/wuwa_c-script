using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E70 RID: 3696
[NullableContext(1)]
[Nullable(0)]
public class CommonTabTitleData
{
	// Token: 0x060093E5 RID: 37861 RVA: 0x002BF805 File Offset: 0x002BDA05
	public CommonTabTitleData(string textId, params object[] args)
	{
		this.TextId = textId;
		this.Args = args;
	}

	// Token: 0x1700103B RID: 4155
	// (get) Token: 0x060093E6 RID: 37862 RVA: 0x002BF81B File Offset: 0x002BDA1B
	public string TextId { get; }

	// Token: 0x1700103C RID: 4156
	// (get) Token: 0x060093E7 RID: 37863 RVA: 0x002BF823 File Offset: 0x002BDA23
	public object[] Args { get; }

	// Token: 0x040056F8 RID: 22264
	[Nullable(2)]
	public string RawText;
}
