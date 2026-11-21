using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D07 RID: 3335
[NullableContext(2)]
[Nullable(0)]
public class FilterItemData
{
	// Token: 0x06008A2A RID: 35370 RVA: 0x0029DC36 File Offset: 0x0029BE36
	public FilterItemData(int filterId = 0, string content = null, string iconPath = null)
	{
		this.FilterId = filterId;
		this.Content = content;
		this.IconPath = iconPath;
	}

	// Token: 0x06008A2B RID: 35371 RVA: 0x0029DC5A File Offset: 0x0029BE5A
	public void SetIsShowIcon(bool value)
	{
		this.IsShowIcon = value;
	}

	// Token: 0x06008A2C RID: 35372 RVA: 0x0029DC63 File Offset: 0x0029BE63
	public string GetIconPath()
	{
		if (this.IsShowIcon)
		{
			return this.IconPath;
		}
		return null;
	}

	// Token: 0x0400530C RID: 21260
	private bool IsShowIcon = true;

	// Token: 0x0400530D RID: 21261
	public bool NeedChangeColor;

	// Token: 0x0400530E RID: 21262
	public int FilterId;

	// Token: 0x0400530F RID: 21263
	public string Content;

	// Token: 0x04005310 RID: 21264
	private readonly string IconPath;

	// Token: 0x04005311 RID: 21265
	public string ChangeColor;
}
