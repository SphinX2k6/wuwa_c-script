using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200147B RID: 5243
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManageConfigItem : GridProxyAbstract<PhantomManageConfigData>, IStaticVariableResetter
{
	// Token: 0x0600D20C RID: 53772 RVA: 0x003E5190 File Offset: 0x003E3390
	static PhantomManageConfigItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomManageConfigItem.CreateStaticDefaultValue), new Action(PhantomManageConfigItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600D20D RID: 53773 RVA: 0x003E51AF File Offset: 0x003E33AF
	public static void CreateStaticDefaultValue()
	{
		PhantomManageConfigItem.CallbackBtnSelect = null;
		PhantomManageConfigItem.ViewModel = null;
	}

	// Token: 0x0600D20E RID: 53774 RVA: 0x003E51BD File Offset: 0x003E33BD
	public static void ResetStaticDefaultValue()
	{
		PhantomManageConfigItem.CallbackBtnSelect = null;
		PhantomManageConfigItem.ViewModel = null;
	}

	// Token: 0x0600D20F RID: 53775 RVA: 0x003E51CC File Offset: 0x003E33CC
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

	// Token: 0x0600D210 RID: 53776 RVA: 0x003E52B4 File Offset: 0x003E34B4
	protected override void OnStart()
	{
		base.GetExtendToggle(3).CanExecuteChange.Bind(() => base.GetExtendToggle(3).GetToggleState() != EToggleState.ETT_Checked || !this.GetSelectState());
		this.Canvas = (base.GetRootActor().GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas);
	}

	// Token: 0x0600D211 RID: 53777 RVA: 0x003E52F4 File Offset: 0x003E34F4
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

	// Token: 0x0600D212 RID: 53778 RVA: 0x003E53A9 File Offset: 0x003E35A9
	[NullableContext(1)]
	public override object GetKey(PhantomManageConfigData data, int displayIndex)
	{
		return data.GetIndex();
	}

	// Token: 0x0600D213 RID: 53779 RVA: 0x003E53B6 File Offset: 0x003E35B6
	private void OnClickedBtnSelect(EToggleState toggleState)
	{
		if (this.Data != null && PhantomManageConfigItem.CallbackBtnSelect != null)
		{
			PhantomManageConfigItem.CallbackBtnSelect(this.Data);
		}
	}

	// Token: 0x0600D214 RID: 53780 RVA: 0x003E53D8 File Offset: 0x003E35D8
	private bool GetSelectState()
	{
		if (this.Data != null && PhantomManageConfigItem.ViewModel != null)
		{
			PhantomManageConfigData selectConfig = PhantomManageConfigItem.ViewModel.GetSelectConfig();
			return selectConfig.GetIndex() == this.Data.GetIndex() && this.Data.GetType() == selectConfig.GetType();
		}
		return false;
	}

	// Token: 0x0600D215 RID: 53781 RVA: 0x003E5429 File Offset: 0x003E3629
	private bool GetEditState()
	{
		return this.Data != null && PhantomManageConfigItem.ViewModel != null && PhantomManageConfigItem.ViewModel.GetEditState();
	}

	// Token: 0x04007679 RID: 30329
	private PhantomManageConfigData Data;

	// Token: 0x0400767A RID: 30330
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Action<PhantomManageConfigData> CallbackBtnSelect;

	// Token: 0x0400767B RID: 30331
	public static PhantomManageConfigViewModel ViewModel;

	// Token: 0x0400767C RID: 30332
	private ULGUICanvas Canvas;

	// Token: 0x02007743 RID: 30531
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04026BBB RID: 158651
		TextNumber,
		// Token: 0x04026BBC RID: 158652
		TextName,
		// Token: 0x04026BBD RID: 158653
		SpriteOn,
		// Token: 0x04026BBE RID: 158654
		BtnItem
	}
}
