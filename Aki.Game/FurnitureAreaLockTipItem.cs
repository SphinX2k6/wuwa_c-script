using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000FBD RID: 4029
public class FurnitureAreaLockTipItem : UiPanelBase
{
	// Token: 0x0600672B RID: 26411 RVA: 0x001465FC File Offset: 0x001447FC
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

	// Token: 0x0600672C RID: 26412 RVA: 0x00146679 File Offset: 0x00144879
	[NullableContext(1)]
	public void Refresh(string content, Action jumpCallback)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), content, Array.Empty<object>());
		this.JumpCallback = jumpCallback;
	}

	// Token: 0x0600672D RID: 26413 RVA: 0x00146699 File Offset: 0x00144899
	private void OnJumpButtonClick()
	{
		Action jumpCallback = this.JumpCallback;
		if (jumpCallback == null)
		{
			return;
		}
		jumpCallback();
	}

	// Token: 0x04002EC5 RID: 11973
	[Nullable(2)]
	private Action JumpCallback;
}
