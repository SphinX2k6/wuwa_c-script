using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02001B4B RID: 6987
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600CF63 RID: 53091 RVA: 0x002F3F8E File Offset: 0x002F218E
	public FloroRanchShopTask(FloroRanchShop data)
	{
		this.ShopData = data;
	}

	// Token: 0x0600CF64 RID: 53092 RVA: 0x002F3FA0 File Offset: 0x002F21A0
	protected override void OnExecute()
	{
		FloroRanchShopViewParam floroRanchShopViewParam = new FloroRanchShopViewParam
		{
			ShopData = this.ShopData,
			CloseCallback = delegate()
			{
				base.Complete(null);
			}
		};
		FloroRanchGamePlayModel.Instance.OpenAndRecordView(EUiViewName.FloroRanchShopView, floroRanchShopViewParam, null);
	}

	// Token: 0x04005F64 RID: 24420
	private readonly FloroRanchShop ShopData;
}
