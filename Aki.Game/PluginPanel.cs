using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A48 RID: 6728
[NullableContext(1)]
[Nullable(0)]
internal class PluginPanel : UiPanelBase
{
	// Token: 0x0600C606 RID: 50694 RVA: 0x002CFCAC File Offset: 0x002CDEAC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
	}

	// Token: 0x0600C607 RID: 50695 RVA: 0x002CFD8C File Offset: 0x002CDF8C
	protected override UniTask OnBeforeStartAsync()
	{
		PluginPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PluginPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C608 RID: 50696 RVA: 0x002CFDD0 File Offset: 0x002CDFD0
	public void Refresh()
	{
		int dangoId = this.ViewModel.GetDangoId();
		AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(dangoId);
		if (dangoAbyssRoleData == null)
		{
			return;
		}
		this.RefreshPlugin(dangoAbyssRoleData);
	}

	// Token: 0x0600C609 RID: 50697 RVA: 0x002CFE00 File Offset: 0x002CE000
	private void RefreshPlugin(AbyssDangoRoleData data)
	{
		foreach (KeyValuePair<int, DangoAbyssPluginItem> keyValuePair in this.PluginMap)
		{
			int key = keyValuePair.Key;
			DangoAbyssPluginItem value = keyValuePair.Value;
			AbyssDangoRoleSlotData pluginSlotData = data.GetPluginSlotData(key);
			value.Refresh(pluginSlotData);
		}
	}

	// Token: 0x04005B44 RID: 23364
	private readonly Dictionary<int, DangoAbyssPluginItem> PluginMap = new Dictionary<int, DangoAbyssPluginItem>();

	// Token: 0x04005B45 RID: 23365
	[Nullable(2)]
	public PluginEquipViewModel ViewModel;
}
