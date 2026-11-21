using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001793 RID: 6035
public class MotorcycleDiyStickerPanel : UiPanelBase
{
	// Token: 0x0600EB07 RID: 60167 RVA: 0x0044FC58 File Offset: 0x0044DE58
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

	// Token: 0x0600EB08 RID: 60168 RVA: 0x0044FD2D File Offset: 0x0044DF2D
	protected override void OnStart()
	{
		this.PartBoxItemLayout = new GenericLayout<MotorcycleDiyOutlookBoxItem, MotorcycleDiyOutlookBoxItemData>(base.GetHorizontalLayout(3), new Func<MotorcycleDiyOutlookBoxItem>(this.CreatePartBoxItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
		this.SetEditable(true);
	}

	// Token: 0x0600EB09 RID: 60169 RVA: 0x0044FD67 File Offset: 0x0044DF67
	[NullableContext(1)]
	private MotorcycleDiyOutlookBoxItem CreatePartBoxItem()
	{
		return new MotorcycleDiyOutlookBoxItem();
	}

	// Token: 0x0600EB0A RID: 60170 RVA: 0x0044FD70 File Offset: 0x0044DF70
	[NullableContext(1)]
	public void Refresh(List<int> stickerIdList)
	{
		List<MotorcycleDiyOutlookBoxItemData> list = new List<MotorcycleDiyOutlookBoxItemData>(stickerIdList.Count);
		for (int i = 0; i < stickerIdList.Count; i++)
		{
			list.Add(new MotorcycleDiyOutlookBoxItemData(EOutlookType.Sticker, stickerIdList[i], i));
		}
		this.PartBoxItemLayout.RefreshByData(list, null, false);
		base.GetItem(5).SetUIActive(MotorcycleDiyModel.Instance.RedDotHasNewStickerByAnyPartVisible());
	}

	// Token: 0x0600EB0B RID: 60171 RVA: 0x0044FDD2 File Offset: 0x0044DFD2
	public void SetEditable(bool isEditable)
	{
		base.GetItem(6).SetUIActive(!isEditable);
		base.GetItem(2).SetUIActive(isEditable);
	}

	// Token: 0x0600EB0C RID: 60172 RVA: 0x0044FDF4 File Offset: 0x0044DFF4
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

	// Token: 0x0400857F RID: 34175
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleDiyOutlookBoxItem, MotorcycleDiyOutlookBoxItemData> PartBoxItemLayout;

	// Token: 0x020079A0 RID: 31136
	private class EMotorStickerDecorateComponent
	{
		// Token: 0x040276B9 RID: 161465
		public const int BtnEnter = 0;

		// Token: 0x040276BA RID: 161466
		public const int TxtTitle = 1;

		// Token: 0x040276BB RID: 161467
		public const int MotorPartItemScroll = 2;

		// Token: 0x040276BC RID: 161468
		public const int Content = 3;

		// Token: 0x040276BD RID: 161469
		public const int MotorPartItem = 4;

		// Token: 0x040276BE RID: 161470
		public const int NewItem = 5;

		// Token: 0x040276BF RID: 161471
		public const int LockItem = 6;
	}
}
