using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002AB2 RID: 10930
internal class SubPackageTab : GridProxyAbstract<int>
{
	// Token: 0x06016C1F RID: 93215 RVA: 0x005C721C File Offset: 0x005C541C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06016C20 RID: 93216 RVA: 0x005C7284 File Offset: 0x005C5484
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		if (data == 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SubPackageDownLoad_Key_Tab", Array.Empty<object>());
		}
		if (data == 1)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SubPackageDownLoad_Expend_Tab", Array.Empty<object>());
		}
		this.CurrentType = data;
	}

	// Token: 0x06016C21 RID: 93217 RVA: 0x005C72D5 File Offset: 0x005C54D5
	private void OnToggleClick(EToggleState state)
	{
		Action<UUIExtendToggle, int> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack(base.GetExtendToggle(0), this.CurrentType);
	}

	// Token: 0x06016C22 RID: 93218 RVA: 0x005C72F4 File Offset: 0x005C54F4
	public void SelectToggle()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x0400A8F1 RID: 43249
	private int CurrentType;

	// Token: 0x0400A8F2 RID: 43250
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickCallBack;
}
