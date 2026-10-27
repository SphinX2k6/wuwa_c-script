using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200175F RID: 5983
public class VisionRecoveryTabItem : GridProxyAbstract<EVisionRecoveryTabViewType>
{
	// Token: 0x0600AD2C RID: 44332 RVA: 0x0026EEDC File Offset: 0x0026D0DC
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

	// Token: 0x0600AD2D RID: 44333 RVA: 0x0026EF43 File Offset: 0x0026D143
	public override void Refresh(EVisionRecoveryTabViewType data, bool isSelected, int gridIndex)
	{
		this.Type = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), CalabashDefine.visionRecoveryTabViewTypeName[this.Type], Array.Empty<object>());
	}

	// Token: 0x0600AD2E RID: 44334 RVA: 0x0026EF72 File Offset: 0x0026D172
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<EVisionRecoveryTabViewType, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.Type, base.GetExtendToggle(0));
	}

	// Token: 0x0600AD2F RID: 44335 RVA: 0x0026EF91 File Offset: 0x0026D191
	public void SelectToggle()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x04004EBE RID: 20158
	private EVisionRecoveryTabViewType Type;

	// Token: 0x04004EBF RID: 20159
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<EVisionRecoveryTabViewType, UUIExtendToggle> OnClickToggleCallBack;

	// Token: 0x02007D4B RID: 32075
	private enum EComponent
	{
		// Token: 0x04029076 RID: 168054
		Toggle,
		// Token: 0x04029077 RID: 168055
		NameText
	}
}
