using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000C18 RID: 3096
public class VisionRecoveryTabItem : GridProxyAbstract<EVisionRecoveryTabViewType>
{
	// Token: 0x06008113 RID: 33043 RVA: 0x00279350 File Offset: 0x00277550
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06008114 RID: 33044 RVA: 0x002793B7 File Offset: 0x002775B7
	public override void Refresh(EVisionRecoveryTabViewType data, bool isSelected, int gridIndex)
	{
		this.Type = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), CalabashDefine.visionRecoveryTabViewTypeName[this.Type], Array.Empty<object>());
	}

	// Token: 0x06008115 RID: 33045 RVA: 0x002793E6 File Offset: 0x002775E6
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<EVisionRecoveryTabViewType, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.Type, base.GetExtendToggle(0));
	}

	// Token: 0x06008116 RID: 33046 RVA: 0x00279405 File Offset: 0x00277605
	public void SelectToggle()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x04004F67 RID: 20327
	private EVisionRecoveryTabViewType Type;

	// Token: 0x04004F68 RID: 20328
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<EVisionRecoveryTabViewType, UUIExtendToggle> OnClickToggleCallBack;

	// Token: 0x02006ED1 RID: 28369
	private enum EComponent
	{
		// Token: 0x040243A1 RID: 148385
		Toggle,
		// Token: 0x040243A2 RID: 148386
		NameText
	}
}
