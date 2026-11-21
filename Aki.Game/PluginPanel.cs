using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F07 RID: 3847
[NullableContext(1)]
[Nullable(0)]
internal class PluginPanel : UiPanelBase
{
	// Token: 0x06009A16 RID: 39446 RVA: 0x002DADA8 File Offset: 0x002D8FA8
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

	// Token: 0x06009A17 RID: 39447 RVA: 0x002DAE88 File Offset: 0x002D9088
	protected override UniTask OnBeforeStartAsync()
	{
		PluginPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PluginPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009A18 RID: 39448 RVA: 0x002DAECC File Offset: 0x002D90CC
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

	// Token: 0x06009A19 RID: 39449 RVA: 0x002DAEFC File Offset: 0x002D90FC
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

	// Token: 0x04005C13 RID: 23571
	private readonly Dictionary<int, DangoAbyssPluginItem> PluginMap = new Dictionary<int, DangoAbyssPluginItem>();

	// Token: 0x04005C14 RID: 23572
	[Nullable(2)]
	public PluginEquipViewModel ViewModel;
}
