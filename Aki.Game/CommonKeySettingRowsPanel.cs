using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Menu.KeySettingsView;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200202E RID: 8238
public class CommonKeySettingRowsPanel : UiPanelBase
{
	// Token: 0x060102BE RID: 66238 RVA: 0x003F0643 File Offset: 0x003EE843
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060102BF RID: 66239 RVA: 0x003F067C File Offset: 0x003EE87C
	protected override UniTask OnBeforeStartAsync()
	{
		CommonKeySettingRowsPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonKeySettingRowsPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060102C0 RID: 66240 RVA: 0x003F06C0 File Offset: 0x003EE8C0
	[NullableContext(1)]
	public void Refresh(List<KeySettingRowData> dataList, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		for (int i = 0; i < dataList.Count; i++)
		{
			dataList[i].IsExpandDetail = false;
		}
		KeySettingRowData[] array = new KeySettingRowData[dataList.Count];
		dataList.CopyTo(array, 0);
		DynamicScrollView<CommonKeySettingRowContainerItem, KeySettingRowBaseItem, KeySettingRowData> dynamicScrollView = this.DynamicScrollView;
		if (dynamicScrollView == null)
		{
			return;
		}
		dynamicScrollView.RefreshByData(array, false, false);
	}

	// Token: 0x060102C1 RID: 66241 RVA: 0x003F0712 File Offset: 0x003EE912
	public void StopScroll()
	{
		base.GetUIDynScrollViewComponent(0).StopMovement();
	}

	// Token: 0x060102C2 RID: 66242 RVA: 0x003F0720 File Offset: 0x003EE920
	[NullableContext(1)]
	private CommonKeySettingRowContainerItem OnItemCreate(KeySettingRowData data, UUIItem uiItem, int index)
	{
		return new CommonKeySettingRowContainerItem();
	}

	// Token: 0x04007786 RID: 30598
	[Nullable(2)]
	private KeySettingRowBaseItem KeySettingRowBaseItem;

	// Token: 0x04007787 RID: 30599
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<CommonKeySettingRowContainerItem, KeySettingRowBaseItem, KeySettingRowData> DynamicScrollView;

	// Token: 0x0200862A RID: 34346
	private static class EChildType
	{
		// Token: 0x0402BA8E RID: 178830
		public const int DynamicScrollView = 0;

		// Token: 0x0402BA8F RID: 178831
		public const int TemplateItem = 1;
	}
}
