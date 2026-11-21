using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000472 RID: 1138
public class FurnitureAreaLockTipItem : UiPanelBase
{
	// Token: 0x06003AC3 RID: 15043 RVA: 0x0014EEC0 File Offset: 0x0014D0C0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnJumpButtonClick))
		};
	}

	// Token: 0x06003AC4 RID: 15044 RVA: 0x0014EF3D File Offset: 0x0014D13D
	[NullableContext(1)]
	public void Refresh(string content, Action jumpCallback)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), content, Array.Empty<object>());
		this.JumpCallback = jumpCallback;
	}

	// Token: 0x06003AC5 RID: 15045 RVA: 0x0014EF5D File Offset: 0x0014D15D
	private void OnJumpButtonClick()
	{
		Action jumpCallback = this.JumpCallback;
		if (jumpCallback == null)
		{
			return;
		}
		jumpCallback();
	}

	// Token: 0x04002F5E RID: 12126
	[Nullable(2)]
	private Action JumpCallback;
}
