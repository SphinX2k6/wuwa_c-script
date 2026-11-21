using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001986 RID: 6534
[NullableContext(2)]
[Nullable(0)]
public class VisionDetailTop : UiPanelBase
{
	// Token: 0x060101E7 RID: 66023 RVA: 0x004B3027 File Offset: 0x004B1227
	[NullableContext(1)]
	public VisionDetailTop(UUIItem actor)
	{
		this.SourceItem = actor;
	}

	// Token: 0x060101E8 RID: 66024 RVA: 0x004B3038 File Offset: 0x004B1238
	public UniTask Init()
	{
		VisionDetailTop.<Init>d__5 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionDetailTop.<Init>d__5>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060101E9 RID: 66025 RVA: 0x004B307C File Offset: 0x004B127C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickLockToggle));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickDeprecateToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060101EA RID: 66026 RVA: 0x004B31EA File Offset: 0x004B13EA
	protected void OnClickLockToggle(EToggleState toggleState)
	{
		InventoryController.Instance.ItemLockRequest(this.CurrentData.GetUniqueId(), !this.CurrentData.GetIsLock());
	}

	// Token: 0x060101EB RID: 66027 RVA: 0x004B320F File Offset: 0x004B140F
	protected void OnClickDeprecateToggle(EToggleState toggleState)
	{
		InventoryController.Instance.ItemDeprecateRequest(this.CurrentData.GetUniqueId(), !this.CurrentData.GetIsDeprecated());
	}

	// Token: 0x060101EC RID: 66028 RVA: 0x004B3234 File Offset: 0x004B1434
	protected override UniTask OnBeforeStartAsync()
	{
		VisionDetailTop.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionDetailTop.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060101ED RID: 66029 RVA: 0x004B3277 File Offset: 0x004B1477
	protected override void OnStart()
	{
		this.VisionNameText = new VisionNameText(base.GetText(0));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshToggle));
	}

	// Token: 0x060101EE RID: 66030 RVA: 0x004B32A8 File Offset: 0x004B14A8
	private void RefreshToggle(int incId)
	{
		PhantomBattleData currentData = this.CurrentData;
		if (currentData == null || currentData.GetUniqueId() != incId)
		{
			return;
		}
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(incId);
		if (attributeItemData == null)
		{
			return;
		}
		EToggleState state = attributeItemData.GetIsLock() ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		base.GetExtendToggle(1).SetToggleState(state, false, false, false);
		EToggleState state2 = attributeItemData.GetIsDeprecated() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(6).SetToggleState(state2, false, false, false);
	}

	// Token: 0x060101EF RID: 66031 RVA: 0x004B331C File Offset: 0x004B151C
	[NullableContext(1)]
	public void Update(PhantomBattleData data)
	{
		this.CurrentData = data;
		this.VisionNameText.Update(data);
		base.GetText(4).SetText(data.GetCost().ToString(), true);
		base.GetText(2).SetText(StringUtils.Format("+{0}", new string[]
		{
			data.GetPhantomLevel().ToString()
		}), true);
		base.GetText(2).SetUIActive(true);
		this.RefreshToggle(data.GetUniqueId());
		PhantomFetterGroup fetterGroupConfig = data.GetFetterGroupConfig();
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupConfig));
	}

	// Token: 0x060101F0 RID: 66032 RVA: 0x004B33B6 File Offset: 0x004B15B6
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshToggle));
	}

	// Token: 0x04008F10 RID: 36624
	private PhantomBattleData CurrentData;

	// Token: 0x04008F11 RID: 36625
	private VisionNameText VisionNameText;

	// Token: 0x04008F12 RID: 36626
	private readonly UUIItem SourceItem;

	// Token: 0x04008F13 RID: 36627
	private VisionFetterSuitItem VisionFetterSuitItem;
}
