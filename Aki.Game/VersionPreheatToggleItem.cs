using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000A31 RID: 2609
internal class VersionPreheatToggleItem : UiPanelBase
{
	// Token: 0x0600710E RID: 28942 RVA: 0x0022AA28 File Offset: 0x00228C28
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.HandleOnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600710F RID: 28943 RVA: 0x0022AAD0 File Offset: 0x00228CD0
	private void HandleOnClick(EToggleState toggleState)
	{
		EventSystem.Instance.Emit<bool>(EEventName.VersionPreheatOnClickVote, this.PassData.ClickPassData);
		VersionPreheatVoteToggleData passData = this.PassData;
		passData.ClickFunc(passData.Id, passData.ClickPassData).Forget();
	}

	// Token: 0x06007110 RID: 28944 RVA: 0x0022AB1B File Offset: 0x00228D1B
	[NullableContext(1)]
	public void RefreshExternal(VersionPreheatVoteToggleData data)
	{
		this.PassData = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.ContentTextId, Array.Empty<object>());
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06007111 RID: 28945 RVA: 0x0022AB51 File Offset: 0x00228D51
	public void RefreshToggle(bool isChosen)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.SetToggleState(isChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		extendToggle.IsSelfInteractive = false;
	}

	// Token: 0x06007112 RID: 28946 RVA: 0x0022AB71 File Offset: 0x00228D71
	public void RefreshToggleDirectly(bool isChosen)
	{
		base.GetExtendToggle(0).SetToggleState(isChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400459D RID: 17821
	[Nullable(1)]
	private VersionPreheatVoteToggleData PassData;

	// Token: 0x02006D36 RID: 27958
	private class EToggleComponent
	{
		// Token: 0x04023DC3 RID: 146883
		public const int RootToggle = 0;

		// Token: 0x04023DC4 RID: 146884
		public const int ContentText = 1;
	}
}
