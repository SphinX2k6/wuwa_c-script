using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022A4 RID: 8868
public class MotorcycleDiyDecoratePanel : UiPanelBase
{
	// Token: 0x06011589 RID: 71049 RVA: 0x0043D6B8 File Offset: 0x0043B8B8
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

	// Token: 0x0601158A RID: 71050 RVA: 0x0043D78D File Offset: 0x0043B98D
	protected override void OnStart()
	{
		this.PartBoxItemLayout = new GenericLayout<MotorcycleDiyOutlookBoxItem, MotorcycleDiyOutlookBoxItemData>(base.GetHorizontalLayout(3), new Func<MotorcycleDiyOutlookBoxItem>(this.CreatePartBoxItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
		this.SetEditable(true);
	}

	// Token: 0x0601158B RID: 71051 RVA: 0x0043D7C7 File Offset: 0x0043B9C7
	[NullableContext(1)]
	private MotorcycleDiyOutlookBoxItem CreatePartBoxItem()
	{
		return new MotorcycleDiyOutlookBoxItem();
	}

	// Token: 0x0601158C RID: 71052 RVA: 0x0043D7D0 File Offset: 0x0043B9D0
	[NullableContext(1)]
	public void Refresh(List<int> decorationIdList)
	{
		List<MotorcycleDiyOutlookBoxItemData> data = decorationIdList.Select((int id, int index) => new MotorcycleDiyOutlookBoxItemData(EOutlookType.Decoration, id, index)).ToList<MotorcycleDiyOutlookBoxItemData>();
		this.PartBoxItemLayout.RefreshByData(data, null, false);
		base.GetItem(5).SetUIActive(MotorcycleDiyModel.Instance.RedDotHasNewDecorationByAnyPartVisible());
	}

	// Token: 0x0601158D RID: 71053 RVA: 0x0043D82C File Offset: 0x0043BA2C
	public void SetEditable(bool isEditable)
	{
		base.GetItem(6).SetUIActive(!isEditable);
		base.GetItem(2).SetUIActive(isEditable);
	}

	// Token: 0x0601158E RID: 71054 RVA: 0x0043D84C File Offset: 0x0043BA4C
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

	// Token: 0x040083D6 RID: 33750
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleDiyOutlookBoxItem, MotorcycleDiyOutlookBoxItemData> PartBoxItemLayout;

	// Token: 0x020087F2 RID: 34802
	private class EMotorDecorateComponent
	{
		// Token: 0x0402C2E1 RID: 180961
		public const int BtnEnter = 0;

		// Token: 0x0402C2E2 RID: 180962
		public const int TxtTitle = 1;

		// Token: 0x0402C2E3 RID: 180963
		public const int MotorPartItemScroll = 2;

		// Token: 0x0402C2E4 RID: 180964
		public const int Content = 3;

		// Token: 0x0402C2E5 RID: 180965
		public const int MotorPartItem = 4;

		// Token: 0x0402C2E6 RID: 180966
		public const int NewItem = 5;

		// Token: 0x0402C2E7 RID: 180967
		public const int LockItem = 6;
	}
}
