using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A0F RID: 6671
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SettingViewLeftCharmItemData : MultiTemplateGridDataBase<PhoneMsgCharmItemData, PhoneMsgCharmItem>
{
	// Token: 0x060106CC RID: 67276 RVA: 0x004CD4FD File Offset: 0x004CB6FD
	public override int GetTemplateIndex()
	{
		return 3;
	}

	// Token: 0x060106CD RID: 67277 RVA: 0x004CD500 File Offset: 0x004CB700
	public override PhoneMsgCharmItem CreateProxy()
	{
		return new PhoneMsgCharmItem
		{
			OnToggleCallBack = this.OnToggleCallBack
		};
	}

	// Token: 0x060106CE RID: 67278 RVA: 0x004CD513 File Offset: 0x004CB713
	public SettingViewLeftCharmItemData(PhoneMsgCharmItemData charmData)
	{
		base.Data = charmData;
	}

	// Token: 0x060106CF RID: 67279 RVA: 0x004CD522 File Offset: 0x004CB722
	public int GetCharmId()
	{
		return base.Data.CharmId;
	}

	// Token: 0x040091C1 RID: 37313
	public int Index;

	// Token: 0x040091C2 RID: 37314
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgCharmItemData> OnToggleCallBack;
}
