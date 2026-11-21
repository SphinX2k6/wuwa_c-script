using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014AB RID: 5291
[NullableContext(1)]
[Nullable(0)]
public class PhantomManageConfigSelectView : UiViewBase
{
	// Token: 0x0600D3E9 RID: 54249 RVA: 0x003F00C3 File Offset: 0x003EE2C3
	public PhantomManageConfigSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D3EA RID: 54250 RVA: 0x003F00CC File Offset: 0x003EE2CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickedClear));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickedConfirm));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D3EB RID: 54251 RVA: 0x003F01B6 File Offset: 0x003EE3B6
	protected override void OnBeforeCreate()
	{
		this.ViewData = (this.OpenParam as InventoryDefine.ISelectViewData);
	}

	// Token: 0x0600D3EC RID: 54252 RVA: 0x003F01CC File Offset: 0x003EE3CC
	protected override UniTask OnCreateAsync()
	{
		PhantomManageConfigSelectView.<OnCreateAsync>d__7 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<PhantomManageConfigSelectView.<OnCreateAsync>d__7>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D3ED RID: 54253 RVA: 0x003F0210 File Offset: 0x003EE410
	protected override void OnStart()
	{
		this.ItemGrid.SetUIParent(base.GetScrollViewWithScrollbar(0).ContentUIItem, false);
		this.Scroll = new GenericScrollViewNew<SelectGroup, InventoryDefine.ISelectGroupData>(base.GetScrollViewWithScrollbar(0), new Func<SelectGroup>(this.InitSelectGroup), this.ItemGrid.GetOwner() as AUIBaseActor, false, null);
		InventoryDefine.ISelectGroupData[] data = this.ConvertData();
		this.Scroll.RefreshByData(data, null, false);
	}

	// Token: 0x0600D3EE RID: 54254 RVA: 0x003F0280 File Offset: 0x003EE480
	private InventoryDefine.ISelectGroupData[] ConvertData()
	{
		InventoryDefine.ISelectViewData viewData = this.ViewData;
		int[] ruleIdList = viewData.RuleIdList;
		int filterId = viewData.FilterId;
		bool isSupportSelectAll = FilterConfig.Instance.GetFilterConfig(filterId).Value.IsSupportSelectAll;
		List<InventoryDefine.ISelectGroupData> list = new List<InventoryDefine.ISelectGroupData>();
		foreach (int num in ruleIdList)
		{
			FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(num);
			int[] array2;
			int[] valueList;
			if (viewData.ValueMap.TryGetValue(num, out array2))
			{
				valueList = array2;
			}
			else
			{
				valueList = Array.Empty<int>();
			}
			InventoryDefine.SelectGroupData item = new InventoryDefine.SelectGroupData
			{
				FilterId = filterId,
				FilterRuleId = num,
				HasSelectAll = isSupportSelectAll,
				NeedChangeColor = filterRuleConfig.Value.NeedChangeColor,
				ValueList = valueList
			};
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600D3EF RID: 54255 RVA: 0x003F035F File Offset: 0x003EE55F
	private SelectGroup InitSelectGroup()
	{
		return new SelectGroup();
	}

	// Token: 0x0600D3F0 RID: 54256 RVA: 0x003F0368 File Offset: 0x003EE568
	private Dictionary<int, int[]> GetAllSelectData()
	{
		List<SelectGroup> scrollItemList = this.Scroll.GetScrollItemList();
		Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
		foreach (SelectGroup selectGroup in scrollItemList)
		{
			int ruleId = selectGroup.GetRuleId();
			int[] selectValueList = selectGroup.GetSelectValueList();
			dictionary.Add(ruleId, selectValueList);
		}
		return dictionary;
	}

	// Token: 0x0600D3F1 RID: 54257 RVA: 0x003F03D4 File Offset: 0x003EE5D4
	private void OnClickedClear()
	{
		foreach (SelectGroup selectGroup in this.Scroll.GetScrollItemList())
		{
			selectGroup.ResetSelect();
		}
	}

	// Token: 0x0600D3F2 RID: 54258 RVA: 0x003F042C File Offset: 0x003EE62C
	private void OnClickedConfirm()
	{
		Dictionary<int, int[]> allSelectData = this.GetAllSelectData();
		this.ViewData.CallbackConfirm(allSelectData);
		base.CloseMe(null);
	}

	// Token: 0x04007725 RID: 30501
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericScrollViewNew<SelectGroup, InventoryDefine.ISelectGroupData> Scroll;

	// Token: 0x04007726 RID: 30502
	[Nullable(2)]
	private InventoryDefine.ISelectViewData ViewData;

	// Token: 0x04007727 RID: 30503
	[Nullable(2)]
	private UUIItem ItemGrid;

	// Token: 0x02007776 RID: 30582
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04026C90 RID: 158864
		Scroll,
		// Token: 0x04026C91 RID: 158865
		ClearButton,
		// Token: 0x04026C92 RID: 158866
		ConfirmButton
	}
}
