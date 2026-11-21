using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E6E RID: 3694
[NullableContext(1)]
[Nullable(0)]
public class CommonTabData
{
	// Token: 0x060093DB RID: 37851 RVA: 0x002BF6CF File Offset: 0x002BD8CF
	[NullableContext(2)]
	public CommonTabData([Nullable(1)] string icon, CommonTabTitleData titleData, CommonTabTitleData tabItemTitleData = null)
	{
		this.Icon = icon;
		this.TitleData = titleData;
		this.TabItemTitleData = tabItemTitleData;
	}

	// Token: 0x060093DC RID: 37852 RVA: 0x002BF6F7 File Offset: 0x002BD8F7
	public void SetSmallIcon(string icon)
	{
		this.SmallIcon = icon;
	}

	// Token: 0x060093DD RID: 37853 RVA: 0x002BF700 File Offset: 0x002BD900
	public string GetSmallIcon()
	{
		if (string.IsNullOrEmpty(this.SmallIcon))
		{
			return this.GetIcon();
		}
		return this.SmallIcon;
	}

	// Token: 0x060093DE RID: 37854 RVA: 0x002BF71C File Offset: 0x002BD91C
	public string GetIcon()
	{
		return this.Icon;
	}

	// Token: 0x060093DF RID: 37855 RVA: 0x002BF724 File Offset: 0x002BD924
	[NullableContext(2)]
	public CommonTabTitleData GetTitleData()
	{
		return this.TitleData;
	}

	// Token: 0x060093E0 RID: 37856 RVA: 0x002BF72C File Offset: 0x002BD92C
	[NullableContext(2)]
	public CommonTabTitleData GetTabItemTitleData()
	{
		return this.TabItemTitleData;
	}

	// Token: 0x040056F4 RID: 22260
	private readonly string Icon;

	// Token: 0x040056F5 RID: 22261
	[Nullable(2)]
	private readonly CommonTabTitleData TitleData;

	// Token: 0x040056F6 RID: 22262
	[Nullable(2)]
	private readonly CommonTabTitleData TabItemTitleData;

	// Token: 0x040056F7 RID: 22263
	private string SmallIcon = "";
}
