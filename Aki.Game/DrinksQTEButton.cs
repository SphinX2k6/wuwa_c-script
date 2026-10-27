using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F63 RID: 3939
public class DrinksQTEButton : UiPanelBase
{
	// Token: 0x060064D0 RID: 25808 RVA: 0x0013FFE8 File Offset: 0x0013E1E8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickedBtn))
		};
	}

	// Token: 0x060064D1 RID: 25809 RVA: 0x0014004F File Offset: 0x0013E24F
	protected override void OnStart()
	{
		this.SetSelfActive(true);
	}

	// Token: 0x060064D2 RID: 25810 RVA: 0x00140058 File Offset: 0x0013E258
	public void SetSelfActive(bool isActive)
	{
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetFillAmount(isActive > false);
		}
		this.CanClick = isActive;
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(isActive);
	}

	// Token: 0x060064D3 RID: 25811 RVA: 0x0014008A File Offset: 0x0013E28A
	public void OnTick(float percent)
	{
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetFillAmount(Math.Max(0f, percent));
		}
		if (percent <= 0f)
		{
			this.OnClickedBtn();
		}
	}

	// Token: 0x060064D4 RID: 25812 RVA: 0x001400B7 File Offset: 0x0013E2B7
	public void OnClickedBtn()
	{
		if (this.OnClickedCb != null && this.CanClick)
		{
			this.CanClick = false;
			this.OnClickedCb();
		}
	}

	// Token: 0x04002DC3 RID: 11715
	[Nullable(2)]
	public Action OnClickedCb;

	// Token: 0x04002DC4 RID: 11716
	protected bool CanClick;

	// Token: 0x020075B0 RID: 30128
	private static class EBtn
	{
		// Token: 0x04026E5F RID: 159327
		public const int Btn = 0;

		// Token: 0x04026E60 RID: 159328
		public const int SpriteBar = 1;
	}
}
