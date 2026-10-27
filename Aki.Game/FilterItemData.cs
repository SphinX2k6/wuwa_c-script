using System;
using System.Runtime.CompilerServices;

// Token: 0x0200184E RID: 6222
[NullableContext(2)]
[Nullable(0)]
public class FilterItemData
{
	// Token: 0x0600B641 RID: 46657 RVA: 0x00293526 File Offset: 0x00291726
	public FilterItemData(int filterId = 0, string content = null, string iconPath = null)
	{
		this.FilterId = filterId;
		this.Content = content;
		this.IconPath = iconPath;
	}

	// Token: 0x0600B642 RID: 46658 RVA: 0x0029354A File Offset: 0x0029174A
	public void SetIsShowIcon(bool value)
	{
		this.IsShowIcon = value;
	}

	// Token: 0x0600B643 RID: 46659 RVA: 0x00293553 File Offset: 0x00291753
	public string GetIconPath()
	{
		if (this.IsShowIcon)
		{
			return this.IconPath;
		}
		return null;
	}

	// Token: 0x04005261 RID: 21089
	private bool IsShowIcon = true;

	// Token: 0x04005262 RID: 21090
	public bool NeedChangeColor;

	// Token: 0x04005263 RID: 21091
	public int FilterId;

	// Token: 0x04005264 RID: 21092
	public string Content;

	// Token: 0x04005265 RID: 21093
	private readonly string IconPath;

	// Token: 0x04005266 RID: 21094
	public string ChangeColor;
}
