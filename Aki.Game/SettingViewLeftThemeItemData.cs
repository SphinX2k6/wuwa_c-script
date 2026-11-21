using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A0E RID: 6670
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SettingViewLeftThemeItemData : MultiTemplateGridDataBase<PhoneMsgThemeItemData, PhoneMsgThemeItem>
{
	// Token: 0x060106C8 RID: 67272 RVA: 0x004CD4CB File Offset: 0x004CB6CB
	public override int GetTemplateIndex()
	{
		return 2;
	}

	// Token: 0x060106C9 RID: 67273 RVA: 0x004CD4CE File Offset: 0x004CB6CE
	public override PhoneMsgThemeItem CreateProxy()
	{
		return new PhoneMsgThemeItem
		{
			OnToggleCallBack = this.OnToggleCallBack
		};
	}

	// Token: 0x060106CA RID: 67274 RVA: 0x004CD4E1 File Offset: 0x004CB6E1
	public SettingViewLeftThemeItemData(PhoneMsgThemeItemData themeData)
	{
		base.Data = themeData;
	}

	// Token: 0x060106CB RID: 67275 RVA: 0x004CD4F0 File Offset: 0x004CB6F0
	public int GetThemeId()
	{
		return base.Data.ThemeId;
	}

	// Token: 0x040091BF RID: 37311
	public int Index;

	// Token: 0x040091C0 RID: 37312
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgThemeItemData> OnToggleCallBack;
}
