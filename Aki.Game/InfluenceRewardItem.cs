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

// Token: 0x02001F88 RID: 8072
public class InfluenceRewardItem : UiPanelBase
{
	// Token: 0x0600FA81 RID: 64129 RVA: 0x003CB30B File Offset: 0x003C950B
	[NullableContext(1)]
	public InfluenceRewardItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600FA82 RID: 64130 RVA: 0x003CB320 File Offset: 0x003C9520
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

	// Token: 0x0600FA83 RID: 64131 RVA: 0x003CB389 File Offset: 0x003C9589
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<CommonItemSimpleGridExFinish>(base.GetLayoutBase(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSimpleGridExFinish>(this.InitItem), null);
	}

	// Token: 0x0600FA84 RID: 64132 RVA: 0x003CB3AC File Offset: 0x003C95AC
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

	// Token: 0x0600FA85 RID: 64133 RVA: 0x003CB404 File Offset: 0x003C9604
	protected override void OnBeforeDestroy()
	{
		this.Layout.ClearChildren();
		this.Layout = null;
	}

	// Token: 0x0600FA86 RID: 64134 RVA: 0x003CB418 File Offset: 0x003C9618
	public void UpdateItem(IntPair rewardData, bool isReceived)
	{
		this.IsReceived = isReceived;
		this.SetRewardTitle(rewardData.Item1);
		List<ValueTuple<int, int>> rewardList = InfluenceReputationModel.Instance.GetRewardList(rewardData.Item2);
		this.Layout.RebuildLayoutByDataNew<ValueTuple<int, int>>(rewardList, null);
	}

	// Token: 0x0600FA87 RID: 64135 RVA: 0x003CB460 File Offset: 0x003C9660
	private void SetRewardTitle(int reputationValue)
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalText(text, "ReputationReceive", new <>z__ReadOnlySingleElementList<object>(reputationValue));
	}

	// Token: 0x0600FA88 RID: 64136 RVA: 0x003CB490 File Offset: 0x003C9690
	public void SetAllReceivedTitle()
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalText(text, "ReputationAllReceived", Array.Empty<object>());
	}

	// Token: 0x040074AB RID: 29867
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<CommonItemSimpleGridExFinish> Layout;

	// Token: 0x040074AC RID: 29868
	private bool IsReceived;

	// Token: 0x02008572 RID: 34162
	private enum EInfluenceRewardItem
	{
		// Token: 0x0402B739 RID: 177977
		Title,
		// Token: 0x0402B73A RID: 177978
		Layout
	}
}
