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

// Token: 0x02001501 RID: 5377
public class CommonKeySettingRowsPanel : UiPanelBase
{
	// Token: 0x0600D726 RID: 55078 RVA: 0x003FCC3B File Offset: 0x003FAE3B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600D727 RID: 55079 RVA: 0x003FCC74 File Offset: 0x003FAE74
	protected override UniTask OnBeforeStartAsync()
	{
		CommonKeySettingRowsPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonKeySettingRowsPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D728 RID: 55080 RVA: 0x003FCCB8 File Offset: 0x003FAEB8
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

	// Token: 0x0600D729 RID: 55081 RVA: 0x003FCD0A File Offset: 0x003FAF0A
	public void StopScroll()
	{
		base.GetUIDynScrollViewComponent(0).StopMovement();
	}

	// Token: 0x0600D72A RID: 55082 RVA: 0x003FCD18 File Offset: 0x003FAF18
	[NullableContext(1)]
	private CommonKeySettingRowContainerItem OnItemCreate(KeySettingRowData data, UUIItem uiItem, int index)
	{
		return new CommonKeySettingRowContainerItem();
	}

	// Token: 0x0400786F RID: 30831
	[Nullable(2)]
	private KeySettingRowBaseItem KeySettingRowBaseItem;

	// Token: 0x04007870 RID: 30832
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<CommonKeySettingRowContainerItem, KeySettingRowBaseItem, KeySettingRowData> DynamicScrollView;

	// Token: 0x020077B1 RID: 30641
	private static class EChildType
	{
		// Token: 0x04026D9D RID: 159133
		public const int DynamicScrollView = 0;

		// Token: 0x04026D9E RID: 159134
		public const int TemplateItem = 1;
	}
}
