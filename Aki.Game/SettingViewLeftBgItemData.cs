using System;
using System.Runtime.CompilerServices;

// Token: 0x02002526 RID: 9510
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SettingViewLeftBgItemData : MultiTemplateGridDataBase<PhoneMsgBgItemData, PhoneMsgBgItem>
{
	// Token: 0x06013204 RID: 78340 RVA: 0x004BF78D File Offset: 0x004BD98D
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x06013205 RID: 78341 RVA: 0x004BF790 File Offset: 0x004BD990
	public override PhoneMsgBgItem CreateProxy()
	{
		return new PhoneMsgBgItem
		{
			OnToggleCallBack = this.OnToggleCallBack
		};
	}

	// Token: 0x06013206 RID: 78342 RVA: 0x004BF7A3 File Offset: 0x004BD9A3
	public SettingViewLeftBgItemData(PhoneMsgBgItemData bgData)
	{
		base.Data = bgData;
	}

	// Token: 0x06013207 RID: 78343 RVA: 0x004BF7B2 File Offset: 0x004BD9B2
	public int GetBgId()
	{
		return base.Data.BgId;
	}

	// Token: 0x04009068 RID: 36968
	public int Index;

	// Token: 0x04009069 RID: 36969
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgBgItemData> OnToggleCallBack;
}
