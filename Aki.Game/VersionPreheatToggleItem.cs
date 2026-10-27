using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001579 RID: 5497
internal class VersionPreheatToggleItem : UiPanelBase
{
	// Token: 0x06009D30 RID: 40240 RVA: 0x00220C78 File Offset: 0x0021EE78
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

	// Token: 0x06009D31 RID: 40241 RVA: 0x00220D20 File Offset: 0x0021EF20
	private void HandleOnClick(EToggleState toggleState)
	{
		EventSystem.Instance.Emit<bool>(EEventName.VersionPreheatOnClickVote, this.PassData.ClickPassData);
		VersionPreheatVoteToggleData passData = this.PassData;
		passData.ClickFunc(passData.Id, passData.ClickPassData).Forget();
	}

	// Token: 0x06009D32 RID: 40242 RVA: 0x00220D6B File Offset: 0x0021EF6B
	[NullableContext(1)]
	public void RefreshExternal(VersionPreheatVoteToggleData data)
	{
		this.PassData = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.ContentTextId, Array.Empty<object>());
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06009D33 RID: 40243 RVA: 0x00220DA1 File Offset: 0x0021EFA1
	public void RefreshToggle(bool isChosen)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.SetToggleState(isChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		extendToggle.IsSelfInteractive = false;
	}

	// Token: 0x06009D34 RID: 40244 RVA: 0x00220DC1 File Offset: 0x0021EFC1
	public void RefreshToggleDirectly(bool isChosen)
	{
		base.GetExtendToggle(0).SetToggleState(isChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x040044F7 RID: 17655
	[Nullable(1)]
	private VersionPreheatVoteToggleData PassData;

	// Token: 0x02007BAB RID: 31659
	private class EToggleComponent
	{
		// Token: 0x04028A88 RID: 166536
		public const int RootToggle = 0;

		// Token: 0x04028A89 RID: 166537
		public const int ContentText = 1;
	}
}
