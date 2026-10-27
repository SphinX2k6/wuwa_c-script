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

// Token: 0x0200249F RID: 9375
[NullableContext(2)]
[Nullable(0)]
public class VisionDetailTop : UiPanelBase
{
	// Token: 0x06012D26 RID: 77094 RVA: 0x004A551F File Offset: 0x004A371F
	[NullableContext(1)]
	public VisionDetailTop(UUIItem actor)
	{
		this.SourceItem = actor;
	}

	// Token: 0x06012D27 RID: 77095 RVA: 0x004A5530 File Offset: 0x004A3730
	public UniTask Init()
	{
		VisionDetailTop.<Init>d__5 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionDetailTop.<Init>d__5>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06012D28 RID: 77096 RVA: 0x004A5574 File Offset: 0x004A3774
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

	// Token: 0x06012D29 RID: 77097 RVA: 0x004A56E2 File Offset: 0x004A38E2
	protected void OnClickLockToggle(EToggleState toggleState)
	{
		InventoryController.Instance.ItemLockRequest(this.CurrentData.GetUniqueId(), !this.CurrentData.GetIsLock());
	}

	// Token: 0x06012D2A RID: 77098 RVA: 0x004A5707 File Offset: 0x004A3907
	protected void OnClickDeprecateToggle(EToggleState toggleState)
	{
		InventoryController.Instance.ItemDeprecateRequest(this.CurrentData.GetUniqueId(), !this.CurrentData.GetIsDeprecated());
	}

	// Token: 0x06012D2B RID: 77099 RVA: 0x004A572C File Offset: 0x004A392C
	protected override UniTask OnBeforeStartAsync()
	{
		VisionDetailTop.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionDetailTop.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012D2C RID: 77100 RVA: 0x004A576F File Offset: 0x004A396F
	protected override void OnStart()
	{
		this.VisionNameText = new VisionNameText(base.GetText(0));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshToggle));
	}

	// Token: 0x06012D2D RID: 77101 RVA: 0x004A57A0 File Offset: 0x004A39A0
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

	// Token: 0x06012D2E RID: 77102 RVA: 0x004A5814 File Offset: 0x004A3A14
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

	// Token: 0x06012D2F RID: 77103 RVA: 0x004A58AE File Offset: 0x004A3AAE
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshToggle));
	}

	// Token: 0x04008DC6 RID: 36294
	private PhantomBattleData CurrentData;

	// Token: 0x04008DC7 RID: 36295
	private VisionNameText VisionNameText;

	// Token: 0x04008DC8 RID: 36296
	private readonly UUIItem SourceItem;

	// Token: 0x04008DC9 RID: 36297
	private VisionFetterSuitItem VisionFetterSuitItem;
}
