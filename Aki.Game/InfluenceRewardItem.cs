using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.ItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200144A RID: 5194
public class InfluenceRewardItem : UiPanelBase
{
	// Token: 0x0600CEA0 RID: 52896 RVA: 0x003D6E43 File Offset: 0x003D5043
	[NullableContext(1)]
	public InfluenceRewardItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600CEA1 RID: 52897 RVA: 0x003D6E58 File Offset: 0x003D5058
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CEA2 RID: 52898 RVA: 0x003D6EC1 File Offset: 0x003D50C1
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<CommonItemSimpleGridExFinish>(base.GetLayoutBase(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSimpleGridExFinish>(this.InitItem), null);
	}

	// Token: 0x0600CEA3 RID: 52899 RVA: 0x003D6EE4 File Offset: 0x003D50E4
	[NullableContext(1)]
	private ILayoutItem<CommonItemSimpleGridExFinish> InitItem(object data, UUIItem uiItem, int index)
	{
		CommonItemSimpleGridExFinish commonItemSimpleGridExFinish = new CommonItemSimpleGridExFinish(uiItem.GetOwner());
		ValueTuple<int, int> valueTuple = (ValueTuple<int, int>)data;
		int item = valueTuple.Item1;
		int item2 = valueTuple.Item2;
		commonItemSimpleGridExFinish.RefreshItem(item, item2);
		commonItemSimpleGridExFinish.SetReceived(this.IsReceived);
		return new LayoutItem<CommonItemSimpleGridExFinish>
		{
			Key = index,
			Value = commonItemSimpleGridExFinish
		};
	}

	// Token: 0x0600CEA4 RID: 52900 RVA: 0x003D6F3C File Offset: 0x003D513C
	protected override void OnBeforeDestroy()
	{
		this.Layout.ClearChildren();
		this.Layout = null;
	}

	// Token: 0x0600CEA5 RID: 52901 RVA: 0x003D6F50 File Offset: 0x003D5150
	public void UpdateItem(IntPair rewardData, bool isReceived)
	{
		this.IsReceived = isReceived;
		this.SetRewardTitle(rewardData.Item1);
		List<ValueTuple<int, int>> rewardList = InfluenceReputationModel.Instance.GetRewardList(rewardData.Item2);
		this.Layout.RebuildLayoutByDataNew<ValueTuple<int, int>>(rewardList, null);
	}

	// Token: 0x0600CEA6 RID: 52902 RVA: 0x003D6F98 File Offset: 0x003D5198
	private void SetRewardTitle(int reputationValue)
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalText(text, "ReputationReceive", new <>z__ReadOnlySingleElementList<object>(reputationValue));
	}

	// Token: 0x0600CEA7 RID: 52903 RVA: 0x003D6FC8 File Offset: 0x003D51C8
	public void SetAllReceivedTitle()
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalText(text, "ReputationAllReceived", Array.Empty<object>());
	}

	// Token: 0x0400758C RID: 30092
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<CommonItemSimpleGridExFinish> Layout;

	// Token: 0x0400758D RID: 30093
	private bool IsReceived;

	// Token: 0x020076F7 RID: 30455
	private enum EInfluenceRewardItem
	{
		// Token: 0x04026A5C RID: 158300
		Title,
		// Token: 0x04026A5D RID: 158301
		Layout
	}
}
