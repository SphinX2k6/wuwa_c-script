using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001788 RID: 6024
public class MotorcycleDiyDecoratePanel : UiPanelBase
{
	// Token: 0x0600EA21 RID: 59937 RVA: 0x0044A2B0 File Offset: 0x004484B0
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

	// Token: 0x0600EA22 RID: 59938 RVA: 0x0044A385 File Offset: 0x00448585
	protected override void OnStart()
	{
		this.PartBoxItemLayout = new GenericLayout<MotorcycleDiyOutlookBoxItem, MotorcycleDiyOutlookBoxItemData>(base.GetHorizontalLayout(3), new Func<MotorcycleDiyOutlookBoxItem>(this.CreatePartBoxItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
		this.SetEditable(true);
	}

	// Token: 0x0600EA23 RID: 59939 RVA: 0x0044A3BF File Offset: 0x004485BF
	[NullableContext(1)]
	private MotorcycleDiyOutlookBoxItem CreatePartBoxItem()
	{
		return new MotorcycleDiyOutlookBoxItem();
	}

	// Token: 0x0600EA24 RID: 59940 RVA: 0x0044A3C8 File Offset: 0x004485C8
	[NullableContext(1)]
	public void Refresh(List<int> decorationIdList)
	{
		List<MotorcycleDiyOutlookBoxItemData> list = new List<MotorcycleDiyOutlookBoxItemData>(decorationIdList.Count);
		for (int i = 0; i < decorationIdList.Count; i++)
		{
			list.Add(new MotorcycleDiyOutlookBoxItemData(EOutlookType.Decoration, decorationIdList[i], i));
		}
		this.PartBoxItemLayout.RefreshByData(list, null, false);
		base.GetItem(5).SetUIActive(MotorcycleDiyModel.Instance.RedDotHasNewDecorationByAnyPartVisible());
	}

	// Token: 0x0600EA25 RID: 59941 RVA: 0x0044A42A File Offset: 0x0044862A
	public void SetEditable(bool isEditable)
	{
		base.GetItem(6).SetUIActive(!isEditable);
		base.GetItem(2).SetUIActive(isEditable);
	}

	// Token: 0x0600EA26 RID: 59942 RVA: 0x0044A44C File Offset: 0x0044864C
	private void OnBtnEnterClick()
	{
		MotorcycleDiyModel.Instance.ResetSelectedItemInfo();
		OpenMotorcycleDiyRootViewData param = new OpenMotorcycleDiyRootViewData
		{
			OpenTabView = new EUiTabViewName?(EUiTabViewName.MotorcycleDiyDecorationTabView),
			PartTabIndex = new int?(1),
			IsNeedResetMotor = new bool?(true)
		};
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyRootView, param, null);
	}

	// Token: 0x04008514 RID: 34068
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleDiyOutlookBoxItem, MotorcycleDiyOutlookBoxItemData> PartBoxItemLayout;

	// Token: 0x0200797B RID: 31099
	private class EMotorDecorateComponent
	{
		// Token: 0x040275ED RID: 161261
		public const int BtnEnter = 0;

		// Token: 0x040275EE RID: 161262
		public const int TxtTitle = 1;

		// Token: 0x040275EF RID: 161263
		public const int MotorPartItemScroll = 2;

		// Token: 0x040275F0 RID: 161264
		public const int Content = 3;

		// Token: 0x040275F1 RID: 161265
		public const int MotorPartItem = 4;

		// Token: 0x040275F2 RID: 161266
		public const int NewItem = 5;

		// Token: 0x040275F3 RID: 161267
		public const int LockItem = 6;
	}
}
