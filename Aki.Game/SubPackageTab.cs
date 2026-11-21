using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200202E RID: 8238
internal class SubPackageTab : GridProxyAbstract<int>
{
	// Token: 0x06014650 RID: 83536 RVA: 0x005F3D70 File Offset: 0x005F1F70
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

	// Token: 0x06014651 RID: 83537 RVA: 0x005F3DD8 File Offset: 0x005F1FD8
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

	// Token: 0x06014652 RID: 83538 RVA: 0x005F3E29 File Offset: 0x005F2029
	private void OnToggleClick(EToggleState state)
	{
		Action<UUIExtendToggle, int> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack(base.GetExtendToggle(0), this.CurrentType);
	}

	// Token: 0x06014653 RID: 83539 RVA: 0x005F3E48 File Offset: 0x005F2048
	public void SelectToggle()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x0400ACF7 RID: 44279
	private int CurrentType;

	// Token: 0x0400ACF8 RID: 44280
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickCallBack;
}
