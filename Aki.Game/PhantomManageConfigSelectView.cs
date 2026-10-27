using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FD8 RID: 8152
[NullableContext(1)]
[Nullable(0)]
public class PhantomManageConfigSelectView : UiViewBase
{
	// Token: 0x0600FF81 RID: 65409 RVA: 0x003E3ABF File Offset: 0x003E1CBF
	public PhantomManageConfigSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FF82 RID: 65410 RVA: 0x003E3AC8 File Offset: 0x003E1CC8
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

	// Token: 0x0600FF83 RID: 65411 RVA: 0x003E3BB2 File Offset: 0x003E1DB2
	protected override void OnBeforeCreate()
	{
		this.ViewData = (this.OpenParam as InventoryDefine.ISelectViewData);
	}

	// Token: 0x0600FF84 RID: 65412 RVA: 0x003E3BC8 File Offset: 0x003E1DC8
	protected override UniTask OnCreateAsync()
	{
		PhantomManageConfigSelectView.<OnCreateAsync>d__7 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<PhantomManageConfigSelectView.<OnCreateAsync>d__7>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FF85 RID: 65413 RVA: 0x003E3C0C File Offset: 0x003E1E0C
	protected override void OnStart()
	{
		this.ItemGrid.SetUIParent(base.GetScrollViewWithScrollbar(0).ContentUIItem, false);
		this.Scroll = new GenericScrollViewNew<SelectGroup, InventoryDefine.ISelectGroupData>(base.GetScrollViewWithScrollbar(0), new Func<SelectGroup>(this.InitSelectGroup), this.ItemGrid.GetOwner() as AUIBaseActor, false, null);
		InventoryDefine.ISelectGroupData[] source = this.ConvertData();
		this.Scroll.RefreshByData(source.ToList<InventoryDefine.ISelectGroupData>(), null, false);
	}

	// Token: 0x0600FF86 RID: 65414 RVA: 0x003E3C80 File Offset: 0x003E1E80
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

	// Token: 0x0600FF87 RID: 65415 RVA: 0x003E3D5F File Offset: 0x003E1F5F
	private SelectGroup InitSelectGroup()
	{
		return new SelectGroup();
	}

	// Token: 0x0600FF88 RID: 65416 RVA: 0x003E3D68 File Offset: 0x003E1F68
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

	// Token: 0x0600FF89 RID: 65417 RVA: 0x003E3DD4 File Offset: 0x003E1FD4
	private void OnClickedClear()
	{
		foreach (SelectGroup selectGroup in this.Scroll.GetScrollItemList())
		{
			selectGroup.ResetSelect();
		}
	}

	// Token: 0x0600FF8A RID: 65418 RVA: 0x003E3E2C File Offset: 0x003E202C
	private void OnClickedConfirm()
	{
		Dictionary<int, int[]> allSelectData = this.GetAllSelectData();
		this.ViewData.CallbackConfirm(allSelectData);
		base.CloseMe(null);
	}

	// Token: 0x0400763C RID: 30268
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericScrollViewNew<SelectGroup, InventoryDefine.ISelectGroupData> Scroll;

	// Token: 0x0400763D RID: 30269
	[Nullable(2)]
	private InventoryDefine.ISelectViewData ViewData;

	// Token: 0x0400763E RID: 30270
	[Nullable(2)]
	private UUIItem ItemGrid;

	// Token: 0x020085EF RID: 34287
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B981 RID: 178561
		Scroll,
		// Token: 0x0402B982 RID: 178562
		ClearButton,
		// Token: 0x0402B983 RID: 178563
		ConfirmButton
	}
}
