using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022AF RID: 8879
public class MotorcycleDiyStickerPanel : UiPanelBase
{
	// Token: 0x0601166F RID: 71279 RVA: 0x00443068 File Offset: 0x00441268
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnEnterClick))
		};
	}

	// Token: 0x06011670 RID: 71280 RVA: 0x0044313D File Offset: 0x0044133D
	protected override void OnStart()
	{
		this.PartBoxItemLayout = new GenericLayout<MotorcycleDiyOutlookBoxItem, MotorcycleDiyOutlookBoxItemData>(base.GetHorizontalLayout(3), new Func<MotorcycleDiyOutlookBoxItem>(this.CreatePartBoxItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
		this.SetEditable(true);
	}

	// Token: 0x06011671 RID: 71281 RVA: 0x00443177 File Offset: 0x00441377
	[NullableContext(1)]
	private MotorcycleDiyOutlookBoxItem CreatePartBoxItem()
	{
		return new MotorcycleDiyOutlookBoxItem();
	}

	// Token: 0x06011672 RID: 71282 RVA: 0x00443180 File Offset: 0x00441380
	[NullableContext(1)]
	public void Refresh(List<int> stickerIdList)
	{
		List<MotorcycleDiyOutlookBoxItemData> data = stickerIdList.Select((int id, int index) => new MotorcycleDiyOutlookBoxItemData(EOutlookType.Sticker, id, index)).ToList<MotorcycleDiyOutlookBoxItemData>();
		this.PartBoxItemLayout.RefreshByData(data, null, false);
		base.GetItem(5).SetUIActive(MotorcycleDiyModel.Instance.RedDotHasNewStickerByAnyPartVisible());
	}

	// Token: 0x06011673 RID: 71283 RVA: 0x004431DC File Offset: 0x004413DC
	public void SetEditable(bool isEditable)
	{
		base.GetItem(6).SetUIActive(!isEditable);
		base.GetItem(2).SetUIActive(isEditable);
	}

	// Token: 0x06011674 RID: 71284 RVA: 0x004431FC File Offset: 0x004413FC
	private void OnBtnEnterClick()
	{
		MotorcycleDiyModel.Instance.ResetSelectedItemInfo();
		OpenMotorcycleDiyRootViewData param = new OpenMotorcycleDiyRootViewData
		{
			OpenTabView = new EUiTabViewName?(EUiTabViewName.MotorcycleDiyStickerTabView),
			PartTabIndex = new int?(1),
			IsNeedResetMotor = new bool?(true)
		};
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyRootView, param, null);
	}

	// Token: 0x04008441 RID: 33857
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleDiyOutlookBoxItem, MotorcycleDiyOutlookBoxItemData> PartBoxItemLayout;

	// Token: 0x0200881B RID: 34843
	private class EMotorStickerDecorateComponent
	{
		// Token: 0x0402C3B2 RID: 181170
		public const int BtnEnter = 0;

		// Token: 0x0402C3B3 RID: 181171
		public const int TxtTitle = 1;

		// Token: 0x0402C3B4 RID: 181172
		public const int MotorPartItemScroll = 2;

		// Token: 0x0402C3B5 RID: 181173
		public const int Content = 3;

		// Token: 0x0402C3B6 RID: 181174
		public const int MotorPartItem = 4;

		// Token: 0x0402C3B7 RID: 181175
		public const int NewItem = 5;

		// Token: 0x0402C3B8 RID: 181176
		public const int LockItem = 6;
	}
}
