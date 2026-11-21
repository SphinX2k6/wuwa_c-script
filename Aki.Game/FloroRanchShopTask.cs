using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x0200100A RID: 4106
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600A374 RID: 41844 RVA: 0x002FF066 File Offset: 0x002FD266
	public FloroRanchShopTask(FloroRanchShop data)
	{
		this.ShopData = data;
	}

	// Token: 0x0600A375 RID: 41845 RVA: 0x002FF078 File Offset: 0x002FD278
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

	// Token: 0x04006033 RID: 24627
	private readonly FloroRanchShop ShopData;
}
