using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A0D RID: 6669
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SettingViewLeftBgItemData : MultiTemplateGridDataBase<PhoneMsgBgItemData, PhoneMsgBgItem>
{
	// Token: 0x060106C4 RID: 67268 RVA: 0x004CD499 File Offset: 0x004CB699
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x060106C5 RID: 67269 RVA: 0x004CD49C File Offset: 0x004CB69C
	public override PhoneMsgBgItem CreateProxy()
	{
		return new PhoneMsgBgItem
		{
			OnToggleCallBack = this.OnToggleCallBack
		};
	}

	// Token: 0x060106C6 RID: 67270 RVA: 0x004CD4AF File Offset: 0x004CB6AF
	public SettingViewLeftBgItemData(PhoneMsgBgItemData bgData)
	{
		base.Data = bgData;
	}

	// Token: 0x060106C7 RID: 67271 RVA: 0x004CD4BE File Offset: 0x004CB6BE
	public int GetBgId()
	{
		return base.Data.BgId;
	}

	// Token: 0x040091BD RID: 37309
	public int Index;

	// Token: 0x040091BE RID: 37310
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgBgItemData> OnToggleCallBack;
}
