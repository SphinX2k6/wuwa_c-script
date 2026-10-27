using System;
using System.Runtime.CompilerServices;

// Token: 0x020019B0 RID: 6576
[NullableContext(1)]
[Nullable(0)]
public class CommonTabData
{
	// Token: 0x0600BFD1 RID: 49105 RVA: 0x002B473F File Offset: 0x002B293F
	[NullableContext(2)]
	public CommonTabData([Nullable(1)] string icon, CommonTabTitleData titleData, CommonTabTitleData tabItemTitleData = null)
	{
		this.Icon = icon;
		this.TitleData = titleData;
		this.TabItemTitleData = tabItemTitleData;
	}

	// Token: 0x0600BFD2 RID: 49106 RVA: 0x002B4767 File Offset: 0x002B2967
	public void SetSmallIcon(string icon)
	{
		this.SmallIcon = icon;
	}

	// Token: 0x0600BFD3 RID: 49107 RVA: 0x002B4770 File Offset: 0x002B2970
	public string GetSmallIcon()
	{
		if (string.IsNullOrEmpty(this.SmallIcon))
		{
			return this.GetIcon();
		}
		return this.SmallIcon;
	}

	// Token: 0x0600BFD4 RID: 49108 RVA: 0x002B478C File Offset: 0x002B298C
	public string GetIcon()
	{
		return this.Icon;
	}

	// Token: 0x0600BFD5 RID: 49109 RVA: 0x002B4794 File Offset: 0x002B2994
	[NullableContext(2)]
	public CommonTabTitleData GetTitleData()
	{
		return this.TitleData;
	}

	// Token: 0x0600BFD6 RID: 49110 RVA: 0x002B479C File Offset: 0x002B299C
	[NullableContext(2)]
	public CommonTabTitleData GetTabItemTitleData()
	{
		return this.TabItemTitleData;
	}

	// Token: 0x04005642 RID: 22082
	private readonly string Icon;

	// Token: 0x04005643 RID: 22083
	[Nullable(2)]
	private readonly CommonTabTitleData TitleData;

	// Token: 0x04005644 RID: 22084
	[Nullable(2)]
	private readonly CommonTabTitleData TabItemTitleData;

	// Token: 0x04005645 RID: 22085
	private string SmallIcon = "";
}
