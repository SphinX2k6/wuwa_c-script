using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001FB9 RID: 8121
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManageConfigItem : GridProxyAbstract<PhantomManageConfigData>, IStaticVariableResetter
{
	// Token: 0x0600FDE6 RID: 64998 RVA: 0x003D97B4 File Offset: 0x003D79B4
	static PhantomManageConfigItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomManageConfigItem.CreateStaticDefaultValue), new Action(PhantomManageConfigItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600FDE7 RID: 64999 RVA: 0x003D97D3 File Offset: 0x003D79D3
	public static void CreateStaticDefaultValue()
	{
		PhantomManageConfigItem.CallbackBtnSelect = null;
		PhantomManageConfigItem.ViewModel = null;
	}

	// Token: 0x0600FDE8 RID: 65000 RVA: 0x003D97E1 File Offset: 0x003D79E1
	public static void ResetStaticDefaultValue()
	{
		PhantomManageConfigItem.CallbackBtnSelect = null;
		PhantomManageConfigItem.ViewModel = null;
	}

	// Token: 0x0600FDE9 RID: 65001 RVA: 0x003D97F0 File Offset: 0x003D79F0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnClickedBtnSelect));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FDEA RID: 65002 RVA: 0x003D98D8 File Offset: 0x003D7AD8
	protected override void OnStart()
	{
		base.GetExtendToggle(3).CanExecuteChange.Bind(() => base.GetExtendToggle(3).GetToggleState() != EToggleState.ETT_Checked || !this.GetSelectState());
		this.Canvas = (base.GetRootActor().GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas);
	}

	// Token: 0x0600FDEB RID: 65003 RVA: 0x003D9918 File Offset: 0x003D7B18
	[NullableContext(1)]
	public override void Refresh(PhantomManageConfigData data, bool isSelected, int gridIndex)
	{
		data.SetDisplayIndex(base.DisplayIndex);
		this.Data = data;
		string indexString = data.GetIndexString();
		base.GetText(0).SetText(indexString, true);
		base.GetText(1).SetText(data.GetName(), true);
		base.GetSprite(2).SetUIActive(data.GetIsOn());
		bool selectState = this.GetSelectState();
		EToggleState state = selectState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		bool editState = this.GetEditState();
		base.GetExtendToggle(3).SetToggleState(state, false, false, false);
		base.GetExtendToggle(3).SetSelfInteractive(!editState);
		base.GetRootItem().SetBubbleUpToParent(!editState);
		this.Canvas.SetSortOrder((selectState && editState) ? 1 : 0, true);
	}

	// Token: 0x0600FDEC RID: 65004 RVA: 0x003D99CD File Offset: 0x003D7BCD
	[NullableContext(1)]
	public override object GetKey(PhantomManageConfigData data, int displayIndex)
	{
		return data.GetIndex();
	}

	// Token: 0x0600FDED RID: 65005 RVA: 0x003D99DA File Offset: 0x003D7BDA
	private void OnClickedBtnSelect(EToggleState toggleState)
	{
		if (this.Data != null && PhantomManageConfigItem.CallbackBtnSelect != null)
		{
			PhantomManageConfigItem.CallbackBtnSelect(this.Data);
		}
	}

	// Token: 0x0600FDEE RID: 65006 RVA: 0x003D99FC File Offset: 0x003D7BFC
	private bool GetSelectState()
	{
		if (this.Data != null && PhantomManageConfigItem.ViewModel != null)
		{
			PhantomManageConfigData selectConfig = PhantomManageConfigItem.ViewModel.GetSelectConfig();
			return selectConfig.GetIndex() == this.Data.GetIndex() && this.Data.GetType() == selectConfig.GetType();
		}
		return false;
	}

	// Token: 0x0600FDEF RID: 65007 RVA: 0x003D9A4D File Offset: 0x003D7C4D
	private bool GetEditState()
	{
		return this.Data != null && PhantomManageConfigItem.ViewModel != null && PhantomManageConfigItem.ViewModel.GetEditState();
	}

	// Token: 0x04007597 RID: 30103
	private PhantomManageConfigData Data;

	// Token: 0x04007598 RID: 30104
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Action<PhantomManageConfigData> CallbackBtnSelect;

	// Token: 0x04007599 RID: 30105
	public static PhantomManageConfigViewModel ViewModel;

	// Token: 0x0400759A RID: 30106
	private ULGUICanvas Canvas;

	// Token: 0x020085C1 RID: 34241
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B8B3 RID: 178355
		TextNumber,
		// Token: 0x0402B8B4 RID: 178356
		TextName,
		// Token: 0x0402B8B5 RID: 178357
		SpriteOn,
		// Token: 0x0402B8B6 RID: 178358
		BtnItem
	}
}
