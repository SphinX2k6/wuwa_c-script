using System;
using System.Runtime.CompilerServices;

// Token: 0x02002527 RID: 9511
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SettingViewLeftThemeItemData : MultiTemplateGridDataBase<PhoneMsgThemeItemData, PhoneMsgThemeItem>
{
	// Token: 0x06013208 RID: 78344 RVA: 0x004BF7BF File Offset: 0x004BD9BF
	public override int GetTemplateIndex()
	{
		return 2;
	}

	// Token: 0x06013209 RID: 78345 RVA: 0x004BF7C2 File Offset: 0x004BD9C2
	public override PhoneMsgThemeItem CreateProxy()
	{
		return new PhoneMsgThemeItem
		{
			OnToggleCallBack = this.OnToggleCallBack
		};
	}

	// Token: 0x0601320A RID: 78346 RVA: 0x004BF7D5 File Offset: 0x004BD9D5
	public SettingViewLeftThemeItemData(PhoneMsgThemeItemData themeData)
	{
		base.Data = themeData;
	}

	// Token: 0x0601320B RID: 78347 RVA: 0x004BF7E4 File Offset: 0x004BD9E4
	public int GetThemeId()
	{
		return base.Data.ThemeId;
	}

	// Token: 0x0400906A RID: 36970
	public int Index;

	// Token: 0x0400906B RID: 36971
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgThemeItemData> OnToggleCallBack;
}
